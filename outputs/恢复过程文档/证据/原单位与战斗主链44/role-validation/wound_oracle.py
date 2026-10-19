"""Original Wound machine code against instrumented external and virtual contracts."""
import native_oracle as n
import json,struct,random
from pathlib import Path
from unicorn import UC_HOOK_CODE
import unicorn.arm64_const as a
cpu=n.cpu;wr=n.wr;qw=n.qw;iw=n.iw;fbits=n.fbits;OWN=Path(__file__).resolve().parent
SELF,PROP,TRANS,GAME,STOP,STACK=n.SELF,n.PROP,n.TRANS,n.GAME,n.STOP,n.STACK
CLASS,BUILDER,BC,LCLASS,TARGET,LINK1,LINK2,LIST,STATIC=0x11000000,0x11001000,0x11002000,0x11003000,0x11004000,0x11005000,0x11006000,0x11007000,0x11008000
MANAGER,ID,ID_SPECIAL,MISS,MINUS,PATH,AUDIO,TEXT=0x12000000,0x12001000,0x12002000,0x12003000,0x12004000,0x12005000,0x12006000,0x12007000
HURT,HEALTH,DEAD,HPBAR,LINK,TOSTRING=0x30001000,0x30001010,0x30001020,0x30001030,0x30001040,0x30001050
for ptr in [CLASS,BUILDER,BC,LCLASS,TARGET,LINK1,LINK2,LIST,STATIC,MANAGER]:wr(ptr,bytes(0x1000))
iw(CLASS+0xe0,1);iw(LCLASS+0xe0,1);qw(CLASS+184,STATIC);qw(BUILDER,BC)
for of,addr in [(680,HEALTH),(696,DEAD),(840,HPBAR)]:qw(CLASS+of,addr)
qw(LCLASS+376,LINK);qw(BC+360,TOSTRING)
for ptr in [SELF,TARGET,LINK1,LINK2]:qw(ptr,CLASS if ptr in [SELF,TARGET] else LCLASS)
wr(CLASS+304,b'\x01');qw(CLASS+200,CLASS+512);qw(CLASS+512,CLASS)
for slot,value in [(0x8ceb3e0,CLASS),(0x8ce5e20,CLASS),(0x8cecb08,CLASS),(0x8d537d8,ID_SPECIAL),(0x8d89380,MISS),(0x8d52658,MINUS),(0x8d57bd0,PATH),(0x8d57ae8,AUDIO)]:qw(slot,value)
manager_slots=[0x8d12168,0x8d12128,0x8d12018,0x8d12048,0x8d12460]
for i,slot in enumerate(manager_slots):qw(slot,0x60000000+i*16)
wr(0x8ffd47b,b'\x01');wr(0x8ffd1ab,b'\x01');qw(SELF+544,BUILDER)
hooks={0x82ed714:'eq',0x82ebc6c:'ne',0x7505920:'str-eq',0x5978460:'manager',0x3d831f4:'hurt',0x82e61f0:'random',0x82f2900:'time',
0x3e0f954:'human',0x3e1003c:'machine',0x574f26c:'item',0x751a56c:'clear',0x7512ea8:'append-string',0x751b730:'append-int',
0x437d2c8:'color',0x3d841c4:'text',0x3d8370c:'kill',0x3d87450:'hell',
HURT:'unused',HEALTH:'health',DEAD:'dead',HPBAR:'hpbar',LINK:'link',TOSTRING:'tostring'}
# Resolve exact named externals from script map, avoiding overloaded Dictionary-name collisions.
for name,tag in [('System.String$$op_Equality','str-eq'),('UnityEngine.Time$$get_time','time'),('AssetsModule.EffectManager$$ShowEffect','fx'),('AudioManager$$PlaySFX','audio'),('GameModule.BattleGameManager$$RecordDamage','record'),('GameModule.BattleGameManager$$RecordBuildDamage','record-build'),('GameModule.RoleBehaviour$$OnKillTalentTrigger','kill'),('GameModule.SynergyEffectManager$$HumanFetter4_DamageReduction','human')]:
    for x in n.mapping['ScriptMethod']:
        if x['Name']==name:hooks[x['Address']]=tag
