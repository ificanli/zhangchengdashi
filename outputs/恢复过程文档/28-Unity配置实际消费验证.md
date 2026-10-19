# 28. Unity 配置实际消费验证

本阶段已取得第一轮真实 Unity Editor 配置消费证据：**当前 AB getter 返回值所选的 65 份配置，已由真实 GlobalInfo 成功加载，65 项类型／字典／原始资源字节检查全部通过，待完成列表为 0。** 实际状态为 `current_config_consumption_passed_ab_context_unconfirmed`。这只接受当前所选配置的消费；11 个 AB getter 均显现常量默认返回桩形态，原 AB 初始化与其他变体仍未确认，核心玩法仍未验收。

观察器只新增 `Assets/RecoveryTools/Editor/ObserveConfigConsumption.cs`，没有再次修改 DataManager、GlobalInfo、既有 Editor asmdef 或任何生产完成字段。源码、独立编译与实际运行证据在下文分别记录。

观察器直接反射 Unity 当前域实际加载的 `Assembly-CSharp`，构造真实 `DataModule.GlobalInfo`，执行真实 `InitInfo`，再读取其实际字段。它没有加载外部测试 DLL、创建替代管理器、把独立解析结果塞回生产字段，或清空 `loadingConfig` 使等待结束。

## 1. 当前完成状态

| 层次 | 本阶段结果 | 证明范围 |
|---|---|---|
| 观察器源码 | 已落盘、冻结 | 新增 Editor 工具及观察逻辑存在 |
| 独立 C# 编译 | 0 警告、0 错误 | 直接编译实际 Assets 文件；仅引用真实 Unity 基础 DLL |
| 编译 DLL 元数据 | 已检查 | 无 Assembly-CSharp、UniTask 或生产替身引用；未执行该 DLL |
| Unity 正式全工程编译 | 第 14 轮已通过，并执行本观察器 | 正式导入与运行由主代理统一记录；本报告另核实本轮 loaded Main 身份 |
| Unity 配置实际消费 | **当前所选 65 项通过** | 真实 await 完成，65 项核对通过，实际 pending 为 0；详见第 8 节 |
| AB 初始化与分组上下文 | **未确认** | 11 个实际 getter 值为 false／0，均检测到常量默认返回桩形态；`abContextConfirmed=false` |
| 核心玩法验收 | **未执行** | `coreGameplayAccepted=false`；不由配置读取结果推断 |

源码稳定点：`ObserveConfigConsumption.cs` 的 SHA-256 为 `944e028c24bb8cfd99d00a5c16d5eef0941b677ae69e608c6d8efa9ece577523`。本代理没有手写或覆盖 `.meta`；该新脚本已交由 Unity 的统一导入处理。

## 2. 真实调用及可观察范围

开始时要求 Editor 处于已完成导入的空闲 Edit Mode；若仍编译、导入或准备进入 Play Mode，只记录原因并结束。当前域必须恰有一个名为 `Assembly-CSharp` 的程序集。JSON 会记录该程序集完整身份、路径、MVID、SHA-256，以及真实 GlobalInfo 类型，避免把独立编译检查误当作 Unity 生产程序集执行。

正常入口可先构造实际 `ljzs_lt.Procedure.ProcedurePreLoad` 并反射调用其私有 `InitGameSetting`，对应原 RVA `0x439FA28`。它当前会执行 I2 的 culture 策略及 StartupLanguageHelper、设置当前／默认线程的 culture 与 UI culture 为 `en-US`，并调用实际 `ToolModule.LitJsonExtent.Init`。这些是生产方法真实产生的前提状态，JSON 记录调用与前后 culture；观察器没有手写一个替代注册器。另有不执行该前提的入口，其记录会明确前提未经本次确认。

随后读取真实 `ABTestManager.Instance` 与 11 个参与选择的 getter，记录值、getter IL 及保守的常量默认返回形态。**访问 Instance 可能触发原单例的懒构造**，所以本观察器是执行型诊断，不应描述为完全无副作用的只读扫描。它不显式调用 `ABTestManager.Init`，不调用分组 setter，不给 AB 分组赋值，也不声称原初始化完成。

