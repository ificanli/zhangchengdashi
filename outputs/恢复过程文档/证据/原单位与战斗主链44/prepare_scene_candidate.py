"""Recover only native-evidenced scene manager bodies into the owned candidate."""
import hashlib, json, re, struct, sys
from pathlib import Path
ROOT=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20')
WORK=ROOT/'work/parallel-44-battle'
sys.path.insert(0,str(WORK))
from bootstrap import members
REL='Assets/Scripts/Assembly-CSharp/GameModule/BattleGameSceneManager.cs'
source=(WORK/'source-before'/REL).read_text(encoding='utf-8-sig')
bodies={}
def body(rva,code): bodies[int(rva,16)]=code.strip()

body('3ded8ec','return MAX_ROLE_COUNT;')
body('3dea55c','return unchecked(allPlayerStayOpenHexObj.Count + allPlayerHasOpenHexObj.Count);')
body('3dea5b4','return unchecked(allEnemyStayOpenHexObj.Count + allEnemyHasOpenHexObj.Count);')
body('3ded8f4','''
if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return true;
return isEnemy ? unchecked(_enemyRoleCount + _enemyReservedCount) < MAX_ROLE_COUNT
               : unchecked(_playerRoleCount + _playerReservedCount) < MAX_ROLE_COUNT;
''')
body('3ded9ac','''
if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return int.MaxValue;
int used = isEnemy ? unchecked(_enemyRoleCount + _enemyReservedCount)
                   : unchecked(_playerRoleCount + _playerReservedCount);
return Mathf.Max(0, unchecked(MAX_ROLE_COUNT - used));
''')
body('3deda74','ReserveRoleSlot(isEnemy, 1);')
body('3deda80','''
if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
if (isEnemy) _enemyReservedCount = unchecked(_enemyReservedCount + count);
else _playerReservedCount = unchecked(_playerReservedCount + count);
''')
body('3dedb30','ReleaseReservedSlot(isEnemy, 1);')
body('3dedb3c','''
if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
if (isEnemy) _enemyReservedCount = Mathf.Max(0, unchecked(_enemyReservedCount - count));
else _playerReservedCount = Mathf.Max(0, unchecked(_playerReservedCount - count));
''')
body('3df9650','''
this.sourceIsEnemy = sourceIsEnemy;
this.q = q;
this.r = r;
this.rangeBucket = rangeBucket;
''')
body('3df9664','return sourceIsEnemy == other.sourceIsEnemy && q == other.q && r == other.r && rangeBucket == other.rangeBucket;')
body('3df96ac','return obj is RoleTargetFrameCacheKey && Equals((RoleTargetFrameCacheKey)obj);')
body('3df9758','return unchecked((397 * ((397 * ((sourceIsEnemy ? 157609 : 0) ^ q)) ^ r)) ^ rangeBucket);')
body('3df0e0c','return sourceIsEnemy ? allPlayerRoleBehaviour : allEnemyRoleBehaviour;')
body('3df28dc','return role != null && !role.isDead && !role.StealthIng;')
body('3df13f8','''
nearestRole = null;
float nearestDistance = float.MaxValue;
for (int i = 0; i < targetList.Count; i++)
{
    RoleBehaviour role = targetList[i];
    if (!IsRoleTargetValid(role)) continue;
    float distance = (sourcePos - role.transform.position).sqrMagnitude;
    if (!(distance > sqrRange) && !(distance >= nearestDistance))
    {
        nearestDistance = distance;
        nearestRole = role;
    }
}
return nearestRole != null;
''')
body('3df1a0c','''
for (int i = 0; i < targetList.Count; i++)
{
    RoleBehaviour role = targetList[i];
    if (IsRoleTargetValid(role) && (sourcePos - role.transform.position).sqrMagnitude <= sqrRange)
        result.Add(role);
}
return result.Count;
''')
body('3df0a50','''
int count = Mathf.Min(roleNum, result.Count);
for (int i = 0; i < count; i++)
{
    int nearest = i;
    float distance = (sourcePos - result[i].transform.position).sqrMagnitude;
    for (int j = i + 1; j < result.Count; j++)
    {
        float candidateDistance = (sourcePos - result[j].transform.position).sqrMagnitude;
        if (candidateDistance < distance)
        {
            nearest = j;
            distance = candidateDistance;
        }
    }
    if (nearest != i)
    {
        RoleBehaviour first = result[nearest];
        RoleBehaviour second = result[i];
        result[i] = first;
        result[nearest] = second;
    }
}
if (result.Count > count) result.RemoveRange(count, result.Count - count);
''')
body('3df2964','''
if (_generateHexBehaviour == null && _generateHexObjRoot != null)
    _generateHexBehaviour = _generateHexObjRoot.GetComponent<GenerateHexBehaviour>();
return _generateHexBehaviour != null ? _generateHexBehaviour.hexSize : 1f;
''')
# 0x1837244 is the exact float32 constant used by FMUL at 0x3DF2878.
raw=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes()
phoff=struct.unpack_from('<Q',raw,32)[0]; phsize,phnum=struct.unpack_from('<HH',raw,54)
segs=[struct.unpack_from('<IIQQQQQQ',raw,phoff+i*phsize) for i in range(phnum)]
def read_rva(a,n):
    s=next(s for s in segs if s[0]==1 and s[3]<=a and a+n<=s[3]+s[5])
    return raw[s[2]+a-s[3]:s[2]+a-s[3]+n]
