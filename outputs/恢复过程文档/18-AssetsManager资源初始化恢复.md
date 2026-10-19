# 18. AssetsManager 资源初始化与句柄生命周期恢复

本阶段把原 `AssetsModule.AssetsManager` 中可由原生代码闭合的方法写回现有 C# 文件，恢复真正生产 `initcomplete` 的资源初始化逻辑，并接回真实 Addressables 加载、缓存引用计数、完成回调及卸载。只修改 `Assets/Scripts/Assembly-CSharp/AssetsModule/AssetsManager.cs`，保留原 `.meta` 与 GUID；没有在其他对象直接设置完成标志。

这仍是源码恢复阶段。Unity 由主代理统一导入与编译，本分支未运行 Unity；静态核查、统一编译、真实资源读取和完整原游戏运行分别记账，不相互代替。

## 1. 为什么必须恢复这个生产者

原 `GameLauncher.InitBaseManager` 只等待 `AssetsManager.Instance.initcomplete`，不调用 AssetsManager.Init。该字段的真实生产者来自上游 `ProcedurePreLoad.PreLoadAsync`，不能因单独打开 Game 场景时等待不结束，就把 bool 改成 true。

已复核原 `ProcedurePreLoad.<PreLoadAsync>d__4.MoveNext (0x43A01BC)`：

1. `0x43A02CC` 取得 metadata `0x8D12008`，确认为 `ManagerBase<AssetsManager>.get_Instance()`。
2. `0x43A02D4` 获取实例，随后取得 gameObject 并 `DontDestroyOnLoad`。
3. `0x43A0318` 从该实例 vtable `+0x178` 取 slot 4，`0x43A0320` 间接调用。AssetsManager 的 slot 4 正是 `Init (0x3F12988)`。
4. 后续保存 UniTask awaiter，并等待该任务完成。

因此，本批恢复 AssetsManager 内部原正文；上游 ProcedurePreLoad 与原 Game 场景切换由另一批独立恢复。直接从 Game 场景进入缺少前置调用，属于已证实的入口差异。

## 2. 原生证据与函数身份

原 IDA 已完成本批 4 个后继目标，均核对实际起止地址与 metadata 一致、prototype 应用成功、无 `JUMPOUT`：

| 方法 | 原范围 | 主要作用 |
|---|---|---|
| AssetsManager 构造函数 | `0x3F13590–0x3F136B4` | 两份句柄字典、支持递归的读写锁、GUI 默认字段 |
| GenerateGroupsMap.MoveNext | `0x3F136BC–0x3F13BD8` | 读 Resources 配置，建立路径和分组映射 |
| LoadAssetAsync<object>.MoveNext | `0x6891B6C–0x6892F10` | 双重缓存检查、计数、真实加载、等待与失败处理 |
| LoadAssetAsync 完成回调 | `0x5194AE0–0x5194E78` | 错误日志、移除、Release、分组清理和等待源完成 |

`Init.MoveNext (0x3F13BE4–0x3F14074)` 使用既有有界 IDA 正文与汇编。其他短方法同时直接从原 ELF 按 metadata 边界读取 ARM64 指令，使用 Capstone 5.0.6，ELF RELA 对应到 script.json 的具体泛型 method/type/string metadata，以免把共享 `object` 实现误读成未知类型。

完成回调的 handle ABI 也已核对：原 `AsyncOperationHandle<T>` 在该构建中为 24 字节，由 InternalOp、Version、对齐与 LocationName 构成，AAPCS64 通过指针间接传值。IDA 使用 `self, handlePointer, MethodInfo*`，没有把它错误地拆成寄存器参数。C# 写回使用原值类型签名 `AsyncOperationHandle<T>`。

证据位于 [AssetsManager恢复证据](证据/AssetsManager恢复/)，其中 `status-assets-init.json` 保存边界核查，`native-consumer-evidence.json` 保存从原 ELF 得到的指令及 metadata 身份，`ida-*.c` 与 `ida-*.asm.txt` 保存正式反编译结果。

