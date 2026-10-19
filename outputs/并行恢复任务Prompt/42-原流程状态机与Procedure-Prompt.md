# 并行任务42：原流程状态机与Procedure

你是占城大师APK恢复工程的一个独立并行窗口。请直接执行下述任务，持续完成代码候选、有效验证和中文过程报告，不要只给建议。主窗口正在集成，最终总目标是在Unity Editor真实运行原场景和地图、开格/占领、兵堆战斗；单独编译、空方法、模拟器镜像、简化替代游戏均不算达到总目标。

任务根目录固定为 `C:\Users\luxinyu\Documents\Codex\2026-10-19\x20`。所有相对路径均以此为基准；不要使用新窗口默认生成目录作为本工程。

## 当前已核实基线

- Unity：`C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Unity.exe`，完整导入已经退出0。
- 工程：`outputs/OccupyCityRecovered`。原Main四轮PlayMode，最新两轮30秒/15快照/0errors；第四轮实读确认唯一VersionMondule的ready=false、原callback已保存、3个资源引用null；核心玩法尚未进入。
- 主窗口当前3路：38存档底座/AssemblyUtility、39版本资源与Editor provider、40 UIModule。它们与41~44同时推进，禁止越界改其源码。
- 原APK：`outputs/占城大师-1.04.apk`；SHA256 `4544b6323c6a2b11dd801fb75d99dbe6fc59253443bde5a24738d772694b0a2d`。
- 原ARM64：`work/ida-input/libil2cpp-arm64.so`；SHA256 `72770d00b2b404acf44cc75cc8bf7a3e06850e9ace1237c9cbb2bc72894220ed`。
- 元数据：`work/metadata-probe/global-metadata.decoded.dat`；类型/方法映射：`outputs/IDA分析材料/Il2Cpp导出/script.json`；DummyDLL位于`work/il2cpp-dump-decoded/DummyDll`，只代表声明。
- IDA9.4：`C:\Program Files\IDA Professional 9.4\idat.exe`。Python：`C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe`，命令请带`-X utf8`。
- 先读`outputs/恢复过程文档/00-阅读导航与当前进度.md`、第10篇以及本任务相关报告。原方法证据优先于猜测。

## 并行约束和交付规则

1. 只负责本文指定文件。先在本任务work目录写owned-scope.json，记录文件/成员、原Token/RVA、开始时SHA与所有已存在非空正文。其他文件仅只读；缺依赖写清单给主窗口，不顺手改。
2. 当前阶段把完整修复后的文件放到本任务work目录的candidate/，保持相对工程路径。不要直接写共享工程Assets/Packages/ProjectSettings；主窗口按source-before SHA统一应用候选。这不需要再向用户确认，你要把候选、验证和可执行apply脚本真正做完。应用脚本必须检查起始SHA，遇到源已变更就拒绝覆盖。
3. 不开Unity/Hub/PlayMode，不终止其他进程，不打开或写共享`work/ida-framework-assets/framework.i64`，不使用其他窗口的IDA数据库。本文会提供专属IDA快照和独立导出driver；所有log/status/ASM/伪C放本任务目录。
4. 精确核对instance/static ABI、结构体传值、真实泛型实例、原字段和函数起止。IDA会吞并相邻方法，导出后核实际start/end；JUMPOUT必须检查ASM/outlined islands。保护现有已恢复方法、字段、Token、GUID、.meta，禁止用空回调、假ready、假登录/SDK/server成功或删除原等待来推进。
5. 先保留原空方法负对照或最小失败用例，再从实际候选重提取正文做有意义的边界/调用顺序验证；能执行原ARM64 oracle时优先使用。不要复制一份业务实现当测试。使用既有Unity引用进行必要独立csc验证；区分独立测试与真实Unity运行，后者由主窗口执行。
6. 每阶段形成中文报告，说明原理、证据、失败和修复、原生与候选对应、已验证层级、未恢复依赖。报告存到outputs/恢复过程文档，编号使用本文分配的编号；证据只放对应子目录，不改00导航或其他编号报告。
7. 交付handoff.json：state=ready_for_integration，owned文件，source-before与candidate SHA256，逐方法恢复清单，编译/测试命令与结果，apply脚本绝对路径，仍未闭合依赖。主窗口会从work/parallel-coordination读取。报告不能宣称总目标已完成。完成一批后可在本范围继续下一批，并始终保留可集成的稳定版本。
8. 请在回复中返回当前新窗口threadId（若工具能够读取）以及handoff路径，方便用户与主窗口协调；不要新建更多任务窗口。若IDA不可用，继续原ARM64静态分析和证据准备，明确限制，不改授权文件。

## 本窗口的具体任务

恢复 GameFrameEntry 后继的原 FsmManager 初始化/更新、Fsm<T>创建/开始/状态切换/销毁和 ProcedureManager.Initialize/Register/StartProcedure 链。目标是让已恢复的原 ProcedurePreLoad 与 ProcedureStarGame 能由原框架进入并按原生命周期执行。先从现有调用点找最小闭包，按精确泛型实例和原native恢复；原Update、状态退出/进入顺序、重复状态、空owner、异常和重入契约均需核实。不要直接调用某Procedure代替状态机，不要跳过等待或把泛型ChangeState写成空壳。可以参考上游公开框架，但只有与本APK原字段、Token/RVA和调用语义匹配的部分才能计为恢复。

## 独占候选范围

- `Assets/Scripts/GFRunning/GameFramework/Fsm/`
- `Assets/Scripts/GFRunning/GameFramework/Procedure/ProcedureManager.cs`
- `Assets/Scripts/GFRunning/GameFramework/Procedure/ProcedureBase.cs`

## 现有任务证据

第20篇与work/procedure-recovery已恢复原ProcedurePreLoad/StarGame，包括TryLogin Token0x06005BBF/RVA0x439FEE0及PreLoadAsync启动后立即原ChangeState的顺序。不可改这些已恢复业务Procedure文件，也不可改GameStartEntry/IGameStart/ljzs_lt.GameStart。ProcedureManager.Initialize RVA0x727AA18，Register0x727AA3C，StartProcedure(Type)0x727AE9C；FsmManager ctor0x7296BD0、Update0x7296D08。保留原接口和程序集身份，禁止改官方analyzer/source generator来掩盖问题。

## 本窗口专用路径

- 工作目录：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-42-fsm`
- 已准备独立IDA数据库：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-42-fsm\ida\framework.i64`（关闭共享库后复制的946MB快照；只操作这一份）
- 独立导出driver：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-42-fsm\ida\analyze_supplement.py`；把本批精确name/address/end/prototype写入同目录targets-supplement.json后，在本目录数据库运行。driver已有函数边界核查。
- 候选：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-42-fsm\candidate`
- 最终handoff：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-coordination\stage42-handoff.json`
- 本任务报告：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\outputs\恢复过程文档\42-原流程状态机与Procedure.md`

无需再次确认，开始核实证据并实施本范围候选恢复。
