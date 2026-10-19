using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
namespace GameModule { public class BattleGameSceneManager {
public struct RoleTargetFrameCacheKey : IEquatable<RoleTargetFrameCacheKey>
		{


			public bool sourceIsEnemy;


			public int q;


			public int r;


			public int rangeBucket;


			public RoleTargetFrameCacheKey(bool sourceIsEnemy, int q, int r, int rangeBucket)
			{
			this.sourceIsEnemy = sourceIsEnemy;
			this.q = q;
			this.r = r;
			this.rangeBucket = rangeBucket;
		}


			public bool Equals(RoleTargetFrameCacheKey other)
			{
			return sourceIsEnemy == other.sourceIsEnemy && q == other.q && r == other.r && rangeBucket == other.rangeBucket;
		}


			public override bool Equals(object obj)
			{
			return obj is RoleTargetFrameCacheKey && Equals((RoleTargetFrameCacheKey)obj);
		}


			public override int GetHashCode()
			{
			return unchecked((397 * ((397 * ((sourceIsEnemy ? 157609 : 0) ^ q)) ^ r)) ^ rangeBucket);
		}
		}
public Transform transform = new Transform();
public struct RoleTargetFrameCacheValue { public RoleBehaviour target; }
const int MAX_ROLE_COUNT=100; const int BATCH_SIZE=50; const int RoleTargetMaxHexSearchRing=10; const float RoleTargetRangeCachePrecision=100f;
public int _currentRoleInstanceID;
public GameObject _playerRoleRoot;
public GameObject _enemyRoleRoot;
public GameObject _generateHexObjRoot;
public GenerateHexBehaviour _generateHexBehaviour;
public readonly Dictionary<RoleTargetFrameCacheKey, RoleTargetFrameCacheValue> _roleTargetFrameCache = new Dictionary<RoleTargetFrameCacheKey, RoleTargetFrameCacheValue>(128);
public int _roleTargetFrameCacheFrame = -1;
public int _playerRoleCount;
public int _enemyRoleCount;
public int _playerReservedCount;
public int _enemyReservedCount;
public List<BarracksArchitectureBehaviour> _playerWaitingBarracks = new List<BarracksArchitectureBehaviour>();
public List<BarracksArchitectureBehaviour> _enemyWaitingBarracks = new List<BarracksArchitectureBehaviour>();
public Dictionary<string, int> _playerLegendaryUnitCount = new Dictionary<string, int>();
public Dictionary<string, int> _enemyLegendaryUnitCount = new Dictionary<string, int>();
public Dictionary<string, int> _playerLegendaryBarracksCount = new Dictionary<string, int>();
public Dictionary<string, int> _enemyLegendaryBarracksCount = new Dictionary<string, int>();
public List<GameObject> allPlayerRoleObj;
public List<GameObject> allEnemyRoleObj;
public List<RoleBehaviour> allPlayerRoleBehaviour;
public List<RoleBehaviour> allEnemyRoleBehaviour;
public List<RoleBehaviour> allRoleBehaviour;
public List<GameObject> allPlayerStayOpenHexObj;
public List<GameObject> allEnemyStayOpenHexObj;
public List<GameObject> allHexObj;
public List<GameObject> allPlayerHasOpenHexObj;
public List<GameObject> allEnemyHasOpenHexObj;
public List<GameObject> allPlayerArchitectureObj;
public List<GameObject> allEnemyArchitectureObj;
public List<HexBehaviour> allHexObjBehaviour;
public List<MeshRenderer> allHexObjMat;
public List<HexBehaviour> allEnemyStayOpenHexObjBehaviours;
public List<ArchitectureBehaviour> allArchitectureBehaviours;
public List<ArchitectureBehaviour> allPlayerArchitectureBehaviours;
public List<ArchitectureBehaviour> allEnemyArchitectureBehaviours;
public List<Vector3> specialHexPos;
public GameObject _playerArchitectureRoot;
public GameObject _enemyArchitectureRoot;
public GameObject _destroyObjRoot;
public GameObject _specialHexRoot;
public WebGLNavigationManager _webGLNavigationManager;
public GameObject _skillIndicator;
public SpriteRenderer _skillIndicatorRenderer;
public int _playerComboWallCount;
public int _enemyComboWallCount;
public float currentUpdateInterTime;
public float updateInterTime = 0.02f;
public bool upgradeing;
public int playerCanGetWoodNum;
public int enemyCanGetWoodNum;
public bool playerMainTowerIsDestroy;
public bool enemyMainTowerIsDestroy;
public int sceneGoldMineCanCreatCount;
public int sceneGoldMineMirrorSideCount;
public int PlayerHasHex { get {
			return unchecked(allPlayerStayOpenHexObj.Count + allPlayerHasOpenHexObj.Count);
		} }
public int EnemyHasHex { get {
			return unchecked(allEnemyStayOpenHexObj.Count + allEnemyHasOpenHexObj.Count);
		} }
public int MaxRoleCount { get {
			return MAX_ROLE_COUNT;
		} }
public bool CanSpawnRole(bool isEnemy) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return true;
			return isEnemy ? unchecked(_enemyRoleCount + _enemyReservedCount) < MAX_ROLE_COUNT
			               : unchecked(_playerRoleCount + _playerReservedCount) < MAX_ROLE_COUNT;
		}
public int GetAvailableSlots(bool isEnemy) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return int.MaxValue;
			int used = isEnemy ? unchecked(_enemyRoleCount + _enemyReservedCount)
			                   : unchecked(_playerRoleCount + _playerReservedCount);
			return Mathf.Max(0, unchecked(MAX_ROLE_COUNT - used));
		}