## 3. 构造函数和分组映射

原构造器建立：

- `_assetHandles = new Dictionary<string,List<AsyncOperationHandle>>()`。
- `_assetHandleMap = new Dictionary<string,AssetHandleInfo>()`。
- `_lock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion)`，原实参为 1。
- `_showDetails = true`。
- `_fontSizeScale = 1.2f`，原 float 位模式为 `0x3F99999A`。

`IsUpdating` 的原 getter/setter 分别读取和写入实例偏移 `0x4C`，已恢复为实际自动属性。原空返回不再吞掉写入。

`GenerateGroupsMap` 按原顺序读取 `Resources.Load<TextAsset>("AddressablesConfig")`，把 `.text` 交给 `JsonUtility.FromJson<AssetsPathInfoCollection>`，再：

1. 新建 `_assetGroupDict`。
2. 新建 `_assetGroupNameDict`。
3. 对每项 `_assetGroupNameDict.Add(item.assetPath,item)`。
4. 每个首次出现的 group 建立空 `List<string>`。

这里的组列表用于跟踪后来实际加载的资源，所以初始化时为空；没有把配置中所有路径直接填入“已加载列表”。Dictionary.Add 的原重复键失败行为也被保留，没有改成静默覆盖。

现有 `Assets/Resources/AddressablesConfig.json` 为 946,424 字节，SHA-256 `45bb30f7c7810343e77c5d87866ccce31b55a31aa27fafda7bf34f0d4c2a3a29`。与先前直接从原 APK 提取的 AddressablesConfig 字节完全相同：4,070 条唯一 assetPath、17 个 group、无重复/空路径或空组名。这个输入核查证明原映射数据齐全，不证明 Editor 已成功加载其中任意 Addressable。

原 GenerateGroupsMap 是没有 await 点的 async UniTask 方法。源码保留 async 形式，使解析/重复键等异常进入失败任务并被上游 await 观察；没有改成空的 CompletedTask，也没有吞掉异常后继续宣布成功。对应 CS1998 仅表示无 await，应与编译错误区分。

## 4. Init 的完成顺序

写回的原顺序为：

```text
await GenerateGroupsMap()
BundleLoadingProgress = 1
发起 ObjPoolManager.Instance.Init()，不 await
发出 AssetsManagerInitComplete 事件
initcomplete = true
```

汇编 `0x3F13E0C` 写进度 1，`0x3F13E24` 调对象池 slot 4，`0x3F13E4C` 触发事件，`0x3F13E58` 才写实例 `+0x4D` 的完成 bool。事件回调执行时，bool 仍可能为 false；源码保留这一顺序。

原方法没有把 ObjPoolManager.Init 的任务纳入等待，本批也未增加等待或删除调用。它同样没有直接 `Addressables.InitializeAsync`，因此 `initcomplete` 不能扩大解释为所有包、对象池和全部资源都已加载。整个源文件只有这一处真实完成赋值，没有 catch/finally 中的无条件成功赋值。

## 5. LoadAssetAsync 的真实缓存、锁和失败语义

`LoadAssetAsync<T>` 恢复原三条等待路径：

- 已有 handle 尚未完成：Interlocked 增加 RefCount，等待其非泛型 Handle.Task，再返回强制转换后的 Result。
- 已有 handle 已成功：增加 RefCount，直接返回其 Result。
- 进入写锁后再次命中 handle：增加 RefCount，等待其 Handle.Task，再返回 Result。该二次检查按原代码保留。

确需新加载时，原配置表必须包含 assetPath。缺失会输出原中文错误并抛 Exception；没有从文件名猜地址，没有转去 AssetDatabase，也没有返回默认资源绕过失败。