hex_step=struct.unpack('<f',read_rva(0x1837244,4))[0]
assert struct.unpack('<I',struct.pack('<f',hex_step))[0]==0x3FDDB3D7
body('3df2828',f'''
searchRing = unchecked(Mathf.CeilToInt(range / Mathf.Max(GetSpawnHexSize() * {hex_step:.9g}f, 0.5f)) + 2);
return searchRing <= RoleTargetMaxHexSearchRing;
''')
body('3df2680','''
key = default;
int searchRing;
if (!TryGetRoleTargetHexSearchRing(range, out searchRing)) return false;
HexBehaviour hex;
if (!HexManager.TryGetHexAt(sourcePos, out hex) || hex == null) return false;
key = new RoleTargetFrameCacheKey(sourceIsEnemy, hex.HexCoord.q, hex.HexCoord.r,
                                 Mathf.CeilToInt(range * RoleTargetRangeCachePrecision));
return true;
''')
body('3df2608','''
int frame = Time.frameCount;
if (_roleTargetFrameCacheFrame == frame) return;
_roleTargetFrameCacheFrame = frame;
_roleTargetFrameCache.Clear();
''')
body('3df0e24','''
target = null;
PrepareRoleTargetFrameCache();
RoleTargetFrameCacheKey key;
if (!TryGetRoleTargetFrameCacheKey(sourcePos, sourceIsEnemy, range, out key)) return false;
RoleTargetFrameCacheValue cached;
if (!_roleTargetFrameCache.TryGetValue(key, out cached)) return false;
RoleBehaviour role = cached.target;
if (!IsRoleTargetValid(role))
{
    _roleTargetFrameCache.Remove(key);
    return false;
}
if (!((sourcePos - role.transform.position).sqrMagnitude > sqrRange))
{
    target = role;
    return true;
}
return false;
''')
body('3df12fc','''
if (target == null) return;
PrepareRoleTargetFrameCache();
RoleTargetFrameCacheKey key;
if (!TryGetRoleTargetFrameCacheKey(sourcePos, sourceIsEnemy, range, out key)) return;
_roleTargetFrameCache[key] = new RoleTargetFrameCacheValue { target = target };
''')
body('3df0fbc','''
nearestRole = null;
searchedHexRing = false;
int searchRing;
if (!TryGetRoleTargetHexSearchRing(range, out searchRing)) return false;
HexBehaviour sourceHex;
if (!HexManager.TryGetHexAt(sourcePos, out sourceHex) || sourceHex == null) return false;
searchedHexRing = true;
float nearestDistance = float.MaxValue;
int q = sourceHex.HexCoord.q;
int r = sourceHex.HexCoord.r;
for (int dq = -searchRing; dq <= searchRing; dq++)
{
    int rMin = Mathf.Max(-searchRing, -dq - searchRing);
    int rMax = Mathf.Min(searchRing, searchRing - dq);
    for (int dr = rMin; dr <= rMax; dr++)
    {
        HexBehaviour hex = HexManager.GetHexBehaviour(new HexManager.HexCoord(unchecked(q + dq), unchecked(r + dr)));
        if (hex == null) continue;
        int count = hex.GetRoleCountByCamp(targetIsEnemy);
        for (int i = 0; i < count; i++)
        {
            RoleBehaviour role = hex.GetRoleByCamp(targetIsEnemy, i);
            if (!IsRoleTargetValid(role)) continue;
            float distance = (sourcePos - role.transform.position).sqrMagnitude;
            if (!(distance > sqrRange) && !(distance >= nearestDistance))
            {
                nearestDistance = distance;
                nearestRole = role;
            }
        }
    }
}
return nearestRole != null;
''')
body('3df1684','''
searchedHexRing = false;
int searchRing;
if (!TryGetRoleTargetHexSearchRing(range, out searchRing)) return false;
HexBehaviour sourceHex;
if (!HexManager.TryGetHexAt(sourcePos, out sourceHex) || sourceHex == null) return false;
searchedHexRing = true;
int q = sourceHex.HexCoord.q;
int r = sourceHex.HexCoord.r;
for (int dq = -searchRing; dq <= searchRing; dq++)
{
    int rMin = Mathf.Max(-searchRing, -dq - searchRing);
    int rMax = Mathf.Min(searchRing, searchRing - dq);
    for (int dr = rMin; dr <= rMax; dr++)
    {
        HexBehaviour hex = HexManager.GetHexBehaviour(new HexManager.HexCoord(unchecked(q + dq), unchecked(r + dr)));
        if (hex == null) continue;
        int count = hex.GetRoleCountByCamp(targetIsEnemy);
        for (int i = 0; i < count; i++)
        {
            RoleBehaviour role = hex.GetRoleByCamp(targetIsEnemy, i);
            if (IsRoleTargetValid(role) && (sourcePos - role.transform.position).sqrMagnitude <= sqrRange)
                result.Add(role);
        }
    }
}
return result.Count > 0;
''')
body('3df06bc','''
target = null;
List<RoleBehaviour> targetList = GetRoleTargetList(sourceIsEnemy);
if (targetList == null || range < 0f || targetList.Count == 0) return false;
float sqrRange = range * range;
if (!TryGetCachedNearestRoleTarget(sourcePos, sourceIsEnemy, range, sqrRange, out target))
{
    bool searchedHexRing;
    if (!TryGetNearestRoleTargetFromHexRing(sourcePos, !sourceIsEnemy, range, sqrRange, out target, out searchedHexRing))
    {
        if (searchedHexRing) return false;
        if (!TryGetNearestRoleTargetFromList(sourcePos, targetList, sqrRange, out target)) return false;
    }
    CacheNearestRoleTarget(sourcePos, sourceIsEnemy, range, target);
}
return true;
''')
body('3df08a8','''
if (result == null) return 0;
result.Clear();
List<RoleBehaviour> targetList = GetRoleTargetList(sourceIsEnemy);
if (targetList == null || range < 0f || targetList.Count == 0) return 0;
float sqrRange = range * range;
bool searchedHexRing;
if (TryCollectRoleTargetsInRangeFromHexRing(sourcePos, !sourceIsEnemy, range, sqrRange, result, out searchedHexRing) || searchedHexRing)
    return result.Count;
return CollectRoleTargetsInRangeFromList(sourcePos, targetList, sqrRange, result);
''')
body('3df0d3c','''
if (sourceTransform == null) { target = null; return false; }
return TryGetNearestRoleTarget(sourceTransform.position, sourceIsEnemy, range, out target);
''')
body('3df1584','''
if (sourceTransform == null) { if (result != null) result.Clear(); return 0; }
return CollectRoleTargetsInRange(sourceTransform.position, sourceIsEnemy, range, result);
''')
body('3df0c7c','''
RoleBehaviour target;
return transform != null && TryGetNearestRoleTarget(transform.position, isEnemy, range, out target) ? target : null;
''')
body('3df0470','''
List<RoleBehaviour> result = new List<RoleBehaviour>();
if (transform == null) return result;
Vector3 pos = transform.position;
if (roleNum <= 1)
{
    RoleBehaviour target;
    if (TryGetNearestRoleTarget(pos, isEnemy, range, out target)) result.Add(target);
}
else
{
    CollectRoleTargetsInRange(pos, isEnemy, range, result);
    SortNearestRoleTargetsInPlace(pos, result, roleNum);
}
return result;
''')
for name,offset in [('Player',False),('Enemy',True)]:
    e='true' if offset else 'false'; pre='_enemy' if offset else '_player'
    add='3df69a0' if offset else '3df64b8'; remove='3df7b40' if offset else '3df6e88'
    body(add,f'''
if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && shouldCountInLimit && {pre}RoleCount >= MAX_ROLE_COUNT)
{{
    UnityEngine.Debug.LogWarning(string.Format("尝试创建超过上限的单位！当前计数: {{0}}, 上限: {{1}}", {pre}RoleCount, MAX_ROLE_COUNT));
    return;
}}
all{name}RoleObj.Add(obj);
RoleBehaviour role = obj.GetComponent<RoleBehaviour>();
all{name}RoleBehaviour.Add(role);
allRoleBehaviour.Add(role);
WebGLNavigationManager.TryRegisterRole(role);
if (isFake) return;
_currentRoleInstanceID = unchecked(_currentRoleInstanceID + 1);
role._instanceID = _currentRoleInstanceID;
if (RoleShadowManager.Instance != null) RoleShadowManager.Instance.Bind(role);
if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && shouldCountInLimit)
{{
    if ({pre}ReservedCount > 0) {pre}ReservedCount = unchecked({pre}ReservedCount - 1);
    {pre}RoleCount = Mathf.Min(unchecked({pre}RoleCount + 1), MAX_ROLE_COUNT);
    global::EventModule.EventManager.Instance.TriggerEvent("{name}RoleCountChange", {pre}RoleCount);
    role._isCountedInRoleLimit = true;
}}
global::EventModule.EventManager.Instance.TriggerEvent("Has{name}RoleCreat", role);
obj.transform.SetParent({pre}RoleRoot.transform, false);
if (BattleGameManager.Instance != null) BattleGameManager.Instance.TryApplyPauseToNewRole(obj);
''')
    body(remove,f'''
if (!all{name}RoleObj.Contains(obj)) return;
RoleBehaviour role = obj.GetComponent<RoleBehaviour>();
all{name}RoleObj.Remove(obj);
all{name}RoleBehaviour.Remove(role);
allRoleBehaviour.Remove(role);
WebGLNavigationManager.TryUnregisterRole(role);
if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && role != null && role._isCountedInRoleLimit && triggerTrySpawn)
{{
    {pre}RoleCount = Mathf.Max(0, unchecked({pre}RoleCount - 1));
    global::EventModule.EventManager.Instance.TriggerEvent("{name}RoleCountChange", {pre}RoleCount);
    TrySpawnFromWaitingBarracks({e});
}}
''')
body('3df7d78','''
if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
List<BarracksArchitectureBehaviour> waiting = isEnemy ? _enemyWaitingBarracks : _playerWaitingBarracks;
if (!waiting.Contains(barracks)) waiting.Add(barracks);
''')
body('3df7eb8','''
if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
(isEnemy ? _enemyWaitingBarracks : _playerWaitingBarracks).Remove(barracks);
''')
for addr,dictionary,operation in [('3df83d8','LegendaryBarracksCount','add'),('3df8508','LegendaryBarracksCount','remove'),('3df866c','LegendaryUnitCount','add'),('3df879c','LegendaryUnitCount','remove'),('3df8910','LegendaryUnitCount','get'),('3df8a14','LegendaryBarracksCount','get')]:
    start='if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return'+(' 0;' if operation=='get' else ';')
    b=start+f'\nDictionary<string, int> counts = isEnemy ? _enemy{dictionary} : _player{dictionary};\n'
    if operation=='add': b+='counts[roleID] = counts.ContainsKey(roleID) ? unchecked(counts[roleID] + 1) : 1;'
    elif operation=='get': b+='return counts.ContainsKey(roleID) ? counts[roleID] : 0;'
    else:
        b+='''if (!counts.ContainsKey(roleID)) return;
counts[roleID] = Mathf.Max(0, unchecked(counts[roleID] - 1));
if (counts[roleID] == 0) counts.Remove(roleID);'''
        if dictionary=='LegendaryUnitCount': b+='\nTrySpawnLegendaryFromWaitingBarracks(roleID, isEnemy);'
    body(addr,b)
