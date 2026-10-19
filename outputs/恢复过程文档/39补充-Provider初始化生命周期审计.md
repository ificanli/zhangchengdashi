# 第 39 阶段补充：Provider 初始化生命周期审计

本次只读审计确认了一个独立于资源格式的生命周期缺口：当原启动协程在首次 yield 后因外部停止 Play 而不再推进时，Provider 的 `_initializing` 没有可靠的取消收束路径。随后在同一共享实例再次调用 Initialize，会报“initialization is already in progress”。这不是清单或 TextAsset 校验失败。

本补充没有修改第 39 阶段已冻结的 10 个生产源文件。仅按主线程授权窄修独立观察入口，改用未注册到 Bridge 的私有新 Provider；原共享实例不会由观察入口重置、替换或推进。独立资源验证不等于原启动链通过。

## 已观察事实

- Main5 实际进入 MineGameMain，在 frame 1 观察到两条渲染错误：CoreBlit 缺少 `BLIT_DECODE_HDR` local keyword，以及 pass index 1 无效。观察器按原保护策略退出 Play，未完成原定 30 秒。
- 保存的 Main5 Provider partial 的 runId 为 `20261019-091119-949-e8345b58`，status 为 `checking_actual_local_resources`，ready=false，manifestRecords/payloads/loadedLegacyTextAssets 均为 0，且没有资源验证异常。该初始收据本身不能证明后续具体 yield 点；源码控制流显示首次可挂起点位于 APK SHA256 Task 的等待循环。
- Probe1 实际执行，在第 1 个 Editor update、约 0.096 秒时报 `_initializing` 已占用。before/after 收据 SHA256 相同，场景、dirty 与层级对象身份保持一致；没有开始独立资源校验。
- 当前 EditorSettings 的 `m_EnterPlayModeOptionsEnabled=0`，默认 Play 入口采用正常重载选项。不能仅凭该配置声称下一会话已得到新实例；仍需实际观察新的 Provider runId 与加载收据。

## 源码链与缺口

1. `VersionMondule.Initialize` 通过 UpdateManager 的真实 MonoBehaviour 协程宿主运行 Init；Editor Init 用 Bridge.Guard 包装 InitializeLocalEditor。
2. `LocalEditorResourceBridge.Initialize` 直接推进 Provider.Initialize；该包装器当前没有 finally/Dispose 传播。
3. Provider.Initialize 第 103 行设置 `_initializing=true`。只有正常迭代结束，或 operation.MoveNext 抛出并被 catch 捕获时，才会清除此值；没有 covering yield 的 finally。
4. Provider.InitializeCore 第 145–146 行在 Task.Run 的实际 APK 哈希完成前 yield null。该 Task 只读文件，不修改 Unity 对象；协程不再推进后，Task 完成也不会自行更新初始化状态或执行原回调。
5. Bridge.Guard 把 nested IEnumerator 放入栈中手工推进，但当前没有在外部取消时 dispose 活跃栈。即使后续给 Provider 加 finally，包装层也需要传播取消/Dispose，不能假定引擎必然处理这一自建栈。
6. 原 Play 观察器在 errors.Count>0 时 Finish，随后调用 EditorApplication.ExitPlaymode。该退出是已记录渲染异常的保护行为，不应删掉或忽略错误来延长运行。

## 下一次 Main 的具体安排

眼前无需解冻第 39 阶段源码来做 Main6。等渲染修复与新观察文件的实际导入完成后，主线程复用当前 GUI，按正常 Play 会话进入 Main；保留 Main5 partial 和 Probe1 failure 原件。下一次必须以新的实际 Provider runId、original module callback/flag 的实际快照和 typed-load 收据判断是否前进。私有 Probe 的 ready 不接入 Bridge，也不作为 Main6 ready。

如果下一会话再次遇到旧 lease，先保存该会话证据并停止，不能反射清 `_initializing`、赋 IsReady、清待处理列表，或把私有 Probe 的实例装入 Bridge 来推进原流程。

## 建议的最小生命周期修复方案（尚未实施）

建议作为一次明确的 Editor 平台生命周期修复实施，范围限定为 `LocalEditorResourcesProvider.cs`、`LocalEditorResourceBridge.cs` 和一个 Editor 会话观察辅助文件；不改原 Version/Resources/UIModule 的完成顺序、原状态或业务数据。

1. Provider 的每次 Initialize 建立唯一 session/lease；用覆盖所有 yield 的 try/finally 收束该 lease，并 dispose 实际 InitializeCore enumerator。正常完成、资源异常、外部取消分别写终态收据。取消必须记录为 `cancelled_editor_session`、ready=false，并保留实际已完成的校验结果，不能记成成功。
2. Provider 以只读方式暴露当前 session 身份和初始化终态，提供只用于当前 owner/session 的显式 Cancel。Cancel 结束该 session 并保留异常/收据，不恢复原 ready，不调用原 callback。后台 SHA Task 无 Unity 写入，允许它完成并忽略结果，或在明确取消 token 检查点终止；不在主线程阻塞等待。
3. Bridge.Initialize 和 Bridge.Guard 用 finally 向内层及活跃 nested 栈传播 Dispose。正常 pop 也 dispose 相应 enumerator；异常、外部取消都要收束，且保留原 sticky 资源异常。
4. Editor 生命周期辅助在 ExitingPlayMode/beforeAssemblyReload 明确取消**正在属于该 Play 会话**的初始化，并保存不可变 runId 收据；它不能取消私有 Probe，也不能在活跃运行中替换共享实例。会话结束后的新会话才显式注册新的 Provider。这样覆盖用户禁用 domain reload 的情况，不依赖私有字段重置，也不复用部分缓存。
5. 以实际 Editor 验证三条不同路径：完整初始化；等待 APK hash 时退出 Play；已加载部分 TextAsset 后退出 Play。验证取消 session 没有 ready/原 callback，新会话得到新 runId 并重新执行全部必要加载。另测真实资源异常仍 sticky，不被“取消”吞掉。

上述方案需要新的授权与独立编译/实际 Editor 验证；本次只提供方案，冻结源码未修改。私有 Probe 的新增源码已独立编译为退出码 0、错误 0，实际运行结果由主线程另行触发与记录。
