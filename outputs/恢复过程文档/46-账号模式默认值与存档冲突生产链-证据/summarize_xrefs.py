from pathlib import Path
import json,collections
r=Path.cwd();p=r/'work/ida-framework-assets/xrefs-stage46-account.json';j=json.loads(p.read_text(encoding='utf-8-sig'));out=[]
for group in j['results']:
 funcs={}
 for row in group.get('direct',[])+group.get('secondLevel',[]):
  m=row.get('metadata_preceding_method')
  if m:funcs[m['Address']]=m
 out.append(dict(target=group['address'],name=group['name'],direct=len(group.get('direct',[])),secondLevel=len(group.get('secondLevel',[])),functions=list(funcs.values())))
 print(group['address'],group['name'],'direct',len(group.get('direct',[])),'second',len(group.get('secondLevel',[])),'function count',len(funcs))
 for m in funcs.values():print(' ',hex(m['Address']),m['Name'])
(r/'work/stage46-account-mode/xref-function-summary.json').write_text(json.dumps(out,ensure_ascii=False,indent=2),encoding='utf-8')
