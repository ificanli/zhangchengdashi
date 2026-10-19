# 任务 41 原旧配置消费链取证摘要

本子调查只读生产源码及原载荷；所有新文件在本 evidence 目录与本任务专属 ida 目录。专属数据库为 `work/parallel-41-config/ida/framework.i64`。两次 IDA 批次共导出 29 个精确 metadata 方法范围，所有实际 start/end 均与目标一致，image base=0。专属库仅接受 driver 的边界/原型/命名及保存，没有操作共享数据库。未启动或控制 Unity。

## 可直接支持的候选语义

- `GameStart.InitConfig` (`0x439B9B0–0x439B9F4`)：`ConfigMgr.Instance → SetConfigABRes(resourcesInfo) → ConfigMgr.Instance → Initialize → InitConfigOver`。初始化抛出后不会调用完成桥。
- `SetConfigABRes` (`0x6005AE9`, `0x4399EBC–0x4399F18`) 只写 `ConfigRead.configRes` 原 static+0x10，没有替换资源成功或修改分支标志。
- `Initialize` (`0x6005AE7`, `0x4399578–0x4399658`) 每次先设 `ConfigRead.IsUserJsonUtility=true`，然后 `AppSetting.IsUseMemoryPack=false`；仅 `IsInitialize=false` 时执行 `ReadConfig → customRead → IsInitialize=true`。两个消费者任一异常均阻止最后完成写入。已初始化时仍重设前两标志。
- `ReadConfig` (`0x6005AE8`, `0x4399658–0x4399BEC`) 实际调用是 38 张表后 3 个对象；不是前段 metadata 初始化的字母序。具体顺序/载荷/主键在 `resource-audit-41.json`，实际指令顺序在 `native-chain-golden.json`。
- `customRead` (`0x6005AEB`, `0x4399BEC–0x4399EBC`) 清空 `dicPoolConfigByPoolId`，按原 Pool 字典枚举，只收 `row!=null && pool_id>0`，以 `TryGetValue`/新建 List/`Add` 建组，同一行对象引用直接进入列表。原数据形成 9 组、51 行，见 `pool-group-original-data.json`。
- `get_Instance` (`0x6005AEA`, `0x4399F1C–0x4399F90`) 是 static，未有实例则分配并调用原构造再赋 `_instance`；没有锁、没有 MonoBehaviour。构造 (`0x6005AED`, `0x4399F90–0x439A9A4`) 按字段顺序创建 38 个表字典和 1 个分组字典，三个对象由后续读取赋值。`SetReloadConfigAction` (`0x6005AEC`, `0x4399F18–0x4399F1C`) 原本即 RET。
- `readConfigByUnityJson<T>` 共享原生实例 (`0x4B8CADC–0x4B8CBCC`)：`typeof(T).Name → 0x7168D84 → dispatch(source,asset,name,UnityJson) → requestedCounter++`；正常的缺资产日志路径仍增加计数，异常路径不增加。
- `A...i<T>` dispatch (`0x4B8B9B0–0x4B8BCEC`) 先调用 Unity 对象真值 `asset != null`。0=LitJson→`0x4B8E01C`，1=UnityJson→`0x4B8BF38`，2=MemoryPack→`0x4B8DD40`；缺资产日志 `配置文件不存在`+name；未知类型日志 `ConfigType error`+enum。
- **UnityJson 字典 helper 是 `0x4B8BF38–0x4B8C16C`，不是 `0x4B8E01C`。** 后者是 LitJson 的近似外形。UnityJson List helper 是 `0x4B8BEB4–0x4B8BF38`：`text.Substring(text.IndexOf("{")) → JsonUtility.FromJson<UnSerialization<T>>() → .Datas`。`il2cpp.h:983563` 起的原泛型上下文第0槽明确指定 `UnityEngine.JsonUtility.FromJson<UnSerialization<T>>`，第1槽为原 `GameFramework.UnSerialization<T>` 类型。
- 字典 helper 不 Clear，不覆盖。`Datas==null` 或空表返回且不访问 source；非空表每行先取 UniqueID，再 `source.ContainsKey`；重复键再次读该行 UniqueID、`CLog.Error(string.Format("表[{0}]中有相同键({1})",name,key))`，保留原值。新键再次取 UniqueID 后 Add。null 行抛 NRE；非空表的 source=null 在第一次 UniqueID 后抛 NRE。wrapper=null 抛 NRE。
- `readConfigVByUnityJson<T>` (`0x4B8D360–0x4B8D56C`)：`typeof(T).Name → helper → Unity真值 → text.Substring(text.IndexOf("{")) → JsonUtility.FromJson<T>`；缺资产原错误日志后返回 null；返回 null 的 JSON 结果直接返回 null。无表字典身份或计数语义可代入此方法。
- `BaseConfig.UniqueID` (`0x71656C0–0x71656F8`) 原本抛 `new NotImplementedException()`，不能返回 id/default/反射猜 key。
- `ConfigRead..cctor` (`0x6005765`, `0x716C144–0x716C238`) 元数据 Token 已用 Mono.Cecil 实读 DummyDLL：IsUserJsonUtility=false，isUseNewRes=AppSetting 对应属性，两个 int 计数=0，configAssetbundle=`"Data/Config/".TrimEnd('/')`，WebGL标志=false。

