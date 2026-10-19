from pathlib import Path
import json
s=json.loads(Path('work/stage38-savebase/native-refs.json').read_text(encoding='utf-8'))
for m in s:
 if m['Address']==0x8D371A0:print(m)
