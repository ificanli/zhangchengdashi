# 50：URP 内部 Shader 与原场景渲染修复

日期：2026-10-19。任务根：`C:\Users\luxinyu\Documents\Codex\2026-10-19\x20`。

**本阶段交付状态为 `ready_for_integration`。** 已完成四个窄范围 Shader 候选、原件与 meta 保存、真实引用取证、实际候选重提取的独立 HLSL 编译、带 source-before SHA256 保护的可执行 apply 脚本，以及交接 JSON。候选尚未应用到共享工程；没有操作已有 Unity GUI、PlayMode、Hub 或 IDA。

**当前不能宣称原地图、开格/占领或兵堆战斗已经运行。** Unity Shader 导入编译、运行态绑定读回、Main6 图形观察及核心玩法验收均由主窗口继续，状态为 `not-run`。

## 1. 原始失败与判断范围

原始证据为 `work/recovery-ledger/unity-play-main5.json`，本阶段另存不可变快照到 `work/parallel-50-render/evidence/unity-play-main5-original.json`。Main5 在用户已有图形 Editor 中正常打开原 `Assets/gameres/bundleres/Scene/MineGameMain.unity` 并 Play，frame1 观察到两条 Error：

1. `Local keyword BLIT_DECODE_HDR doesn't exist in the shader.`
2. `RenderingCommandBuffer: shader Hidden/Universal/CoreBlit: invalid pass index 1 in DrawProcedural`

记录的 `status` 为 `runtime_error_observed`，只有 frame1 快照，`coreGameplayAccepted=false`。快照已有实际 UpdateManager；版本入口已开始 LocalEditorResourcesProvider。渲染错误使本轮提早退出，因此该记录不能判定资源 provider 加载失败，也不能证明其后继完成。

两条错误的堆栈均只保留 `GUIUtility.ProcessEvent`；日志未记录运行 Shader 的 instanceID/GUID。下文的 GUID 结论来自真实序列化链与官方消费代码，不冒充已完成运行态对象身份读回。

## 2. 确定的真实绑定链

本工程实际安装的 `com.unity.render-pipelines.universal` 与 `com.unity.render-pipelines.core` 均为 **14.0.12**。证据为实际 PackageCache 的 package.json、Packages/manifest.json 与 packages-lock.json。

| 层级 | 实际文件与字段 | 指向 |
|---|---|---|
| 全局渲染设置 | `ProjectSettings/GraphicsSettings.asset:67` 的 m_CustomRenderPipeline | Pipeline GUID `8032d5a74d1f0534c8bd6a9c90d87505` |
| 当前质量档 | `QualitySettings.asset:7` 当前为0；`:47` 的 customRenderPipeline | 同一个 Pipeline；Medium 的 `:145` 也相同 |
| Pipeline | `Assets/MonoBehaviour/SamplesPipelineAsset.asset:19` 的 m_RendererDataList，默认索引0 | Renderer GUID `e0e3c0bc2567dac4680e6c8ca49b7dc6` |
| Renderer | `Assets/MonoBehaviour/SamplesForwardRenderer.asset:33` / `:34` | 无后缀 CoreBlit / ColorAndDepth 两个 GUID |
| 原 Main 相机 | `MineGameMain.unity:2727` / `:2771` 的 m_RendererIndex=-1 | 使用默认 Renderer |
| 原 Addressable 备用配置 | `_Res/Addressable/01FirstBundle/Config/SamplesPipelineAsset.asset` → 同目录 SamplesForwardRenderer | `_0` CoreBlit / ColorAndDepth 两个 GUID |

四份 Shader 和独占范围如下。所有 meta 保留原字节，apply 脚本不写 meta，也不重绑 Renderer/Pipeline。

| 独占候选路径（相对工程根） | 原 GUID | 原 Renderer 字段 |
|---|---|---|
| `Assets/Shader/Hidden_Universal_CoreBlit.shader` | `a44b6e872349fd24eb5ea9b6e58a802d` | MonoBehaviour/SamplesForwardRenderer:33 coreBlitPS |
| `Assets/Shader/Hidden_Universal_CoreBlit_0.shader` | `d8cc01d3f785b864d8efaf9b7ec5449a` | Addressable Config/SamplesForwardRenderer:33 coreBlitPS |
| `Assets/Shader/Hidden_Universal_CoreBlitColorAndDepth.shader` | `8e333044aacf327419306bea075c9496` | MonoBehaviour/SamplesForwardRenderer:34 coreBlitColorAndDepthPS |
| `Assets/Shader/Hidden_Universal_CoreBlitColorAndDepth_0.shader` | `e6b6d875b4a83ac4fae4edb450598540` | Addressable Config/SamplesForwardRenderer:34 coreBlitColorAndDepthPS |

