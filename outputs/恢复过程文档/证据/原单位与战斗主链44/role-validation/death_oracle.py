"""Run original Dead.MoveNext through initial, pending, and resumed paths."""
import native_oracle as n
from pathlib import Path
import json,struct
from unicorn import UC_HOOK_CODE
import unicorn.arm64_const as a
cpu=n.cpu;wr=n.wr;qw=n.qw;iw=n.iw;fb=n.fbits;OWN=Path(__file__).resolve().parent
SELF,PROP,STOP,STACK=n.SELF,n.PROP,n.STOP,n.STACK
CLASS,STATIC,STATE,ANIM,AC,TASK,TC,CONFIG,HEX,AB= [0x14000000+i*0x1000 for i in range(10)]
STOPLISTEN,CALLBACK,LENGTH,STATUS,RESULT=[0x30002000+i*0x10 for i in range(5)]
DESC_LENGTH,DESC_STATUS,DESC_RESULT=[0x14010000+i*0x1000 for i in range(3)]
ARENA1,ARENA2,OTHER=0x16000000,0x16001000,0x16002000
for ptr in [CLASS,STATIC,STATE,ANIM,AC,TASK,TC,CONFIG,HEX,AB,DESC_LENGTH,DESC_STATUS,DESC_RESULT]:wr(ptr,bytes(0x1000))
iw(CLASS+0xe0,1);qw(CLASS+184,STATIC);qw(ANIM,AC);qw(TASK,TC)
qw(CLASS+728,STOPLISTEN);qw(CLASS+744,CALLBACK)
for desc,fn in [(DESC_LENGTH,LENGTH),(DESC_STATUS,STATUS),(DESC_RESULT,RESULT)]:qw(desc,fn)
for slot,value in [(0x8ceb3e0,CLASS),(0x8ce5e20,CLASS),(0x8ce1928,CLASS),(0x8ceedf8,CLASS),(0x8d536b8,ARENA1),(0x8d53708,ARENA2)]:qw(slot,value)
for flag in [0x8ffd4bf,0x8ffd1ab,0x8ffd3a7,0x8ffd1ad,0x8ffd1ae,0x8ffd1af]:wr(flag,b'\x01')
hooks={0x82ebc6c:'ne',0x3d7fa30:'path',0x4429ae8:'hex-remove',0x46a78c8:'kill-tween',0x5978460:'manager',0x3f05f64:'event',0x3d912e8:'subgame',0x3d9135c:'friendly-dead',0x3d8bc2c:'remove-ui',0x5fbeb64:'ab-instance',0x3f7257c:'ab',0x3e4bde0:'bless',0x3d91430:'modify-coin',0x3c3d3b8:'box',0x7501e3c:'format',0x4273760:'cointext',0x3de3cf4:'player-coin',0x41966f0:'config',0x74fe874:'str-eq',0x3dd3ec4:'ai-coin',0x3d7f628:'animation',0x3d7ab7c:'can-move',0x3df7b40:'remove-enemy',0x3df6e88:'remove-player',0x3e0d2e8:'unbind',0x75b0140:'set-result',0x7d7545c:'wait',0x4accd54:'await',0x3c504a4:'interface',STOPLISTEN:'stop-listen',CALLBACK:'callback',LENGTH:'length',STATUS:'status',RESULT:'result',0x75b02a4:'exception'}
for pc in hooks:n.page(pc&~0xfff)
trace=[];sc={};phase=0
def read_i(p):return struct.unpack('<i',cpu.mem_read(p,4))[0]
def hook(uc,pc,sz,data):
    tag=hooks.get(pc)
    if tag is None:return
    xs=[cpu.reg_read(getattr(a,'UC_ARM64_REG_X'+str(i))) for i in range(5)];out=0
    if tag in ['ne','str-eq']:out=int(xs[0]!=xs[1]) if tag=='ne' else int(xs[0]==xs[1])
    elif tag in ['manager','subgame','ab-instance']:out=AB
    elif tag=='ab':out=int(sc['ab']);trace.append('ab')
    elif tag=='path':trace.append('path:'+str(bool(xs[1])).lower())
    elif tag=='hex-remove':assert xs[1]==7 and bool(xs[2])==(not sc['enemy']);trace.append('hex-remove')
    elif tag=='kill-tween':trace.append('kill-tween')
    elif tag=='event':trace.append('event')
    elif tag=='friendly-dead':assert bool(xs[1])==sc['enemy'];trace.append('friendly-dead')
    elif tag=='remove-ui':trace.append('remove-ui')
    elif tag=='bless':assert bool(xs[1])==sc['enemy'];out=sc['bless'];trace.append('bless')
    elif tag=='modify-coin':
        assert bool(xs[2])==sc['enemy'];iw(xs[1],read_i(xs[1])+sc['buff']);trace.append('modify-coin')
    elif tag=='box':out=OTHER
    elif tag=='format':out=OTHER
    elif tag=='cointext':trace.append('cointext')
    elif tag=='player-coin':trace.append('player-coin:'+str(read_i(STATE+100) if False else struct.unpack('<i',struct.pack('<I',xs[1]&0xffffffff))[0]))
    elif tag=='ai-coin':trace.append('ai-coin:'+str(struct.unpack('<i',struct.pack('<I',xs[1]&0xffffffff))[0]))
    elif tag=='config':out=CONFIG
    elif tag=='animation':assert xs[1:3]==[2,1];trace.append('animation')
    elif tag=='can-move':assert not xs[1];trace.append('can-move')
    elif tag=='remove-enemy':assert xs[2]==1;trace.append('remove-enemy')
    elif tag=='remove-player':assert xs[2]==1;trace.append('remove-player')
    elif tag=='unbind':trace.append('unbind')
    elif tag=='set-result':trace.append('set-result')
    elif tag=='wait':
        assert xs[:4]==[0,8,0,0]
        trace.append('wait:'+str(cpu.reg_read(a.UC_ARM64_REG_S0)))
        out=TASK;cpu.reg_write(a.UC_ARM64_REG_X1,0)
    elif tag=='await':trace.append('await')
    elif tag=='interface':out=DESC_LENGTH if xs[0]==ANIM else DESC_STATUS if xs[2]==0 else DESC_RESULT
    elif tag=='stop-listen':trace.append('stop-listen')
    elif tag=='callback':assert xs[1]==sc['deadType'];trace.append('callback:'+str(xs[1]))
    elif tag=='length':cpu.reg_write(a.UC_ARM64_REG_S0,sc['lengthBits']);trace.append('length')
    elif tag=='status':out=0 if sc['pending'] and phase==0 else 1;trace.append('status')
    elif tag=='result':trace.append('result')
    elif tag=='exception':raise RuntimeError('native exception')
    else:raise RuntimeError(tag)
    cpu.reg_write(a.UC_ARM64_REG_X0,out)
    cpu.reg_write(a.UC_ARM64_REG_PC,cpu.reg_read(a.UC_ARM64_REG_LR))
