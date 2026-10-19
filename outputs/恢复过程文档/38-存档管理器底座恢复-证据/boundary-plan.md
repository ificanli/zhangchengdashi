# Stage38 最小存档底座边界计划（只读取证阶段）

生产源码尚未修改。原文件、Token、GenericInst 和 native target 位于本目录清单，root 负责共享 IDA 导出及实际 Unity。

## 已有证据

1. `DbtSaveDataManagerBase<T,TD>` 原 TypeToken0x02000073，T约束自身基类，TD约束ServerBaseData与new()。原Data property0x1700001F、get/set0x06000265/266、backing0x0400021B，三者CompilerGenerated证据齐全。共享native getter0x6AF3D70/setter0x6AF3D78直接读写实例+0x30；恢复auto property安全。I是原普通staticfield0x04000219，不能改lazy singleton。
2. OnInit0x6AF3D80：记录原日志、I=(T)this、_name=typeof(T).Name、_lastSaveData=ReadLocalData()，再UpdataData(false)。这只准备原持久化字符串，不直接创建TD。
3. Load0x6AF4198：仅Data==null时处理；_lastSaveData为空则再ReadLocalData；仍空时new TD→InitFromDefaults；有数据时GZipDecompressString→JsonConvert.DeserializeObject<TD>；最后实际Data.Init。原GetData0x6AF42C8不调用Init，只空串new+Defaults或非空解压+Deserialize。
4. Save0x6AF43D4：条件为!_cleared && CanSave && LoadingManager.EnterHome；OnBeforeSerializeForSave→JsonConvert.SerializeObject→GZipCompressString；压缩结果非空才存_lastSaveData与SaveLocalData。不能放松任何门条件。
5. 原Dbt ctor0x6AF47D0只_lastSaveData=""→base。原GF base ctor0x7173018：local/server两个实例bool均true、hash字段string.Empty。OnSave0x6AF4178在未clear时再次保存_lastSaveData；Clear0x6AF44FC幂等、原日志、SaveLocalData("")；LoadFormMemory0x6AF43AC实际赋Data后调用Init，null自然异常。
6. PlayerTimeData实际原ctor0x4376AFC分配Dictionary<string,TimeInfo>后调用ServerBaseData。原TimeManager33直接消费此类，scope不需要虚构独立Timer.cs或TimeData.cs。
7. 原JSON schema使用[JsonProperty]缩写字段；不得改MemoryPack。新对象ctor初始化dictionary；反序列化输入明确给tid=null时不能擅自替换新字典。无效格式不得静默变成新用户数据。

## 原路径和明确适配边界

- GF DataManagerBase ReadLocalData0x717284C调用原底层存储读取，以原DataKey及server标志为参数；第三个compressionflag成立时再走原Utils.DecompressData。
- SaveLocalData0x7171E48还含命名验证、MD5未变化判断、原额外压缩、local/server保存、版本登记和SDK参数。当前原SDK/存储闭包未恢复，不应通过设置登录或服务端状态越过。
- 原Pool负责模型注册与原OnInit触发，不能通过Data getter创建TD、staticI lazynew、枚举几十manager直接赋值来替代。
- 建议Editor适配只放在ReadLocalData/SaveLocalData的实际平台I/O边界，日志包含LocalEditorStore。存取原压缩字符串，不接触MuMu或Application.persistentDataPath的原用户存档。
- 候选独立目录：从当前Application.dataPath解析`../../../work/occupycity-localeditor-store`，在当前任务布局中对应本任务work。必须把解析后绝对路径记录在日志及报告；文件名仅由原DataKey的稳定哈希生成，避免任意key越界。此具体路径及落盘实现待root批准后定案。
- Editor适配不得写CanSave、LoadingManager.EnterHome、ServerTimeMgr、任何登录/绑定/服务器成功标志。原generic Save门在适配前继续执行。没有数据时底层读取返回原空字符串，由原Load决定new/default/init流程。
- 非Editor分支保留原调用与未完成外部边界；不能谎称服务端同步闭环。

## 所需最小第二批证据

`supplement-targets.json`20项：DataCompressTools存档专用6方法+cctor；Pool6入口；底层命名/读/写3项只读；ModelRegister构造和3真实属性4项。当前均为静态native取证，不执行任一存档I/O。

另：GF命名验证0x7171B08的伪C遗漏catch块。ARM64明确包含catch、原日志和false返回；必须按ASM恢复异常边界，不能根据精简伪C宣称无异常分支。

## 拟验证契约

- metadata：双CompilerGenerated、backing、GenericInst槽、shared getter/setter偏移和原成员不变。
- 原JSON+压缩往返：中文、DateTime Kind、空dict及已保存timer，确认缩写schema；空串与无效base64/gzip/json分别匹配原异常/返回契约。
- 生命周期：OnInit只登记I与获取字符串；Load只一次初始化，空档Defaults→Init；GetData不Init；LoadFormMemory实际Init。
- 原保存门：未EnterHome／CanSave=false／cleared时不写；hook和序列化顺序不变；Clear幂等；OnSave只写缓存。
- Pool：按native确认注册→OnInit原顺序与重复类型行为，不手工lazy赋I。
- EditorI/O：只用本任务独立work测试目录；两种manager/key隔离；首次不存在返回空；真实压缩串写入后读回；没有任何MuMu、用户存档、network/login flag访问。
- 实际Unity引用独立GF/main csc与受控CLR边界分层验证；Unity导入/运行由root统一执行。

在第二批native证据和最小scope获root审阅前，继续只在work编写候选、清单和fixture，不改生产。
