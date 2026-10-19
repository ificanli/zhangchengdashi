# LoadingScene 手工状态机还原

证据：主代理 `work/ida-startup-bounded/pseudocode/0x4083954.asm.txt`，元数据 `dump.cs` 与 `native-refs.json`，原 ELF 段映射读取 `loading-constants.json`。`LoadingScene.candidate.cs` 是方法还原候选，位于 work，没有接入工程，没有运行验收。

## 8 个 iterator 状态

| 状态 | 恢复地址 | 行为 |
|---|---|---|
| 0 | 0x4083AB0 | p=0，LoadingPanel.UpdateInfo(p)，进入首段进度 |
| 1 | 0x4083B40 | while p<progress1：每帧 p+=0.01，p>=currentMaxProgress则取currentMaxProgress，UpdateInfo，yield null |
| 2 | 0x4083C08 → 0x4083CD4 | 当 BundleLoadingProgress<1 且累计deltaTime<0.1 时yield；不是整个启动的0.1秒超时 |
| 3 | 0x4083C14 → 0x4083D28 | 每帧等 DataManager.LoadDataCompleted |
| 4 | 0x4083C20 → 0x4083D44 | 每帧等 TutorialManager.InitSteerInfoEnd；完成后发 OnLoadingCompleted |
| 5 | 0x4083C2C → 0x4083DA4 | 每帧等 GameManager.InitComplete；随后设置 IsLoadingCompleted=true、EnterHome=true，进入首页/IAP/存档检查，发LoadEnd |
| 6 | 0x4083C38 → 0x4083F74 | p从progress1到progress2，每帧+0.01并钳到0.9；之后CompareCheat.StartCheck，false则结束枚举器 |
| 7 | 0x4083C4C | StartCheck成功后UpdateInfo(1)，等待20次yield null，再Destroy LoadingPanel并发CloseLoadPanel |

关键字段：LoadingManager `_loadingPanel=0x20`、`IsLoadingCompleted=0x28`、`currentMaxProgress=0x2C`、`progress1=0x30`、`progress2=0x34`。UIPanel vtable偏移0x1C8对应slot9，元数据方法为 `UpdateInfo(params object[])`。

事件时序很重要：OnLoadingCompleted 在 GameManager.InitComplete 之前；LoadEnd 在 CompareCheat.StartCheck 和20帧展示之前；CloseLoadPanel 才在销毁LoadingPanel之后。不能把这3个事件合并为一个“结束”。GameLauncher的回调和订阅方法还需短方法正文确认其将OnLoadingCompleted接到InitGame。

首页检查保持原行为：DailyTask("GemCheck")；读取LastGemCheck和资源"20006"；数量>=50001或增量>=50001时调用相应ReportEventsManager方法；当天状态为0时写回计数并置1。这些步骤和StartCheck均保留于候选方法，没有跳过。

## 已实读浮点数

- RVA0x1837464：`0ad7233c`，float32=0.01。
- RVA0x1836E9C：`cdcccc3d`，float32=0.1。
- RVA0x1836EA0：`6666663f`，float32=0.9。

读取脚本解析ELF PT_LOAD映射后取原始4字节，未假设通用RVA与文件偏移差值。

## 耗时与优化结论的边界

IDA的长时间plan_and_wait/反编译CPU耗时属于分析工具，不能当作游戏启动耗时。当前没有本轮游戏帧时间数据。

从原代码能确证有按帧计数的额外等待：首段进度每帧仅增加0.01，尾段同样如此，最终还固定等待20帧。例如20帧在30FPS约0.67秒、60FPS约0.33秒；这只是数学换算，不是本机实测。首段进度还受currentMaxProgress约束，真实瓶颈可能是Manager初始化尚未推进，而非进度动画本身。

可进一步测量的阶段：各Manager初始化耗时、LoadDataCompleted等待时长、InitSteerInfoEnd等待时长、GameManager.InitComplete等待时长、进度动画帧数和20帧展示。只有取得实测后，才适合把固定帧步长调整成deltaTime驱动或缩短展示时间；恢复阶段应首先保持原顺序和检查。

若progress2>0.9，末段会被钳0.9而无法结束；是否存在此配置取决于构造器和字段写入，当前未据此认定原包有bug。应补 `LoadingManager..ctor 0x40830C0` / `StartLoading 0x4082BF0`，再判断不变量。若业务信号永不就绪，原方法没有给Data/Tutorial/GameManager等待超时；Editor适配应该诊断缺失依赖，不应强制把这些信号置true。
