# 旧配置资源独立审计

本轮直接重读交付字节、SHA-256、当前类型声明及原 ARM64 getter；未启动 Unity，未写共享工程。

50 TextAsset = 43 张 Datas 表（951 行）+ 5 个 JSON 对象 + 2 份空 BOM/CRLF。ConfigMgr 直接消费 38 张表（927 行）与 3 个对象。143 项交付文件长度及 SHA-256、50 项 payload 映射均通过。

38 张直接消费表的主键均由原 getter 实际读取的字段偏移确定，类型均为 int，零重复、零空值。当前 38 个源 getter 均 return null；它们是三文件候选之外的精确依赖。构造函数均已单独导出，详情见 JSON，不能把 DummyDLL 的空体视为原方法。

| TextAsset | 直接消费 | 结构 | 行数 | 主键 | 不同主键 | 字段 |
|---|---|---|---:|---|---:|---|
| TotalDiceConfig | 是 | Datas-table | 66 | id | 66 | count, id, isBig, item, itemType, totalCost |
| PropAttrEnumInfoConfig | 是 | Datas-table | 34 | ID | 34 | ID, Max, RankUpFactor, Type, UpgradeFactor |
| ConfigType | 否 | config-object | — | — | — | configType |
| MLanguageImageConfig | 否 | Datas-table | 1 | id（仅序列化候选） | 1 | en, id, ja, ko, zh_cn, zh_tw |
| AIPropInfoBConfig | 是 | Datas-table | 15 | arnenaLevel | 15 | AIPropNum1, AIPropNum2, AIPropNum3, AIPropNum4, AIPropRank1, AIPropRank2, AIPropRank3, AIPropRank4, AIPropUpgrade1, AIPropUpgrade2, AIPropUpgrade3, AIPropUpgrade4, arnenaLevel |
| SettingConfig | 是 | config-object | — | — | — | AllMusic_PlayWaitTime |
| LimitedPropInfoConfig | 是 | Datas-table | 8 | id | 8 | Item, Number, ShowWeight, Weight, id |
| LimitedPropOrderConfig | 是 | Datas-table | 6 | id | 6 | PropID, id |
| PropAttrTypeConfig | 是 | Datas-table | 7 | ID | 7 | Des, Factor, ID |
| PropAttrBuffInfoConfig | 是 | Datas-table | 18 | id | 18 | Attr, Rare, id |
| PropForgePowerConfig | 是 | Datas-table | 3 | Type | 3 | Factor, Type |
| CrystalPackConfig | 是 | Datas-table | 3 | id | 3 | Benefit, DailyCount, LimitType, PackDes, PackID, id, rewards |
| BuildConfigConfig | 是 | Datas-table | 13 | id | 13 | buildIndex, build_type, des, id, image, name, pool_id |
| OnceAudioConfig | 否 | config-object | — | — | — | AudioInfos |
| ChessboardConfig | 是 | Datas-table | 24 | id | 24 | build_id, id |
| SubGameBuffConfig | 是 | Datas-table | 20 | ID | 20 | Des, ID, Icon, Name, Rare, Weight |
| SaleShopConfig | 是 | Datas-table | 30 | id | 30 | buyCount, buyItem, count, id, item, itemType, saleTag, weight |
| all | 否 | empty-text | — | — | — |  |
| AIPropInfoCConfig | 是 | Datas-table | 15 | arnenaLevel | 15 | AIPropNum1, AIPropNum2, AIPropNum3, AIPropNum4, AIPropRank1, AIPropRank2, AIPropRank3, AIPropRank4, AIPropUpgrade1, AIPropUpgrade2, AIPropUpgrade3, AIPropUpgrade4, arnenaLevel |
| PoolConfigConfig | 是 | Datas-table | 51 | id | 51 | count1, count2, id, item1, item2, itemType1, itemType2, pool_id, weight |
| WorldCuphow2PlayConfig | 是 | Datas-table | 7 | id | 7 | des, id |
| WorldCupdailyTaskConfig | 是 | Datas-table | 4 | id | 4 | count, des, id, item, itemType, jump, parameter_nomal, parameter_progress, taskType |
| WorldCupdailyPriceConfig | 是 | Datas-table | 6 | id | 6 | PayLimit, PriceId, PriceName, count1, count2, count3, id, item1, item2, item3, itemType1, itemType2, itemType3, saleTag, showType |
| LimitedPropPackConfig | 是 | Datas-table | 8 | id | 8 | Benefit, DailyCount, LimitType, PackDes, PackID, Type, id, rewards |
| PropRankUpInfoConfig | 是 | Datas-table | 31 | Level | 31 | Cost, Level, R, Rank, RankUpAttrCurve, SR, SSR, SSSR, Star |
| EffectConfig | 否 | Datas-table | 1 | id（仅序列化候选） | 1 | duration, id, res, type |
| DailyPriceConfig | 是 | Datas-table | 6 | id | 6 | PayLimit, PriceId, PriceName, count1, count2, count3, id, item1, item2, item3, itemType1, itemType2, itemType3, saleTag, showType |
| AudioConfig | 否 | Datas-table | 2 | id（仅序列化候选） | 2 | Atype, EndTime, Ptype, ResPath, StartTime, VoiceType, Vol, id |
| DiceConfigConfig | 是 | Datas-table | 6 | id | 6 | id, weight |
| DailyTaskConfig | 是 | Datas-table | 8 | id | 8 | count, des, id, item, itemType, jump, parameter_nomal, parameter_progress, taskType |
| GoalRewardConfig | 是 | Datas-table | 17 | id | 17 | count, id, item, itemType, weight |
| WorldCupbaseConfigConfig | 是 | config-object | — | — | — | activity_id, goalPoints, ungoalPoints, goalProbability, initBall |
| BaseConfigConfig | 是 | config-object | — | — | — | activity_id, duration_days, face_min, face_max, recover_interval_hour, natural_cap |
| CompareShenqiInfoConfig | 是 | Datas-table | 18 | id | 18 | NameIconPath, Rare, id, name |
| How2PlayConfig | 是 | Datas-table | 6 | id | 6 | des, id, image |
| CumulativeRewardConfig | 是 | Datas-table | 6 | ID | 6 | ID, NeedDays, Num, RewardID, RewardType |
| LapsConfigConfig | 是 | Datas-table | 20 | id | 20 | count, id, item, itemType, needExp, resourcesUp |
| CheckInRewardsIndexConfig | 是 | Datas-table | 2 | ID | 2 | CheckInRewards, CumulativeRewards, ID |
| PointShopConfig | 是 | Datas-table | 17 | id | 17 | buyCount, buyItem, count, id, item, itemType, saleLimit |
| AIPropInfoConfig | 是 | Datas-table | 15 | arnenaLevel | 15 | AIPropNum1, AIPropNum2, AIPropNum3, AIPropNum4, AIPropRank1, AIPropRank2, AIPropRank3, AIPropRank4, AIPropUpgrade1, AIPropUpgrade2, AIPropUpgrade3, AIPropUpgrade4, arnenaLevel |
| CompareCardInfoConfig | 是 | Datas-table | 40 | id | 40 | Rare, id, name |
| LanguageConfig | 否 | Datas-table | 1 | id（仅序列化候选） | 1 | It, Ma, Th, Vi, ar, en, fr, ge, id, ja, ko, po, ru, sp, zh_cn, zh_tw |
| WordEmojiConfig | 是 | Datas-table | 26 | ID | 26 | ID, Name |
| PurchaseConfig | 是 | Datas-table | 128 | id | 128 | ABTest, Des, ProductData, channel, id, price, productID, productName, type |
| VideoBtnConfig | 否 | Datas-table | 19 | id（仅序列化候选） | 19 | AudioId, ReportLable, VideFlag, id, showType |
| PropUpgradeInfoConfig | 是 | Datas-table | 150 | Level | 150 | CrystalCost, Level, NeedRank, UpgradeAttrCurve |
| CheckInRewardsConfig | 是 | Datas-table | 60 | ID | 60 | ID, Num, RewardID, RewardType |
| RuinsConfigConfig | 是 | Datas-table | 5 | id | 5 | id, image, image_txt, option_txt1, option_txt2, option_txt3, reward1, reward2, reward3, weight |
| CdkConfig | 是 | Datas-table | 28 | id | 28 | cdk, content, id |
| LayerCollisionMatrix | 否 | empty-text | — | — | — |  |