for pc in hooks:n.page(pc&~0xfff)
sc={};trace=[];builder=''
def s32(v):return struct.unpack('<i',struct.pack('<I',v&0xffffffff))[0]
def read_i(p):return s32(int.from_bytes(cpu.mem_read(p,4),'little'))
def hook(uc,pc,sz,data):
    global builder
    tag=hooks.get(pc)
    if tag is None:return
    xs=[cpu.reg_read(getattr(a,'UC_ARM64_REG_X'+str(i))) for i in range(8)]
    out=0
    if tag in ['eq','str-eq']:out=int(xs[0]==xs[1])
    elif tag=='ne':out=int(xs[0]!=xs[1])
    elif tag=='manager':out=MANAGER
    elif tag=='hurt':
        trace.append('hurt:'+str(s32(xs[1])));out=(sc['hurtMissBits']<<32)|(sc['hurtDamage']&0xffffffff)
    elif tag=='random':assert xs[:2]==[0,101];trace.append('random');out=sc['roll']
    elif tag=='time':cpu.reg_write(a.UC_ARM64_REG_S0,fbits(9));cpu.reg_write(a.UC_ARM64_REG_PC,cpu.reg_read(a.UC_ARM64_REG_LR));return
    elif tag=='human':trace.append('human:'+str(s32(xs[1])));out=sc['synergy']
    elif tag=='machine':trace.append('machine:'+str(s32(xs[1])));out=sc['synergy']
    elif tag=='item':out=sc['links'][s32(xs[1])]
    elif tag=='clear':builder='';out=BUILDER
    elif tag=='append-string':assert xs[1]==MINUS;builder+='-';out=BUILDER
    elif tag=='append-int':builder+=str(s32(xs[1]));out=BUILDER
    elif tag=='tostring':out=TEXT
    elif tag=='color':
        trace.append('color');
        for i,bits in enumerate([fbits(1),fbits(0.5),fbits(0.25),fbits(1)]):cpu.reg_write(getattr(a,'UC_ARM64_REG_S'+str(i)),bits)
    elif tag=='text':trace.append('text:'+('闪避' if xs[1]==MISS else builder))
    elif tag=='fx':trace.append('fx')
    elif tag=='record':trace.append('record:'+str(s32(xs[2])))
    elif tag=='record-build':trace.append('record-build:'+str(s32(xs[2])))
    elif tag=='health':trace.append('health');iw(PROP+24,read_i(PROP+24)+sc['heal'])
    elif tag=='hpbar':trace.append('hpbar')
    elif tag=='dead':trace.append('dead:'+str(s32(xs[1])));wr(SELF+33,b'\x01')
    elif tag=='link':
        assert int.from_bytes(cpu.mem_read(cpu.reg_read(a.UC_ARM64_REG_SP),8),'little')==0
        trace.append('link:'+str(s32(xs[1]))+':'+str(bool(xs[3])).lower()+':'+str(xs[5])+':'+str(xs[6])+':'+str(xs[7]))
    elif tag=='kill':trace.append('kill')
    elif tag=='hell':trace.append('hell');out=int(sc['hell'])
    elif tag=='audio':trace.append('audio')
    else:raise RuntimeError(tag)
    cpu.reg_write(a.UC_ARM64_REG_X0,out&0xffffffffffffffff)
    cpu.reg_write(a.UC_ARM64_REG_PC,cpu.reg_read(a.UC_ARM64_REG_LR))
cpu.hook_add(UC_HOOK_CODE,hook)
rng=random.Random(4401);rows=[]
for case in range(240):
    sc={'gaming':True,'dead':False,'property':True,'special':False,'skilling':False,'damage':rng.choice([1,17,100,16777219,2147483647,-1]),'hurtDamage':rng.choice([1,17,100,16777219,2147483647,-1]),'hurtMissBits':fbits(0),'missBits':fbits(0),'reduceBits':[fbits(0),fbits(0.1),fbits(0.5),fbits(1),fbits(2),0x7f800000,0x7fc00000][case%7],'roll':case%101,'fetter':[0,2,3,4][case%4],'synergy':rng.choice([0,1,17,99,2147483647]),'hp':rng.choice([1,50,200,2147483647]),'enemy':bool(case%2),'build':bool(case%3==0),'land':bool(case%2),'way':case%3,'attacker':case%3,'attackerDead':bool(case%7==0),'heal':rng.choice([0,0,0,200]),'linkBits':fbits([0,0.25,0.5,1,2][case%5]),'links':[LINK1,0,LINK2] if case%5==0 else [],'hell':bool(case%2),'linkObj':bool(case%4==0)}
    if case%20==0:sc['gaming']=False
    if case%20==1:sc['dead']=True
    if case%20==2:sc['property']=False
    if case%20==3:sc['special']=True;sc['skilling']=True
    if case%20==4:sc['damage']=0
    if case%20==5:sc['hurtMissBits']=fbits(0.5);sc['missBits']=fbits(0.5)
    if case%20==6:sc['hurtMissBits']=0x7fc00000
    n.scenario={'position':[0,0,0]}
    wr(SELF+32,bytes(0x2e0));qw(SELF,CLASS);qw(SELF+544,BUILDER);qw(SELF+64,PROP if sc['property'] else 0)
    wr(SELF+32,bytes([int(sc['enemy']),int(sc['dead'])]));wr(SELF+188,bytes([int(sc['skilling'])]));iw(SELF+200,sc['fetter']);qw(PROP+16,ID_SPECIAL if sc['special'] else ID);iw(PROP+24,sc['hp']);iw(PROP+64,sc['missBits']);iw(PROP+76,sc['reduceBits']);iw(SELF+392,sc['linkBits']);qw(SELF+384,LIST if sc['links'] else 0);iw(LIST+24,len(sc['links']));wr(STATIC,bytes([int(sc['gaming'])]));wr(TARGET+33,bytes([int(sc['attackerDead'])]))
    trace=[];builder='';cpu.reg_write(a.UC_ARM64_REG_SP,STACK+0x10000);cpu.reg_write(a.UC_ARM64_REG_LR,STOP)
    target=[0,TARGET,MANAGER][sc['attacker']]
    qw(MANAGER,BC);wr(BC+304,b'\x00')
    for i,value in enumerate([SELF,sc['damage']&0xffffffff,ID,int(sc['build']),target,int(sc['land']),sc['way'],4]):cpu.reg_write(getattr(a,'UC_ARM64_REG_X'+str(i)),value)
    qw(STACK+0x10000,PATH if sc['linkObj'] else 0)
    cpu.emu_start(0x3d86a44,STOP,count=10000)
    rows.append({'scenario':{k:v for k,v in sc.items() if k!='links'},'linkCount':len(sc['links']),'trace':trace,'hp':read_i(PROP+24),'dead':bool(cpu.mem_read(SELF+33,1)[0]),'frontTimeBits':int.from_bytes(cpu.mem_read(SELF+48,4),'little'),'attackObj':int.from_bytes(cpu.mem_read(SELF+368,8),'little')==target})
(OWN/'wound-native-oracle.json').write_text(json.dumps(rows,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({'method':'Wound','rva':'0x3d86a44','cases':len(rows),'failures':0}))
