using System.Reflection;
using System.Text;
using System.Text.Json;
using DataModule;
using GameFramework;
using L_Tools;
using Newtonsoft.Json;
var passed=new List<string>();
void Check(bool ok,string name){if(!ok)throw new Exception(name);passed.Add(name);}
void Throws<T>(Action action,string name)where T:Exception{try{action();}catch(T){passed.Add(name);return;}throw new Exception("Expected "+typeof(T).Name+": "+name);}
var work=Path.GetFullPath(args[0]);var fixtureRoot=Path.Combine(work,"fixture-run-"+Guid.NewGuid().ToString("N"));
UnityEngine.Application.dataPath=Path.Combine(fixtureRoot,"outputs","Recovered","Assets");
string storeRoot=Path.Combine(fixtureRoot,"work","occupycity-localeditor-store");
Check(DataManagerPool.CanSaveLocalData,"Pool original cctor enables local storage only");
var registration=new ModelRegister("ljzs_lt",false,true);
Check(registration.GameName=="ljzs_lt"&&!registration.AutoSyn&&registration.CompressData,"ModelRegister preserves original three constructor values");
Check(DataCompressTools.EncryptString("ABC")=="5Ofm1234567890","Original encryption XOR mask A5 and suffix");
Check(DataCompressTools.DecryptString("5Ofm1234567890")=="ABC"&&DataCompressTools.DecryptString("legacy")=="legacy","Decrypt suffix and legacy passthrough");
foreach(string input in new[]{null,""})
 Check(DataCompressTools.GZipCompressString(input)==""&&DataCompressTools.GZipDecompressString(input)==""&&DataCompressTools.EncryptString(input)==""&&DataCompressTools.DecryptString(input)=="","Original empty codec contract "+(input??"null"));
