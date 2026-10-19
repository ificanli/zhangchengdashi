# 44 号内部分工：BattleGameSceneManager 原登记、容量、选敌与帧驱动

日期：2026-10-19。状态：候选稳定，等待父代理统一编译、报告合并和 SHA 门禁应用。

本分工仅写 `work/parallel-44-battle/candidate/Assets/Scripts/Assembly-CSharp/GameModule/BattleGameSceneManager.cs`。共享工程与地图文件全部只读；没有启动 Unity、Hub、PlayMode，没有操作任何 IDA 数据库。原生伪 C 与 ASM 由父代理统一从本任务专属数据库导出；本分工另外直接从原 ARM64 ELF 读取消费者证据和执行标量 oracle。

## 交付和保护

- 恢复 65 个原方法正文，另按原构造 `0x3DF9248` 恢复 16 处字段初始化器，保持初始化发生在基类构造之前。其中 PrewarmBattleRuntimePools 原方法本身即无业务工作，仅保留其真实 async 完成语义，见后文尾函数证据。
- 源前 SHA256：`0adeb82e5ac636ff1a955c63540dcede5e1a4688582b5b7c09f3fe59661d54bb`。
- 候选 SHA256：`eef332ac7c5471f3e7b7add4a1dff2f29b177c2f64bac758c5d0d62d27a9750f`。前一批 60 方法稳定版本和当时验证结果保存在 `stable-60/`，下一批先写 `candidate-next/` 并完成负对照、真实引用 csc 和审计后才提升到正式 candidate。
- 原有 `PlayerRoleCount` / `EnemyRoleCount` 两段非空 getter 正文逐字保持；原 Token 全序列一致。未触碰其他三个候选类，尤其未触碰 `InternalCalculateDamage`。
- `scene-recovery.json` 给出逐方法 Token/RVA/签名/正文 hash；`scene-validation/scene-validation-summary.json` 给出保护审计、75 个关联原生函数边界、测试结果。Prewarm 的唯一 JUMPOUT 已沿原 ELF 追至真实 builder 尾函数；其他选中伪 C 无未审查 JUMPOUT。Init/更新/启动/地面任务采用原入口对应的 MoveNext 证据；旧导出状态机嵌套声明保留，恢复的 async 方法由 C# 编译器生成新的可执行状态机。

## 原入口与尚未闭合的资源链

已恢复的 GameManager 源码表明 `StartCoreGame` 构造原 BattleContext 后交 `CoreGameManager.StartGame`。本分工再次从原 ELF 读取 CoreGameManager / BarracksArchitectureBehaviour 共 38 个原方法，记录原函数边界、直接调用、MethodInfo 和字符串引用，存放 `scene-validation/consumer-chain/`，外部源码没有修改。

原 `CoreGameManager.<StartGame>d__18.MoveNext` 位于 `0x3E03374`：可确认调用 `BattleGameSceneManager.LoadMapGround`，随后调用其 `StartGame`。第二批已恢复本类这两个原入口，包含真实 LoadGround 等待和最终 Generate(gameType) 调用，具体契约见后文。CoreGameManager 本身仍属主窗口拥有；本批没有用替代入口绕过它，也没有实现另一套地图。

原 `BarracksArchitectureBehaviour.<CreatRole>d__34.MoveNext` 位于 `0x4299C04`，可确认调用本类 `GetAvailableSlots`、`GetRoleBornPos`、`ReleaseReservedSlot`、`AddPlayerRole` / `AddEnemyRole`、`AddLegendaryUnit`，同时有真实资源等待、配置刷新、角色资源等待和生产上限分支。本分工恢复的是它调用的容量和登记部分；兵营正文、出生位置和原角色资源/动画生产链仍是明确依赖。

原兵营引用的八个 MagicCircle / MagicMissileSoft Prefab 已在实际工程中查到，同一路径均存在于 AddressablesConfig，分别归 UI / FirstPack2。`scene-validation/resource-chain.json` 记录每项实际 Prefab 路径、GUID、SHA、meta bundle 名及配置记录。资源文件存在不代表运行时已经加载成功。

