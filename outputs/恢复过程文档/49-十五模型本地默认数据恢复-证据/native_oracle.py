from pathlib import Path
import sys,json,re,struct,math,hashlib
r=Path(__file__).resolve().parents[2];w=r/'work/stage49-model-defaults';sys.path.insert(0,str(r/'work/tools/unicorn-recovery'))
from unicorn import Uc,UC_ARCH_ARM64,UC_MODE_ARM,UC_HOOK_CODE
import unicorn.arm64_const as A
mapping=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));symbols={m['Address']:m for m in mapping['ScriptMethod']};metadata={m['Address']:m for m in mapping['ScriptMetadata']};methodmeta={m['Address']:m for m in mapping['ScriptMetadataMethod']};strings={m['Address']:m['Value'] for m in mapping['ScriptString']};ends=sorted(set(mapping['Addresses']))
code=(r/'work/recovery-input/lib/arm64-v8a/libil2cpp.so').read_bytes();models=json.loads((w/'model-inventory.json').read_text(encoding='utf-8'));models.append(json.loads((w/'child-metadata.json').read_text(encoding='utf-8')));types={m['dataType']:m for m in models};plans=json.loads((w/'write-plan.json').read_text(encoding='utf-8'))['files'];selected={x['token'] for f in plans for x in f['methods']}
phoff=struct.unpack_from('<Q',code,32)[0];phsize,phnum=struct.unpack_from('<HH',code,54)
segments=[struct.unpack_from('<IIQQQQQQ',code,phoff+i*phsize) for i in range(phnum)]
def va_bytes(a,n):
 for typ,flags,off,va,pa,fs,ms,align in segments:
  if typ==1 and va<=a and a+n<=va+fs:return code[off+a-va:off+a-va+n]
 raise RuntimeError('No mapped ELF data '+hex(a))