public void ReserveRoleSlot(bool isEnemy) {
			ReserveRoleSlot(isEnemy, 1);
		}
public void ReserveRoleSlot(bool isEnemy, int count) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			if (isEnemy) _enemyReservedCount = unchecked(_enemyReservedCount + count);
			else _playerReservedCount = unchecked(_playerReservedCount + count);
		}
public void ReleaseReservedSlot(bool isEnemy) {
			ReleaseReservedSlot(isEnemy, 1);
		}
public void ReleaseReservedSlot(bool isEnemy, int count) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			if (isEnemy) _enemyReservedCount = Mathf.Max(0, unchecked(_enemyReservedCount - count));
			else _playerReservedCount = Mathf.Max(0, unchecked(_playerReservedCount - count));
		}
public async Task Init() {
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
		}
public static bool ShouldUseWebGLNavigation() {
			return global::Pathfinding.AstarWebGLRuntimeConfig.UseWebGLNavigation;
		}
public void EnsureWebGLNavigationManager() {
			if (!ShouldUseWebGLNavigation()) return;
			if (_webGLNavigationManager == null)
			{
			    GameObject obj = new GameObject("WebGLNavigationManager");
			    obj.transform.SetParent(transform, false);
			    _webGLNavigationManager = obj.AddComponent<WebGLNavigationManager>();
			}
			_webGLNavigationManager.Initialize(this);
		}
public void ShutdownWebGLNavigationManager() {
			if (_webGLNavigationManager != null) _webGLNavigationManager.Shutdown();
		}
public void TickWebGLNavigation(float deltaTime) {
			if (!ShouldUseWebGLNavigation()) return;
			EnsureWebGLNavigationManager();
			_webGLNavigationManager?.Tick(deltaTime);
		}
public void MarkWebGLNavigationDirty() {
			MarkWebGLNavigationGraphDirty();
		}
public void MarkWebGLNavigationGraphDirty() {
			if (!ShouldUseWebGLNavigation()) return;
			EnsureWebGLNavigationManager();
			_webGLNavigationManager?.MarkPathGraphDirty();
		}
public async Task StartGame(GameType gameType) {
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
		}
public async Task PrewarmBattleRuntimePools() {
			// Original ARM64 MoveNext 0x3DFD310 only completes its async builder.
			return;
		}
public async Task LoadMapGround(GameType gameType) {
			if (_generateHexObjRoot == null)
			{
			    _generateHexObjRoot = new GameObject("GenerateHex");
			    _generateHexObjRoot.AddComponent<GenerateHexBehaviour>();
			}
			await _generateHexObjRoot.GetComponent<GenerateHexBehaviour>().LoadGround(gameType);
		}
