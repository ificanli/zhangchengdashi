import hashlib
import json
import re
import shutil
from pathlib import Path

ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/stage37-entry'
PROJECT=ROOT/'outputs/OccupyCityRecovered'
mapping=json.loads((ROOT/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
strings={row['Address']:row['Value'] for row in mapping['ScriptString']}
literal=lambda address:json.dumps(strings[address],ensure_ascii=True)
paths={
 'entry':'Assets/Scripts/GFRunning/GameFramework/Base/GameStartEntry.cs',
 'frame':'Assets/Scripts/GFRunning/GameFramework/GameFrameEntry.cs',
 'bridge':'Assets/Scripts/GFRunning/GameFramework/Base/IGameStart.cs',
 'game':'Assets/Scripts/Assembly-CSharp/ljzs_lt/GameStart.cs',
}
bodies={key:{} for key in paths}
def body(file,token,text):bodies[file][token]=text.strip()

body('entry','0x6007193',f'''
AppSetting.AutoSaveData = m_AutoSaveData;
AppSetting.gameCode = gameCode;
if (_008ANUO_008B_0084 == null)
    _008ANUO_008B_0084 = GetComponent<IGameStart>();
if (_008ANUO_008B_0084 == null)
{{
    CLog.Error({literal(0x8D87D40)});
    return;
}}
_008ANUO_008B_0084._007Dye_0080_00BCa(this);
Á_008A_008F_008Bvh = false;
AppSetting.SetCultureBasedOnSetting();
if (AppSetting.IsGameColletion)
{{
    AppName = GlobalData.MineAppName;
    langLibrary = GlobalData.localELangLibrary;
    appDefaultLangType = GlobalData.appDefaultLangType;
}}
AppSetting.MineGameName = AppName;
DontDestroyOnLoad(this);
UserDataPrefs.OnInit();
_008ANUO_008B_0084.BeforeGameFrameworkInit();
GameFrameEntry.Initialize(GameFrameEntry.GetModule<VersionMondule>(), vj_00B7_0098_008A_007F, System.Array.Empty<object>());
''')
body('entry','0x6007177','''if (isShowInitGameLog)
    CLog.Log(iD_00B7m_0094À);''')
body('entry','0x6007179','''
_008A_0080M_00ACa_0083("VersionMondule初始化完成");
if (AppSetting.UseNewRes)
{
    GameFrameModule module = NewResLoadHelper.GetNewResModule(AppSetting.IsKeWan);
    bool isWebPlay = AppSetting.IsXYXEnvironment && !AppSetting.IsXYXNativeMode;
    TeamType teamType = _008ANUO_008B_0084.GetNewResLoadCDNTeamType();
    EPlayMode playMode;
    if (isWebPlay)
    {
        playMode = (EPlayMode)4;
        CLog.Log("cdnTeamTypeXYX:" + teamType.ToString() + " appPlayMode:" + playMode.ToString());
    }
    else
    {
        playMode = _008ANUO_008B_0084.GetNewResLoadAppPlayMode();
        CLog.Log("cdnTeamType:" + teamType.ToString() + " appPlayMode:" + playMode.ToString());
    }
    NewResLoadHelper.Initialize(module, fÂ_00A7_0096_005D_009C, playMode, teamType);
    return;
}
GameFrameEntry.Initialize(GameFrameEntry.GetModule<AssetbundleModule>(), fÂ_00A7_0096_005D_009C, System.Array.Empty<object>());
''')
body('entry','0x6007182','''
_008ANUO_008B_0084?.AfterGameFrameworkInit();
_008A_0080M_00ACa_0083("资源模块初始化完成");
if (AppSetting.UseNewRes)
    GameFrameEntry.Initialize(GameFrameEntry.GetModule<UIModule>(), _0082_00BBf_0090_00B8_005D, System.Array.Empty<object>());
else
    GameFrameEntry.Initialize(GameFrameEntry.GetModule<ResourcesModule>(), _009F_008Br_00B7Mu, System.Array.Empty<object>());
''')
body('entry','0x60071A6','''GameFrameEntry.Initialize(GameFrameEntry.GetModule<UIModule>(), _0082_00BBf_0090_00B8_005D, System.Array.Empty<object>());''')
body('entry','0x6007194','''
_008A_0080M_00ACa_0083("UI模块初始化完成，开始初始化其他次级模块");
GameFrameEntry.Initialize(GameFrameEntry.GetModule<LangModule>(), null, System.Array.Empty<object>());
GameFrameEntry.Initialize(GameFrameEntry.GetModule<GameFramework.Fsm.FsmManager>(), null, System.Array.Empty<object>());
GameFrameEntry.Initialize(GameFrameEntry.GetModule<MineGameLogicModule>(), null, System.Array.Empty<object>());
GameFrameEntry.Initialize(GameFrameEntry.GetModule<TimeModule>(), null, System.Array.Empty<object>());
GameFrameEntry.Initialize(GameFrameEntry.GetModule<EffectModule>(), null, System.Array.Empty<object>());
GameFrameEntry.Initialize(GameFrameEntry.GetModule<GameFramework.ObjectPool.ObjectPoolManager>(), null, System.Array.Empty<object>());
GameFrameEntry.Initialize(GameFrameEntry.GetModule<GameFramework.Procedure.ProcedureManager>(), J_009DK_0099M_00AC, System.Array.Empty<object>());
''')
body('entry','0x6007185','''
GameFrameEntry.Start();
_008A_0080M_00ACa_0083("核心模块初始化完成");
bool showLog = !GlobalData.IsReleaseVersion || DBTSDK.SDKToolManager.Instance.IsSupportLogStatic();
CLog.SetIsShowLog(showLog);
if (GlobalData.IsReleaseVersion)
{
    if (showLog)
    {
        DBTSDK.SDKToolManager.Instance.ShowToast("警告：正式包开启了日志");
        DBTSDK.ReportManager.Instance.ReportGMLogOpen();
    }
}
else if (NewResLoadHelper.GetIsDeepObf())
    DBTSDK.SDKToolManager.Instance.ShowToast("警告：当前测试包开启了深度混淆，请注意验证数据存储");
GamePath.Instance.FindMineGamePath();
tÂ_007DµJ_008F = true;
GameFrameEntry.GetModule<LangModule>().SetLocalLangLibrary(langLibrary, appDefaultLangType);
MsgDispatcher.SendMessage("GF_InitFinish");
_008ANUO_008B_0084.InitPatchManager();
''')
body('entry','0x60071A5','''
_008A_0080M_00ACa_0083("LoadingUIOpen");
DBTSDK.SDKToolManager.Instance.U3DGameStart_Override();
if (AppSetting.UseNewRes)
    O_00A9_00B3_00A7_00A0i();
else
    ResLoadHelper.LoadAsset("data/config", _008B_00A7_0099YW_0091, System.Array.Empty<object>());
''')
body('entry','0x600718F','''
_008A_0080M_00ACa_0083("ConfigLoadOver");
_008ANUO_008B_0084.InitConfig(_0088_00AB_0084E_0082F);
''')
body('entry','0x6007180','''
Á_008A_008F_008Bvh = true;
ª_008C_0098_00ABV_005E();
''')
body('entry','0x6007175','''
_008A_0080M_00ACa_0083("开始初始化进游戏前的逻辑");
if (AppSetting.IsGameColletion)
    _009EªOl_0097F();
_008ANUO_008B_0084.SetLayerCollisionMatrix();
_008ANUO_008B_0084.MnieGameProjectSetting();
_008ANUO_008B_0084.RegisterProcedure();
_008ANUO_008B_0084.RegisterLogicCtr();
GameFramework.AudioManager.Instance.InitAudioManager();
GameFrameEntry.GetModule<MineGameLogicModule>().InitCtrl(!m_Fastmode);
x_0080_008D_00B1f_0086 = true;
tÂ_007DµJ_008F = false;
_008A_0080M_00ACa_0083("开始游戏");
GameFrameEntry.CommonSettings();
DBTSDK.ReportManager.Instance.StartMineGame();
MsgDispatcher.AddEventListener("ExitGame", _007Ea_00AEºgf);
_008ANUO_008B_0084.StartGame();
''')
body('entry','0x6007189','''
if (_00BDm_00B9_008F_0096h)
    return;
if (tÂ_007DµJ_008F)
    GameFrameEntry.ResourcesModuleUpdate(Time.deltaTime, Time.unscaledDeltaTime);
if (x_0080_008D_00B1f_0086)
    GameFrameEntry.Update(Time.deltaTime, Time.unscaledDeltaTime);
''')

body('frame','0x60055D2','''
_009D_007FOz_00AFs.Àª_00A6_00A3_00BDE = _00B7_0060_0084VQI;
_009D_007FOz_00AFs.Initialize(h_00A6_00BB_00B2_0089w);
''')
body('frame','0x60055D9','''return K_007E_005E_0098_00ABb(K_0086_009C_0083_0084_0089<T>()) as T;''')
body('frame','0x60055DB','''
Type type = typeof(T);
if (!type.FullName.StartsWith("GameFramework."))
    throw new Exception(string.Format("You must get a Game Framework module, but '{0}' is not.", type.FullName));
string typeName = string.Format("{0}.{1}", type.Namespace, type.Name);
Type moduleType = Type.GetType(typeName);
if (moduleType == null)
    throw new Exception(string.Format("Can not find Game Framework module type '{0}'.", typeName));
return moduleType;
''')
body('frame','0x60055DC','''
LinkedListNode<GameFrameModule> node = y_0086A_0094F_0083.Last;
while (node != null)
{
    if (node.Value.GetType() == kF_00A8_008F_007C_00A5)
        return node.Value;
    node = node.Previous;
}
return _00B9X_0081_0093_0095_009B(kF_00A8_008F_007C_00A5);
''')
body('frame','0x60055DD','''
GameFrameModule module = (GameFrameModule)Activator.CreateInstance(kF_00A8_008F_007C_00A5);
if (module == null)
    throw new Exception(string.Format("Can not create module '{0}'.", module.GetType().FullName));
CLog.d_00B0e_00A1_00B2_005B("创建模块===" + kF_00A8_008F_007C_00A5.Name);
LinkedListNode<GameFrameModule> node = y_0086A_0094F_0083.First;
while (node != null)
{
    if (module.Priority > node.Value.Priority)
        break;
    node = node.Next;
}
if (node == null)
    y_0086A_0094F_0083.AddLast(module);
else
    y_0086A_0094F_0083.AddBefore(node, module);
return module;
''')
body('frame','0x60055D3','''
AppSetting.SetCultureBasedOnSetting();
foreach (GameFrameModule module in y_0086A_0094F_0083)
    module.Start();
O_00B8_005D_00A1_008B_005E = true;
''')
body('frame','0x60055D4','''
if (AppSetting.UseNewRes || !O_00B8_005D_00A1_008B_005E)
    return;
GameFrameModule module = GetModule<GameFramework.Resources.ResourcesModule>();
if (module != null)
    module.Update(_008EJ_0092_009BUc, rfjÀ_0098L);
''')
body('frame','0x60055D5','''
if (!O_00B8_005D_00A1_008B_005E)
    return;
LinkedListNode<GameFrameModule> node = y_0086A_0094F_0083.First;
while (node != null)
{
    node.Value.Update(_008EJ_0092_009BUc, rfjÀ_0098L);
    node = node.Next;
}
''')
body('frame','0x60055D6','''
if (!O_00B8_005D_00A1_008B_005E)
    return;
LinkedListNode<GameFrameModule> node = y_0086A_0094F_0083.First;
while (node != null)
{
    node.Value.U_0095_008Bd_008A_00AC();
    node = node.Next;
}
''')

body('bridge','0x60071A8','''this._00B4_0098p_00BDg_008A = _00B4_0098p_00BDg_008A;''')
body('bridge','0x60071AA','''_00B4_0098p_00BDg_008A.O_008AJy_0085_00BF();''')
body('bridge','0x60071AB','''_00B4_0098p_00BDg_008A.whJq_00B8_00B9();''')

body('game','0x6005B41','''
ConfigMgr.Instance.SetConfigABRes(resourcesInfo);
ConfigMgr.Instance.Initialize();
InitConfigOver();
''')
body('game','0x6005B42','''
base.RegisterProcedure();
var procedures = new List<GameFramework.Procedure.ProcedureBase>();
procedures.Add(new ljzs_lt.Procedure.ProcedurePreLoad());
procedures.Add(new ljzs_lt.Procedure.ProcedureStarGame());
procedures.Add(new ljzs_lt.Procedure.ProcedureExitGame());
GameFramework.GameFrameEntry.GetModule<GameFramework.Procedure.ProcedureManager>().Register(procedures.ToArray());
''')
body('game','0x6005B43','''StartCoroutine(OpenLoadingUI(LoadingUIShow));''')
body('game','0x6005B45','''
UnityEngine.Debug.Log("OpenLoadingUI");
yield return 0;
loadOver?.Invoke();
''')
body('game','0x6005B48','''
base.RegisterLogicCtr();
GameFramework.GameFrameEntry.GetModule<GameFramework.MineGameLogicModule>().RegisterLogicCtr(L_Tools.ServerTimeMgr.I, false);
GameFramework.GameFrameEntry.GetModule<GameFramework.MineGameLogicModule>().RegisterLogicCtr(PurchaseControl.I, false);
GameFramework.GameFrameEntry.GetModule<GameFramework.MineGameLogicModule>().RegisterLogicCtr(CommonGameModule.Email.EmailControl.I, false);
''')
body('game','0x6005B49','''GameFramework.GameFrameEntry.GetModule<GameFramework.Procedure.ProcedureManager>().StartProcedure<ljzs_lt.Procedure.ProcedurePreLoad>();''')

def replace_body(text,token,body):
    marker='[Token(Token = "'+token+'")]'
    start=text.index(marker)
    begin=text.index('{',start)
    depth=1;end=begin+1
    while depth:
        if text[end]=='{':depth+=1
        elif text[end]=='}':depth-=1
        end+=1
    indent='\t\t'
    replacement='{\n'+'\n'.join(indent+'\t'+line if line else '' for line in body.splitlines())+'\n'+indent+'}'
    return text[:begin]+replacement+text[end:]

result=[]
for key,relative in paths.items():
    source=PROJECT/relative
    before=OWN/'source-before'/relative
    before.parent.mkdir(parents=True,exist_ok=True)
    if not before.exists():
        shutil.copy2(source,before)
        shutil.copy2(source.with_suffix('.cs.meta'),before.with_suffix('.cs.meta'))
    text=before.read_text(encoding='utf-8-sig')
    for token,value in bodies[key].items():text=replace_body(text,token,value)
    if key=='entry':
        text=text.replace('public bool isShowInitGameLog;','public bool isShowInitGameLog = true;').replace('private int tRJqx_0095;','private int tRJqx_0095 = 3001;').replace('private LocalELangLibrary langLibrary;','private LocalELangLibrary langLibrary = LocalELangLibrary.ZH_CN;')
    if key=='game':
        text=text.replace('\t\t[IteratorStateMachine(typeof(_003COpenLoadingUI_003Ed__4))]\n','')
    if key=='frame':
        cctor='''
        [Token(Token = "0x60055DE")]
        [Address(RVA = "0x715BAE8", Offset = "0x7157AE8", VA = "0x715BAE8")]
        static GameFrameEntry()
        {
            y_0086A_0094F_0083 = new LinkedList<GameFrameModule>();
            GameMenuSceneName = string.Empty;
            IsGoGameMenu = false;
        }
'''
        pos=text.rfind('\n\t}')
        text=text[:pos]+cctor+text[pos:]
    target=OWN/'candidate'/relative
    target.parent.mkdir(parents=True,exist_ok=True)
    target.write_text(text,encoding='utf-8')
    result.append(dict(path=relative,beforeSha256=hashlib.sha256(before.read_bytes()).hexdigest(),candidateSha256=hashlib.sha256(target.read_bytes()).hexdigest(),restoredTokens=list(bodies[key]),restoredMethods=len(bodies[key])+(key=='frame'),fieldInitializers=3 if key=='entry' else 0))
(OWN/'write-plan.json').write_text(json.dumps(dict(stage=37,files=result),ensure_ascii=False,indent=2),encoding='utf-8')
(OWN/'bodies.json').write_text(json.dumps(bodies,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps(result,ensure_ascii=True,indent=2))
