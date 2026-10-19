# 03：IDA、MCP与实际反编译

## 工具各自负责什么

- IDA分析ARM64指令、控制流、引用关系和类型。
- Hex-Rays ARM64反编译器生成伪C；伪C仍可能存在错误类型、未知调用与未解析异常路径。
- MCP把查询、重命名、类型应用等接口提供给自动化客户端。MCP连接成功只证明通信正常，不证明业务恢复正确。

## 本次配置

IDA安装位置为`C:\Program Files\IDA Professional 9.4`。本报告不记录任何第三方授权补丁流程。环境可用性以实际文件加载和反编译结果验收。

MCP采用用户指定仓库`https://github.com/Sunny-Gu/idapromcp`，固定提交`48bc62d54c704a5939de73a804e284cfcafa69b6`。独立Python3.11环境安装，版本ida-pro-mcp1.4.0、mcp1.6.0。桥接服务启动命令：

```powershell
& 'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe' -m ida_pro_mcp.server --transport stdio --ida-rpc http://127.0.0.1:13337
```

IDA插件位于`%APPDATA%\Hex-Rays\IDA Pro\plugins\mcp-plugin.py`，菜单`Edit → Plugins → MCP`或`Ctrl+Alt+M`启动。本次未启用`--unsafe`，但默认工具仍可修改IDA数据库，不能称为只读模式。

未用仓库一键安装器，因为它会修改其他编辑器配置并添加自动批准项，而不直接支持Codex。只添加Codex的idapromcp段，原配置保持不变。完整安装过程见上级`idapromcp-安装说明.md`。

## 分析输入与数据库

输入`libil2cpp-arm64.so`，SHA256为`72770d00b2b404acf44cc75cc8bf7a3e06850e9ace1237c9cbb2bc72894220ed`。IDA识别ELF64 ARM64，基址为0。工作数据库与原文件独立保存；MCP活跃数据库位于上级`IDA分析材料/首轮反编译/zhancheng-targeted.i64`。

使用`script.json`恢复名称，使用最小类型头解释HexCoord与角色计数字段。HexCoord是两个int32组成的8字节值类型；ARM64按值传递，不能错当成两个指针或四个独立参数。

## 第一次“成功返回伪C”为何仍不算成功

最初只创建了函数入口指令，反编译结果类似：

```c
void HexDistance() { JUMPOUT(...); }
```

这是函数范围尚未完成分析，并非原方法只有跳转。补齐目标地址范围分析与参数类型后，返回了真实坐标计算和条件分支。必须检查正文、汇编和参数，不能只看工具返回isError=false。

## 实际检查顺序

1. `check_connection`核对打开文件名。
2. `get_metadata`核对原生库哈希、基址和架构。
3. 创建/分析目标方法地址范围。
4. 应用最小类型与真实函数原型。
5. 同时导出伪C和带地址的汇编。
6. 对关键字段偏移、条件跳转、转换指令与调用目标交叉核对。
7. 保存数据库，重新打开，再通过MCP反编译同一方法，排除仅临时内存状态成功。

## 首轮结果与限制

已导出HexDistance、InternalCalculateDamage、GetAvailableSlots、ChangeCoin、DetermineHexCamp、OpenHex和GameLauncher.Start的MoveNext。前两个没有JUMPOUT；其他方法仍有异常路径或类型恢复限制。GetAvailableSlots和ChangeCoin带局部变量分配警告，必须以汇编验证关键部分。

GetAvailableSlots中，伪C曾给单例方法附加错误的参数；真实汇编只传了隐藏MethodInfo。DetermineHexCamp的null路径不能擅自改为“空列表”。这些说明“看起来像C”的结果仍需审查。

启动链分析中，较长InitManager的范围分析耗时异常，已保留过程日志；后续将采用有界范围或分段分析，不能无限等全库分析后才推进。

## 学习入口

- 上级`IDA分析材料/首轮反编译/pseudocode`：逐方法`.c`与`.asm.txt`。
- 上级`IDA分析材料/首轮反编译/汇编复核.md`：参数、字段和数值语义独立核查。
- 本目录第08篇：如何把泛型MethodInfo、qword和场景脚本关联成真实启动链。
# 补充案例：伪代码的函数名和参数不能直接当成事实

在后续资源解码中遇到了两种不同的分析失真，现保留在这里作为学习案例。

1. `FileManager.QnXgString`是实例方法，实际参数为`self, byte[], MethodInfo*`。最初手工传入了静态二参数原型，导致伪代码看起来把MethodInfo当数据。原ASM只有`MOV X0,X1; MOV X1,XZR; B ...`，配合metadata签名可确认它丢弃self，把第二参数bytes传给静态解码函数。修正原型后重新导出，才作为参数流依据。
2. 目标`0x71EE040`本应是单参数SHA256派生函数，导出的.c却显示前一个`0x71EDA90 DecryptBytes`的大段AES逻辑。原因是IDA自动分析把相邻边界合并；`decompile(address)`会反编译包含该地址的函数，而不保证起始地址等于传入地址。原ASM范围正确，伪C的函数身份错误。

第二个问题通过metadata的独立方法边界修正工作数据库：截断错误延长的前函数（或分离错误tail），重新建立目标函数，再应用原型和反编译。新的输出确认调用`SHA256.Create`及`HashAlgorithm.ComputeHash`。批处理现在记录actual_function_start/end，并在实际函数起始地址不等于目标RVA时拒绝输出成功结论。

工作证据为`work/ida-framework-assets/status-supplement.json`、`targets-supplement.json`及对应`.asm.txt/.c`。错误原型的初始输出单独保留，不混作恢复依据。这里说明：符号映射、原型、函数边界、调用约定和原指令必须相互核对；“IDA生成了伪代码”本身不是语义恢复的验收。

