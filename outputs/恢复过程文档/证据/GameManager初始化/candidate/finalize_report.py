from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
path=ROOT/'outputs/恢复过程文档/29-GameManager原始初始化恢复.md'
text=path.read_text(encoding='utf-8')
changes={
'状态：**16 个原业务方法、10 段原 lambda 和原 UpdateController 字段初始化器的完整候选已准备并验证；当前仍保存在 work，尚未写回 Unity 工程。**主流程正在验证已正式导入的工程，并安排时间生产者恢复；本阶段按协调要求保持 GameManager.cs 原样，避免提前接回原网络协程的前置紧循环。':'状态：**16 个原业务方法、10 段原 lambda 和原 UpdateController 字段初始化器已窄写回实际 GameManager.cs；实际源码与已验证候选逐字节一致，实际源重编、控制流复测及 IL 读回通过。**主流程在第 33 阶段时间生产者落盘后解除本文件冻结；网络协程的原前置紧循环没有添加 yield、跳过条件或伪造完成标志。',
'候选完整源码独立编译 0 错误；适配控制流测试 30 场景 / 227 检查通过':'实际完整源码独立编译 0 错误；从实际源码提取的适配控制流测试 30 场景 / 227 检查通过',
'## 1. 单文件范围和当前保存位置':'## 1. 单文件范围和实际写回位置',
'唯一拟写业务文件为':'唯一修改业务文件为',
'- 当前工程源 SHA-256：':'- 变更前工程源 SHA-256：',
'- 候选 SHA-256：':'- 候选及实际恢复源 SHA-256：',
'完成统一整合后需要改为实际源码路径再编译、读回、复测并更新本报告状态。不能把候选的验证数字直接写成工程已应用结果。':'实际源码已经按候选窄应用，并以 `-p:Actual=true` 独立重编。夹具重新从工程实际文件提取正文，30 场景 / 227 检查重新通过；实际编译 IL 已导出至 actual.il.txt 并通过 final-audit.json。上述状态只表示源码和独立验证完成，Unity 统一导入和实际核心场景验收由主流程继续负责。',
'当前 TimeManager 的真实初始化生产者尚未恢复。如果直接接回本 Init 末尾的 StartCoroutine，可能因这个原前置缺失卡住 Unity 主线程。因此保持候选尚未写回，等待时间生产者的真实恢复。不能通过给协程补 yield、超时后继续、跳过检查或替别的 Manager 写 flag 来制造启动完成。':'初次准备候选时 TimeManager 的真实初始化生产者尚未恢复，因此本文件曾保持冻结。主流程随后完成第 33 阶段时间生产者的源码稳定点，明确允许接入，才写回本阶段候选。当前仍保留 Init / Time / Data 三个真实前置；GameLauncher / LoadingManager 需要真实 Data 完成后才会调用核心 Init。不能通过给协程补 yield、超时后继续、跳过检查或替别的 Manager 写 flag 来制造启动完成，本批未作这些修改。',
'原 CheckNetworkState 在 this':'原 CheckNetworkState 在 this',
'| 候选完整 GameManager.cs，netstandard2.1':'| 实际完整 GameManager.cs，netstandard2.1',
'| 候选正文提取的 Task / Unity 依赖适配夹具 |':'| 实际源码正文提取的 Task / Unity 依赖适配夹具 |',
'| 工程源码 / .meta | **工程源码尚未改，meta未变；候选Token序列保留** | 当前仍为等待统一整合的候选 |':'| 工程源码 / .meta | **已写回并与候选逐字节一致；meta未变，原Token序列保留** | 实际工程源与既有候选对应 |',
'| 实际源码写回读回、Unity 编译、场景、视觉与原地图/开格/战斗验收 | **not-run** | 未把控制流或候选编译当成游戏运行 |':'| 实际源码写回读回 | **通过** | 实际源与候选 SHA-256 一致，实际编译和测试已重跑 |\n| 本阶段 Unity 编译、场景、视觉与原地图/开格/战斗验收 | **not-run** | 统一导入和 Play 由主流程后继负责，未把独立结果当成游戏运行 |',
'夹具从当前候选的完整 16 个正文提取':'夹具已重新从实际工程源的完整 16 个正文提取',
'候选整合前至少需要 TimeManager.Init / InitializeTimeSource / initComplete 的生产链和 Timer.Key / StartTime / TargetEndTime / GetTimer / CreateTimer / Restart 的真实行为。后继已将精确入口交主流程：Init `0x3E451B4`、MoveNext `0x3F6EA3C`；时间源 MoveNext `0x3F6F450`；构造 `0x3E46E8C`。日期和存档门不能通过默认值完成。':'本文件曾以 TimeManager.Init / InitializeTimeSource / initComplete 的原生产链和 Timer 真实行为作为整合前置。主流程第 33 阶段已经落盘时间生产者后授权写回；但实际 Data / Loading / 存档计时消费门仍必须由后继真实流程产生，不能用默认值完成。原时间入口仍可追溯：Init `0x3E451B4`、MoveNext `0x3F6EA3C`；时间源 MoveNext `0x3F6F450`；构造 `0x3E46E8C`。',
'当前候选复现：':'实际工程源复现：',
'dotnet build work/gamemanager-recovery/compile/GameManagerCompile.csproj -c Release':'dotnet build work/gamemanager-recovery/compile/GameManagerCompile.csproj -c Release -p:Actual=true',
'work/gamemanager-recovery/make_fixture.py --candidate':'work/gamemanager-recovery/make_fixture.py',
'work/gamemanager-recovery/audit.py\n':'work/gamemanager-recovery/audit.py --actual\n',
'候选源码、实际前态、meta、窄 diff':'候选及实际后态源码、实际前态、meta、窄 diff',
'与 candidate-audit.json 已归档':'与 candidate-audit.json / final-audit.json 已归档',
}
for old,new in changes.items():
    if old==new:continue
    assert old in text,old
    text=text.replace(old,new)
path.write_text(text,encoding='utf-8')
print('report 29 updated to actual-source state')
