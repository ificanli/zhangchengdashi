from pathlib import Path
import json
s=json.loads(Path('work/ida-framework-assets/status-stage38-supplement.json').read_text(encoding='utf-8-sig'))
for m in s['methods']:
 if m['address']==0x71783A4:
  for c in m['direct_callees']:print(c)