本类 Init 的 SkillIndicator 路径完全来自原字符串槽：`Assets/_Res/Addressable/02CoreGameBundle/Prefabs/CoreGame/SpriteUI/SkillIndicator.prefab`，真实 GUID `b01873c19db176a4eb2a25d4a60c5d8b`，实际 Prefab 包含 SpriteRenderer，m_Sprite GUID `3ad852d324cb3fb49b59da03798f5496` 指向实际 `SpritesBundle/Dynamic/SkillRing.asset`。FirstPack 原配置和生成 Addressables 分组都登记该地址。没有添加资源兜底或伪造加载结果。

## 恢复行为与原生对应

### 初始化和实例生产

`Init` 的原 MoveNext `0x3DFC2C4` 先生成 19 个原列表、六个根 GameObject，随后按原导航设置创建/复用 WebGLNavigationManager，创建/复用 GenerateHex 根并添加原 GenerateHexBehaviour。创建组件时原方法没有立即写 `_generateHexBehaviour` 缓存，候选也没有添加这次写入；该缓存仍在 GetSpawnHexSize 按需取得。

原 `CraetHexEnd` 拼写保持。该监听回调叫 `CreatBothMainTower`，但原 native 只注册 `HasHexOpen` / `HasHexDestroy` 到 `CheckComboWallCount`，不能按名字另写创建主塔逻辑。候选保留真实回调闭包；连墙计数仍消费原 `HexBehaviour.IsCombo()`，并按玩家事件后敌人事件的顺序触发。

NewArtifactsPlay AB 门为真时才发起真实 LoadAssetAsync，一次 await；成功后按原对象/renderer 判空复用或 Instantiate，最后隐藏指示器。失败按原 async 语义传播，不继续生成指示器。重复 Init 会重新生成各列表和六个根、再次注册监听，但复用已有 GenerateHex/SkillIndicator；没有擅自改成“一次性初始化”。

`PlayerHasHex` / `EnemyHasHex` 原 getter 是各自 StayOpen 列表数加 HasOpen 列表数，候选没有把它改成单一列表数或建筑数。

### 原容量、登记与等待兵营

容量门由 `ABTestManager.GamePlayImprove01IsBTest` 决定。AB 关闭时 CanSpawnRole=true，GetAvailableSlots=int.MaxValue，预占/释放和传奇计数写入全部不生效。AB 开启时读取各自 role count 与 reserved count，按原 int32 溢出后比较/钳零，最大数为 100。

AddPlayerRole / AddEnemyRole 先执行原限额拒绝分支，再顺序加入 GameObject 列表、阵营 RoleBehaviour 列表和全 RoleBehaviour 列表，登记导航。isFake 只执行这些前段动作。普通角色才写实例 ID、绑定阴影、消费一个已有预占、计数与事件、原父节点和暂停适用。原方法允许重复登记，候选没有补去重。计数事件若抛错，原后续 counted 标志、出生事件和 parent 都不会执行，该顺序已验证。

Remove 只有对象确实在登记列表时才继续；移除三个列表、注销导航后，必须 AB 开、原角色仍有效、角色 counted 且 triggerTrySpawn=true 才减计数、发计数事件、唤醒等待兵营。**triggerTrySpawn=false 同时抑制原计数减少**，虽容易误以为只控制唤醒，本批按原 native 保留。

等待兵营先看容量，再清理失效/死亡项。按原逻辑将传奇和普通兵营分开：先按 roleID 分组传奇，取可生产组内最高稀有度；没有可用传奇才取最高稀有度普通兵营；同稀有度保留遇到的第一个，一次只唤醒一个，且先从等待列表移除再调用 OnCanSpawnRole。传奇死亡只寻找同 ID 可生产传奇。传奇单位数和兵营数的零值会删除字典键，AB、阵营、回调顺序都保留。

### 原目标选择与缓存