body('3df7f8c','''
if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return true;
return GetLegendaryUnitCount(roleID, isEnemy) < GetLegendaryBarracksCount(roleID, isEnemy);
''')
body('3df70c0','''
if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
List<BarracksArchitectureBehaviour> waiting = isEnemy ? _enemyWaitingBarracks : _playerWaitingBarracks;
if (waiting.Count == 0 || !CanSpawnRole(isEnemy)) return;
for (int i = waiting.Count - 1; i >= 0; i--)
    if (waiting[i] == null || waiting[i].isDead) waiting.RemoveAt(i);
if (waiting.Count == 0) return;
List<BarracksArchitectureBehaviour> legendary = new List<BarracksArchitectureBehaviour>();
List<BarracksArchitectureBehaviour> ordinary = new List<BarracksArchitectureBehaviour>();
foreach (BarracksArchitectureBehaviour barracks in waiting)
    if (barracks.IsLegendaryBarracks()) legendary.Add(barracks); else ordinary.Add(barracks);
if (legendary.Count > 0)
{
    Dictionary<string, List<BarracksArchitectureBehaviour>> groups = new Dictionary<string, List<BarracksArchitectureBehaviour>>();
    foreach (BarracksArchitectureBehaviour barracks in legendary)
    {
        string id = barracks.GetCreatRoleID();
        if (string.IsNullOrEmpty(id)) continue;
        if (!groups.ContainsKey(id)) groups[id] = new List<BarracksArchitectureBehaviour>();
        groups[id].Add(barracks);
    }
    foreach (KeyValuePair<string, List<BarracksArchitectureBehaviour>> group in groups)
    {
        if (!CanSpawnLegendaryUnit(group.Key, isEnemy)) continue;
        BarracksArchitectureBehaviour best = null;
        int bestRareLevel = -1;
        foreach (BarracksArchitectureBehaviour barracks in group.Value)
        {
            int rareLevel = barracks.GetRareLevelValue();
            if (rareLevel > bestRareLevel) { bestRareLevel = rareLevel; best = barracks; }
        }
        if (best != null)
        {
            waiting.Remove(best);
            best.OnCanSpawnRole();
            return;
        }
    }
}
if (ordinary.Count > 0)
{
    BarracksArchitectureBehaviour best = null;
    int bestRareLevel = -1;
    foreach (BarracksArchitectureBehaviour barracks in ordinary)
    {
        int rareLevel = barracks.GetRareLevelValue();
        if (rareLevel > bestRareLevel) { bestRareLevel = rareLevel; best = barracks; }
    }
    if (best != null) { waiting.Remove(best); best.OnCanSpawnRole(); }
}
''')
body('3df8054','''
if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
List<BarracksArchitectureBehaviour> waiting = isEnemy ? _enemyWaitingBarracks : _playerWaitingBarracks;
if (waiting.Count == 0 || !CanSpawnLegendaryUnit(roleID, isEnemy) || !CanSpawnRole(isEnemy)) return;
for (int i = waiting.Count - 1; i >= 0; i--)
    if (waiting[i] == null || waiting[i].isDead) waiting.RemoveAt(i);
if (waiting.Count == 0) return;
BarracksArchitectureBehaviour best = null;
int bestRareLevel = -1;
foreach (BarracksArchitectureBehaviour barracks in waiting)
{
    if (!barracks.IsLegendaryBarracks() || barracks.GetCreatRoleID() != roleID) continue;
    int rareLevel = barracks.GetRareLevelValue();
    if (rareLevel > bestRareLevel) { bestRareLevel = rareLevel; best = barracks; }
}
if (best != null) { waiting.Remove(best); best.OnCanSpawnRole(); }
''')
body('3dedcf0','return global::Pathfinding.AstarWebGLRuntimeConfig.UseWebGLNavigation;')
body('3dedcf8','''
if (!ShouldUseWebGLNavigation()) return;
if (_webGLNavigationManager == null)
{
    GameObject obj = new GameObject("WebGLNavigationManager");
    obj.transform.SetParent(transform, false);
    _webGLNavigationManager = obj.AddComponent<WebGLNavigationManager>();
}
_webGLNavigationManager.Initialize(this);
''')
body('3dede50','''
if (_webGLNavigationManager != null) _webGLNavigationManager.Shutdown();
''')
body('3dedc54','''
allPlayerStayOpenHexObj = new List<GameObject>();
allEnemyStayOpenHexObj = new List<GameObject>();
allHexObj = new List<GameObject>();
allPlayerHasOpenHexObj = new List<GameObject>();
allEnemyHasOpenHexObj = new List<GameObject>();
allPlayerArchitectureObj = new List<GameObject>();
allEnemyArchitectureObj = new List<GameObject>();
allPlayerRoleObj = new List<GameObject>();
allEnemyRoleObj = new List<GameObject>();
allHexObjBehaviour = new List<HexBehaviour>();
allHexObjMat = new List<MeshRenderer>();
allEnemyRoleBehaviour = new List<RoleBehaviour>();
allPlayerRoleBehaviour = new List<RoleBehaviour>();
allRoleBehaviour = new List<RoleBehaviour>();
allEnemyStayOpenHexObjBehaviours = new List<HexBehaviour>();
allArchitectureBehaviours = new List<ArchitectureBehaviour>();
allPlayerArchitectureBehaviours = new List<ArchitectureBehaviour>();
allEnemyArchitectureBehaviours = new List<ArchitectureBehaviour>();
specialHexPos = new List<Vector3>();
_playerArchitectureRoot = new GameObject("PlayerArchitectureRoot");
_enemyArchitectureRoot = new GameObject("EnemyArchitectureRoot");
_playerRoleRoot = new GameObject("PlayerRoleRoot");
_enemyRoleRoot = new GameObject("EnemyRoleRoot");
_destroyObjRoot = new GameObject("DestroyObjRoot");
_specialHexRoot = new GameObject("SpecialHexRoot");
EnsureWebGLNavigationManager();
if (_generateHexObjRoot == null)
{
    _generateHexObjRoot = new GameObject("GenerateHex");
    _generateHexObjRoot.AddComponent<GenerateHexBehaviour>();
}
global::EventModule.EventManager.Instance.StartListening("CraetHexEnd", CreatBothMainTower);
if (global::SDKModule.ABTestManager.Instance.NewArtifactsPlayIsBTest)
{
    GameObject prefab = await global::AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/SkillIndicator.prefab");
    if (_skillIndicator == null)
    {
        _skillIndicator = UnityEngine.Object.Instantiate(prefab);
        _skillIndicatorRenderer = _skillIndicator.GetComponent<SpriteRenderer>();
    }
    else if (_skillIndicatorRenderer == null)
        _skillIndicatorRenderer = _skillIndicator.GetComponent<SpriteRenderer>();
    _skillIndicator.SetActive(false);
}
''')
body('3def3a4','''
global::EventModule.EventManager.Instance.StartListening("HasHexOpen", CheckComboWallCount);
global::EventModule.EventManager.Instance.StartListening("HasHexDestroy", CheckComboWallCount);
''')
body('3def4cc','''
int playerCount = 0;
for (int i = 0; i < allPlayerHasOpenHexObj.Count; i++)
    if (allPlayerHasOpenHexObj[i].GetComponent<HexBehaviour>().IsCombo()) playerCount++;
_playerComboWallCount = playerCount;
global::EventModule.EventManager.Instance.TriggerEvent("PlayerComboWallCountChange", _playerComboWallCount);
int enemyCount = 0;
for (int i = 0; i < allEnemyHasOpenHexObj.Count; i++)
    if (allEnemyHasOpenHexObj[i].GetComponent<HexBehaviour>().IsCombo()) enemyCount++;
_enemyComboWallCount = enemyCount;
global::EventModule.EventManager.Instance.TriggerEvent("EnemyComboWallCountChange", _enemyComboWallCount);
''')
body('3deded4','''
if (!ShouldUseWebGLNavigation()) return;
EnsureWebGLNavigationManager();
_webGLNavigationManager?.Tick(deltaTime);
''')
body('3dedf64','MarkWebGLNavigationGraphDirty();')
body('3dedf68','''
if (!ShouldUseWebGLNavigation()) return;
EnsureWebGLNavigationManager();
_webGLNavigationManager?.MarkPathGraphDirty();
''')
body('3dee670','''
// Original ARM64 MoveNext 0x3DFD310 only completes its async builder.
return;
''')
body('3deeb04','''
if (_generateHexObjRoot == null)
{
    _generateHexObjRoot = new GameObject("GenerateHex");
    _generateHexObjRoot.AddComponent<GenerateHexBehaviour>();
}
await _generateHexObjRoot.GetComponent<GenerateHexBehaviour>().LoadGround(gameType);
''')
body('3dee5d0','''
_currentRoleInstanceID = 0;
playerCanGetWoodNum = 0;
enemyCanGetWoodNum = 0;
_playerRoleCount = 0;
_enemyRoleCount = 0;
playerMainTowerIsDestroy = false;
enemyMainTowerIsDestroy = false;
EnsureWebGLNavigationManager();
MarkWebGLNavigationDirty();
PrewarmBattleRuntimePools().Forget();
Dictionary<string, global::DataModule.GlobalArenaInfo> arenaInfo = global::DataModule.DataManager.Instance.GlobalInfo.arenaInfoDic;
string arenaId = ToolModule.StringTool.IsNullOrEmpty(CoreGameManager.NowPlayEdArenaID, true) ? "1001" : CoreGameManager.NowPlayEdArenaID;
sceneGoldMineCanCreatCount = ToolModule.StringTool.ToInt(arenaInfo[arenaId].minesCountLimit);
if (global::SDKModule.ABTestManager.Instance.BalanceAdjustment01IsBTest)
    sceneGoldMineCanCreatCount &= ~1;
sceneGoldMineMirrorSideCount = sceneGoldMineCanCreatCount / 2;
if (_generateHexObjRoot == null)
{
    _generateHexObjRoot = new GameObject("GenerateHex");
    _generateHexObjRoot.AddComponent<GenerateHexBehaviour>();
}
_generateHexObjRoot.GetComponent<GenerateHexBehaviour>().Generate(gameType);
''')
body('3deebb0','''
if (!CoreGameManager.Gaming) return;
TickWebGLNavigation(Time.deltaTime);
currentUpdateInterTime += Time.deltaTime;
if (currentUpdateInterTime > updateInterTime)
{
    currentUpdateInterTime = 0f;
    if (!upgradeing) UpdateAllList().Forget();
}
''')
body('3deeca0','''
upgradeing = true;
await UniTask.WhenAll(UpdateEnemyRole(), UpdatePlayerRole(), UpdateHexObj(), UpdateArchitecture());
upgradeing = false;
''')
for addr,list_name,item_type in [('3deed38','allEnemyRoleBehaviour','RoleBehaviour'),('3deedd0','allPlayerRoleBehaviour','RoleBehaviour'),('3deee68','allHexObjBehaviour','HexBehaviour'),('3deef00','allArchitectureBehaviours','ArchitectureBehaviour')]:
    body(addr,f'''
int processedCount = 0;
for (int i = {list_name}.Count - 1; i >= 0 && i < {list_name}.Count; i--)
{{
    {item_type} obj = {list_name}[i];
    if (obj != null) obj.MyUpdate();
    processedCount++;
    if (i > 0 && processedCount % BATCH_SIZE == 0) await UniTask.Yield();
}}
''')