观察器构造一个新的真实 GlobalInfo，先保存构造后的集合快照，再调用真实 InitInfo 一次。当前生产方法签名是 **`System.Threading.Tasks.Task InitInfo()`**，其内部才等待真实 UniTask；不能把外层返回类型写成 UniTask。观察器对实际返回对象执行实际 `GetAwaiter`，在 `EditorApplication.update` 中轮询实际 `IsCompleted`，完成后只调用一次实际 `GetResult`，并记录返回类型、awaiter 类型及程序集。它没有插入自己的 UniTask 队列或调用 `QueuePlayerLoopUpdate`。

该范围验证的是“当前 Editor 域内，一个新建真实 GlobalInfo 的配置消费”。它不执行 `DataManager.LoadConfig`，因此不会以本结果宣称 DataManager 的完成字段、完整启动顺序、登录或存档加载已经通过。

## 3. 81、72、65 的口径及实际选表

第 23 阶段原生证据保留了 81 个唯一路径、72 个静态回调加载点；每次真实 InitInfo 经过原分支选择后应记录 65 个请求。本工具只从实际私有 `hadLoadInfo` 获取本次路径，从实际 `loadingConfig` 获取待完成路径。原生映射只用于事后验证，不决定生产加载哪些表。

生产 await 成功后，工具按真实已选路径筛出验证项，每个 Editor update 最多处理一个回调。选中列表必须为 65 项，待完成列表必须收敛为 0。不能用 81 个静态候选地址冒充本次实际消费结果，也不能因 getter 返回默认值便称 AB 上下文成立。

## 4. 实际类型、字典与资源字节核对

工具读取第 23 阶段的 `配置路径-类型-回调-字段映射.json` 和 `resource-audit.json`，记录它们的 SHA-256。前者必须有 72 项，后者必须有 81 个原始地址。它们是验证依据，任何内容均不写入生产字段。

对每个实际选中的回调，核对真实字段的 List 泛型声明、真实元素的生产模型类型和载荷行数。对原来建字典的回调，还核对 Dictionary 泛型声明、字典键取自原模型字段、字典数量，以及字典 value 与真实列表对象的 `ReferenceEquals`。这可以发现“计数看似正确，但对象或键映射错误”的情况。

主城地图回调 47 额外核对三份真实声明：`List<GlobalMainCityMapInfo>`、`List<GlobalMapInfo>`、`Dictionary<string,GlobalMapInfo>`，并检查嵌套展开数量、唯一 tileKey 数量和字典对象身份。原始载荷已知为 10 个外层行、941 个 tile 和 941 个唯一 tileKey；实际验证按当前 Unity TextAsset 解码所得值比较，不把这些数字直接写给生产对象。

完成后对本次选中的 `JsonData/<stem>` 做第二次 `Resources.Load<TextAsset>` 读回，保存 Unity TextAsset 身份、压缩原始字节与独立 GZip 解码字节的长度及 SHA-256，并要求与第 23 阶段原始资源审计完全一致。预期 JSON 行数通过实际已加载的 LitJson 非泛型 `JsonMapper.ToObject(string)` 读取；这些 JsonData 对象只用于计数，不进入 GlobalInfo。

该第二次读回不能证明生产 loader 的具体分支。若 Resources 不可读而生产可能走了真实 Addressables fallback，记录会保留无法闭合字节核对的原因，不以替代加载伪造通过。观察器也不验证 Addressables 初始化、下载或 fallback 的完整运行链。

## 5. 通过条件与失败保留

`configurationConsumptionPassed` 只有在真实 GetResult 成功、实际选中 65 项、实际待完成为 0、原生映射可用、65 个类型／字典／原始字节验证全部通过，且观察期间没有捕获 Unity Error、Exception 或 Assert 时才可能为 true。即使满足，状态仍写作 `current_config_consumption_passed_ab_context_unconfirmed`，保留 AB 上下文限制；`coreGameplayAccepted` 始终为 false。

工具默认观察 120 秒，可设为 10–600 秒。超时、域重载、再次导入／编译或 Play Mode 状态变化时，只停止自身观察，记录异常、待完成路径、最后集合数量、相关日志和耗时。它不会取消生产任务、清空列表或写任何生产 ready flag；尚未真实完成的情况记录为 `productionMayStillBeRunning`。批处理观察结束可以退出该进程，不把退出本身视为生产成功。

