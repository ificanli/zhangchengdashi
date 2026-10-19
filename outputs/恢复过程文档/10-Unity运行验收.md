# 10：Unity原场景与核心玩法运行验收

**总体状态：未通过。** 第14轮完整工程导入已成功退出0；原MineGameMain已完成四轮真实PlayMode观察，尚未跑通原启动和核心玩法。

## 第一轮原场景观察

入口为`ObserveRecoveryPlayMode.Run`，打开原`Assets/gameres/bundleres/Scene/MineGameMain.unity`后正常进入PlayMode，没有手工调用初始化、设置登录成功或创建替代地图。原Main对象上的GameStartEntry确实激活，帧1快照保留真实配置AppName=ljzs_lt、gameCode=U-CSZDZ、m_Fastmode=false。

观察状态为`runtime_error_observed`，记录7条错误。首批问题：

1. logo_Atlas和Loading-zsj_Atlas的atlasFile无法作为TextAsset读取。GUID实际指向两个原atlas明文文件，但导出扩展名是`.atlas.atlas`，当前Unity没有把它们导为TextAsset。已将其改为`.atlas.txt`，原内容、meta、GUID完整保留，待下轮真实读回。
2. Entities正常world bootstrap创建AIMovementSystemGroup时抛出未创建异常。其导出OnCreate正文为空，漏掉原生base.OnCreate调用和真实RateManager，正在按原native恢复生命周期。
3. Spine的NoRender Material/_MainTex错误来自缺atlas后的RegionlessAttachmentLoader兜底，先修真正atlas链，不先伪造材质属性掩盖。

本轮在frame1保存快照后退出，不能证明场景持续运行、登录、地图生成或输入交互。

## 已完成的独立运行层

真实Unity GlobalInfo配置消费探针已通过65项当前分支检查，详见第28篇。该结果仅覆盖实际当前分组选表，AB初始化未完成，核心玩法没有自动验收。

## 后续必须验收的链

- 原首场景GameStartEntry→Version/资源/UI/旧配置→ProcedurePreLoad的真实前置生产。
- 原AssetsManager/登录→GameLauncher→时间、存档、UI、加载协程→GameManager.Init。
- 原地图、开格/占领、单位/兵堆生成、移动战斗及胜负状态。
- 图形Editor中的原资源画面和实际输入；batchmode/nographics状态检查不能代替视觉与手动交互。

当前证据：[首轮原场景观察JSON](证据/运行验收/unity-play-main1.json)、[首轮有界错误清单](证据/运行验收/main1-error-summary.json)。后续每轮在本篇追加，不抹掉早期失败。

## 第二轮原场景观察：首批错误消失

修复两个真实Spine atlas文本导入扩展名，并依据原生恢复ECS系统组创建/释放后，再次打开同一个原MineGameMain正常进入PlayMode。观察30秒、15次快照、错误0，最后快照已到140950帧、游戏时间约27.98秒。原Main入口组件仍激活，场景始终是MineGameMain。

观察状态为`observation_completed_core_gameplay_not_accepted`。此时GameStartEntry原入口仍是导出空壳，因此没有资源/流程推进和原Game场景切换；不能把无错误的加载场景当作地图或玩法运行。下一步恢复首场景原框架入口及其实际初始化生产者，继续观察真实阻塞。

[第二轮完整观察JSON](证据/运行验收/unity-play-main2.json)。本次没有通过输入、地图、开格/占领或兵堆战斗验收。


## 第三、四轮：实际抵达版本模块的未恢复初始化门

第三轮已接入第37篇的原首场景入口、第33篇的TimeManager与第29篇的GameManager源码。Unity进程17456退出0，持续30秒、15次快照、错误0；场景始终为原MineGameMain。Main已处于DontDestroyOnLoad，但没有进入后续玩法。第三轮的普通组件快照尚不足以直接证明停在哪个纯C#模块。

第四轮只扩展观察工具，读取原入口已经创建的模块集合、模块继承字段和已保存回调的目标名称。没有调用GetModule、Instance、属性getter或任何业务方法，也没有改门条件。Unity进程19020退出0，持续30秒、15次快照、错误0。从frame1至frame130135均只有一个VersionMondule：原完成字段false，原下一步回调已保存，CurrBundleServices、persistentABRes、streamingABRes均为null，框架started为false。

该结果把“静态上应停在Version.Initialize空正文”的判断落实为实际场景中的状态证据。当前版本模块没有产生资源服务与完成通知，因此后面的资源、UI、配置与Procedure链尚未启动。下一阶段恢复原版本/资源模块的必要方法，并为Editor提供实际读取原资源的本地平台实现；本地验证和读取失败时不能通知完成。

本轮不能证明TimeManager或GameManager已在场景内被调用；它们只是随工程正常编译并接入。也不能证明地图、开格/占领、兵堆、战斗或图形输入已工作。`coreGameplayAccepted`继续为false。

