"""Execute original manager ARM64. External APIs are recording hooks, not business reimplementations."""
import json,struct,sys,itertools,hashlib
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];W=Path(__file__).resolve().parent;OUT=W/'manager-validation';OUT.mkdir(exist_ok=True)
sys.path.insert(0,str(ROOT/'work/tools/unicorn-recovery'))
from unicorn import Uc,UC_ARCH_ARM64,UC_MODE_ARM,UC_HOOK_CODE,UC_HOOK_MEM_UNMAPPED
import unicorn.arm64_const as a
raw=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes();po=struct.unpack_from('<Q',raw,32)[0];ps,pn=struct.unpack_from('<HH',raw,54)
segs=[struct.unpack_from('<IIQQQQQQ',raw,po+i*ps) for i in range(pn)]
so=struct.unpack_from('<Q',raw,40)[0];ss,sn=struct.unpack_from('<HH',raw,58);relocs={}
for n in range(sn):
 s=struct.unpack_from('<IIQQQQIIQQ',raw,so+n*ss)
 if s[1]==4:
  for at in range(s[4],s[4]+s[5],s[9] or 24):
   of,inf,ad=struct.unpack_from('<QQq',raw,at)
   if inf&0xffffffff==1027:relocs[of]=ad
pages={}
for of,ad in relocs.items():pages.setdefault(of&~0xfff,[]).append((of,ad))
cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM);mapped=set()
def map_page(p):
 if p in mapped:return
 cpu.mem_map(p,0x1000);mapped.add(p)
 for s in segs:
  if s[0]!=1:continue
  lo=max(p,s[3]);hi=min(p+4096,s[3]+s[5])
  if hi>lo:cpu.mem_write(lo,raw[s[2]+lo-s[3]:s[2]+hi-s[3]])
 for of,ad in pages.get(p,[]):cpu.mem_write(of,struct.pack('<Q',ad))
def unmapped(uc,access,addr,size,val,user):
 for p in range(addr&~0xfff,(addr+size+4095)&~0xfff,4096):map_page(p)
 return True
cpu.hook_add(UC_HOOK_MEM_UNMAPPED,unmapped)
def wr(p,b):
 for pg in range(p&~0xfff,(p+len(b)+4095)&~0xfff,4096):map_page(pg)
 cpu.mem_write(p,b)
def qw(p,v):wr(p,struct.pack('<Q',v))
def iw(p,v):wr(p,struct.pack('<I',v&0xffffffff))
def ir(p):return struct.unpack('<i',cpu.mem_read(p,4))[0]
SELF,STATE,SCENE,LIST1,LIST2,BOX,STOP,STACK,CLASS=0x10000000,0x10001000,0x10002000,0x10003000,0x10004000,0x10005000,0x30000000,0x20000000,0x10006000
for p in [SELF,STATE,SCENE,LIST1,LIST2,BOX,CLASS,STOP]:wr(p,bytes(4096))
wr(STACK,bytes(0x10000));qw(STATE+40,SELF);qw(SCENE+176,LIST1);qw(SCENE+184,LIST2);iw(CLASS+224,1);qw(0x8cea738,CLASS)
mapping=json.loads((ROOT/'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'))
names={r['Name']:r['Address'] for r in mapping['ScriptMethod']}
def addr(contains):
 found=[r for r in mapping['ScriptMethod'] if r['Name']==contains];assert len(found)==1,contains;return found[0]['Address']
hooks={0x3c3d280:'metadata',0x3c3d3b0:'class',0x3c3d3b8:'box',0x5978460:'singleton',0x3c3d4cc:'null',0x3de3fd8:'gameEnd',0x3de5278:'countdown',0x3dea61c:'never-hook-original-iterator'}
for label,name in [('event','EventModule.EventManager$$TriggerEvent'),('buff','GameModule.SubGameBuffManager$$OnCoinChanged'),('buffSingleton','GameModule.SubGameBuffManager$$get_Instance'),('timeScale','UnityEngine.Time$$get_timeScale'),('stop','UnityEngine.MonoBehaviour$$StopCoroutine'),('start','UnityEngine.MonoBehaviour$$StartCoroutine'),('result','System.Runtime.CompilerServices.AsyncVoidMethodBuilder$$SetResult'),('playerHex','GameModule.BattleGameSceneManager$$get_PlayerHasHex'),('enemyHex','GameModule.BattleGameSceneManager$$get_EnemyHasHex')]:
 # Overloads are disambiguated by exact address in native caller metadata below.
 found=[r for r in mapping['ScriptMethod'] if r['Name']==name]
 if len(found)==1:hooks[found[0]['Address']]=label
 else:
  wanted={'stop':0x830c9dc,'start':0}.get(label,0)
  # Use direct callsite targets from the exact function ASM export.
  import re
  asm=(W/'ida/pseudocode/0x3dea22c.asm.txt').read_text()
  for r in found:
   if any(hex(r['Address'])[2:].lower() in line.lower() for line in asm.splitlines()):hooks[r['Address']]=label
  # IDA may have renamed a call rather than printed its address; use signature.
  if label=='stop':
   r=next(r for r in found if 'UnityEngine_Coroutine_o* routine' in r['Signature']);hooks[r['Address']]=label
  if label=='start':
   r=next(r for r in found if 'System_Collections_IEnumerator_o* routine' in r['Signature']);hooks[r['Address']]=label