## 三个直接对象

- `SettingConfig`：`{"AllMusic_PlayWaitTime": 3000}`
- `WorldCupbaseConfigConfig`：`{"activity_id": 1002, "goalPoints": 50, "ungoalPoints": 20, "goalProbability": 60, "initBall": 5}`
- `BaseConfigConfig`：`{"activity_id": 1001, "duration_days": 7, "face_min": 1, "face_max": 6, "recover_interval_hour": 14400, "natural_cap": 10}`

ConfigType 原值为 {"configType":1}，1 对应原 ConfigType.UnityJson。OnceAudioConfig 是含 AudioInfos 的对象。两者不在 ConfigMgr 本次直接 41 项中。其余五张框架表的序列化 id 唯一性已统计，但未将资源名与行类型作未经证实的等同。

PoolConfigConfig 的 51 条原行按 pool_id 得到 9 组：1001/1002/1003/1004 各 1 行，2001 为 2 行，2002 为 9 行，2003/2004/2005 各 12 行；原行 id 顺序在 JSON 中保留，可验证分组引用身份。

## 加载和解码证据

已核读交付 README、Editor 映射计划及 0x71758D0/0x7175D04/0x7363F34/0x736221C 原伪 C。0x71758D0 优先使用非空传入 key，空 key 才用默认；0x736221C 在下载完成后读取 data、用实例 +0x20 的 key 解码，再 LoadFromMemory。清单用 WeDoBest，两个数据包用 manifest header 的 RandomSeed。143 项本轮哈希通过覆盖了该链的既有原始、解码与代码证据，未把 provider 测试当作 Unity 接入验收。

## 复跑

`C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe -X utf8 audit_resources.py`。脚本只向自身 resource-audit 目录写结果；原 ELF SHA 为 72770d00b2b404acf44cc75cc8bf7a3e06850e9ace1237c9cbb2bc72894220ed。
