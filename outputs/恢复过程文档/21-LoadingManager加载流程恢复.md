# 21. LoadingManager 加载流程恢复

本阶段恢复 `LoadingModule.LoadingManager` 的原进度协程、真实 LoadingPanel 消费、完成事件、原数据/教程/游戏初始化等待，以及 GemCheck 和 CompareCheat 检查。只修改现有 `Assets/Scripts/Assembly-CSharp/LoadingModule/LoadingManager.cs`；`.meta` 和 GUID 未变。没有替其他 Manager 写入就绪状态，也没有新建占位 LoadingPanel。

源码稳定点 SHA-256 为 `6607303d6221f8371e2e6ce3628d2334734077b2fd78ddd2351423fb5c1ceab5`，11,278 字节。此分支未运行 Unity，已交主代理统一导入/编译；源码恢复与真实启动验收分别记录。

## 1. 采用的原生证据

LoadingScene 的大状态机 `0x4083954–0x4084190` 先前多次在 Hex-Rays 中长时间未返回。本阶段直接复核完整 ARM64 汇编、metadata 字段/泛型/string 引用、8 个 iterator 恢复状态和原 ELF 浮点常量，没有再次对该大函数重复反编译。

已有 `work/startup-restore/LoadingScene.candidate.cs` 与 `loading-state-machine.md` 是准备稿；本阶段按原汇编逐段核对后，才将逻辑写入工程中实际 `LoadingScene()`。指向旧空状态机壳的 IteratorStateMachine 属性被移除，由 C# 编译器为真实迭代器方法生成执行状态机。原壳继续保留供身份追溯，没有另建替代组件。

补取的 4 个短方法已得到正式 IDA 伪 C 与汇编，实际函数起止边界与 metadata 全部一致、原型应用成功、无 JUMPOUT：

| 方法 | 原范围 | 本阶段结果 |
|---|---|---|
| `StartLoading` | `0x4082BF0–0x4082D8C` | 找到实际场景 LoadingPanel，取 UIPanel、显示进度条、发起 Show、启动协程 |
| `GetData` | `0x4082E2C–0x4082EB4` | 按原路径检查与读取文本，缺文件返回空字符串 |
| `GetFilePath` | `0x4082EB4–0x4083028` | 原 SaveDirectory 判断/Init 调用、键名替换与 `.txt` 路径 |
| `Init.MoveNext` | `0x40831A4–0x4083944` | 原上传测试配置分支、Panel/事件/目录/0.1 秒等待 |

构造器、静态初始化、属性 getter/setter 和进度增量方法较短，另从原 ELF 按 metadata 边界直接解码 ARM64，解析 RELA 指针槽到 script.json 中的具体类型、方法和字符串。新证据、原始汇编、正式 IDA 结果、前后源码及差异均归档在 [LoadingManager恢复证据](证据/LoadingManager恢复/)。

## 2. 原字段初值解决了进度上限疑问

原构造函数 `0x40830C0` 从 ELF `0x1838570` 读取 8 字节 `CD CC 4C 3E 0A D7 23 3F`，分别写入实例偏移 `0x2C` 和 `0x30`，即：

| 字段 | 原 float 值 | 作用 |
|---|---:|---|
| currentMaxProgress | 0.2 | 第一段当前可达到的进度 |
| progress1 | 0.64 | 第一段目标和业务初始化推进上限 |
| progress2 | 0.9 | 末段目标 |

`progress2` 的原位模式为 `0x3F666666`，确实是 0.9。此前报告 08 提出的“若 progress2 大于 0.9，可能无法结束”是尚未读取构造器时的条件性疑问；本次证据已确认原初值与末段上限一致，不能继续把该假设当成本包故障。

`AddCurrentMaxProgress` 在 `0x4082DEC` 将当前值与传入 p 相加，再取不大于 progress1 的结果。源码恢复为 `Mathf.Min(currentMaxProgress+p,progress1)`，没有把进度直接设满。

`IsLoadingCompleted` 的原 getter/setter 读取/写入实例 `+0x28`，已恢复为真实自动属性。原静态初始化 `0x4083120` 赋值 `EnterHome=false`、`SaveInfo="SaveInfo"`、`SaveDataStr="SaveData"`，本批按原值保留。