## 资源与 ABI

`resource-audit-41.json` 重新读取真实交付字节并检查所有 SHA256。38 张表合计 927 行，3 个对象完整值记录，所有主键无重复。每张表都从原 UniqueID getter 的 ARM64 字段 load 偏移映射到源声明字段，保存原 getter token/start/end/prototype/code hash；未按字段名猜测。41 份资源有各自原 PathID、container path、SHA 和实际 JSON 字段。

常规实例方法 native ABI 为 `(self, visible args..., const MethodInfo*)`。static ConfigRead 泛型入口无 self，其最后隐藏 MethodInfo 指向真实 T 的 RGCTX。`readConfigVByUnityJson<T>` 唯一参数就是隐藏 MethodInfo。`UnSerialization<T>.Datas` 是 object+0x10。IDA 模型的 `void*` 是用于守住寄存器 ABI 的局部最小原型，不等于恢复完整类型。

异步 state machine 的 Il2CppDumper 签名可能把 value type `__this` 打印为值；实际 MoveNext 指令读写 X0 指向的结构体，必须按托管 struct 实例指针解释。此任务当前路径同步，异步只导出取证，不计入候选闭合。

若伪 C 中出现 `JUMPOUT(nextMethodStart)`，已核对对应 ASM：均在末尾 raise/throw helper 后形成的伪继续流，不能接着恢复相邻方法。本批核心方法没有业务 outlined island 被遗漏。BaseConfig.UniqueID 的 JUMPOUT=0x71656F8 同属 throw 尾部。

## 原指令验证与边界

`native_chain_oracle.py` 用 Unicorn 直接执行原 ELF 指令，46 个案例全部通过。4 个 Initialize 案例覆盖首次、重复、ReadConfig 边界异常、customRead 边界异常；42 个 ReadConfig 案例覆盖完整 41 调用及逐个消费者异常。仅配置解析/分组消费者被 hook，原指令完成 MethodInfo 选择、38 个字典参数传递、3 个对象字段赋值、控制流和完成标志写入。未复制 C# 业务实现来制造 oracle。

追加 `native_dictionary_oracle.py` 直接执行原 `0x4B8BF38–0x4B8C16C` 的16个案例全部通过，只在解析List、List/Dictionary访问、虚UniqueID和分配/format/log边界设hook。覆盖 null/空Datas+null source、三行、内部/预存重复保留原对象、null source先调一次UID、null行、UID第一次/第二次异常、Contains/Add异常后的前缀保留、null key在Contains拒绝。变化getter返回 `[1,2]` 的案例还证明 UniqueID 未被缓存：原路径先Contains(1)后Add(2)，或重复时Format记录第二次UID=2。

此结果属于原生控制流边界验证，不能代替真实 Unity JSON 解析/ResourcesInfo/provider 或最终 PlayMode。当前生产 AppSetting.IsUseMemoryPack getter/setter 仍是空壳，setter `0x711F768` 原 STRB 写 static+0x3C，Token=0x6005160，backing field Token=0x40017D5；getter Token=0x6005163/RVA0x711F924。候选调用可遵循原契约，但该依赖需主窗口闭合，不能用测试 adapter 宣称生产字段已生效。

## 文件索引

- `targets-supplement.json`, `targets-batch2.json`：精确原函数名/start/end/完整原签名与局部应用原型。
- `status-batch1.json`, `status-batch2.json`：IDA 实际边界、直接调用、原型应用和 JUMPOUT 标记。
- `pseudocode/*.c`, `*.asm.txt`：29 个目标的实际导出。
- `original-declarations.json`：DummyDLL 原 Token/RVA/static/virtual/泛型声明证据，声明不当作正文。
- `resource-audit-41.json`, `*-UniqueID.asm.txt`：41 真资源及38原主键getter审计。
- `native-chain-golden.json`：46 个原 ARM64 结果。
- `native-dictionary-golden.json`：16 个原 UnityJson 字典helper ARM64结果。
- `pool-group-original-data.json`：原51条池配置按原规则分组的预期身份列表。
