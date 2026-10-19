# Stage42 Procedure 子任务研究与候选

本子任务只写了 candidate 下的 ProcedureBase.cs 与 ProcedureManager.cs，以及本 research-procedure 目录。未改共享工程、未开启 Unity 或 IDA、未操作共享数据库。父任务提供的独立 IDA 导出用于 native 对照。

## 已恢复成员与依据

ProcedureBase 的 Token 0x06006A22 至 0x06006A27 共 6 个成员：OnInit/OnEnter/OnUpdate/OnLeave/OnDestroy 的 base 转发，以及构造函数的隐式 FsmState<IProcedureManager> 基构造。OnEnter/OnLeave 在 base 调用以后，以 GetType().FullName 拼接原字符串，再调用 CLog.LogProcedure。字符串来自 script.json 的 0x8D5F378、0x8D65E40、0x8D519A8；FullName 由 dump.cs:312155–312156 的 Type slot29 和 ASM 的 0x308 vtable 偏移交叉核实。

ProcedureManager 的 Token 0x06006A28 至 0x06006A37 共 16 个成员：

- 构造将两个字段置空；基构造由 C# 隐式执行。
- Initialize 将继承的完成字段置 true 后调用原保存回调；没有在此取得 FsmManager，也没有建立状态机。该位置的完成语义为模块自身初始化完成，并不表示后续业务 Procedure 已执行。
- Register 从原 GameFrameEntry 取得 FsmManager；null 时抛原异常；以 this 为 IProcedureManager owner 和传入 ProcedureBase[] 建立原泛型 FSM。
- Priority 为 90。
- Start 和 Update 的原 native 各只有一条 RET，候选保留空操作。状态更新由 FsmManager 执行，ProcedureManager 不再额外更新一次。
- CurrentProcedure/Time 和两类 Start/Has/Get 入口首先要求 m_ProcedureFsm 非空，随后直接转发到原 IFsm<IProcedureManager> API。Start 使用 Array.Empty<object>。没有额外自动初始化、自动注册或自动切换逻辑。
- Shutdown 在 manager 非空时，先销毁非空的 Procedure FSM，再依次清 FSM 字段、manager 字段，最后清完成字段。Destroy 抛异常时后续赋值不会执行；manager 已空时仅清完成字段。
- 私有 GetProceduresType 保留 Assembly.Load("Assembly-CSharp") 的原程序集身份、GetTypes、GetCustomAttributes(typeof(ProcedureTypeAttribute), false)、显式强转 ProcedureTypeAttribute[]、取第一属性 ProcedureType 的原规则。它没有参与当前 ljzs_lt.GameStart 的显式 Register 链。

## 当前生产调用链

GameStartEntry._0082_00BBf_0090_00B8_005D 先初始化 FsmManager，之后初始化 ProcedureManager 并保存 J_009DK_0099M_00AC 回调。ProcedureManager.Initialize 调回后，该回调调用 GameFrameEntry.Start，后续进入 patch/config 等原链。进游戏前，GameStartEntry.ª_008C_0098_00ABV_005E 先通过 IGameStart.RegisterProcedure 调用 ljzs_lt.GameStart.RegisterProcedure 注册 PreLoad/StarGame/ExitGame，后经 StartGame 才 StartProcedure<ProcedurePreLoad>。

既有 ProcedurePreLoad.OnInit 与 ProcedureStarGame.OnInit 依赖真正的 Fsm OnInit 保存 owner；PreLoad.OnEnter 经 PreLoad 启动 async void 后立即 ChangeState<ProcedureStarGame>。状态机必须允许进入 PreLoad 的 OnEnter 中同步再切状态，并正确先 Leave，再 Enter；不能等登录完成才切换。该行为已由第20篇原生/CLR证据核实，本子任务没有改两个业务 Procedure。

## 检查结果与界限

verify_procedure.py 已从最终候选重新读取正文并检查：两共享源仍与 source-before 逐字节相同；22 个目标成员以外的全文完全一致；全部属性字面值完全一致；Start/Update 的原汇编各为单 RET；Initialize 原汇编先写完成字段再调回。结果保存在 structural-verification.json。

review_jumpouts.py 逐项检查了 8 个 Procedure JUMPOUT：精确起止与 metadata 一致，末指令均为 end-4，所有局部直接分支目标都在原方法内部。正常接口调用出口与异常构造/类型转换失败出口均分别记录；没有遗漏需要继续跟踪的 outlined island。完整说明在 jumpout-review.json。本结果是静态范围和控制流检查；不代表已经运行原 ARM64 或 Unity。

建议父任务在实际候选夹具中覆盖：Initialize 回调观察到完成字段 true；未 Register 时八个查询/启动入口均抛原异常类型；重复 Register 延用 FsmManager 的重复 owner/name 规则；Start/Update 不重复触发状态更新；原保存 owner 接通；PreLoad 同步 OnEnter→ChangeState 重入顺序；Shutdown 成功清理与 Destroy 异常传播；manager-null/FSM-nonnull 的异常人工状态保持原行为。

## 范围外依赖

CLog.LogProcedure 仍是范围外空正文，所以调用恢复不等于日志可见。GameFrameworkException(string) 构造仍为空，因此生产异常类型可抛，但原 Message 是否正确尚需恢复其原基构造调用。ProcedureTypeAttribute(Type) 构造仍为空；若未来启用私有反射发现入口，属性字段生产必须另恢复。当前显式 Register 路径没有使用该属性。

业务后继依赖仍包括原资源/SDK 登录、TimeModule 循环 Timer、MsgDispatcher、原 scene Addressables 与 GameManager/地图/战斗等；本子任务不宣称这些生产链已在 Unity 中执行。
