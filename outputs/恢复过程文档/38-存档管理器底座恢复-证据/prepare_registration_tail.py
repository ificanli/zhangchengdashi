from pathlib import Path
import bisect,json
r=Path.cwd();w=r/'work/stage38-savebase';s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));ms={m['Address']:m for m in s['ScriptMethod']};ends=sorted(set(s['Addresses']))
rows=[]
for a,p,t in [(0x7178538,'void AutoRegister(void* self,const MethodInfo* method);','0x6005877'),(0x717B0B8,'void PoolCctor(const MethodInfo* method);','0x600587E'),(0x7179184,'void* PoolDictionary(void* self,const MethodInfo* method);','0x6005869'),(0x72B7900,'void BackendCtor(void* self,const MethodInfo* method);',None),(0x72BA280,'void BackendInit(void* self,const MethodInfo* method);',None)]:
 m=ms[a];rows.append(dict(name=m['Name'],address=a,end=ends[bisect.bisect_right(ends,a)],signature=m['Signature'],prototype=p,method_token=t,note='Last bounded producer dependency, readonly before scope review; no SDK tree expansion'))
(w/'registration-tail-targets.json').write_text(json.dumps(rows,ensure_ascii=False,indent=2),encoding='utf-8');print('Prepared',len(rows),'final bounded producer candidates')
