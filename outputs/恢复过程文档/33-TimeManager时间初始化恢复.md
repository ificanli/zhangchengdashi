# 33｜TimeManager时间初始化恢复

本阶段恢复原 TimeManager 的初始化、时间源选择、服务器同步等待和计时器加载链。GameManager 原流程会等待 TimeManager.initComplete；这里修复该标志的真实生产流程，保留原有数据和 LoadingManager 等待条件。

实现范围是原 `Assets/Scripts/Assembly-CSharp/TimeModuleO/TimeManager.cs`（包含嵌套 Timer）与所需的原 `L_Tools/DateTools.cs`。共恢复 **41 个原方法正文、1 个遗漏原静态构造器、3 个原自动属性**。另在时间源选择入口加入明确的 **LocalEditor provider 适配**，使用原 LocalTime 分支的真实系统时钟。

候选验证后已在主任务解冻窗口完成两文件生产写入；写入前校验原源码哈希，写入后校验与候选完全相同，两份 meta 哈希保持不变。两文件随后冻结。实际 Unity 导入和运行由主任务统一验证；本报告中的独立 C# 编译和 CLR 边界验证不代表原游戏核心玩法已经运行通过。

## 原初始化顺序与完成语义

原方法 Token `0x060004B4` / wrapper RVA `0x3E451B4` 的业务流程位于原 `Init.MoveNext`，Token `0x0600050F` / RVA `0x3F6EA3C`。恢复的顺序为：

1. 创建普通计时器字典、结束回调字典、结束回调计时器字典和待删除 key 列表。
2. 等待 InitializeTimeSource 选择时间源。
3. 调用 SyncServerTime，启动 LoadTimers 协程。
4. 读取偏好 `OffsetHours`，默认 0。
5. 在原偏移 `0x70` 的对应逻辑位置写 `initComplete = true`。
6. 若选择 NetworkTime，继续等待真实 IsNetworkConnected；每次等待 0.1 秒，每 100 次显示原提示“服务器时间同步异常”。连接成功后输出原成功日志。
7. 再等待 0.1 秒，调用 HandleTimeToWeekCutDown 后完成 Init。

因此原 initComplete 表示初始化已经到达第 5 步，并不表示网络同步和计时器加载已经全部完成。没有把该标志提前写到函数入口，也没有改变 GameManager 的等待逻辑。

高层 async 与 iterator 正文恢复后，移除原导出占位的 AsyncStateMachine／IteratorStateMachine 指向，由 C# 编译器为恢复正文生成可执行状态机。旧导出嵌套状态机声明保持存档状态，其空 MoveNext 不计入正文恢复数量。

## 原时间源选择与 LocalEditor 适配

原 InitializeTimeSource Token `0x060004B6`，状态机业务 RVA `0x3F6F450`。原隐藏 predicate Token `0x060004FA` / RVA `0x3F6E3C0` 调用 `DBTSDK.AppInfoManager.Instance.IsOnlineParamReady_Override()`。原流程等待该 predicate，使用 `TimeoutWithoutException(TimeSpan.FromSeconds(10))`。

官方 UniTask 对该 API 的 bool 语义也已核对：true 表示超时等未正常完成的结果。原 true 分支选择 NetworkTime；正常完成时才查询 `OnlineParamControl.GetOnlineParam("UseLocalTime", "")`，仅精确字符串 `"1"` 选择 LocalTime。恢复保留该 APK／非 Editor 路径。

Editor 入口使用 `#if UNITY_EDITOR` 与 `Application.isEditor` 选择原枚举 `TimeSource.LocalTime`，并输出：

```text
[TimeManager] Time source: LocalEditor (original LocalTime provider)
```

**这是明确标记的 Editor 运行适配，不是原 APK 中恢复出的判断。** 适配本身只选择时间源和记录日志；它不写 ServerTimeMgr.UpdateFinish、DateTools 的缓存或 UseLocalTime，不写 initComplete 或 IsNetworkConnected。IsNetworkConnected 由原 SyncServerTimeCoroutine 的 LocalTime 分支设置；initComplete 由上述原 Init 顺序设置。

