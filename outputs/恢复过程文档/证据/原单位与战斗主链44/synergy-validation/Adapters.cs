using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Reflection;
namespace Il2CppDummyDll {
[AttributeUsage(AttributeTargets.All,AllowMultiple=true)] public class TokenAttribute:Attribute {public string Token;}
[AttributeUsage(AttributeTargets.All,AllowMultiple=true)] public class AddressAttribute:Attribute {public string RVA,Offset,VA,Slot;}
[AttributeUsage(AttributeTargets.All,AllowMultiple=true)] public class FieldOffsetAttribute:Attribute {public string Offset;}
}
namespace Cysharp.Threading.Tasks {
public struct UniTask { public bool Completed; }
}
namespace Cysharp.Threading.Tasks.CompilerServices {
public struct AsyncUniTaskMethodBuilder {
 public static AsyncUniTaskMethodBuilder Create()=>new();
 public void Start<T>(ref T stateMachine) where T:IAsyncStateMachine=>stateMachine.MoveNext();
 public void SetResult(){completed=true;Env.BuilderResults++;}
 public void SetStateMachine(IAsyncStateMachine s){Env.BuilderSetMachines++;}
 private bool completed;
 public Cysharp.Threading.Tasks.UniTask Task=>new(){Completed=completed};
}
}
public static class Env {
 public static int[] Player=new int[6],Enemy=new int[6];
 public static bool New; public static int RandomValue,Near,BuilderResults,BuilderSetMachines;
 public static List<object> Trace=new();public static List<object> ConstructorTrace=new();
 public static void Manager(string name){if(name=="AIBehaviourManager")Trace.Add(new{call="manager",side="enemy"});else if(name=="EquipCardInfoManager")Trace.Add(new{call="manager",side="player"});else if(name=="BattleGameSceneManager")Trace.Add(new{call="manager",side="scene"});}
}
namespace ToolModule {
 public class ManagerBase<T> where T:class,new() {
  static T _instance;
  public static T Instance {get {Env.Manager(typeof(T).Name);return _instance??=new T();}}
  public virtual Cysharp.Threading.Tasks.UniTask Init()=>default;
  public ManagerBase(){if(typeof(T).Name=="SynergyEffectManager")Env.ConstructorTrace.Add(new{call="base-ctor",newFetter=(bool)GetType().GetField("IsUseNewFetter",BindingFlags.Instance|BindingFlags.NonPublic).GetValue(this)});}
 }
}
namespace SDKModule {
 public class ABTestManager {private static ABTestManager value=new(); public static ABTestManager Instance{get{Env.ConstructorTrace.Add(new{call="ab-singleton"});return value;}} public bool GamePlayImprove01IsBTest {get{Env.ConstructorTrace.Add(new{call="ab-getter"});return Env.New;}}}
}
namespace UnityEngine {public static class Random {public static int Range(int min,int max){Env.Trace.Add(new{call="random",min,max});return Env.RandomValue;}}}
namespace GameModule {
 public enum CardFettersType{Orcs,Undead,Terran,Machine,Null} public enum AtkWayType{Melee,Remote,Null}
 public class EntityBase{} public class RoleBehaviour:EntityBase{public CardFettersType CardFettersType;} public class ArchitectureBehaviour:EntityBase{public CardFettersType CardFettersType;}
 public class EquipCardInfoManager:ToolModule.ManagerBase<EquipCardInfoManager>{public int OrcsCount=>Env.Player[0];public int UnDeadCount=>Env.Player[1];public int TerranCount=>Env.Player[2];public int MachineCount=>Env.Player[3];public int MeleeCount=>Env.Player[4];public int RemoteCount=>Env.Player[5];}
 public class AIBehaviourManager:ToolModule.ManagerBase<AIBehaviourManager>{public int OrcsCount=>Env.Enemy[0];public int UnDeadCount=>Env.Enemy[1];public int TerranCount=>Env.Enemy[2];public int MachineCount=>Env.Enemy[3];public int MeleeCount=>Env.Enemy[4];public int RemoteCount=>Env.Enemy[5];}
 public class BattleGameSceneManager:ToolModule.ManagerBase<BattleGameSceneManager>{public List<RoleBehaviour> GetNearRole(bool isEnemy,EntityBase role,float range=1f,int roleNumber=-1){Env.Trace.Add(new{call="near",enemy=isEnemy,rangeBits=unchecked((uint)BitConverter.SingleToInt32Bits(range)),roleNumber});return Env.Near<0?null:Enumerable.Range(0,Env.Near).Select(_=>new RoleBehaviour()).ToList();}}
}