官方 `UniversalRenderPipelineAsset.cs:758` 将上述 Shader 字段直接传给 `Blitter.Initialize`；`UniversalRenderer.cs:178` 也按字段创建 CoreBlit 材质。`CoreUtils.CreateEngineMaterial(Shader)` 直接 new Material，不经过 Shader.Find。ResourceReloader 仅在字段为 null 时按官方路径补全，非 null 的导出占位不会自动得到替换。

工程的两份导出 CoreBlit 与官方包 Shader 名称相同。已查路径按 GUID 字段消费；没有通过改名或赌同名 Shader.Find 的胜出顺序修复。本次保持两份原 GUID，各自恢复完整官方正文。完整扫描与行证据见 `work/parallel-50-render/audit-binding/binding-evidence.json`、`绑定审计小结.md`。

## 3. 根因与四文件修复依据

四份原件均带 `DummyShaderTextExporter`，只有一个 Pass，顶点使用对象矩阵，片元固定返回白色。它们是导出占位，不能满足 URP 内部全屏拷贝接口。

- `Core/Runtime/Utilities/Blitter.cs:58-61` 无条件创建 CoreBlit 和 ColorAndDepth 配对材质，然后构造 `new LocalKeyword(blitPS, "BLIT_DECODE_HDR")`。即使当前场景没有启用 HDR，初始化仍要求该本地关键字存在。两份 CoreBlit 占位均缺少声明。
- 同文件的常规 BlitTexture 以 `bilinear ? 1 : 0` 选 Pass。原件只有索引0，因此索引1非法。
- 两份 Pipeline 都设置 `m_RequireOpaqueTexture:1`、`m_OpaqueDownsampling:1`（2x bilinear）。`CopyColorPass.cs:187-188` 在该设置下使用 CoreBlit Pass1，与 Main5 错误吻合。由于日志缺 C# 调用栈，不能断言它是本次唯一运行来源。
- `FinalBlitPass.cs:22-23/:62-63` 还按名字要求 BilinearDebugDraw / NearestDebugDraw。补一个空 Pass 不能满足完整链。
- 配对的 ColorAndDepth 已在同次初始化无条件创建材质；`Blitter.BlitColorAndDepth` 按 `blitDepth ? 1 : 0` 选择两个不同 Pass。原件单 Pass 同样不符合已安装 API 契约，因此将这两个同类占位列入 owned-scope 后一起恢复。**没有证据证明 Main5 已走 depth=true 分支**，本次没有用该附加修复解释已观察的 CoreBlit 错误。

候选采用工程已安装的同版本官方文件，保持官方正文逐字节相同：

- `Library/PackageCache/com.unity.render-pipelines.universal@14.0.12/Shaders/Utils/CoreBlit.shader` → CoreBlit 双份。
- 同目录 `CoreBlitColorAndDepth.shader` → ColorAndDepth 双份。

保持官方 `Packages/...` include 链，实际实现由已安装的 Core/URP HLSL 提供。没有删除 URP 功能、关闭后处理、抑制日志或修改业务门条件。

这是同版本 Unity 内部 Shader 接口的恢复。ShaderLab 资产没有 managed Token/IL2CPP RVA；owned-scope 与 handoff 明确填写 null 及原因。本次未占用 IDA，也不把官方源码一致性说成原 APK GPU 程序或最终像素一致性证明。

## 4. 源码保护与逐入口对照

先写 `work/parallel-50-render/owned-scope.json`，记录原 GUID、source-before SHA、meta SHA、引用证据和原非空正文快照，再生成 candidate。原件及 meta 完整保存在 `before/Assets/Shader`；完整候选保持同一工程相对路径放在 `candidate/Assets/Shader`。candidate 只有四个 `.shader` 文件。