以 sourceIsEnemy 选择对方列表。有效目标规则原生只有 Unity 对象非空、未死亡、未隐身；没有添加其他单位/阵营/碰撞条件。正常距离使用三维平方距离，边界包含在范围内，最近距离相同保留首个。

最近目标先尝试按帧缓存，然后按原 HexRing 搜索。只有无法取得当前位置 Hex 或搜索圈数超过 10 时才回退阵营列表；已成功搜索 HexRing 但没有找到目标会返回 false，不能强制再扫描全列表来掩盖 Hex 角色登记依赖。收集目标保持相同回退门。多目标按原部分选择排序取最近若干；roleNum<=1 的公共路径尝试一个最近目标，包括 roleNum=0。

缓存 key 为 sourceIsEnemy、原 HexCoord.q/r、CeilToInt(range*100)，frameCount 改变时清缓存。GetHashCode 的 bool 真分支原立即数是 **157609**，后两轮乘 397 后异或，候选没有按常见模板改成 397。Hex 步距乘数从原 ELF `0x1837244` 读取，float32 bits `0x3FDDB3D7`，没有采用伪 C 四舍五入显示的 1.7321。

一个真实修复点是伪 C 隐藏了 NaN 条件。ASM 最近目标比较为 B.GT / B.GE，距离 unordered 时原路径可接受；收集方法使用 B.HI，会拒绝 unordered 距离；范围负值门使用 B.MI，NaN 不被当成负值拒绝。候选逐分支匹配，并有实际候选 NaN 边界用例，未统一改成看似等价的 <= / >= 表达式。

### 每帧调用闭包

Update 原入口 `0x3DEEBB0` 只有 `CoreGameManager.Gaming` 门。Gaming 为真后先 TickWebGLNavigation(Time.deltaTime)，再累计更新计时，严格大于 0.02 秒阈值时归零；upgradeing=false 才发起 UpdateAllList().Forget()。没有额外插入暂停标志、固定步长或直接扣血。

UpdateAllList 原 MoveNext `0x3DFE8C8` 先写 upgradeing=true，以原顺序发起 EnemyRole、PlayerRole、HexObj、Architecture 四任务后 WhenAll。每个列表逆序遍历，且每次检查下标仍在当前列表长度内；每处理 50 项且还有更低下标时 await UniTask.Yield()。失效/空项跳过 MyUpdate，但仍计入批次数。yield 期间列表缩短到当前下标之外，原方法会结束迭代。

只有四任务全部成功后原 native 才清 upgradeing；异常路径没有 finally 清理。本批保留这种失败后防重入状态，并验证其他列表任务已经发起、失败传播、下一 Update 仍重置计时但不重入。

### 第二批：真实 LoadGround / Generate 入口

LoadMapGround 原入口 `0x3DEEB04` / MoveNext `0x3DFCE18` 先按 Unity 对象判空创建或复用 `GenerateHex` 对象及原 GenerateHexBehaviour，再且仅 await 一次该组件的 `LoadGround(gameType)`。候选保留 gameType、等待、异常传播与对象复用；没有在本类直接加载一个地面资源来假装地图已完成，也没有额外调用 Generate 或缓存 `_generateHexBehaviour`。

StartGame 原入口 `0x3DEE5D0` / MoveNext `0x3DFE48C` 是 async-void，但没有 await。候选保留 async-void 的异常送交 builder 语义。先重置 `_currentRoleInstanceID`、双方可得木材数、双方角色数、双方主塔死亡标记；原方法不清预占数、角色列表或传奇字典，候选没有擅自加清理。