原 LocalTime getter 使用 DateTime.Now／DateTime.UtcNow，再加 OffsetHours。原 NetworkTime getter 读取 DateTools.GetNow／GetUTCNow，再加相同偏移。没有用本地时钟伪造服务器响应或缓存。

## 网络时间的真实外部生产边界

原 SyncServerTime Token `0x060004C7` / RVA `0x3E46080` 在不处于拉取状态时停止已有取时协程，再启动原同步协程。同步协程业务 RVA `0x3F70868`：

- LocalTime 分支直接执行原 IsNetworkConnected=true 并结束。
- NetworkTime 分支设置内部 fetching 状态，调用 ServerTimeMgr.I.TryCheck(true)。
- 持续检查真实 IsUpdateFinish；按 Time.deltaTime 累计，严格超过 3 秒才重试，每帧 yield null。
- 只有真实 IsUpdateFinish 成立才清 fetching、设置 IsNetworkConnected。

本阶段只读追踪了原外部生产者，未修改 ServerTimeMgr、HTTP、SDK 或其单例基础层：

| 原调用 | 原 RVA | 生产行为 |
| --- | --- | --- |
| ServerTimeMgr.TryCheck | 0x43B94E8 | 强制检查时进入 GetCurrentServerTime |
| GetCurrentServerTime | 0x43B96FC | 在允许检查时清完成标志，调用 HttpManager.RequestServerTime |
| ReceiveServerTime | 0x43B9970 | 将 args[0] 的 Int64 毫秒除 1000，更新秒时间和 DateTools，记录 realtimeSinceStartup，再设置完成标志 |
| UpdateCheck | 0x43B9574 | 周期更新当前服务器时间缓存 |
| GetServerTime | 0x43B965C | 按最后服务器秒、最后游戏时间、realtimeSinceStartup 和 HourOffset 计算 |
| InitAfterLogin | 0x43B90A8 | 初始化时间及更新／服务器消息／UnityAgency 监听 |

这些外部服务的真实实现尚不属于本阶段闭环；现有 RichControlBase<ServerTimeMgr>.I、在线参数和 HTTP 链仍可能阻止 APK 网络分支完成。没有为了宣称可运行而把它们替换为成功结果。

## DateTools 原缓存语义

原静态构造器在导出源码中遗漏，原 metadata 确认 Token `0x06005E26` / RVA `0x43FA7E4`。已恢复：

- StartTime = 1970-01-01 08:00:00，DateTimeKind.Utc。
- StartTime_UTC = 1970-01-01 00:00:00，DateTimeKind.Utc。
- UseLocalTime = true。
- m_Now、m_UTCNow 保留默认值，等待真实生产者更新。

原 UpdateTime（Token `0x06005E10` / RVA `0x43F96E4`）将 UseLocalTime 清为 false，把秒时间戳转换为 UTC 和本地缓存；StampToDatetime（Token `0x06005E19` / RVA `0x43F97D8`）根据参数使用 AddSeconds 或 AddMilliseconds。

GetNow 和 GetUTCNow 原 native 直接读偏移 0x18 与 0x20 的缓存，NowIsServerTime 返回 !UseLocalTime。这里保留该行为，未添加实时推算。实时推算属于上述 ServerTimeMgr.UpdateCheck 的外部职责。

## 计时器与加载等待

Timer 的 Key、StartTime、TargetEndTime 原 backing field 分别为 Token `0x040004F6/F7/F8`、原偏移 `0x10/0x18/0x20`。恢复为实际自动属性，保留原 property／accessor Token、RVA 和 CompilerGenerated 证据。前阶段已恢复的 IsNetworkConnected、OffsetHours、useStandardNetTime 保持逐字不变。

原 Timer 构造链按选定时间源产生 StartTime；倒计时将 duration 加到起点，非倒计时使用 DateTime.MaxValue。原 il2cpp.h 的 DateTime 静态字段布局确认 native 偏移 0x18 对应 MaxValue。恢复原数据对象构造器时，直接复制 TimeInfo 的 key、起点、终点及标准时间标志，不用当前时间覆盖记录。

