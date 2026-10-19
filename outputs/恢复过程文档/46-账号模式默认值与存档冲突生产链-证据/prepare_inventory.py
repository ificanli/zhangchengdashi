from pathlib import Path
import json
r=Path.cwd();w=r/'work/stage46-account-mode';s=json.loads((r/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
rows=[x for x in s['ScriptMethod'] if x['Name'].startswith('GameFramework.Login.ILoginProcedure$$')]
(w/'account-native-inventory.json').write_text(json.dumps(rows,ensure_ascii=False,indent=2),encoding='utf-8')
for x in rows:print(hex(x['Address']),x['Name'])
refs=[dict(kind=k,**x) for k in ['ScriptMetadata','ScriptMetadataMethod'] for x in s[k] if 'ILoginProcedure_TypeInfo' in x.get('Name','') or '.set_accountType()' in x.get('Name','') or 'DataManager.ChooseConflict()' in x.get('Name','')]
(w/'account-producer-slots.json').write_text(json.dumps(refs,ensure_ascii=False,indent=2),encoding='utf-8')
print(refs)