public void Update() {
			if (!CoreGameManager.Gaming) return;
			TickWebGLNavigation(Time.deltaTime);
			currentUpdateInterTime += Time.deltaTime;
			if (currentUpdateInterTime > updateInterTime)
			{
			    currentUpdateInterTime = 0f;
			    if (!upgradeing) UpdateAllList().Forget();
			}
		}
public async Task UpdateAllList() {
			upgradeing = true;
			await Task.WhenAll(UpdateEnemyRole(), UpdatePlayerRole(), UpdateHexObj(), UpdateArchitecture());
			upgradeing = false;
		}
public async Task UpdateEnemyRole() {
			int processedCount = 0;
			for (int i = allEnemyRoleBehaviour.Count - 1; i >= 0 && i < allEnemyRoleBehaviour.Count; i--)
			{
			    RoleBehaviour obj = allEnemyRoleBehaviour[i];
			    if (obj != null) obj.MyUpdate();
			    processedCount++;
			    if (i > 0 && processedCount % BATCH_SIZE == 0) await BatchScheduler.Yield();
			}
		}
public async Task UpdatePlayerRole() {
			int processedCount = 0;
			for (int i = allPlayerRoleBehaviour.Count - 1; i >= 0 && i < allPlayerRoleBehaviour.Count; i--)
			{
			    RoleBehaviour obj = allPlayerRoleBehaviour[i];
			    if (obj != null) obj.MyUpdate();
			    processedCount++;
			    if (i > 0 && processedCount % BATCH_SIZE == 0) await BatchScheduler.Yield();
			}
		}
public async Task UpdateHexObj() {
			int processedCount = 0;
			for (int i = allHexObjBehaviour.Count - 1; i >= 0 && i < allHexObjBehaviour.Count; i--)
			{
			    HexBehaviour obj = allHexObjBehaviour[i];
			    if (obj != null) obj.MyUpdate();
			    processedCount++;
			    if (i > 0 && processedCount % BATCH_SIZE == 0) await BatchScheduler.Yield();
			}
		}
public async Task UpdateArchitecture() {
			int processedCount = 0;
			for (int i = allArchitectureBehaviours.Count - 1; i >= 0 && i < allArchitectureBehaviours.Count; i--)
			{
			    ArchitectureBehaviour obj = allArchitectureBehaviours[i];
			    if (obj != null) obj.MyUpdate();
			    processedCount++;
			    if (i > 0 && processedCount % BATCH_SIZE == 0) await BatchScheduler.Yield();
			}
		}
public void CreatBothMainTower(object o) {
			global::EventModule.EventManager.Instance.StartListening("HasHexOpen", CheckComboWallCount);
			global::EventModule.EventManager.Instance.StartListening("HasHexDestroy", CheckComboWallCount);
		}
public void CheckComboWallCount(object o) {
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
		}
public List<RoleBehaviour> GetRoleTargetsSync(Transform transform, bool isEnemy, float range, int roleNum = 1) {
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
		}
public RoleBehaviour GetRoleTargetSync(Transform transform, bool isEnemy, float range) {
			RoleBehaviour target;
			return transform != null && TryGetNearestRoleTarget(transform.position, isEnemy, range, out target) ? target : null;
		}
public bool TryGetNearestRoleTarget(Transform sourceTransform, bool sourceIsEnemy, float range, out RoleBehaviour target) {
			if (sourceTransform == null) { target = null; return false; }
			return TryGetNearestRoleTarget(sourceTransform.position, sourceIsEnemy, range, out target);
		}
public bool TryGetNearestRoleTarget(Vector3 sourcePos, bool sourceIsEnemy, float range, out RoleBehaviour target) {
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
		}
public int CollectRoleTargetsInRange(Transform sourceTransform, bool sourceIsEnemy, float range, List<RoleBehaviour> result) {
			if (sourceTransform == null) { if (result != null) result.Clear(); return 0; }
			return CollectRoleTargetsInRange(sourceTransform.position, sourceIsEnemy, range, result);
		}