GetTimer／CreateTimer 保留原字符串空白判断和重复 key 行为。Restart、InitAddTimeInfo 和 CreateTimer 的重复保存调用保留；创建普通计时器的原路径会保存 3 次。原 InitAddTimeInfo 新建 TimeInfo 时没有写 useStandardNetTime，本阶段也没有补写。ChangeTimeInfoEndTime 在存储字典为 null 时创建的局部字典原本不回填 Data，该细节保持。

LoadTimers wrapper Token `0x060004DA` / RVA `0x3E46B84`、业务 RVA `0x3F6FAF4`，顺序为：

1. 等待 IsNetworkConnected。
2. 等待 DataManager.Instance.LoadDataCompleted。
3. 根据原 playerTimeInfoConverted 标志读取已保存记录，或执行原迁移标志保存及现有计时器写入。
4. 等待 **LoadingModule.LoadingManager.Instance.IsLoadingCompleted**，不是 UIManager 的其他标志。
5. 初始化本地零点、UTC 零点及周一计时器，停止旧 watcher，启动 3 个实际检查协程。

三个 watcher 都先 yield new WaitForSeconds(1f)，再检查并重复等待 1 秒。没有改成每帧轮询。零点、周一、结束回调和跨周检查按已导出的 native 恢复；结束回调只删除回调跟踪字典，保留普通计时器和存储记录。其他未分析的格式化、焦点／暂停、删除和注册变体等方法仍是原导出未恢复占位，不计为本阶段完成。

## 验证与交付边界

| 验证项 | 结果 |
| --- | --- |
| 原 metadata、native C／ARM64、字符串和 MethodInfo 对照 | 已核对，5 个有界批次状态 complete |
| 定点候选源码 | TimeManager 36 个正文、DateTools 5 个正文、1 个原 cctor、3 个自动属性 |
| 非目标成员不变 | TimeManager 139 个、DateTools 23 个源成员逐字不变 |
| 生产文件写入及 meta/GUID | 已完成，实际源码哈希与验证候选一致，2 份 meta 哈希不变 |
| 真实 Unity rsp 独立全主程序集 C# 编译 | candidate1：exitCode=0、errors=0，实际输出 DLL 6,652,928 字节 |
| Editor CLR／task／协程边界 | 40 项通过 |
| APK 条件编译 CLR／task／协程边界 | 45 项通过 |
| 本阶段 Unity 启动、ILPP、真实场景运行 | 未执行，由主流程统一验收 |
| 原网络服务、完整计时器功能、原核心玩法验收 | 未完成 |

边界 fixture 从真实候选源码提取 TimeManager／Timer 与 DateTools，剥除 metadata 属性和旧导出状态机声明，保留恢复正文，再用受控 Unity／UniTask／持久化边界对象验证。它覆盖 LocalEditor 选择与标志不被适配写入、原 APK 超时／精确参数选择、Init 标志顺序、网络未就绪与重试、三个独立加载 gate、存储恢复、日／周边界、回调清理及 watcher 首次等待。fixture 中的服务器完成输入仅用于模拟外部响应，不进入生产源。

实际 API 兼容性由另一次使用 Unity 原主程序集 rsp、原引用／define／analyzer 的独立编译验证。仅把两个源路径替换为 work 候选，并将 DLL／生成文件输出到 work；没有启动 Unity，没有写 Library 编译输出。两层验证分别记录，不相互替代。

交付证据目录：`33-TimeManager时间初始化恢复-证据`。其中保留原文件、最终候选、写入计划、原身份清单、41 个方法原 Token／RVA 映射、完整 source verification、独立编译摘要、两种 fixture 的结果、原 native target／status 与所用 C／ARM64。生产写入时校验源文件和 meta 哈希，并把备份放在项目外 `work/recovery-stubs/stage33-time-before`。
