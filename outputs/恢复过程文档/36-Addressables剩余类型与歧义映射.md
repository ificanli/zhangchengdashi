# 36. Addressables 剩余类型与歧义映射

本阶段已修订 **9 条有原容器与序列化引用证据的类型映射**，并对 **5 张 PNG 的 TextureImporter 各修改两个字段**，消除重复生成 Sprite 的来源。4 个原地址本就包含多个 Sprite，现已明确移入 pending，没有任选其中一个对象。当前计划为 **5,142 条可验证映射、60 条 pending**，仍不能标记完整恢复或核心玩法通过。

主代理第二轮真实 Unity Fast Mode Build 已通过：**5,142 条类型检查通过，5,142 次官方 locator 核对通过，类型失败和 locator 歧义均为 0，进程退出码 0。** 60 项 pending 仍未接受，`complete=false`、核心玩法未验收。本代理没有自行启动 Unity；实际报告、官方 settings 和退出记录已归档于第 7 节。

## 1. 修订前的真实问题

主代理第 14 轮正式导入后，真实 Addressables 验证读取 5,146 条 entries 和 56 条 pending，验证通过 5,133 条，留下 13 条实际导入类型不匹配。正式 Fast Mode Build 建立 3,952 个 entry、核对 5,133 次 locator，又出现 5 个同 address／Sprite 类型的双重定位结果。两份报告均为 `complete=false`。

本阶段使用 systematic-debugging 的根因取证方式，将原 catalog、原 bundle 容器／PathID、导出 YAML 的 PPtr/GUID 和实际 Unity 类型／locator 报告连接起来。没有根据相似文件名选择候选，也没有把 validator 改成接受第一个结果。

13 个类型失败分为：URP Renderer Feature 1 项，两个字体各自的 atlas Texture2D／Material 共 4 项，Crown 的 Material 1 项，材质嵌入渐变 Texture2D 1 项，6 个 PNG 地址的 Sprite 请求。5 个 locator 歧义则是原 PSD 地址导出了独立 Sprite.asset 和 Texture PNG，而 PNG importer 又额外生成 Sprite，导致同一原地址有两个 Sprite 位置。

## 2. 原对象身份和当前引用如何连接

对 18 个受影响 catalog 行（13 个类型失败与 5 个 locator 失败）读取相应原 APK bundle，逐项取出原 AssetBundle 的 container key、直接对象 PPtr、serialized file、64 位 PathID、类型、名称和 preload 段。第一依赖 bundle 只作为查找起点；只有实际匹配到原 container key 和对象时才作为证据。本轮 18 行均在查找 bundle 中取得了原容器对象。

原生容器的同一个 key 可以登记多个准确类型的对象。此前“原路径存在就优先使用该文件”的规则使一些子资产请求仍指向根 MonoBehaviour／Material，Unity 导入检查因而正确失败。本次把有明确关系的 typed request 改指其真实独立导出对象，保留原 address、requestedType、requestedAssembly、group、labels 和 originalInternalId。

9 个改动对象都具备完整 `sourceBundle/sourceFile/sourcePathId/sourceType/sourceName`。其中旧 AssetRipper `path_id_map.json` 只确切收录了 3 项，故 `pathIdMapConfirmed` 如实为 **3 true、6 false**。这与本轮直接读取原 bundle 的证据是两个口径；独立证明记录 `nativeContainerConfirmed=true`，没有为让 validator 通过而假写旧 map 命中。

## 3. 9 条实际类型映射修订

| catalog 行 | 原请求地址／类型 | 已证明的实际导出对象 |
|---|---|---|
| 716 | SamplesForwardRenderer.asset／RenderObjects | Config/Render Effects.asset |
| 720 | GenSenRoundedTCJP-BSDF.asset／Texture2D | GenSenRoundedTCJP-BSDF Atlas.png |
| 721 | 同字体地址／Material | GenSenRoundedTCJP-BSDF Material.mat |
| 741 | PowerNumFont SDF.asset／Texture2D | PowerNumFont SDF Atlas.png |
| 742 | 同字体地址／Material | PowerNumFont Atlas Material.mat |
| 2758 | Crown.asset／Material | Altas/icon_HW_1 Material.mat |
| 3042 | mat_glow14.mat／Texture2D | 原 `_ColorRampTexGradient` 引用的准确 PNG |
| 2166 | bmp_HW_jijin_8.png／Sprite | FundPanel/bmp_HW_jijin_8_0.asset |
| 4183 | bmp_HW_jjcyl_3.png／Sprite | Dynamic/Common/bmp_HW_jjcyl_3_0.asset |

