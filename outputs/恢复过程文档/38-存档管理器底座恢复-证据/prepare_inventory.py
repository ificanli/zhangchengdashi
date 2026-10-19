from pathlib import Path
import json
r=Path.cwd();s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
methods=[m for m in s['ScriptMethod'] if 'DbtSaveDataManagerBase' in m.get('Name','') or 'DataManagerBase$$' in m.get('Name','')]
Path('work/stage38-savebase/native-method-inventory.json').write_text(json.dumps(methods,ensure_ascii=False,indent=2),encoding='utf-8')
for m in methods:print(hex(m['Address']),m['Name'],m['Signature'])
print('REFS')
refs=[m for m in s['ScriptMetadataMethod'] if 'DbtSaveDataManagerBase<DbtSaveDataManager_PlayerTimeData, PlayerTimeData>' in m.get('Name','') or 'DbtSaveDataManagerBase<DbtSaveDataManager_PlayerCoreData, PlayerCoreData>' in m.get('Name','')]
Path('work/stage38-savebase/coretime-generic-slots.json').write_text(json.dumps(refs,ensure_ascii=False,indent=2),encoding='utf-8')
for m in refs:print(hex(m['Address']),m['Name'],hex(m['MethodAddress']))
