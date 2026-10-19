from pathlib import Path
import re, json, hashlib

ROOT = Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20')
WORK = ROOT / 'work/parallel-44-battle'
SOURCE = WORK / 'role-validation/source-before.cs'
DEST = WORK / 'candidate/Assets/Scripts/Assembly-CSharp/GameModule/RoleBehaviour.cs'
BODIES = {
0x3D876CC: '''var stateMachine = new _003CDead_003Ed__190
{
    _003C_003Et__builder = AsyncVoidMethodBuilder.Create(),
    _003C_003E4__this = this,
    deadType = deadType,
    _003C_003E1__state = -1
};
stateMachine._003C_003Et__builder.Start(ref stateMachine);''',
0x3D90878: '''RoleBehaviour role = _003C_003E4__this;
try
{
    UniTask.Awaiter awaiter;
    if (_003C_003E1__state != 0)
    {
        if (role.isDead)
        {
            _003C_003E1__state = -2;
            _003C_003Et__builder.SetResult();
            return;
        }
        role.waitToChangeAnimationing = false;
        role.SetPathfindingEnabled(false);
        role.isDead = true;
        if (role._currentHex != null)
            role._currentHex.RemoveRole(role._instanceID, !role.isEnemy, role);
        role.transform.DOKill();
        global::EventModule.EventManager.Instance.TriggerEvent("HasRoleDead", role.gameObject);
        SubGameBuffManager.Instance.OnFriendlyUnitDead(role.isEnemy, role.transform.position);
        role.RemoveHPUI();
        int coin = global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest ? 1 : 5;
        coin = unchecked(coin + DailyBlessManager.Instance.KillUnitCoinHandle(role.isEnemy));
        SubGameBuffManager.Instance.ModifyKillCoin(ref coin, role.isEnemy);
        if (role.isEnemy)
        {
            global::UIModuleO.UITextEffectManager.Instance.ShowTextEffect(
                string.Format("<color=#FFFF00>+{0}</color>", coin), role.transform.position,
                global::UIModuleO.TextEffImgType.Coin, 1f, global::UIModuleO.PositionType.WorldPosition);
            BattleGameManager.Instance.ChangeCoin(coin);
        }
        else if (!(global::GameConfigModule.GameConfigManager.GameGlobalConfig.enableReduceArena12EnemyDifficulty
            && global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest
            && (CoreGameManager.NowPlayEdArenaID == "1001" || CoreGameManager.NowPlayEdArenaID == "1002")))
        {
            AIBehaviourManager.Instance.ChangeCoin(coin);
        }
        role.StopListeningEvent();
        role.SetAnimation(GPUInstanceAnimationBehaviour.AnimationName.Dead, true);
        role.SetAiCanMove(false);
        if (role.isEnemy)
            BattleGameSceneManager.Instance.RemoveEnemyRole(role.gameObject, true);
        else
            BattleGameSceneManager.Instance.RemovePlayerRole(role.gameObject, true);
        float delay = role.gpuInstanceAnimationBehaviour.GetAnimationLength(GPUInstanceAnimationBehaviour.AnimationName.Dead) + -0.1f;
        delay = delay <= 0f ? 0.1f : delay;
        awaiter = UniTask.WaitForSeconds(delay, false, PlayerLoopTiming.Update, default, false).GetAwaiter();
        if (!awaiter.IsCompleted)
        {
            _003C_003E1__state = 0;
            _003C_003Eu__1 = awaiter;
            _003C_003Et__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
            return;
        }
    }
    else
    {
        awaiter = _003C_003Eu__1;
        _003C_003Eu__1 = default;
        _003C_003E1__state = -1;
    }
    awaiter.GetResult();
    RoleShadowManager.Instance.Unbind(role);
    role.DeadCallBack(deadType);
}
catch (global::System.Exception exception)
{
    _003C_003E1__state = -2;
    _003C_003Et__builder.SetException(exception);
    return;
}
_003C_003E1__state = -2;
_003C_003Et__builder.SetResult();''',
0x3D914E4: '''_003C_003Et__builder.SetStateMachine(stateMachine);''',
0x3D878E4: '''if (!Application.isPlaying)
    return;
if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest
    && PropertyTemp != null && PropertyTemp.rareLevel == RareLevel.SSSR)
    BattleGameSceneManager.Instance.RemoveLegendaryUnit(PropertyTemp.id, isEnemy);
if (SkillType != GameEventType.OnTime && !isClone)
    OnDeadSkill();
DeadUnitInfo deadUnit = new DeadUnitInfo(RoleInfo, isEnemy, CardLevel, PropertyTemp.rareLevel,
    RelativeCardID, CardFettersType, AtkWayType);
if (isEnemy)
    AIBehaviourManager.Instance.AddDeadUnit(_instanceID, deadUnit);
else
    BattleGameManager.Instance.AddDeadUnit(_instanceID, deadUnit);
if (!global::CheatControl.DisableDeathEffect)
    global::AssetsModule.EffectManager.Instance.ShowEffect(
        "Assets/_Res/Addressable/EffectsBundle/Effects/RoleDead.prefab", transform.position, default, 1f);
if (HWGPUInstancerManager.Instance != null
    && (HWGPUInstancerManager.Instance.IsDestroying || !HWGPUInstancerManager.Instance.IsCrowdManagerAlive))
{
    var prefabs = GetComponentsInChildren<global::GPUInstancer.CrowdAnimations.GPUICrowdPrefab>(true);
    for (int i = 0; i < prefabs.Length; i++)
        if (prefabs[i] != null && (int)prefabs[i].state != 0)
            prefabs[i].state = (global::GPUInstancer.PrefabInstancingState)0;
}
gameObject.SetActive(false);
global::AssetsModule.ObjPoolManager.Instance.Recycle(gameObject);
if (deadType == DeadType.HellFire)
    HellFireDeadCallBack();
OnRecycle();
hadInit = false;
SetAiCanMove(false);''',
0x3D8CE8C: '''if (global::SDKModule.ABTestManager.Instance.UnitCollisionEnableIsBTest)
    ApplyOccupancyPenalty(false);
SetPathfindingEnabled(false);
if (_currentHex != null)
{
    _currentHex.RemoveRole(_instanceID, !isEnemy, this);
    _currentHex = null;
}
RoleShadowManager.Instance.Unbind(this);
if (gpuInstanceAnimationBehaviour != null)
    gpuInstanceAnimationBehaviour.ResetState();
transform.DOKill();
transform.localScale = new Vector3(_bornScaleX, _bornScaleX, _bornScaleX);
findTargeting = false;
FrontAtkTime = 0f;
frontWoundTime = 0f;
skillCompleteTime = 0f;
SkillNumber = 0f;
SkillType = 0;
isClone = false;
_tempRangePercent = 0f;
_tempBuildingDamagePercent = 0f;
dontWound = false;
SetAiCanMove(false);
global::EventModule.EventManager.Instance.StopListening("HasHexOpen", UpdateArchitectureTarget);
isSummonKuLou = false;
isConvertSkeleton = false;
hadRecycle = true;
RemoveHPUI();
ClearDizzyState();
ClearFreezeState();
addSpeedIng = false;
Object.Destroy(addSpeedEff);
Object.Destroy(addAttackEff);
Object.Destroy(addMissEff);
Object.Destroy(charmEff);
charmEff = null;
isShocking = false;
linkRoleList.Clear();
shockTW.Kill();
linkNum = 0f;
TalentTreeData = null;
if (allTalent != null)
{
    for (int i = 0; i < allTalent.Count; i++)
        allTalent[i].Clear();
    allTalent.Clear();
}
allTalent = null;
if (allTalent2 != null)
{
    for (int i = 0; i < allTalent2.Count; i++)
        allTalent2[i].Clear();
    allTalent2.Clear();
}
StealthIng = false;
stealNum = 0f;
allTalent2 = null;
AttackObj = null;
if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest
    && gpuInstanceAnimationBehaviour != null && originalAttackAnimationSpeed > 0f)
{
    gpuInstanceAnimationBehaviour.ChangeAnimatorSpeed(GPUInstanceAnimationBehaviour.AnimationName.Attack, originalAttackAnimationSpeed);
    originalAttackAnimationSpeed = 0f;
}
if (_pathfindingTarget != null)
{
    Object.Destroy(_pathfindingTarget);
    _pathfindingTarget = null;
}''',
0x3D8CDD8: '''if (!hadRecycle)
    OnRecycle();
hadInit = false;
SetAiCanMove(false);
gameObject.SetActive(false);
global::AssetsModule.ObjPoolManager.Instance.Recycle(gameObject);''',
0x3D8BC2C: '''if (global::GameConfigModule.GameConfigManager.GameGlobalConfig.useNewFloatingText)
{
    FloatingTextManager.Instance.RemoveTextByTarget(transform);
    return;
}
if (hpBarUI != null)
    global::UIModuleO.UIHUDManager.Instance.RecycleHealthBatHUD(hpBarUI);
hpBarUI = null;''',
0x3D8776C: '''global::EventModule.EventManager.Instance.StartListening("HasHexOpen", UpdateArchitectureTarget);''',
0x3D87828: '''global::EventModule.EventManager.Instance.StopListening("HasHexOpen", UpdateArchitectureTarget);''',
0x3D7FA30: '''if (!Application.isPlaying)
    return;
if (followerEntity == null)
    followerEntity = GetComponent<FollowerEntity>();
if (DestinationSetter == null)
    DestinationSetter = GetComponent<AIDestinationSetter>();
if (AstarWebGLRuntimeConfig.UseWebGLNavigation)
{
    if (followerEntity != null)
        followerEntity.enabled = false;
    if (DestinationSetter != null)
    {
        DestinationSetter.target = null;
        DestinationSetter.enabled = false;
    }
    if (enabled)
        WebGLNavigationManager.TryRegisterRole(this);
    else
    {
        WebGLNavigationManager.TryUnregisterRole(this);
        followerEntityNeedSearchPath = false;
        followerEntityLastSearchPathTime = -999f;
        _followerEntityLastTargetSyncTime = -999f;
        followerEntityCurrentTarget = null;
        followerEntityCurrentSourceTarget = null;
    }
    return;
}
if (followerEntity != null)
    followerEntity.enabled = enabled;
if (!enabled)
{
    followerEntityNeedSearchPath = false;
    followerEntityLastSearchPathTime = -999f;
    _followerEntityLastTargetSyncTime = -999f;
    followerEntityCurrentSourceTarget = null;
}
if (DestinationSetter != null)
    DestinationSetter.enabled = enabled;''',
0x3D84B68: '''if (AstarWebGLRuntimeConfig.UseWebGLNavigation)
{
    _currentOccupancyGUO = null;
    _isPenaltyApplied = false;
    _occupancyBounds = default;
    return;
}
if (!enable)
{
    if (!_isPenaltyApplied)
        return;
    if (_occupancyBounds.size == Vector3.zero)
    {
        _currentOccupancyGUO = null;
        _isPenaltyApplied = false;
        return;
    }
    GraphUpdateObject removal = new GraphUpdateObject(_occupancyBounds);
    removal.addPenalty = -999999999;
    removal.updatePhysics = false;
    if (!AstarWebGLRuntimeConfig.DisableAstarRuntime && AstarPath.active != null)
        AstarPath.active.UpdateGraphs(removal);
    _currentOccupancyGUO = null;
    _isPenaltyApplied = false;
    _occupancyBounds = default;
    return;
}
if (_isPenaltyApplied)
    return;
float radius = followerEntity != null ? followerEntity.radius
    : followerEntityCurrentRadius > 0f ? followerEntityCurrentRadius : 0.5f;
float diameter = radius + radius;
_occupancyBounds = new Bounds(transform.position, new Vector3(diameter, diameter, diameter));
GraphUpdateObject addition = new GraphUpdateObject(_occupancyBounds);
addition.addPenalty = 999999999;
addition.updatePhysics = false;
if (!AstarWebGLRuntimeConfig.DisableAstarRuntime && AstarPath.active != null)
{
    AstarPath.active.UpdateGraphs(addition);
    _currentOccupancyGUO = addition;
    _isPenaltyApplied = true;
}''',
0x3D86A44: '''if (this == null || !CoreGameManager.Gaming || isDead || PropertyTemp == null)
    return;
if (damage == 0 || (PropertyTemp.id == "1012" && Skilling))
    return;
AttackObj = target;
var hurt = OnHurtTalentTrigger(damage);
int remaining = hurt.Item1;
float dodge = (hurt.Item2 + PropertyTemp.missObb) * 100f;
if (dodge > UnityEngine.Random.Range(0, 101))
{
    ShowDamageText("闪避", new Color(0f, 0f, 1f, 1f));
    return;
}
frontWoundTime = Time.time;
float reductionValue = PropertyTemp.damageReduceObb * (float)remaining;
int reduction = float.IsPositiveInfinity(reductionValue) ? int.MinValue
    : float.IsNaN(reductionValue) ? 0
    : reductionValue >= 2147483648f ? int.MaxValue
    : reductionValue <= -2147483648f ? int.MinValue : (int)reductionValue;
remaining = unchecked(remaining - reduction);
if (CardFettersType == CardFettersType.Terran)
    remaining = SynergyEffectManager.Instance.HumanFetter4_DamageReduction(remaining, this, isEnemy, 1f);
if (CardFettersType == CardFettersType.Machine)
    remaining = SynergyEffectManager.Instance.MachineFetter6_RemoteDamageReduction(remaining, this, isEnemy, atkWayType);
if (remaining <= 0)
    return;
if (linkRoleList != null)
{
    for (int i = 0; i < linkRoleList.Count; i++)
    {
        if (linkRoleList[i] == null)
            continue;
        float linkedValue = linkNum * (float)remaining;
        int linkedDamage = float.IsPositiveInfinity(linkedValue) ? int.MinValue
            : float.IsNaN(linkedValue) ? 0
            : linkedValue >= 2147483648f ? int.MaxValue
            : linkedValue <= -2147483648f ? int.MinValue : (int)linkedValue;
        linkRoleList[i].Wound(linkedDamage, id, isBuild, target, isLandRole, atkWayType, fetterType, null);
        remaining = unchecked(remaining - linkedDamage);
        if (remaining <= 0)
            return;
    }
}
_damageTextBuilder.Clear();
_damageTextBuilder.Append("-");
_damageTextBuilder.Append(remaining);
ShowDamageText(_damageTextBuilder.ToString(), FloatingTextManager.Instance.GetDamageTextColor(isEnemy, false));
PropertyTemp.hp = unchecked(PropertyTemp.hp - remaining);
global::AssetsModule.EffectManager.Instance.ShowEffect(
    "Assets/_Res/Addressable/EffectsBundle/Effects/BloodExplosionSpiky.prefab", transform.position, default, 1f);
if (isEnemy)
{
    if (isBuild)
        BattleGameManager.Instance.RecordBuildDamage(id, remaining);
    else
        BattleGameManager.Instance.RecordDamage(id, remaining);
}
OnHealthChangeTalentTrigger();
if (PropertyTemp.hp <= 0)
{
    PropertyTemp.hp = 0;
    Dead(linkAttackObj != null && GetIsHellFireAtk(linkAttackObj) ? DeadType.HellFire : DeadType.Common);
    UpdateHpBar();
    if (!isBuild && target is RoleBehaviour attacker && !attacker.isDead)
        attacker.OnKillTalentTrigger();
}
else
{
    UpdateHpBar();
    global::AudioManager.Instance.PlaySFX("Assets/_Res/Addressable/AudiosBundle/SFX/Hit1.mp3", transform, 1f, 0);
}''',
0x3D831F4: '''bool second = allTalent2 != null;
if (!second && allTalent == null)
    return (damage, 0f);
GameEventArgs args = new GameEventArgs(this, AttackObj, GetNearOneMTeamMate(), (float)damage, 0f, false, null);
for (int i = 0; i < (second ? allTalent2 : allTalent).Count; i++)
    (second ? allTalent2 : allTalent)[i].OnEventTrigger(GameEventType.OnHurt, args);
float value = args.ValueNumber;
int result = float.IsPositiveInfinity(value) ? int.MinValue
    : float.IsNaN(value) ? 0
    : value >= 2147483648f ? int.MaxValue
    : value <= -2147483648f ? int.MinValue : (int)value;
return (result, args.ValueNumber2);''',
0x3D82FE8: '''bool second = allTalent2 != null;
if (second || allTalent != null)
{
    GameEventArgs args = new GameEventArgs(this, AttackObj, GetNearOneMTeamMate(), 0f, 0f, true, null);
    for (int i = 0; i < (second ? allTalent2 : allTalent).Count; i++)
        (second ? allTalent2 : allTalent)[i].OnEventTrigger(GameEventType.OnHealthChange, args);
}
UpdateHpBar();''',
0x3D8363C: '''bool second = allTalent2 != null;
if (!second && allTalent == null)
    return;
GameEventArgs args = new GameEventArgs(this, null, null, 0f, 0f, false, null);
for (int i = 0; i < (second ? allTalent2 : allTalent).Count; i++)
    (second ? allTalent2 : allTalent)[i].OnEventTrigger(GameEventType.OnKill, args);''',
0x3D83190: '''return BattleGameSceneManager.Instance.GetNearRole(isEnemy, this, 1f, -1);''',
0x3D87450: '''if (AttackObj == null)
    return false;
DemonLordRoleBehaviour demonLord = AttackObj as DemonLordRoleBehaviour;
return demonLord != null && demonLord.EmitHellFireIng && (link as HellfireBehaviour) != null;''',
0x3D841C4: '''if (global::GameConfigModule.GameConfigManager.GameGlobalConfig.useNewFloatingText)
{
    FloatingTextManager.Instance.ShowDamageText(damage, transform, false, color, null, false, false, 1f, null, null);
    return;
}
global::UIModuleO.UITextEffectManager.Instance.ShowTextEffect(
    string.Concat("<color=#", global::ToolModule.ColorExtend.ColorToHex(color), ">", damage, "</color>"),
    transform.position, global::UIModuleO.TextEffImgType.Null, 1f, global::UIModuleO.PositionType.WorldPosition);''',
0x3D7F778: '''return PropertyTemp.roleType == "land";''',
0x3D7F7D0: '''return skillRequireCount > 0f;''',
0x3D7FD58: '''var aniInstancing = GetComponent<global::AnimationInstancing.AnimationInstancing>();
if (aniInstancing != null)
    return aniInstancing;
var gpuInstancer = GetComponent<GPUInstanceAnimationBehaviour>();
return gpuInstancer != null ? gpuInstancer : null;''',
0x3D7FE44: '''return GetComponent<global::AnimationInstancing.AnimationInstancing>() != null
    ? RoleAnimationDriverType.AniInstancing : RoleAnimationDriverType.GPUInstancer;''',
0x3D7FED8: '''return GetAnimationDriverType() == RoleAnimationDriverType.GPUInstancer;''',
0x3D7FEF0: '''if (gpuInstanceAnimationBehaviour == null)
    gpuInstanceAnimationBehaviour = ResolveAnimationBehaviour();
return gpuInstanceAnimationBehaviour;''',
0x3D81228: '''_lastTrackedRoleTarget = null;
_lastRoleTargetHexDistance = -1;''',
0x3D82340: '''if (AtkWayType == AtkWayType.Remote || skillRequireCount > 0f
    || (PropertyTemp != null && PropertyTemp.rareLevel == RareLevel.SSSR))
    return 0.15f;
return 0.25f;''',
0x3D81F00: '''if (_RoleBehaviour != null)
{
    if (IsRoleTargetValidInRange(_RoleBehaviour, range))
        return true;
    _RoleBehaviour = null;
    _nextFindTargetTime = 0f;
    ClearRoleTargetTracking();
}
float now = Time.time;
if (now < _nextFindTargetTime && Mathf.Abs(_lastFindTargetRange - range) <= 0.01f)
    return true;
_lastFindTargetRange = range;
_nextFindTargetTime = now + GetFindTargetInterval();
return false;''',
0x3D821A0: '''if (target == null || target == this || target.isDead)
    return false;
RoleBehaviour roleTarget = target as RoleBehaviour;
if (roleTarget == null || roleTarget.StealthIng)
    return false;
float allowedRange = PropertyTemp != null ? PropertyTemp.atkRange : range;
allowedRange = allowedRange >= range ? allowedRange : range;
Vector3 delta = roleTarget.transform.position - transform.position;
delta.y = 0f;
return delta.sqrMagnitude <= allowedRange * allowedRange && UpdateRoleTargetHexDistance(roleTarget);''',
0x3D8237C: '''if (roleTarget == null)
{
    ClearRoleTargetTracking();
    return false;
}
HexBehaviour sourceHex;
HexBehaviour targetHex;
if (!HexManager.TryGetHexAt(transform.position, out sourceHex) || sourceHex == null
    || !HexManager.TryGetHexAt(roleTarget.transform.position, out targetHex) || targetHex == null)
{
    _lastTrackedRoleTarget = roleTarget;
    _lastRoleTargetHexDistance = -1;
    return true;
}
int distance = HexManager.HexDistance(sourceHex.HexCoord, targetHex.HexCoord);
if (_lastTrackedRoleTarget != roleTarget || _lastRoleTargetHexDistance < 0)
{
    _lastTrackedRoleTarget = roleTarget;
    _lastRoleTargetHexDistance = distance;
    return true;
}
if (distance > unchecked(_lastRoleTargetHexDistance + 1))
    return false;
if (distance < _lastRoleTargetHexDistance)
    _lastRoleTargetHexDistance = distance;
return true;''',
0x3D82110: '''RoleBehaviour roleTarget = _RoleBehaviour as RoleBehaviour;
if (roleTarget != null)
    UpdateRoleTargetHexDistance(roleTarget);
else
    ClearRoleTargetTracking();''',
0x3D7E054: '''Vector3 delta = targetPosition - transform.position;
delta.y = 0f;
return delta.normalized;''',
0x3D83B54: '''if (hadRecycle || destroying || isDead || isFreeze || isDizzy)
    return true;
return BattleGameManager.Instance != null && BattleGameManager.Instance.IsGamePaused;''',
0x3D83B14: '''SetAiCanMove(!Skilling && !IsAiMovementBlockedByState());
SetAiEnableLocalAvoidance(true);''',
0x3D84098: '''if (Skilling || IsAiMovementBlockedByState())
{
    SetAiCanMove(false);
    return;
}
SetAiCanMove(true);
SetAnimation(GPUInstanceAnimationBehaviour.AnimationName.Run);''',
0x3D840E4: '''isFreeze = false;
freezeEndTime = 0f;
if (IceBall != null)
    IceBall.gameObject.SetActive(false);
isDizzy = false;
dizzyTime = 0f;
if (stunEffect != null)
{
    Object.Destroy(stunEffect);
    stunEffect = null;
}
isShocking = false;
if (shockTW != null)
    shockTW.Kill();''',
0x3D81238: '''isDizzy = false;
dizzyTime = 0f;
if (stunEffect != null)
{
    Object.Destroy(stunEffect);
    stunEffect = null;
}''',
0x3D8D3F8: '''isFreeze = false;
freezeEndTime = 0f;
if (IceBall != null)
    IceBall.SetActive(false);''',
0x3D84470: '''return hadInit && !hadRecycle && !destroying && !isDead && gameObject.activeInHierarchy;''',
0x3D844BC: '''return followerEntityCurrentCanMove && !attacking && !Skilling && !isFreeze && !isDizzy
    && !_isAttackingWall && !_isBreakingWall && !isDead && !hadRecycle;''',
0x3D84514: '''return attacking && hadInit && !hadRecycle && !destroying && !isDead && gameObject.activeInHierarchy
    && !Skilling && !isFreeze && !isDizzy && !_isAttackingWall && !_isBreakingWall;''',
0x3D845A0: '''return _targetTrans != null ? _targetTrans : followerEntityCurrentSourceTarget;''',
0x3D84618: '''return TargetType;''',
0x3D84620: '''if (!(followerEntityCurrentSpeed > 0.01f))
    return PropertyTemp != null ? GetWebGLNavigationMoveSpeed(PropertyTemp.moveSpeed) : 0f;
return followerEntityCurrentSpeed;''',
0x3D84668: '''return followerEntityCurrentRadius > 0.01f ? followerEntityCurrentRadius : 0.35f;''',
0x3D84688: '''return PropertyTemp != null ? PropertyTemp.atkRange : 0f;''',
0x3D84A94: '''return followerEntityCurrentCanMove;''',
0x3D7AB7C: '''if (followerEntityCurrentCanMove == can)
    return;
followerEntityCurrentCanMove = can;
if (AstarWebGLRuntimeConfig.UseWebGLNavigation)
{
    if (can)
        WebGLNavigationManager.TryRegisterRole(this);
}
else if (followerEntity != null)
    followerEntity.canMove = can;''',
0x3D816B4: '''if (AstarWebGLRuntimeConfig.UseWebGLNavigation && PropertyTemp != null)
    return PropertyTemp.moveSpeed;
return followerEntityCurrentSpeed;''',
0x3D84A9C: '''if (!(_bornScaleX <= 0.001f))
    speed /= _bornScaleX;
return speed * 0.8f;''',
0x3D84658: '''return speed * 0.8f;''',
0x3D84AC4: '''return followerEntityCurrentRadius;''',
0x3D84B60: '''return followerEntityCurrentEnableLocalAvoidance;''',
0x3D7F9E0: '''if (!(baseRadius < 0f))
    return (0.5f / transform.localScale.x) * baseRadius;
return baseRadius;''',
0x3D84ACC: '''if (AstarWebGLRuntimeConfig.UseWebGLNavigation)
{
    float radius = GetScaledRadius(s);
    if (Mathf.Abs(followerEntityCurrentRadius - radius) > 0.01f)
        followerEntityCurrentRadius = radius;
}''',
0x3D7EDA8: '''if (this == null)
    return;
if (AstarWebGLRuntimeConfig.UseWebGLNavigation)
{
    float speed = s * 0.8f;
    if (Mathf.Abs(speed - followerEntityCurrentSpeed) > 0.01f)
        followerEntityCurrentSpeed = speed;
    return;
}
float nextSpeed = GetFollowerEntityMoveSpeed(s);
if (followerEntity == null)
    followerEntity = GetComponent<FollowerEntity>();
if (followerEntity != null && Mathf.Abs(nextSpeed - followerEntityCurrentSpeed) > 0.01f)
{
    followerEntityCurrentSpeed = nextSpeed;
    followerEntity.maxSpeed = nextSpeed;
}''',
0x3D812CC: '''if (!AstarWebGLRuntimeConfig.UseWebGLNavigation)
    return 1f;
return roleCount > 79 ? 3f : 2f;''',
0x3D848E4: '''followerEntityNeedSearchPath = true;''',
0x3D848F0: '''if (!AstarWebGLRuntimeConfig.UseWebGLNavigation || sourceTargetChanged)
    return true;
float distanceSqr = (targetPosition - currentPosition).sqrMagnitude;
if (distanceSqr <= 0.0001f)
    return false;
return distanceSqr >= 0.16f || Time.time - _followerEntityLastTargetSyncTime >= 0.15f;''',
0x3D849C4: '''if (!followerEntityNeedSearchPath)
    return;
if (AstarWebGLRuntimeConfig.UseWebGLNavigation)
{
    followerEntityNeedSearchPath = false;
    followerEntityLastSearchPathTime = Time.time;
    return;
}
if (followerEntity != null && followerEntity.enabled)
{
    followerEntityNeedSearchPath = false;
    followerEntityLastSearchPathTime = Time.time;
    followerEntity.SearchPath();
}''',
0x3D82018: '''if (outPathPoints == null)
    return false;
outPathPoints.Clear();
if (AstarWebGLRuntimeConfig.UseWebGLNavigation)
    return WebGLNavigationManager.TryGetRemainingPath(this, outPathPoints, 32) && outPathPoints.Count > 0;
if (followerEntity == null)
    return false;
bool stale = false;
followerEntity.GetRemainingPath(outPathPoints, out stale);
return outPathPoints.Count > 0;''',
0x3D8D738: '''if (newHex == null || newHex == _currentHex)
    return;
if (_currentHex != null)
    _currentHex.RemoveRole(_instanceID, !isEnemy, this);
newHex.AddRole(_instanceID, !isEnemy, this);
_currentHex = newHex;''',
0x3D8D5A8: '''HexBehaviour newHex;
HexManager.TryGetHexAt(transform.position, out newHex);
if (_currentHex != null && _currentHex != newHex)
    _currentHex.RemoveRole(_instanceID, !previousIsEnemy, this);
if (newHex != null)
    newHex.RefreshRoleCamp(_instanceID, !isEnemy, this);
_currentHex = newHex;''',
0x3D7F628: '''if (this == null)
    return;
if (gpuInstanceAnimationBehaviour == null)
    gpuInstanceAnimationBehaviour = ResolveAnimationBehaviour();
if (gpuInstanceAnimationBehaviour == null)
    return;
if ((nextAnimationName != GPUInstanceAnimationBehaviour.AnimationName.Dead && isDead)
    || (!force && waitToChangeAnimationing))
    return;
waitToChangeAnimationing = false;
lastChangeTime = Time.time;
gpuInstanceAnimationBehaviour.SetAnimation(nextAnimationName);''',
0x3D8E1E4: '''_bornFollowerRadius = -1f;
_lastFindTargetRange = -1f;
_lastRoleTargetHexDistance = -1;
firstSkill = true;
attackDamageDelay = new List<float>();
linkRoleList = new List<RoleBehaviour>();
followerEntityCurrentSpeed = -1f;
followerEntityCurrentRadius = -1f;
followerEntityLastSearchPathTime = -999f;
_followerEntityLastTargetSyncTime = -999f;
targetList = new List<RoleBehaviour>();
allPos = new List<Vector3>();
allPosLength = new List<float>();
_targetRemainingPathPoints = new List<Vector3>(32);
_damageTextBuilder = new StringBuilder(16);
_attackWallStateEnterTime = -1f;
_lastWatchdogMoveTime = -1f;''',
}

