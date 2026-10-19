"""Execute original Synergy ARM64; only external singleton/Unity APIs are hooks."""
import json,struct,sys,hashlib,random
from pathlib import Path
ROOT=Path(__file__).resolve().parents[3]; OWN=Path(__file__).resolve().parent
sys.path.insert(0,str(ROOT/'work/tools/unicorn-recovery'))
from unicorn import Uc,UC_ARCH_ARM64,UC_MODE_ARM,UC_HOOK_CODE,UC_HOOK_MEM_UNMAPPED
import unicorn.arm64_const as a
raw=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes(); po=struct.unpack_from('<Q',raw,32)[0];ps,pn=struct.unpack_from('<HH',raw,54);segments=[struct.unpack_from('<IIQQQQQQ',raw,po+i*ps) for i in range(pn)]
so=struct.unpack_from('<Q',raw,40)[0];ss,sn=struct.unpack_from('<HH',raw,58);sections=[struct.unpack_from('<IIQQQQIIQQ',raw,so+i*ss) for i in range(sn)];relocs={}
for s in sections:
 if s[1]==4:
  for p in range(s[4],s[4]+s[5],s[9] or 24):
   of,inf,ad=struct.unpack_from('<QQq',raw,p)
   if inf&0xffffffff==1027:relocs[of]=ad
page_relocs={}
for of,ad in relocs.items():page_relocs.setdefault(of&~0xfff,[]).append((of,ad))
cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM);mapped=set()
def map_page(p):
 if p in mapped:return
 cpu.mem_map(p,0x1000);mapped.add(p)
 for s in segments:
  if s[0]!=1:continue
  lo=max(p,s[3]);hi=min(p+0x1000,s[3]+s[5])
  if lo<hi:cpu.mem_write(lo,raw[s[2]+lo-s[3]:s[2]+hi-s[3]])
 for of,ad in page_relocs.get(p,[]):cpu.mem_write(of,struct.pack('<Q',ad))
def unmapped(uc,access,address,size,value,data):
 for p in range(address&~0xfff,(address+size+0xfff)&~0xfff,0x1000):map_page(p)
 return True
cpu.hook_add(UC_HOOK_MEM_UNMAPPED,unmapped)
def wr(p,b):
 for pg in range(p&~0xfff,(p+len(b)+0xfff)&~0xfff,0x1000):map_page(pg)
 cpu.mem_write(p,b)
def qw(p,v):wr(p,struct.pack('<Q',v))
def iw(p,v):wr(p,struct.pack('<i',v))
def qr(p):return struct.unpack('<Q',cpu.mem_read(p,8))[0]
SELF,PLAYER,ENEMY,TARGET,SCENE,LIST,AB=0x10000000,0x10001000,0x10002000,0x10003000,0x10004000,0x10005000,0x10006000
ROLE_CLASS,ARCH_CLASS,OTHER_CLASS=0x10010000,0x10011000,0x10012000
STOP,STACK=0x30000000,0x20000000
wr(STACK,bytes(0x10000));wr(SELF,bytes(0x1000));wr(PLAYER,bytes(0x1000));wr(ENEMY,bytes(0x1000));wr(TARGET,bytes(0x1000));wr(LIST,bytes(0x1000));wr(STOP,bytes.fromhex('c0035fd6'))
for cl in [ROLE_CLASS,ARCH_CLASS,OTHER_CLASS]:
 wr(cl,bytes(0x1000));qw(cl+0xc8,cl+0x400);qw(cl+0x400,cl);wr(cl+0x130,b'\x01')
