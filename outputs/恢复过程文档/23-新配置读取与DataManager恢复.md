# 23. 新配置读取与 DataManager 恢复

本阶段恢复 `DataModule.DataManager.LoadConfig → GlobalInfo.InitInfo → LoadGlobalInfo → 原 Base64/GZip/LitJson 解析 → 原配置回调` 的新配置链。范围仅为现有 DataManager.cs 和 GlobalInfo.cs，保留此前第 22 批恢复的 LoadDataCompleted 属性及两个文件原 meta/GUID。

旧框架的 41 项配置与这里的业务 JSON 使用不同消费者和格式；本批沿原完整路径、类型、AB 分支及回调恢复，没有把它们混用。Unity 导入与编译由主代理统一安排，此分支未自行启动 Unity。


源码稳定点：DataManager.cs 为 `44968437878d1800023105935555caddb27950bf07b9c3b197ff89b51cab5409`（7580 B）；GlobalInfo.cs 为 `8af0eb9c42d52c3027e518b6774e0177edb8851aad076a5a0fb46e0a78dcd0c2`（53853 B）。两份 meta 未变，第 22 批 LoadDataCompleted 自动属性逐字保留。

## 1. 原链的身份与范围

| 消费阶段 | 原 RVA/范围 | 已确认的契约 |
|---|---|---|
| DataManager.LoadConfig 状态机 | `0x434F8C4–0x434FB94` | new GlobalInfo，写实例+0x28，await InitInfo，成功后写 loadConfigComplete(+0x31) |
| GlobalInfo 构造器 | `0x434FB94–0x4350578` | 两个跟踪列表、原头像 ID 列表 |
| GlobalInfo.InitInfo 状态机 | `0x435DF2C–0x4361218` | 原 AB 分支、配置请求及 loadingConfig 完成等待 |
| LoadGlobalInfo<object> 状态机 | `0x6893230–0x68939A0` | 先 Resources，缺失才 await AssetsManager；回调后移除未完成记录 |
| GlobalStringToConfig<object> | `0x4C8F99C–0x4C8FB38` | Base64/GZip 解压，LitJson 解析 List<T>，原失败日志与重新抛出 |
| 完成 predicate b__92_72 | `0x435DEDC–0x435DF2C` | loadingConfig.Count<1 |

8 个中短方法已得到新的有界 IDA 伪 C 与汇编，包含 3 个具有代表性的复杂回调：召唤表建字典、英雄表建字典及日志、主城地图二次 JSON 展开。实际函数起止地址逐项核对 metadata；predicate 原型为 bool，泛型解析 helper 返回 List<T> 对象。

大 InitInfo 状态机已有完整 ARM64，没有再次提交可能长时间阻塞的整段反编译。其方法引用与 ELF RELA 槽已连接到具体泛型 T、回调和路径，不能仅凭共享实现名 `<object>` 推测类型。

## 2. 81 个地址、72 个调用点与每次 65 个请求

原状态机包含 81 个唯一的 `Assets/_Res/Addressable/01FirstBundle/JsonData/*.json` 地址。这不代表每次同时加载 81 份。原方法有 72 个静态加载调用点，其中 7 对由原 AB 条件选择其一，所以每次选中 65 个请求；另外若干调用点通过路径变量选择不同变体。

本批以原泛型方法 metadata、Action 回调 metadata 与地址实参逐项连接，恢复全部 72 个调用点，没有按文件名称自动猜数据类型。完整映射保留为 `load-request-map.json` 和 `callback-ledger.json`。

原选择包括：

- NewArtifactsPlay：A/B 神器属性表。
- ShopImproveV1：建筑、角色、英雄卡牌的成组路径，以及竞技场敌人卡牌表。
- AbilitiesInAdvance：升级天赋价格表。
- NewArenaProcess：段位与竞技场表。
- NewbieTutorial：训练地图表。
- GamePlayImproveV2Variant：值为 1、2 时使用各自 V2 难度/平衡表，其余值沿原基础分支；基础分支再按 BalanceAdjustment03 选择平衡表。
- WeeklyClashImprove01：赛季排名奖励和周对战难度表。

源码维持原分支的读取时机与调用顺序，未选定一个默认变体替代全部情况。ABTestManager 自身的初始化与服务器赋值仍属于独立依赖，不能从这些调用存在推断其当前值已正确。

## 3. Resources 优先与真实资源证据

`LoadGlobalInfo<T>` 先把完整 jsonPath 最后一段去掉 `.json`，按 `Resources.Load<TextAsset>("JsonData/"+stem)` 获取 TextAsset。只有 Resources 返回 Unity null，才输出原警告并 await `AssetsManager.Instance.LoadAssetAsync<TextAsset>(jsonPath)`。后者是第 18 阶段恢复的真实 Addressables 资源入口。

原导出的 81 个 Resources 文件是 `Assets/Resources/JsonData/*.txt`，不是 `.json`；Unity Resources 地址省略扩展名。这些文件均已逐字节与对应 Addressable `.json` 核对相等，都是原始 `H4sI...` Base64/GZip 内容。81 项全部可解压成合法 JSON 数组，原始/解压后字节数、SHA-256、行数和 Resources 对应关系归档于 `resource-audit.json`。

该核查没有修改数据文件，也没有把解压明文覆盖原压缩 TextAsset。这里证明的是输入字节及映射完整，不代表 Unity Resources 或 Addressables 已在本机实际读入。

## 4. 完成列表与失败行为

