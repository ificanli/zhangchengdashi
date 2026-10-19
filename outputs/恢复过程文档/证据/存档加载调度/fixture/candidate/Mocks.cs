using System;
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
public class DbtSaveDataManager_PlayerMainCityData: MockManager { public static DbtSaveDataManager_PlayerMainCityData I; public DbtSaveDataManager_PlayerMainCityData():base("DbtSaveDataManager_PlayerMainCityData") {} }
public class DbtSaveDataManager_PlayerCardData: MockManager { public static DbtSaveDataManager_PlayerCardData I; public DbtSaveDataManager_PlayerCardData():base("DbtSaveDataManager_PlayerCardData") {} }
public class DbtSaveDataManager_PlayerShopData: MockManager { public static DbtSaveDataManager_PlayerShopData I; public DbtSaveDataManager_PlayerShopData():base("DbtSaveDataManager_PlayerShopData") {} }
public class DbtSaveDataManager_PlayerArenaData: MockManager { public static DbtSaveDataManager_PlayerArenaData I; public DbtSaveDataManager_PlayerArenaData():base("DbtSaveDataManager_PlayerArenaData") {} }
public class DbtSaveDataManager_PlayerRankData: MockManager { public static DbtSaveDataManager_PlayerRankData I; public DbtSaveDataManager_PlayerRankData():base("DbtSaveDataManager_PlayerRankData") {} }
public class DbtSaveDataManager_PlayerResourceData: MockManager { public static DbtSaveDataManager_PlayerResourceData I; public DbtSaveDataManager_PlayerResourceData():base("DbtSaveDataManager_PlayerResourceData") {} }
public class DbtSaveDataManager_PlayerChestData: MockManager { public static DbtSaveDataManager_PlayerChestData I; public DbtSaveDataManager_PlayerChestData():base("DbtSaveDataManager_PlayerChestData") {} }
public class DbtSaveDataManager_PlayerTimeData: MockManager { public static DbtSaveDataManager_PlayerTimeData I; public DbtSaveDataManager_PlayerTimeData():base("DbtSaveDataManager_PlayerTimeData") {} }
public class DbtSaveDataManager_PlayerAdData: MockManager { public static DbtSaveDataManager_PlayerAdData I; public DbtSaveDataManager_PlayerAdData():base("DbtSaveDataManager_PlayerAdData") {} }
public class DbtSaveDataManager_PlayerArtifactData: MockManager { public static DbtSaveDataManager_PlayerArtifactData I; public DbtSaveDataManager_PlayerArtifactData():base("DbtSaveDataManager_PlayerArtifactData") {} }
public class DbtSaveDataManager_PlayerCustomizationData: MockManager { public static DbtSaveDataManager_PlayerCustomizationData I; public DbtSaveDataManager_PlayerCustomizationData():base("DbtSaveDataManager_PlayerCustomizationData") {} }
public class DbtSaveDataManager_PlayerCoreData: MockManager { public static DbtSaveDataManager_PlayerCoreData I; public DbtSaveDataManager_PlayerCoreData():base("DbtSaveDataManager_PlayerCoreData") {} }
public class DbtSaveDataManager_PlayerGuideData: MockManager { public static DbtSaveDataManager_PlayerGuideData I; public DbtSaveDataManager_PlayerGuideData():base("DbtSaveDataManager_PlayerGuideData") {} }
public class DbtSaveDataManager_PlayerMysteryAdventureData: MockManager { public static DbtSaveDataManager_PlayerMysteryAdventureData I; public DbtSaveDataManager_PlayerMysteryAdventureData():base("DbtSaveDataManager_PlayerMysteryAdventureData") {} }
public class DbtSaveDataManager_PlayerWorldCupActivityData: MockManager { public static DbtSaveDataManager_PlayerWorldCupActivityData I; public DbtSaveDataManager_PlayerWorldCupActivityData():base("DbtSaveDataManager_PlayerWorldCupActivityData") {} }