from pathlib import Path
import json
r=Path.cwd();w=r/'work/stage49-model-defaults';status=json.loads((r/'work/ida-framework-assets/status-stage49-defaults.json').read_text(encoding='utf-8-sig'));assert status['stage']=='complete';rows=[]
for m in status['methods']:
 cs=m.get('direct_callees',[]);nonBcl=[c for c in cs if not c.get('name','').startswith(('System.','il2cpp_','UnityEngine.'))]
 rows.append(dict(name=m['name'],address=hex(m['address']),calls=nonBcl,normalCallCount=len(cs)))
 print(hex(m['address']),m['name'])
 for c in nonBcl:print(' ',c['address'],c['name'])
(w/'native-dependency-classification.json').write_text(json.dumps(rows,ensure_ascii=False,indent=2),encoding='utf-8')