public int CollectRoleTargetsInRange(Vector3 sourcePos, bool sourceIsEnemy, float range, List<RoleBehaviour> result) {
			if (result == null) return 0;
			result.Clear();
			List<RoleBehaviour> targetList = GetRoleTargetList(sourceIsEnemy);
			if (targetList == null || range < 0f || targetList.Count == 0) return 0;
			float sqrRange = range * range;
			bool searchedHexRing;
			if (TryCollectRoleTargetsInRangeFromHexRing(sourcePos, !sourceIsEnemy, range, sqrRange, result, out searchedHexRing) || searchedHexRing)
			    return result.Count;
			return CollectRoleTargetsInRangeFromList(sourcePos, targetList, sqrRange, result);
		}
public List<RoleBehaviour> GetRoleTargetList(bool sourceIsEnemy) {
			return sourceIsEnemy ? allPlayerRoleBehaviour : allEnemyRoleBehaviour;
		}
public void PrepareRoleTargetFrameCache() {
			int frame = Time.frameCount;
			if (_roleTargetFrameCacheFrame == frame) return;
			_roleTargetFrameCacheFrame = frame;
			_roleTargetFrameCache.Clear();
		}
public bool TryGetRoleTargetFrameCacheKey(Vector3 sourcePos, bool sourceIsEnemy, float range, out RoleTargetFrameCacheKey key) {
			key = default;
			int searchRing;
			if (!TryGetRoleTargetHexSearchRing(range, out searchRing)) return false;
			HexBehaviour hex;
			if (!HexManager.TryGetHexAt(sourcePos, out hex) || hex == null) return false;
			key = new RoleTargetFrameCacheKey(sourceIsEnemy, hex.HexCoord.q, hex.HexCoord.r,
			                                 Mathf.CeilToInt(range * RoleTargetRangeCachePrecision));
			return true;
		}
public bool TryGetCachedNearestRoleTarget(Vector3 sourcePos, bool sourceIsEnemy, float range, float sqrRange, out RoleBehaviour target) {
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
		}
public void CacheNearestRoleTarget(Vector3 sourcePos, bool sourceIsEnemy, float range, RoleBehaviour target) {
			if (target == null) return;
			PrepareRoleTargetFrameCache();
			RoleTargetFrameCacheKey key;
			if (!TryGetRoleTargetFrameCacheKey(sourcePos, sourceIsEnemy, range, out key)) return;
			_roleTargetFrameCache[key] = new RoleTargetFrameCacheValue { target = target };
		}
public static bool IsRoleTargetValid(RoleBehaviour role) {
			return role != null && !role.isDead && !role.StealthIng;
		}
public bool TryGetRoleTargetHexSearchRing(float range, out int searchRing) {
			searchRing = unchecked(Mathf.CeilToInt(range / Mathf.Max(GetSpawnHexSize() * 1.73205078f, 0.5f)) + 2);
			return searchRing <= RoleTargetMaxHexSearchRing;
		}
public bool TryGetNearestRoleTargetFromHexRing(Vector3 sourcePos, bool targetIsEnemy, float range, float sqrRange, out RoleBehaviour nearestRole, out bool searchedHexRing) {
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
		}
public bool TryCollectRoleTargetsInRangeFromHexRing(Vector3 sourcePos, bool targetIsEnemy, float range, float sqrRange, List<RoleBehaviour> result, out bool searchedHexRing) {
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
		}
public static bool TryGetNearestRoleTargetFromList(Vector3 sourcePos, List<RoleBehaviour> targetList, float sqrRange, out RoleBehaviour nearestRole) {
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
		}
public static int CollectRoleTargetsInRangeFromList(Vector3 sourcePos, List<RoleBehaviour> targetList, float sqrRange, List<RoleBehaviour> result) {
			for (int i = 0; i < targetList.Count; i++)
			{
			    RoleBehaviour role = targetList[i];
			    if (IsRoleTargetValid(role) && (sourcePos - role.transform.position).sqrMagnitude <= sqrRange)
			        result.Add(role);
			}
			return result.Count;
		}
public static void SortNearestRoleTargetsInPlace(Vector3 sourcePos, List<RoleBehaviour> result, int roleNum) {
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
		}
public float GetSpawnHexSize() {
			if (_generateHexBehaviour == null && _generateHexObjRoot != null)
			    _generateHexBehaviour = _generateHexObjRoot.GetComponent<GenerateHexBehaviour>();
			return _generateHexBehaviour != null ? _generateHexBehaviour.hexSize : 1f;
		}