原 GlobalInfo 构造器初始化 loadingConfig、hadLoadInfo，以及按原顺序排列的 23 个初始头像 ID。顺序以 `1003,1002,1004,...` 开始，并保留原缺省项；本批没有为顺序或编号连续性自行补项。InitInfo 再按 NewMachineCard、NewCardsV1、WeeklyCardEvent 等原条件追加相应 ID，最后追加 1038–1040。

每次 LoadGlobalInfo 先检查 hadLoadInfo，重复请求会记录原错误，但仍按原行为继续加载；不会悄悄跳过回调。随后将路径加入 loadingConfig，读取/解析 TextAsset，执行具体回调，最后才 Remove(jsonPath)。

原 loader 是 async void，InitInfo 发起各请求后 await `UniTask.WaitUntil(loadingConfig.Count<1)`。没有替换为逐项串行 await，没有用清空列表结束加载，也没有在 finally 中把失败项标完成。解析/回调失败时，原未完成记录不会被无条件移除；真实失败仍必须被处理，不能以成功 flag 掩盖。

DataManager.LoadConfig 仅在 await GlobalInfo.InitInfo 成功返回后写 `loadConfigComplete=true`。这是配置完成字段，与存档加载的 LoadDataCompleted 是不同契约；本阶段没有对后者赋真值。

## 5. 导出时遗漏的 72 个实际回调

恢复工程原 GlobalInfo.cs 没有导出 `<InitInfo>b__92_0...71` 的方法声明，但原 ELF 仍有它们。仅恢复“发出加载请求”会让配置结果无法进入实际字段，因此本批按原字段偏移补回 72 个回调以及最后一个完成 predicate。

多数回调只把解析后的 List<T> 写入原字段。25 个回调还新建对应 Dictionary，并按原字段逐项 Add；重复键/空键的原失败语义保持。字典键并非全部为 id，例如召唤表使用 level，竞技场平衡表有自己的键字段；每个键均从原 load 指令偏移连接到类型声明。

两个 int 字典回调保留 StringTool.ToInt：EnemyDifficultLevelInfos 和 UserLevelInfo。没有把无法解析的键强行覆盖为 0 或用索引代替。英雄回调保留原卡牌条数日志。

特别的主城地图回调先保存 `List<GlobalMainCityMapInfo>`，对每行 `.infos` 再用 LitJson 解析 `List<GlobalMapInfo>`，将所有 tile 加入 tileInfos，再按 tile.tileKey `TryAdd` 到 tileInfoDic，保留首个重复键值的原策略。

作为数据层交叉核查，25 个建字典回调涉及的 34 份真实配置变体，其原键字段全部存在且无重复/null；两项整数键也可解析。主城原 10 行 infos 展开为 941 个 tile、941 个唯一 tileKey。这是原载荷分析结果，不等同于 C# LitJson 或 Unity 运行验收。

## 6. 新旧配置格式边界

| 项目 | 旧 ljzs_lt.ConfigMgr | 本批 GlobalInfo |
|---|---|---|
| 原入口 | GameStart.InitConfig | DataManager.LoadConfig |
| 资源 | 旧 data/config.unity3d 的 TextAsset | JsonData/*.txt 或原 Addressable JSON 地址 |
| 文本格式 | 明文 JSON、Datas 表等 | Base64/GZip 压缩的 JSON 数组 |
| 解析器 | ConfigRead/UnityJson | GZipTool + LitJson List<T> |
| 核对规模 | 41 个直接游戏配置类型 | 81 个唯一路径、72 个回调加载调用点 |

两条链都有原消费者证据，不能因为旧包已解码就拿其中的表替代 GlobalInfo。原 GlobalStringToConfig 的 jsonPath 参数虽然保留在签名中，正常解析正文直接处理 jsonStr；本批没有据未使用参数猜新的地址派生规则。

## 7. DataManager.Init 的窄范围恢复

原 `DataManager.<Init>d__14.MoveNext (0x434F5AC)` 只向真实 EventManager 订阅 `StartGame → PlayGame` 和 `GameWin → GameWin`，没有资源等待，也没有写配置或用户数据完成标志。该窄链已按完整 ARM64 恢复，保留 async UniTask 的异常传递形式。

PlayGame/GameWin 的业务正文、LoadData、保存冲突、登录和持久化读写不属于这次配置链的可闭合范围，仍保留给后继原生恢复。DataManager 构造器的原 ARM64 只有基类构造调用，本阶段没有添加额外默认业务状态。

## 8. 验证边界与尚需依赖

本批保存原生函数身份、路径/类型/回调映射、配置字节审计、键审计、前后源码和差异。源码已写回并冻结交主代理统一导入。18 项静态/原生/资源字节检查全部通过，两个 meta 文件未变，LoadDataCompleted 最新属性逐字保留；未以旧快照覆盖第 22 阶段的改动。

直接依赖包括：

- `GZipTool.DecompressFromBase64` 及其原解压 helper 链。真实载荷仍是压缩文本，返回 null 的空实现会直接使 LitJson 失败；本批保留原调用，相关公共工具由主代理另恢复。
- `StringTool.ToInt`，用于两份真实 int 字典键。空实现返回默认 0 会制造重复键，不能改变字典行为来掩盖该依赖。
- 原 ABTestManager 完成契约、模型字段与真实资源系统。完整 InitInfo 选择依赖原测试分组值。
- 存档/登录/LoadData 完成生产者。配置完成不代表用户数据加载完成。

Unity 的导入编译、各配置实际回调、loadingConfig 清空、DataManager 配置完成字段，以及后续存档/玩法初始化都必须由实际运行证据继续闭合。本阶段没有新增占位数据、默认成功或跨文件资源替代。