for flag in [0x8ffd853,0x8ffd854,0x8ffd855,0x8ffd856,0x8ffd857,0x8ffd858]:wr(flag,b'\x01')
AI_METHOD,PLAYER_METHOD,SCENE_METHOD,AB_METHOD,BASE_METHOD=0x60000010,0x60000020,0x60000030,0x60000040,0x60000050
for got,val in [(0x8acff28,AI_METHOD),(0x8acff30,PLAYER_METHOD),(0x8ace700,SCENE_METHOD),(0x8acfaa0,ROLE_CLASS),(0x8ad15a0,ARCH_CLASS),(0x8acdf88,AB_METHOD),(0x8ad4a20,BASE_METHOD)]:qw(relocs[got],val)
# Constructor class-init flag and singleton type metadata.
qw(relocs[0x8acdf78],OTHER_CLASS);iw(OTHER_CLASS+0xe0,1)
scenario={};trace=[];failed=None
hooks={0x5978460:'manager',0x82e61f0:'random',0x3df36d4:'near',0x3c3d4cc:'null',0x5fbeb64:'ab-singleton',0x3f7257c:'ab-getter',0x5978848:'base-ctor',0x3c3d3b0:'class-init'}
for p in hooks:map_page(p&~0xfff)
def hook(uc,pc,sz,data):
 global failed
 name=hooks.get(pc)
 if not name:return
 x=[cpu.reg_read(getattr(a,'UC_ARM64_REG_X'+str(i))) for i in range(5)]
 if name=='manager':
  assert x[0] in [AI_METHOD,PLAYER_METHOD,SCENE_METHOD],(hex(pc),x)
  dest={AI_METHOD:ENEMY,PLAYER_METHOD:PLAYER,SCENE_METHOD:SCENE}[x[0]]
  if scenario.get('nullManager'):dest=0
  cpu.reg_write(a.UC_ARM64_REG_X0,dest);trace.append({'call':name,'side':{AI_METHOD:'enemy',PLAYER_METHOD:'player',SCENE_METHOD:'scene'}[x[0]]})
 elif name=='random':
  assert x[:2]==[0,100];cpu.reg_write(a.UC_ARM64_REG_X0,scenario['random']);trace.append({'call':'random','min':0,'max':100})
 elif name=='near':
  assert x[0]==SCENE and x[2]==TARGET and x[3]&0xffffffff==0xffffffff
  trace.append({'call':'near','enemy':bool(x[1]&1),'rangeBits':cpu.reg_read(a.UC_ARM64_REG_S0),'roleNumber':-1})
  cpu.reg_write(a.UC_ARM64_REG_X0,LIST if scenario['near']>=0 else 0)
 elif name=='gettask':
  trace.append({'call':'gettask','state':struct.unpack('<i',cpu.mem_read(x[0]-8,4))[0],'runner':qr(x[0])});cpu.reg_write(a.UC_ARM64_REG_X0,0);cpu.reg_write(a.UC_ARM64_REG_X1,0)
 elif name=='setstate':trace.append({'call':'setstate','builderOffset':x[0]-SELF,'stateMachine':x[1]})
 elif name=='null':failed='NullReferenceException';cpu.emu_stop();return
 elif name=='ab-singleton':cpu.reg_write(a.UC_ARM64_REG_X0,AB);trace.append({'call':name})
 elif name=='ab-getter':cpu.reg_write(a.UC_ARM64_REG_X0,int(scenario['new']));trace.append({'call':name})
 elif name=='base-ctor':trace.append({'call':name,'newFetter':bool(cpu.mem_read(SELF+0x20,1)[0])})
 cpu.reg_write(a.UC_ARM64_REG_PC,cpu.reg_read(a.UC_ARM64_REG_LR))
cpu.hook_add(UC_HOOK_CODE,hook)
def configure(sc):
 global scenario,trace,failed
 scenario=sc;trace=[];failed=None
 wr(SELF+0x20,bytes([int(sc['new'])]));iw(LIST+0x18,max(sc['near'],0))
 for base,offs,counts in [(PLAYER,[0x50,0x54,0x58,0x64,0x5c,0x60],sc['player']),(ENEMY,[0xc4,0xc8,0xcc,0xd8,0xd0,0xd4],sc['enemy'])]:
  for of,c in zip(offs,counts):iw(base+of,c)
 cl={'role':ROLE_CLASS,'arch':ARCH_CLASS,'other':OTHER_CLASS}.get(sc['targetKind'],OTHER_CLASS);qw(TARGET,cl);iw(TARGET+0xc8,sc['targetFetter']);iw(TARGET+0x80,sc['targetFetter'])
