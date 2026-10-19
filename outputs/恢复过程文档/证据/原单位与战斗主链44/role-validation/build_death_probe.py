from pathlib import Path
import sys
from restore_role import DEST,extract
OWN=Path(__file__).resolve().parent
baseline='--baseline' in sys.argv;path=OWN/'source-before.cs' if baseline else DEST
m=extract(path.read_text(encoding='utf-8-sig'))
prefix='''using System;using System.Collections.Generic;using System.Text.Json;using System.Runtime.CompilerServices;using Cysharp.Threading.Tasks;using UnityEngine;using DG.Tweening;
public static class State {public static List<string> Log=new();public static bool Ab,Reduce,Pending,Resumed;public static int Bless,Buff;public static uint LengthBits;}
namespace UnityEngine {public class Transform{public Vector3 position;}public class GameObject{}public struct Vector3{} }
namespace DG.Tweening {public static class Extensions{public static void DOKill(this UnityEngine.Transform t){State.Log.Add("kill-tween");}}}
public enum DeadType{Common,HellFire}public static class GPUInstanceAnimationBehaviour {public enum AnimationName{Idle,Run,Dead,Attack}}
public interface IAnimation {float GetAnimationLength(GPUInstanceAnimationBehaviour.AnimationName name);}
public class Animation:IAnimation{public float GetAnimationLength(GPUInstanceAnimationBehaviour.AnimationName n){State.Log.Add("length");return BitConverter.UInt32BitsToSingle(State.LengthBits);}}
namespace Cysharp.Threading.Tasks {
public enum PlayerLoopTiming{Update=8}
public struct UniTask {
public static UniTask WaitForSeconds(float duration,bool ignore,PlayerLoopTiming timing,System.Threading.CancellationToken token,bool immediately){if(ignore||(int)timing!=8||token!=default||immediately)throw new Exception("wait ABI");State.Log.Add("wait:"+BitConverter.SingleToUInt32Bits(duration));return new UniTask();}
public Awaiter GetAwaiter()=>new Awaiter{valid=true};
public struct Awaiter:ICriticalNotifyCompletion {
public bool valid;public bool IsCompleted{get{State.Log.Add("status");return !State.Pending||State.Resumed;}}
public void GetResult(){State.Log.Add("result");}
public void OnCompleted(Action action){State.Log.Add("await");}
public void UnsafeOnCompleted(Action action){State.Log.Add("await");}
}
}}
public class HexBehaviour {public void RemoveRole(int id,bool player,RoleBehaviour role){if(id!=7||player==role.isEnemy)throw new Exception("camp ABI");State.Log.Add("hex-remove");}}
namespace EventModule{public class EventManager {public static EventManager Instance=new();public void TriggerEvent(string name,GameObject obj){if(name!="HasRoleDead")throw new Exception("event");State.Log.Add("event");}}}
namespace SDKModule {public class ABTestManager{public static ABTestManager Instance=new();public bool GamePlayImprove01IsBTest{get{State.Log.Add("ab");return State.Ab;}}}}
namespace GameConfigModule{public static class GameConfigManager{public static Config GameGlobalConfig=new();}public class Config{public bool enableReduceArena12EnemyDifficulty=>State.Reduce;}}
namespace UIModuleO {public enum TextEffImgType{Null,Coin}public enum PositionType{WorldPosition}public class UITextEffectManager{public static UITextEffectManager Instance=new();public void ShowTextEffect(string text,Vector3 pos,TextEffImgType img,float scale,PositionType type){if(img!=TextEffImgType.Coin||scale!=1||(int)type!=0)throw new Exception("text contract");State.Log.Add("cointext");}}}
public static class CoreGameManager{public static string NowPlayEdArenaID;}
public class SubGameBuffManager{public static SubGameBuffManager Instance=new();public void OnFriendlyUnitDead(bool enemy,Vector3 pos){State.Log.Add("friendly-dead");}public void ModifyKillCoin(ref int coin,bool enemy){coin=unchecked(coin+State.Buff);State.Log.Add("modify-coin");}}
public class DailyBlessManager{public static DailyBlessManager Instance=new();public int KillUnitCoinHandle(bool enemy){State.Log.Add("bless");return State.Bless;}}
public class BattleGameManager{public static BattleGameManager Instance=new();public void ChangeCoin(int coin){State.Log.Add("player-coin:"+coin);}}
public class AIBehaviourManager{public static AIBehaviourManager Instance=new();public void ChangeCoin(int coin){State.Log.Add("ai-coin:"+coin);}}
public class BattleGameSceneManager{public static BattleGameSceneManager Instance=new();public void RemoveEnemyRole(GameObject obj,bool spawn){if(!spawn)throw new Exception("spawn");State.Log.Add("remove-enemy");}public void RemovePlayerRole(GameObject obj,bool spawn){if(!spawn)throw new Exception("spawn");State.Log.Add("remove-player");}}
public class RoleShadowManager{public static RoleShadowManager Instance=new();public void Unbind(RoleBehaviour role){State.Log.Add("unbind");}}
public class RoleBehaviour {
public bool isEnemy,isDead,waitToChangeAnimationing;public HexBehaviour _currentHex;public int _instanceID=7;public Transform transform=new();public GameObject gameObject=new();public IAnimation gpuInstanceAnimationBehaviour=new Animation();
public void SetPathfindingEnabled(bool value){State.Log.Add("path:"+value.ToString().ToLowerInvariant());}public void RemoveHPUI(){State.Log.Add("remove-ui");}public void StopListeningEvent(){State.Log.Add("stop-listen");}public void SetAnimation(GPUInstanceAnimationBehaviour.AnimationName n,bool force){if(n!=GPUInstanceAnimationBehaviour.AnimationName.Dead||!force)throw new Exception("animation contract");State.Log.Add("animation");}public void SetAiCanMove(bool can){if(can)throw new Exception("move contract");State.Log.Add("can-move");}public void DeadCallBack(DeadType t){State.Log.Add("callback:"+(int)t);}
public struct _003CDead_003Ed__190:IAsyncStateMachine {
public int _003C_003E1__state;public AsyncVoidMethodBuilder _003C_003Et__builder;public RoleBehaviour _003C_003E4__this;public DeadType deadType;public UniTask.Awaiter _003C_003Eu__1;
public void MoveNext(){'''
mid='''}
public void SetStateMachine(IAsyncStateMachine stateMachine){'''
end='''}
}
public void Dead(DeadType deadType){'''
runner='''}
}
public static class Program {
public static int Main(string[] args){int checks=0,failed=0;List<string> errors=new();using var doc=JsonDocument.Parse(System.IO.File.ReadAllText(args[0]));int index=0;
foreach(var row in doc.RootElement.EnumerateArray()){
 var sc=row.GetProperty("scenario");bool V(string n)=>sc.GetProperty(n).GetBoolean();int I(string n)=>sc.GetProperty(n).GetInt32();
 State.Ab=V("ab");State.Reduce=V("reduce");State.Pending=V("pending");State.Resumed=false;State.LengthBits=sc.GetProperty("lengthBits").GetUInt32();State.Bless=I("bless");State.Buff=I("buff");CoreGameManager.NowPlayEdArenaID=new[]{"1001","1002","other"}[I("arena")];
 var role=new RoleBehaviour{isDead=V("dead"),isEnemy=V("enemy"),_currentHex=V("hex")?new HexBehaviour():null,waitToChangeAnimationing=true};
 var sm=new RoleBehaviour._003CDead_003Ed__190{_003C_003E1__state=-1,_003C_003Et__builder=AsyncVoidMethodBuilder.Create(),_003C_003E4__this=role,deadType=(DeadType)I("deadType")};
 int phase=0;
 foreach(var p in row.GetProperty("phases").EnumerateArray()){
  State.Resumed=phase>0;State.Log.Clear();sm.MoveNext();var expected=new List<string>();foreach(var t in p.GetProperty("trace").EnumerateArray())if(t.GetString()!="set-result")expected.Add(t.GetString());
  void Check(bool ok,string s){checks++;if(!ok){failed++;if(errors.Count<14)errors.Add("case "+index+" phase "+phase+" "+s);}}
  string actualTrace=string.Join("|",State.Log),expectedTrace=string.Join("|",expected);
  // Both runtimes classify NaN delay as NaN; payload/sign are platform specific.
  if(actualTrace!=expectedTrace){for(int i=0;i<State.Log.Count&&i<expected.Count;i++){if(State.Log[i].StartsWith("wait:")&&expected[i].StartsWith("wait:")){uint x=uint.Parse(State.Log[i].Substring(5)),y=uint.Parse(expected[i].Substring(5));if(float.IsNaN(BitConverter.UInt32BitsToSingle(x))&&float.IsNaN(BitConverter.UInt32BitsToSingle(y)))State.Log[i]=expected[i];}}actualTrace=string.Join("|",State.Log);}
  Check(actualTrace==expectedTrace,"trace actual="+actualTrace+" native="+expectedTrace);Check(sm._003C_003E1__state==p.GetProperty("state").GetInt32(),"state");Check(role.isDead==p.GetProperty("isDead").GetBoolean(),"isDead");Check(sm._003C_003Eu__1.valid==p.GetProperty("awaiterSaved").GetBoolean(),"awaiter storage");phase++;
 }
 index++;
}
Console.WriteLine(JsonSerializer.Serialize(new{cases=index,checks,failed,errors}));return failed==0?0:1;
}}
'''
(OWN/'Death.generated.cs').write_text(prefix+m[0x3d90878]['body']+mid+m[0x3d914e4]['body']+end+m[0x3d876cc]['body']+runner,encoding='utf-8')
(OWN/'DeathProbe.csproj').write_text('''<Project Sdk="Microsoft.NET.Sdk"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>net10.0</TargetFramework><EnableDefaultCompileItems>false</EnableDefaultCompileItems><Nullable>disable</Nullable></PropertyGroup><ItemGroup><Compile Include="Death.generated.cs" /></ItemGroup></Project>''',encoding='utf-8')
print('Death three bodies extracted from',path)