## 3. StartLoading 消费原场景 UI

原 `StartLoading` 通过 `GameObject.Find("LoadingPanel")` 找场景对象，取其 `UIPanel` 并保存。若该对象实际属于 `UIModuleO.LoadingPanel`，调用 `SetProgressBarActive(true)`。随后对实际 UIPanel 发起 `Show(Array.Empty<object>())`，不等待返回任务，再 `StartCoroutine(LoadingScene())`。

这里的 vtable `+0x188` 是 UIPanel slot 5，对应 `Show(params object[])`；进度更新使用 `+0x1C8` 的 slot 9，对应 `UpdateInfo(params object[])`。方法身份已据原 UIPanel 声明核对，不从槽号猜 UI 生命周期名称。

没有新建 GameObject、AddComponent 占位面板或使用 Editor 专用假 UI。原对象不存在、组件缺失或其真实实现未恢复时，仍必须报告这些依赖，不能因为启动协程本身存在就声称面板可见、进度可动。

## 4. LoadingScene 的 8 个状态

| 状态 | 原恢复点 | 恢复的行为 |
|---|---|---|
| 0 | `0x4083AB0` | p=0，向真实 Panel 发送 UpdateInfo，进入首段 |
| 1 | `0x4083B40` | p<progress1 时，每帧增加 0.01，并受 currentMaxProgress 限制 |
| 2 | `0x4083C08` | 仅在资源进度小于 1 且累计 deltaTime 小于 0.1 时继续等待 |
| 3 | `0x4083C14` | 每帧等待 DataManager.LoadDataCompleted |
| 4 | `0x4083C20` | 每帧等待 TutorialManager.InitSteerInfoEnd，完成后发 OnLoadingCompleted |
| 5 | `0x4083C2C` | 等待 GameManager.InitComplete，随后设置加载完成和进入首页状态 |
| 6 | `0x4083C38` | p 从 progress1 每帧增加 0.01，钳至 0.9，直到 progress2；再执行 CompareCheat |
| 7 | `0x4083C4C` | 检查通过后显示 1，保留 20 次逐帧等待，销毁原 Panel，再发 CloseLoadPanel |

原 ELF 中 `0x1837464`、`0x1836E9C`、`0x1836EA0` 的实际 float 分别为 0.01、0.1、0.9，已与本批源码常量连接。

0.1 秒只限制第二段资源进度等待，不限制 DataManager、教程或 GameManager 的等待。后三个原信号没有新增超时、默认成功或假值赋予。首段也没有改成恒定时间动画：当上游尚未提高 currentMaxProgress，原协程会停在相应进度等待真实推进。

## 5. 三个完成事件不能合并

原顺序由汇编及字段偏移确定：

1. 数据和教程完成后发 `OnLoadingCompleted`。
2. 等 `GameManager.InitComplete`，再设 `IsLoadingCompleted=true` 和 `EnterHome=true`。
3. 执行首页/IAP/GemCheck，之后发 `LoadEnd`。
4. 完成末段进度，执行 `CompareCheat.StartCheck`。
5. 检查通过才显示最终进度，等 20 帧，销毁 Panel 并发 `CloseLoadPanel`。

因此 `IsLoadingCompleted`、`LoadEnd` 和面板已关闭是不同阶段。尤其 CompareCheat 返回 false 时，原枚举器立即结束，LoadingPanel 留在现场，既不补 100% 也不销毁。本批完整保留该否决分支；没有用最后一个事件替代所有前置契约。

`OnLoadingCompleted` 与 GameLauncher 的订阅/InitGame 链已有前批证据，后续必须运行这条真实事件联系，不能直接写 GameManager.InitComplete 来绕过它。

## 6. GemCheck、存档与上报原检查

进入首页阶段先调用 `HWIAPManager.EnterHomeInit`，再 `new DailyTask("GemCheck")`，从 PlayerPrefs2Center 读取 `LastGemCheck`，从 UserResourcesManager 读取资源 `"20006"`。

原 `0x4083EA0` 与 `0x4083ED0` 比较阈值 `0xC351=50001`，两项检查均保留：

