# Stage42 独立验证记录

本目录只写验证工具、原空方法负对照、候选源码的逐字节夹具及结果，没有修改共享工程或候选。未启动、停止或控制 Unity，未打开或写入任何 IDA 数据库。

现有全部 6 个候选源通过原 GFRunning 响应文件的独立 Unity csc 编译，exitCode=0、errorCount=0。保留响应文件的原引用、define、analyzer 和 source generator，仅替换候选源路径、输出路径和 generatedfilesout。编译结果在 `unity-csc/result.json`，6 个候选文件 SHA 在其中；这是程序集静态编译验收，不代表 Unity 实际场景或玩法验收。

CLR 生命周期验证直接编译原空方法源或候选文件的逐字节副本，没有复制 FSM / Procedure 的业务算法作为被测实现。最终版本 52 项：原空方法负对照 52 failed / 0 passed；实际候选 52 passed / 0 failed。初版 36 项结果保存为两模式目录下 `results-v1-36.json`，初版测试源码保存为 `Program-v1-36.cs.txt`。每次运行产生 `source-provenance.json` 和 `harness-provenance.json`，可以核对当次源码与夹具哈希相同、测试工具身份相同。

52 项覆盖：构造的 owner / states / null状态 / 重复状态、逐个 OnInit 时状态已加入集合、属性与命名、两类 Start / ChangeState 桥、null与空数组不走带参 OnEnter、非空参数数组身份、两个基类 OnEnter 独立且不互相转发、Scaled time 在 OnUpdate 前累加且保留真实delta、重复Start、未知状态、null Type 原NullReferenceException、同状态 Leave/Enter、进入与退出时同步重入、Leave/Enter异常后的真实current/time、Shutdown顺序与storage清空、Shutdown Leave/Destroy异常时字段保留、数据/事件、Foreign IFsm 的 InvalidCastException、manager 实时列表自删跳过后继/新增同帧更新、ready先写后callback、Procedure Initialize独立于Register、Register/Start/State桥和Fsm唯一更新、未Register的8个API、重复Register重取manager但异常后保留旧fsm、ProcedureShutdown异常保留fields及ready。

夹具对 `Utility.Text.GetFullName`、`GameFrameEntry.GetModule`、`CLog.LogProcedure` 使用明确的边界适配。键公式来自原本批原生证据：空name为`typeof(T).FullName`，非空name为`type.FullName + "." + name`。外部模块取得和日志只记录边界调用，不宣称其生产实现已闭合。

另一个独立可执行程序 `ProductionDependencyProbe.cs` 完全没有引用 BoundaryAdapters 或 FSM 夹具。它加载上述刚编译的完整生产 `GFRunning.Stage42.dll`，反射调用真实生产 Utility.Text.GetFullName<object>("blocked")，实读返回 null；再调用真实生产 FsmManager.CreateFsm<object>，实际抛出 `System.ArgumentNullException`，ParamName=`key`。这发生在空 states 数组的构造校验之前，证明当前生产键生成器仍阻断状态机创建。结果在 `unity-csc/production-dependency-negative.json`。没有以边界适配的通过结果掩盖这个生产缺口。

复跑命令（工程根目录不影响脚本工作）：

```powershell
pwsh -NoLogo -NoProfile -File 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-42-fsm\validation-research\run-validation.ps1' -Mode baseline
pwsh -NoLogo -NoProfile -File 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-42-fsm\validation-research\run-validation.ps1' -Mode candidate
pwsh -NoLogo -NoProfile -File 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-42-fsm\validation-research\compile-candidate.ps1'
pwsh -NoLogo -NoProfile -File 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-42-fsm\validation-research\run-production-dependency-probe.ps1'
```

负对照的退出码1是预期结果；后3个命令本次退出码为0。CLR使用已安装 .NET SDK 10.0.103。独立生产csc使用 Unity 2022.3.62f3c1 的 `Editor/Data/NetCoreRuntime/dotnet.exe` 与 `Editor/Data/DotNetSdkRoslyn/csc.dll`。Unity自带 `Editor/Data/MonoBleedingEdge/bin/mono.exe` 也存在，但这轮 CLR 生命周期夹具使用 .NET 10，没有以 Mono 或 Unity Editor 已执行来表述。

ARM64 oracle 已由本任务其他 agent 在 `../native-oracle` 独立处理，本验证子任务没有重复执行。研究确认现有 `work/tools/unicorn-recovery` 提供 Unicorn 2.1.4；所给 idapromcp Python 默认 site-packages 没有 unicorn，需要工具脚本显式加入该目录，不能仅 `import unicorn` 就推断可用性。所有 CLR 结果仍与 native / Unity 运行层级明确区分。
