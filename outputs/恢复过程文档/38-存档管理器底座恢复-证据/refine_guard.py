import json,hashlib
from pathlib import Path
w=Path(__file__).parent
path=w/'candidate/Assets/Scripts/GFRunning/GameFramework/DataManagerBase.cs'
before=path.read_bytes();text=before.decode('utf-8')
old='{\n    LocalEditorStore.Write(DataKey, _008C_00A8_00A1cf_00A6);\n    return;'
new='{\n    if (_007C_007Ev_00A8G_00BB && DataManagerPool.CanSaveLocalData && (int)GameFramework.Login.ILoginProcedure.accountType >= 10)\n        LocalEditorStore.Write(DataKey, _008C_00A8_00A1cf_00A6);\n    return;'
assert text.count(old)==1
path.write_bytes(text.replace(old,new).encode('utf-8'))
plan=json.loads((w/'write-plan.json').read_text(encoding='utf-8'))
for f in plan['files']:
 if f['path'].endswith('/DataManagerBase.cs'):
  for m in f['methods']:
   if m['token']=='0x600581A':m['body']=m['body'].replace('    LocalEditorStore.Write(DataKey, _008C_00A8_00A1cf_00A6);','    if (_007C_007Ev_00A8G_00BB && DataManagerPool.CanSaveLocalData && (int)GameFramework.Login.ILoginProcedure.accountType >= 10)\n        LocalEditorStore.Write(DataKey, _008C_00A8_00A1cf_00A6);')
(w/'write-plan.json').write_text(json.dumps(plan,ensure_ascii=False,indent=2),encoding='utf-8')
(w/'guard-refinement.json').write_text(json.dumps(dict(file='Assets/Scripts/GFRunning/GameFramework/DataManagerBase.cs',beforeSha256=hashlib.sha256(before).hexdigest().upper(),afterSha256=hashlib.sha256(path.read_bytes()).hexdigest().upper(),reason='Preserve original local enable / Pool.CanSaveLocalData / AccountType>=10 gates inside Editor storage adapter before I/O',productionApplied=False),ensure_ascii=False,indent=2),encoding='utf-8')
print('Refined work candidate only; production remains at previous hash pending fresh verification')
