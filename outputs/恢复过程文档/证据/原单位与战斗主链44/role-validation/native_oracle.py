"""Run original RoleBehaviour ARM64. Hooks cover only Unity/config external APIs."""
import json, struct, sys, random, hashlib
from pathlib import Path
ROOT=Path(__file__).resolve().parents[3]; OWN=Path(__file__).resolve().parent
sys.path.insert(0,str(ROOT/'work/tools/unicorn-recovery'))
from unicorn import Uc,UC_ARCH_ARM64,UC_MODE_ARM,UC_HOOK_CODE,UC_HOOK_MEM_UNMAPPED
import unicorn.arm64_const as a
raw=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes()
phoff=struct.unpack_from('<Q',raw,32)[0];psz,pn=struct.unpack_from('<HH',raw,54)
segments=[struct.unpack_from('<IIQQQQQQ',raw,phoff+i*psz) for i in range(pn)]
soff=struct.unpack_from('<Q',raw,40)[0];ssz,sn=struct.unpack_from('<HH',raw,58)
sections=[struct.unpack_from('<IIQQQQIIQQ',raw,soff+i*ssz) for i in range(sn)]
page_relocs={}
for s in sections:
    if s[1]==4:
        for p in range(s[4],s[4]+s[5],s[9] or 24):
            of,info,ad=struct.unpack_from('<QQq',raw,p)
            if info&0xffffffff==1027:page_relocs.setdefault(of&~0xfff,[]).append((of,ad))
cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM);mapped=set()
def page(p):
    if p in mapped:return
    cpu.mem_map(p,0x1000);mapped.add(p)
    for s in segments:
        if s[0]!=1:continue
        lo=max(p,s[3]);hi=min(p+0x1000,s[3]+s[5])
        if lo<hi:cpu.mem_write(lo,raw[s[2]+lo-s[3]:s[2]+hi-s[3]])
    for of,ad in page_relocs.get(p,[]):cpu.mem_write(of,struct.pack('<Q',ad))
def unmapped(uc,access,address,size,value,data):
    for p in range(address&~0xfff,(address+size+0xfff)&~0xfff,0x1000):page(p)
    return True
cpu.hook_add(UC_HOOK_MEM_UNMAPPED,unmapped)
def wr(p,b):
    for pg in range(p&~0xfff,(p+len(b)+0xfff)&~0xfff,0x1000):page(pg)
    cpu.mem_write(p,b)
def qw(p,v):wr(p,struct.pack('<Q',v))
def iw(p,v):wr(p,struct.pack('<I',v&0xffffffff))
def fbits(v):return struct.unpack('<I',struct.pack('<f',v))[0]
SELF,PROP,TRANS,GAME,STOP,STACK=0x10000000,0x10001000,0x10002000,0x10003000,0x30000000,0x20000000
wr(STACK,bytes(0x10000));wr(SELF,bytes(0x1000));wr(PROP,bytes(0x1000));wr(STOP,bytes.fromhex('c0035fd6'))
mapping=json.loads((ROOT/'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'))
named={x['Name']:x['Address'] for x in mapping['ScriptMethod']}
hooks={named['Pathfinding.AstarWebGLRuntimeConfig$$get_UseWebGLNavigation']:'webgl',
       named['UnityEngine.Component$$get_transform']:'transform',
       named['UnityEngine.Component$$get_gameObject']:'gameobject',
       named['UnityEngine.Transform$$get_localScale']:'scale',
       named['UnityEngine.Transform$$get_position']:'position',
       named['UnityEngine.GameObject$$get_activeInHierarchy']:'active',
       0x3c3d280:'metadata',0x3c3d3b0:'classinit'}
for p in hooks:page(p&~0xfff)
scenario={};trace=[]
def hook(uc,pc,sz,data):
    name=hooks.get(pc)
    if name is None:return
    trace.append(name)
    if name=='webgl':cpu.reg_write(a.UC_ARM64_REG_X0,int(scenario.get('webgl',False)))
    elif name=='active':cpu.reg_write(a.UC_ARM64_REG_X0,int(scenario.get('active',True)))
    elif name=='transform':cpu.reg_write(a.UC_ARM64_REG_X0,TRANS)
    elif name=='gameobject':cpu.reg_write(a.UC_ARM64_REG_X0,GAME)
    elif name in ['scale','position']:
        defaults=[fbits(1),fbits(1),fbits(1)] if name=='scale' else [0,0,0]
        for i,bits in enumerate(scenario.get(name,defaults)):cpu.reg_write(getattr(a,'UC_ARM64_REG_S'+str(i)),bits)
    cpu.reg_write(a.UC_ARM64_REG_PC,cpu.reg_read(a.UC_ARM64_REG_LR))
