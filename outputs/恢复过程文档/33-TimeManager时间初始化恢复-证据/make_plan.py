import json
from pathlib import Path
p=Path(__file__).parent
methods=[]
def add(token,body,async_=False,iterator=False):
    methods.append(dict(token=token,body='{\n'+body+'\n}',makeAsync=async_,iterator=iterator))
add('0x60004B4','''_timers = new Dictionary<string, Timer>();
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
        if (count % 100 == 0) DBTSDK.SDKToolManager.Instance.ShowToast("服务器时间同步异常");
    }
    UnityEngine.Debug.Log("[TimeManager] 服务器时间同步成功");
}
await UniTask.WaitForSeconds(0.1f);
HandleTimeToWeekCutDown();''',True)
add('0x60004B6','''// Editor provider adapter: select the original LocalTime branch without changing server/data readiness.
#if UNITY_EDITOR
if (Application.isEditor)
{
    _currentTimeSource = TimeSource.LocalTime;
    UnityEngine.Debug.Log("[TimeManager] Time source: LocalEditor (original LocalTime provider)");
    return;
}
#endif
bool timedOut = await UniTask.WaitUntil(() => DBTSDK.AppInfoManager.Instance.IsOnlineParamReady_Override())
    .TimeoutWithoutException(TimeSpan.FromSeconds(10));
_currentTimeSource = timedOut ? TimeSource.NetworkTime
    : L_Tools.OnlineParamControl.Instance.GetOnlineParam("UseLocalTime", "") == "1"
        ? TimeSource.LocalTime : TimeSource.NetworkTime;''',True)
add('0x60004B7','return dt.AddDays(-(((int)dt.DayOfWeek + 6) % 7)).Date;')
add('0x60004B8','''DateTime time = GetLocalNetworkTime();
DbtSaveDataManager_PlayerTimeData.I.Data.lastExitGameTime = time;
DbtSaveDataManager_PlayerTimeData.I.Save();''')
add('0x60004BB','''while (!IsNetworkConnected) await UniTask.Yield();
while (toWeekTimer == null) await UniTask.Yield();
if (toWeekTimer.IsCompleted()) toWeekTimer.Restart(GetTimeSpanToWeek(), true);''',True)
add('0x60004BD','''if (_currentTimeSource != TimeSource.NetworkTime)
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
IsNetworkConnected = true;''',iterator=True)
add('0x60004BE','''toZeroTimer = GetTimer("TimeToZeroKey") ?? CreateTimer("TimeToZeroKey", GetTimeSpanToZero(), true, false);
toZeroStandardNetworkTime = GetTimer("TimeToZeroKeyStandardNetworkTime")
    ?? CreateTimer("TimeToZeroKeyStandardNetworkTime", GetTimeSpanToZeroStandardNetworkTime(), true, true);''')
