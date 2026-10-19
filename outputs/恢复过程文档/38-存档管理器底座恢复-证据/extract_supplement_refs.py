from pathlib import Path
import json,re
r=Path.cwd();s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));addrs=set()
for fn in ['supplement-targets.json','registration-tail-targets.json']:
 for t in json.loads((r/'work/stage38-savebase'/fn).read_text(encoding='utf-8-sig')):
  p=r/'work/ida-framework-assets/pseudocode'/f"0x{t['address']:x}.c"
  addrs.update(int(x,16) for x in re.findall(r'(?:off|qword|unk)_([0-9A-Fa-f]{7,})',p.read_text(encoding='utf-8')))
refs=[dict(kind=k,**x) for k in ['ScriptMetadata','ScriptMetadataMethod','ScriptString'] for x in s[k] if x['Address'] in addrs]
(r/'work/stage38-savebase/supplement-refs.json').write_text(json.dumps(refs,ensure_ascii=False,indent=2),encoding='utf-8')
for x in refs:
 if x['Address'] in [0x8D53930,0x8D408D8,0x8D40900,0x8D408B0,0x8D408E8] or x['kind']=='ScriptString':print(hex(x['Address']),x.get('Value',x.get('Name')))
