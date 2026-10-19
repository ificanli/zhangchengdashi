# Sunny-Gu/idapromcp 安装记录

日期：2026-10-19。

## 当前状态

已安装用户指定的 `Sunny-Gu/idapromcp`，已部署 IDA 用户插件文件，并添加 Codex 的 `idapromcp` MCP 配置。独立 MCP 客户端已实际完成初始化、枚举 50 个工具以及调用 `check_connection`。

IDA 本体尚未安装或启动，本次没有验证 IDA 内的插件加载、反汇编、反编译或游戏逻辑。连接检查的实际结果是：

```text
无法连接到 IDA Pro! 您是否运行了 Edit -> Plugins -> MCP (Ctrl+Alt+M) 启动服务器？
```

当前聊天尚未获得新 MCP 工具，需要在 Codex 中重新加载 MCP 配置或重启应用后再确认。

## 来源与版本

- 指定仓库：https://github.com/Sunny-Gu/idapromcp
- 固定提交：`48bc62d54c704a5939de73a804e284cfcafa69b6`。
- 包版本：`ida-pro-mcp 1.4.0`。
- Python：`3.11.16`，独立虚拟环境。
- MCP SDK：`1.6.0`；依赖按仓库 `uv.lock` 使用 `uv sync --frozen --no-dev` 安装。
- README 中指向另一个仓库的克隆命令未采用。

## 安装位置

源码与虚拟环境：

```text
C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source
C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe
```

IDA 插件：

```text
C:\Users\luxinyu\AppData\Roaming\Hex-Rays\IDA Pro\plugins\mcp-plugin.py
```

插件源文件和部署文件的 SHA256 一致：

```text
efda9ec584c9b279595d268107d0f5b47f91b298a50f25960d8ba700cc4e94d6
```

Codex 配置文件：

```text
C:\Users\luxinyu\.codex\config.toml
```

新增配置如下，其余配置经解析对比保持一致：

```toml
[mcp_servers.idapromcp]
command = 'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe'
args = ['-m', 'ida_pro_mcp.server', '--transport', 'stdio', '--ida-rpc', 'http://127.0.0.1:13337']
startup_timeout_sec = 30
tool_timeout_sec = 180

[mcp_servers.idapromcp.env]
PYTHONIOENCODING = 'utf-8'
PYTHONUTF8 = '1'
```

本机 PATH 中的旧 Codex CLI 不识别当前配置的 `model_reasoning_effort = "ultra"`，因此注册时仅追加上述 MCP 段，未改动推理档位。随后使用只在该次进程生效的 CLI 参数覆盖完成 `mcp get idapromcp --json` 读回，确认服务器配置为 enabled。

## 已验证的范围

| 检查 | 结果 |
|---|---|
| 固定仓库提交、Python 包安装 | 通过 |
| Python 模块加载及命令行帮助 | 通过 |
| IDA 插件文件部署与 SHA256 对比 | 通过 |
| MCP initialize | 通过，协议版本 `2024-11-05` |
| MCP tools/list | 通过，50 个工具 |
| 默认调试器工具过滤 | 通过，未暴露 `dbg_*` 工具 |
| check_connection 调用 | 调用成功；返回 IDA 尚未连接 |
| Codex 配置读回 | 通过，enabled=true |
| 当前聊天直接调用新 MCP | 尚未加载，需要刷新客户端 |
| IDA 内加载插件、反编译 | 未验证，缺少运行中的 IDA |

验证详情见同目录 `idapromcp-安装验证.json`。

## 后续启动顺序

1. 安装并打开适用的 IDA。IDA 自身的 IDAPython 需要 Python 3.11 或更高版本；独立虚拟环境的版本不能代替这一要求。
2. 在 IDA 中打开待分析二进制，例如本次提取的 ARM64 `libil2cpp`。反编译伪 C 还需要适用的 ARM64 反编译器。
3. 在 IDA 菜单选择 `Edit → Plugins → MCP`，或按 `Ctrl+Alt+M` 启动插件服务。
4. 在 Codex 中重新加载 MCP 配置；若没有可用的重新加载入口，则重启 Codex，再检查服务器列表。
5. 首先调用 `check_connection`，成功后再验证 `get_metadata`、分页函数列表、单函数反汇编和反编译。

MCP 桥接通过 stdio 与 Codex 通信，仅向 `127.0.0.1:13337` 连接。IDA 插件默认监听本机 `localhost:13337`，只有在 IDA 中启动插件后才会监听。本次未修改防火墙或开放局域网端口。

## 仓库实现的实际边界

未使用仓库的一键 `--install`，因为它会改写 Cline、Roo Code、Claude、Cursor、Windsurf、LM Studio 的配置并写入自动批准项，而不支持 Codex。此次只部署 IDA 插件并增加 Codex 连接。

未启用 `--unsafe`。这会隐藏 10 个调试器工具，但默认工具中仍包含重命名、注释和类型修改等 IDA 数据库写操作，因此不应将其称为只读模式。

静态检查发现，这个分支的一些增强功能存在未定义变量/函数及嵌套同步调用问题，涉及增量追踪、动态字符串和自动报告等。本次没有改写这些功能，也没有将它们列为可用性验收结果；后续应先使用基础查询与反编译工具。MCP 握手和工具枚举通过，不代表每个 IDA 端方法都已运行验证。

安装过程未安装 IDA 本体、未改动 APK 或此前导出的逆向分析材料。