URP 一项既有原 SamplesForwardRenderer 的 `m_RendererFeatures` PPtr 指向原 Render Effects 的 PathID，也有当前 renderer YAML 的 feature GUID 指向这个导出对象。其 script GUID 对应实际 URP 14.0.12 包中的 `UnityEngine.Experimental.Rendering.Universal.RenderObjects`，与 catalog 请求类型一致；没有把父 RendererData 当作 RenderObjects。

两个字体的原 material PPtr、`m_AtlasTextures` PPtr 与原同 key 的 Material／Texture2D PathID 分别相同。当前字体的 material／atlas GUID 解析到对应独立导出文件，字体材质 `_MainTex` 又与字体 atlas GUID 相同。这是双向关系核对，不是用字体名称推测贴图。

Crown 的原 `material` 字段确实为 null，本阶段原样保留。其 Material 请求来自同 container key 直接登记的 `icon_HW_1 Material` 对象；原材质 `_MainTex` PPtr 与 Crown.spriteSheet PPtr 相同，当前导出材质 `_MainTex` GUID 也与 Crown.spriteSheet GUID 相同。因此可以修正该 catalog 的 Material 映射，不能顺手把 Crown.material 改成非空。

mat_glow14 的原 `_ColorRampTexGradient` PPtr 正好指向同 key 的嵌入 Texture2D PathID `1209810381784203910`。当前材质的同一属性 GUID 为 `8c2683af4693e6c4ea6cc793298fa98b`，唯一解析到对应的长名渐变 PNG。完整路径、原名称和哈希保留在 JSON 证据，没有截短或重命名资源。

两项 Sprite 请求在各自原容器中都只有一个 Sprite，分别是 PathID `-5249927552142160770` 和 `3084142577113659703`。独立导出 Sprite 的 vertex／index 原始字节与该原对象完全相同，`m_RD.texture` GUID 指向正确 PNG。只有这两个可唯一证明的 Sprite 请求被改到准确现有 asset。

## 4. 5 个 locator 歧义的根因修复

| 原 Sprite 地址 | 仅调整的 PNG GUID | 保留的原独立 Sprite |
|---|---|---|
| White.psd | `1e47e4a5d7476624b8a913e014a97673` | White.asset |
| Bubble Circle L.psd | `cff2fbaa761976b45b43d07a39fdc509` | Bubble Circle L.asset |
| Bubble Circle R.psd | `86d3f3e9960586e44bcce2f06f9a1d68` | Bubble Circle R.asset |
| Bubble Square L.psd | `98bd2b13ea1c2ce4f856e281920a2a8d` | Bubble Square L.asset |
| Bubble Square R.psd | `376ca4775fac8e145b9cf260d091503f` | Bubble Square R.asset |

每个独立 Sprite 均与原 Sprite PathID 的 vertex／index 字节对应。对 5 个 PNG GUID 进行全 Assets 文本引用扫描，包含源文件、meta 与序列化资源：PNG 只有其独立 Sprite 的 `m_RD.texture fileID=2800000` 消费，没有引用 importer 自动生成 `fileID=21300000` Sprite 的消费者。独立 Sprite GUID 仍保留原 prefab／UI 引用。

因此只在这 5 个已核实 source GUID 的 PNG.meta 中，把 `textureType: 8 → 0`、`spriteMode: 1 → 0`。这使 PNG 继续作为 Texture2D 被原独立 Sprite 使用，停止额外自动生成同地址 Sprite。没有修改 PNG 字节、GUID、sprite asset、任何 prefab 引用或其余 importer 字节，也没有在 locator 中选择第一个对象绕开歧义。

全部 meta 的修改前／后字节和 SHA-256 已归档；写入后逐项重新读回。主代理第二轮 Unity 导入后再读回，5 份 meta 的哈希仍与冻结值完全相同；实际 locator 歧义均已消失，详见第 7 节。

## 5. 4 个 multi-Sprite 明确保留 pending

另 6 个失败 PNG 的 importer 实际上已经是 `textureType=8, spriteMode=2`，但 `spriteSheet.sprites=[]`，并非简单的“把 Texture 改成 Sprite”即可恢复。原始 Sprite 已作为独立 `.asset` 导出。

其中两项原容器只有一个 Sprite，已在前文准确映射。另四项原 key 各包含多个 Sprite：

| catalog 行／原地址 | 原容器中的 Sprite 数量 | 当前状态 |
|---|---:|---|
| 2116／bmp_HW_zc_16.png | 4 | pending |
| 2118／bmp_HW_zc_17.png | 4 | pending |
| 2120／bmp_HW_zc_18.png | 3 | pending |
| 2150／bmp_HW_jijin_13_1.png | 3 | pending |

14 个原 Sprite 的 PathID、名称、当前精确候选路径均记录在 `applied-repair.json` 和新计划 pending 条目。当前尚未证明这个不含子对象 local-ID 的单个 Sprite typed request，应该唯一指向哪个对象；也没有运行验证重建 importer slice 后的原单对象选择契约。不能根据 `_0` 后缀、容器出现次序或“全尺寸看起来像默认”自行选一个。

