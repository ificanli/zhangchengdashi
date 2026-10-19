# Git与全资料交付范围只读审计

本报告只审计当前工作区，不修改恢复业务源码，不启动 Unity，不上传、不删除资料。恢复工作保持暂停。扫描时间：2026-10-19T10:14:30Z。清单统计为扫描时快照，新产生的 Git 交付记录由主窗口纳入最终清单。

## 实测状态与交付不能掩盖的限制

Main6 实际观测 45.0 秒，22 份快照，0 个记录错误；后 17 份快照停在 frame=1803、gameTime=9.987316131591797。资源 provider 状态为 `cancelled_editor_session`、ready=false，coreGameplayAccepted=false。零错误不能证明玩法运行成功，地图、开格/占领、兵堆/战斗仍未通过真实连续交互验收。

实测文件：`work/git-delivery/main6.json`、`work/git-delivery/main6-provider.json`、`work/git-delivery/render-readback.json`。

## 范围统计

扫描 outputs/work 共 150,429 文件、27,849,794,893 字节。文件枚举/stat 错误 0。

|分类|文件数|字节数|
|---|---:|---:|
|project_or_evidence|104,184|24,574,483,073|
|project_machine_cache:Library|42,314|3,175,004,689|
|project_machine_cache:Logs|19|11,163,127|
|project_machine_cache:Temp|63|297,578|
|project_machine_cache:UserSettings|2|905|
|reproducible_cache:.venv|788|47,650,355|
|reproducible_cache:dotnet_obj|2,931|39,280,543|
|reproducible_cache:__pycache__|128|1,914,623|

project_or_evidence 是按文件路径排除明确缓存后的资料候选，不代表全部直接进入 Git。大型二进制、重复底座的独立分析状态、工具与原资源需分卷附件保留；不得只提交能编译的当前工程就声称“所有资料”已经上传。

## 建议进入 Git 的资料

- `outputs/OccupyCityRecovered/Assets/**`：真实原资源、GUID/meta、恢复源码与编辑器观察/适配工具；保留 asset/meta 配对。
- `outputs/OccupyCityRecovered/Packages/**`：manifest、packages-lock、嵌入依赖源码全部保留，不能按全局 models/Build/audio 通配符隐藏。
- `outputs/OccupyCityRecovered/ProjectSettings/**`、`RecoveryReports/**`：原工程设定与机器生成验证报告。
- `outputs/恢复过程文档/**`、`outputs/并行恢复任务Prompt/**`、`outputs/旧框架资源恢复/**`：中文教程、证据、原名/PathID 映射、哈希与旧资源。
- `work/**` 中所有实际脚本、原生 ASM/伪代码、targets/status、候选、源前快照、独立复核、有效测试输入/结果和日志，按准确清单归档。实验失败也是恢复过程证据，应保留。

## 必须作为非 Git 大附件保留的资料

- 原 APK、ELF、metadata、IL2CPP 原导出，包括超过普通 Git 文件限额的 script.json/il2cpp.h。
- 所有独立任务的 `.i64` 及原 `.id0/.id1/.id2/.nam/.til` 配套文件。数据库虽共享原生底座，独立任务分析状态不同；本审计未证明任何一份可无损替代其他份，不能按“重复”直接删省。
- 原 AssetRipper 首轮/完整/归一化导出快照、保留原资产、备份场景与源码；工具二进制、下载包和对应源码快照。
- `work/recovery-ledger/unity-recovery-import13.log` 的 510,492,328 字节失败原日志以及其余运行日志。
- 最终逐文件路径/大小/SHA256 清单、各分卷 SHA256、发布附件条目和恢复脚本。`git clone` 不会取得 Release 附件，必须明确恢复步骤。

下表列出本次 >=50 MiB 且未划为明确缓存的文件，普通 Git 限额以上的文件不能直接推送：