def extract(s):
    pattern = re.compile(r'\[Token\(Token = "(0x600[0-9A-Fa-f]+)"\)\]\s*\[Address\(RVA = "(0x[0-9A-Fa-f]+)"[^\n]*\)\]\s*(?:(?:\[[^\n]+\]\s*)*)([^\n]+)\s*\{')
    out = {}
    for m in pattern.finditer(s):
        a = m.end() - 1
        depth = 1; b = a + 1
        while depth:
            depth += (s[b] == '{') - (s[b] == '}'); b += 1
        out[int(m[2],16)] = {'token':m[1], 'declaration':m[3].strip(), 'a':a+1,'b':b-1,'body':s[a+1:b-1]}
    return out

def main():
    source = SOURCE.read_bytes().decode('utf-8-sig')
    members = extract(source)
    provenance=[]
    for rva, body in sorted(BODIES.items(), key=lambda x: members[x[0]]['a'], reverse=True):
        m=members[rva]
        if m['body'].strip() not in ('','return default;','return null;'):
            raise RuntimeError('Refuse overwrite existing body '+hex(rva))
        # Each replacement requires exact native evidence, including assembler.
        for suffix in ['.c','.asm.txt']:
            assert (WORK/'ida/pseudocode'/(hex(rva)+suffix)).exists(),hex(rva)
        indent='\t\t\t\t' if m['declaration']=='get' else '\t\t\t'
        closing='\t\t\t' if m['declaration']=='get' else '\t\t'
        formatted='\r\n'+'\r\n'.join(indent+line if line else '' for line in body.splitlines())+'\r\n'+closing
        source=source[:m['a']]+formatted+source[m['b']:]
        provenance.append({'rva':hex(rva),'token':m['token'],'declaration':m['declaration'],'body':body,'evidence':[str(WORK/'ida/pseudocode'/(hex(rva)+s)) for s in ['.c','.asm.txt','.annotated.txt']]})
    DEST.parent.mkdir(parents=True,exist_ok=True)
    DEST.write_bytes(source.encode('utf-8'))
    (WORK/'role-validation/restored-methods.json').write_text(json.dumps(sorted(provenance,key=lambda x:int(x['rva'],16)),ensure_ascii=False,indent=2),encoding='utf-8')
    print(json.dumps({'candidate':str(DEST),'restored_methods':len(BODIES),'sha256':hashlib.sha256(DEST.read_bytes()).hexdigest()},ensure_ascii=False))

if __name__=='__main__': main()