这 4 条从 entries 移到 pending 后，保留待定的总数为 60：**41 Mesh、15 AnimationClip、4 Sprite**。此前 56 条 pending 逐项保持不变；没有强解 multiMesh 或 animation 身份。类型验证候选降到 5,142 不代表丢失原请求，而是将 4 个原本错误地标为 resolved 的多对象请求如实改为 pending；总 catalog 资产行数仍为 5,202。

## 6. 修改范围、读回与后继验收

实际工程资源修改只有上述 5 份 PNG.meta 的 10 处字段值。工作区计划 `work/startup-restore/addressable-recovery-plan.json` 使用既有 `write_json_atomic` 写入，完整 JSON 读回与目标结构相等，最终 SHA-256 为 `fbb2c2647a6847b35a605228d3c8755cd6491e1870f734ffbd8f6871718443cb`。

静态回读确认：除 9 条映射及 4 条移入 pending 的行，原 5,133 条其他 entries 与修改前相同；原 56 条 pending 相同；5 张 PNG 字节哈希相同；5 份 meta 仅上述两个字段变化，其余字节保持。没有编辑 C#、场景、Crown.material、字体正文、Spine atlas 扩展或其他资源。

本批不会重新运行整个旧 plan 生成器，因为原生成器的“路径存在优先”会再次把这些 typed 子资产映射覆盖回根文件。当前改动的前后计划、准确 overlay 和生成脚本已归档；若未来要重建 plan，必须重用这些证据式修订，不能无条件以旧生成结果覆盖本稳定点。

主代理已经重新导入受影响 meta，并执行真实类型检查和正式 Fast Mode Build／官方 locator 验证。结果按实际报告记录在下一节，仍保留 60 pending 与 `complete=false`。

归档目录为 `证据/Addressables剩余类型与歧义映射`，含原 bundle 直接对象／preload 证据、当前引用图、全 GUID 引用审计、9 条映射／4 条 pending／5 份 meta 的精确变更、修改前后完整计划、meta 前后字节、修订前真实 Unity 报告、只读提取与有界修订脚本及 SHA-256 清单。

## 7. 第二轮真实 Unity Build 结果

原始实际报告时间为 `2026-10-19T08:06:02.9781710Z`（本地 UTC+8 为 16:06:02），主代理运行 `BuildRecoveryAddressables` 的正式 Fast Mode 流程。进程 6408 的退出记录明确为 `ExitCode=0`。

| 实际指标 | 第一轮 | 修订后第二轮 |
|---|---:|---:|
| 输入可验证 entries | 5,146 | 5,142 |
| pending | 56 | 60 |
| 实际通过类型检查 | 5,133 | 5,142 |
| 类型失败 | 13 | 0 |
| 官方 settings entryCount | 3,952 | 3,961 |
| 官方 locator 核对次数 | 5,133 | 5,142 |
| locator 失败／歧义 | 5 | 0 |
| fatalError | 空 | 空 |
| complete | false | false |

第二轮输入数量少 4，是因为 4 个尚未判明单对象 local-ID 契约的 multi-Sprite 行明确移入 pending；原请求没有删除，总资产行数仍为 5,202。新增通过的 9 条是前文具有确定身份的 typed 映射，不能把剩余 60 项写成“也通过了”。

官方 settings 根资产为 `Assets/RecoveryTools/GeneratedAddressables/RecoveryAddressableAssetSettings.asset`，SHA-256 为 `51d512bd81e1baace831f7a74464d629a30ffd32522041c7e30f82e493f564f0`。该 settings 目录下 128 个实际文件（含 groups、schema、builder 与 meta）已原样归档，并逐项记录哈希，便于将实际成功报告连接到本次生成的官方设置。

原实际 Build 报告 SHA-256 为 `45eeeb187812a5c761569f282df87e374f4ee15253f804342d676011e1310e49`。证据中保存路径脱敏的完整报告、独立汇总 `actual-build2-validation.json`、实际退出记录、授权／设备信息脱敏后的 Unity 日志和原日志哈希。5 份修改后的 meta 在本轮 Unity 执行后再次逐项校验，仍与本批冻结哈希相同。

本次接受范围是：已证明身份的 5,142 条映射在官方 **Fast Mode settings locator／AssetDatabaseProvider** 中通过类型与唯一位置检查。它没有验证打包后的 Player bundle、实际下载或所有资源的视觉内容；剩余 41 Mesh、15 AnimationClip、4 multi-Sprite 身份仍待定。首入口、版本服务、场景推进和核心玩法继续按各自阶段验收，不能由本次 Build 成功推断。