targets={t['method_token']:t for name in ['native-targets.json','supplement-targets.json'] for t in json.loads((w/name).read_text(encoding='utf-8')) if t.get('method_token')}
ctor={m['dataType']:int(x['rva'],16) for m in models if 'ownMethods'in m for x in m['ownMethods'] if x['Name']=='.ctor'};ctor['DataModule.SeasonData']=0x436A224
seed_offsets={'DataModule.PlayerMainCityData':[0x10],'DataModule.PlayerArenaData':[0x10],'DataModule.PlayerResourceData':[0x10],'DataModule.PlayerShopData':[0xA0,0xD8,0xA8,0x60],'DataModule.PlayerCustomizationData':[0x18],'DataModule.PlayerCoreData':[0x60]}
all_asm='\n'.join((r/'work/ida-framework-assets/pseudocode'/f'0x{a:x}.asm.txt').read_text(encoding='utf-8') for a in set(ctor.values())|{t['address'] for t in targets.values()} if (r/'work/ida-framework-assets/pseudocode'/f'0x{a:x}.asm.txt').exists())
aliases={int(a,16):int(b,16) for a,b in re.findall(r'#off_([0-9A-F]+)@PAGEOFF\];\s*(?:off|qword|unk)_([0-9A-F]+)',all_asm)};guards=set(int(x,16) for x in re.findall(r'byte_(900[0-9A-F]+)',all_asm))
def execute(type_name,method_name,address,seed='normal'):
 cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM);pages=set();heap=0x20000000;objects={};classes={};classnames={};rng=[];draws=[];created_random=0;error=None;sent=0x30001000;randnext=0x30002000;rootobj=0x31000000
 def write(a,b):
  for page in range(a&~4095,(a+len(b)+4095)&~4095,4096):
   if page not in pages:cpu.mem_map(page,4096);pages.add(page)
  cpu.mem_write(a,b)
 def readq(a):return struct.unpack('<Q',cpu.mem_read(a,8))[0]
 def ptr(a,v):write(a,struct.pack('<Q',v))
 def alloc(n=1024):
  nonlocal heap
  p=heap;heap+=((n+15)//16)*16;write(p,bytes(n));return p
 def text(value):
  p=alloc();objects[p]={'kind':'string','value':value};return p
 def cls(label):
  if label not in classes:
   p=alloc(2048);stat=alloc();classes[label]=p;classnames[p]=label;ptr(p+0xB8,stat);write(p+0xE0,struct.pack('<I',1));ptr(p+408,randnext)
  return classes[label]
 def obj(label,count=0,items=None):
  p=alloc();ptr(p,cls(label))
  if 'List<'in label or 'List`'in label:
   array=alloc();write(array+24,struct.pack('<I',64));ptr(p+16,array);write(p+24,struct.pack('<i',count));objects[p]={'kind':'list','label':label}
   for i,x in enumerate(items or []):write(array+32+i*4,struct.pack('<i',x))
  elif 'Dictionary<'in label or 'Dictionary`'in label:objects[p]={'kind':'dictionary','count':count,'label':label}
  else:objects[p]={'kind':'object','label':label}
  return p
 for a,b in aliases.items():ptr(a,b)
 for a,v in metadata.items():
  if a not in set(aliases.values()):continue
  p=cls(v['Name']);ptr(a,p)
  if v['Name']=='string_TypeInfo':ptr(readq(p+0xB8),text(''))
 for a in set(aliases.values())&methodmeta.keys():ptr(a,alloc())
 for a in set(aliases.values())&strings.keys():ptr(a,text(strings[a]))
 for a in guards:write(a,b'\x01')
 for literal in set(int(x,16) for x in re.findall(r'#(?:qword|dword|xmmword)_([0-9A-F]+)@PAGE',all_asm)):
  write(literal,va_bytes(literal,16))
 def load(a,end):write(a,code[a-0x4000:end-0x4000])
 import bisect
 for a in set(ctor.values())|{t['address'] for t in targets.values()}:
  end=ends[bisect.bisect_right(ends,a)]
  if a==0x437A9E8:end=0x437AAC4
  load(a,end)
 load(0x856E7E0,0x856E7E8)
 write(rootobj,bytes(2048));ptr(rootobj,cls(type_name+'_TypeInfo'));objects[rootobj]={'kind':'object','label':type_name+'_TypeInfo'}
 write(sent,b'\x1f\x20\x03\xd5');write(randnext,b'\xc0\x03\x5f\xd6');stack=alloc(16384);cpu.reg_write(A.UC_ARM64_REG_SP,stack+8192)
 for a in symbols:
  # Only create external entry stubs on demand in reachable BL target pages.
  pass
 for a in set(int(x,16) for x in re.findall(r'0x([0-9a-f]+):\s+BL\s',all_asm)):pass
 # BL destinations are decoded from original instructions, not candidate source.
 for page in list(pages):
  if not (0x4000000<=page<0x9000000):continue
  raw=bytes(cpu.mem_read(page,4096))
  for off in range(0,4096,4):
   ins=struct.unpack_from('<I',raw,off)[0]
   if ins>>26==0b100101:
    delta=ins&0x3FFFFFF;delta=delta-(1<<26) if delta&(1<<25) else delta;dst=page+off+delta*4
    if dst//4096*4096 not in pages:write(dst,b'\xc0\x03\x5f\xd6')
 def ret(v=None):
  if v is not None:cpu.reg_write(A.UC_ARM64_REG_X0,v&0xFFFFFFFFFFFFFFFF)
  cpu.reg_write(A.UC_ARM64_REG_PC,cpu.reg_read(A.UC_ARM64_REG_X30))
 def getstr(p):return objects.get(p,{}).get('value')
 def hook(machine,a,size,data):
  nonlocal error,created_random
  x0=cpu.reg_read(A.UC_ARM64_REG_X0);x1=cpu.reg_read(A.UC_ARM64_REG_X1);x2=cpu.reg_read(A.UC_ARM64_REG_X2);name=symbols.get(a,{}).get('Name','')
  if a in [0x3C3D4C4]:ret(obj(classnames[x0]));return
  if a in [0x3C3D4CC] or 'raise_null_reference' in name:error='NullReferenceException';cpu.emu_stop();return
  if a==0x3D20318:
   if x0==rootobj:cpu.emu_stop()
   else:ret()
   return
  if a in [0x3D20310,0x3D20314]:ret();return
  if a==randnext:
   assert (x1,x2)==(0,9),(x1,x2);v=rng.pop(0);draws.append(dict(kind='System.Random.Next',min=x1,max=x2,value=v));ret(v);return
  if name.startswith('System.Collections.Generic.') and name.endswith('$$.ctor'):
   record=objects[x0]
   if record['kind']=='list':
    array=alloc();write(array+24,struct.pack('<I',64));ptr(x0+16,array);write(x0+24,bytes(8))
   ret();return
  if name=='System.Object$$.ctor':ret();return
  if name=='System.Random$$.ctor':created_random+=1;ret();return
  if name=='UnityEngine.Random$$Range':
   assert (x0,x1)==(0,100),(x0,x1);v=rng.pop(0);draws.append(dict(kind=name,min=x0,max=x1,value=v));ret(v);return
  if name=='System.Math$$Pow':
   v0=struct.unpack('<d',struct.pack('<Q',cpu.reg_read(A.UC_ARM64_REG_D0)))[0];v1=struct.unpack('<d',struct.pack('<Q',cpu.reg_read(A.UC_ARM64_REG_D1)))[0];cpu.reg_write(A.UC_ARM64_REG_D0,struct.unpack('<Q',struct.pack('<d',math.pow(v0,v1)))[0]);ret();return
  if name=='ToolModule.StringTool$$IsNullOrEmpty':v=getstr(x0);ret(v is None or not (v.strip() if x1 else v));return
  if name=='System.Int32$$ToString':ret(text(str(struct.unpack('<i',cpu.mem_read(x0,4))[0])));return
  if a==0x74FE7A4 or name=='System.String$$Concat':ret(text((getstr(x0)or'')+(getstr(x1)or'')));return
  if a in [sent]:return
  if a in symbols and not (ctor[type_name]<=a<ctor[type_name]+4) and a not in [address,0x436A224]:
   error='UNHANDLED_NATIVE_CALL '+hex(a)+' '+name;cpu.emu_stop()
 cpu.hook_add(UC_HOOK_CODE,hook)
 def run(a,constructor=False):
  cpu.reg_write(A.UC_ARM64_REG_X0,rootobj);cpu.reg_write(A.UC_ARM64_REG_X1,0);cpu.reg_write(A.UC_ARM64_REG_X30,sent);cpu.reg_write(A.UC_ARM64_REG_SP,stack+8192)
  try:cpu.emu_start(a,sent,count=50000)
  except Exception as ex:raise RuntimeError(f"{type_name} {method_name} {seed}: pc={cpu.reg_read(A.UC_ARM64_REG_PC):#x} x0={cpu.reg_read(A.UC_ARM64_REG_X0):#x} x1={cpu.reg_read(A.UC_ARM64_REG_X1):#x}") from ex
  if error is None:assert cpu.reg_read(A.UC_ARM64_REG_PC) in [sent,0x3D20318],('Native did not terminate at original return/base tail',type_name,method_name,seed,hex(cpu.reg_read(A.UC_ARM64_REG_PC)))
 run(ctor[type_name],True)
 if error:raise RuntimeError(error)
 offsets=seed_offsets.get(type_name,[])
 if method_name=='Init':offsets=[0xB8]
 fields=types[type_name]['fields'];seed_pointers={}
 if method_name!='.ctor':
  for f in fields:
   if f.get('IsStatic') or not f.get('offset'):continue
   off=int(f['offset'],16)
   if off not in offsets:continue
   if seed=='null':ptr(rootobj+off,0)
   elif seed=='existing':
    label=f['type'];p=text('ExistingName') if label in ['System.String','string'] else obj(label,1,[999]);ptr(rootobj+off,p);seed_pointers[off]=p
  rng[:]=[0,79,80,99] if type_name=='DataModule.PlayerCoreData' else [8,7,6,5,4,3]
  run(address)
 result={};preserved={}
 for f in fields:
  if f.get('IsStatic'):continue
  off=int(f['offset'],16);typ=f['type'];at=rootobj+off;v=None
  if typ in ['System.Int32','int','GameModule.ShopManager/TimingPushGiftPackType']:v=struct.unpack('<i',cpu.mem_read(at,4))[0]
  elif typ in ['System.Boolean','bool']:v=bool(cpu.mem_read(at,1)[0])
  elif typ in ['System.Single','float']:v=struct.unpack('<f',cpu.mem_read(at,4))[0]
  elif typ in ['System.Int64','long']:v=struct.unpack('<q',cpu.mem_read(at,8))[0]
  elif typ=='System.DateTime':v={'kind':'date','ticks':readq(at)&0x3FFFFFFFFFFFFFFF}
  elif typ=='System.Numerics.BigInteger':
   assert readq(at+8)==0,'Non-small BigInteger outside this native scope'
   v={'kind':'bigint','value':str(struct.unpack('<i',cpu.mem_read(at,4))[0])}
  else:
   p=readq(at)
   if p:
    record=objects[p];kind=record['kind']
    if kind=='string':v=record['value']
    elif kind=='dictionary':v={'kind':'dictionary','count':record.get('count',0)}
    elif kind=='list':
     count=struct.unpack('<i',cpu.mem_read(p+24,4))[0];v={'kind':'list','count':count}
     if typ.endswith('<System.Int32>') or typ=='List<int>':v['items']=[struct.unpack('<i',cpu.mem_read(readq(p+16)+32+i*4,4))[0] for i in range(count)]
    else:v={'kind':'object'}
   if off in seed_pointers:preserved[f['Name']]=p==seed_pointers[off]
  result[f['Name']]=v
 end=0x437AAC4 if address==0x437A9E8 else ends[bisect.bisect_right(ends,address)]
 return dict(dataType=type_name,method=method_name,address=hex(address),end=hex(end),originalCodeSha256=hashlib.sha256(va_bytes(address,end-address)).hexdigest().upper(),seed=seed,error=error,fields=result,preserved=preserved,draws=draws,randomConstructors=created_random)
rows=[]
for name,a in ctor.items():rows.append(execute(name,'.ctor',a))
for model in models:
 for m in model.get('ownMethods',[]):
  if m['token'] in selected and m['Name']!='.ctor':
   for seed in ['normal','null','existing']:rows.append(execute(model['dataType'],m['Name'],int(m['rva'],16),seed))
(w/'native-golden.json').write_text(json.dumps(rows,ensure_ascii=False,indent=2),encoding='utf-8');print('Original ARM64 cases',len(rows),'executed; BCL collections/RNG/strings are explicit boundary hooks; TD field writes and branching execute original code')
