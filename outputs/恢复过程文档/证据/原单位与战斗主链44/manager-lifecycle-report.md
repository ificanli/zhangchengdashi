# Manager 生命周期入口有效验证补充

本补充分支保持候选冻结，仅测试和写报告。新增覆盖 `BattleGameManager.Init`（RVA `0x3DE3B50`）、`GameEnd`（`0x3DE3FD8`）、`StartGame`（`0x3DE6814`）三个入口。实际候选 **102 场景、1195 检查、0 失败，exit=0**；source-before 原空桩负对照使用同一夹具，**102 场景、1195 检查、935 失败，exit=1**。规范结果入口为 `manager-lifecycle-validation/result.json`。

候选 SHA256 `13228c84736658776651f1bbd6cb3093e4e9f8be4f670320b32a398c8a38bba8` 在提取和最终读回一致，未修改候选、共享工程或数据库，也没有运行 Unity。

## 从实际候选提取，不维护另一份入口实现

`extract_manager_lifecycle.py` 按原 Token/RVA 读取候选的当前正文，生成 `manager-lifecycle-validation/ExtractedLifecycle.cs`。`candidate-provenance.json` 同时保存源文件绝对路径与 SHA256、三个原方法签名、原始正文、正文 SHA256 和依赖适配说明；`candidate-body.txt` 保存本次实际测试正文。负对照保留在 `baseline-provenance.json`、`baseline-body.txt`。

唯一的语义表面适配是：

- Init 的 `async UniTask` 返回换成 `async Task`，正文不变。
- GameEnd 的 `async void` 返回换成 `async Task`，便于观察等待和异常边界，正文不变。
- UniTask.WaitForSeconds 的外部依赖以受控 Task gate 表达，没有真实等待 2.3 秒。
- 原空桩 Init 的默认 UniTask 是完成任务，负对照表达为 `Task.CompletedTask`，避免把返回类型适配问题冒充业务失败。

其余 adapters 只提供单例、配置容器、UI、buff、格式化、事件、回调和协程依赖；没有复制三个方法的业务控制流程。为了观察原四个字典的赋值顺序，适配 State 把这些原字段的存储操作观察为属性 setter，并记录先后；生产候选没有改成属性。`GetTimeCutDownString`、`BeginStartCountDown` 只记录本入口调用时的参数与状态，它们各自的正文已经由另一个 Manager 夹具验证，本补充不重复实现其规则。

## Init：等待、失败与监听顺序

3 个场景覆盖：FloatingText 初始化尚未完成时的暂停、依赖完成后的注册与字典创建、初始化依赖异常、监听中途异常。

具体检查包括：

- FloatingText 的 gate 未放行前，Init 仍未完成，13 个监听和四字典没有提前创建。
- 放行后按原顺序注册监听，逐一核实事件名和真实候选传入的委托 Method.Name；同一个 `GameSteerEndShowCardProbabilityPanel` 事件先绑定 BeginStartCountDown，再绑定 GuidOneEndAddCoin。
- 所有监听发生时四个字典仍为 null；随后按 role damage→tower damage→card open→dead unit 顺序赋值，都是新的空字典，三个 string/int 字典互不共用。
- FloatingText 失败时不进行后续监听/字典创建；第六个监听失败时保留前六次注册的实际轨迹，不执行剩余监听，也不提前创建字典。

这些检查能发现空方法、未等待初始化、错误的监听名/回调、注册顺序变化和提前创建字典。

## GameEnd：2.3 秒等待、out 与不等待 HidePanel

33 个场景包含胜负、Weekly BTest、文本动画、面板显示状态、原协程有无的 32 种组合，以及 GameEnd 事件失败场景。适配 UIManager 要求精确的原 HexDescribesPanel 路径，IsPanelShowing 使用 out 参数；HidePanel 返回一个始终不完成的 Task，用于验证原入口确实没有等待它。

检查顺序为原生复核所得契约：胜利任务的可选触发→写 isVictory→可选 DoAni→Gaming=false→GameEnd 事件→isCountDowning=false→可选停止协程→ForceCloseTutorial→IsPanelShowing/可选 HidePanel→可选 WaitForSeconds(2.3f)→SettlementAnimation。

其中事件 adapter 在回调现场观察 Gaming=false、isVictory 已更新、isCountDowning 尚为 true；StopCoroutine 在其现场观察 isCountDowning 已为 false，证明关键字段修改与事件先后没有被交换。Weekly 任务的装箱枚举=1，数量=1。

