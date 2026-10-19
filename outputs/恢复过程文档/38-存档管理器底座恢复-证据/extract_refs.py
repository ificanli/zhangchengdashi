from pathlib import Path
import json,re
r=Path.cwd();w=r/'work/stage38-savebase';s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
a=set()
for t in json.loads((w/'native-targets.json').read_text(encoding='utf-8')):
 c=(r/'work/ida-framework-assets/pseudocode'/f"0x{t['address']:x}.c").read_text(encoding='utf-8')
 a.update(int(v,16) for v in re.findall(r'(?:off|qword|unk)_([0-9A-Fa-f]{7,})',c))
refs=[]
for k in ['ScriptMetadata','ScriptMetadataMethod','ScriptString']:
 for m in s[k]:
  if m['Address'] in a:refs.append(dict(kind=k,**m))
(w/'native-refs.json').write_text(json.dumps(refs,ensure_ascii=False,indent=2),encoding='utf-8')
for m in refs:
 if m['Address'] in [0x8CE9FD0,0x8CEDAE8,0x8CEA1F0,0x8CEBB08,0x8CEF230,0x8CE8C58] or m['kind']=='ScriptString':print(hex(m['Address']),m.get('Name',m.get('Value')))
status=json.loads((r/'work/ida-framework-assets/status-stage38-savebase.json').read_text(encoding='utf-8-sig'))
for m in status['methods']:
 for c in m.get('direct_callees',[]):
  if c.get('name','').startswith('Oke') or 'DataCompressTools' in c.get('name',''):print('CALLEE',c)