string json="{\"text\":\"时间恢复与占城大师\",\"v\":99}";string compressed=DataCompressTools.GZipCompressString(json);
Check(compressed.EndsWith("1234567890")&&DataCompressTools.GZipDecompressString(compressed)==json,"Original gzip base64 encrypted format round trip Unicode");
string legacy=DataCompressTools.DecryptString(compressed);
Check(DataCompressTools.GZipDecompressString(legacy)==json,"Original codec accepts gzip base64 without encrypted suffix");
Throws<FormatException>(()=>DataCompressTools.GZipDecompressString("%%%"),"Invalid base64 propagates without replacing new game");
Throws<InvalidDataException>(()=>DataCompressTools.GZipDecompressString(Convert.ToBase64String(Encoding.UTF8.GetBytes(new string('A',100)))),"Invalid gzip propagates without fallback");
var time=new PlayerTimeData();
Check(time.timeInfoDic!=null&&time.timeInfoDic.Count==0&&time.lastExitGameTime==default,"PlayerTimeData original ctor initializes only timer dictionary");
time.lastExitGameTime=new DateTime(2026,10,19,8,12,0,DateTimeKind.Utc);
time.timeInfoDic.Add("计时器",new TimeInfo{Key="计时器",StartTime=time.lastExitGameTime,TargetEndTime=time.lastExitGameTime.AddDays(2),useStandardNetTime=true});
string timeJson=JsonConvert.SerializeObject(time);var restored=JsonConvert.DeserializeObject<PlayerTimeData>(DataCompressTools.GZipDecompressString(DataCompressTools.GZipCompressString(timeJson)));
Check(timeJson.Contains("\"tid\"")&&timeJson.Contains("\"legt\"")&&!timeJson.Contains("timeInfoDic"),"Real Newtonsoft consumes original JsonProperty save schema");
Check(restored.lastExitGameTime.Kind==DateTimeKind.Utc&&restored.timeInfoDic["计时器"].useStandardNetTime&&restored.timeInfoDic["计时器"].TargetEndTime==time.lastExitGameTime.AddDays(2),"Real Newtonsoft preserves UTC and original timer fields");
Check(JsonConvert.DeserializeObject<PlayerTimeData>("{\"tid\":null}").timeInfoDic==null,"Explicit JSON null dictionary is not silently repaired");
var probe=new ProbeManager();probe.OnInit();
Check(ReferenceEquals(ProbeManager.I,probe)&&probe.Data==null&&probe.Reads==2,"Original OnInit registers I and reads cached text twice without creating TD");
var fresh=probe.GetData(null);
Check(fresh.Value==7&&fresh.Trail.SequenceEqual(new[]{"defaults"})&&probe.Data==null,"GetData empty creates defaults without Init or assigning Data");
probe.Load();
Check(probe.Data.Value==7&&probe.Data.Trail.SequenceEqual(new[]{"defaults","init"}),"Load empty follows Defaults then Init");
probe.Load();Check(probe.Data.Trail.Count==2,"Load existing Data is idempotent");
string valid=DataCompressTools.GZipCompressString("{\"v\":99}");
var fromString=probe.GetData(valid);
Check(fromString.Value==99&&fromString.Trail.Count==0,"GetData populated JSON does not run Init");
probe=new ProbeManager{Stored=valid};probe.OnInit();probe.Load();
Check(probe.Data.Value==99&&probe.Data.Trail.SequenceEqual(new[]{"init"}),"Load populated JSON runs Init without defaults");
Throws<JsonReaderException>(()=>probe.GetData(DataCompressTools.GZipCompressString("bad json")),"Invalid JSON does not become default data");
Check(probe.GetData(DataCompressTools.GZipCompressString("null"))==null,"JSON null GetData result remains null");
var nullManager=new ProbeManager{Stored=DataCompressTools.GZipCompressString("null")};nullManager.OnInit();
Throws<NullReferenceException>(()=>nullManager.Load(),"Load null JSON fails at original Data.Init boundary");
var memory=new ProbeData();probe.LoadFormMemory(memory);
Check(ReferenceEquals(probe.Data,memory)&&memory.Trail.SequenceEqual(new[]{"init"}),"LoadFormMemory assigns exact object then initializes");
Throws<NullReferenceException>(()=>probe.LoadFormMemory(null),"Null memory object retains original exception");
probe=new ProbeManager();probe.OnInit();probe.Load();
LoadingModule.LoadingManager.EnterHome=false;probe.CanSave=true;probe.Save();
Check(probe.Writes.Count==0&&probe.Hooks==0,"EnterHome false blocks serialization and storage");
LoadingModule.LoadingManager.EnterHome=true;probe.CanSave=false;probe.Save();
Check(probe.Writes.Count==0&&probe.Hooks==0,"CanSave false blocks serialization and storage");
probe.CanSave=true;probe.Data.Value=123;probe.Save();
Check(probe.Writes.Count==1&&probe.Hooks==1&&probe.GetData(probe.Writes[0]).Value==123,"Save invokes hook then real Newtonsoft and native codec before IO");
string saved=probe.Writes[0];probe.Data.Value=456;probe.OnSave();
Check(probe.Writes.Count==2&&probe.Writes[1]==saved&&probe.Hooks==1,"OnSave writes cached string without serializing modified Data");
probe.Clear();probe.Clear();probe.Save();probe.OnSave();
Check(probe.Writes.Count==3&&probe.Writes[2]==""&&probe.Hooks==1,"Clear is idempotent and suppresses later Save and OnSave");
probe=new ProbeManager{Stored=valid};probe.OnInit();probe.Receive("");
Check(probe.Cache==valid&&DBTSDK.ReportManager.Instance.Last is DBTSDK.NewReport.JsonProperties.activity_complete report&&report.game_name=="ljzs_lt"&&report.activity_name=="LTDataEmpty"&&report.activity_mode1=="LTDataEmpty","Original empty server report preserves existing local cache");
L_Tools.LoginControl.I=new(){IsProxyLogin=true};probe.Receive("");
Check(probe.Cache=="","Original proxy-login condition permits empty update without fake login state");L_Tools.LoginControl.I=null;
var beforeAssembly=Utility.AssemblyUtility.LoadCSharpAssembly();
Check(beforeAssembly==typeof(ProbeManager).Assembly&&ReferenceEquals(beforeAssembly,Utility.AssemblyUtility.LoadAssembly("Assembly-CSharp")),"Original assembly loader resolves and caches only Assembly-CSharp");
Throws<FileNotFoundException>(()=>Utility.AssemblyUtility.LoadAssembly("RecoveryDefinitelyMissingAssembly"),"Missing original assembly load exception preserved");
var pool=DataManagerPool.Instance;Check(ReferenceEquals(pool,DataManagerPool.Instance),"Original pool singleton reuses same instance");
#if UNITY_EDITOR
pool.OnInit();
Check(ProbeManager.I!=null&&DbtSaveDataManager_PlayerTimeData.I!=null&&RejectedManager.I==null,"Original auto-registration filters ModelRegister game name and creates real I producers");
Check(DbtSaveDataManager_PlayerTimeData.I.Data==null,"Pool registration does not bypass original Load");
DbtSaveDataManager_PlayerTimeData.I.Load();
Check(DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic!=null,"Original PlayerTimeData Load reaches initialized timer dictionary");
Check(ReferenceEquals(pool.GetModel<ProbeManager>(),ProbeManager.I)&&ReferenceEquals(pool.d_0088_00A0_0089_00B3v(typeof(ProbeManager)),ProbeManager.I),"Pool generic and typed lookup consume registered instances");
Check(pool.GetModel<RejectedManager>()==null,"Generic missing model warns and returns null without factory");
Throws<IndexOutOfRangeException>(()=>pool.d_0088_00A0_0089_00B3v(typeof(RejectedManager)),"Original typed missing-model array index exception retained from ARM64");
var duplicate=new ProbeManager();var original=ProbeManager.I;Check(ReferenceEquals(pool.AddModel(duplicate),duplicate)&&ReferenceEquals(ProbeManager.I,original)&&duplicate.Reads==0,"Duplicate AddModel returns supplied object without replacing registration or init");
var manual=pool.AddModel(new ManualManager(),false);Check(ManualManager.I==null,"AddModel false does not initialize model");
Check(UpdateManager.Requests.Count==1&&MsgDispatcher.Requests.Keys.OrderBy(x=>x).SequenceEqual(new[]{"GF_HttpServerErrorCode","GF_HttpServerSuccess","GF_HttpWebRequestError"})&&UnityEngine.Debug.Logs.Any(x=>x.Contains("consumers and MsgDispatcher are unresolved")),"Backend requests original handle and three message bindings with explicit unresolved diagnostic");
var storageA=pool.GetModel<StorageManagerA>();var storageB=pool.GetModel<StorageManagerB>();storageA.Load();storageB.Load();
storageA.CanSave=true;storageB.CanSave=true;
GameFramework.Login.ILoginProcedure.accountType=1;storageA.Save();
Check(!Directory.Exists(storeRoot),"Original TryGame account mode blocks Editor local writes");
GameFramework.Login.ILoginProcedure.accountType=10;storageA._007C_007Ev_00A8G_00BB=false;storageA.Save();
Check(!Directory.Exists(storeRoot),"Original model local-enable flag blocks Editor local writes");
storageA._007C_007Ev_00A8G_00BB=true;DataManagerPool.CanSaveLocalData=false;storageA.Save();
Check(!Directory.Exists(storeRoot),"Original pool local-save flag blocks Editor local writes");DataManagerPool.CanSaveLocalData=true;
storageA.Data.Value=212;storageB.Data.Value=313;storageA.Save();storageB.Save();
Check(Directory.Exists(storeRoot)&&Directory.GetFiles(storeRoot,"*.save").Length==2,"Editor adapter writes only isolated task work store with per-key filenames");
var reloadA=new StorageManagerA();reloadA.OnInit();reloadA.Load();var reloadB=new StorageManagerB();reloadB.OnInit();reloadB.Load();
Check(reloadA.Data.Value==212&&reloadB.Data.Value==313,"Editor adapter round trip preserves separate model saves");
Check(UnityEngine.Debug.Logs.Any(x=>x.Contains("LocalEditorStore")&&x.Contains(Path.GetFullPath(storeRoot))),"Editor adapter logs resolved absolute independent path");
UnityEngine.Application.isEditor=false;
Throws<NotImplementedException>(()=>new StorageManagerA().OnInit(),"Editor false does not silently use unresolved native storage");
UnityEngine.Application.isEditor=true;
#else
Throws<NotImplementedException>(()=>new StorageManagerA().OnInit(),"APK original storage has explicit diagnostic instead of default success");
Check(!Directory.Exists(storeRoot),"APK diagnostic does not create any storage directory");
#endif
Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(new{mode=
#if UNITY_EDITOR
"Editor",
#else
"APK",
#endif
passed=passed.Count,isolatedRoot=storeRoot,tests=passed},new JsonSerializerOptions{WriteIndented=true}));
public class ProbeData:ServerBaseData
{
 [JsonProperty("v")]public int Value;[JsonIgnore]public List<string> Trail=new();
 public override void InitFromDefaults(){Value=7;Trail.Add("defaults");}
 public override void Init(){Trail.Add("init");}
}
[ModelRegister("ljzs_lt",true,false)]
public class ProbeManager:DbtSaveDataManagerBase<ProbeManager,ProbeData>
{
 public string Stored="";public int Reads,Hooks;public List<string> Writes=new();
 public string Cache=>(string)typeof(DbtSaveDataManagerBase<ProbeManager,ProbeData>).GetField("_lastSaveData",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(this);
 protected override string ReadLocalData(){Reads++;return Stored;}
 protected override void SaveLocalData(string str){Writes.Add(str);Stored=str;}
 protected override void OnBeforeSerializeForSave(){Hooks++;}
 public void Receive(string str)=>base.UpdateDataCallBack(str);
}
[ModelRegister("ljzs_lt",true,false)]public class StorageManagerA:DbtSaveDataManagerBase<StorageManagerA,ProbeData>{}
[ModelRegister("ljzs_lt",false,true)]public class StorageManagerB:DbtSaveDataManagerBase<StorageManagerB,ProbeData>{}
[ModelRegister("other",true,false)]public class RejectedManager:DbtSaveDataManagerBase<RejectedManager,ProbeData>{}
public class ManualManager:DbtSaveDataManagerBase<ManualManager,ProbeData>{}