cpu.hook_add(UC_HOOK_CODE,hook)
# The tested float/boolean methods use no runtime class data except static Vector3 zero.
# Initialised metadata/class flags are genuine execution environment inputs.
for of in [0x8ffd46b,0x8ffcfff,0x8ffcffc,0x8ffcffd]:wr(of,b'\x01')
fields={
'hadInit':(328,'bool'),'hadRecycle':(636,'bool'),'destroying':(637,'bool'),'isDead':(33,'bool'),
'Skilling':(188,'bool'),'isFreeze':(224,'bool'),'isDizzy':(404,'bool'),
'attacking':(577,'bool'),'_isAttackingWall':(592,'bool'),'_isBreakingWall':(578,'bool'),
'followerEntityCurrentCanMove':(440,'bool'),'followerEntityCurrentSpeed':(444,'float'),
'followerEntityCurrentRadius':(448,'float'),'followerEntityCurrentEnableLocalAvoidance':(464,'bool'),
'skillRequireCount':(292,'float'),'_bornScaleX':(184,'float'),'AtkWayType':(204,'int'),
'TargetType':(72,'int'),'_lastRoleTargetHexDistance':(288,'int'),
'PropertyTemp.moveSpeed':(40,'float'),'PropertyTemp.atkRange':(36,'float'),'PropertyTemp.rareLevel':(80,'int')}
methods=[
('HasSkill',0x3d7f7d0,'bool'),('WebGLNavigationIsValid',0x3d84470,'bool'),
('WebGLNavigationCanMove',0x3d844bc,'bool'),('WebGLNavigationCanSoftSeparate',0x3d84514,'bool'),
('WebGLNavigationTargetType',0x3d84618,'int'),('WebGLNavigationMoveSpeed',0x3d84620,'float'),
('WebGLNavigationRadius',0x3d84668,'float'),('WebGLNavigationAttackRange',0x3d84688,'float'),
('GetFindTargetInterval',0x3d82340,'float'),('GetAiCanMove',0x3d84a94,'bool'),
('GetAiSPeed',0x3d816b4,'float'),('GetFollowerEntityMoveSpeed',0x3d84a9c,'float'),
('GetWebGLNavigationMoveSpeed',0x3d84658,'float'),('GetAiRadius',0x3d84ac4,'float'),
('GetAiEnableLocalAvoidance',0x3d84b60,'bool'),('GetAutoRepathPeriod',0x3d812cc,'float'),
('GetScaledRadius',0x3d7f9e0,'float')]
bits=[0,0x80000000,1,0x3f800000,0xbf800000,0x3a83126f,0x3a831270,0x3c23d70a,0x3c23d70b,0x7f7fffff,0x7f800000,0xff800000,0x7fc00000,0x4b800001]
rng=random.Random(44);rows=[]
for name,addr,ret in methods:
    for case in range(120):
        scenario={'webgl':bool(case&1),'active':not bool(case%3),'property':bool(case%4),'fields':{},'scale':[bits[case%len(bits)],fbits(1),fbits(1)]}
        wr(SELF,bytes(0x300));wr(PROP,bytes(0x100))
        for f,(of,kind) in fields.items():
            if kind=='bool':
                if name in ['WebGLNavigationIsValid','WebGLNavigationCanMove','WebGLNavigationCanSoftSeparate']:
                    permissive={'hadInit':1,'followerEntityCurrentCanMove':1,'attacking':int(name=='WebGLNavigationCanSoftSeparate')}
                    value=permissive.get(f,0)
                    guard=list(k for k,(_,t) in fields.items() if t=='bool')[case%12]
                    if f==guard:value=1-value
                else:value=rng.randrange(2)
            elif kind=='int':value=rng.choice([0,1,2,3,4,79,80,1499,1500,1501,-1,-2147483648,2147483647])
            else:value=bits[(case+of)%len(bits)]
            scenario['fields'][f]=value
            base=PROP if f.startswith('PropertyTemp.') else SELF
            wr(base+of,bytes([value]) if kind=='bool' else struct.pack('<I',value&0xffffffff))
        qw(SELF+64,PROP if scenario['property'] else 0)
        for i in range(8):cpu.reg_write(getattr(a,'UC_ARM64_REG_X'+str(i)),0);cpu.reg_write(getattr(a,'UC_ARM64_REG_S'+str(i)),0)
        cpu.reg_write(a.UC_ARM64_REG_SP,STACK+0x10000);cpu.reg_write(a.UC_ARM64_REG_LR,STOP)
        cpu.reg_write(a.UC_ARM64_REG_X0,SELF)
        arg=bits[case%len(bits)]
        if name in ['GetFollowerEntityMoveSpeed','GetWebGLNavigationMoveSpeed','GetScaledRadius']:cpu.reg_write(a.UC_ARM64_REG_S0,arg);scenario['floatArg']=arg
        if name=='GetAutoRepathPeriod':
            arg=[-1,0,1,20,21,79,80,1500,1501,2147483647,-2147483648][case%11]
            cpu.reg_write(a.UC_ARM64_REG_X0,arg&0xffffffff);scenario['intArg']=arg
        trace=[]
        cpu.emu_start(addr,STOP,count=1000)
        result=cpu.reg_read(a.UC_ARM64_REG_S0 if ret=='float' else a.UC_ARM64_REG_W0)&0xffffffff
        rows.append({'method':name,'rva':hex(addr),'return':ret,'scenario':scenario,'expectedBits':result,'trace':trace})
(OWN/'native-oracle.json').write_text(json.dumps(rows,indent=2),encoding='utf-8')
summary={'methods':len(methods),'cases':len(rows),'raw_sha256':hashlib.sha256(raw).hexdigest(),'hooks':{hex(k):v for k,v in hooks.items()},'failures':0}
(OWN/'native-summary.json').write_text(json.dumps(summary,indent=2),encoding='utf-8');print(json.dumps(summary))
