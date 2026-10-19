from pathlib import Path
import json
r=Path.cwd();s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));matches=[m for m in s['ScriptMethod'] if 'Conflict' in m['Name'] or 'Comflict' in m['Name']]
(r/'work/stage46-account-mode/conflict-native-inventory.json').write_text(json.dumps(matches,ensure_ascii=False,indent=2),encoding='utf-8')
print('Conflict named methods:',len(matches))
for m in matches[:60]:print(hex(m['Address']),m['Name'])