initializers={
 '_spawnHexVertices':'new Vector3[6]', '_spawnHexVertexSize':'-1f',
 '_roleTargetFrameCache':'new Dictionary<RoleTargetFrameCacheKey, RoleTargetFrameCacheValue>(128)',
 '_roleTargetFrameCacheFrame':'-1', 'allHellfireBehaviours':'new List<HellfireBehaviour>()',
 'needDestroyPoolPrefabOnEndGame':'new List<GameObject>()',
 '_mirrorMap':'new Dictionary<Tuple<int, int>, HexMirrorInfo>()', 'ScaleFactor':'1000',
 '_playerWaitingBarracks':'new List<BarracksArchitectureBehaviour>()','_enemyWaitingBarracks':'new List<BarracksArchitectureBehaviour>()',
 '_playerLegendaryUnitCount':'new Dictionary<string, int>()','_enemyLegendaryUnitCount':'new Dictionary<string, int>()',
 '_playerLegendaryBarracksCount':'new Dictionary<string, int>()','_enemyLegendaryBarracksCount':'new Dictionary<string, int>()',
 'updateInterTime':'0.02f','updateInterTime_FindAllRoleNearesdEnemy':'1f'
}
rows=members(source); result=source; recovered=[]
for m in reversed(rows):
    a=int(m['rva'],16)
    if a not in bodies: continue
    assert m['stub'],f'Existing body protected: {m["signature"]}'
    code='\n'+''.join('\t\t\t'+l+'\n' if l else '\n' for l in bodies[a].splitlines())+'\t\t'
    result=result[:m['body_start']]+code+result[m['body_end']:]
    recovered.append(dict(token=m['token'],rva=m['rva'],signature=m['signature'],body_sha256=hashlib.sha256(code.encode()).hexdigest()))
