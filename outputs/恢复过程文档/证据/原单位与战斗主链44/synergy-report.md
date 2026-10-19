# 44号子证据：SynergyEffectManager 原羁绊链

本子任务仅在 `work/parallel-44-battle/candidate/Assets/Scripts/Assembly-CSharp/GameModule/SynergyEffectManager.cs` 写入候选，未修改共享工程。新增 32 个普通方法正文（含 `Init`）、2 个原生成状态机正文；通过字段初值恢复原构造时的 ABTest 读取及其先于基构造的次序。原先已经验证的 `InternalCalculateDamage` 连同注释和 CRLF 换行逐字节保留。

类内 36 个原方法及 UniTask `Start<SynergyEffectManager.<Init>d__1>` 实际泛型实例共 37 个目标均已交由父代理专属 IDA 导出。完整目标在 `synergy-targets.json`；IDA 证据在 `ida/pseudocode/`，本分支独立原机器码及 Capstone 解码在 `synergy-validation/native/`。没有操作 IDA 数据库，也没有调用 Unity。

## 原始契约与恢复内容

`GetFetterCount` (`0x3E0F480`) 和 `GetAtkWayTypeCount` (`0x3E0F5F8`) 不读取“羁绊等级”。它们依据 `isEnemy` 从原 `AIBehaviourManager` 或 `EquipCardInfoManager` 的六个计数字段读取。两类计数 getter 之前已有原生字段恢复，候选调用这些现存 getter。非法枚举值原样返回 0，不访问单例。敌方原字段为 `0xC4/0xC8/0xCC/0xD8/0xD0/0xD4`，我方为 `0x50/0x54/0x58/0x64/0x5C/0x60`。

原构造 `0x3E1016C` 先读取 `SDKModule.ABTestManager.Instance.GamePlayImprove01IsBTest`，写入 `IsUseNewFetter` (`object+0x20`)，再执行 `ManagerBase<SynergyEffectManager>` 构造。候选使用字段初值表达这一顺序；保留原空的显式构造正文与隐式基构造。两个原构造输入的指令执行轨迹和 C# 适配基构造观察完全一致。

生产时间函数 `0x3E0F6D4` 按 `original + original * -0.1f` 计算，未达到门槛直接返回原值。原 ABI 是 x0=this、s0=float、w1=isEnemy、w2=count、w3=required，IDA 未加类型时伪代码的参数顺序不能用作 ABI 证据。本次原 ARM64 实际执行使用该 ABI，并完整执行函数。

普通攻击加成沿用已恢复的 `InternalCalculateDamage`，保持 int32→float32→0.5f→向零截断→int32 加法。人类六羁绊产量及近战七羁绊生命的系数为 0.2f；新兽人对建筑伤害系数为 0.75f。新兽人移动和新机械射程为 `bonus + original` 的两步 float32；远程七羁绊射程系数为 0.1f。没有把浮点转换替换为整数除法，没有将两次浮点操作改为单次倍率相乘。

原新旧模式的门控均保留：旧的人类/兽人/机械二羁绊生产时间和旧四羁绊攻击在新模式下返回输入；机械四羁绊攻击仍对两种模式有效；亡灵二羁绊生产时间在新模式下降 20%、旧模式下降 10%。旧亡灵六羁绊 `Range(0,100)<10`；新亡灵六羁绊直接为真，新四羁绊复活才消耗同样的随机抽样。未达到门槛时不消耗随机数。

`HumanFetter4_DamageReduction` (`0x3E0F8AC`) 要求新模式、目标是原 `RoleBehaviour` 且 `CardFettersType=Terran`、同方人类计数达到 4，再调用 `BattleGameSceneManager.Instance.GetNearRole(isEnemy,target,checkRange,-1)`。列表非空且 Count>0 时按 `damage - (int)((float)damage*0.2f)` 返回。`MachineFetter6_RemoteDamageReduction` (`0x3E1003C`) 仅接受远程攻击、新模式、机械单位或机械建筑、同方机械计数达到 6，按 float32 的 0.5f 减伤。原生类型检查保留为 C# `is`，没有增加 Unity 重载的对象存活/null 判定。

`Init` (`0x3E0F400`) 的原状态机没有业务副作用或等待：构造 builder/state=-1、Start 原结构体、MoveNext 写 state=-2 并 SetResult、返回 builder.Task。候选恢复这条真实 builder 路径；没有伪造启动状态或绕过主流程的等待。`SetStateMachine` 原样转发 builder。原 ARM64 入口和两个转发过程的证据见 `native-init.json`。

## 验证及其有效性

`native_oracle.py` 从 SHA256 为 `72770d00b2b404acf44cc75cc8bf7a3e06850e9ace1237c9cbb2bc72894220ed` 的原 ELF 读取 PT_LOAD 与 RELA，借助 Unicorn 执行完整业务方法。32 个业务方法共 3200 案例，另执行 2 个构造输入及原 Init/状态机路径。原类内 `GetFetterCount` 和 `GetAtkWayTypeCount` 也执行真实 ARM64 字段读取，未被 hook 替代。

仅对原外部依赖设置适配 hook：两个 ManagerBase 单例、ABTest 单例/属性、基构造、Random.Range、GetNearRole、UniTask builder 的库接口，以及运行时 class-init/null helper。机器码中的门控、计数分派、类型检查、数值规则、抽样调用条件与顺序均由原 ARM64 执行。`native-summary.json` 列明 hook 地址，`native-oracle.json` 保存每个输入、输出、外部调用轨迹。