add('0x60004BF','''if (toZeroTimer != null && toZeroTimer.IsCompleted())
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
}''')
add('0x60004C0','toWeekTimer = GetTimer("TimeToWeekKey") ?? CreateTimer("TimeToWeekKey", GetTimeSpanToWeek(), true, false);')
add('0x60004C1','''if (toWeekTimer.IsCompleted())
{
    toWeekTimer.Restart(GetTimeSpanToWeek(), true);
    _onTimeReachMondayZero?.Invoke();
    ChangeTimeInfoEndTime("TimeToWeekKey", toWeekTimer.TargetEndTime);
    UnityEngine.Debug.Log("周一零点到达 执行了");
    EventModule.EventManager.Instance.TriggerEvent("TimeToMonDayZero", null);
}''')
add('0x60004C2','''if (_onWeekPassed != null)
{
    DateTime last = DbtSaveDataManager_PlayerTimeData.I.Data.lastExitGameTime;
    if (last != default(DateTime))
    {
        if (GetStartOfWeekForTimeManager(GetLocalNetworkTime()) > GetStartOfWeekForTimeManager(last))
        {
            _onWeekPassed?.Invoke();
            SaveLastExitTime();
        }
        if (FirstCheckNewWeekFinish) return;
        FirstCheckNewWeekFinish = true;
    }
    SaveLastExitTime();
}''')
add('0x60004C3','''_toRemoveTimerKeys.Clear();
foreach (var pair in _cutdownTimers)
{
    if (pair.Value.IsCompleted() && _cutdownTimerEvents.ContainsKey(pair.Key))
        _toRemoveTimerKeys.Add(pair.Key);
}
for (int i = 0; i < _toRemoveTimerKeys.Count; i++)
{
    string key = _toRemoveTimerKeys[i];
    if (_cutdownTimerEvents.TryGetValue(key, out Action action) && action != null) action.Invoke();
    RemoveTimerEvent(key);
}
_toRemoveTimerKeys.Clear();''')
for token,check in [('0x60004C4','CheckTimerToZero'),('0x60004C5','CheckTimerEndEvent'),('0x60004C6','CheckWeekPassed')]:
    add(token,f'''yield return new WaitForSeconds(1f);
while (true)
{{
    {check}();
    yield return new WaitForSeconds(1f);
}}''',iterator=True)
add('0x60004C7','''if (!_isFetchingNetworkTime)
{
    if (_getTimeCoroutine != null) StopCoroutine(_getTimeCoroutine);
    _getTimeCoroutine = StartCoroutine(SyncServerTimeCoroutine());
}''')
add('0x60004CC','return useStandardNetworkTime ? GetStandardNetworkTime() : GetLocalNetworkTime();')
add('0x60004CD','return (_currentTimeSource == TimeSource.LocalTime ? DateTime.Now : L_Tools.DateTools.GetNow()).AddHours(_offsetHours);')
add('0x60004CE','return (_currentTimeSource == TimeSource.LocalTime ? DateTime.UtcNow : L_Tools.DateTools.GetUTCNow()).AddHours(_offsetHours);')
add('0x60004D0','''if (StringTool.IsNullOrEmpty(key, true) || _timers.ContainsKey(key)) return null;
Timer timer = new Timer(key, duration, isCountdown, useStandardNetTime);
_timers.Add(key, timer);
InitAddTimeInfo(timer);
return timer;''')
add('0x60004D2','''if (_cutdownTimerEvents.ContainsKey(timerKey)) _cutdownTimerEvents.Remove(timerKey);
if (_cutdownTimers.ContainsKey(timerKey)) _cutdownTimers.Remove(timerKey);''')
add('0x60004D4','_onTimeReachZero += action;')
add('0x60004D8','_onTimeReachMondayZero += action;')
add('0x60004D9','''if (!StringTool.IsNullOrEmpty(key, true) && _timers.ContainsKey(key)) return _timers[key];
return null;''')
add('0x60004DA','''while (!IsNetworkConnected) yield return null;
while (!DataManager.Instance.LoadDataCompleted) yield return null;
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
    foreach (var pair in _timers) InitAddTimeInfo(pair.Value);
}
while (!LoadingModule.LoadingManager.Instance.IsLoadingCompleted) yield return null;
InitToZeroTimer();
InitToWeekTimer();
if (_checkTimerToZeroCoroutine != null) StopCoroutine(_checkTimerToZeroCoroutine);
_checkTimerToZeroCoroutine = StartCoroutine(CheckTimerToZeroCoroutine());
if (_checkTimerEndEventCoroutine != null) StopCoroutine(_checkTimerEndEventCoroutine);
_checkTimerEndEventCoroutine = StartCoroutine(CheckTimerEndEventCoroutine());
if (_checkWeekPassedCoroutine != null) StopCoroutine(_checkWeekPassedCoroutine);
_checkWeekPassedCoroutine = StartCoroutine(CheckWeekPassedCoroutine());''',iterator=True)
add('0x60004DC','DateTime now = GetLocalNetworkTime();\nreturn now.Date.AddDays(1) - now;')
add('0x60004DD','DateTime now = GetStandardNetworkTime();\nreturn now.Date.AddDays(1) - now;')
add('0x60004DE','''DateTime now = GetLocalNetworkTime();
int days = (8 - (int)now.DayOfWeek) % 7;
if (days == 0) days = 7;
return now.AddDays(days).Date - now;''')
add('0x60004E0','''var dict = DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic;
if (dict.ContainsKey(timer.Key))
{
    dict[timer.Key].StartTime = timer.StartTime;
    dict[timer.Key].TargetEndTime = timer.TargetEndTime;
    DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic[timer.Key].StartTime = timer.StartTime;
    DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic[timer.Key].TargetEndTime = timer.TargetEndTime;
}
else
{
    var info = new TimeInfo { Key = timer.Key, StartTime = timer.StartTime, TargetEndTime = timer.TargetEndTime };
    dict.Add(timer.Key, info);
    DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic.TryAdd(timer.Key, info);
}
DbtSaveDataManager_PlayerTimeData.I.Save();''')
add('0x60004E1','''var dict = DbtSaveDataManager_PlayerTimeData.I.Data.timeInfoDic;
if (dict == null) dict = new Dictionary<string, TimeInfo>();
if (!dict.TryGetValue(key, out TimeInfo info)) return;
info.TargetEndTime = endTime;
TimeManager.Instance._timers[key].SetTargetEndTime(endTime);
DbtSaveDataManager_PlayerTimeData.I.Save();''')
add('0x60004EC','''Key = key;
this.useStandardNetTime = useStandardNetTime;
Restart(duration, isCountdown);''')
add('0x60004ED','TargetEndTime = targetEndTime;')
add('0x60004EE','''Key = timeInfo.Key;
StartTime = timeInfo.StartTime;
TargetEndTime = timeInfo.TargetEndTime;
useStandardNetTime = timeInfo.useStandardNetTime;''')
add('0x60004EF','''StartTime = TimeManager.Instance.GetNetworkTime(useStandardNetTime);
TargetEndTime = isCountdown ? StartTime + duration : DateTime.MaxValue;
TimeManager.Instance.InitAddTimeInfo(this);
DbtSaveDataManager_PlayerTimeData.I.Save();''')
add('0x60004F3','return TargetEndTime - TimeManager.Instance.GetNetworkTime(useStandardNetTime);')
add('0x60004F7','return TimeManager.Instance.GetNetworkTime(useStandardNetTime) >= TargetEndTime;')
time_methods=methods
methods=[]
add('0x6005E0F','return !UseLocalTime;')
add('0x6005E10','''if (UseLocalTime) UseLocalTime = false;
m_Now = StampToDatetime(serverTime, false).ToLocalTime();
m_UTCNow = StampToDatetime(serverTime, false);''')
add('0x6005E13','return m_Now;')
add('0x6005E15','return m_UTCNow;')
add('0x6005E19','return isMinSeconds ? StartTime_UTC.AddMilliseconds(TimeStamp) : StartTime_UTC.AddSeconds(TimeStamp);')
plan={'files':[
 dict(path='Assets/Scripts/Assembly-CSharp/TimeModuleO/TimeManager.cs',methods=time_methods,autoProperties=['0x1700003C','0x1700003D','0x1700003E']),
 dict(path='Assets/Scripts/Assembly-CSharp/L_Tools/DateTools.cs',methods=methods,autoProperties=[],helperClassToken='0x2000FB2',addHelper='''[Token(Token = "0x6005E26")]
[Address(RVA = "0x43FA7E4", Offset = "0x43F67E4", VA = "0x43FA7E4")]
static DateTools()
{
    StartTime = new DateTime(1970, 1, 1, 8, 0, 0, DateTimeKind.Utc);
    StartTime_UTC = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    UseLocalTime = true;
}''')
]}
(p/'write-plan.json').write_text(json.dumps(plan,indent=2,ensure_ascii=False),encoding='utf-8')
print('Planned',len(time_methods),'TimeManager/Timer methods,',len(methods),'DateTools methods + original cctor; 3 auto properties')
