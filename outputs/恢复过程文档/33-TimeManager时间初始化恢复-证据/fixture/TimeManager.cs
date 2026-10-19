using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DataModule;
using ToolModule;
using UnityEngine;

namespace TimeModuleO
{
	public class TimeManager : ManagerBase<TimeManager>
	{
		public enum TimeSource
		{
			NetworkTime = 0,
			LocalTime = 1
		}
		public class Timer
		{
			private int hours;
			private int minutes;
			public string Key
			{
				get
;								private set
;			}
			public DateTime StartTime
			{
				get
;								private set
;			}
			public DateTime TargetEndTime
			{
				get
;								private set
;			}
			public bool useStandardNetTime
			{
				get;
				private set;
			}
			public Timer(string key, TimeSpan duration, bool isCountdown, bool useStandardNetTime)
			{
    Key = key;
    this.useStandardNetTime = useStandardNetTime;
    Restart(duration, isCountdown);
}
			public void SetTargetEndTime(DateTime targetEndTime)
			{
    TargetEndTime = targetEndTime;
}
			public Timer(TimeInfo timeInfo)
			{
    Key = timeInfo.Key;
    StartTime = timeInfo.StartTime;
    TargetEndTime = timeInfo.TargetEndTime;
    useStandardNetTime = timeInfo.useStandardNetTime;
}
			public void Restart(TimeSpan duration, bool isCountdown)
			{
    StartTime = TimeManager.Instance.GetNetworkTime(useStandardNetTime);
    TargetEndTime = isCountdown ? StartTime + duration : DateTime.MaxValue;
    TimeManager.Instance.InitAddTimeInfo(this);
    DbtSaveDataManager_PlayerTimeData.I.Save();
}
			public void ChangeTime(TimeSpan duration, bool isAdd = false)
			{
			}
			public void ChangeUseStandNetTime(bool useStandardNetTime)
			{
			}
			public TimeSpan GetElapsedTime()
			{
				return default;
			}
			public TimeSpan GetRemainingTime()
			{
    return TargetEndTime - TimeManager.Instance.GetNetworkTime(useStandardNetTime);
}
			public string GetFormattedElapsedTime(int unit = 5)
			{
				return null;
			}
			public string GetFormattedRemainingTime(int unit = 5)
			{
				return null;
			}
			public int GetFormattedRemainingMinuteTime()
			{
				return default;
			}
			public bool IsCompleted()
			{
    return TimeManager.Instance.GetNetworkTime(useStandardNetTime) >= TargetEndTime;
}
		}
		private TimeSource _currentTimeSource;
		private bool _isFetchingNetworkTime;
		private Dictionary<string, Timer> _timers;
		private Action _onTimeReachZero;
		private Action _onStandardNetworkTimeReachZero;
		private Action _onTimeReachMondayZero;
		private Action _onWeekPassed;
		private int _offsetHours;
		public Timer toZeroTimer;
		public Timer toZeroStandardNetworkTime;
		public Timer toWeekTimer;
		public bool initComplete;
		public Dictionary<string, Action> _cutdownTimerEvents;
		public Dictionary<string, Timer> _cutdownTimers;
		private List<string> _toRemoveTimerKeys;
		private Coroutine _getTimeCoroutine;
		private Coroutine _checkTimerToZeroCoroutine;
		private Coroutine _checkTimerEndEventCoroutine;
		private Coroutine _checkWeekPassedCoroutine;
		private bool FirstCheckNewWeekFinish;
		private DateTime lastFocusLossTime;
		public bool IsNetworkConnected
		{
			get;
			private set;
		}
		public int OffsetHours
		{
			get
			{
				return _offsetHours;
			}
		}
		public void AddOffsetHours(int hours)
		{
		}
		public void ClearOffsetHours()
		{
		}
		public override async UniTask Init()
		{
    _timers = new Dictionary<string, Timer>();
    _cutdownTimerEvents = new Dictionary<string, Action>();
    _cutdownTimers = new Dictionary<string, Timer>();
    _toRemoveTimerKeys = new List<string>();
    await InitializeTimeSource();
    SyncServerTime();
    StartCoroutine(LoadTimers());
    _offsetHours = L_Tools.PlayerPrefs2Center.GetInt("OffsetHours", 0);
    initComplete = true;
    if (_currentTimeSource == TimeSource.NetworkTime)
    {
        int count = 0;
        while (!IsNetworkConnected)
        {
            await UniTask.WaitForSeconds(0.1f);
            count++;
            if (count % 100 == 0)
                DBTSDK.SDKToolManager.Instance.ShowToast("服务器时间同步异常");
        }

        UnityEngine.Debug.Log("[TimeManager] 服务器时间同步成功");
    }

    await UniTask.WaitForSeconds(0.1f);
    HandleTimeToWeekCutDown();
}
		private void OnMiniGameOnShow(object[] args)
		{
		}
		private async UniTask InitializeTimeSource()
		{
    // Editor provider adapter: select the original LocalTime branch without changing server/data readiness.
#if UNITY_EDITOR
if (Application.isEditor)
{
    _currentTimeSource = TimeSource.LocalTime;
    UnityEngine.Debug.Log("[TimeManager] Time source: LocalEditor (original LocalTime provider)");
    return;
}
#endif
    bool timedOut = await UniTask.WaitUntil(() => DBTSDK.AppInfoManager.Instance.IsOnlineParamReady_Override()).TimeoutWithoutException(TimeSpan.FromSeconds(10));
    _currentTimeSource = timedOut ? TimeSource.NetworkTime : L_Tools.OnlineParamControl.Instance.GetOnlineParam("UseLocalTime", "") == "1" ? TimeSource.LocalTime : TimeSource.NetworkTime;
}
		private DateTime GetStartOfWeekForTimeManager(DateTime dt)
		{
    return dt.AddDays(-(((int)dt.DayOfWeek + 6) % 7)).Date;
}
		public void SaveLastExitTime()
		{
    DateTime time = GetLocalNetworkTime();
    DbtSaveDataManager_PlayerTimeData.I.Data.lastExitGameTime = time;
    DbtSaveDataManager_PlayerTimeData.I.Save();
}
		public void RegisterOnWeekPassed(Action action)
		{
		}
		public void UnRegisterOnWeekPassed(Action action)
		{
		}
		private async void HandleTimeToWeekCutDown()
		{
    while (!IsNetworkConnected)
        await UniTask.Yield();
    while (toWeekTimer == null)
        await UniTask.Yield();
    if (toWeekTimer.IsCompleted())
        toWeekTimer.Restart(GetTimeSpanToWeek(), true);
}
		private void Update()
		{
		}
		private IEnumerator SyncServerTimeCoroutine()
		{
    if (_currentTimeSource != TimeSource.NetworkTime)
    {
        IsNetworkConnected = true;
        yield break;
    }

    _isFetchingNetworkTime = true;
    L_Tools.ServerTimeMgr.I.TryCheck(true);
    float requestTimer = 0f;
    while (!L_Tools.ServerTimeMgr.IsUpdateFinish)
    {
        requestTimer += Time.deltaTime;
        if (requestTimer > 3f)
        {
            requestTimer = 0f;
            L_Tools.ServerTimeMgr.I.TryCheck(true);
        }

        yield return null;
    }

    _isFetchingNetworkTime = false;
    IsNetworkConnected = true;
}
		private void InitToZeroTimer()
		{
    toZeroTimer = GetTimer("TimeToZeroKey") ?? CreateTimer("TimeToZeroKey", GetTimeSpanToZero(), true, false);
    toZeroStandardNetworkTime = GetTimer("TimeToZeroKeyStandardNetworkTime") ?? CreateTimer("TimeToZeroKeyStandardNetworkTime", GetTimeSpanToZeroStandardNetworkTime(), true, true);
}
		private void CheckTimerToZero()
		{
    if (toZeroTimer != null && toZeroTimer.IsCompleted())
    {
        toZeroTimer.Restart(GetTimeSpanToZero(), true);
        _onTimeReachZero?.Invoke();
        ChangeTimeInfoEndTime("TimeToZeroKey", toZeroTimer.TargetEndTime);
        UnityEngine.Debug.Log("每日零点到达 执行了");
        EventModule.EventManager.Instance.TriggerEvent("TimeToZero", null);
        if (GetLocalNetworkTime().DayOfWeek == DayOfWeek.Monday)
        {
            toWeekTimer.Restart(GetTimeSpanToWeek(), true);
            _onTimeReachMondayZero?.Invoke();
            UnityEngine.Debug.Log("周一零点到达 执行了");
            EventModule.EventManager.Instance.TriggerEvent("TimeToMonDayZero", null);
        }
    }

    if (toZeroStandardNetworkTime != null && toZeroStandardNetworkTime.IsCompleted())
    {
        toZeroStandardNetworkTime.Restart(GetTimeSpanToZeroStandardNetworkTime(), true);
        _onStandardNetworkTimeReachZero?.Invoke();
        ChangeTimeInfoEndTime("TimeToZeroKeyStandardNetworkTime", toZeroStandardNetworkTime.TargetEndTime);
        EventModule.EventManager.Instance.TriggerEvent("TimeToZeroStandardNetworkTime", null);
    }
}
		private void InitToWeekTimer()
		{
    toWeekTimer = GetTimer("TimeToWeekKey") ?? CreateTimer("TimeToWeekKey", GetTimeSpanToWeek(), true, false);
}
		private void CheckTimerToWeek()
		{
    if (toWeekTimer.IsCompleted())
    {
        toWeekTimer.Restart(GetTimeSpanToWeek(), true);
        _onTimeReachMondayZero?.Invoke();
        ChangeTimeInfoEndTime("TimeToWeekKey", toWeekTimer.TargetEndTime);
        UnityEngine.Debug.Log("周一零点到达 执行了");
        EventModule.EventManager.Instance.TriggerEvent("TimeToMonDayZero", null);
    }
}
		private void CheckWeekPassed()
		{
    if (_onWeekPassed != null)
    {
        DateTime last = DbtSaveDataManager_PlayerTimeData.I.Data.lastExitGameTime;
        if (last != default(DateTime))
        {
            if (GetStartOfWeekForTimeManager(GetLocalNetworkTime()) > GetStartOfWeekForTimeManager(last))
            {
                _onWeekPassed?.Invoke();
                SaveLastExitTime();
            }

            if (FirstCheckNewWeekFinish)
                return;
            FirstCheckNewWeekFinish = true;
        }

        SaveLastExitTime();
    }
}
		private void CheckTimerEndEvent()
		{
    _toRemoveTimerKeys.Clear();
    foreach (var pair in _cutdownTimers)
    {
        if (pair.Value.IsCompleted() && _cutdownTimerEvents.ContainsKey(pair.Key))
            _toRemoveTimerKeys.Add(pair.Key);
    }

    for (int i = 0; i < _toRemoveTimerKeys.Count; i++)
    {
        string key = _toRemoveTimerKeys[i];
        if (_cutdownTimerEvents.TryGetValue(key, out Action action) && action != null)
            action.Invoke();
        RemoveTimerEvent(key);
    }

    _toRemoveTimerKeys.Clear();
}
		private IEnumerator CheckTimerToZeroCoroutine()
		{
    yield return new WaitForSeconds(1f);
    while (true)
    {
        CheckTimerToZero();
        yield return new WaitForSeconds(1f);
    }
}
		private IEnumerator CheckTimerEndEventCoroutine()
		{
    yield return new WaitForSeconds(1f);
    while (true)
    {
        CheckTimerEndEvent();
        yield return new WaitForSeconds(1f);
    }
}
		private IEnumerator CheckWeekPassedCoroutine()
		{
    yield return new WaitForSeconds(1f);
    while (true)
    {
        CheckWeekPassed();
        yield return new WaitForSeconds(1f);
    }
}
		private void SyncServerTime()
		{
    if (!_isFetchingNetworkTime)
    {
        if (_getTimeCoroutine != null)
            StopCoroutine(_getTimeCoroutine);
        _getTimeCoroutine = StartCoroutine(SyncServerTimeCoroutine());
    }
}
		private void OnApplicationFocus(bool hasFocus)
		{
		}
		private void OnApplicationQuit()
		{
		}
		private UniTask OnApplicationStateChange(bool hasFocus)
		{
			return default;
		}
		private void OnApplicationPause(bool pauseStatus)
		{
		}
		public DateTime GetNetworkTime(bool useStandardNetworkTime = false)
		{
    return useStandardNetworkTime ? GetStandardNetworkTime() : GetLocalNetworkTime();
}
		public DateTime GetLocalNetworkTime()
		{
    return (_currentTimeSource == TimeSource.LocalTime ? DateTime.Now : L_Tools.DateTools.GetNow()).AddHours(_offsetHours);
}
		public DateTime GetStandardNetworkTime()
		{
    return (_currentTimeSource == TimeSource.LocalTime ? DateTime.UtcNow : L_Tools.DateTools.GetUTCNow()).AddHours(_offsetHours);
}
		public void ShowAllCutDowmLog()
		{
		}
		public Timer CreateTimer(string key, TimeSpan duration, bool isCountdown, bool useStandardNetTime = false)
		{
    if (StringTool.IsNullOrEmpty(key, true) || _timers.ContainsKey(key))
        return null;
    Timer timer = new Timer(key, duration, isCountdown, useStandardNetTime);
    _timers.Add(key, timer);
    InitAddTimeInfo(timer);
    return timer;
}
		public void RegisterOnCutdownTimerEnd(string timerKey, Action action)
		{
		}
		public void RemoveTimerEvent(string timerKey)
		{
    if (_cutdownTimerEvents.ContainsKey(timerKey))
        _cutdownTimerEvents.Remove(timerKey);
    if (_cutdownTimers.ContainsKey(timerKey))
        _cutdownTimers.Remove(timerKey);
}
		public void RemoveTimerEvent(string timerKey, Action action)
		{
		}
		public void RegisterOnTimeToZero(Action action)
		{
    _onTimeReachZero += action;
}
		public void RegisterOnStandardNetworkTimeToZero(Action action)
		{
		}
		public void UnRegisterOnTimeToZero(Action action)
		{
		}
		public void UnRegisterOnStandardNetworkTimeToZero(Action action)
		{
		}
		public void RegisterOnTimeToMondayZero(Action action)
		{
    _onTimeReachMondayZero += action;
}
		public Timer GetTimer(string key)
		{
    if (!StringTool.IsNullOrEmpty(key, true) && _timers.ContainsKey(key))
        return _timers[key];
    return null;
}
		private IEnumerator LoadTimers()
		{
    while (!IsNetworkConnected)
        yield return null;
    while (!DataManager.Instance.LoadDataCompleted)
        yield return null;
    if (DbtSaveDataManager_PlayerCoreData.I.Data.playerTimeInfoConverted)
    {
        _timers.Clear();
        foreach (var pair in DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic)
            _timers.Add(pair.Key, new Timer(pair.Value));
    }
    else
    {
        DbtSaveDataManager_PlayerCoreData.I.Data.playerTimeInfoConverted = true;
        DbtSaveDataManager_PlayerCoreData.I.Save();
        foreach (var pair in _timers)
            InitAddTimeInfo(pair.Value);
    }

    while (!LoadingModule.LoadingManager.Instance.IsLoadingCompleted)
        yield return null;
    InitToZeroTimer();
    InitToWeekTimer();
    if (_checkTimerToZeroCoroutine != null)
        StopCoroutine(_checkTimerToZeroCoroutine);
    _checkTimerToZeroCoroutine = StartCoroutine(CheckTimerToZeroCoroutine());
    if (_checkTimerEndEventCoroutine != null)
        StopCoroutine(_checkTimerEndEventCoroutine);
    _checkTimerEndEventCoroutine = StartCoroutine(CheckTimerEndEventCoroutine());
    if (_checkWeekPassedCoroutine != null)
        StopCoroutine(_checkWeekPassedCoroutine);
    _checkWeekPassedCoroutine = StartCoroutine(CheckWeekPassedCoroutine());
}
		public void RemoveTimer(string key)
		{
		}
		public TimeSpan GetTimeSpanToZero()
		{
    DateTime now = GetLocalNetworkTime();
    return now.Date.AddDays(1) - now;
}
		public TimeSpan GetTimeSpanToZeroStandardNetworkTime()
		{
    DateTime now = GetStandardNetworkTime();
    return now.Date.AddDays(1) - now;
}
		public TimeSpan GetTimeSpanToWeek()
		{
    DateTime now = GetLocalNetworkTime();
    int days = (8 - (int)now.DayOfWeek) % 7;
    if (days == 0)
        days = 7;
    return now.AddDays(days).Date - now;
}
		public TimeSpan GetTimeSpanToDayZero(int dayCount)
		{
			return default;
		}
		public void InitAddTimeInfo(Timer timer)
		{
    var dict = DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic;
    if (dict.ContainsKey(timer.Key))
    {
        dict[timer.Key].StartTime = timer.StartTime;
        dict[timer.Key].TargetEndTime = timer.TargetEndTime;
        DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic[timer.Key].StartTime = timer.StartTime;
        DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic[timer.Key].TargetEndTime = timer.TargetEndTime;
    }
    else
    {
        var info = new TimeInfo
        {
            Key = timer.Key,
            StartTime = timer.StartTime,
            TargetEndTime = timer.TargetEndTime
        };
        dict.Add(timer.Key, info);
        DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic.TryAdd(timer.Key, info);
    }

    DbtSaveDataManager_PlayerTimeData.I.Save();
}
		public static void ChangeTimeInfoEndTime(string key, DateTime endTime)
		{
    var dict = DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic;
    if (dict == null)
        dict = new Dictionary<string, TimeInfo>();
    if (!dict.TryGetValue(key, out TimeInfo info))
        return;
    info.TargetEndTime = endTime;
    TimeManager.Instance._timers[key].SetTargetEndTime(endTime);
    DbtSaveDataManager_PlayerTimeData.I.Save();
}
		public void RemoveTimeInfo(string timerKey)
		{
		}
		public TimeManager()
		{
		}
	}
}
