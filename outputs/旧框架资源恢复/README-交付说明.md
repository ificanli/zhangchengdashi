# 旧框架资源恢复交付

本目录保存从原 APK 证据链恢复的 `ABFiles.txt`、2 个旧框架数据 AssetBundle 和 50 个 TextAsset，以及解码脚本、原名/PathID/容器路径映射、完整 SHA-256 清单和消费者证据。此阶段只完成解码、结构核查和交付，尚未把这些资源导入 Unity 工程，也未证明 Editor 启动已经消费它们。

## 已确认结果

| 资源 | 原密文大小 | 解码大小 | 内容 |
|---|---:|---:|---|
| ABFiles.txt | 4,340 | 4,335 | 1 行 header + 34 条清单记录 |
| b1a1165a67f21d096a79a144bac38207.unity3d | 13,012 | 13,005 | 49 TextAsset + 1 AssetBundle |
| 88f786fb5f53905f559260048dbfe059.unity3d | 868 | 861 | 1 TextAsset + 1 AssetBundle |

34 条清单记录均已与原 APK 核对存在性、长度和原文件 MD5。3 份密文均通过完整重新编码逐字节 roundtrip。两个 UnityFS 的全部压缩块、目录边界和 52 个对象 type tree 均读取完成；另在全新目录再次运行最终复现入口，与本次交付的 3 个主体文件和 50 个 TextAsset 共 53 份有效载荷逐字节相同。

50 个 TextAsset 中，48 个是合法 UTF-8 JSON：43 个 `Datas` 表、5 个其他 JSON 对象。其余 2 个 `all` 和 `LayerCollisionMatrix` 均只有 5 字节 `EF BB BF 0D 0A`，即 BOM 与 CRLF；它们在原 APK 中就是空内容。未为其补造规则或配置。

## 为什么使用两种密钥

`VersionMondule.LoadABFileStreaming → FileManager.QnXgString (0x7241D94) → 0x7175D04 → SplitColors` 读取清单，常量为 `WeDoBest`。清单解析器 `PatchManifest..ctor (0x72ECFD8)` 把 header 第 4 段保存到 `RandomSeed`，实际值为 `05950256e8ba3a5e7a37916c954e7db1`。

数据包走 `GetAssetBundleInfo (0x72EF2A0) → BundleAssetInfo..ctor (0x72EB0D0) → LoadAssetBundleInternal (0x7363F34) → 专用加载器..ctor (0x73622FC) → IsDone (0x736221C) → 0x71758D0 → SplitColors`，消费的就是该 `RandomSeed`。核心为已恢复的 UTF-16LE key、little-endian uint32、delta `0x9E3779B9` 的 XXTEA 混合式和末 word 长度检查。

`证据/decode-report.json` 与 `decode-attempt-001.json` 保留早期过程：把清单的 key 用于数据包时长度检查失败。最终两个数据包的权威结果是 `证据/data-bundles-decode-report.json`，两项均 `success=true`。失败历史不能覆盖最终结果，也不能当作另一种数据包算法。

## 文件如何对应原资源

- `原始密文/`：从原 APK 取出的 3 份原始字节，保留原文件名。
- `解码资源/`：3 份明文派生副本，保留原文件名。
- `TextAssets/`：精确保留原 TextAsset 字节，文件名组合为原 bundle stem、原 PathID、原 `m_Name`，负数 PathID 也保留。
- `原名与PathID映射.json`：每项含原清单逻辑包名、存储包名、PathID、TextAsset 名、`AssetBundle.m_Container` 实读路径、交付路径、字节数和 SHA-256。
- `证据/消费者与物理设置/`：原 ELF 的 ARM64 指令、metadata 目标与 RELA 槽解析、JSON 结构、原始物理设置对比。
- `证据/原加载与解码链/`：原 IDA 的加载器/清单/codec 汇编、伪 C 与函数边界状态；异常尾块仅按 metadata 界定的正常方法范围引用。
- `Editor导入与资源映射计划.json`：可审查的后续导入计划，目前未执行。