def execute(addr,ints=[],fbits=None,floatReturn=False):
 cpu.reg_write(a.UC_ARM64_REG_SP,STACK+0x10000);cpu.reg_write(a.UC_ARM64_REG_LR,STOP)
 for i in range(8):cpu.reg_write(getattr(a,'UC_ARM64_REG_X'+str(i)),0)
 cpu.reg_write(a.UC_ARM64_REG_X0,SELF)
 for i,v in enumerate(ints,1):cpu.reg_write(getattr(a,'UC_ARM64_REG_X'+str(i)),v&0xffffffffffffffff)
 if fbits is not None:cpu.reg_write(a.UC_ARM64_REG_S0,fbits)
 cpu.emu_start(addr,STOP,count=10000)
 if failed:return failed
 return cpu.reg_read(a.UC_ARM64_REG_S0) if floatReturn else struct.unpack('<i',struct.pack('<I',cpu.reg_read(a.UC_ARM64_REG_W0)))[0]
methods=json.loads((ROOT/'work/parallel-44-battle/synergy-targets.json').read_text(encoding='utf-8'));methods={x['name'].split('$$')[-1]:x for x in methods if x['name'].startswith('GameModule.SynergyEffectManager$$')}
floatNames={'InternalCalculateProductionSpeed','HumanFetter2','UndeadFetter2','OrcsFetter2','OrcsFetter6','OrcsFetter2_MoveSpeed','MachineFetter2','MeleeFetter3','RemoteFetter3','RemoteFetter7','MachineFetter2_Range'}
boolNames={'HumanFetter6_GoldPerSecond','UndeadFetter6','UndeadFetter4_Revive','UndeadFetter6_ExtraSpawn','OrcsFetter4_AttackSpeed'}
intValues=[0,1,-1,101,-101,16777219,2147483647,-2147483648]
floatBits=[0,0x80000000,0x3f800000,0x41200000,0xbf800000,0x4b800001,0x7f7fffff,0x7f800000,0xff800000,0x7fc00000,1]
rows=[]
for name,entry in methods.items():
 if name in ['Init','.ctor']:continue
 for ni,new in enumerate([False,True]):
  for enemy in [False,True]:
   for k in range(10):
    sc={'new':new,'isEnemy':enemy,'player':[k,k-1,k+1,k-2,k+2,k-3],'enemy':[9-k,8-k,10-k,7-k,11-k,6-k],'random':[0,9,10,99][k%4],'near':[-1,0,1,3][k%4],'targetKind':['role','arch','other','null'][k%4],'targetFetter':k%5}
    v=intValues[k%len(intValues)];bits=floatBits[k%len(floatBits)];args=[];fbits=None;isfloat=name in floatNames
    if name=='GetFetterCount':args=[k-3,int(enemy)]
    elif name=='GetAtkWayTypeCount':args=[k-3,int(enemy)]
    elif name=='InternalCalculateDamage':args=[v,int(enemy),k-2,4]
    elif name=='InternalCalculateProductionSpeed':args=[int(enemy),k-2,4];fbits=bits
    elif name=='HumanFetter4_DamageReduction':args=[v,0 if sc['targetKind']=='null' else TARGET,int(enemy)];fbits=0x3f400000
    elif name=='MachineFetter6_RemoteDamageReduction':args=[v,0 if sc['targetKind']=='null' else TARGET,int(enemy),k%3]
    elif name=='OrcsFetter4_AttackSpeed':args=[v,[0,-1,1,100,202,2147483647][k%6],int(enemy)]
    elif name in boolNames:args=[int(enemy)]
    elif name in ['MachineFetter6','OrcsFetter6_BuildingDamage']:args=[v,int(enemy),k%2]
    elif isfloat:args=[int(enemy)];fbits=bits
    else:args=[v,int(enemy)]
    configure(sc);result=execute(entry['address'],args,fbits,isfloat)
    rows.append({'name':name,'scenario':sc,'args':args,'floatBits':fbits,'floatReturn':isfloat,'native':result,'trace':trace.copy()})