cpu.hook_add(UC_HOOK_CODE,hook)
rows=[]
for case in range(64):
    sc={'dead':case%16==0,'enemy':bool(case&1),'ab':bool(case&2),'reduce':bool(case&4),'arena':case%3,'hex':bool(case%3),'pending':bool(case&8),'lengthBits':[fb(0),fb(.05),fb(.1),fb(1),fb(2),0x7fc00000,0x7f800000,0xff800000][case%8],'bless':[-5,0,3,2147483647][case%4],'buff':[-1,0,2][case%3],'deadType':case%2}
    n.scenario={'position':[0,0,0]}
    wr(SELF+32,bytes(0x2e0));qw(SELF,CLASS);wr(SELF+32,bytes([int(sc['enemy']),int(sc['dead'])]));iw(SELF+56,7);qw(SELF+320,ANIM);qw(SELF+640,HEX if sc['hex'] else 0);wr(CONFIG+20,bytes([int(sc['reduce'])]));qw(STATIC+8,[ARENA1,ARENA2,OTHER][sc['arena']])
    wr(STATE,bytes(0x100));iw(STATE,-1);qw(STATE+40,SELF);iw(STATE+48,sc['deadType'])
    phases=[]
    for phase in [0,1] if sc['pending'] and not sc['dead'] else [0]:
        trace=[];cpu.reg_write(a.UC_ARM64_REG_SP,STACK+0x10000);cpu.reg_write(a.UC_ARM64_REG_LR,STOP);cpu.reg_write(a.UC_ARM64_REG_X0,STATE)
        cpu.emu_start(0x3d90878,STOP,count=10000)
        phases.append({'trace':trace,'state':read_i(STATE),'isDead':bool(cpu.mem_read(SELF+33,1)[0]),'awaiterSaved':int.from_bytes(cpu.mem_read(STATE+56,8),'little')!=0})
    rows.append({'scenario':sc,'phases':phases})
(OWN/'death-native-oracle.json').write_text(json.dumps(rows,indent=2),encoding='utf-8')
print(json.dumps({'method':'Dead.MoveNext','rva':'0x3d90878','cases':len(rows),'phases':sum(len(x['phases']) for x in rows),'failures':0}))
