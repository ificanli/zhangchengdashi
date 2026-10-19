# 占城大师 1.04：IDA / IL2CPP 分析材料

本材料已完成 APK 提取、原生动态符号导出、IL2CPP 元数据还原，以及 Il2CppDumper 解析。尚未恢复可执行的 C# 方法体，尚未在 Unity Editor 中运行原游戏。IDA 本体尚未安装，导入脚本尚未在 IDA 中执行验证。

## 输入与身份

- 应用：占城大师；包名：`com.tfzzd.lcsq`；版本：`1.04`，versionCode：`104`。
- 原 APK：上一级目录的 `占城大师-1.04.apk`，253,246,448 字节。
- APK SHA256：`4544b6323c6a2b11dd801fb75d99dbe6fc59253443bde5a24738d772694b0a2d`。
- Unity 资源包版本：`2022.3.62f3`；Addressables：`1.22.3`。
- APK 包含 ARM64 和 ARMv7 原生库；本目录的 `libil2cpp-arm64.so` 来自 ARM64 目录。
- 本机核实存在 `2022.3.62f3c1` 编辑器；这与包内版本字符串并不完全相同，未验证重建工程兼容性。
- 原 APK、MuMu 中的应用和存档均未改写。

## 优先查看的文件

| 文件 | 内容与用途 |
|---|---|
| `GameModule-方法索引.tsv` | 6,089 条以 `GameModule.` 开头的方法映射，包含名称、RVA、签名；这是命名空间子集，不代表全部业务逻辑 |
| `Il2Cpp导出/dump.cs` | 类型、字段、方法声明和偏移；不是恢复出的完整可执行 C# 源码 |
| `Il2Cpp导出/script.json` | 396,253 条方法映射记录，供 IDA/Ghidra 等工具应用名称与地址信息，包含框架和泛型实例等 |
| `Il2Cpp导出/il2cpp.h` | 恢复的 C/C++ 类型声明，约 167 MB |
| `Il2Cpp导出/DummyDll/` | 118 个程序集结构文件，便于查看类型；不包含原游戏方法实现 |
| `Il2Cpp导出/stringliteral.json` | 导出的字符串字面量信息 |
| `原生符号表-arm64.tsv` | ELF `.dynsym` 中现存的 2,667 条原生符号 |
| `已定义原生函数-arm64.tsv` | 其中的 1,734 个已定义函数符号 |
| `导入原生函数-arm64.tsv` | 295 个未定义导入函数符号 |
| `global-metadata-original.dat` | 从 APK 提取的原始元数据，保留用于比对 |
| `global-metadata-decoded.dat` | 已还原并经结构检查、Dumper 解析的元数据副本 |
| `Il2Cpp导出/attempt.log` | 成功运行 Il2CppDumper 的日志 |
| `Il2CppDumper-解析日志.txt` | 对原始元数据的首次失败日志，保留用于解释处理原因 |
| `导出统计.json` / `manifest.json` | 数量、阶段状态，以及文件大小和 SHA256 校验值 |

TSV 使用 UTF-8 BOM。原生符号中的虚拟地址是 ELF 链接时地址；运行时地址还涉及装载基址。方法索引的 RVA 来自 Il2CppDumper 输出，应结合 IDA 数据库基址理解。

## 本次元数据处理

原文件的 magic 为 `0xFAB11BAF`、version 为 `31`，但从偏移 8 起的表数据经过固定字节变换，直接解析会越界。原始文件和原始 APK 均保留未修改。

生成标准副本的方法：保留前 8 字节，从偏移 8 开始按位置循环 XOR 以下 8 字节：

```text
64 62 74 78 69 6A 6B 00
```

还原副本 SHA256：`a7dd08dcdbd578a6604fd63e682fd240850033abab71c7e86df6016b65afe13b`。

验证结果：31 个表范围合法且按 4 字节对齐，30 对相邻表严格连续，末表结束位置与文件大小完全一致；118 个 image 与 21,672 个 type 的名称、范围和相关结构通过检查。随后使用 Il2CppDumper 6.7.46 实际完成解析、结构头生成和 Dummy DLL 生成。结构检查详情见 `metadata-结构验证.json`。

成功日志中的 CodeRegistration=`0x8575538`，MetadataRegistration=`0x891b5e8`。工具曾提示原生文件可能受保护，但后续自动定位及导出成功；该提示不能单独作为导出失败结论。

## 在 IDA 中使用

本机尚未安装适用的 IDA，也没有执行以下导入流程。因此这里是已准备的操作步骤，不是已经完成的 IDA 验证。

1. 使用支持 ARM64 的 IDA 打开 `libil2cpp-arm64.so`，识别为 AArch64 ELF；等待初始分析完成。
2. 先保存数据库到独立位置。
3. 通过 File / Script file 运行 `Il2Cpp导出/ida_py3.py`。
4. 在脚本的文件选择窗口中选择同目录的 `script.json`。
5. 完成后搜索 `GameModule.HexBehaviour$$CreatSoldierPile` 等名称，检查与方法索引中的地址是否一致。
6. 若需要反编译伪 C，许可证还需包含 ARM64 反编译器。

`ida_py3.py` 和 `ida_with_struct_py3.py` 是 Il2CppDumper 6.7.46 原附带脚本，未为未知的本机 IDA 版本修改。后者还会读取 `il2cpp.h` 并应用类型；由于输入较大，可先验证基础名称映射，再处理完整类型。脚本的具体 API 兼容性需要安装目标 IDA 后验证。

## IDA 安装条件

截至 2026-10-19，本轮核查的 Hex-Rays 官方产品说明中，IDA Free 仅支持 x86/x64，不适用于这个 ARM64 文件。可用选择包括带 ARM64 反编译器的 IDA Pro，或适合非商业使用的 IDA Home ARM 家族。官方下载由账号现有许可证决定。

- 下载中心：https://my.hex-rays.com/download-center
- IDA Pro：https://hex-rays.com/ida-pro
- IDA Home：https://hex-rays.com/ida-home
- IDA Free：https://hex-rays.com/ida-free
- 下载与许可证说明：https://hex-rays.com/faqs/how-do-i-access-my-downloads-in-the-portal

尚未购买、注册或替用户接受任何付费方案。若没有适用授权，Ghidra 可作为后续免费的 ARM64 分析选项；尚未安装或运行它。

## 距离 Unity Editor 运行还缺什么

当前材料可以帮助定位原生代码中的方法，但 Dummy DLL 和 `dump.cs` 不能直接恢复游戏玩法。后续仍需恢复或重写方法体，重建资源和脚本引用，处理 Addressables、Android 平台接口及其他依赖，并单独验证实际运行效果。

工具来源：Il2CppDumper 6.7.46 官方发布 https://github.com/Perfare/Il2CppDumper/releases/tag/v6.7.46 。