| 家族 | 双份 source-before SHA256 | 双份 candidate/official SHA256 |
|---|---|---|
| CoreBlit | `6f3165b151180bc899f6ae57a61318f6a2bd8a98d1be2d105a5ae2a9f49e35a3` | `00f324fc5b358d6d172bf31d919eabce575e2dffe08cced1e53d5a50ad57640d` |
| ColorAndDepth | `b921fd0c8ff6032989597d8322f2fa55cbeac32eb66ae2b4a79c07ae71841f88` | `98ec3a4073d017c3b653e95f2327a90c8d8655ca4ced66d943e53901b00e79de` |

CoreBlit 双份恢复相同的25个 Pass；逐 Pass 的 vertex/fragment 原名如下，完整结构也写入 handoff：

| Pass | Vertex | Fragment |
|---|---|---|
|0|Vert|FragNearest|
|1|Vert|FragBilinear|
|2|VertQuad|FragNearest|
|3|VertQuad|FragBilinear|
|4|VertQuadPadding|FragNearest|
|5|VertQuadPadding|FragBilinear|
|6|VertQuadPadding|FragNearestRepeat|
|7|VertQuadPadding|FragBilinearRepeat|
|8|VertQuadPadding|FragOctahedralBilinearRepeat|
|9|VertQuadPadding|FragNearest|
|10|VertQuadPadding|FragBilinear|
|11|VertQuadPadding|FragNearestRepeat|
|12|VertQuadPadding|FragBilinearRepeat|
|13|VertQuadPadding|FragOctahedralBilinearRepeat|
|14|VertQuad|FragOctahedralProject|
|15|VertQuad|FragOctahedralProjectLuminance|
|16|VertQuad|FragOctahedralProjectAlphaToRGBA|
|17|VertQuad|FragOctahedralProjectRedToRGBA|
|18|VertQuad|FragBilinearLuminance|
|19|VertQuad|FragBilinearAlphaToRGBA|
|20|VertQuad|FragBilinearRedToRGBA|
|21|VertQuadPadding|FragOctahedralProjectNearestRepeat|
|22|VertQuadPadding|FragOctahedralProjectBilinearRepeat|
|23|Vert|FragmentURPBlitBilinearSampler；Name BilinearDebugDraw|
|24|Vert|FragmentURPBlitPointSampler；Name NearestDebugDraw|

Pass21/22 保持官方 `#pragma multi_compile_local _ BLIT_DECODE_HDR`。ColorAndDepth 双份分别恢复 Pass0 Vert/FragColorOnly（ZWrite Off）与 Pass1 Vert/FragColorAndDepth（ZWrite On）。Pass1 的 PixelData 同时输出颜色和 `SV_Depth`。

## 5. 已实际执行的验证

### 5.1 原件负对照与候选静态契约

`verify_contract.py` 从 before 与实际 candidate 重读正文，不复制 Shader 业务实现。检查 Pass数量、Pass1入口、URP tag、Package include、HDR本地关键字、21/22入口、最终命名 Pass、ColorAndDepth入口及写深度状态。

结果：**原件32项预期失败；候选32项契约检查通过；28项源/meta/官方字节相等/真实绑定完整性检查通过，0失败。** 原工程四份源码仍等于各自 source-before SHA，meta 仍等于起始 SHA。负对照证明了已观察错误的接口缺口；它不是重新运行原 Main5。

结果：`work/parallel-50-render/validation/contract-results.json`。

### 5.2 实际候选的独立 HLSL 编译与二进制检查

使用实际存在的 Windows SDK FXC：`C:\Program Files (x86)\Windows Kits\10\bin\10.0.26100.0\x64\fxc.exe`。文件版本 `10.0.26100.8249`，工具 SHA256 `005eff830845789c7efb2831a0b41950ee6954e9bcd93baf50de67ad537728b2`。

`audit-official/validate_shader_fxc.py` 直接从候选抽取 HLSLINCLUDE + 每个实际 HLSLPROGRAM，使用原 pragma 的入口。37个官方 include 的路径和 SHA 已保存。FXC 缺少 Unity PackageManager 解析，因此仅将审计副本的 include 路径映射至真实 PackageCache 内容；没有替换函数体、制造 stub 或复制另一份实现。

