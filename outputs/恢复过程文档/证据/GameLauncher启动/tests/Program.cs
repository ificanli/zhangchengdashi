using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using CoreModule;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

static class Program
{
    static int scenarios,checks,failures;
    static object Call(GameLauncher launcher,string method,params object[] args)=>typeof(GameLauncher).GetMethod(method,BindingFlags.NonPublic|BindingFlags.Instance)!.Invoke(launcher,args);
    static Task CallTask(GameLauncher launcher,string method)=>(Task)Call(launcher,method);
    static void Check(bool condition,string note) {checks++;if(!condition)throw new Exception(note);}
    static async Task Run(string name,Func<Task> action)
    {
        scenarios++;Env.Reset();AssetsModule.AssetsManager.Instance.initcomplete=false;
        try {await action().WaitAsync(TimeSpan.FromSeconds(2));Console.WriteLine("PASS "+name);}
        catch(Exception ex) {failures++;Console.WriteLine("FAIL "+name+": "+ex.GetBaseException().Message);}
    }
    static Task Done(Action action) {action();return Task.CompletedTask;}
    static readonly string[] Background={"FeatureUnlockManager","AudioManager","UIHUDManager","EffectManager","UITextEffectManager","MaterialsManager","SteerManager","CheckStayGetRewardManager","ReportEventsManager","PanelPopHandleManager","PacksTipManager","PropDetailsManager","AdButtonManager","AnnouncementManager","ResourceObtainGuideManager","CheckInRewardManager","SubGameChaosTrailsManager"};
    static async Task Main()
    {
        await Run("Awake stores live base task before CheatControl.Init",()=>Done(()=>
        {
            var launcher=new GameLauncher();Env.Hold("EventManager");Application.targetFrameRate=0;Call(launcher,"Awake");
            Check(Application.targetFrameRate==60,"performance setup runs");
            Check(Env.Trace.SequenceEqual(new[]{"EventManager","CheatControl"}),"base init starts before cheat init");
            var task=(Task)typeof(GameLauncher).GetField("_initBaseManagerTask",BindingFlags.NonPublic|BindingFlags.Instance)!.GetValue(launcher);
            Check(task!=null&&!task.IsCompleted,"stored task retains actual pending base init");
        }));
        await Run("InitBaseManager waits event, asset flag, parent, then config",async()=>
        {
            var launcher=new GameLauncher();Env.Hold("EventManager","GameConfigManager");
            var task=CallTask(launcher,"InitBaseManager");Check(task!=null,"must return a real task");
            Check(Env.Trace.SequenceEqual(new[]{"EventManager"}),"event is first wait");
            Env.Release("EventManager");Check(TestTasks.Pending.Count==1,"asset predicate follows event completion");
            TestTasks.Tick();Check(!Env.Trace.Contains("SetParent"),"false asset gate blocks parenting");
            AssetsModule.AssetsManager.Instance.initcomplete=true;TestTasks.Tick();
            Check(ReferenceEquals(AssetsModule.AssetsManager.Instance.transform.Parent,launcher.transform),"parent is launcher transform");
            Check(Env.Trace.TakeLast(2).SequenceEqual(new[]{"SetParent","GameConfigManager"}),"parent precedes config init");
            Check(!task.IsCompleted,"config remains awaited");Env.Release("GameConfigManager");await task;
        });
        await Run("Start waits stored base task before subscribing and loading",()=>Done(()=>
        {
            var launcher=new GameLauncher();var baseTask=new TaskCompletionSource();
            typeof(GameLauncher).GetField("_initBaseManagerTask",BindingFlags.NonPublic|BindingFlags.Instance)!.SetValue(launcher,baseTask.Task);
            Call(launcher,"Start");Check(Env.Trace.Count==0,"start must wait base initialization");
            baseTask.SetResult();Check(Env.Trace.Take(2).SequenceEqual(new[]{"Listen:OnLoadingCompleted","StartLoading"}),"listen precedes loading");
            Check(!Env.Trace.Contains("ABTestManager"),"login still gates business");
        }));
        await Run("Login pending and failed states block until Success",()=>Done(()=>
        {
            var launcher=new GameLauncher();Env.Hold("ABTestManager");Call(launcher,"Login");
            Check(TestTasks.Pending.Count==1,"login predicate created");TestTasks.Tick();Check(!Env.Trace.Contains("ABTestManager"),"pending blocks");
            L_Tools.LoginControl.I.Curloginstate=L_Tools.LoginState.Fail;TestTasks.Tick();Check(!Env.Trace.Contains("ABTestManager"),"failed login blocks");
            L_Tools.LoginControl.I.Curloginstate=L_Tools.LoginState.Success;TestTasks.Tick();Check(Env.Trace.Last()=="ABTestManager","success starts GameLogic");
        }));
        await Run("GameLogic waits AB before progress and fire-and-forget InitManager",async()=>
        {
            var launcher=new GameLauncher();Env.Hold("ABTestManager","HWIAPManager");
            var task=CallTask(launcher,"GameLogic");Check(task!=null&&!task.IsCompleted,"AB task remains pending");
            Check(Env.Trace.SequenceEqual(new[]{"ABTestManager"}),"nothing downstream before AB");
            Env.Release("ABTestManager");await task;
            Check(Env.Trace[1]=="Progress:0.05","first progress follows AB");
            Check(Env.Trace.Last()=="HWIAPManager","InitManager started");Check(Env.Forgotten.Count==1&&!Env.Forgotten[0].IsCompleted,"RunInitManager remains pending in background");
        });
        await Run("InitManager preserves 11 await gates and concurrent task start",async()=>
        {
            var launcher=new GameLauncher();DataModule.DataManager.Instance.LoadDataCompleted=false;LocalizationModule.Runtime.CustomBundlesManager.Instance.PreloadTaskCompleted=false;
            Env.Hold("TimeManager","LoadConfig","HWIAPManager","DataManager","UIManager","LoadData","UserResourcesManager","CameraManager","CustomBundlesManager","GetPanel");
            var task=CallTask(launcher,"InitManager");Check(task!=null&&!task.IsCompleted,"initialization is pending");
            Check(Env.Trace.Where(x=>!x.StartsWith("Log:")&&!x.StartsWith("Progress:")).SequenceEqual(new[]{"WaitUntil","TimeManager","LoadConfig","HWIAPManager"}),"all three task starts precede first await");
            Env.Release("HWIAPManager");Check(Env.Trace.Last()=="DataManager","data init follows HWIAP");
            Env.Release("DataManager");Check(Env.Trace.Last()=="UIManager","UI follows data init");
            Env.Release("UIManager");Check(!Env.Trace.Contains("LoadData"),"already-started config task still awaited");
            Env.Release("LoadConfig");Check(Env.Trace.Last()=="LoadData","LoadData follows config completion");
            Env.Release("LoadData");Check(TestTasks.Pending.Count==2,"LoadData false introduces second predicate");
            TestTasks.Tick();Check(!Env.Trace.Contains("UserResourcesManager"),"LoadData flag blocks resources");
            DataModule.DataManager.Instance.LoadDataCompleted=true;TestTasks.Tick();Check(Env.Trace.Last()=="UserResourcesManager","resource init follows data flag");
            Env.Release("UserResourcesManager");Check(Env.Trace.Last()=="CameraManager","camera follows resources");
            Env.Release("CameraManager");Check(!Env.Trace.Contains("CustomBundlesManager"),"both early tasks are awaited before custom init");
            Env.Release("TimeManager");Check(!Env.Trace.Contains("CustomBundlesManager"),"time alone cannot release preload");
            LocalizationModule.Runtime.CustomBundlesManager.Instance.PreloadTaskCompleted=true;TestTasks.Tick();Check(Env.Trace.Last()=="CustomBundlesManager","preload completes WhenAll");
            Env.Release("CustomBundlesManager");Check(Env.Trace.Last()=="GetPanel","panel prefetch is awaited next");
            Check(Env.Trace.Contains("PanelPath:Assets/_Res/Addressable/01FirstBundle/Prefabs/UI/Panels/NoInternetPanel.prefab"),"exact original panel address");
            Check(!Env.Trace.Contains(Background[0]),"no background start before panel completion");
            Env.Release("GetPanel");await task;
            Check(Env.Trace.Count(x=>x=="Progress:0.05")==10,"ten native progress increments");
            Check(Env.Trace.TakeLast(17).SequenceEqual(Background),"17 managers retain native order");
        });
        foreach(bool firstGuide in new[]{true,false})
        {
            await Run("firstEnterGameTime uses network time with guide="+firstGuide,async()=>
            {
                DbtSaveDataManager_PlayerCoreData.I.Data.firstEnterGameTime=DateTime.MinValue;DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame=firstGuide;
                var task=CallTask(new GameLauncher(),"InitManager");Check(task!=null,"real init task");TestTasks.Tick();await task;
                var expected=new DateTime(2026,10,19,10,0,0,DateTimeKind.Utc).AddDays(firstGuide?0:-4);
                Check(DbtSaveDataManager_PlayerCoreData.I.Data.firstEnterGameTime==expected,"original guide time branch");
                Check(Env.Trace.Count(x=>x=="NetworkTime:False")==1&&Env.Trace.Last()=="Save","single network time false and save after background starts");
            });
        }
        await Run("existing firstEnterGameTime is preserved",async()=>
        {
            var task=CallTask(new GameLauncher(),"InitManager");Check(task!=null,"real init task");TestTasks.Tick();await task;
            Check(DbtSaveDataManager_PlayerCoreData.I.Data.firstEnterGameTime==new DateTime(2020,1,1),"existing timestamp stays");Check(!Env.Trace.Contains("Save")&&!Env.Trace.Any(x=>x.StartsWith("NetworkTime:")),"no migration side effects");
        });
        await Run("failed awaited dependency stops InitManager with original exception",async()=>
        {
            Env.Hold("HWIAPManager");var task=CallTask(new GameLauncher(),"InitManager");Check(task!=null,"real init task");var error=new InvalidOperationException("native dependency failed");Env.Held["HWIAPManager"].SetException(error);
            try {await task;Check(false,"must propagate dependency failure");}catch(InvalidOperationException actual){Check(ReferenceEquals(error,actual),"exception identity retained");}
            Check(!Env.Trace.Contains("DataManager")&&!Env.Trace.Contains(Background[0]),"downstream init does not run after failure");
        });
        await Run("loading listener is idempotent and unsubscribes before game initialization",()=>Done(()=>
        {
            var launcher=new GameLauncher();Call(launcher,"StartLoadingCompletedListening");Call(launcher,"StartLoadingCompletedListening");Check(Env.Trace.Count(x=>x.StartsWith("Listen:"))==1,"one subscription");
            EventModule.EventManager.Instance.Fire();Check(EventModule.EventManager.Instance.Callback==null,"callback already removed");
            Check(Env.Trace.TakeLast(2).SequenceEqual(new[]{"Stop:OnLoadingCompleted","GameManager"}),"stop listening precedes GameManager.Init");
            Call(launcher,"StopLoadingCompletedListening");Check(Env.Trace.Count(x=>x.StartsWith("Stop:"))==1,"stop is idempotent");
            EventModule.EventManager.Instance.Fire();Check(Env.Trace.Count(x=>x=="GameManager")==1,"old event does not reinitialize game");
        }));
        await Run("background initialization launches all 17 without waiting",()=>Done(()=>
        {
            Env.Hold(Background);Call(new GameLauncher(),"StartBackgroundManagersInit");Check(Env.Trace.SequenceEqual(Background),"background launch order");Check(Env.Forgotten.Count==17&&Env.Forgotten.All(t=>!t.IsCompleted),"all 17 pending tasks are forgotten, not awaited");
        }));
        foreach(var row in new[]{(2048,true,true,30,.75f),(4096,true,true,60,.8f),(2048,false,true,30,.7f),(4096,false,true,30,.7f),(2048,false,false,30,0f),(4096,false,false,60,0f)})
        {
            await Run($"performance ram={row.Item1} compute={row.Item2} URP={row.Item3}",()=>Done(()=>
            {
                SystemInfo.systemMemorySize=row.Item1;SystemInfo.supportsComputeShaders=row.Item2;var asset=new UniversalRenderPipelineAsset();GraphicsSettings.currentRenderPipeline=row.Item3?asset:null;
                Call(new GameLauncher(),"SetOptimalPerformanceSettings");Check(Application.targetFrameRate==row.Item4,"native frame rate policy");Check(Math.Abs(asset.renderScale-row.Item5)<.0001f,"native render scale policy");
            }));
        }
        await Run("renderer data property, fallback fields, invalid index and null",()=>Done(()=>
        {
            var launcher=new GameLauncher();var expected=new ScriptableRendererData();var asset=new UniversalRenderPipelineAsset {Direct=expected};
            object[] args={asset,null};Check((bool)Call(launcher,"TryGetDefaultRendererData",args)&&ReferenceEquals(args[1],expected),"nonpublic property first");
            asset.Direct=null;asset.SetFallback(new[]{expected},0);args=new object[]{asset,null};Check((bool)Call(launcher,"TryGetDefaultRendererData",args)&&ReferenceEquals(args[1],expected),"private field fallback");
            asset.SetFallback(new[]{expected},-1);args=new object[]{asset,null};Check(!(bool)Call(launcher,"TryGetDefaultRendererData",args)&&args[1]==null,"invalid index gives false and null");
            args=new object[]{null,expected};Check(!(bool)Call(launcher,"TryGetDefaultRendererData",args)&&args[1]==null,"null asset resets out argument");
        }));
        await Run("renderer feature name comparison and warning results",()=>Done(()=>
        {
            var launcher=new GameLauncher();var data=new ScriptableRendererData();var feature=new ScriptableRendererFeature{name="render effects"};data.rendererFeatures.Add(null);data.rendererFeatures.Add(feature);var asset=new UniversalRenderPipelineAsset{Direct=data};
            Check((bool)Call(launcher,"TrySetRendererFeatureActive",asset,"Render Effects",false)&&!feature.active,"case insensitive feature disable");
            Check(!(bool)Call(launcher,"TrySetRendererFeatureActive",asset,"Missing",false)&&Env.Trace.Last()=="Warn:未找到Renderer Feature：Missing","missing feature warns");
        }));
        await Run("reflection setter priority, private fallback, public-field exclusion and exception",()=>Done(()=>
        {
            var launcher=new GameLauncher();var target=new ReflectionTarget();var method=typeof(GameLauncher).GetMethod("TrySetPropertyOrField",BindingFlags.NonPublic|BindingFlags.Instance)!.MakeGenericMethod(typeof(bool));
            bool Set(string property,string field)=> (bool)method.Invoke(launcher,new object[]{target,property,field,false});
            Check(Set("Value","fallback")&&!target.Value&&target.Fallback,"private setter has priority");
            Check(Set("ReadOnly","fallback")&&!target.Fallback,"no setter falls back to private field");
            Check(!Set("Absent","PublicField")&&target.PublicField,"native flags exclude public fields");
            bool propagated=false;try {Set("Throwing","fallback");}catch(TargetInvocationException ex) {propagated=ex.GetBaseException() is ApplicationException;}Check(propagated,"reflection setter failure propagates");
        }));
        await Run("camera post processing and antialiasing disable",()=>Done(()=>
        {
            var launcher=new GameLauncher();Call(launcher,"DisablePostProcessingForLoadedCameras");Check(Env.Trace.Last().StartsWith("Warn:30帧策略"),"no cameras warns");
            var camera=new Camera();Camera.Cameras=new[]{camera,null};Call(launcher,"DisablePostProcessingForLoadedCameras");Check(!camera.Data.renderPostProcessing&&camera.Data.antialiasing==AntialiasingMode.None,"loaded camera disables both settings");
        }));
        await Run("explicit thirty FPS rendering helper retains lighting and feature effects",()=>Done(()=>
        {
            var launcher=new GameLauncher();var feature=new ScriptableRendererFeature{name="Render Effects"};var data=new ScriptableRendererData();data.rendererFeatures.Add(feature);var asset=new UniversalRenderPipelineAsset{Direct=data,shadowDistance=30};
            Call(launcher,"ApplyThirtyFpsRenderingSettings",asset);Check(asset.msaaSampleCount==1&&asset.shadowDistance==0,"MSAA one and shadow distance zero");
            Check(!asset.AnyShadow,"four native lighting fields disabled");Check(!feature.active,"Render Effects feature disabled");
            int traceCount=Env.Trace.Count;Call(launcher,"ApplyThirtyFpsRenderingSettings",new object[]{null});Check(Env.Trace.Count==traceCount,"null asset exits without helper effects");
        }));
        Console.WriteLine($"RESULT scenarios={scenarios} checks={checks} failures={failures}");Environment.ExitCode=failures==0?0:1;
    }
    sealed class ReflectionTarget {public bool Value{get;private set;}=true;private bool fallback=true;public bool Fallback=>fallback;public bool ReadOnly=>true;public bool PublicField=true;public bool Throwing{set=>throw new ApplicationException("setter");}}
}
