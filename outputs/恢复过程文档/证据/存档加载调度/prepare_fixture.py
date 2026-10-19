from pathlib import Path
import json
import sys

WORK=Path(__file__).resolve().parent
ROOT=WORK.parents[1]
variant=sys.argv[1] if len(sys.argv)>1 else 'candidate'
manifest=json.loads((WORK/'candidate-manifest.json').read_text())
source=(WORK/'DataManager-before.cs' if variant=='before' else
        ROOT/'outputs/OccupyCityRecovered'/manifest['files'][0]['path'] if variant=='actual' else
        WORK/'candidate'/manifest['files'][0]['path']).read_text(encoding='utf-8-sig')

def extract(signature):
    if signature=='public UniTask LoadData()' and 'public async UniTask LoadData()' in source:signature='public async UniTask LoadData()'
    start=source.index(signature);opening=source.index('{',start);level=1;end=opening+1
    while level:
        if source[end]=='{':level+=1
        elif source[end]=='}':level-=1
        end+=1
    return source[start:end]

directory=WORK/'fixture'/variant
directory.mkdir(parents=True,exist_ok=True)
(directory/'DataManager.Extracted.cs').write_text('''using Cysharp.Threading.Tasks;
public enum ComflictStatus { UseLocalData=0, UseServerData=1, CompareData=2 }
public class DataManager {
 public static bool SaveConflictCheckFinish;
 public static bool HasCheckedSaveConflict;
 public static ComflictStatus ComflictStatus;
 private bool loadConfigComplete;
 public bool LoadDataCompleted { get; private set; }
 public void FixtureConfig(bool value) { loadConfigComplete=value; }
 public void FixtureCompleted(bool value) { LoadDataCompleted=value; }
 public void FixtureLoadAll() { LoadAllSaveData(); }
'''+ '\n'.join(extract(m['signature']) for m in manifest['methods'])+'\n}',encoding='utf-8')
classes=[]
for name in manifest['nativeModelsInLoadOrder']:
    classes.append(f'public class {name}: MockManager {{ public static {name} I; public {name}():base("{name}") {{}} }}')