|相对路径|字节数|
|---|---:|
|`work/parallel-44-battle/ida/framework.i64`|955,850,398|
|`work/parallel-43-hex/ida/framework.i64`|950,253,124|
|`work/ida-framework-assets/framework.i64`|947,967,593|
|`work/parallel-42-fsm/ida/framework.i64`|946,894,230|
|`work/parallel-41-config/ida/framework.i64`|946,844,998|
|`work/game-launcher-recovery/ida/launcher.i64`|945,385,612|
|`work/ida-startup-bounded/startup-short.i64`|944,180,554|
|`work/ida-targeted/zhancheng-targeted.i64`|944,024,971|
|`work/ida-constructor-recovery/constructors.i64`|943,992,104|
|`outputs/IDA分析材料/首轮反编译/zhancheng-targeted.i64`|943,951,092|
|`work/ida-startup-bounded/startup.i64`|943,951,092|
|`outputs/IDA分析材料/首轮反编译/zhancheng-targeted.id1`|603,742,208|
|`work/ida-session/zhancheng-arm64.id1`|603,742,208|
|`work/ida-startup-bounded/startup-short.id1`|603,742,208|
|`work/ida-startup-bounded/startup.id1`|603,742,208|
|`work/ida-targeted/zhancheng-targeted.id1`|603,742,208|
|`work/parallel-44-battle/ida/framework.id1`|603,742,208|
|`work/recovery-ledger/unity-recovery-import13.log`|510,492,328|
|`work/parallel-44-battle/ida/framework.id0`|352,002,048|
|`work/ida-startup-bounded/startup-short.id0`|340,344,832|
|`work/ida-targeted/zhancheng-targeted.id0`|340,205,568|
|`work/ida-startup-bounded/startup.id0`|340,156,416|
|`outputs/IDA分析材料/首轮反编译/zhancheng-targeted.id0`|340,115,456|
|`work/ida-session/zhancheng-arm64.id0`|340,107,264|
|`outputs/占城大师-1.04.apk`|253,246,448|
|`work/apk-intake/zhancheng-dashi-1.04.apk`|253,246,448|
|`work/tools/spine-runtimes-4.2-e7dc1435.zip`|190,947,220|
|`outputs/IDA分析材料/Il2Cpp导出/script.json`|181,643,286|
|`work/il2cpp-dump-decoded/script.json`|181,643,286|
|`outputs/IDA分析材料/Il2Cpp导出/il2cpp.h`|167,459,882|
|`work/il2cpp-dump-decoded/il2cpp.h`|167,459,882|
|`outputs/IDA分析材料/libil2cpp-arm64.so`|150,935,896|
|`work/ida-input/libil2cpp-arm64.so`|150,935,896|
|`work/recovery-input/lib/arm64-v8a/libil2cpp.so`|150,935,896|
|`work/tools/AssetRipper-2.0.0/AssetRipper.GUI.Free.exe`|130,120,704|
|`work/recovery-input/lib/armeabi-v7a/libil2cpp.so`|128,994,820|
|`work/tools/cpp2il-official/source/TestFiles/Simple_2019_4_34/GameAssembly.pdb`|91,942,912|
|`outputs/IDA分析材料/Il2Cpp导出/dump.cs`|60,882,278|
|`work/il2cpp-dump-decoded/dump.cs`|60,882,278|

## 可排除的再生缓存及取证例外

- Unity `Library`、`Temp`、`obj`，Python `.venv`/`__pycache__`/`.pyc`，编译中间 `obj`、node_modules 等可以排除再生部分；不删除本地原文件。
- 在排除 Library 前建议保存 `outputs/OccupyCityRecovered/Library/Bee/**/*.rsp`：335 个原编译参数文件、8,967,584 字节，可作为准确编译证据附件。
- `outputs/OccupyCityRecovered/Logs`：19 个文件、11,163,127 字节，虽属于编辑器生成日志，但本轮“所有资料”目标下适合作为取证附件保存。
- UserSettings 为本机布局/使用状态，可以作为可选机器记录，恢复工程运行不依赖它。
- 两个工具内嵌 `.git` 不应直接误加成子模块；完整源码快照及 HEAD 来源已记录如下。原本地 `.git` 不删除。

