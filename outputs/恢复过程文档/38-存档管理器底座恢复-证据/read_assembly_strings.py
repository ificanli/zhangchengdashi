from pathlib import Path
import json
s=json.loads(Path('work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
print([x for x in s['ScriptString'] if x['Address'] in [0x8D56B20,0x8D86710]])