## 6. 独立编译证据

实际执行：`dotnet build work/config-consumption-observer/compile/ConfigObserverCompile.csproj -c Release --nologo`。csproj 直接包含已经落入 Assets 的观察器文件，目标为 `netstandard2.1`、C# 9，引用 Unity `2022.3.62f3c1` 安装中的 `UnityEngine.CoreModule`、`UnityEngine.JSONSerializeModule` 与 `UnityEditor.CoreModule`。最终结果 0 警告、0 错误。

编译输出 DLL 的 SHA-256 为 `98aa56b20715c2b5f9a2f53d14d65e0e3c2931a70fe9e268ee006d45e8bad8bf`。用 PEReader 仅读取元数据，得到引用恰为 `netstandard 2.1.0.0` 及上述三个 Unity 程序集；未加载／执行目标 DLL。此证据证明独立编译未借用 Main、UniTask 或生产替身，不证明 Unity 当前域已执行配置。

## 7. 主代理下一轮执行入口

统一导入成功、Editor 空闲后，可从菜单执行 `Recovery/Observe Config Consumption/With Original InitGameSetting`。菜单不会关闭交互式 Editor。若需要只观察既有前提，使用 `Without Invoking Preconditions` 并保留相应限制。

批处理执行的 `-executeMethod` 为 `OccupyCity.Recovery.Editor.ObserveConfigConsumption.Run`，**不要附加 `-quit`**；工具需要等待多个 Editor update，再由自己的 Run 入口结束批处理。默认调用真实 InitGameSetting；仅显式指定 `-recoveryConfigSkipPreconditions` 才跳过。报告路径参数 `-recoveryConfigReportPath` 必须位于工作区 `work/recovery-ledger` 内，防止误写资源或生产文件。默认文件名含 UTC 时间和随机短 ID，不复用旧结果。

后续重跑时可使用以下命令形态，并选用新的报告文件名；本轮实际归档名为 `unity-config-consumption1`，见第 8 节：

```powershell
& 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Unity.exe' `
  -batchmode -nographics `
  -projectPath 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\outputs\OccupyCityRecovered' `
  -executeMethod OccupyCity.Recovery.Editor.ObserveConfigConsumption.Run `
  -recoveryConfigTimeoutSeconds 120 `
  -recoveryConfigReportPath 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\recovery-ledger\config-consumption-current.json' `
  -logFile 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\recovery-ledger\config-consumption-current.log'