编译设置：D3D11、`vs_5_0/ps_5_0`，`SHADER_TARGET=20`、`UNITY_VERSION=202230`，实际 stage 宏及每次变体宏，`/Gec` 兼容官方 Deprecated.hlsl 的全局 half。`SHADER_TARGET=20` 保持原预处理门，SM5 profile 并不能证明全部平台 target2.0 能力约束。

覆盖所有25+2 Pass 的顶点/片元；HDR开关；Pass23/24的 sRGB/debug组合；common纹理数组禁用和 single-slice相关宏。另有显式定义 USE_TEXTURE2D_X_AS_ARRAY 的探索分支用于激活额外 guard，不表示当前场景实际使用 XR，也未声称穷举全部变体笛卡尔积。同内容的 `_0` 副本通过 SHA相等闭合，避免重复编译。

**主 owner 复跑结果：228次编译全部退出0并生成非空DXBC，失败0。** 三份实际 `/dumpbin` 断言全部通过：

- CoreBlit Pass1 有 `_BlitTexture`、`sampler_LinearClamp`、`sample_l_indexable`，确实采样输入纹理。
- ColorAndDepth Pass1 有 `_InputDepthTexture`、颜色采样、`SV_Depth/oDepth`，确实写出深度。
- CoreBlit Pass21 HDR分支有 `_BlitDecodeInstructions` 与 `_BlitCubeTexture`。

结果：`audit-official/fxc-root-verified-results.json`；完整复跑输出：`validation/fxc-root-run.log`；DXBC、日志与反汇编在 `audit-official/fxc-output/`。详细适配、覆盖和工具盘点见 `audit-official/官方契约与独立编译审计.md`。

保留 FXC 对 Unity 专有 pragma 的 X3568 警告，以及官方 DEBUG_DISPLAY 路径的 X4000 可能未初始化警告。缺失的主机专用 API/VFX include 在当前D3D11分支不激活，路径完整保留。没有宣称0warning，也没有宣称 Unity ShaderLab 前端已通过。独立 csc 对本阶段纯 Shader 候选不适用。

### 5.3 实际 apply 脚本隔离验证

`apply_stage50.py` 默认只检查。只有 `--apply` 才写四份源码，先全量校验 source-before、原meta、candidate、已安装官方源码 SHA 和两个 Renderer 的精确字段GUID；校验全部通过后才写，并逐文件再次核源SHA、写后核candidate与meta。

`test_apply_guards.py` 在本任务 guard-tests 中复制最小工程夹具，实际子进程执行同一个 apply脚本：**10个场景通过，失败0**。

| 场景 | 结果 |
|---|---|
| 默认check-only | 退出0，项目零写入 |
| 正常apply | 退出0，只改变四份Shader，所有meta保持 |
| 重复应用到已变化源 | 退出2，零新增写入 |
| 最后一份源发生漂移 | 全量预检退出2，前面文件也未写 |
| meta / candidate / official分别漂移 | 各退出2，项目零写入 |
| Renderer绑定漂移 | 退出2，项目零写入 |
| 源文件缺失 | 退出2，项目零写入 |
| manifest越界范围 | 退出2，项目零写入 |

真实共享工程执行过默认check-only，退出0、writtenFiles=0。结果为 `validation/apply-guard-results.json`。脚本不是跨文件事务：若预检后仍有并发写入，逐文件复核会拒绝受影响文件，但此前文件可能已写。因此主窗口需按约定串行集成，不应与其他写者并发应用；本次没有对并发原子性作保证。

### 5.4 独立审查

另一审查agent只读检查了四候选、官方内容和应用工具，在其review目录独立重跑228次FXC并全部通过，3个字节码契约通过；重新比对27个唯一Pass提取正文和37个依赖副本，确认只进行了include路径改写。隔离contract及10项apply保护重跑通过，真实工程check-only再次退出0。`review/review.json` 的passed=true、blockingFindings为空。审查明确保留Main5未采GUID、ColorAndDepth未观测depth=true、独立FXC层级和apply非整批事务四个边界。

## 6. 主窗口执行命令与 Main6 复验

在实际 x20 根执行，先确认检查结果：

```powershell
& 'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe' -X utf8 'work/parallel-50-render/apply_stage50.py'
```

主窗口统一集成时执行：

```powershell
& 'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe' -X utf8 'work/parallel-50-render/apply_stage50.py' --apply
```

