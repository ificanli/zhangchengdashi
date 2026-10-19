using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
public class Coroutine { }
public class WaitForSeconds { public float seconds; public WaitForSeconds(float x) { seconds=x; } }
public static class Time { public static float timeScale=1;static float delta=.2f;public static int DeltaReads;public static float deltaTime {get{DeltaReads++;return delta;}set{delta=value;}} }
public static class Mathf { public static int Clamp(int v,int lo,int hi)=>Math.Clamp(v,lo,hi); public static int FloorToInt(float v)=>(int)MathF.Floor(v); }
public class DeadUnitInfo { }
public static class UniTask {
 public static Func<bool> Predicate; public static TaskCompletionSource Gate;
 public static Task WaitUntil(Func<bool> condition) { Predicate=condition; if(condition())return Task.CompletedTask; Gate=new TaskCompletionSource(); return Gate.Task; }
 public static void Tick() { if(Predicate!=null&&Predicate()) Gate?.TrySetResult(); }
}
namespace QuickTutor { public class TutorialManager { public static TutorialManager Instance=new(); public bool tutorialing; } }
namespace UnityEngine {
 public class Object { public bool Alive=true;static int Next=1;int id=Next++;public int GetInstanceID()=>id;
  public static bool operator==(Object x,Object y){bool xn=ReferenceEquals(x,null)||!x.Alive,yn=ReferenceEquals(y,null)||!y.Alive;return xn&&yn||!xn&&!yn&&ReferenceEquals(x,y);}
  public static bool operator!=(Object x,Object y)=>!(x==y);public override bool Equals(object o)=>ReferenceEquals(this,o);public override int GetHashCode()=>id;
 }
 public static class Random { public static int Value; public static int Range(int min,int max) { if(min!=0||max!=101)throw new Exception("random ABI");return Value; } }
}
public class GameObject:UnityEngine.Object {public Dictionary<Type,object> Parts=new();public Animator[] Animators=Array.Empty<Animator>();public T GetComponent<T>() where T:class=>Parts.TryGetValue(typeof(T),out var p)?p as T:null;public T[] GetComponentsInChildren<T>(bool includeInactive)=>Animators as T[];}
public class Animator:UnityEngine.Object {public float speed=1;}
public interface IAnimation {float GetAnimatorSpeed(int name);int GetCurrentAnimationName();}
public enum RoleAnimationDriverType{GPUInstancer,AniInstancing}
public class GPUInstanceAnimationBehaviour:UnityEngine.Object,IAnimation {public float speed=1;public float GetAnimatorSpeed(int name)=>speed;public int GetCurrentAnimationName()=>0;}
public class RoleBehaviour:UnityEngine.Object {public IAnimation Animation;public RoleAnimationDriverType Driver;public IAnimation GetAnimationBehaviour()=>Animation;public RoleAnimationDriverType GetAnimationDriverType()=>Driver;}
namespace AnimationInstancing {public class AnimationInstancing:UnityEngine.Object,IAnimation {public bool Paused;public int PauseCalls,ResumeCalls;public bool IsPause()=>Paused;public void Pause(){Paused=true;PauseCalls++;}public void Resume(){Paused=false;ResumeCalls++;}public float GetAnimatorSpeed(int n)=>1;public int GetCurrentAnimationName()=>0;}}
namespace GPUInstancer.CrowdAnimations {public class GPUICrowdPrefab:UnityEngine.Object{public float Speed=1;public int Calls;}public static class GPUICrowdAPI {public static void SetAnimationSpeed(GPUICrowdPrefab p,float speed){p.Speed=speed;p.Calls++;}}}
public static class HWGPUInstancerManager {public static bool Supported;public static bool IsGPUInstancerSupported()=>Supported;}
namespace EventModule { public class EventManager { public static EventManager Instance=new(); public static string ThrowOn; public void TriggerEvent(string name,object arg=null) { if(ThrowOn==name)throw new InvalidOperationException(name); State.Current.Trace.Add(new object[]{name,arg,State.Current.hasCoin}); } } }
public class SubGameBuffManager { public static SubGameBuffManager Instance=new(); public void OnCoinChanged(bool enemy,int amount) { State.Current.Trace.Add(new object[]{"buff",enemy?1:0,amount}); } }
public class BattleGameSceneManager {
 public static BattleGameSceneManager Instance=new(); public int PlayerHasHex,EnemyHasHex;
 public List<GameObject> allPlayerRoleObj=new(),allEnemyRoleObj=new(),allPlayerArchitectureObj=new(),allEnemyArchitectureObj=new();
}
public class BattleFPSController { public static BattleFPSController Instance; public void StopMonitoring(){State.Current.EndTrace.Add("monitor-stop");} }
public partial class State:UnityEngine.Object {
 public static State Current; public List<object[]> Trace=new(); public List<string> EndTrace=new();
 public int hasCoin,battleTotalEarned,battleTotalCost,gameUseCoinNums,openHexCount,countDownTime;
 public bool _isGamePaused,isCountDowning,hornIng,canCutDown,playerNowGameOpenGoldCardEd,_isAddCoining,isVictory;
 public float hornTime=5,_timeLeft;public string _timeString="3:00",betRewardNum;public Coroutine _myCoroutine;
 public Dictionary<string,int> cardOpenCount=new(),roleAllDamageDic=new(),towerAllDamageDic=new();
 public struct AnimationPauseSnapshot {public Dictionary<int,float> animatorInstanceSpeed;public bool hasGpuiCrowdPrefab;public float gpuiAnimationSpeed;public bool shouldResumeAniInstancing;}
 public Dictionary<int,DeadUnitInfo> GameDeadUnitInfoDic=new();public Dictionary<int,AnimationPauseSnapshot> _pausedRoleAnimationSnapshots=new();
 public Action<bool> gameEndCallBack,applyRewardCallBack; public object rewardConfig;
 public State(){Current=this;}
 public void GameEnd(bool victory,bool text){Trace.Add(new object[]{"gameEnd",victory?1:0,text?1:0});}
 public void StopCoroutine(Coroutine c){Trace.Add(new object[]{"stop"});EndTrace.Add("stop");}
 public Coroutine StartCoroutine(IEnumerator c){Trace.Add(new object[]{"countdown"});Trace.Add(new object[]{"start"});return new Coroutine();}
}
public class GamePanelManager { public static GamePanelManager Instance=new(); public List<object[]> Calls=new(); public void UpdateInfo(object[] p){Calls.Add(p);} }