public void AddPlayerRole(GameObject obj, bool isFake = false, bool shouldCountInLimit = false) {
			if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && shouldCountInLimit && _playerRoleCount >= MAX_ROLE_COUNT)
			{
			    UnityEngine.Debug.LogWarning(string.Format("尝试创建超过上限的单位！当前计数: {0}, 上限: {1}", _playerRoleCount, MAX_ROLE_COUNT));
			    return;
			}
			allPlayerRoleObj.Add(obj);
			RoleBehaviour role = obj.GetComponent<RoleBehaviour>();
			allPlayerRoleBehaviour.Add(role);
			allRoleBehaviour.Add(role);
			WebGLNavigationManager.TryRegisterRole(role);
			if (isFake) return;
			_currentRoleInstanceID = unchecked(_currentRoleInstanceID + 1);
			role._instanceID = _currentRoleInstanceID;
			if (RoleShadowManager.Instance != null) RoleShadowManager.Instance.Bind(role);
			if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && shouldCountInLimit)
			{
			    if (_playerReservedCount > 0) _playerReservedCount = unchecked(_playerReservedCount - 1);
			    _playerRoleCount = Mathf.Min(unchecked(_playerRoleCount + 1), MAX_ROLE_COUNT);
			    global::EventModule.EventManager.Instance.TriggerEvent("PlayerRoleCountChange", _playerRoleCount);
			    role._isCountedInRoleLimit = true;
			}
			global::EventModule.EventManager.Instance.TriggerEvent("HasPlayerRoleCreat", role);
			obj.transform.SetParent(_playerRoleRoot.transform, false);
			if (BattleGameManager.Instance != null) BattleGameManager.Instance.TryApplyPauseToNewRole(obj);
		}
public void AddEnemyRole(GameObject obj, bool isFake = false, bool shouldCountInLimit = false) {
			if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && shouldCountInLimit && _enemyRoleCount >= MAX_ROLE_COUNT)
			{
			    UnityEngine.Debug.LogWarning(string.Format("尝试创建超过上限的单位！当前计数: {0}, 上限: {1}", _enemyRoleCount, MAX_ROLE_COUNT));
			    return;
			}
			allEnemyRoleObj.Add(obj);
			RoleBehaviour role = obj.GetComponent<RoleBehaviour>();
			allEnemyRoleBehaviour.Add(role);
			allRoleBehaviour.Add(role);
			WebGLNavigationManager.TryRegisterRole(role);
			if (isFake) return;
			_currentRoleInstanceID = unchecked(_currentRoleInstanceID + 1);
			role._instanceID = _currentRoleInstanceID;
			if (RoleShadowManager.Instance != null) RoleShadowManager.Instance.Bind(role);
			if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && shouldCountInLimit)
			{
			    if (_enemyReservedCount > 0) _enemyReservedCount = unchecked(_enemyReservedCount - 1);
			    _enemyRoleCount = Mathf.Min(unchecked(_enemyRoleCount + 1), MAX_ROLE_COUNT);
			    global::EventModule.EventManager.Instance.TriggerEvent("EnemyRoleCountChange", _enemyRoleCount);
			    role._isCountedInRoleLimit = true;
			}
			global::EventModule.EventManager.Instance.TriggerEvent("HasEnemyRoleCreat", role);
			obj.transform.SetParent(_enemyRoleRoot.transform, false);
			if (BattleGameManager.Instance != null) BattleGameManager.Instance.TryApplyPauseToNewRole(obj);
		}
public void RemovePlayerRole(GameObject obj, bool triggerTrySpawn = true) {
			if (!allPlayerRoleObj.Contains(obj)) return;
			RoleBehaviour role = obj.GetComponent<RoleBehaviour>();
			allPlayerRoleObj.Remove(obj);
			allPlayerRoleBehaviour.Remove(role);
			allRoleBehaviour.Remove(role);
			WebGLNavigationManager.TryUnregisterRole(role);
			if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && role != null && role._isCountedInRoleLimit && triggerTrySpawn)
			{
			    _playerRoleCount = Mathf.Max(0, unchecked(_playerRoleCount - 1));
			    global::EventModule.EventManager.Instance.TriggerEvent("PlayerRoleCountChange", _playerRoleCount);
			    TrySpawnFromWaitingBarracks(false);
			}
		}