证据：[第三轮完整观察](证据/运行验收/unity-play-main3.json)、[第四轮含模块字段的完整观察](证据/运行验收/unity-play-main4.json)、[汇总及观察源码SHA](证据/运行验收/main3-main4-summary.json)、[本轮观察工具源码快照](证据/运行验收/ObserveRecoveryPlayMode-main4.cs.txt)。


## 第五轮：图形Editor实际启动，CoreBlit渲染契约失败

第38/39/40/45/46阶段及BundleAssetInfo依赖到达稳定点后，主线程重新核对42项源码/meta SHA，复用用户从Hub打开的GUI Editor3808。第一次命令因原Game场景dirty被保护检查拒绝，没有进入Play。用户随后明确指示“不管，直接切，不保存”，第二次命令记录authorizedDiscard=true，正常切换原MineGameMain并进入Play，未保存原Game的未提交场景修改。

本轮在frame1记录两条真实图形渲染错误后正常退出Play，保留Editor窗口：

1. `Local keyword BLIT_DECODE_HDR doesn't exist in the shader.`
2. `RenderingCommandBuffer: shader Hidden/Universal/CoreBlit: invalid pass index 1 in DrawProcedural`。

这与前四轮nographics观察不同，直接暴露图形Editor使用的内部Shader契约。当前发现Assets/Shader中有两份同名Hidden/Universal/CoreBlit导出文件；第50号独立任务已负责对照官方同版本URP/Core实现、实际GUID绑定和Pass/keyword，不靠禁用渲染或清日志掩盖错误。

实际快照中UpdateManager已由原Instance路径创建并进入DontDestroyOnLoad，Version的原Initialize已经启动LocalEditorResourcesProvider实际验证。收据runId为20261019-091119-949-e8345b58，停在APK后台哈希的yield阶段，manifest/payload/typedLoad仍为0。观察器因图形错误在第一帧退出，因此不能把这份partial当成资源校验失败，也不能称版本或资源服务通过。

当前没有场景过渡或核心玩法验收。后续先修图形Shader，再重新执行原Main。独立Editor资源Probe的结果单独归档，不会把其私有Provider的ready接回原Version回调。

证据：[实际第五轮观察](证据/运行验收/unity-play-main5.json)、[用户授权后的命令回执](证据/运行验收/editor-command-e356ab436719471cb34b4a5b52590ec6.json)、[源SHA及运行准备](证据/运行验收/unity-play-main5-launch.json)、[保留的资源partial](证据/运行验收/main5-local-resources-partial.json)。


## 第六轮与用户暂停检查点

已合入41配置15方法、42流程82方法、43格子45方法、44战斗197方法，共339个原方法正文，以及50四份同版本官方Shader。后续必要38个配置主键getter、UI48A、数据默认49、Provider生命周期修复也已接入，原GUID/meta保留。完整GFRunning和Assembly-CSharp独立官方rsp编译错误均为0；这些仍不代表运行验收。

实际GUI Shader读回通过：两个CoreBlit有25Pass和BLIT_DECODE_HDR关键字，两个ColorAndDepth有2Pass，四者isSupported=true、ShaderUtil errors=0，两套Renderer绑定及当前SamplesPipeline/默认Renderer身份匹配。原第五轮两条渲染错误在本次45秒观察中未再出现。

Main6在现有Editor3808正常进入原MineGameMain，观察45秒、22个快照、Error0。它始终只显示VersionMondule；资源Provider有新runId，仍停在后台APK哈希等待，payload/manifest/typed-load进度均0，结束时已正确记录cancelled_editor_session、ready=false及ExitingPlayMode原因。

必须保留一个重要限制：后半段快照frame固定1803、游戏时间固定约9.987秒，而Editor观察时钟继续推进。因此不能把“45秒无Error”说成游戏持续运行，更不能认定资源版本启动完成。下一恢复轮应诊断GUI播放帧停止推进与后台哈希等待的关系，再检查正常启动回调；此处未通过删等待、强置ready或复用私有Probe成功状态掩盖。

用户要求“做完停下来，传一下git”，当前批整合和本轮验证已结束，恢复目标已标paused。不会继续新玩法恢复；本次Git交付保存工程、报告和分析现场。此前独立私有资源Probe2通过53typed loads、34载荷、50TextAsset/5142locator，原共享startup并未因之完成。地图、开格/占领、兵堆移动攻击、死亡和胜负循环均未验收。

证据：[整合暂停检查点](证据/四路整合与暂停检查点/checkpoint.json)、[Main6完整观察](证据/四路整合与暂停检查点/unity-play-main6.json)、[取消收据](证据/四路整合与暂停检查点/main6-provider-cancelled.json)、[实际Shader及Renderer读回](证据/四路整合与暂停检查点/unity-render-bindings1.json)。
