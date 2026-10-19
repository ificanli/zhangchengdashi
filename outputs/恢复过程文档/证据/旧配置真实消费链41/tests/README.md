# stage41 真实源码独立配置闭包验证

执行 `pwsh -File .\run_all.ps1`。脚本生成并运行三个独立 .NET 10 项目，保存每组完整源码输入 SHA、编译运行 log、JSON 结果与汇总；执行前后再次核对源码 SHA，遇到父任务并行改动就失败并重跑。代码与生成目录全部在本任务 work 下；没有启动 Unity，没有写共享 Assets。

| 模式 | 源码输入 | 预期与本轮结果 |
|---|---|---|
| baseline | source-before 的 3 个 owned 文件 + 当前真实 41 行类 | 单例为 null、reader 空体、object 返回 null，45 项负对照通过 |
| candidate-current-getters | candidate 的 3 个文件原样 + 当前真实 41 行类 | 首表 GoalRewardConfig 因当前 UniqueID 返回 null 而抛 ArgumentNullException，ready=false、读取完成计数0，50 项失败行为断言通过 |
| candidate-fixture-getters | candidate 的 3 个文件原样 + 38 个仅改 UniqueID.get 的测试行类副本 + 3 个原样对象类 | 830 项断言通过；38 表927行、7424字段值、930解析对象身份、9个pool分组的51个原行引用均对应 |

每组 `.csproj` 显式 `Compile Include` 实际 ConfigMgr.cs、ConfigRead.cs、BaseConfig.cs 与 41 类；没有从它们复制业务实现。还直接包含原 ConfigType.cs 与 UnSerialization.cs。`BoundaryAdapters.cs` 仅提供 Il2Cpp/MemoryPack 声明以及受控 Unity Object/TextAsset、资源 provider、JsonUtility、YooAsset handle 与 AppSetting/CLog 边界。fixture 模式由原 ARM64 getter 字段偏移导出的 `return <原字段>;` 替换测试副本中38处 `return null;`，不会改写生产类，也不会作为三文件候选的一部分应用。

`Program.cs` 从原交付 bytes 重新读取并核 SHA，逐表核对原 JSON 及字典 boxed Int32 key、每行每字段；保存 parser 返回的实际行实例，并与 ConfigMgr 字典值及 pool 分组值进行 ReferenceEquals 身份比较。三个对象同样比较字段及 parser 对象身份，不能用新 GlobalInfo 的检查替代。

边界断言覆盖原字典不 Clear、重复新键保留先行、重复既有键保留既有实例、空/null Datas 保留源字典、缺 TextAsset 记录后增加计数、解析/资源异常不增加计数、非 JSON 前缀截到第一个花括号、无花括号保留 Substring 失败、null row/null source 行为、新资源同步 handle 先 Release 后解析、WebGL map 的可读/错误类型/null 情况、旧资源 provider 为 null、customRead 清理旧组并跳过空行与非正 pool_id，以及 Initialize 在第7张表资源失败时保留前6表结果并保持 ready=false。

JSON 解码使用 System.Text.Json 的字段解析 adapter；malformed 情况出现的 JsonException 是这个 adapter 的异常类型。本验证只证明候选不会吞解析异常/提前增加计数，未证明 Unity JsonUtility 的具体异常类型或真实 Unity 运行结果。原 Unity provider、Unity JsonUtility 与 Editor 启动验收仍由主任务执行。原生 getter 的38文件/Token/RVA/ASM/字段与起始SHA见 `../evidence/resource-audit/row-getter-dependencies.json`，属于已证实但超出本批三文件生产范围的依赖。

本轮一次 harness 自身失败已排除：资源异常用例在注入 provider throw 前先用 null 构造测试 TextAsset，触发 adapter 的 Encoding.GetBytes 参数异常；现改为该用例构造空字符串 asset 后由 provider 明确抛指定异常。该修复只改测试输入，候选代码未变。