新加载流程为 `Addressables.LoadAssetAsync<T>(assetPath)`，建立 `AssetHandleInfo`，保存真实 handle、`RefCount=1` 和 `UniTaskCompletionSource<object>`，加入路径句柄表、实际分组加载列表，注册原完成回调，再 await 泛型 handle.Task。完成后检查 Status；成功但 Unity Object 为 null、失败状态等均保留原日志、句柄表移除和 Exception。缓存路径保留原直接转换行为，没有额外添加原程序未有的成功判定。

读写锁恢复原跨度：外层 UpgradeableReadLock，内层 WriteLock，finally 中对应退出；原方法会在锁范围内 await，完成回调也进入写锁，因此构造器的 SupportsRecursion 不能换成默认值。此处保留原逻辑，尚未把它改造成新的并发设计；实际 Unity 主线程/continuation 行为需后续运行验收。

原完成回调使用现有嵌套闭包类，保留其 self、assetPath、groupName 和 newHandleInfo 字段。失败时记录原错误格式，移除句柄表项，Release 真实 Addressables handle，并从已加载组路径列表移除；之后 `WaitSource?.TrySetResult(null)`。它是原等待通知，成功/失败任务仍由真实 handle 决定；没有用 TrySetResult 把失败资源转换成成功结果。

## 6. 卸载闭环

| 方法 | 原 RVA | 写回行为 |
|---|---|---|
| `UnloadAsset` | `0x3F12A98` | 外读锁、内写锁；引用计数恰好减到 0 才释放有效 handle，移除组内路径和句柄映射 |
| `UnloadGroup` | `0x3F12DB8` | 复制已加载组路径列表后逐项 UnloadAsset，避免枚举时列表被移除；最后发起 UnloadUnusedAssets |
| `ForceUnloadUnusedAssets` | `0x3F1337C` | 按原代码发起 Resources.UnloadUnusedAssets 后 GC.Collect，不额外 await |
| `ForceUnloadAsset` | `0x3F133D4` | 写锁内释放有效 handle 并移除映射，不执行引用计数减法 |

强制卸载的原方法未同步移除 group 路径，本批保留原行为，没有趁恢复时重新设计生命周期。空 `AssetHandleInfo` 构造器经原 ARM64 确认为仅调用 Object 构造器，字段初始化由新加载分支赋值，并非遗漏原初始化。

## 7. 本阶段检查与可审查交付

已执行只读静态核对并归档 `static-verification.json`：原 metadata/GUID 文件 hash 未变，Init 事件/flag 顺序和唯一完成写入位置相符，两个缓存检查和三处真实任务等待存在，AddressablesConfig 原字节未变，原 IDA 函数边界/原型核查全部通过。

源码 SHA-256 为 `34bae1e67fcdee17010e10ccd1de37cba7de3732df6aad02e28b14a0bf6a811b`，15,673 字节。`AssetsManager.patch` 提供按统一换行展示的逻辑差异，另外保留原始 before 源码和当前 recovered 源码字节副本，便于审查。它们只位于文档证据目录，不会作为 Unity 运行脚本重复导入。

本阶段没有自行执行 Unity。第一稳定点已交主代理 import9，主代理反馈该轮未报 AssetsManager 错误；LoadAssetAsync/卸载闭环属于第二稳定点，仍由主代理统一导入及编译，不能用第一轮结果代替第二轮验证。

## 8. 明确剩余依赖

本批已恢复上述实际正文，没有恢复所有原游戏业务。原上游 ProcedurePreLoad/ProcedureStarGame 由另一批接回；ObjPoolManager.Init 及对象池数据仍是单独依赖，不能由“调用了它”推断其逻辑已实现。InitGUIStyles 这段未参与当前启动闭环，本批保留待恢复状态。

原导出的旧状态机壳保留在类中以便追溯；已实现的三个 async 方法移除了指向旧空壳的显式 AsyncStateMachine 属性，由 C# 编译器为真实方法体生成状态机。真实启动是否完成、Addressables 句柄是否成功、场景是否进入原玩法，必须记录后续统一编译和 Editor 实际运行证据。
