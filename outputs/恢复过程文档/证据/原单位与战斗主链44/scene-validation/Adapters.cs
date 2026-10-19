using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace UnityEngine {
public class Object {
 public static T Instantiate<T>(T obj) where T:Object {if(obj==null)throw new ArgumentException("null prefab");GameModule.Probe.Events.Add("instantiate");if(obj is GameObject g)return (T)(Object)new GameObject(g.name+"(Clone)"){component=g.component};throw new NotSupportedException();}
 public bool destroyed;
 public static bool operator ==(Object a,Object b) { bool an=ReferenceEquals(a,null)||a.destroyed,bn=ReferenceEquals(b,null)||b.destroyed; return an||bn ? an==bn : ReferenceEquals(a,b); }
 public static bool operator !=(Object a,Object b)=>!(a==b);
 public override bool Equals(object x)=>ReferenceEquals(this,x);public override int GetHashCode()=>System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(this);
}
public class Component:Object { public GameObject gameObject; public Transform transform; public Component(){transform=new Transform();} }
public class Transform:Object { public Vector3 position;public Transform parent;public bool worldPositionStays;public void SetParent(Transform target,bool keep){parent=target;worldPositionStays=keep;GameModule.Probe.Events.Add("parent");} }
public class GameObject:Object {public string name;public bool activeSelf=true;public Transform transform=new Transform();public object component;public GameObject(string name=""){this.name=name;}public T GetComponent<T>()=>component is T t?t:default;public T AddComponent<T>()where T:Component,new(){T value=new(){gameObject=this,transform=transform};component=value;GameModule.Probe.Events.Add("add:"+typeof(T).Name);return value;}public void SetActive(bool active){activeSelf=active;GameModule.Probe.Events.Add("active:"+active);}}
public class SpriteRenderer:Component {} public class MeshRenderer:Component {}
public struct Vector3 {public float x,y,z;public Vector3(float x,float y=0,float z=0){this.x=x;this.y=y;this.z=z;}public static Vector3 operator -(Vector3 a,Vector3 b)=>new(a.x-b.x,a.y-b.y,a.z-b.z);public float sqrMagnitude=>x*x+y*y+z*z;}
public static class Mathf {public static int Max(int a,int b)=>Math.Max(a,b);public static float Max(float a,float b)=>Math.Max(a,b);public static int Min(int a,int b)=>Math.Min(a,b);public static int CeilToInt(float x){if(float.IsPositiveInfinity(x))return int.MinValue;if(float.IsNaN(x))return 0;if(x>=int.MaxValue)return int.MaxValue;if(x<=int.MinValue)return int.MinValue;return (int)MathF.Ceiling(x);} }
public static class Time {public static int frameCount;public static float deltaTime;}
public static class Debug {public static List<string> warnings=new();public static void LogWarning(object x){warnings.Add(x.ToString());GameModule.Probe.Events.Add("warning");} }
}
namespace SDKModule {public class ABTestManager {public static ABTestManager Instance=new();public bool GamePlayImprove01IsBTest,NewArtifactsPlayIsBTest,BalanceAdjustment01IsBTest;}}
namespace ToolModule {public static class StringTool {public static bool IsNullOrEmpty(string s,bool trimSpaces=true)=>s==null||(trimSpaces?s.Trim():s).Length==0;public static int ToInt(string s){int value=0;int.TryParse(s,System.Globalization.NumberStyles.Float,System.Globalization.CultureInfo.InvariantCulture,out value);return value;}}}
namespace DataModule {public class GlobalArenaInfo {public string minesCountLimit;}public class GlobalInfo {public Dictionary<string,GlobalArenaInfo> arenaInfoDic=new();}public class DataManager {public static DataManager Instance=new();public GlobalInfo GlobalInfo=new();}}
namespace EventModule {public class EventManager {public static EventManager Instance=new();public Action<string,object> Hook;public List<(string key,object value)> records=new();public List<(string key,Action<object> callback)> listeners=new();public void StartListening(string key,Action<object> callback){listeners.Add((key,callback));GameModule.Probe.Events.Add("listen:"+key);}public void TriggerEvent(string key,object value){records.Add((key,value));GameModule.Probe.Events.Add(key);Hook?.Invoke(key,value);}public void Signal(string key,object value){foreach(var l in listeners.ToArray())if(l.key==key)l.callback(value);} }}
namespace AssetsModule {public class AssetsManager {public static AssetsManager Instance=new();public TaskCompletionSource<object> pending;public UnityEngine.GameObject prefab;public List<string> paths=new();public async Task<T> LoadAssetAsync<T>(string path) where T:UnityEngine.Object {paths.Add(path);GameModule.Probe.Events.Add("load");return pending!=null?(T)await pending.Task:(T)(UnityEngine.Object)prefab;}}}
namespace Pathfinding {public static class AstarWebGLRuntimeConfig {public static bool UseWebGLNavigation;}}
namespace GameModule {
public static class Probe {public static List<string> Events=new();}
public class RoleBehaviour:UnityEngine.Component {public bool isDead,StealthIng,_isCountedInRoleLimit;public int _instanceID;public string label;public int updated;public Action onUpdate;public void MyUpdate(){updated++;Probe.Events.Add("update:"+label);onUpdate?.Invoke();}}
public class BarracksArchitectureBehaviour:UnityEngine.Component {public bool isDead,legendary;public int rare,spawned;public string id;public Action onSpawn;public bool IsLegendaryBarracks()=>legendary;public int GetRareLevelValue()=>rare;public string GetCreatRoleID()=>id;public void OnCanSpawnRole(){spawned++;Probe.Events.Add("spawn:"+id);onSpawn?.Invoke();}}
public enum GameType { PVP=0,Other=1 }
public class GenerateHexBehaviour:UnityEngine.Component {public float hexSize=1;public int loadCalls,generateCalls;public GameType lastGameType;public TaskCompletionSource pendingGround;public Action onGenerate;public Task LoadGround(GameType type){lastGameType=type;loadCalls++;Probe.Events.Add("load-ground");return pendingGround?.Task??Task.CompletedTask;}public void Generate(GameType type){lastGameType=type;generateCalls++;Probe.Events.Add("generate");onGenerate?.Invoke();}}
public class HexBehaviour:UnityEngine.Component {public HexManager.HexCoord HexCoord;public bool combo;public List<RoleBehaviour> player=new(),enemy=new();public int GetRoleCountByCamp(bool e)=>(e?enemy:player).Count;public RoleBehaviour GetRoleByCamp(bool e,int i)=>(e?enemy:player)[i];public bool IsCombo()=>combo;public void MyUpdate(){Probe.Events.Add("update:hex");}}
public class ArchitectureBehaviour:UnityEngine.Component {public void MyUpdate(){Probe.Events.Add("update:architecture");}}
public class RoleShadowManager:UnityEngine.Object {public static RoleShadowManager Instance;public void Bind(RoleBehaviour role){Probe.Events.Add("bind");}}
public class BattleGameManager:UnityEngine.Object {public static BattleGameManager Instance;public void TryApplyPauseToNewRole(UnityEngine.GameObject obj){Probe.Events.Add("pause");}}
public class WebGLNavigationManager:UnityEngine.Component {public int initialized,shutdown,graphDirty;public float lastDelta;public void Initialize(BattleGameSceneManager scene){initialized++;Probe.Events.Add("nav-init");}public void Shutdown(){shutdown++;Probe.Events.Add("nav-shutdown");}public void MarkPathGraphDirty(){graphDirty++;Probe.Events.Add("nav-graph-dirty");}public void Tick(float dt){lastDelta=dt;Probe.Events.Add("nav-tick");}public static void TryRegisterRole(RoleBehaviour role){Probe.Events.Add("register");}public static void TryUnregisterRole(RoleBehaviour role){Probe.Events.Add("unregister");}}
public static class CoreGameManager {public static bool Gaming;public static string NowPlayEdArenaID;}
public static class BatchScheduler {public static Queue<TaskCompletionSource> pending=new();public static int yields;public static Task Yield(){yields++;var promise=new TaskCompletionSource();pending.Enqueue(promise);return promise.Task;}public static void ReleaseOne(){pending.Dequeue().SetResult();}public static void Reset(){pending.Clear();yields=0;}}
public static class TaskAdapters {public static List<Task> forgotten=new();public static void Forget(this Task task){forgotten.Add(task);}}
}
public static class HexManager {
 public struct HexCoord {public readonly int q,r;public HexCoord(int q,int r){this.q=q;this.r=r;}}
 public static bool locate;public static GameModule.HexBehaviour source;public static Dictionary<(int,int),GameModule.HexBehaviour> map=new();public static List<(int,int)> looked=new();
 public static bool TryGetHexAt(UnityEngine.Vector3 pos,out GameModule.HexBehaviour hex){hex=source;return locate;}
 public static GameModule.HexBehaviour GetHexBehaviour(HexCoord coord){looked.Add((coord.q,coord.r));return map.TryGetValue((coord.q,coord.r),out var h)?h:null;}
}
