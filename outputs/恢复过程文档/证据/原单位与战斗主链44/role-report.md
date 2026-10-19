# 44 号 RoleBehaviour：原单位伤害、死亡与底层契约恢复

状态：**64 个原成员形成稳定候选，已冻结为可合入批次。** 本子任务仅写独立 work 候选；共享工程 RoleBehaviour、地图与派生兵种源码均未修改，未启动 Unity。

## 本批实际交付

候选：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-44-battle\candidate\Assets\Scripts\Assembly-CSharp\GameModule\RoleBehaviour.cs`。

起始 SHA256：`6bcd6f2a91c7e646dfa943b305469379855ab1ae4145a7f1813faed08089a454`。

最终候选 SHA256：`f49977604d96f417b7f2b3f3ec869e5bd07842488ceb14ad3d6d230cd5011d9e`。

183 个原带 RVA 成员、全部 Token/Address/字段/声明/属性标注保持不变。原先 3 个非空 getter `0x3D846A0`、`0x3D88158`、`0x3D88160` 的正文逐字节保留。`role-validation/final-audit.json` 的 7 项保护检查全部通过，共享源仍等于起始 SHA。

本批恢复了构造初值、AniInstancing 优先的真实动画驱动解析与缓存、角色目标保留/最近格距约束、导航速度/半径与控制门、路径刷新、当前格子登记、完整 Wound 原调用链、完整 Dead 原状态机与回调、普通回收清理/战后回收、血条移除和事件订阅解绑。没有把兵种派生类改成基类绕行，也没有用直接扣血演示替代原入口。

## 关键原理与原生对应

`Wound RVA 0x3D86A44` 保留 `CoreGameManager.Gaming`、已死、缺属性、零伤害、角色 ID 1012 施法状态等门。原 `OnHurtTalentTrigger` 先返回 `(int damage,float extraMiss)`，再执行 `Random.Range(0,101)` 闪避；减伤、Terran/Machine 羁绊、契约按剩余伤害顺序分摊之后，才写伤害文字、减 hp、血液特效和敌方承伤统计，再触发健康变化天赋，最后重新判断死亡并调用原 Dead/血条/击杀天赋或受击音效。契约转发保留全部原参数，并把 linkAttackObj 重置为 null。

原伤害转换是 `SCVTF/float32 multiply/FCVTZS`，额外把正无穷转换为 int.MinValue。候选以内联边界分支保留 NaN、超界饱和与正无穷特判，int32 减法明确 unchecked。父任务负责 SynergyEffectManager；本子任务没有触碰已验证 InternalCalculateDamage。

`Dead RVA 0x3D876CC` 使用原 `_003CDead_003Ed__190` 结构体和 AsyncVoidMethodBuilder 启动；`MoveNext RVA 0x3D90878`、`SetStateMachine RVA 0x3D914E4` 已恢复，保留原字段、Token 和状态机属性。初始阶段先停寻路、标死、移出当前格、终止 Tween、通知 HasRoleDead/子玩法/血条、计算并分配击杀币，再解绑地图事件、播放死亡动画、停移动、移出双方列表；等待 `DeadAnimationLength - 0.1f`（非正时 0.1f，Update 时序）之后才解绑影子并调用 DeadCallBack。挂起使用原 state=0/awaiter 字段，恢复清空 awaiter 并进入 state=-1，终态为 -2。

`DeadCallBack RVA 0x3D878E4` 保留传奇计数移除、OnDeadSkill 门、真实 DeadUnitInfo 入双方死亡字典、死亡特效开关、GPU crowd 原状态复位、停用与对象池回收、特殊地狱火分支及 OnRecycle。`OnRecycle RVA 0x3D8CE8C` 保留原格登记清理、动画/速度控制、HasHexOpen 解绑、冰冻/眩晕/临时特效/契约/Tween/天赋/目标/原攻击动画速度/寻路目标对象等清理顺序。地图操作只调用原 HexBehaviour API，未改地图窗口文件。

IDA 伪 C 曾省略 `RemoveRole` 的 player/role 参数及 `ModifyKillCoin` 的阵营参数，均按原 ASM 的 W2/X3 等传参校正。Dead.MoveNext 的地址区间内还出现 SubGameBuffManager 方法别名/outlined 区块；按真实 BL 及原声明保留调用，没有把同区间子函数的文本当作主函数顺序。

## 有效验证、负对照与修复

| 验证 | 实际范围 | 最终结果 | 原空壳负对照 |
| --- | --- | --- | --- |
| 原 ARM64 标量/布尔 oracle + 实际候选控制流夹具 | 17 个原方法 2040 组机器码输入，另 21 项构造/控制/格登记/目标保留调用顺序断言 | 2061 检查，0 失败 | 1470 失败 |
| 原 ARM64 Wound oracle + 实际候选重提取 | 240 场景，覆盖门、闪避、减伤/整数边界、羁绊/分摊、治疗后重新判死与调用序列 | 1200 检查，0 失败 | 631 失败 |
| 原 ARM64 Dead.MoveNext oracle + 实际候选原三正文重提取 | 64 场景、96 个初始/挂起/恢复阶段，币制/阵营/AB/难度门/float32 等待/awaiter/回调顺序 | 384 检查，0 失败 | 312 失败 |
| 原 Unity Assembly-CSharp.rsp 全引用/analyzer 独立 csc | 四个 44 号候选，含最终 Role SHA f4997760… | exit 0，errors 0，既有警告 7790 | 不适用 |
| 声明与保护审计 | 183 原成员，Token/Address/字段/属性/原 3 正文/共享源 SHA | 7 项通过 | 不适用 |

总计 **3645 项候选检查 0 失败**；原占位负对照共 **2413 项失败**。测试从候选真实文件重新提取正文，没有另写一套业务实现作为测试。外部 Unity/Manager/动画/路径 API 和虚方法通过可观察适配器记录契约；数值及主方法控制流由原 ARM64 作为独立 oracle。NaN 的位模式仅比较 NaN 分类，有限值、无穷和有符号零按原 float32 位模式比较。

最初 scalar 测试捕获 GetFollowerEntityMoveSpeed 8 个 NaN 差异：原 `FCSEL HI` 对 unordered 选择除法，伪 C 的 `>0.001` 不足，候选修正为 `!(_bornScaleX <= 0.001f)`。Wound 初版的 NaN 闪避比较也由原生对照发现，按真实分支恢复为 `dodge > roll` 才闪避。GetScaledRadius 按 FCMP+B.MI 恢复为 `!(baseRadius <0)`，保留 NaN 时仍访问 transform 的原副作用。这些修复之后重新跑完整提取验证。

最终编译日志与 SHA：`role-validation/compile-final/result.json`。全部测试 CLI 在 `role-handoff.json.commands`；负对照日志与最终日志均保存在 role-validation。Unity Editor、PlayMode、视觉、原场景地图/兵堆移动战斗验收均为 **not-run**。

## 主链完成度与后续阻塞

本批完成了原伤害/普通死亡及底层契约的候选恢复；**从生成到移动攻击的最小主链仍未闭合**。

| 原入口/阶段 | 当前候选状态 |
| --- | --- |
| 构造器 `0x3D8E1E4` | 已恢复原列表、容量、计时和 sentinel 初值 |
| Awake `0x3D7F7E0` | 原占位保留；Follower/Renderer/初始动画缓存仍未建立 |
| Init `0x3D7FF14` | 原占位保留；属性生产、战斗资源和 hadInit 门仍未闭合 |
| FindTarget `0x3D818CC` | 顶层仍占位；本批仅恢复有效性/节流/格距保留子方法 |
| MyUpdate `0x3D853A0` | 原占位保留 |
| Move `0x3D85A88` | 原占位保留，墙体/占用/卡住看门狗等尚未整体恢复 |
| Atk/MoveNext `0x3D87FB0 / 0x3D8F208` | 原占位保留；未以直接伤害替代攻击节奏 |
| Wound `0x3D86A44` | 完整正文恢复并有 240 场景原 ARM64 对照 |
| Dead/MoveNext `0x3D876CC / 0x3D90878` | 原状态机恢复并有 64 场景原 ARM64 对照 |
| DeadCallBack/OnRecycle `0x3D878E4 / 0x3D8CE8C` | 原正文恢复、独立编译通过；完整真实依赖运行未验收 |
| UpdateHpBar `0x3D8BF30` | 原占位保留；RemoveHPUI 已恢复 |
| HellFireDeadCallBack/MoveNext | 特殊分支仍占位，原调用点保留 |

RolePropertyTemp 与 GameEventArgs 的原构造/实际天赋触发、派生 Terran/Undead/Machine/具体兵种 Init/AtkCallBack/Wound、CoreGameManager.Gaming 的真实生产者、Astar/FollowerEntity/WebGLNavigationManager/ECS 更新组、GPU/动画/血条/特效/音效与对象池等必须由相应拥有者继续恢复。类型可编译和适配测试不能证明这些真实消费者可运行。RemoteInitInfo.MoveNext 与 FindIntermediateHexPath 的导出仍有 JUMPOUT，不据此猜写。

## 逐成员清单（64）

| 原 RVA | 原 Token | 原声明 |
| --- | --- | --- |
| `0x3d90878` | `0x6000FB3` | `void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()` |
| `0x3d914e4` | `0x6000FB4` | `void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)` |
| `0x3d7f778` | `0x6000F08` | `get` |
| `0x3d7f7d0` | `0x6000F09` | `get` |
| `0x3d84470` | `0x6000F30` | `get` |
| `0x3d844bc` | `0x6000F31` | `get` |
| `0x3d84514` | `0x6000F32` | `get` |
| `0x3d845a0` | `0x6000F33` | `get` |
| `0x3d84618` | `0x6000F34` | `get` |
| `0x3d84620` | `0x6000F35` | `get` |
| `0x3d84668` | `0x6000F36` | `get` |
| `0x3d84688` | `0x6000F37` | `get` |
| `0x3d7fd58` | `0x6000F0B` | `private IAnimation ResolveAnimationBehaviour()` |
| `0x3d7fe44` | `0x6000F0C` | `public RoleAnimationDriverType GetAnimationDriverType()` |
| `0x3d7fed8` | `0x6000F0D` | `public bool IsGPUInstancerAnimationDriver()` |
| `0x3d7fef0` | `0x6000F0E` | `public IAnimation GetAnimationBehaviour()` |
| `0x3d81f00` | `0x6000F12` | `private bool ShouldSkipFindTarget(float range)` |
| `0x3d821a0` | `0x6000F13` | `private bool IsRoleTargetValidInRange(EntityBase target, float range)` |
| `0x3d8237c` | `0x6000F14` | `private bool UpdateRoleTargetHexDistance(RoleBehaviour roleTarget)` |
| `0x3d82110` | `0x6000F15` | `private void RecordCurrentRoleTargetDistance()` |
| `0x3d81228` | `0x6000F16` | `private void ClearRoleTargetTracking()` |
| `0x3d82340` | `0x6000F17` | `private float GetFindTargetInterval()` |
| `0x3d82fe8` | `0x6000F1C` | `protected virtual void OnHealthChangeTalentTrigger()` |
| `0x3d831f4` | `0x6000F1D` | `protected (int, float) OnHurtTalentTrigger(int damage)` |
| `0x3d8363c` | `0x6000F20` | `protected void OnKillTalentTrigger()` |
| `0x3d83190` | `0x6000F21` | `public List<RoleBehaviour> GetNearOneMTeamMate()` |
| `0x3d7e054` | `0x6000F29` | `protected Vector3 GetXZDirection(Vector3 targetPosition)` |
| `0x3d83b14` | `0x6000F2A` | `protected void RestoreAiAfterSkillRespectFreeze()` |
| `0x3d83b54` | `0x6000F2B` | `protected bool IsAiMovementBlockedByState()` |
| `0x3d84098` | `0x6000F2C` | `protected void RestoreAiAfterControlStateReleased()` |
| `0x3d840e4` | `0x6000F2D` | `protected void ClearAiControlStates()` |
| `0x3d7fa30` | `0x6000F3A` | `private void SetPathfindingEnabled(bool enabled)` |
| `0x3d848e4` | `0x6000F3C` | `private void RequestSearchPathRefresh()` |
| `0x3d848f0` | `0x6000F3D` | `private bool ShouldSyncPathfindingTargetPosition(bool sourceTargetChanged, Vector3 currentPosition, Vector3 targetPosition)` |
| `0x3d849c4` | `0x6000F3E` | `private void TryRefreshSearchPath()` |
| `0x3d812cc` | `0x6000F3F` | `private static float GetAutoRepathPeriod(int roleCount)` |
| `0x3d84a94` | `0x6000F42` | `public bool GetAiCanMove()` |
| `0x3d7ab7c` | `0x6000F43` | `public void SetAiCanMove(bool can)` |
| `0x3d816b4` | `0x6000F45` | `public float GetAiSPeed()` |
| `0x3d84a9c` | `0x6000F46` | `private float GetFollowerEntityMoveSpeed(float speed)` |
| `0x3d84658` | `0x6000F47` | `private float GetWebGLNavigationMoveSpeed(float speed)` |
| `0x3d7eda8` | `0x6000F48` | `public void SetAiSPeed(float s, bool isReduceSpeed = false)` |
| `0x3d7f9e0` | `0x6000F49` | `private float GetScaledRadius(float baseRadius)` |
| `0x3d84ac4` | `0x6000F4A` | `public float GetAiRadius()` |
| `0x3d84acc` | `0x6000F4B` | `public void SetAiRadius(float s)` |
| `0x3d84b60` | `0x6000F4C` | `public bool GetAiEnableLocalAvoidance()` |
| `0x3d84b68` | `0x6000F4E` | `private void ApplyOccupancyPenalty(bool enable)` |
| `0x3d86a44` | `0x6000F59` | `public override void Wound(int damage, string id, [Optional][DefaultParameterValue(false)] bool isBuild, [Optional] EntityBase target, [Optional][DefaultParameterValue(false)] bool isLandRole, [Optional][DefaultParameterValue((AtkWayType)0)] AtkWayType atkWayType, [Optional][DefaultParameterValue((CardFettersType)4)] CardFettersType fetterType, [Optional] Object linkAttackObj)` |
| `0x3d841c4` | `0x6000F5A` | `public void ShowDamageText(string damage, Color color)` |
| `0x3d876cc` | `0x6000F5C` | `protected virtual void Dead(DeadType deadType = DeadType.Common)` |
| `0x3d8776c` | `0x6000F5D` | `protected virtual void StartListeningEvent()` |
| `0x3d87828` | `0x6000F5E` | `protected virtual void StopListeningEvent()` |
| `0x3d878e4` | `0x6000F5F` | `protected virtual void DeadCallBack(DeadType deadType = DeadType.Common)` |
| `0x3d87450` | `0x6000F60` | `private bool GetIsHellFireAtk(object link)` |
| `0x3d7f628` | `0x6000F65` | `public void SetAnimation(GPUInstanceAnimationBehaviour.AnimationName nextAnimationName, bool force = false)` |
| `0x3d82018` | `0x6000F73` | `private bool TryGetAstarRemainingPath(List<Vector3> outPathPoints)` |
| `0x3d8bc2c` | `0x6000F81` | `public void RemoveHPUI()` |
| `0x3d8cdd8` | `0x6000F8A` | `public void RecycleOnBattleEnd()` |
| `0x3d8ce8c` | `0x6000F8B` | `protected virtual void OnRecycle()` |
| `0x3d8d5a8` | `0x6000F8D` | `private void SyncCurrentHexCampRegistration(bool previousIsEnemy)` |
| `0x3d8d738` | `0x6000F90` | `private void ApplyHexPosition(HexBehaviour newHex)` |
| `0x3d81238` | `0x6000F93` | `private void ClearDizzyState()` |
| `0x3d8d3f8` | `0x6000F94` | `private void ClearFreezeState()` |
| `0x3d8e1e4` | `0x6000FA2` | `public RoleBehaviour()` |

本批交接状态：`ready_for_integration`，文件 `work/parallel-44-battle/role-handoff.json`。**64 成员稳定候选已冻结；本批没有完成原游戏单位生成、移动攻击、战斗胜负或 Unity 运行验收。**
