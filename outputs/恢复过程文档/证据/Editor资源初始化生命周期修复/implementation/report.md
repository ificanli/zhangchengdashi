# 第39阶段 Editor资源初始化生命周期窄修候选

候选只在work，生产写入0，原10冻结源哈希变化0。尚未授权应用，也未运行Unity。候选为Provider、Bridge和新增Play会话辅助共3文件。

先对当前生产真实正文执行2个回归：yield后Dispose仍占用lease、Guard未释放活跃内层；2项均按预期失败。随后对work候选正文重提取：24场景/90检查/0失败。覆盖hash等待、部分加载、成功、实际资源异常、保存收据失败、精确owner/重复取消、取消后恢复、nested正常/异常/Dispose异常、共享与private隔离、会话边界和domain reload限制。保存了取消主异常与Dispose次异常顺序的失败样例及修复后结果。

以当前Unity官方rsp、真实引用和Roslyn分别编译完整GFRunning与LocalResources.Editor，均exit0/error0，未覆盖Library程序集、未启动Unity。

Provider以唯一lease托管Initialize；所有yield均在finally覆盖之下。外部Dispose/精确会话取消写cancelled_editor_session、ready=false、结束时间和原因，清自身lease并dispose实际I/O迭代器。实际资源异常仍sticky，取消不会转换成成功。正常成功仍由原InitializeCore在真实数据与收据保存后才设IsReady；原Version/Resources/UIModule flags及callback未触碰。

每runId新增独立收据路径。旧取消会话只更新自身runId收据，不覆盖已属于更新private Probe的canonical收据。Bridge.Initialize固定其Provider身份并finally Dispose；Guard按栈释放全部nested迭代器，保留首个实际异常并将清理次异常附加记录。

新增Editor会话辅助只操作共享Bridge.Provider。退出Play/assembly reload取消属于Play的活跃lease；正常reload会话入口明确新实例。private Probe仍私有。禁用domain reload时只记录精确不支持诊断，不清原框架静态模块/缓存/ready来绕行。此范围不能承诺原框架无domain reload重进已支持。

已静态审计原InitializeCore实际资源业务（扣除新增收据元数据）、LoadAsset/RecordInstance/registry身份/locator/OriginalManifestEditorServices和GF资源实例化/loader业务均保持原正文。编译/夹具不替代真实Unity取消与后续Main验证；待root授权应用后再做GUI验收。

完整scope、diff、source-before、candidate、provenance、失败负对照、候选24场景结果、真实编译rsp/log/result均在本目录。稳定交接为work/parallel-coordination/stage39-lifecycle-handoff.json。
