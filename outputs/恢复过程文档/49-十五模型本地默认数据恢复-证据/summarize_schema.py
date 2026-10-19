from pathlib import Path
import json,collections
w=Path('work/stage49-model-defaults');m=json.loads((w/'model-inventory.json').read_text(encoding='utf-8'));rows=[]
for x in m:
 fields=x['fields'];d=[f for f in fields if f['type'].startswith('System.Collections.Generic.Dictionary`2')];l=[f for f in fields if f['type'].startswith('System.Collections.Generic.List`1')];h=[f for f in fields if f['type'].startswith('System.Collections.Generic.HashSet`1')]
 rows.append(dict(index=x['nativeLoadIndex'],dataType=x['dataType'],fields=len(fields),dictionaries=len(d),lists=len(l),sets=len(h),collectionFields=[dict(name=f['Name'],type=f['type'],token=f['token'],offset=f['offset']) for f in d+l+h],inheritedInit=x['inheritedInit'],inheritedDefaults=x['inheritedDefaults'],protected=x['protectedExisting']))
summary=dict(models=len(rows),fields=sum(x['fields'] for x in rows),declaredCollections=sum(x['dictionaries']+x['lists']+x['sets'] for x in rows),inheritedInit=sum(x['inheritedInit'] for x in rows),inheritedDefaults=sum(x['inheritedDefaults'] for x in rows),rows=rows,note='Collection declarations are schema only, not proof native ctor initializes them; await bounded native body classification')
(w/'schema-priority.json').write_text(json.dumps(summary,ensure_ascii=False,indent=2),encoding='utf-8');print({k:v for k,v in summary.items() if k not in ['rows','note']})
