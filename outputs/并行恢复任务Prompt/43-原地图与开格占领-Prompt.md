# 并行任务43：原地图与开格占领

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

恢复原地图的格子坐标/邻接/索引、原初始化与生成、原OpenHex/DetermineHexCamp及开格或占领所必需的数据变更和资源调用。先列原GameManager/GameLauncher到这3文件的真实调用链及最小闭包，然后分批恢复可核实原方法。保留费用、阵营、可开条件、占领时序、生成数量、异步等待与原事件语义；不得新造一张可点击简化地图或硬编码测试布局来代替原玩法。资源/单位外部依赖尚未恢复时，提供明确未闭合清单和边界测试，不假称玩法可运行。

## 独占候选范围

- `Assets/Scripts/Assembly-CSharp/HexManager.cs`
- `Assets/Scripts/Assembly-CSharp/GameModule/HexBehaviour.cs`
- `Assets/Scripts/Assembly-CSharp/GameModule/GenerateHexBehaviour.cs`

## 现有任务证据

HexManager位于Assembly-CSharp根目录，不在GameModule中。原HexDistance RVA0x3D2A600已恢复，1137组原ARM64输入验证；必须保留其int32回绕语义及现有所有已恢复访问器。读取第09/22/29篇及work/recovered-rule-tests、work/il-recovery。HexBehaviour.OpenHex RVA0x4424D5C、DetermineHexCamp0x44298EC有最初native材料可复用，但必须核对精确边界与this ABI。BattleGameSceneManager属于44号窗口，不可改；MapCreateDataManager、GlobalInfo、DataManager、GameManager也不属于本窗口。

## 本窗口专用路径

- 工作目录：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-43-hex`
- 已准备独立IDA数据库：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-43-hex\ida\framework.i64`（关闭共享库后复制的946MB快照；只操作这一份）
- 独立导出driver：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-43-hex\ida\analyze_supplement.py`；把本批精确name/address/end/prototype写入同目录targets-supplement.json后，在本目录数据库运行。driver已有函数边界核查。
- 候选：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-43-hex\candidate`
- 最终handoff：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-coordination\stage43-handoff.json`
- 本任务报告：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\outputs\恢复过程文档\43-原地图与开格占领.md`

无需再次确认，开始核实证据并实施本范围候选恢复。
