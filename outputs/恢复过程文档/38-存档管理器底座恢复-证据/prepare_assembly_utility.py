from pathlib import Path
import json,bisect
r=Path.cwd();s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));m={x['Address']:x for x in s['ScriptMethod']};ends=sorted(set(s['Addresses']));rows=[]
for a,t,p in [(0x71E1B58,'0x6006008','void* LoadOriginalAssembly(void* name,const MethodInfo* method);'),(0x71E1D78,'0x6006009','void* LoadOriginalCSharp(const MethodInfo* method);'),(0x71E1E44,'0x600600A','void AssemblyUtilityCctor(const MethodInfo* method);')]:
 x=m[a];rows.append(dict(name=x['Name'],address=a,end=ends[bisect.bisect_right(ends,a)],signature=x['Signature'],prototype=p,method_token=t,file='Assets/Scripts/GFRunning/GameFramework/Utility.cs'))
(r/'work/stage38-savebase/assembly-utility-targets.json').write_text(json.dumps(rows,ensure_ascii=False,indent=2),encoding='utf-8')