# Explicit type/count/reduction gates and exact random/HP boundaries.
for name in ['HumanFetter4_DamageReduction','MachineFetter6_RemoteDamageReduction','UndeadFetter6','UndeadFetter4_Revive','OrcsFetter4_AttackSpeed']:
 for new in [False,True]:
  for enemy in [False,True]:
   for kind in ['role','arch','other','null']:
    for fetter in [0,2,3,4]:
     for k in [0,3,4,5,6,7]:
      sc={'new':new,'isEnemy':enemy,'player':[k]*6,'enemy':[k]*6,'random':9 if k%2 else 10,'near':1,'targetKind':kind,'targetFetter':fetter}
      args=[16777219,0 if kind=='null' else TARGET,int(enemy)];fb=None
      if name=='HumanFetter4_DamageReduction':fb=0x3f800000
      elif name=='MachineFetter6_RemoteDamageReduction':args.append(1)
      elif name=='OrcsFetter4_AttackSpeed':args=[k,10,int(enemy)]
      else:args=[int(enemy)]
      configure(sc);result=execute(methods[name]['address'],args,fb)
      rows.append({'name':name,'scenario':sc,'args':args,'floatBits':fb,'floatReturn':False,'native':result,'trace':trace.copy()})
ctor=[]
for new in [False,True]:
 sc={'new':new,'isEnemy':False,'player':[0]*6,'enemy':[0]*6,'random':99,'near':0,'targetKind':'other','targetFetter':4};configure(sc);wr(SELF+0x20,b'\0');execute(methods['.ctor']['address']);ctor.append({'new':new,'trace':trace.copy(),'storedNew':bool(cpu.mem_read(SELF+0x20,1)[0])})
# Execute original Init entry and original generated forwarders. UniTask get_Task and SetStateMachine are library API hooks.
hooks[0x3d17780]='gettask';hooks[0x7d8999c]='setstate'
qw(relocs[0x8ad4a18],0x60001000);qw(0x60001000+0x38,0x60001080)
configure({'new':False,'isEnemy':False,'player':[0]*6,'enemy':[0]*6,'random':99,'near':0,'targetKind':'other','targetFetter':4})
execute(methods['Init']['address']);init_trace=trace.copy();assert init_trace==[{'call':'gettask','state':-2,'runner':0}],init_trace
trace.clear();execute(0x3e102c0,[0x60002000]);assert trace==[{'call':'setstate','builderOffset':8,'stateMachine':0x60002000}],trace
(OWN/'native-init.json').write_text(json.dumps({'init':init_trace,'setStateMachine':trace},indent=2),encoding='utf-8')
(OWN/'native-oracle.json').write_text(json.dumps(rows,ensure_ascii=False,indent=2),encoding='utf-8');(OWN/'native-constructor.json').write_text(json.dumps(ctor,indent=2),encoding='utf-8')
summary={'cases':len(rows),'methods':len({x['name'] for x in rows}),'constructorCases':len(ctor),'nativeFailures':[x for x in rows if isinstance(x['native'],str)],'elfSha256':hashlib.sha256(raw).hexdigest(),'externalHooks':hooks,'scope':'Original ARM64 executes full business methods and actual GetFetterCount/GetAtkWayTypeCount field reads; singleton/Unity APIs modeled.'};(OWN/'native-summary.json').write_text(json.dumps(summary,indent=2),encoding='utf-8');print(json.dumps(summary,indent=2))