|工具源码目录|本次 HEAD|
|---|---|
|`work/idapromcp-intake/source`|`48bc62d54c704a5939de73a804e284cfcafa69b6`|
|`work/tools/cpp2il-official/source`|`b5ad444b82267cb1e4b88b8b373c008105bdea52`|

## Stage41/42/43/44/50/51 覆盖

|Stage|报告与交接是否存在|原生代码文件数|范围说明|
|---|---|---:|---|
|41|报告true，handofftrue|237|旧配置消费链15正文；配置全闭合尚未通过|
|42|报告true，handofftrue|170|状态机82候选、8原native RET保留；handoff为历史候选状态|
|43|报告true，handofftrue|217|地图/开格45正文；真实玩法未验收|
|44|报告true，handofftrue|1043|战斗197正文；主链仍有未闭合依赖|
|50|报告true，handofftrue|0|官方URP源码/绑定修复，以官方文件和实际Shader读回为证据，不需要伪造IDA证据|
|51|报告true，handofftrue|38|38配置主键访问器；38份实际ASM位于 outputs 证据/native，不能只搜work判缺证据|

上述报告 SHA256、具体 native/status/候选/原生路径在 audit.json 中。Stage41 getter extension、Stage42 Utility extension 与 stage43/44 独立复核协调记录均存在，必须随 `work/parallel-coordination` 交付。handoff 中 source_applied=false 等值是产生交接时的历史状态；最终整合状态应由主窗口实际源码/应用日志和编译读回判断，本审计不以旧 handoff 代替当前运行验收。

## 授权/凭据检查

文件名检查未发现 hexlic、私钥、keystore、.env 或个人 credentials/token 配置。扫描 51,894 个文本文件、2,613,396,268 字节；检查 17 个ZIP的 16,094 条内部文件名。

- 唯一高置信形式命中：`work/recovery-input/assets/google-services-desktop.json` 的 Google API key 形式。本报告不包含值、片段或密钥本身。建议不将这份独立明文配置作为无敏感风险材料上传；保留原本地文件，由主窗口明确原客户端公开配置与个人授权秘密的边界。
- 该路径是 APK 原提取资源；原 APK 可能也内嵌相同客户端配置。文本形式命中不证明它是个人秘密，也不证明可以用来访问私有数据。不能由此宣称二进制 APK/数据库/压缩包已做全量秘密审计。
- 未读取个人凭据文件、用户账号数据或 IDA 授权文件。二进制数据库/可执行体内部未扫描，ZIP内部只检查文件名、未解包检查正文；此为审计覆盖限制。
- 第三方 `license.txt`/LICENSE 版权声明必须保留，不能和应用授权 hexlic/key 混同后删除。任何个人 token、私钥、授权 key/hexlic 均应从 Git 与附件排除。

## 结构与完成条件

Unity Assets 有 12,903 个 meta；孤立 meta=0、无meta资产=0。恢复时仍需创建 folderAsset meta 对应的空目录。

最终交付必须同时证明：

1. 用户资料每个保留文件都映射到 Git 或发布附件，不存在未分配必需资料。
2. Git 上传后 fetch 并确认本地 HEAD 与指定远程 ref 一致。
3. 每个分卷可读取/解压，逐文件路径、大小、SHA256 与清单一致；所有分卷已发布并核对附件大小/哈希，至少实测下载一卷再哈希。
4. 恢复说明包含仓库 clone、附件下载/解压、Python/IDA/Unity版本和工具前提；仅仓库上传不能证明大资料恢复完成。
5. 当前暂停与真实运行未完成的状态明确写入交付报告；此次 Git 全资料上传不是原游戏玩法目标完成。

审计借鉴历史完整迁移经验仅用于检查边界，当前文件统计和运行结论均来自本次现场读取。