- 旧数量为 0 且当前数量至少 50001，调用 `ReportGemStartCheckNumTooBig`。
- 当前数量减旧数量至少 50001，调用 `ReportGemChangeTooBig`。32 位减法保留 unchecked 语义。

当天任务为 `DailyTaskStatus.NoFinish=0` 时，原逻辑写回 LastGemCheck 并设 `DailyTaskStatus.Finish=1`；已经完成则不重复写。随后继续原 LoadEnd 和 CompareCheat 检查。这里没有调低阈值、删除调用或改造原比较检查。

这些是 LoadingManager 内的原调用恢复；DailyTask、PlayerPrefs2Center、ReportEventsManager、UserResourcesManager 和 CompareCheat 自身的数据/实现是否齐全，仍需分别继续核对。

## 7. Init 上传分支与本地文本路径

原 `Init` 先读取 `GameConfigManager.GameGlobalConfig.OpenUploadDataLogic`。只有该配置为 true 才执行上传测试相关分支：

1. 取得同一个实际 LoadingPanel、显示进度条并 UpdateInfo(0f)。
2. 订阅 `OnLoadingPanelBtnUploadTestStartGameClicked`。
3. `SaveDirectory=Path.Combine(Application.persistentDataPath,SaveInfo)`，按原条件创建目录。
4. 计算第二目录，再按原条件创建。
5. await `UniTask.WaitForSeconds(0.1f)`，原参数为不忽略时间缩放、PlayerLoopTiming.Update。

原第二路径的替换方向根据 `0x4083514` 的实参寄存器确定，是 `SaveDirectory.Replace(SaveDataStr,SaveInfo)`。本阶段按证据保留，即使名称看上去让人想交换参数，也没有借恢复修改原行为。

按钮回调 `0x40830B4` 只赋值 `BeginStartGame=true`。原 Init 没有等待该字段，本批也没有添加新的按钮门槛或无条件将其设为 true。

`GetFilePath` 使用原 `StringTool.IsNullOrEmpty(SaveDirectory,true)`，空时发起但不等待自身 Init；随后把 key 中 `/` 与 `\\` 替换为 `_`，加 `.txt` 并与 SaveDirectory 组合。`GetData` 按该路径用 File.Exists/ReadAllText；不存在返回 string.Empty。没有更换存档目录、添加密码猜解或用空成功数据替代文件内容。

这一分支仍依赖 GameGlobalConfig、StringTool 和实际场景 UI；本批没有用默认 false 跳过配置读取，也没有擅改其他文件补其方法。

## 8. 验证范围和后继依赖

本阶段执行了 15 项静态/原始字节/metadata 边界核对，结果归档于 [static-verification.json](证据/LoadingManager恢复/static-verification.json)：meta 未变，原事件与检查顺序保留，无 Data/Tutorial/Game 就绪字段赋值，CompareCheat false 保留 yield break，构造值与原 ELF 相符，原 UI 查找/Show/UpdateInfo 消费存在，4 个短 IDA 方法身份完整。

归档还包含 `LoadingManager.before.cs.txt`、`LoadingManager.recovered.cs.txt` 和按统一换行展示的 `LoadingManager.patch`。这些证据位于文档目录，不会作为 Unity 脚本再次导入。

当前源代码已交主代理统一 import。此分支没有运行 Unity，没有以静态核查替代 C# 编译、协程运行或视觉验收。后续主要依赖明确如下：

- 实际场景必须存在 LoadingPanel，UIPanel.Show、LoadingPanel.SetProgressBarActive/UpdateInfo/自身加载方法需要真实正文及资源依赖。
- DataManager.LoadDataCompleted、TutorialManager.InitSteerInfoEnd、GameManager.InitComplete 必须由其原初始化流程产生，本批没有代赋值。
- GameGlobalConfig、StringTool、本地存档、IAP、资源数量与原比较/上报方法需要继续恢复；仅保留调用不能宣称其业务已执行成功。
- 统一编译通过后，应记录每个等待开始/结束、进度上限推进、三个不同事件、检查结果和原 Panel 销毁。完整游戏可运行必须由这些实际运行证据闭合。