随后执行 EnsureWebGLNavigationManager、MarkWebGLNavigationDirty、PrewarmBattleRuntimePools().Forget()，再取得 `DataManager.Instance.GlobalInfo.arenaInfoDic`。原 `NowPlayEdArenaID.IsNullOrEmpty(trimSpaces:true)` 为真时使用 `1001`，否则使用未经 trim 的原 arenaID。读取该行 `minesCountLimit.ToInt()` 到 `sceneGoldMineCanCreatCount`；BalanceAdjustment01 AB 为真时按原 `AND 0xFFFFFFFE` 降到偶数，`sceneGoldMineMirrorSideCount` 为总数除 2、负数向零截断。最终创建/复用 GenerateHex 对象并调用其原 `Generate(gameType)`。ASM `0x3DFE778 LDR W1,[state+0x30]` 核实了伪 C 丢掉的 gameType 实参，未改为无参调用。

MarkWebGLNavigationDirty `0x3DEDF64` 实际是到 MarkWebGLNavigationGraphDirty `0x3DEDF68` 的尾调用；后者受原 WebGLNavigation 门控制，Ensure 后通过引用空条件调用原 MarkPathGraphDirty。不能把名字含 Dirty 的方法当成空操作。

PrewarmBattleRuntimePools 的 MoveNext `0x3DFD310` 仅 4 条指令：写 state=-2、把 this 移至 builder 字段、X1=0、跳 `0x3D313B0`。本批继续直接读取原 ELF `0x3D313B0–0x3D31494`：runner 为空即返回；否则取得 IStateMachineRunner.ReturnAction，调用 PlayerLoopHelper.AddContinuation(LastPostLateUpdate=13, action) 并清 runner，与工程现有 AsyncUniTaskVoidMethodBuilder.SetResult 完全对应。`prewarm-builder-tail.json/.asm.txt` 保存真实类型槽、调用、代码 hash 和 RET 位置。该原 APK 方法没有预热业务；候选保留原 async UniTaskVoid 完成，不伪造对象池工作，也没有删除 StartGame 的调用。

这两个入口恢复之后，实际地图仍依赖 43 号的 GenerateHexBehaviour.LoadGround / Generate 正文；两个调用都不表示它们已经在 Unity 内完成。GetRoleBornPos 本批仍未恢复，具体未闭合点见末节。

## 验证与有效负对照

| 层级 | 结果 | 实际支持范围 |
|---|---|---|
| 候选正文重提取的独立夹具 | **1283 场景 / 4589 检查 / 0 失败** | 容量、预占、阵营列表、登记/事件/异常顺序、等待兵营、选敌边界、缓存、Init/LoadGround 等待与失败、原 StartGame 配置/生成入口、每帧时序与批次 |
| 原始空壳负对照 | **1283 场景 / 1280 失败，进程退出 1** | 能发现缺失实现；3 个自然零结果容量边界恰好与空壳一致，保留在结果中未删掉 |
| 原 ARM64 指令 oracle | **2688 次候选对照全通过** | 480 组容量输入各执行 CanSpawn/GetSlots/Reserve/Release 四种原指令段，另 512 组原 hash、256 组 StartGame 矿数量 AB 取偶和向零除 2 指令；包含正负极限、计数边界和固定种子随机值 |
| 原生边界/JUMPOUT 审计 | **75 个关联函数边界匹配，无未检查 JUMPOUT** | 65 个原入口及构造、Init/四批次/WhenAll/StartGame/LoadMapGround/Prewarm 状态机正文身份；Prewarm tail 已核真实 builder |
| 现有非空正文/Token 保护 | **2 段正文逐字一致，Token 全序列一致** | 不覆盖已经恢复 getter，不删除声明 |
| 真实 Unity 引用 csc | **退出 0，0 错误**；完整工程原有 7792 警告记录保留 | 原 Unity Assembly-CSharp.rsp 的全部引用与 analyzers，4 个候选替换；结果在 scene-validation/compile-next/result.json。Scene 的源 hash 与提升后候选相同。父代理最终统一编译仍应记录其另外三类的最终 hash |
| Unity Editor/PlayMode/视觉/输入/原兵堆战斗 | **not-run** | 用户明确禁止本窗口启动 Unity；未宣称实际游戏运行 |

