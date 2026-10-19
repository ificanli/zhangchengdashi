from pathlib import Path
import json
r=Path.cwd();s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));keys={0x8D53EC0,0x8D53728,0x8D77010};refs=[x for x in s['ScriptString'] if x['Address'] in keys];print(refs)
(r/'work/stage49-model-defaults/default-string-refs.json').write_text(json.dumps(refs,ensure_ascii=False,indent=2),encoding='utf-8')
