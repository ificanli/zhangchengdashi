from pathlib import Path
import json
r=Path.cwd();s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));status=json.loads((r/'work/ida-framework-assets/status-stage38-savebase.json').read_text(encoding='utf-8-sig'))
for m in status['methods']:
 if 'GameFramework.DataManagerBase' in m['name']:
  print(m['name'])
  for c in m.get('direct_callees',[]):print(c['address'],c['name'])
print('POOL')
for m in s['ScriptMethod']:
 if m['Name'].startswith('GameFramework.DataManagerPool$$') or 'GameFramework.DataManagerPool$$' in m['Name'] or m['Name'].startswith('GameFramework.DataManagerPool.') or 'DataManagerPool$$GetModel' in m['Name'] or 'DataManagerPool$$AddModel' in m['Name']: print(hex(m['Address']),m['Name'])