容器实际记录了 `assets/gameres/bundleres/data/config/...bytes` 与 `assets/gameres/bundleres/data/layercollisionmatrix.bytes`。它们是原构建包中的小写 key，不等于已知原工程的大小写文件名；交付没有依据名称猜造源 `Assets` 路径。计划中的 `Assets/RecoveredLegacy/...` 明确是拟议恢复目录。

## 已找到的实际消费者

`ljzs_lt.GameStart.InitConfig (0x439B9B0)` 依次调用 `ConfigMgr.SetConfigABRes`、`ConfigMgr.Initialize` 和 `InitConfigOver`。`SetConfigABRes (0x4399EBC)` 把收到的 ResourcesInfo 写入 `ConfigRead.configRes`。`ConfigMgr.ReadConfig (0x4399658)` 的泛型 metadata 明确列出 38 次表读取和 3 次单对象读取，41 个类型名全部与解包 TextAsset 对应，包括骰子/棋盘/遗迹、神器属性/升级、签到/商店/购买和世界杯活动配置。因此这些主体配置有真实游戏消费者，不应整体标成框架 demo。

`ConfigType` 的原 JSON 是 `{"configType":1}`，与元数据 enum 的 `UnityJson=1` 相符。语言、图片语言、音频、特效、视频按钮等其余框架表里含测试条目；本阶段记录其内容，但没有把它们全部认定为当前游戏必须启用。

同时，`DataModule.DataManager.LoadConfig` 状态机 `0x434F8C4` 创建 `GlobalInfo` 并等待 `InitInfo`。其 `0x435DF2C` 状态机直接引用 `Assets/_Res/Addressable/01FirstBundle/JsonData/*.json`，与这里的旧框架 `.bytes` 是不同的加载链。具体地址另存于 `证据/新DataManager配置地址证据.json`，不能拿这 41 个配置代替新链数据。

## 碰撞矩阵的真实来源

原 `data.unity3d/globalgamemanagers` 的 PathID 10 是 `PhysicsManager`，PathID 15 是 `Physics2DSettings`，二者均有真实 32 个 uint32、128 字节的 LayerCollisionMatrix。按 little-endian 原值转换后，与导出工程 `ProjectSettings/DynamicsManager.asset` 和 `Physics2DSettings.asset` 的矩阵全部一致。3D 矩阵包含原有禁碰组合，2D 为原全 1 矩阵。

`GameStart.SetLayerCollisionMatrix (0x439BEDC)` 仅尾跳到基类空实现；`GameStartNewRes.SetLayerCollisionMatrix (0x439C330)` 本身就是 `RET`。空 TextAsset 与真实 ProjectSettings 是不同来源；不能从空文本推出工程丢失碰撞规则，也不需要猜补矩阵。

## 复现与核验

已实际使用 Python 3.14.4 和 UnityPy 1.25.2 完成复现。安装并运行以下命令时，将 APK 路径替换为原 APK，将输出指定到新的派生目录：

```powershell
python -m pip install -r .\复现脚本\requirements.txt
python .\复现脚本\reproduce_legacy.py --apk "原APK绝对路径.apk" --out "新的派生输出目录"
python .\复现脚本\verify_legacy_delivery.py
```

`reproduce_legacy.py` 是最终入口：先用清单的已证实 key 处理 ABFiles，再从 header 读数据包 seed。原始 `decode_legacy_resources.py` 保留调查复现历史，其 main 会复现早期用同 key 试两包而失败的情况，因此不应把它单独当最终入口。

`完整哈希清单.json` 列出本目录所有交付文件的字节数和 SHA-256（排除该清单自身及其 sidecar）；`完整哈希清单.sha256` 校验清单文件。核验脚本会检查缺失、长度、哈希及额外文件。`证据/调查脚本/` 是本工作区原始布局下的只读调查脚本，需要原 ELF、script.json 和 APK；其中 native 调查另使用 Capstone 5.0.6，不是解码所必需。

## 尚未完成的验收

本批没有修改 `Assets`、`Packages` 或 `ProjectSettings`，没有运行 Unity，也没有声明编译成功。Editor 导入、ConfigRead/ConfigMgr 的实际可执行正文、当前启动分支和新 DataManager 的完整配置消费仍需继续恢复。交付证明的是原数据已解码、结构可读、映射可追溯；原游戏能否在 Editor 完整运行必须另行记录实际运行结果。
