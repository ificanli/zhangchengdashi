from pathlib import Path
import json,re
r=Path.cwd();s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));w=r/'work/stage46-account-mode';a=set()
for t in json.loads((w/'conflict-producer-targets.json').read_text(encoding='utf-8')):
 for ext in ['.c','.asm.txt']:
  text=(r/'work/ida-framework-assets/pseudocode'/f"0x{t['address']:x}{ext}").read_text(encoding='utf-8');a.update(int(x,16) for x in re.findall(r'(?:off|qword|unk)_([0-9A-Fa-f]{7,})',text))
refs=[dict(kind=k,**x) for k in ['ScriptMetadata','ScriptMetadataMethod','ScriptString'] for x in s[k] if x['Address'] in a]
(w/'conflict-native-refs.json').write_text(json.dumps(refs,ensure_ascii=False,indent=2),encoding='utf-8')
for x in refs:
 if x['Address'] in [0x8CEA258,0x8CE9C48,0x8D27CD8,0x8D27CC0]:print(hex(x['Address']),x.get('Name',x.get('Value')))