```

每轮重跑后均应保留真实 JSON、Unity 日志和 loaded Main 身份。没有生成示例运行 JSON，也没有将计划值包装为观察值。

本阶段归档目录为 `证据/Unity配置实际消费验证`，内含观察器源码快照、实际编译项目、最终编译日志、DLL 元数据、编译状态与逐项验证计划。`compile-status.json`、`verification-plan.json` 保留 07:35 UTC 准备时的历史 `not-run` 状态；最新实际运行结果以 `runtime-validation.json` 和本节之后的记录为准。

## 8. 第一轮真实 Unity 执行结果

主代理在第 14 轮正式导入成功后执行真实观察器。运行 ID 为 `20261019-074214-405-e5b9d48c`，时间为 2026-10-19 15:42:14–15:42:23（UTC+8），观察耗时约 8.926 秒，处于 batch Edit Mode，`playMode=false`。原始 JSON 为 `work/recovery-ledger/unity-config-consumption1.json`，原始 Unity 日志为同名 `.log`。

实际生产程序集来自 Unity 当前项目 `Library/ScriptAssemblies/Assembly-CSharp.dll`，记录的 SHA-256 为 `fb9049cacf79cb003d549ba11358344d816d30530ec531a43901d5b3e5f7198a`，MVID 为 `2d3bdaac-c944-4340-b255-a8660e5ff0a6`。归档时重新计算该 DLL 的 SHA-256，与运行记录相同，未把独立编译工具 DLL 作为生产对象。

实际反射声明返回类型为 `System.Threading.Tasks.Task`；本轮 Mono 运行时返回对象具体为 `Task<VoidTaskResult>`，awaiter 为 `TaskAwaiter<VoidTaskResult>`，两者来自实际 `mscorlib`。观察器真实调用 GetResult 并成功返回，`productionAwaitCompleted=true`、`productionMayStillBeRunning=false`，异常和快照错误均为空。实际 UniTask 与 LitJson 程序集也分别记录为 `UniTask`、`LitJson`。

本轮确实执行了真实 `InitGameSetting`，当前与默认线程的 culture／UI culture 从本机 `zh-CN`、默认 null 变为 `en-US`。没有跳过该前提。

| 核对项 | 实际观察 |
|---|---|
| 实际 selected 路径 | 65 项，65 个唯一地址 |
| 实际 pending 路径 | 0 项 |
| 实际类型／字典检查 | 65 项通过，0 项失败 |
| 与原生映射的选中 callback 集合 | 完全相同，共 65 项 |
| 当前 Unity TextAsset 的原始／解码字节 | 65 项均与第 23 阶段原始资源审计相同 |
| 集合快照 | 构造后与完成后各记录 93 个集合字段；不将快照数量称为所有字段均有数据 |
| 捕获的 Unity Error／Exception／Assert／Resources fallback 警告 | 0 条，丢弃日志 0 条 |
| 主城外层 mapInfos | 真实 `List<GlobalMainCityMapInfo>`，10 行 |
| 主城 tileInfos | 真实 `List<GlobalMapInfo>`，展开为 941 个 tile |
| 主城 tileInfoDic | 真实 `Dictionary<string,GlobalMapInfo>`，941 个唯一键，实际对象身份不匹配 0 项 |

主城 TextAsset 原始 6,436 B，解码后 86,656 B；原始 SHA-256 为 `c4327a33aa1e4e01ce9372336b9450f40f8b9adf26e817e97b882906ceb82bad`，解码 SHA-256 为 `fdb0d1be07ce03970cb3d9b1e674443a73cc1028765dbd752e1847728d387be1`。二者与原审计相同。

### 本轮 AB 值和接受限制

实际读取的 11 个选择 getter 中，`GamePlayImproveV2Variant=0`；其余 `NewMachineCardIsB`、`NewCardsV1IsB`、`WeeklyCardEventIsB`、`NewArtifactsPlayIsBTest`、`ShopImproveV1IsBTest`、`AbilitiesInAdvanceIsBTest`、`NewArenaProcessIsBTest`、`NewbieTutorialIsBTest`、`BalanceAdjustment03IsBTest`、`WeeklyClashImprove01IsBTest` 均为 false。

**11 个 getter 的实际 IL 全部为 `00160A2B00062A`，均标记 `possibleConstantDefaultStub=true`。** 该形态对应当前 getter 的常量默认返回。因而，本轮证明的是“这些当前值所选出的真实配置消费成功”，不能说原 AB 初始化已恢复，也不能说 A/B、V2 等所有变体都在 Unity 中跑过。观察器没有为使选表成功而修改这些值。

本轮未执行 `DataManager.LoadConfig` 或首场景完整启动链；没有验证真实 Addressables fallback，因为选中 Resources 读回均存在；没有进入 Play Mode、观察实际游戏画面或执行核心玩法。`abContextConfirmed=false` 和 `coreGameplayAccepted=false` 原样保留。

### 实际证据归档与脱敏

原始 JSON SHA-256 为 `760b67ff5723735db5f903c352b16ab3d8a5d44baafc496aeac3c907116cc42e`，原始日志 SHA-256 为 `7d55e067436c57ab2bcd8d2ce3f995827a471c21e6145eeea0d0756360d8b10d`。交付目录保存完整观察 JSON 的路径脱敏副本、Unity 日志的脱敏副本和独立回读审计 `runtime-validation.json`。JSON 只替换工作区路径文本，观察值、程序集身份和哈希不变；日志另外遮蔽 47 行授权／会话／设备认证细节，没有用脱敏修改配置结果。

归档回读共核实 14 项条件，包含实际 DLL 字节身份、真实 Task awaiter、选中 callback 集、生产模型类型、65 项原始资源哈希、主城 941 项对象与键、AB 默认桩提示及范围限制，全部与原始 JSON 一致。这个“14 项回读通过”是对本轮真实证据的一致性核实，不能代替未执行的其他验收层。
