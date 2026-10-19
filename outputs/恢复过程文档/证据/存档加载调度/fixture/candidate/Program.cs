using System.Text.Json.Nodes;
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
