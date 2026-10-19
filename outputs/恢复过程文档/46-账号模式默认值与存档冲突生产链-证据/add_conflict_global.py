from pathlib import Path
import json
r=Path.cwd();s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));refs=[x for x in s['ScriptMetadata'] if x.get('Name')=='DataModule.DataManager_TypeInfo'];print(refs)
p=r/'work/stage46-account-mode/xref-requests.json';j=json.loads(p.read_text(encoding='utf-8'));j['metadataGlobals'].extend(dict(address=hex(x['Address']),name=x['Name'],purpose='Incoming refs may inline static SaveConflictCheckFinish/ComflictStatus writes; select original conflict decision producers') for x in refs);p.write_text(json.dumps(j,ensure_ascii=False,indent=2),encoding='utf-8')