oracle 执行的是 AB getter 返回后的原指令后段，由夹具控制 W0 表示原 AB 服务结果；不是整套 AB 服务或完整引擎环境的执行。未以手写容量公式充当原生 oracle。

验证代码从**本次交付候选**重新提取 65 个正文。private 改 public 仅为夹具访问；UniTask 改 Task，UniTask.Yield 改为可控的依赖等待源，StartGame 的 async-void 在夹具内改 Task 以观察错误，Unity、原管理器、Hex 角色索引和兵营回调是可控适配器。正式候选仍是 async-void，且已用真实引用编译。夹具没有第二份场景业务实现，但不验证这些依赖的真实实现、Unity Object 生命周期、真实帧调度、资源视觉或导航算法。

复现命令（在 x20 根运行，Python 为任务指定的 idapromcp venv Python）：

```text
python -X utf8 work/parallel-44-battle/prepare_scene_candidate.py
python -X utf8 work/parallel-44-battle/scene-validation/native_oracle.py
python -X utf8 work/parallel-44-battle/scene-validation/extract_fixture.py --baseline
dotnet run --project work/parallel-44-battle/scene-validation/SceneTests.csproj
python -X utf8 work/parallel-44-battle/scene-validation/extract_fixture.py
dotnet run --project work/parallel-44-battle/scene-validation/SceneTests.csproj
python -X utf8 work/parallel-44-battle/scene-validation/audit_candidate.py
```

dotnet run 的工作目录须为 `scene-validation`，因为夹具读取其本地 golden/extraction JSON。baseline 命令预期退出 1；最终再提取候选并跑到退出 0，当前交付的 fixture 已恢复为候选版本。

## 当前不可宣称完成的依赖

1. CoreGameManager 的真实 StartGame / Gaming 生产仍需由主窗口恢复；本类 LoadMapGround / StartGame 已恢复到原 GenerateHexBehaviour 依赖调用，但 43 号的 LoadGround / Generate 正文与地图验收仍需闭合。本批没有把启动完成字段改成 true。
2. 本类 GetRoleBornPos 与两个采样辅助方法仍未恢复。已核其 ABI：isEnemy 参数在本方法原生实际未消费，count 在 W3，返回 UniTask<List<Vector3>> 使用 X8 间接结果；count<=0 不访问 Transform，正数先读一次 position 再重复调用采样。采样原 ASM 实际用相邻顶点与 Vector3.zero 组成三角形，取两个 float 随机数、sum>1 时各自取 1-rand，生成重心坐标，不能按方法名字误写成单一边缘插值。GetRandomPositionOnHexEdge 旧伪 C 丢失全部向量返回和具体 catch/rethrow 边界；EnsureSpawnHexVertices 也有数组越界异常尾部 JUMPOUT。当前未把尚未完整验证的异常语义/float 舍入候选写入稳定交付。兵营创建角色仍必须消费该原出生位置链。
3. BarracksArchitectureBehaviour.Init / CreatRole / OnCanSpawnRole / GetRareLevelValue / GetCreatRoleID / IsLegendaryBarracks 与 ArchitectureBehaviour.MyUpdate 不在本内部拥有范围，当前共享源仍有大量壳。等待队列回调被调用不代表已经产兵。
4. 地图 43 号必须提供 HexManager.TryGetHexAt/GetHexBehaviour、HexBehaviour.GetRoleCountByCamp/GetRoleByCamp 和原角色登记、IsCombo、MyUpdate；本候选保持真实调用，不写替代索引或回退绕过。
5. WebGLNavigationManager、Astar、GPUInstancer 动画、RoleShadowManager 和真实角色资源加载仍需各自完整实现与场景验证；本批只恢复本类调用契约。
6. 本分工没有恢复胜负结算、塔死亡、Scene EndGame；父代理 BattleGameManager/Role/Synergy 的恢复进度应单独报告，不能由本类独立测试推断战斗完成。

这些限制不会阻止父窗口集成本次 SHA 门禁候选；它们是下一批原主链闭合和真实 Unity 验收的必要条件。
