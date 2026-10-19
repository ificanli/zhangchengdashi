from pathlib import Path
import json,re
r=Path.cwd();w=r/'work/stage49-model-defaults';models=json.loads((w/'model-inventory.json').read_text(encoding='utf-8'));byfile={m['source']:m for m in models};facts=[]
for t in json.loads((w/'native-targets.json').read_text(encoding='utf-8')):
 c=(r/'work/ida-framework-assets/pseudocode'/f"0x{t['address']:x}.c").read_text(encoding='utf-8');model=byfile[t['file']];fields={int(f['offset'],16):f for f in model['fields'] if not f['IsStatic'] and f.get('offset')}
 stores=[]
 for match in re.finditer(r'\*\(\(_(QWORD|DWORD|WORD|BYTE) \*\)self \+ (\d+)\) = ([^;]+);',c):
  kind,index,value=match.groups();size={'QWORD':8,'DWORD':4,'WORD':2,'BYTE':1}[kind];offset=int(index)*size
  covered=[dict(name=f['Name'],token=f['token'],type=f['type'],offset=f['offset']) for o,f in fields.items() if offset<=o<offset+size]
  stores.append(dict(offset=hex(offset),size=size,nativeValue=value,fields=covered))
 facts.append(dict(name=t['name'],address=hex(t['address']),stores=stores,unresolvedJumpout='JUMPOUT' in c,codeBytes=len(c.encode()),note='Direct C field stores only; unaligned/char*/vector and conditional semantics require raw C/ARM64 review'))
(w/'native-field-store-map.json').write_text(json.dumps(facts,ensure_ascii=False,indent=2),encoding='utf-8')
(w/'range-corrections.json').write_text(json.dumps([dict(name='DataModule.PlayerWorldCupActivityData..ctor',originalRequestedStart='0x437A9E8',originalRequestedEnd='0x437AEFC',verifiedCtorTail='0x437AAC0',reachableCtorEnd='0x437AAC4',reason='Unconditional tail B ServerBaseData..ctor after full epilogue; later addresses are unrelated UniTask state-machine thunks, exclude from ctor call graph and oracle')],ensure_ascii=False,indent=2),encoding='utf-8')
print('Mapped',sum(len(x['stores']) for x in facts),'direct field stores; range-correction and unresolved-Arena notes recorded')
