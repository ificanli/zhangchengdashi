using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using GameFramework;
using GameFramework.Base;
using GameFramework.Resources;
using GameFramework.Procedure;

internal sealed class TestStart:IGameStart {
    public void Bind(GameStartEntry entry)=>_007Dye_0080_00BCa(entry);
    public void ConfigDone()=>InitConfigOver();
    public void LoadingDone()=>LoadingUIShow();
    public override void BeforeGameFrameworkInit(){Rig.Trace.Add("before-framework");if(Rig.ThrowBefore)throw new InvalidOperationException("before");}
    public override void AfterGameFrameworkInit()=>Rig.Trace.Add("after-framework");
    public override void InitPatchManager()=>Rig.Trace.Add("patch-manager");
    public override void StartGame()=>Rig.Trace.Add("start-game");
    public override void SetLayerCollisionMatrix()=>Rig.Trace.Add("layers");
    public override void MnieGameProjectSetting()=>Rig.Trace.Add("project-settings");
    public override void RegisterProcedure()=>Rig.Trace.Add("register-procedures");
    public override void RegisterLogicCtr()=>Rig.Trace.Add("register-controls");
    public override TeamType GetNewResLoadCDNTeamType(){Rig.Trace.Add("get-team");return TeamType.Team3;}
    public override YooAsset.EPlayMode GetNewResLoadAppPlayMode(){Rig.Trace.Add("get-mode");return YooAsset.EPlayMode.HostPlayMode;}
}
internal static class Program {
    static int scenarios,checks,failures;
    static void Check(bool value,string reason){checks++;if(!value)throw new Exception(reason);}
    static void Call(object target,string method){try{target.GetType().GetMethod(method,BindingFlags.NonPublic|BindingFlags.Public|BindingFlags.Instance).Invoke(target,null);}catch(TargetInvocationException e){throw e.InnerException;}}
    static object Field(object target,string name)=>typeof(GameStartEntry).GetField(name,BindingFlags.NonPublic|BindingFlags.Instance).GetValue(target);
    static void Set(object target,string name,object value)=>typeof(GameStartEntry).GetField(name,BindingFlags.NonPublic|BindingFlags.Instance).SetValue(target,value);
    static bool Started=>(bool)typeof(GameFrameEntry).GetField("O_00B8_005D_00A1_008B_005E",BindingFlags.NonPublic|BindingFlags.Static).GetValue(null);
    static void Throws<T>(Action action,string reason)where T:Exception{try{action();}catch(T){checks++;return;}throw new Exception("missing "+typeof(T).Name+": "+reason);}
    static void Sequence(IEnumerable<string> values,params string[] expected)=>Check(values.SequenceEqual(expected),"sequence: "+string.Join(",",values));
    static void Scenario(string name,Action action){scenarios++;Rig.Reset();try{action();Console.WriteLine("PASS "+name);}catch(Exception e){failures++;Console.WriteLine("FAIL "+name+": "+e.Message);}}
    static GameStartEntry Entry(IGameStart start){var entry=new GameStartEntry{AppName="ljzs_lt",gameCode="U-CSZDZ",AttachedComponent=start};return entry;}
    static int Main(){
        Scenario("Awake binds actual component and stops at real module callback gate",()=>{
            var start=new TestStart();var entry=Entry(start);Call(entry,"Awake");
            Check(entry.GetCalls==1,"GetComponent count");Check(ReferenceEquals(Field(entry,"_008ANUO_008B_0084"),start),"actual component binding");
            Check(ReferenceEquals(UnityEngine.Object.Persisted,entry),"entry persistence");Check(AppSetting.gameCode=="U-CSZDZ"&&AppSetting.MineGameName=="ljzs_lt","scene identity");
            Sequence(Rig.ModuleCalls,"init:VersionMondule");var version=GameFrameEntry.GetModule<VersionMondule>();
            Check(version.Àª_00A6_00A3_00BDE!=null&&!version.x_0080_008D_00B1f_0086,"original callback stored without ready");Check(!Started,"framework not auto-started");
            Sequence(Rig.Trace.Where(s=>!s.StartsWith("module-log:")),"get-component","culture","persist","prefs-init","before-framework");
        });
        Scenario("Awake keeps an existing live component and original constructor defaults",()=>{
            var start=new TestStart();var entry=Entry(null);Set(entry,"_008ANUO_008B_0084",start);Call(entry,"Awake");Check(entry.GetCalls==0,"unexpected component lookup");
            Check(entry.isShowInitGameLog&&(int)Field(entry,"tRJqx_0095")==3001&&(LocalELangLibrary)Field(entry,"langLibrary")==LocalELangLibrary.ZH_CN,"original field defaults");
        });
        Scenario("Awake rejects missing component before culture persistence and version",()=>{
            var entry=Entry(null);Set(entry,"m_AutoSaveData",true);Call(entry,"Awake");Check(AppSetting.AutoSaveData,"autosave transfer before missing component");Check(Rig.Trace.Any(s=>s.StartsWith("error:")),"original missing entry error");Check(!Rig.Trace.Contains("culture")&&!Rig.Trace.Contains("persist")&&Rig.ModuleCalls.Count==0,"advanced without actual component");
        });
        Scenario("Awake applies original collection app and language overrides",()=>{
            AppSetting.IsGameColletion=true;GlobalData.MineAppName="collection-game";GlobalData.localELangLibrary=LocalELangLibrary.EN;GlobalData.appDefaultLangType=ELangType.EN;
            var entry=Entry(new TestStart());Call(entry,"Awake");Check(entry.AppName=="collection-game"&&AppSetting.MineGameName=="collection-game","collection app override");Check((LocalELangLibrary)Field(entry,"langLibrary")==LocalELangLibrary.EN&&(ELangType)Field(entry,"appDefaultLangType")==ELangType.EN,"collection language order");
        });
        Scenario("Awake before hook failure preserves module initialization gate",()=>{
            Rig.ThrowBefore=true;var entry=Entry(new TestStart());Throws<InvalidOperationException>(()=>Call(entry,"Awake"),"Before failure");Check(Rig.ModuleCalls.Count==0&&!Started,"continued after Before failure");
        });
        Scenario("Initialize forwards exact args and last callback without faking ready",()=>{
            var module=GameFrameEntry.GetModule<LowModule>();var args=new object[]{42,"original"};int first=0,last=0;
            GameFrameEntry.Initialize(module,()=>first++,args);Check(ReferenceEquals(module.Args,args),"argument identity");Check(first==0&&!module.x_0080_008D_00B1f_0086,"synthesized completion");
            GameFrameEntry.Initialize(module,()=>last++,null);Check(module.Args==null,"null args preserved");module.Complete();Check(first==0&&last==1,"callback combined instead of replaced");
        });
        Scenario("Initialize null module has original null exception",()=>Throws<NullReferenceException>(()=>GameFrameEntry.Initialize(null,()=>{},new object[0]),"null module"));
        Scenario("GetModule caches exact runtime type and inserts stable descending priority",()=>{
            var low=GameFrameEntry.GetModule<LowModule>();var middle=GameFrameEntry.GetModule<MiddleModule>();var equal=GameFrameEntry.GetModule<EqualModule>();var high=GameFrameEntry.GetModule<HighModule>();Check(ReferenceEquals(low,GameFrameEntry.GetModule<LowModule>()),"module not cached");Check(!ReferenceEquals(middle,equal),"distinct exact types collapsed");
            Rig.ModuleCalls.Clear();GameFrameEntry.Start();Sequence(Rig.ModuleCalls,"start:HighModule","start:MiddleModule","start:EqualModule","start:LowModule");
        });
        Scenario("module resolver preserves prefix restriction and missing nested type error",()=>{
            Throws<Exception>(()=>GameFrameEntry.GetModule<string>(),"non-framework module");Throws<Exception>(()=>GameFrameEntry.GetModule<GameFramework.NestedContainer.Child>(),"unresolvable nested module");Check(Rig.ModuleCalls.Count==0,"invalid lookup started modules");
        });
        Scenario("Start repeats original calls and gates update only after successful traversal",()=>{
            GameFrameEntry.GetModule<LowModule>();GameFrameEntry.Update(0.1f,0.2f);GameFrameEntry.LateUpdate();Check(Rig.ModuleCalls.Count==0,"update before start");
            GameFrameEntry.Start();GameFrameEntry.Start();Check(Started,"original final started write missing");Sequence(Rig.ModuleCalls,"start:LowModule","start:LowModule");Rig.ModuleCalls.Clear();GameFrameEntry.Update(0.25f,0.5f);GameFrameEntry.LateUpdate();Sequence(Rig.ModuleCalls,"update:LowModule:0.25:0.5","late:LowModule");
        });
        Scenario("Start failure leaves started false and does not advance later modules",()=>{
            GameFrameEntry.GetModule<LowModule>();GameFrameEntry.GetModule<MiddleModule>();Rig.ThrowModuleStart=true;Throws<InvalidOperationException>(GameFrameEntry.Start,"module start failure");Check(!Started,"flag after failed traversal");Sequence(Rig.ModuleCalls,"start:MiddleModule");
        });
        Scenario("Version completion selects real old backend and retains its callback gate",()=>{
            var entry=Entry(new TestStart());Call(entry,"Awake");Rig.ModuleCalls.Clear();GameFrameEntry.GetModule<VersionMondule>().Complete();Sequence(Rig.ModuleCalls,"init:AssetbundleModule");Check(GameFrameEntry.GetModule<AssetbundleModule>().Àª_00A6_00A3_00BDE!=null&&!Started,"backend gate lost");
        });
        Scenario("new backend chooses original normal play mode and team",()=>{
            var entry=Entry(new TestStart());Call(entry,"Awake");AppSetting.UseNewRes=AppSetting.IsKeWan=true;Rig.Trace.Clear();GameFrameEntry.GetModule<VersionMondule>().Complete();Check(GameFramework.NewResLoadHelper.Mode==YooAsset.EPlayMode.HostPlayMode&&GameFramework.NewResLoadHelper.Team==TeamType.Team3,"normal backend parameters");Check(Rig.Trace.IndexOf("backend:True")<Rig.Trace.IndexOf("get-team")&&Rig.Trace.IndexOf("get-team")<Rig.Trace.IndexOf("get-mode"),"backend selection order");Check(NewResLoadHelper.Callback!=null&&!Started,"new backend auto-completed");
        });
        Scenario("web backend forces original numeric play mode four without calling app mode",()=>{
            var entry=Entry(new TestStart());Call(entry,"Awake");AppSetting.UseNewRes=AppSetting.IsXYXEnvironment=true;Rig.Trace.Clear();GameFrameEntry.GetModule<VersionMondule>().Complete();Check((int)NewResLoadHelper.Mode==4&&!Rig.Trace.Contains("get-mode"),"web play mode contract");
        });
        Scenario("old backend waits Resources then UI before secondary module dispatch",()=>{
            var entry=Entry(new TestStart());Call(entry,"Awake");GameFrameEntry.GetModule<VersionMondule>().Complete();Rig.ModuleCalls.Clear();GameFrameEntry.GetModule<AssetbundleModule>().Complete();Sequence(Rig.ModuleCalls,"init:ResourcesModule");GameFrameEntry.GetModule<ResourcesModule>().Complete();Sequence(Rig.ModuleCalls,"init:ResourcesModule","init:UIModule");Rig.ModuleCalls.Clear();GameFrameEntry.GetModule<UIModule>().Complete();
            Sequence(Rig.ModuleCalls,"init:LangModule","init:FsmManager","init:MineGameLogicModule","init:TimeModule","init:EffectModule","init:ObjectPoolManager","init:ProcedureManager");Check(!Started,"secondary modules auto completed");Check(GameFrameEntry.GetModule<LangModule>().Àª_00A6_00A3_00BDE==null&&GameFrameEntry.GetModule<ProcedureManager>().Àª_00A6_00A3_00BDE!=null,"original callback ownership");
        });
        Scenario("core callback sets resource update stage only after original Start and path steps",()=>{
            var entry=Entry(new TestStart());Call(entry,"Awake");Call(entry,"_0082_00BBf_0090_00B8_005D");Rig.Trace.Clear();GameFrameEntry.GetModule<ProcedureManager>().Complete();Check(Started&&(bool)Field(entry,"tÂ_007DµJ_008F"),"core stage fields");Check(!(bool)Field(entry,"x_0080_008D_00B1f_0086"),"logic stage advanced early");Check(Rig.Trace.IndexOf("find-path")<Rig.Trace.IndexOf("message:GF_InitFinish")&&Rig.Trace.Last()=="patch-manager","core callback order");
        });
        Scenario("loading bridge preserves SDK boundary and real config resource callback",()=>{
            var start=new TestStart();var entry=Entry(start);start.Bind(entry);start.LoadingDone();Check(ResLoadHelper.Path=="data/config"&&ResLoadHelper.Callback!=null,"original config path");Check(!(bool)Field(entry,"Á_008A_008F_008Bvh"),"config flag synthesized before resource callback");Check(Rig.Trace.IndexOf("sdk-game-start")<Rig.Trace.IndexOf("load:data/config"),"SDK original position");
        });
        Scenario("unbound original bridge throws instead of auto completing",()=>Throws<NullReferenceException>(()=>new TestStart().ConfigDone(),"unbound config bridge"));
        Scenario("real GameStart loading iterator yields boxed zero before invoking bridge",()=>{
            var start=new ljzs_lt.GameStart();var entry=Entry(start);start._007Dye_0080_00BCa(entry);start.InitPatchManager();Check(start.Coroutine!=null&&ResLoadHelper.Path==null,"coroutine bridge executed immediately");Check(start.Coroutine.MoveNext()&&start.Coroutine.Current is int&&(int)start.Coroutine.Current==0,"original int zero yield");Check(ResLoadHelper.Path==null,"loading callback same frame");Check(!start.Coroutine.MoveNext()&&ResLoadHelper.Path=="data/config","loading callback missing after one frame");
        });
        Scenario("real GameStart config failure prevents completion bridge and logic",()=>{
            var start=new ljzs_lt.GameStart();var entry=Entry(start);start._007Dye_0080_00BCa(entry);Rig.ThrowConfig=true;Throws<InvalidOperationException>(()=>start.InitConfig(new ResourcesInfo()),"config failure");Check(!(bool)Field(entry,"Á_008A_008F_008Bvh")&&!Rig.Trace.Any(s=>s.StartsWith("procedure-start:")),"advanced after config failure");
        });
        Scenario("real GameStart registers original procedures controls and PreLoad after config",()=>{
            var start=new ljzs_lt.GameStart();var entry=Entry(start);Call(entry,"Awake");start.InitConfig(new ResourcesInfo());Check((bool)Field(entry,"Á_008A_008F_008Bvh")&&(bool)Field(entry,"x_0080_008D_00B1f_0086"),"original config/logic flags");Check(!(bool)Field(entry,"tÂ_007DµJ_008F"),"resource-only phase not cleared");
            Sequence(Rig.Trace.Where(s=>s.StartsWith("register-control:")),"register-control:ServerTimeMgr:False","register-control:PurchaseControl:False","register-control:EmailControl:False");
            var manager=GameFrameEntry.GetModule<ProcedureManager>();Check(manager.Registered!=null&&manager.Registered.Length==3&&manager.Registered[0] is ljzs_lt.Procedure.ProcedurePreLoad&&manager.Registered[1] is ljzs_lt.Procedure.ProcedureStarGame&&manager.Registered[2] is ljzs_lt.Procedure.ProcedureExitGame,"original procedures");Check(manager.Started==typeof(ljzs_lt.Procedure.ProcedurePreLoad),"original PreLoad start");Check(Rig.Trace.Contains("init-controls:True"),"non-fastmode actual bool");Check(Rig.Trace.IndexOf("initialize-config")<Rig.Trace.IndexOf("audio")&&Rig.Trace.IndexOf("report-start-game")<Rig.Trace.IndexOf("procedure-start:ProcedurePreLoad"),"config-to-start order");
        });
        Scenario("Fastmode passes false to original control initialization",()=>{
            var start=new ljzs_lt.GameStart();var entry=Entry(start);entry.m_Fastmode=true;Call(entry,"Awake");start.InitConfig(new ResourcesInfo());Check(Rig.Trace.Contains("init-controls:False")&&!Rig.Trace.Contains("init-controls:True"),"Fastmode inversion");
        });
        Scenario("Entry Update keeps original resource logic and exit gates",()=>{
            var entry=Entry(new TestStart());GameFrameEntry.GetModule<LowModule>();GameFrameEntry.Start();Rig.ModuleCalls.Clear();Call(entry,"Update");Check(Rig.ModuleCalls.Count==0,"update before entry gates");Set(entry,"tÂ_007DµJ_008F",true);Call(entry,"Update");Sequence(Rig.ModuleCalls,"update:ResourcesModule:0.25:0.5");Rig.ModuleCalls.Clear();Set(entry,"tÂ_007DµJ_008F",false);Set(entry,"x_0080_008D_00B1f_0086",true);Call(entry,"Update");Check(Rig.ModuleCalls.Contains("update:LowModule:0.25:0.5"),"logic update missing");Rig.ModuleCalls.Clear();Set(entry,"_00BDm_00B9_008F_0096h",true);Call(entry,"Update");Check(Rig.ModuleCalls.Count==0,"exit gate ignored");
        });
        Console.WriteLine($"RESULT scenarios={scenarios} checks={checks} failures={failures}");return failures==0?0:1;
    }
}
