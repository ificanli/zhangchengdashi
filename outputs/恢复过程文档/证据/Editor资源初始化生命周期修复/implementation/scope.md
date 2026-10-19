# 39 Editor 资源初始化生命周期窄修候选范围

当前只写 work 候选，不写生产，不运行/重启/终止 Unity。Main6 期间不改变共享 Provider、Scene、原 flags/callback、资源字节、旧清单或 pending60。

候选仅三个 Editor adapter 文件：

1. 既有 `LocalEditorResourcesProvider.cs`：Initialize 的唯一 lease 与 covering-yield finally；精确 owner/lease 取消；成功/实际验证失败/外部取消三种收据终态；每个 runId 独立收据。实际 InitializeCore 的清单、payload、50 TextAsset、UIRoot、5142 locator、53 typed-load 业务保持不变。IsReady 仍只在实际 I/O 和收据保存后写入。
2. 既有 `LocalEditorResourceBridge.cs`：Initialize 固定本次 Provider 身份并 finally Dispose；Guard 正常完成/异常/外部 Dispose 时释放全部自建 nested IEnumerator 栈，不吞原异常。资源加载/实例化业务不改。
3. 新 `LocalEditorResourcesPlaySession.cs`：只处理共享 Bridge.Provider；ExitingPlayMode/beforeAssemblyReload 精确取消归属 Play 的活跃 lease，私有 Probe 不注册、不受此取消。正常 domain-reload Play 会话入口显式记录边界并准备全新共享 Provider；不修改任何原框架模块字段、缓存、ready 或 callback。若禁用 domain reload，不清理原框架静态状态，明确记录“不支持无 domain reload 的原框架重新启动”，保持现场供诊断。

当前 EditorSettings 的 m_EnterPlayModeOptionsEnabled=0；正常重载会重建原框架静态状态。此修复不扩大为支持原框架的无 domain-reload 重进。

测试先对当前正文执行失败负对照，再对实际候选方法重提取；只将实际资源 I/O 作为可控依赖等待源，不能复制生命周期状态机到测试。验证 waiting/hash、部分加载、完整成功、资源异常、取消 owner 不匹配、重复 Dispose、nested 清理与外部生命周期边界。候选另用 Unity 官方 rsp 完整独立 csc 编译。全部结果不替代实际 GUI Editor/Play 验收。