文本动画为真时，放行 2.3 秒 gate 前没有结算；放行后立即结算，即使 HidePanel 的 Task 仍未完成。无文本动画时，GameEnd 在 HidePanel Task 未完成的情况下直接完成并结算。因而测试能够发现新增 `await HidePanel`、遗漏等待或提前结算。GameEnd 事件抛错时，后续停止协程、关教程、延迟和结算均不继续。

此处把 async void 适配为 Task 是为了观察结果，不验证 Unity 的 async-void 异常路由。

## StartGame：配置读取、初始金币和卡牌计数

66 个场景包含 null/空/纯空白 arena ID 的默认 `1001`、指定 `2042`、引导场/常规场、首次通关标记、已有/新建卡牌字典、FPS 监控存在/不存在的 64 种组合，以及 arena 不存在、battleContext 为 null 两个原失败边界。

实际候选从原消费路径 `DataManager.Instance.GlobalInfo.arenaInfoDic[arenaID].countDownTime` 取值，再调用 StringTool.ToInt 和 SubGameBuffManager.ModifyCountDownTime(ref countDownTime)。适配配置用可辨别的字符串 `347`，buff 增加 13，另放置未使用键和值 `999`；检查最终原字段为 360、时间字符串消费者看到 360、查找的是指定键，buff 发生在格式化和 UI 更新之前。由此证明候选消费传入的配置字段，不能以固定 180 等常量通过。本补充没有加载原资源配置文件，不把这个依赖契约验证表述为原配置加载链已经运行。

UI 更新必须仍接收到旧余额 7，之后才产生引导配置金币 777、已通关金币 150 或首次金币 50。检查 battleInitCoin、battleTotalEarned 等于新初始余额、battleTotalCost=0、_isAddCoining=true；开始倒计时调用保持原 `!isFirstThroghGame` 门控。

GameType、_battleContext 和两个 callback 保持输入引用身份；暂停字段和暂停快照按原次序清理，接着 ResetPerfStates、可选 StartMonitoring，再读取原卡牌列表。列表包含重复 `101` 及 `202`；已有 `101=7/303=9` 的字典不被重置，重复卡不覆盖已有计数，只有新卡 `202` 增加为 0；原字典身份保留，缺失字典才创建。

arena 缺失时保留 KeyNotFoundException，buff/UI/新金币没有被补造。context 为 null 时按原次序先完成配置、UI、初始金币和可选倒计时，再在上下文访问处失败，未越过该点修改暂停/perf 状态。

## 结果与复现命令

| 输入 | 场景 | 检查 | 失败 | 退出码 |
|---|---:|---:|---:|---:|
| source-before 原三入口空桩 | 102 | 1195 | 935 | 1 |
| 实际候选重新提取 | 102 | 1195 | 0 | 0 |

工作目录固定为 `C:/Users/luxinyu/Documents/Codex/2026-10-19/x20`，精确 CLI 同时记录在 `result.json`：

```powershell
& 'C:/Users/luxinyu/AppData/Local/Programs/idapromcp/source/.venv/Scripts/python.exe' -X utf8 work/parallel-44-battle/extract_manager_lifecycle.py --baseline
dotnet run --project work/parallel-44-battle/manager-lifecycle-validation/LifecycleTests.csproj -c Release -- work/parallel-44-battle/manager-lifecycle-validation/baseline-result.json
& 'C:/Users/luxinyu/AppData/Local/Programs/idapromcp/source/.venv/Scripts/python.exe' -X utf8 work/parallel-44-battle/extract_manager_lifecycle.py
dotnet run --project work/parallel-44-battle/manager-lifecycle-validation/LifecycleTests.csproj -c Release -- work/parallel-44-battle/manager-lifecycle-validation/candidate-result.json
```

最终 ExtractedLifecycle.cs 与 fixture-provenance.json 保持实际候选状态。所有场景的具体轨迹和中间观察在 candidate-result.json/baseline-result.json；stdout 在 candidate-tests.log/baseline-tests.log。已有 Manager 主夹具的 413 检查和编译 IL 的 12 检查应由总报告单列，本补充 1195 检查不包含它们。

本阶段为原生证据约束下的实际候选依赖适配执行，覆盖了三个核心入口的行为和失败边界。它不验证 Unity 生命周期、UI资源、SDK、存档加载器、真实协程/player loop 或 GPU；原生方法语义的逐项证据另见 manager-review.md，真实 Unity 运行仍由主窗口统一验收。