assert len(recovered)==len(bodies),(len(recovered),len(bodies))
result=result.replace('[AsyncStateMachine(typeof(_003CInit_003Ed__129))]\n\t\tpublic override UniTask Init()', 'public override async UniTask Init()')
for name,number in [('UpdateAllList',155),('UpdateEnemyRole',156),('UpdatePlayerRole',157),('UpdateHexObj',158),('UpdateArchitecture',159)]:
    result=result.replace(f'[AsyncStateMachine(typeof(_003C{name}_003Ed__{number}))]\n\t\tprivate UniTask {name}()',f'private async UniTask {name}()')
result=result.replace('[AsyncStateMachine(typeof(_003CLoadMapGround_003Ed__147))]\n\t\tpublic UniTask LoadMapGround(GameType gameType)', 'public async UniTask LoadMapGround(GameType gameType)')
result=result.replace('[AsyncStateMachine(typeof(_003CStartGame_003Ed__142))]\n\t\tpublic void StartGame(GameType gameType)', 'public async void StartGame(GameType gameType)')
result=result.replace('[AsyncStateMachine(typeof(_003CPrewarmBattleRuntimePools_003Ed__143))]\n\t\tprivate UniTaskVoid PrewarmBattleRuntimePools()', 'private async UniTaskVoid PrewarmBattleRuntimePools()')
for field,value in initializers.items():
    result,n=re.subn(r'(\b'+re.escape(field)+r')\s*;',lambda m:m[1]+' = '+value+';',result,count=1)
    assert n==1,field
is_next='--next' in sys.argv
candidate=WORK/('candidate-next' if is_next else 'candidate')/REL; candidate.parent.mkdir(parents=True,exist_ok=True)
candidate.write_text(result,encoding='utf-8-sig',newline='\r\n')
report=dict(file=REL,source_before_sha256=hashlib.sha256((WORK/'source-before'/REL).read_bytes()).hexdigest(),candidate_sha256=hashlib.sha256(candidate.read_bytes()).hexdigest(),methods=list(reversed(recovered)),constructor_rva='0x3DF9248',field_initializers=initializers,exact_hex_step=dict(rva='0x1837244',float32=hex_step,bits='0x3FDDB3D7'))
(WORK/('scene-recovery.next.json' if is_next else 'scene-recovery.json')).write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps(dict(methods=len(recovered),fields=len(initializers),candidate_sha256=report['candidate_sha256']),ensure_ascii=False))