public void RemoveEnemyRole(GameObject obj, bool triggerTrySpawn = true) {
			if (!allEnemyRoleObj.Contains(obj)) return;
			RoleBehaviour role = obj.GetComponent<RoleBehaviour>();
			allEnemyRoleObj.Remove(obj);
			allEnemyRoleBehaviour.Remove(role);
			allRoleBehaviour.Remove(role);
			WebGLNavigationManager.TryUnregisterRole(role);
			if (global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest && role != null && role._isCountedInRoleLimit && triggerTrySpawn)
			{
			    _enemyRoleCount = Mathf.Max(0, unchecked(_enemyRoleCount - 1));
			    global::EventModule.EventManager.Instance.TriggerEvent("EnemyRoleCountChange", _enemyRoleCount);
			    TrySpawnFromWaitingBarracks(true);
			}
		}
public void RegisterWaitingBarracks(BarracksArchitectureBehaviour barracks, bool isEnemy) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			List<BarracksArchitectureBehaviour> waiting = isEnemy ? _enemyWaitingBarracks : _playerWaitingBarracks;
			if (!waiting.Contains(barracks)) waiting.Add(barracks);
		}
public void UnregisterWaitingBarracks(BarracksArchitectureBehaviour barracks, bool isEnemy) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			(isEnemy ? _enemyWaitingBarracks : _playerWaitingBarracks).Remove(barracks);
		}
public void TrySpawnFromWaitingBarracks(bool isEnemy) {
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
		}
public void TrySpawnLegendaryFromWaitingBarracks(string roleID, bool isEnemy) {
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
		}
public void AddLegendaryBarracks(string roleID, bool isEnemy) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			Dictionary<string, int> counts = isEnemy ? _enemyLegendaryBarracksCount : _playerLegendaryBarracksCount;
			counts[roleID] = counts.ContainsKey(roleID) ? unchecked(counts[roleID] + 1) : 1;
		}
public void RemoveLegendaryBarracks(string roleID, bool isEnemy) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			Dictionary<string, int> counts = isEnemy ? _enemyLegendaryBarracksCount : _playerLegendaryBarracksCount;
			if (!counts.ContainsKey(roleID)) return;
			counts[roleID] = Mathf.Max(0, unchecked(counts[roleID] - 1));
			if (counts[roleID] == 0) counts.Remove(roleID);
		}
public void AddLegendaryUnit(string roleID, bool isEnemy) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			Dictionary<string, int> counts = isEnemy ? _enemyLegendaryUnitCount : _playerLegendaryUnitCount;
			counts[roleID] = counts.ContainsKey(roleID) ? unchecked(counts[roleID] + 1) : 1;
		}
public void RemoveLegendaryUnit(string roleID, bool isEnemy) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return;
			Dictionary<string, int> counts = isEnemy ? _enemyLegendaryUnitCount : _playerLegendaryUnitCount;
			if (!counts.ContainsKey(roleID)) return;
			counts[roleID] = Mathf.Max(0, unchecked(counts[roleID] - 1));
			if (counts[roleID] == 0) counts.Remove(roleID);
			TrySpawnLegendaryFromWaitingBarracks(roleID, isEnemy);
		}
public int GetLegendaryUnitCount(string roleID, bool isEnemy) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return 0;
			Dictionary<string, int> counts = isEnemy ? _enemyLegendaryUnitCount : _playerLegendaryUnitCount;
			return counts.ContainsKey(roleID) ? counts[roleID] : 0;
		}
public int GetLegendaryBarracksCount(string roleID, bool isEnemy) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return 0;
			Dictionary<string, int> counts = isEnemy ? _enemyLegendaryBarracksCount : _playerLegendaryBarracksCount;
			return counts.ContainsKey(roleID) ? counts[roleID] : 0;
		}
public bool CanSpawnLegendaryUnit(string roleID, bool isEnemy) {
			if (!global::SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest) return true;
			return GetLegendaryUnitCount(roleID, isEnemy) < GetLegendaryBarracksCount(roleID, isEnemy);
		}
} }