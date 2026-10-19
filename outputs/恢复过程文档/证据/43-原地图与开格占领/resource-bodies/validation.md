# 第43任务资源子闭包验证

已交付 `bodies.json` 七个原方法正文：Awake、OnDestroy、GetHexPrefabPaths、GetGroundPrefabPaths、LoadHexPrefabs、LoadBTestHexPrefabs、LoadSeasonBTestHexPrefabs。三种加载保留真正的逐项 await、配置和 AB 分支、失败传播与原资源地址。本文仅涵盖独立资源子任务。

## 原证据与正文对应

`native-resource-evidence.json` 从原 ARM64 ELF 和 `outputs/IDA分析材料/Il2Cpp导出/script.json` 独立读取，不打开任何 IDA 数据库。原 ELF SHA256 为 `72770d00b2b404acf44cc75cc8bf7a3e06850e9ace1237c9cbb2bc72894220ed`。每个方法保留实际起止、方法字节 SHA256、真实泛型实例、元数据字符串槽和 direct call；IDA片段以主任务专属导出为补充。

| 方法 | Wrapper RVA | MoveNext RVA与末端 | 原行为 |
| --- | --- | --- | --- |
| Awake | 0x4411A0C | 末端0x4411B58 | HasHexDestroy、OnGameOver 顺序注册，保存skybox到0xD0 |
| OnDestroy | 0x4412270 | 末端0x44123B4 | 同序退订，tailcall ReleaseReferences |
| GetHexPrefabPaths | 0x4411F4C | 末端0x4411FE8 | arenaInfoDic配置0x90字段按59分号拆分 |
| GetGroundPrefabPaths | 0x4411FE8 | 末端0x4412084 | arenaInfoDic配置0xB8字段按59分号拆分 |
| LoadHexPrefabs | 0x4412084 | 0x441F698..0x4420114 | Season-B优先，再Weekly-B；普通两个结果写0x48/0x50 |
| LoadBTestHexPrefabs | 0x4415440 | 0x441CACC..0x441D428 | Player内/外、Enemy内/外顺序await，写0x58/0x60/0x68/0x70 |
| LoadSeasonBTestHexPrefabs | 0x4412124 | 0x4420120..0x4420A7C | Player内/外、Enemy内/外顺序await，写0x78/0x80/0x88/0x90 |

`native-path-oracle.json` 的八个地址来自原字符串槽，独立于候选代码。GetResult、IsCompleted、AwaitUnsafeOnCompleted 的泛型均核实为 GameObject。三种加载函数末端的 ARM64 异常处理岛位于精确函数边界内；新 async 源由编译器生成异常传播，并未添加吞异常、完成回调或默认成功。

## 有效验证

`build_fixture.py` 依据原RVA从主任务实际候选 `candidate/Assets/Scripts/Assembly-CSharp/GameModule/GenerateHexBehaviour.cs` 重新提取这七个正文，记录候选SHA和逐正文SHA到 `fixture-provenance.json`、`actual-candidate-bodies.json`。验证代码未复制业务实现，只把方法返回容器 UniTask 适配为 Task，使挂起/失败资源源可以独立驱动。其余实际候选正文原样注入。

实际命令：

```powershell
& 'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe' -X utf8 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-43-hex\resource-bodies\build_fixture.py'
dotnet run --project 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-43-hex\resource-bodies\fixture-candidate\Fixture.csproj' -- 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-43-hex\resource-bodies\native-path-oracle.json' 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-43-hex\resource-bodies\candidate-result.json'
dotnet run --project 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-43-hex\resource-bodies\fixture-negative\Fixture.csproj' -- 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-43-hex\resource-bodies\native-path-oracle.json' 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-43-hex\resource-bodies\negative-result.json' negative
```

两条执行命令均退出0：实际候选50 passed/0 failed；原空方法负对照0 passed/14 failed，确认测试会识别缺失请求、假提前完成、缺事件生命周期。

候选50检查覆盖：首个请求挂起；八个真实固定地址；八个字段归属与逐项完成；BTest和SeasonBTest每一级失败后禁止后续请求；普通两级失败传播、null配置、短数组在第一次字段赋值后抛异常；字典缺key和split空条目；Season分支避开AB单例；外层协程传播子协程失败；事件同一实例delegate匹配及退订先于ReleaseReferences。

这属于可控外部资源源下的独立异步调用顺序/状态/失败边界验证。实际UniTask与Unity引用csc由主任务负责，Unity真实载入、渲染、地图生成和输入交互由主窗口验收，本子任务没有开关Unity。

## LoadGround与未闭合依赖

LoadGround Wrapper为0x4412C0C，MoveNext为0x441DD78..0x441F68C。完整原流程包含随机选图、教程1008、排除多边形11、原Arena首次进入、赛季AB地图与塔key、配置地址和资源await，不能缩成一条资源load。

原标志 `loadGroundResEnd` 在0x441E23C写false、0x441EA10写true；true位于实际资源await之前。`res` 在0x441E3E4才写GetResult返回值。因此该标志不是资源加载成功证明，验收需真实await结果。此方法没有Instantiate，实例生成属于InitMap。

专属伪C矩形塔key分支错误显示return；原ASM 0x441F0F8读取key[0]、0x441F10C按逗号拆分、0x441F11C跳到0x441EC84汇合。`ground-jump-tables.json`直接保存原三个表字节和四个目标地址，证明状态机、塔key、资源switch的对应。额外完整Ground草稿在 `ground-body.cs.txt`，尚未作为稳定bodies集成交付或通过验证；主任务可继续检查再整合。

外部硬依赖：MapGenerateConfig.ArenaIdForAssets属性当前共享源码仍为空getter；该文件不属于本子任务。当前三种加载的真实入口依赖原配置存储、DataManager/GlobalInfo已初始化、AssetsManager生产，以及AB状态。Awake还依赖GameEnd与ReleaseReferences原正文。没有替这些依赖造默认成功。
