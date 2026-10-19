# 占城大师：首轮实际反编译结果

本轮已完成 IDA 9.4 加载目标 ARM64 库、MCP 连接、七个方法的范围分析与伪 C 导出。保存后的数据库已重新打开，并通过 MCP 再次反编译 HexDistance 验证。尚未恢复完整的 C# 工程，尚未在 Unity Editor 运行游戏。

## 环境验证

- 输入：`libil2cpp-arm64.so`，SHA256 `72770d00b2b404acf44cc75cc8bf7a3e06850e9ace1237c9cbb2bc72894220ed`。
- IDA：9.4；处理器：ARM64；映像基址：`0x0`。
- Hex-Rays：`9.4.0.260713`，已实际返回方法伪代码。
- MCP：`check_connection` 返回 `成功连接到 IDA Pro (打开文件: libil2cpp-arm64.so)`。
- 当前数据库：本目录的 `zhancheng-targeted.i64`，约 944 MB。
- 采用目标方法范围分析，未执行全库自动分析；数据库中的其他方法不应视为已分析完成。
- 已应用首批最小类型与参数声明，并补入一部分方法名映射。

`analysis-status.json` 记录七个方法的范围、调用目标、类型应用和导出结果。`live-connection.json` 与 `live-hex-distance.json` 是保存数据库重新打开后的 MCP 真实调用记录。

## 已导出的七个方法

| 原方法 | RVA | 文件 | 当前质量 |
|---|---|---|---|
| HexManager.HexDistance | `0x3D2A600` | `pseudocode/0x3d2a600.c` | 计算主体完整，无 JUMPOUT；包含尚未命名的运行时初始化调用 |
| BattleGameSceneManager.GetAvailableSlots | `0x3DED9AC` | `pseudocode/0x3ded9ac.c` | 主分支已对照汇编；有局部变量分配警告、异常路径 JUMPOUT |
| SynergyEffectManager.InternalCalculateDamage | `0x3E0F6F0` | `pseudocode/0x3e0f6f0.c` | 标量计算主体完整，无 JUMPOUT |
| BattleGameManager.ChangeCoin | `0x3DE3CF4` | `pseudocode/0x3de3cf4.c` | 数值写入与事件调用可见；有局部变量分配警告、异常路径 JUMPOUT |
| HexBehaviour.DetermineHexCamp | `0x44298EC` | `pseudocode/0x44298ec.c` | 主分支已对照汇编；异常路径未完全还原 |
| HexBehaviour.OpenHex | `0x4424D5C` | `pseudocode/0x4424d5c.c` | 可见开格、表现和双方集合更新调用；仍需补全类型和异常路径 |
| GameLauncher.Start 状态机 MoveNext | `0x4195B70` | `pseudocode/0x4195b70.c` | 可见等待任务、Loading 和 Login 调用；异步状态与异常路径未完整重建 |

每个 `.c` 文件旁边均有同名 `.asm.txt`，保留相应地址范围的 ARM64 汇编。伪代码是分析材料，不是可直接编译运行的 C# 源码；尤其不要忽略其中的警告或自行删除异常路径。

## 已能从方法正文确认的规则

### 六边形距离

在正常地图坐标范围内，计算为：

```text
(abs(a.q - b.q) + abs(a.r - b.r) + abs(a.q + a.r - b.q - b.r)) / 2
```

HexCoord 是两个 int32 组成的 8 字节值类型，按值传递。若做严格逐位还原，必须保留原生 32 位溢出行为；直接使用 C# `Math.Abs(int.MinValue)` 会产生与原生 CNEG 不同的异常行为。

### 羁绊攻击加成

`InternalCalculateDamage` 对有符号整数比较 `fetterCount >= requiredCount`：

- 不满足门槛：返回 `originalAttack`。
- 满足门槛：先把攻击转换为 float32，乘以 `0.5f`，向零截断为整数，再与原攻击做 32 位加法。

该方法的机器指令没有读取 `self`、`isEnemy` 或 `IsUseNewFetter` 字段。普通正数示例：攻击 101 达到门槛时得到 151。严格还原时不能直接换成整数除二或整体乘 1.5，否则浮点精度和截断顺序可能不同。

### 兵力名额受 A/B 开关控制

该方法先读取 `ABTestManager.GamePlayImprove01IsBTest`：

- 开关为 false：返回 `int.MaxValue`。
- 开关为 true：按敌我选择当前数量与预留数量，返回 `Max(0, 100 - 当前数量 - 预留数量)`，运算具有原生 int32 语义。

因此不能只看到 `MAX_ROLE_COUNT=100` 就认定所有用户/分组都执行 100 的上限。当前包实际运行时开关值尚未核查。

### 阵营判定与占领

在正常、非空、数量非负的角色列表前提下，`DetermineHexCamp` 只对 `isOpened == false` 的格子进行检查：

- 双方都有角色，或双方都没有角色：不触发占领入口。
- 只有玩家角色、格子标为敌方：调用 `EncroachmentEnemy`。
- 只有敌方角色、格子标为玩家方：调用 `EncroachmentPlayer`。

这里的方法命名指向被侵占的一方，不能仅根据名字反推行动方。占领动画、计时和完成后的所有副作用还需要分析对应异步状态机。

## 资源与场景的新证据

资源探测详见 `资源探测.md` 与 `resource-summary.json`。

- 主资源包能解析到 1,078 个 GameObject、4,146 个 MonoScript、1,631 个 MonoBehaviour。这些是序列化对象和类型引用，不能当作已恢复源码。
- BuildSettings 中的初始场景是 `Assets/GameRes/BundleRes/Scene/MineGameMain.unity`。
- 初始场景的 Main 对象挂载 `GFRunning.dll` 的 `GameStartEntry` 和 Assembly-CSharp 中的启动、登录、服务管理组件。
- Addressables 目录还包含 `Assets/_Scene/Game.unity`，19 个目录引用的本地 Android bundle 均存在于 APK。本轮只抽样解析其中最小的 Shader bundle。
- 主包剥离了 TypeTree，多数自定义 MonoBehaviour 字段尚未恢复；当前只读取了通用头和脚本引用。
- 已检查的 141 个 TextAsset 中没有发现可直接加载的原始或普通 base64/gzip 编码的托管 DLL；122 个为编码后的 JSON 数据表。该结果不覆盖未抽样的 bundle。

这说明恢复工程需要把外层启动框架与 Addressables 游戏场景对应起来，不能只把 GameLauncher 的类名当作已证实的首场景入口。

## 下一步所需工作

1. 对主要运行时辅助函数和被调用方法补全类型与不返回属性，消除错误参数推断；所有修改应以汇编为依据。
2. 继续还原开格、兵堆生成、占领与地图初始化的调用链，特别是异步 MoveNext。
3. 基于 Dummy DLL/元数据恢复资源中的自定义脚本字段，导出场景与 Prefab 及其依赖。
4. 在独立 Unity 工程中恢复方法实现并处理平台接口，再分别验证编译、资源绑定和实际玩法。

当前验收层级是“工具连接、静态反编译和资源抽样解析”，并非“原游戏已经在 Unity Editor 可玩”。