events={0x60000010:'PlayerGameCostCoin',0x60000020:'CoinChangeUpdateGamePanel',0x60000030:'PlayerCoinChange'}
for slot,val in [(0x8d6c138,0x60000010),(0x8d5c020,0x60000020),(0x8d6c128,0x60000030)]:qw(slot,val)
sc={};trace=[]
def hook(uc,pc,size,user):
 label=hooks.get(pc)
 if label is None:return
 x=[cpu.reg_read(getattr(a,'UC_ARM64_REG_X'+str(i))) for i in range(4)]
 if label=='metadata' or label=='class':pass
 elif label=='singleton' or label=='buffSingleton':cpu.reg_write(a.UC_ARM64_REG_X0,SCENE)
 elif label=='box':iw(BOX,ir(x[1]));cpu.reg_write(a.UC_ARM64_REG_X0,BOX)
 elif label=='event':trace.append([events[x[1]],None if x[2]==0 else ir(x[2]),ir(SELF+40)])
 elif label=='buff':trace.append(['buff',int(x[1]),int(x[2])])
 elif label=='gameEnd':trace.append(['gameEnd',int(x[1]),int(x[2])])
 elif label=='timeScale':cpu.reg_write(a.UC_ARM64_REG_S0,sc['scaleBits'])
 elif label=='stop':trace.append(['stop'])
 elif label=='start':trace.append(['start']);cpu.reg_write(a.UC_ARM64_REG_X0,0x60001000)
 elif label=='countdown':trace.append(['countdown']);cpu.reg_write(a.UC_ARM64_REG_X0,0x60002000)
 elif label=='result':pass
 elif label=='playerHex':cpu.reg_write(a.UC_ARM64_REG_W0,sc['pHex'])
 elif label=='enemyHex':cpu.reg_write(a.UC_ARM64_REG_W0,sc['eHex'])
 else:raise RuntimeError(label)
 cpu.reg_write(a.UC_ARM64_REG_PC,cpu.reg_read(a.UC_ARM64_REG_LR))
for p in hooks:map_page(p&~4095)
cpu.hook_add(UC_HOOK_CODE,hook)
def execute(rva,this,arg=0):
 cpu.reg_write(a.UC_ARM64_REG_SP,STACK+0x10000);cpu.reg_write(a.UC_ARM64_REG_LR,STOP)
 cpu.reg_write(a.UC_ARM64_REG_X0,this);cpu.reg_write(a.UC_ARM64_REG_X1,arg&0xffffffff)
 cpu.emu_start(rva,STOP,count=10000)
 assert cpu.reg_read(a.UC_ARM64_REG_PC)==STOP,hex(cpu.reg_read(a.UC_ARM64_REG_PC))
rows=[]
for has,delta,earned,cost in [(10,-20,0,0),(10,-3,0,0),(10,0,2,3),(9999999,3,0,0),(2147483647,1,2147483647,0),(0,-2147483648,0,0),(-10,-2,0,0),(0,2147483647,0,0),(10,-1,0,2147483647)]:
 trace=[];iw(SELF+40,has);iw(SELF+48,earned);iw(SELF+52,cost);execute(0x3de3cf4,SELF,delta)
 rows.append(dict(kind='coin',has=has,delta=delta,earned=earned,cost=cost,after=[ir(SELF+40),ir(SELF+48),ir(SELF+52)],trace=trace.copy()))
for scale,phex,ehex,prole,erole,coroutine in itertools.product([0,0x3f800000,0x7fc00000],[0,2],[0,2],[0,3],[0,3],[False,True]):
 sc=dict(scaleBits=scale,pHex=phex,eHex=ehex);trace=[];iw(LIST1+24,prole);iw(LIST2+24,erole);qw(SELF+88,0x60001000 if coroutine else 0);wr(SELF+60,struct.pack('<f',0.0));wr(SELF+80,b'\0');iw(STATE,-1)
 execute(0x3dea22c,STATE)
 rows.append(dict(kind='countdown',**sc,pRole=prole,eRole=erole,coroutine=coroutine,timeBits=struct.unpack('<I',cpu.mem_read(SELF+60,4))[0],isCountDowning=bool(cpu.mem_read(SELF+80,1)[0]),trace=trace.copy()))
(OUT/'native-oracle.json').write_text(json.dumps(rows,indent=2),encoding='utf-8')
(OUT/'native-summary.json').write_text(json.dumps(dict(cases=len(rows),coin_cases=9,countdown_cases=len(rows)-9,external_hooks={hex(k):v for k,v in hooks.items()},elf_sha256=hashlib.sha256(raw).hexdigest()),indent=2),encoding='utf-8')
print('Executed original manager ARM64 cases:',len(rows))
