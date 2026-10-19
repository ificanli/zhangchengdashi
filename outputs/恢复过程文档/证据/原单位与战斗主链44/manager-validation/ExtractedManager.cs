using System; using System.Collections; using System.Collections.Generic; using System.Threading.Tasks;
public partial class State {
public float ElapseTime { get {
			return (float)countDownTime - _timeLeft;
		} }
public bool IsGamePaused { get {
			return _isGamePaused || QuickTutor.TutorialManager.Instance.tutorialing;
		} set { _isGamePaused=value; } }
public void ChangeCoin(int coinNum)
{
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
		
}
public void RecordCardCount(string id)
{
			if (cardOpenCount.ContainsKey(id)) cardOpenCount[id] = unchecked(cardOpenCount[id] + 1);
			else cardOpenCount.Add(id, 1);
		
}
public void RecordCoinCount(int num)
{
			gameUseCoinNums = unchecked(gameUseCoinNums + num);
		
}
public void PlayerHornEmitIng(object o)
{
			hornIng = true;
		
}
public void PlayerHornEmitEnd(object o)
{
			hornIng = false;
		
}
public void GameEndCheck(object o)
{
			int playerCount = BattleGameSceneManager.Instance.allPlayerArchitectureObj.Count;
			if (playerCount == 0 || BattleGameSceneManager.Instance.allEnemyArchitectureObj.Count == 0)
			    GameEnd(playerCount != 0, false);
		
}
public void CloseMatchPanel(object o)
{
			canCutDown = true;
		
}
public void PlayerOpenHexCountAdd(object o)
{
			openHexCount = unchecked(openHexCount + 1);
		
}
public void Update()
{
			if (isCountDowning && hornIng && hornTime > 0f) hornTime -= Time.deltaTime;
		
}
public IEnumerator Countdown()
{
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
		
}
public string GetTimeCutDownString()
{
			int minutes = Mathf.FloorToInt(_timeLeft / 60f);
			int seconds = Mathf.FloorToInt(_timeLeft % 60f);
			string format = seconds == 0 ? "{0}:{1}0" : seconds <= 9 ? "{0}:0{1}" : "{0}:{1}";
			return string.Format(string.Format(format, minutes, seconds), Array.Empty<object>());
		
}
public void RecordDamage(string id, int damage)
{
			if (roleAllDamageDic.ContainsKey(id)) roleAllDamageDic[id] = unchecked(roleAllDamageDic[id] + damage);
			else roleAllDamageDic.Add(id, damage);
		
}
public void RecordBuildDamage(string id, int damage)
{
			if (towerAllDamageDic.ContainsKey(id)) towerAllDamageDic[id] = unchecked(towerAllDamageDic[id] + damage);
			else towerAllDamageDic.Add(id, damage);
		
}
public void AddDeadUnit(int id, DeadUnitInfo unitInfo)
{
			if (!GameDeadUnitInfoDic.ContainsKey(id)) GameDeadUnitInfoDic.Add(id, unitInfo);
		
}
public void RemoveDeadUnit(int id)
{
			if (GameDeadUnitInfoDic.ContainsKey(id)) GameDeadUnitInfoDic.Remove(id);
		
}
public void CountDownEnd()
{
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
		
}
public async System.Threading.Tasks.Task BeginStartCountDown(object o)
{
			if (isCountDowning) return;
			await UniTask.WaitUntil(() => canCutDown);
			if (this == null || isCountDowning) return;
			isCountDowning = true;
			if (_myCoroutine != null) StopCoroutine(_myCoroutine);
			_myCoroutine = StartCoroutine(Countdown());
		
}
public void EndGame()
{
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
		
}
public void BetRecordRewardNum(object o)
{
			betRewardNum = o.ToString();
		
}
public void GuidOneEndAddCoin(object o)
{
			ChangeCoin(200);
		
}
public void SetGamePaused(bool paused)
{
			if (_isGamePaused == paused) return;
			IsGamePaused = paused;
			ApplyAnimationPauseToAllRoles(paused);
		
}
public void OnPauseGame(object o)
{
			SetGamePaused(true);
		
}
public void OnResumeGame(object o)
{
			SetGamePaused(false);
		
}
public void ApplyAnimationPauseToAllRoles(bool paused)
{
			if (BattleGameSceneManager.Instance == null) return;
			ApplyAnimationPauseToRoleList(BattleGameSceneManager.Instance.allPlayerRoleObj, paused);
			ApplyAnimationPauseToRoleList(BattleGameSceneManager.Instance.allEnemyRoleObj, paused);
			if (!paused) _pausedRoleAnimationSnapshots.Clear();
		
}
public void ApplyAnimationPauseToRoleList(List<GameObject> roles, bool paused)
{
			if (roles == null || roles.Count == 0) return;
			for (int i = roles.Count - 1; i >= 0; --i)
			    if (roles[i] != null) ApplyAnimationPauseToSingleRole(roles[i], paused);
		
}
public void ApplyAnimationPauseToSingleRole(GameObject roleObj, bool paused)
{
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
		
}
public void TryApplyPauseToNewRole(GameObject roleObj)
{
			if (IsGamePaused && roleObj != null) ApplyAnimationPauseToSingleRole(roleObj, true);
		
}
}