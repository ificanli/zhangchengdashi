# 第39阶段补充：Editor资源初始化生命周期修复

已按主线程明确授权应用3个Editor adapter源文件。应用前全量SHA门核对通过，应用后生产源与批准候选逐字节一致；既有meta没有写入，新增会话辅助meta 1份。第39阶段原10个冻结源中只有本次批准的Provider/Bridge两份变化，其余8份哈希保持不变。

原flags/callback、原Version/Resources/UIModule完成顺序、私有Probe注册规则、原34清单/50旧TextAsset/5142 locator实际I/O业务均未扩大修改。本代理没有开关Unity3808，没有启动其他Unity实例。

## 问题依据与实际变更

Main5因真实CoreBlit渲染错误在frame1退出Play，原共享Provider处于实际初始化yield阶段；随后Probe1在同一实例报initialization is already in progress。当前正文没有覆盖yield的finally，Bridge自建nested栈也没有外部取消时的Dispose传播。此前私有Probe2真实完成资源验证且未改变共享Provider，这份结果属于独立资源服务验证，不替代原启动链。

Provider现在以owner/lease托管Initialize。正常成功仍只由真实InitializeCore在实际资源校验与收据保存后设置IsReady。外部Dispose或对应Play会话取消会释放占用、Dispose实际I/O迭代器、写cancelled_editor_session/ready=false/结束时间/原因，保留已完成校验数量；实际资源异常保持sticky。取消不调用原模块完成回调，也不写原ready。

每runId写入独立的RecoveryReports/LocalResourcesSessions收据。旧会话取消只更新自己的runId收据，不覆盖已经属于新私有Probe的canonical收据。清理次异常附加到原异常与收据，不冒充成功或掩盖首个实际错误。

Bridge.Initialize固定本次Provider身份并finally Dispose。Guard对正常结束、异常和外部Dispose都清理整个nested栈；资源加载、实例化、原清单服务与业务消费者正文保持不变。

新增Play会话辅助只操作共享Bridge.Provider。退出Play或assembly reload时取消属于Play的活跃lease；正常domain reload会话入口准备新的未就绪实例。私有Probe保持私有。禁用domain reload时明确诊断不支持原框架静态状态重进，不清原模块/缓存/ready来绕行。只读SHA Task可能在取消后自然完成；结果不再被消费，也不阻塞主线程等待。

## 验证与实际边界

| 检查 | 结果 |
|---|---|
| 修改前当前真实正文的两项回归 | 2项按预期失败：Dispose仍占用lease；Guard不释放内层 |
| 修改后实际生产正文重提取夹具 | 24场景、90检查、0失败，进程exit0 |
| 完整GFRunning官方rsp/真实引用独立编译 | exit0、error0 |
| LocalResources.Editor官方rsp/真实引用独立编译 | exit0、error0 |
| 业务正文保留审计 | 10项通过；InitializeCore仅新增收据身份元数据 |
| 生产readback与批准候选SHA | 3份完全一致；既有meta未改 |
| 本代理Unity运行 | not-run |

夹具直接重提取本次生产生命周期正文，并保留真实Save文件I/O；原资源I/O协程被可控等待/异常依赖替代，用于精确触发hash等待、部分加载、保存失败、外部取消、重复owner、nested清理、异常保留、共享/private隔离和会话边界。它不验证真实Unity协程是否按预期被停止，也不证明实际PlayerLoop、资源视觉或原玩法通过。

## 稳定源码

| 生产文件 | SHA256 |
|---|---|
| `Assets/RecoveryTools/Editor/LocalResources/LocalEditorResourcesProvider.cs` | `c328d57dcd9958b726b82e82cf15640f26212f4df048772ce2d5fc37ad025625` |
| `Assets/Scripts/GFRunning/GameFramework/Recovery/LocalEditorResourceBridge.cs` | `08abb454171c92739547938b880cdde90b54f42c2ed2b37f84c576fd600789b7` |
| `Assets/RecoveryTools/Editor/LocalResources/LocalEditorResourcesPlaySession.cs` | `2813eb92c20a553070d269de483dee74545a8c1093b898236d8d55edbb781db2` |

完整证据包含修改前后源码/meta、精确scope/diff、两项失败负对照、候选取消次异常失败样例及修复、实际生产夹具provenance/result、官方rsp/编译log/result/dll和逐文件SHA清单，位于证据/Editor资源初始化生命周期修复。

主线程收到sourceStable后统一运行Main6。实际GUI验收仍需确认：提前退出时取消收据与lease终态正确、未发原完成回调；下一正常reload会话有新的真实runId并重新完成全部必要I/O；私有Probe共享引用/ready/services隔离继续成立。当前coreGameplayAccepted=false。
