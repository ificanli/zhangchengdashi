import json,re,sys,textwrap
from pathlib import Path
from bootstrap import members
W=Path(__file__).resolve().parent
REL='Assets/Scripts/Assembly-CSharp/GameModule/BattleGameManager.cs'
src=(W/'source-before'/REL).read_text(encoding='utf-8-sig')
B={}
def body(rva,text): B[rva.lower()]=textwrap.dedent(text).strip()
body('0x3DE3A9C','return (float)countDownTime - _timeLeft;')
body('0x3DE3AAC','return _isGamePaused || QuickTutor.TutorialManager.Instance.tutorialing;')
body('0x3DE3B48','return betRewardNum;')
body('0x3DE3B50','''
await FloatingTextManager.Instance.Init();
EventModule.EventManager.Instance.StartListening("CoinChangeUpdateGamePanel", CoinChangeUpdateGamePanel);
EventModule.EventManager.Instance.StartListening("HasHexDestroy", GameEndCheck);
EventModule.EventManager.Instance.StartListening("PlayerBeginOpenHex", PlayerOpenHexCountAdd);
EventModule.EventManager.Instance.StartListening("PlayerHornEmitIng", PlayerHornEmitIng);
EventModule.EventManager.Instance.StartListening("OnGameOver", ShowInterstitial);
EventModule.EventManager.Instance.StartListening("PlayerHornEmitEnd", PlayerHornEmitEnd);
EventModule.EventManager.Instance.StartListening("SettlementAnimationEnd", SettlementAnimationEnd);
EventModule.EventManager.Instance.StartListening("BetStartGame", BetRecordRewardNum);
EventModule.EventManager.Instance.StartListening("GameSteerEndShowCardProbabilityPanel", BeginStartCountDown);
EventModule.EventManager.Instance.StartListening("GameSteerEndShowCardProbabilityPanel", GuidOneEndAddCoin);
EventModule.EventManager.Instance.StartListening("CloseMatchPanel", CloseMatchPanel);
EventModule.EventManager.Instance.StartListening("PauseGame", OnPauseGame);
EventModule.EventManager.Instance.StartListening("ResumeGame", OnResumeGame);
roleAllDamageDic = new Dictionary<string, int>();
towerAllDamageDic = new Dictionary<string, int>();
cardOpenCount = new Dictionary<string, int>();
GameDeadUnitInfoDic = new Dictionary<int, DeadUnitInfo>();
''')
body('0x3DE3BDC','betRewardNum = o.ToString();')
body('0x3DE3C0C','''
if (cardOpenCount.ContainsKey(id)) cardOpenCount[id] = unchecked(cardOpenCount[id] + 1);
else cardOpenCount.Add(id, 1);
''')
body('0x3DE3CEC','ChangeCoin(200);')
body('0x3DE3F10','gameUseCoinNums = unchecked(gameUseCoinNums + num);')
body('0x3DE3F20','hornIng = true;')
body('0x3DE3F2C','hornIng = false;')
body('0x3DE3F34','''
int playerCount = BattleGameSceneManager.Instance.allPlayerArchitectureObj.Count;
if (playerCount == 0 || BattleGameSceneManager.Instance.allEnemyArchitectureObj.Count == 0)
    GameEnd(playerCount != 0, false);
''')
body('0x3DE4088','canCutDown = true;')
body('0x3DE3FD8','''
if (isVictory && WeeklyCardActivityManager.Instance.IsBTest())
    EventModule.EventManager.Instance.TriggerEvent("WeeklyCardActivityTaskTrigger", new object[] { WeeklyCardActivityManager.WeekLyTaskType.GameWin, 1 });
this.isVictory = isVictory;
if (doTxtAni) GamePanelManager.Instance.DoAni();
CoreGameManager.Gaming = false;
EventModule.EventManager.Instance.TriggerEvent("GameEnd");
isCountDowning = false;
if (_myCoroutine != null) StopCoroutine(_myCoroutine);
QuickTutor.TutorialManager.Instance.ForceCloseTutorial();
const string panel = "Assets/_Res/Addressable/02CoreGameBundle/Prefabs/UI/Panels/HexDescribesPanel.prefab";
if (UIFramework.UIManager.Instance.IsPanelShowing(panel, out _)) UIFramework.UIManager.Instance.HidePanel(panel);
if (doTxtAni) await UniTask.WaitForSeconds(2.3f);
BattleGameSceneManager.Instance.SettlementAnimation(isVictory);
''')
body('0x3DE50F8','openHexCount = unchecked(openHexCount + 1);')
body('0x3DE5108','''
if (isCountDowning && hornIng && hornTime > 0f) hornTime -= Time.deltaTime;
''')
body('0x3DE3CF4','''
unchecked
{
    if (coinNum < 0)
    {
        EventModule.EventManager.Instance.TriggerEvent("PlayerGameCostCoin", coinNum < 0 ? -coinNum : coinNum);
        if (hasCoin < -coinNum) coinNum = -hasCoin;
        battleTotalCost += coinNum < 0 ? -coinNum : coinNum;
    }
    else if (coinNum != 0) battleTotalEarned += coinNum;
    hasCoin = Mathf.Clamp(hasCoin + coinNum, 0, 10000000);
}
EventModule.EventManager.Instance.TriggerEvent("CoinChangeUpdateGamePanel");
EventModule.EventManager.Instance.TriggerEvent("PlayerCoinChange", hasCoin);
SubGameBuffManager.Instance.OnCoinChanged(false, hasCoin);
''')
body('0x3DE514C','GamePanelManager.Instance.UpdateInfo(new object[] { hasCoin, _timeString });')
body('0x3DE5278','''
while (_timeLeft > 0f)
{
    while (IsGamePaused) yield return new WaitForSeconds(0.1f);
    _timeString = GetTimeCutDownString();
    GamePanelManager.Instance.UpdateInfo(new object[] { hasCoin, _timeString });
    yield return new WaitForSeconds(1f);
    _timeLeft -= 1f;
    if (_timeLeft == 10f && UnityEngine.Random.Range(0, 101) <= 79)
        EventModule.EventManager.Instance.TriggerEvent("CountDownIsTen", 3);
    if (_timeLeft <= 0f) CountDownEnd();
}
''')
body('0x3DE5300','''
if (_isGamePaused == paused) return;
IsGamePaused = paused;
ApplyAnimationPauseToAllRoles(paused);
''')
body('0x3DE5424','SetGamePaused(true);')
body('0x3DE5444','SetGamePaused(false);')
body('0x3DE531C','''
if (BattleGameSceneManager.Instance == null) return;
ApplyAnimationPauseToRoleList(BattleGameSceneManager.Instance.allPlayerRoleObj, paused);
ApplyAnimationPauseToRoleList(BattleGameSceneManager.Instance.allEnemyRoleObj, paused);
if (!paused) _pausedRoleAnimationSnapshots.Clear();
''')
body('0x3DE545C','''
if (roles == null || roles.Count == 0) return;
for (int i = roles.Count - 1; i >= 0; --i)
    if (roles[i] != null) ApplyAnimationPauseToSingleRole(roles[i], paused);
''')
body('0x3DE5D94','''
if (IsGamePaused && roleObj != null) ApplyAnimationPauseToSingleRole(roleObj, true);
''')
body('0x3DE5540','''
int instanceID = roleObj.GetInstanceID();
if (paused)
{
    if (_pausedRoleAnimationSnapshots.ContainsKey(instanceID)) return;
    AnimationPauseSnapshot snapshot = new AnimationPauseSnapshot { animatorInstanceSpeed = new Dictionary<int, float>(4) };
    Animator[] animators = roleObj.GetComponentsInChildren<Animator>(true);
    if (animators != null)
        foreach (Animator animator in animators)
            if (animator != null)
            {
                int id = animator.GetInstanceID();
                if (!snapshot.animatorInstanceSpeed.ContainsKey(id)) snapshot.animatorInstanceSpeed.Add(id, animator.speed);
                animator.speed = 0f;
            }
    RoleBehaviour role = roleObj.GetComponent<RoleBehaviour>();
    IAnimation animation = role != null ? role.GetAnimationBehaviour() : null;
    RoleAnimationDriverType driver = role != null ? role.GetAnimationDriverType() : RoleAnimationDriverType.GPUInstancer;
    var instancing = animation as AnimationInstancing.AnimationInstancing;
    snapshot.gpuiAnimationSpeed = 1f;
    if (animation is AnimationInstancing.AnimationInstancing && (driver == RoleAnimationDriverType.AniInstancing || roleObj.GetComponent<GPUInstanceAnimationBehaviour>() == null))
    {
        if (instancing != null && !instancing.IsPause()) { instancing.Pause(); snapshot.shouldResumeAniInstancing = true; }
    }
    else if (HWGPUInstancerManager.IsGPUInstancerSupported())
    {
        var crowd = roleObj.GetComponent<GPUInstancer.CrowdAnimations.GPUICrowdPrefab>();
        if (crowd != null)
        {
            float speed = animation != null ? animation.GetAnimatorSpeed(animation.GetCurrentAnimationName()) : 1f;
            if (speed <= 0f) speed = 1f;
            snapshot.gpuiAnimationSpeed = speed;
            GPUInstancer.CrowdAnimations.GPUICrowdAPI.SetAnimationSpeed(crowd, 0f);
            snapshot.hasGpuiCrowdPrefab = true;
        }
    }
    _pausedRoleAnimationSnapshots.Add(instanceID, snapshot);
    return;
}
AnimationPauseSnapshot saved;
if (!_pausedRoleAnimationSnapshots.TryGetValue(instanceID, out saved)) return;
Animator[] current = roleObj.GetComponentsInChildren<Animator>(true);
if (current != null)
    foreach (Animator animator in current)
        if (animator != null)
        {
            float speed;
            if (saved.animatorInstanceSpeed != null && saved.animatorInstanceSpeed.TryGetValue(animator.GetInstanceID(), out speed)) animator.speed = speed;
            else if (animator.speed == 0f) animator.speed = 1f;
        }
RoleBehaviour currentRole = roleObj.GetComponent<RoleBehaviour>();
IAnimation currentAnimation = currentRole != null ? currentRole.GetAnimationBehaviour() : null;
if (saved.shouldResumeAniInstancing)
{
    var instancing = currentAnimation as AnimationInstancing.AnimationInstancing;
    if (instancing != null && instancing.IsPause()) instancing.Resume();
}
if (saved.hasGpuiCrowdPrefab && HWGPUInstancerManager.IsGPUInstancerSupported())
{
    var crowd = roleObj.GetComponent<GPUInstancer.CrowdAnimations.GPUICrowdPrefab>();
    if (crowd != null) GPUInstancer.CrowdAnimations.GPUICrowdAPI.SetAnimationSpeed(crowd, saved.gpuiAnimationSpeed);
}
_pausedRoleAnimationSnapshots.Remove(instanceID);
''')
body('0x3DE5E20','''
int minutes = Mathf.FloorToInt(_timeLeft / 60f);
int seconds = Mathf.FloorToInt(_timeLeft % 60f);
string format = seconds == 0 ? "{0}:{1}0" : seconds <= 9 ? "{0}:0{1}" : "{0}:{1}";
return string.Format(string.Format(format, minutes, seconds), Array.Empty<object>());
''')
body('0x3DE6088','''
if (roleAllDamageDic.ContainsKey(id)) roleAllDamageDic[id] = unchecked(roleAllDamageDic[id] + damage);
else roleAllDamageDic.Add(id, damage);
''')
body('0x3DE6178','''
if (towerAllDamageDic.ContainsKey(id)) towerAllDamageDic[id] = unchecked(towerAllDamageDic[id] + damage);
else towerAllDamageDic.Add(id, damage);
''')
body('0x3DE65C8','if (!GameDeadUnitInfoDic.ContainsKey(id)) GameDeadUnitInfoDic.Add(id, unitInfo);')
body('0x3DE666C','if (GameDeadUnitInfoDic.ContainsKey(id)) GameDeadUnitInfoDic.Remove(id);')
body('0x3DE66FC','''
if (_myCoroutine != null) StopCoroutine(_myCoroutine);
if (Time.timeScale == 0f) return;
if (BattleGameSceneManager.Instance.PlayerHasHex > BattleGameSceneManager.Instance.EnemyHasHex) GameEnd(true, true);
else if (BattleGameSceneManager.Instance.PlayerHasHex < BattleGameSceneManager.Instance.EnemyHasHex) GameEnd(false, true);
else if (BattleGameSceneManager.Instance.allPlayerRoleObj.Count > BattleGameSceneManager.Instance.allEnemyRoleObj.Count) GameEnd(true, true);
else if (BattleGameSceneManager.Instance.allPlayerRoleObj.Count < BattleGameSceneManager.Instance.allEnemyRoleObj.Count) GameEnd(false, true);
else if (Time.timeScale != 0f)
{
    _timeLeft += 10f;
    isCountDowning = true;
    if (_myCoroutine != null) StopCoroutine(_myCoroutine);
    _myCoroutine = StartCoroutine(Countdown());
}
''')
body('0x3DE6788','''
if (isCountDowning) return;
await UniTask.WaitUntil(() => canCutDown);
if (this == null || isCountDowning) return;
isCountDowning = true;
if (_myCoroutine != null) StopCoroutine(_myCoroutine);
_myCoroutine = StartCoroutine(Countdown());
''')
body('0x3DE6814','''
string arenaID = StringTool.IsNullOrEmpty(CoreGameManager.NowPlayEdArenaID) ? "1001" : CoreGameManager.NowPlayEdArenaID;
countDownTime = StringTool.ToInt(DataModule.DataManager.Instance.GlobalInfo.arenaInfoDic[arenaID].countDownTime);
SubGameBuffManager.Instance.ModifyCountDownTime(ref countDownTime);
_timeLeft = countDownTime;
_timeString = GetTimeCutDownString();
GamePanelManager.Instance.UpdateInfo(new object[] { hasCoin, _timeString });
if (TrainingGroundManager.IsInGuidedGame) hasCoin = TrainingGroundManager.Instance.GetPlayerInitialCoin();
else hasCoin = global::DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame ? 150 : 50;
battleInitCoin = hasCoin;
battleTotalEarned = hasCoin;
battleTotalCost = 0;
_isAddCoining = true;
if (!global::DbtSaveDataManager_PlayerGuideData.I.Data.isFirstThroghGame) BeginStartCountDown(null);
GameType = battleContext.GameType;
_battleContext = battleContext;
IsGamePaused = false;
gameEndCallBack = battleContext.gameEndCallBack;
applyRewardCallBack = battleContext.gameEndApplyRewardCallBack;
_pausedRoleAnimationSnapshots.Clear();
CheatControl.ResetPerfStates();
if (BattleFPSController.Instance != null) BattleFPSController.Instance.StartMonitoring();
List<int> ids = global::DbtSaveDataManager_PlayerCardData.I.Data.GetBattleCardIDList();
if (cardOpenCount == null) cardOpenCount = new Dictionary<string, int>();
for (int i = 0; i < ids.Count; ++i) cardOpenCount.TryAdd(ids[i].ToString(), 0);
''')
body('0x3DE6DAC','''
if (BattleFPSController.Instance != null) BattleFPSController.Instance.StopMonitoring();
playerNowGameOpenGoldCardEd = false;
gameEndCallBack?.Invoke(isVictory);
isCountDowning = false;
openHexCount = 0;
gameEndCallBack = null;
applyRewardCallBack = null;
rewardConfig = null;
if (_myCoroutine != null) StopCoroutine(_myCoroutine);
_isAddCoining = false;
hasCoin = 0;
_timeLeft = 0f;
roleAllDamageDic.Clear();
IsGamePaused = false;
_pausedRoleAnimationSnapshots.Clear();
GameDeadUnitInfoDic.Clear();
towerAllDamageDic.Clear();
hornIng = false;
hornTime = 5f;
cardOpenCount.Clear();
gameUseCoinNums = 0;
countDownTime = 0;
canCutDown = false;
''')
rows=members(src);changed=[]
for r in reversed(rows):
    replacement=B.get(r['rva'].lower())
    if replacement is None: continue
    if not r['stub']: raise RuntimeError('Refuse overwrite existing body '+r['rva'])
    src=src[:r['body_start']]+'\n'+textwrap.indent(replacement,'\t\t\t')+'\n\t\t'+src[r['body_end']:]
    changed.append(dict(rva=r['rva'],token=r['token'],signature=r['signature']))