(directory/'Mocks.cs').write_text('''using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
namespace Cysharp.Threading.Tasks {
 public enum PlayerLoopTiming { Update=8 }
 [AsyncMethodBuilder(typeof(UniTaskMethodBuilder))]
 public readonly struct UniTask {
  public readonly Task AsTask;
  public UniTask(Task task) {AsTask=task;}
  public TaskAwaiter GetAwaiter() => (AsTask??Task.CompletedTask).GetAwaiter();
  public static UniTask WaitForSeconds(float seconds,bool ignoreDeltaTime=false,PlayerLoopTiming timing=PlayerLoopTiming.Update,CancellationToken cancellation=default,bool immediately=false) {
   if(seconds!=0.1f||ignoreDeltaTime||timing!=PlayerLoopTiming.Update||cancellation.CanBeCanceled||immediately)throw new Exception("wrong original delay contract");
   var completion=new TaskCompletionSource<bool>();Clock.Pending.Enqueue(completion);Clock.Delays++;return new UniTask(completion.Task);
  }
 }
 public struct UniTaskMethodBuilder {
  private AsyncTaskMethodBuilder inner;
  public static UniTaskMethodBuilder Create()=>new UniTaskMethodBuilder{inner=AsyncTaskMethodBuilder.Create()};
  public UniTask Task=>new UniTask(inner.Task);
  public void SetResult()=>inner.SetResult();
  public void SetException(Exception value)=>inner.SetException(value);
  public void SetStateMachine(IAsyncStateMachine value)=>inner.SetStateMachine(value);
  public void Start<T>(ref T value) where T:IAsyncStateMachine=>inner.Start(ref value);
  public void AwaitOnCompleted<TA,TS>(ref TA a,ref TS s) where TA:INotifyCompletion where TS:IAsyncStateMachine=>inner.AwaitOnCompleted(ref a,ref s);
  public void AwaitUnsafeOnCompleted<TA,TS>(ref TA a,ref TS s) where TA:ICriticalNotifyCompletion where TS:IAsyncStateMachine=>inner.AwaitUnsafeOnCompleted(ref a,ref s);
 }
}
public static class Clock {
 public static Queue<TaskCompletionSource<bool>> Pending=new();public static int Delays;
 public static void Step(){var t=Pending.Dequeue();t.SetResult(true);}
 public static void Reset(){Pending.Clear();Delays=0;}
}
public class PlayerCoreData { public bool LoginSuccessfully; }
public class MockManager {
 public string Name; public bool CanSave;public PlayerCoreData Data=new();
 public static List<string> Calls=new();public static string FailLoad;public static bool FailSave;public static int SaveCount;
 public MockManager(string name){Name=name;}
 public void Load(){Calls.Add(Name);if(!CanSave)throw new Exception("Load without original CanSave write");if(Name==FailLoad)throw new InvalidOperationException("load failure");}
 public void Save(){SaveCount++;if(FailSave)throw new InvalidOperationException("save failure");}
}
'''+ '\n'.join(classes),encoding='utf-8')
(directory/'Fixture.csproj').write_text('<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework><Nullable>disable</Nullable><ImplicitUsings>enable</ImplicitUsings></PropertyGroup></Project>',encoding='utf-8')
(directory/'Program.cs').write_text('''using System.Text.Json.Nodes;
using System.Reflection;
using System.Text.Json;
using Cysharp.Threading.Tasks;
class Program {
 static List<object> Results=new();static int Checks,Failures;
 static string[] Names;
 static Dictionary<string,MockManager> Models;
 static void Check(bool value,string why){Checks++;if(!value)throw new Exception(why);}
 static void Case(string name,Action body){int start=Checks;try{body();Results.Add(new{name,checks=Checks-start,passed=true});}catch(Exception ex){Failures++;Results.Add(new{name,checks=Checks-start,passed=false,error=ex.GetType().Name+":"+ex.Message});}}
 static void Reset(bool flags=false){Clock.Reset();MockManager.Calls.Clear();MockManager.SaveCount=0;MockManager.FailLoad=null;MockManager.FailSave=false;Models=new();foreach(string name in Names){Type type=typeof(Program).Assembly.GetType(name);var value=(MockManager)Activator.CreateInstance(type);value.CanSave=flags;type.GetField("I").SetValue(null,value);Models[name]=value;}DataManager.SaveConflictCheckFinish=false;DataManager.HasCheckedSaveConflict=false;DataManager.ComflictStatus=(ComflictStatus)(-7);}
 static Task TaskOf(UniTask value)=>value.AsTask??Task.CompletedTask;
 static void Error(Task task,string error){Check(task.IsCompleted,"task must finish");Check(task.IsFaulted,"task must fault");Check(task.Exception.InnerException.GetType().Name==error,"wrong fault "+task.Exception);}
 static void Main(string[] args){
  var gold=JsonNode.Parse(File.ReadAllText(args[0])).AsArray();
  Names=gold.First(x=>x["kind"].GetValue<string>()=="LoadAllSaveData"&&x["missingIndex"].GetValue<int>()==-1)["calls"].AsArray().Select(x=>x.GetValue<string>()).ToArray();
  foreach(var row in gold){string kind=row["kind"].GetValue<string>();int missing=row["missingIndex"].GetValue<int>();int choice=row["choice"].GetValue<int>();Case("native:"+kind+":"+missing+":"+choice,()=>{
   Reset(kind=="StopAllSave");var manager=new DataManager();DataManager.HasCheckedSaveConflict=true;
   if(missing>=0){string missingName=row["slotOrder"][missing].GetValue<string>();typeof(Program).Assembly.GetType(missingName).GetField("I").SetValue(null,null);}
   Exception error=null;try{if(kind=="ChooseConflict")manager.ChooseConflict((ComflictStatus)choice);else if(kind=="LoadAllSaveData")manager.FixtureLoadAll();else manager.StopAllSave();}catch(Exception ex){error=ex;}
   Check(error?.GetType().Name==row["error"]?.GetValue<string>(),"native fault differs");
   Check(MockManager.Calls.SequenceEqual(row["calls"].AsArray().Select(x=>x.GetValue<string>())),"native ordered calls differ");
   foreach(var flag in row["flags"].AsObject())Check(Models[flag.Key].CanSave==flag.Value.GetValue<bool>(),"native CanSave differs "+flag.Key);
   if(kind=="ChooseConflict"){Check(DataManager.SaveConflictCheckFinish==row["conflictFinish"].GetValue<bool>(),"conflict finish differs");Check(DataManager.HasCheckedSaveConflict==row["hasChecked"].GetValue<bool>(),"unrelated flag changed");Check((int)DataManager.ComflictStatus==row["status"].GetValue<int>(),"enum bits differ");}
  });}
  Case("config waits before resetting completed",()=>{Reset();DataManager.SaveConflictCheckFinish=true;var m=new DataManager();m.FixtureCompleted(true);Task task=TaskOf(m.LoadData());Check(!task.IsCompleted,"must await config");Check(m.LoadDataCompleted,"must not reset before config");Check(MockManager.Calls.Count==0,"no early loads");m.FixtureConfig(true);Clock.Step();Check(task.IsCompletedSuccessfully,"config continuation");Check(m.LoadDataCompleted,"load completed");Check(MockManager.Calls.SequenceEqual(Names),"15 ordered loads");Check(MockManager.SaveCount==1,"first local login save");Check(Models["DbtSaveDataManager_PlayerCoreData"].Data.LoginSuccessfully,"original stored login write");Check(!DataManager.HasCheckedSaveConflict,"not fabricated");});
  Case("conflict waits and uses original chooser",()=>{Reset();var m=new DataManager();m.FixtureConfig(true);m.FixtureCompleted(true);Task task=TaskOf(m.LoadData());Check(!task.IsCompleted,"must wait choice");Check(!m.LoadDataCompleted,"reset after config");Check(MockManager.Calls.Count==0,"no early model loads");m.ChooseConflict(ComflictStatus.UseLocalData);Clock.Step();Check(task.IsCompletedSuccessfully&&m.LoadDataCompleted,"choice continuation");Check(Clock.Delays==1,"one native 0.1 delay");});
  Case("both independent waits retained",()=>{Reset();var m=new DataManager();Task task=TaskOf(m.LoadData());m.FixtureConfig(true);Clock.Step();Check(!task.IsCompleted&&Clock.Pending.Count==1,"second gate retained");m.ChooseConflict(ComflictStatus.CompareData);Clock.Step();Check(task.IsCompletedSuccessfully,"both finish");Check(Clock.Delays==2,"two native delay boundaries");});
  Case("already logged in skips original first save",()=>{Reset();var m=new DataManager();m.FixtureConfig(true);DataManager.SaveConflictCheckFinish=true;Models["DbtSaveDataManager_PlayerCoreData"].Data.LoginSuccessfully=true;Task task=TaskOf(m.LoadData());Check(task.IsCompletedSuccessfully&&m.LoadDataCompleted,"sync completion");Check(MockManager.SaveCount==0,"no extra save");Check(Clock.Delays==0,"no fabricated delay");});
  Case("load failure preserves incomplete",()=>{Reset();var m=new DataManager();m.FixtureConfig(true);DataManager.SaveConflictCheckFinish=true;MockManager.FailLoad=Names[2];Task task=TaskOf(m.LoadData());Error(task,"InvalidOperationException");Check(!m.LoadDataCompleted,"fault not ready");Check(MockManager.Calls.SequenceEqual(Names.Take(3)),"stop at actual fault");Check(!Models["DbtSaveDataManager_PlayerCoreData"].Data.LoginSuccessfully,"no login on failed load");Check(MockManager.SaveCount==0,"no save on failure");});
  Case("null data preserves original failure",()=>{Reset();var m=new DataManager();m.FixtureConfig(true);DataManager.SaveConflictCheckFinish=true;Models["DbtSaveDataManager_PlayerCoreData"].Data=null;Task task=TaskOf(m.LoadData());Error(task,"NullReferenceException");Check(!m.LoadDataCompleted,"null data not ready");Check(MockManager.Calls.Count==15,"all loads happen first");});
  Case("save failure keeps original earlier login write",()=>{Reset();var m=new DataManager();m.FixtureConfig(true);DataManager.SaveConflictCheckFinish=true;MockManager.FailSave=true;Task task=TaskOf(m.LoadData());Error(task,"InvalidOperationException");Check(!m.LoadDataCompleted,"failed save not ready");Check(Models["DbtSaveDataManager_PlayerCoreData"].Data.LoginSuccessfully,"preserve native earlier write");Check(MockManager.SaveCount==1,"one original save");});
  var report=new{variant=Path.GetFileName(Path.GetDirectoryName(args[1])),scenarios=Results.Count,checks=Checks,failures=Failures,scope="Extracted actual source with controlled async/resource boundaries; not Unity gameplay",results=Results};
  File.WriteAllText(args[1],JsonSerializer.Serialize(report,new JsonSerializerOptions{WriteIndented=true}));Console.WriteLine($"scenarios={Results.Count} checks={Checks} failures={Failures}");Environment.ExitCode=Failures==0?0:1;
 }
}
''',encoding='utf-8')
print('Prepared fixture from',variant,'source; selected four real method bodies')
