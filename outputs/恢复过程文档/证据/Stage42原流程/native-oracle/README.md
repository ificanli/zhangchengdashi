# Stage 42 原 ARM64 FSM 执行证据

执行根目录：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20`。本子任务只写入 `work/parallel-42-fsm/native-oracle`，未操作 Unity、IDA 数据库或共享工程源码。

验证命令：

```powershell
& 'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe' -X utf8 'work\parallel-42-fsm\native-oracle\native_oracle.py'
```

实测进程退出码 `0`，输出 `Original ARM64 executions: 43 passed`。逐条轨迹、原 ELF SHA256、逐方法原指令 SHA256 在 `native-results.json`；测试脚本为 `native_oracle.py`。原 ELF 的 SHA256 为 `72770d00b2b404acf44cc75cc8bf7a3e06850e9ace1237c9cbb2bc72894220ed`，与任务基线一致。

## 实际执行范围

从 ELF64 的 PT_LOAD 段解析 VA 与文件偏移，取原文件指令；未把 Python 业务实现当 oracle。以下原 FSM 代码及其实际 GetState 辅助方法都在 Unicorn 内执行：

| 方法 | 地址 | 验证关注点 |
|---|---:|---|
| `Fsm<object>..ctor` | `0x52A8890` | owner/states/null 元素/重复状态检查，逐项 Add→OnInit，末尾重置字段 |
| `Fsm<object>.Update` | `0x52A8BF0` | ABI `s0/s1`，float32 累加后再回调，无当前状态不累加 |
| `Fsm<object>.Shutdown` | `0x52A8C18` | Leave(true)→清 current/time→逐状态 Destroy→Dispose→清字典→destroyed=true |
| `Fsm<object>.Start(Type,args)` | `0x52A8DBC` | running 检查，GetState，写 current/time，再选择 OnEnter 重载 |
| `Fsm<object>.GetState(Type)` | `0x52A8F74` | Type.FullName→字典查找；Type==null 抛 NRE |
| `Fsm<object>.ChangeState(Type,args)` | `0x52A9308` | GetState→Leave(false)→写 current/time→OnEnter；允许同类型切换 |
| `FsmManager.Update` | `0x7296D08` | 每轮读实时 Count，先查 IsDestroyed 再原 Update，回调内增删列表 |

真实泛型共享实例是 APK 内的 `Fsm<object>`。管理器虚调用的 IsDestroyed getter、FSM IsRunning getter，以及其 Update 方法同样使用原指令。`nativeEntries` 记录各用例实际进入的原函数地址与次数。

## 43 条执行的结论

- Start 的 `null`、空数组都调用无参 `OnEnter(fsm)`，有至少一个元素时调用 `OnEnter(fsm,args)`；Change 同样处理参数。两者都先写 current/time，再进入目标状态。
- Start 已运行时抛原 `GameFrameworkException`；Start/Change 的目标缺失时抛原错误分支；`stateType==null` 进入原 NRE 分支。不存在成功兜底。
- Change 先查询目标，再调用旧状态 Leave(false)。Leave 观察到旧 current 和旧 time；Enter 观察到目标 current 和 time=0。同一类型也会 Leave→Enter。
- Update 累加使用 float32 的 `FADD S2,S2,S0`。初值 `16777216f` 加 `1f` 保持 `16777216f`，而回调收到的 elapse=1、realElapse=13.5。无 current 时原计时保留；负 delta 原样传递并参与累加。
- 单独设 destroyed=true、但保留 current/字典的隔离夹具下，直接 Fsm.Update 与 Start 不检查 destroyed。正常 manager.Update 会跳过 destroyed 项。此测试不代表完成 Shutdown 后还能找到已清掉的状态。
- Shutdown 的 Leave 在 current/time 清除前执行，参数 isShutdown=true。当前状态清除后再遍历各状态 Destroy；destroyed 标志在所有 Destroy、Dispose 和两次 Clear 完成后写 true。无 current 的隔离夹具中，旧 time 会保留。
- 原构造函数按数组顺序逐项登记并 OnInit。null owner/null states/空 states 在 OnInit 前失败；null 元素或重复项出现在第二位时，第一项的 OnInit 已经执行。候选应保留这种部分进度。
- manager.Update 回调中追加 D，会在该帧继续访问 D；删除当前 A 会跳过原 B，随后更新 C；清空列表后本帧结束；null 元素触发原 NRE。s0/s1 在各次回调间保持原值。
- Change 的 Enter(B) 回调中执行原 Change(C)，最终为 C，轨迹为 `A.Leave→B.Enter→B.Leave→C.Enter`。
- Change 的 Leave(A) 回调中执行原 Change(C)，嵌套返回后外层继续把 B 写入，轨迹为 `A.Leave→A.Leave→C.Enter→B.Enter`，最终为 B。
- Shutdown 的 Leave(A) 内执行原 Change(B) 后，外层继续清 current 并销毁全部状态；原框架没有重入锁或队列。
- 构造 OnInit(A) 中调用原 Start(A) 可以进入 A；构造函数结尾仍把 current/time 重置。这一轨迹为 `A.Init→A.Enter→B.Init→C.Init`，最终 current=null。

## 验证边界与不可外推项

以下边界由测试夹具提供，不计为恢复或原生库内部实现通过：IL2CPP 元数据解析、对象分配、反射的 GetType/FullName、Dictionary 操作与枚举器载荷、List 索引访问、虚回调的外部行为，以及 FsmBase 构造中的 name 写入。原 FSM 对这些边界的调用位置、调用参数、分支、循环、字段写入、float 运算仍由原指令决定。

重入用例并未复制 Python FSM：虚回调把 PC 和参数转入同一 ELF 的原 Start/Change 指令，返回时恢复调用方 CPU 上下文，保留原生对 FSM 内存的写入。

`CallbackAbort` 用例在回调边界停止 CPU，用于观察“回调开始执行时已经提交到哪一步”。这些用例确认 Leave 前未清 current/time，Enter 前已经清零并提交目标，以及 Destroy 前已清 current。**它们没有模拟 C++/managed exception unwinding，不能据此宣称 finally/枚举器异常 Dispose 已通过原生运行验证。** 真实 GameFrameworkException / NRE 用例执行到原 throw 边界后停止，错误消息来自 APK ScriptString 元数据；异常对象本身由外部 hook 构造。

本子任务只完成原生行为 oracle；未编译候选 C#，未对候选做等价验证，未启动 Unity，也未宣称原地图、开格或兵堆战斗已运行。父任务应从候选实际正文编译并对照相同用例，真实 Unity 接入仍由主窗口完成。
