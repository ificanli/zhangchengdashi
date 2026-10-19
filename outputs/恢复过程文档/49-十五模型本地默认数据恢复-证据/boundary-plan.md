# Stage49 真实15模型默认数据闭包计划（生产未授权）

## 授权边界与证据来源

按 `work/stage45-data/native-golden.json` 首个 `LoadAllSaveData / missingIndex=-1 / error=null` 实际成功序列提取15个模型，而非从命名猜数据类型。每个模型的原GenericInstanceBase第二参数决定真实TD，原DummyDll读取类型、字段、JsonProperty、方法Token/RVA，再与当前真实源和meta哈希对照。

初步工作文件：`model-inventory.json`、`native-targets.json`、`proposed-scope.json`。当前14份TD源码只列为候选，不具有生产写入授权。受保护项包括：38的PlayerTimeData ctor、原108/新145已恢复访问器、45编排、38持久化底座、46原账号模式默认值及其余并行源。

## 原加载与初始化契约

38原Load在Data==null时：读取原压缩字符串；空档new TD并执行InitFromDefaults；已有档反序列化TD；两条路径最后执行Init。原GetData空档只new+Defaults，没有Init。因此三类方法各有职责，不能用一份“填所有默认值”的helper代替。

字段缺失、JSON显式null、旧档迁移和新档初始化应按各自native分支恢复；不能在所有null处自动new集合，也不能强行覆写旧档已有值。

## 初始36个native目标

| 原加载索引 | 真实TD | 候选方法数 | 备注 |
| --- | --- | --- | --- |
| 0 | PlayerMainCityData | 3 | ctor/default/init |
| 1 | PlayerCardData | 3 | ctor/default/init |
| 2 | PlayerShopData | 3 | ctor/default/init |
| 3 | PlayerArenaData | 3 | ctor/default/init |
| 4 | PlayerRankData | 2 | ctor/init，Defaults继承base |
| 5 | PlayerResourceData | 3 | ctor/default/init |
| 6 | PlayerChestData | 3 | ctor/default/init |
| 7 | PlayerTimeData | 0 | 38ctor保护，Init/Defaults继承base |
| 8 | PlayerAdData | 3 | ctor/default/init |
| 9 | PlayerArtifactData | 3 | ctor/default/init |
| 10 | PlayerCustomizationData | 3 | ctor/default/init |
| 11 | PlayerCoreData | 3 | ctor/default/init |
| 12 | PlayerGuideData | 2 | ctor/default，Init继承base |
| 13 | PlayerMysteryAdventureData | 1 | ctor，Init/Defaults继承base |
| 14 | PlayerWorldCupActivityData | 1 | ctor，Init/Defaults继承base |

这15个TD没有声明自己的static ctor。继承的ServerBaseData.Init/InitFromDefaults原native为无业务noop，不因当前空正文自动判为缺陷或添加新逻辑。

## native输出后的最小分类

1. 纯构造字段：原new字典/list、常量、日期和本地嵌套数据对象。按原分配顺序和字段身份恢复，不顺手填入原本留空的字段。
2. 纯本地Defaults/Init：仅集合和本地状态，按原新档／旧档分支恢复。native原noop保留，不计新增恢复量。
3. 配置依赖：记录具体GlobalInfo／表／字段及消费者，不猜初始单位、货币或关卡数值。仅当实际配置源和读取链已成立才实现对应原调用。
4. 外部SDK/用户ID/事件：明确实际输入和失败／null行为；没有原生产者则保持可见未知边界，不用空UID、登录成功、默认服务器响应或门true填补。
5. 构造必需的子数据闭包：只对native直接调用且会影响真实字段内容的子ctor/小helper列有界追加候选；不扩成整套玩法、几十数据类或SDK生态。

## 拟验证

- 每个目标保留原Token/RVA/fields/meta，非目标成员（尤其既有访问器）逐字不变。
- 纯构造使用原ARM64字段写入／分配顺序作为独立oracle，再执行真实候选TD构造并读取真实字段；不用简化替代TD。
- 分开验证空档Defaults→Init、已有JSON反序列化→Init、明确null和旧档字段缺失；不镜像实现写假“成功加载”测试。
- 配置／事件／SDK外部边界用实际source接口核对，无法验证部分明确not-run，不宣称完整15模型数据已可用。
- 实际Unity引用独立main编译与运行时实际acceptance分层；不操作用户GUI Unity，由root统一观察。

在36方法native分类和最小写入闭包经过root审阅前，仅在work整理证据和候选，不写生产文件。