`SynergyTests.csproj` 直接 Compile Include 实际候选完整文件。`audit.py` 再从实际候选提取所有成员正文至 `candidate-method-readback.json`。测试没有维护另一份羁绊实现：C# 只保留必要类型/属性/Unity API 的 adapters，通过反射调用候选原成员，逐条比较原 ARM64 的返回值和调用轨迹。

覆盖双方独立计数、新旧 AB 模式、无效枚举、各门槛两侧、正负整数、16,777,219 float32 精度边界、int32 首尾、float32 正负零/无穷/NaN/非正规值、单位/建筑/其他类型/null、人类邻近列表 null/空/非空、随机 9/10 边界、最大生命 0/负数、生命比例半血两侧。有限数与零按 float32 bit 比较；两个结果都为 NaN 时按 NaN 语义相等，不主张 NaN payload 完全一致。

| 验证层 | 结果 | 证据 |
| --- | --- | --- |
| source-before 原空桩负对照 | 6408 检查、3339 失败，exit=1 | `baseline-tests.log` |
| 实际候选完整文件适配编译/执行 | 6408 检查、0 失败，exit=0 | `candidate-tests.log` |
| 原 ARM64 完整业务执行 | 32 方法、3200 案例、无执行异常 | `native-oracle.json`、`native-summary.json` |
| 原构造执行 | 2 模式，属性读取/写字段/基构造顺序吻合 | `native-constructor.json` |
| 原 Init 入口/状态机 | state=-2、runner=0 完成任务，SetStateMachine 偏移+8 | `native-init.json` |
| 保护审计 | 原伤害正文逐字节不变，所有 Token/声明、非本批区域、共享 source/meta 不变 | `audit.json` |
| 真实 Unity 引用独立 csc | 由父代理汇总执行 | 父任务 44 主报告 |
| Unity/PlayMode/原战斗验收 | not-run | 本任务禁止启动，由主窗口统一验收 |

开发测试期间先发现夹具顶层 `args` 命名冲突，改为 `invokeArgs`；随后检测到宿主未安装 .NET9 runtime，将独立夹具目标框架设为宿主已有 .NET8。两项都发生在夹具层，没有修改恢复代码或安装运行时来改变共享环境。最后对源文件 CRLF 做保留并重新运行审计及候选测试，结果仍为 6408/0。

复现命令（根目录为 x20）：

```powershell
& 'C:/Users/luxinyu/AppData/Local/Programs/idapromcp/source/.venv/Scripts/python.exe' -X utf8 work/parallel-44-battle/synergy-validation/native_oracle.py
dotnet run --project work/parallel-44-battle/synergy-validation/SynergyTests.csproj -c Release -p:Baseline=true
dotnet run --project work/parallel-44-battle/synergy-validation/SynergyTests.csproj -c Release
& 'C:/Users/luxinyu/AppData/Local/Programs/idapromcp/source/.venv/Scripts/python.exe' -X utf8 work/parallel-44-battle/synergy-validation/audit.py
```

## 原主链调用者与仍待恢复依赖

原 ARM64 直接分支扫描在 `native-callers.json` 保留 36 个类外调用点，包含 2 个元数据覆盖范围之前的 native thunk（明确标为未知身份，不误归属托管方法）、UniTask 的真实 Start 泛型，以及 33 个游戏业务调用点。主要调用者为：

- `RoleBehaviour.Wound`：人类邻近减伤、机械远程减伤；近战/远程初始化：攻击、生命和射程。
- `MachineBehaviour`、`OrcsBehaviour`、`TerranBehaviour`、`UndeadBehaviour` 的原初始化/攻击回调：派生兵种羁绊。
- `ArchitectureBehaviour.Init/FetterChangeCreatSpeed/MyUpdate`：建筑生命、生产时间、金币；`ResourcesArchitectureBehaviour.Init`：人类产量。
- `BarracksArchitectureBehaviour.Init`：亡灵额外生成；`DefenseArchitectureBehaviour`：机械/远程与被击减伤。

这些派生文件仅只读，没有越权补写。恢复当前类不会自动恢复仍为空的兵种/建筑原入口，也不会自行产生兵堆、播放动画或推进寻路。`GetNearRole` 的真正距离/阵营过滤由本任务父代理负责候选；适配测试只证明本类传入的 `isEnemy/target/checkRange/-1` 及后续列表判断正确，不声称原地图距离或单位注册已验收。

ABTest 属性和两方计数的生产更新链仍需对应拥有者恢复；目前 getter 已有字段正文，字段何时正确更新不能从当前类推断。随机引擎、Unity 对象类型/资源、ManagerBase 初始化和 UniTask 调度均未用 Unity 运行验收。Astar/GPU 动画没有由本类直接调用，也没有在此制造替代实现。

候选 SHA256：`d51152b9fb2ae5eae0a33071259e9ed2dc95de39a68ecea41680c656ee86109d`；起始源 SHA256：`9ef81382d7ff42dd9ee69e669cb085bbd400b7cdeb69f3d5c29848281b5dff33`。候选交主窗口 source-before SHA 检查后统一合入；此分支结果不代表原场景/原单位战斗已经可运行。