src=src.replace('public override UniTask Init()', 'public override async UniTask Init()')
src=src.replace('public void GameEnd(bool isVictory, bool doTxtAni)', 'public async void GameEnd(bool isVictory, bool doTxtAni)')
src=src.replace('private void CountDownEnd()', 'private async void CountDownEnd()')
src=src.replace('private void BeginStartCountDown(object o)', 'private async void BeginStartCountDown(object o)')
initializers={
    'private readonly Dictionary<int, AnimationPauseSnapshot> _pausedRoleAnimationSnapshots;':'private readonly Dictionary<int, AnimationPauseSnapshot> _pausedRoleAnimationSnapshots = new Dictionary<int, AnimationPauseSnapshot>();',
    'public float hornTime;':'public float hornTime = 5f;',
    'private string _timeString;':'private string _timeString = "3:00";',
    'public readonly int[] PropBTestChargeTime;':'public readonly int[] PropBTestChargeTime = new int[] { 30, 90, 210 };',
    'private float _perfPanelScale;':'private float _perfPanelScale = 1f;',
}
for a,b in initializers.items():
    assert src.count(a)==1,a
    src=src.replace(a,b)
dest=W/'candidate'/REL;dest.parent.mkdir(parents=True,exist_ok=True);dest.write_bytes(src.replace('\n','\r\n').encode('utf-8'))
(W/'manager-recovery.json').write_text(json.dumps(dict(methods=list(reversed(changed)),field_initializers=initializers,constructor_rva='0x3DE99CC'),ensure_ascii=False,indent=2),encoding='utf-8')
print('Manager restored methods:',len(changed),'field initializers:',len(initializers))