若source-before或meta已漂移，应保留拒绝结果重新审查，不能force覆盖。脚本不启动Unity、不删除缓存、不触发Play。本窗口没有执行真实工程 `--apply`。

主窗口在用户已有GUI Editor中依次完成：

1. 统一导入四个Shader。按资产路径加载，每份记录GUID/instanceID/name/isSupported/ShaderUtil消息；CoreBlit的passCount=25、keywordSpace中BLIT_DECODE_HDR有效，Material.FindPass的BilinearDebugDraw=23、NearestDebugDraw=24；ColorAndDepth的passCount=2。检查 `ShaderUtil.ShaderHasError` 和所有编译消息。
2. 读回 `GraphicsSettings.currentRenderPipeline` 的路径及默认Renderer，读回 `shaders.coreBlitPS/coreBlitColorAndDepthPS` 的实际对象路径/GUID/instanceID。补齐Main5缺失的运行对象身份；若运行中换到Addressable配置，应相应记录其 `_0` Shader对。
3. 正常打开同一个原 MineGameMain，用已有观察工具进行 Main6 的30秒/15快照观察。保留原错误记录，将本轮新结果另存，不清日志伪造通过。确认frame1两错误消失；如有新错误，保留完整栈和实际运行Shader身份。
4. 观察provider真实资源消费receipt、Version服务/完成回调、后续模块与场景状态，判断是否继续推进。渲染错误消失本身不等于provider完成或地图进入。
5. 保存实际图形画面，继续原地图、开格/占领、兵堆生成/移动/战斗及输入验收。只有这些真实链有证据后才改变coreGameplayAccepted。

可供主窗口桥接工具采用的诊断文本在 `work/parallel-50-render/Main6-readonly-shader-probe.cs.txt`；它不属于candidate、不在Assets中，也未在本窗口编译/执行。它只读导入状态与既有绑定，临时Material只用于命名Pass检查并立即释放。

## 7. 保留的未闭合项

两份Renderer中仍有CopyDepth、Sampling、HDR overlay、MotionVector、deferred/debug/fallback/terrain等导出占位。完整字段/GUID/Dummy标志保存在binding-evidence。当前2x opaque路径使用CoreBlit；没有证据允许把所有内部或游戏Shader批量替换。本次没有扩大候选到这些文件；如果Main6实际走到新缺口，应按真实调用及原GUID逐项恢复。

13个真实Spine Shader、游戏自定义Shader、材质、贴图、业务C#、其他owner文件、ProjectSettings和Renderer/Pipeline资产均不在写范围。Unity导入、真实GPU画面、Android/GLES/Vulkan/Metal编译、原APK像素等价、资源服务完成和核心玩法都未在本窗口验收。

## 8. 交付索引

- 所有权及前后SHA：`work/parallel-50-render/owned-scope.json`、`apply-manifest.json`。
- 完整原件与meta：`work/parallel-50-render/before/Assets/Shader/`。
- 完整候选：`work/parallel-50-render/candidate/Assets/Shader/`，仅四文件。
- 可执行apply：`work/parallel-50-render/apply_stage50.py`，默认check-only。
- 交接：`work/parallel-coordination/stage50-handoff.json`，state=ready_for_integration。
- 绑定审计：`work/parallel-50-render/audit-binding/`。
- 官方契约、实际候选编译与DXBC：`work/parallel-50-render/audit-official/`。
- 验证结果：`work/parallel-50-render/validation/`。
- 本报告的对应归档证据：`outputs/恢复过程文档/证据/50-URP内部Shader与原场景渲染/`。
- 当前窗口threadId：`01a15371-b9fc-71e0-beab-5ab4ea2338de`（本窗口环境变量CODEX_THREAD_ID/CODEX_SESSION_ID实读一致）。

本阶段交付解决的是已复现CoreBlit接口缺口的可集成候选与验证证据。原场景持续渲染和总体游戏目标仍以主窗口实际GUI验收为准。


## 主线程实际集成检查点

主线程已实际应用四份官方Shader正文并保留原meta。Unity actualShader读回Pass25/2、HDR关键字、supported及两套Renderer引用全通过；Main6未再出现CoreBlit两错误。此结果不代表原Android像素等价或游戏玩法运行。 详见[第10篇最新运行结果](10-Unity运行验收.md)。用户已要求暂停后上传，源码本批冻结。
