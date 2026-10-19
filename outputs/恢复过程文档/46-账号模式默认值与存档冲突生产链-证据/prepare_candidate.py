from pathlib import Path
import json
w=Path('work/stage46-account-mode');row=dict(path='Assets/Scripts/GFRunning/GameFramework/Login/ILoginProcedure.cs',autoProperties=[],methods=[dict(token='0x60074DF',body='{ return _00ACI_008A_00B9b_0098; }',makeAsync=False,iterator=False),dict(token='0x60074E0',body='{ _00ACI_008A_00B9b_0098 = value; }',makeAsync=False,iterator=False)],helperClassToken='0x20004EC',addHelper='''[Token(Token = "0x60074EE")]
[Address(RVA = "0x7301214", Offset = "0x72FD214", VA = "0x7301214")]
static ILoginProcedure() { _00ACI_008A_00B9b_0098 = AccountType.None; }''')
(w/'write-plan.json').write_text(json.dumps(dict(files=[row]),ensure_ascii=False,indent=2),encoding='utf-8')
(w/'owned-scope.json').write_text(json.dumps(dict(stage=46,authorized=True,files=[row['path']],methods=['0x60074DF','0x60074E0','0x60074EE'],limits='Only original account field accessors and original default cctor; no SDK/login status flags, no conflict producer or Fsm/Procedure writes'),ensure_ascii=False,indent=2),encoding='utf-8')
for name in ['Rewrite.cs','Rewrite.csproj','Verify.cs','Verify.csproj','compile-candidate.ps1']:
 s=(Path('work/stage38-savebase')/name).read_text(encoding='utf-8').replace('work/stage38-savebase','work/stage46-account-mode').replace('work\\stage38-savebase','work\\stage46-account-mode')
 (w/name).write_text(s,encoding='utf-8')
