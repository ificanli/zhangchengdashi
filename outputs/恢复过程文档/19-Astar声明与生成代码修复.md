# 19｜Astar声明、生成代码与缺失正文边界

本阶段将AstarPathfindingProject从第九轮导入暴露的声明错误推进到**同一Unity编译器、同一rsp引用和同一组analyzer/source generator下独立csc成功：exitCode=0、errors=0**。独立编译的DLL、PDB、引用DLL和生成源码仅写入`work/`，没有启动Unity，没有覆盖Library中的正式编译产物。

本轮最终修改157个现有C#文件，另外归档3个独立IL后处理生成源及其原meta。范围仅为AstarPathfindingProject，未修改GameLauncher、AssetsManager、Singleton或Unity包源码。**2个有原native证据的本地构造函数完整恢复；其余声明修复、生成物处理和显式缺失诊断的算法恢复计数均为0。**Astar寻路、RVO、Entities系统和原游戏核心玩法仍需恢复其实际正文并验证，不能把本次编译成功写成库或玩法已经可用。

## 1. 用Unity实际rsp复现，而不是另造宽松编译环境

第九轮摘要原有306项错误，全部属于AstarPathfindingProject。主流程已先用既有Roslyn接口工具处理58个文件，记录其body逐字不变。本子阶段接手时以当前源码重新编译，实际剩余为80项，不能继续把旧306项当成当前错误。

原响应文件为：

`Library/Bee/artifacts/1900b0aEDbg.dag/AstarPathfindingProject.rsp`

独立复现保留其中的全部引用、define、C#9语言版本、unsafe选项、Unity analyzer/source generator和additional file。使用安装的Unity2022.3.62f3c1自带NetCoreRuntime及DotNetSdkRoslyn/csc.dll。仅把out/refout重定向至`work/astar-repair`；收集生成源码时增加generatedfilesout，输出至短工作路径`work/ag`。没有删除analyzer、改变语言版本、全系统排除Astar或用空替代程序集遮住错误。

分层结果如下：

| 已核实阶段 | 错误数 | 含义 |
| --- | ---: | --- |
| 第九轮原摘要 | 306 | 主流程接口修复之前的Unity诊断 |
| 对58文件接口修复后的当前源码独立复现 | 80 | 56个内部类型访问错误，及接口、约束、Burst桥接可访问性等 |
| 第一批声明和生成物处理后 | 4 | 原生容器约束向调用签名的传递 |
| 补齐4处约束传递后 | 744 | 编译器进入先前被遮住的构造/out/ref-null空桩 |
| 严格显式缺失诊断后 | 2 | 两个需要原native证据的继承构造 |
| 两构造恢复后进入源生成层 | 53 | EA0007/EA0008：导出声明缺失partial |
| 恢复partial后 | 24 | SGJE0008：每个IJobEntity同时含业务Execute和旧生成的chunk Execute |
| 按官方源生成器清理旧生成成员后，最终复现 | **0** | **exitCode=0，官方source generators保持启用，DLL已实际输出** |

最后还单独回退了一个不必要的约束收紧：`SpanExtensions.GetAllocator<T>(NativeArray<T>)`仅需struct，保留其原有API范围；再次编译仍为exitCode=0、errors=0。最终证据以`final-narrowed`为准。

## 2. 接口身份与静态重载必须区别

主流程58文件的通用显式接口转写主要恢复了IEnumerator、IAstarAI、IJob等的C#表达。本轮补齐三个带`global::`编码前缀的IEnumerator.Current属性，以及FollowerEntityProxy的IAstarAI.onSearchPath、FinalizeMovement和MovementUpdate。修改仅涉及显式接口声明，继续使用原accessor helper调用和原方法正文。

同时修正一个通用工具的过度匹配：BBTree.NearbyNodesIterator的原Token `0x06000FF9`，在DummyDll中明确是`private static MoveNext(ref NearbyNodesIterator)`。它是Burst静态辅助重载，不能表达为无参实例接口`IEnumerator.MoveNext()`。本轮按原Token、static/private标记和参数签名恢复辅助方法；真正的无参接口实现保留。此处没有升级语言版本来容纳错误的静态接口声明。

原metadata摘录已保存于`original-generated-method-metadata.json`。后续复用接口工具需要同时核对实例/静态身份和参数签名，不能只按MoveNext这个名字匹配。

## 3. unmanaged约束来自实际存储要求，不虚称metadata完整保留了它

UnsafeSpan<T>和NativeCircularBuffer<T>的原导出声明包含T*；SlabAllocator<T>及相关签名使用NativeList、UnsafeList、NativeQueue等要求unmanaged的容器。struct仍允许含托管引用，无法表达这些实际存储要求。

本轮恢复必要约束，并将约束传递至原本接收或返回UnsafeSpan/SlabAllocator的签名。最终保留31处必要的约束表达；没有给整个程序集或所有struct泛型统一加unmanaged。

原DummyDll中的泛型约束只有ValueType等标记，没有保留IsUnmanagedAttribute；因此此处证据口径是“依据原T*和原容器签名恢复C#必需的约束”，并不声称从DummyDll直接读回了完整的原unmanaged标记。原泛型metadata清单已保留，便于独立核对。

正文层后来出现的6个CS0208属于另一种情况：`return ref *(T*)null;`或对PathRequestSettings的同类null解引用，是导出器生成的ref-return占位。CircularBuffer本来可以包含托管T，PathRequestSettings也不应被为了占位表达强制改成非托管类型。因此没有扩大约束或改写业务组件字段，而是只把这些精确占位body改成显式缺失异常。

## 4. 原ILPP输出不能作为普通源重复注册

56个CS0122由54处内部Unity.Entities.MonoPInvokeCallback，以及独立TypeRegistry和DOTSCompilerGenerated访问引起。只替换成可访问的同名attribute不足以修复：官方IL后处理器随后还会再次生成同名wrapper或注册类。

核对的真实包及源码如下，证据目录含原文件副本及SHA-256：

- Entities1.3.15的ISystemPostProcessor：创建`__UnmanagedPostProcessorOutput__...`，并通过Methods.Add加入`__codegen__OnCreate/OnUpdate/OnDestroy/OnCreateForCompiler`等转发。这里没有对现存同名wrapper的去重检查。
- Entities1.3.15的ComponentDataPP：为组件Equals/GetHashCode生成`__codegen__`转发，并注入内部MonoPInvokeCallback属性。
- Entities1.3.15的StaticTypeRegistryPostProcessor：创建`Unity.Entities.CodeGeneratedRegistry.AssemblyTypeRegistry`及TypeRegistry字段。
- Collections2.5.7的JobReflectionDataPostProcessor：按程序集稳定哈希生成`__JobReflectionRegistrationOutput__...`及注册入口。
- Burst1.8.21的ILPostProcessing：生成PostfixBurstDelegate、BurstDirectCall及BurstManaged伴生物。

据此归档54个明确的旧ILPP转发方法，以及其中两项OnUpdate wrapper的4个Burst伴生类型。每项保留原Token、原源码文本、归档理由及原完整文件备份。删除的均为上述生成器所有的桥接表达，**原ISystem的OnCreate、OnUpdate、OnDestroy、OnCreateForCompiler及原组件Equals/GetHashCode业务方法保留**。

三个独立旧注册源为：

1. Unity.Entities.CodeGeneratedRegistry.AssemblyTypeRegistry。
2. `__JobReflectionRegistrationOutput__10569589673291187727`。
3. `__UnmanagedPostProcessorOutput__10569589673291187727`。

这三个源的导出正文为已知空桩；程序集自身没有业务源码对这三个具体生成身份的直接调用，三个原GUID在项目Assets中均没有序列化引用。原源文件和原meta按字节移动至项目外备份，并在交付证据中提供副本与哈希。其他程序集自己的同名AssemblyTypeRegistry声明不属于本轮范围。

这一步保留当前真实包重新生成注册的机会，**尚未验证Unity ILPP最终产物的TypeRegistry、JobReflection及Unmanaged注册**。独立csc运行Roslyn源生成器，不等于运行Unity后续ILPP。

另外7个Burst可访问性错误，只收窄了三个文件中特定生成delegate/bridge的访问级别，使其不超过原TreeInfo、CutCollection、SpinLock参数类型；未扩大原业务类型访问级别，也未改变其字段或算法正文。

## 5. Roslyn源生成层也需要还原生成前的声明边界

当C#声明与正文阻塞清除后，原rsp中实际启用的Entities源生成器开始报EA0007/EA0008。导出后的普通class/struct声明丢失partial，而ISystem、SystemBase、IJobEntity要求partial。

本轮按真实错误位置恢复31文件内42个类型的partial，全部body保持不变。之后24个IJobEntity各自报SGJE0008：它们同时带原业务Execute和先前生成的`Execute(in ArchetypeChunk, int, bool, in v128)`，源生成器无法确定唯一业务入口。

核对官方JobEntityDescriptionSourceFactory及JobEntityIndentedTextWriterExtensions后，对24个原job只归档生成器明确负责的成员：

- 带CompilerGenerated的chunk Execute。
- InternalCompilerQueryAndHandleData与InternalCompiler。
- `__TypeHandle`、`__EntityManager`、`__ChunkBaseEntityIndices`等生成字段。
- 官方模板产生的Run、RunByRef、Schedule系列及`__ThrowCodeGenException`重载。

共归档658个源级成员，分布在19个文件。原完整源码及每项成员全文均保存在项目外备份和机读清单中。**24个原业务Execute、用户字段、job类型本身、原Token和GUID均保留。**现有调用继续由当前官方生成器产生对应API；没有把业务组件或整个Entities/RVO系统排除。

最终编译中，当前官方JobEntity生成器实际生成24份新的.g.cs。随后用独立Cecil读回工作DLL，确认：

- 24个原业务Execute都存在。
- 每个job都有一个当前生成的chunk Execute。
- 24个chunk Execute的IL都真实调用所属job的原业务Execute。
- 当前生成的TypeHandle和InternalCompilerQueryAndHandleData都存在。

这证明生成链结构已经接通；原业务Execute中尚未恢复的空正文仍然未知。没有把官方生成的调度包装算法计入本游戏业务算法恢复数。

## 6. 318个确定空桩显式失败，其他真实正文保持

744条正文诊断经去重，实际对应121个文件的318个已知占位body。允许转换的形状严格限定为：空body、单条return null/default、空值cast，或精确的`return ref *(T*)null`。

目标body替换为带原类型、方法、Token与RVA的NotImplementedException；没有给out随意填默认值，也没有给struct构造批量塞零来制造成功返回。未匹配已知占位形状的真实body不修改。

独立Roslyn核验逐项比较备份与实际写入，确认318项都来自上述形状，其他2656个body文本不变；擦除body后，诊断阶段的全部声明/属性也保持等价。后续源生成物归档改变了其中一部分生成成员的在编译范围，因此核验按每个阶段的精确备份哈希串联，不把较早阶段的after哈希错误地要求等于最终文件。

318项显式诊断全部计0。没有编译错误的其他未知空正文仍可能存在；本阶段没有宣称为整个Astar程序集恢复了全部实现。

## 7. 两个本地构造的完整原生恢复

### EndingConditionProximity：原字段初值的顺序也恢复

原Token `0x06000A69`、RVA `0x4564C00`。原汇编先把`0x41200000`，即10f，写到派生字段maxDistance的偏移0x20，再调用原ABPathEndingCondition构造，最后把原float实参写回同一字段。原path实参寄存器在base调用前保持不变。

因此恢复为字段初值`maxDistance = 10f`、构造初始化器`base(p)`，以及构造body里的`this.maxDistance = maxDistance`。C#字段初值在base之前执行，保留了原native的顺序；不是只保留最终赋值而漏掉基构造期间可见的初值。

### MutableGraphTransform：补导原基构造证明内联关系

原Token `0x06001085`、RVA `0x44952B0`。Matrix4x4是64字节值参数，在ARM64此处通过指针间接传递。原native调用Object构造后完整复制64字节矩阵，再调用GraphTransform.Set。

补导其真实基构造`0x0600108F / 0x449534C`，确认同样为Object构造、完整64字节复制、GraphTransform.Set，没有额外派生字段工作。因此恢复原`base(matrix)`，本地body保持空转发。

两项实际起止地址、原签名、直接调用和伪代码/汇编均已归档。它们计2个本地构造完整恢复；ABPathEndingCondition、GraphTransform.Set等基类依赖的未知算法仍需独立恢复。

## 8. 写入边界、最终读回与主流程交接

所有源码备份均位于`work/recovery-stubs/astar-...`，不在Unity项目Assets内。归档路径写入前解析为绝对路径，验证仍属于当前项目源范围和本任务备份根；没有递归删除、覆盖未知备份或重置其他工作。

最终独立验证包括：

- 声明/约束阶段保留的业务body逐项不变。
- 121文件的318个精确占位替换及2656个其他body不变。
- partial恢复阶段body不变。
- 从原备份减去658项已记录的生成成员，可逐字重构实际归档后文件；保留的原业务Execute及用户字段不变。
- 三个独立生成源及meta在项目外存在，SHA-256匹配，项目原位置已移出，三个GUID无Assets引用。
- 157个最终现有源码及各自meta的哈希清单。
- 最终Unity同款csc含全部原analyzer/source generator：exitCode=0、errors=0。
- 工作DLL中24对原业务Execute与当前生成chunk Execute，以及24份实际.g.cs的哈希。

两个过程性问题也保留在工作记录中：诊断摘要最初只抽取CS编号，在返回码仍为1时发现遗漏EA生成器诊断，随后扩大到全部字母前缀；观察生成源码时，一次输出目录未建立导致CS0016，改为建立短工作路径后重跑。两次都没有据“摘要0”宣称编译成功。最终成功同时要求真实exitCode=0和DLL读回。

源码已向主流程释放最终稳定点，主流程可进行第十轮Unity导入。本子任务随后冻结Astar源码，仅整理文档和证据。**Unity正式编译、ILPP最终注册、PlayMode、寻路表现及原核心玩法运行都不是本阶段已经通过的验收项。**

证据入口：

- [最终独立csc结果](证据/Astar声明与生成代码/final-narrowed-errors.json)
- [最终原始编译日志](证据/Astar声明与生成代码/final-narrowed.log)
- [实际rsp副本](证据/Astar声明与生成代码/final-narrowed.rsp)
- [独立body及分阶段哈希核验](证据/Astar声明与生成代码/independent-verification.json)
- [工作DLL及当前生成源码读回](证据/Astar声明与生成代码/compiled-sourcegen-readback.json)
- [最终157文件及meta哈希](证据/Astar声明与生成代码/final-source-manifest.json)
- [54个ILPP方法及伴生物、三个独立生成源归档](证据/Astar声明与生成代码/structure-applied.json)
- [318个显式缺失诊断](证据/Astar声明与生成代码/missing-diagnostics-applied.json)
- [42个partial声明](证据/Astar声明与生成代码/sourcegen-partial-applied.json)
- [24个job的658项生成成员归档全文](证据/Astar声明与生成代码/job-sourcegen-artifacts-applied.json)
- [两个真实构造的写入与哈希](证据/Astar声明与生成代码/constructors-applied.json)
- [构造native实际边界与调用记录](证据/Astar声明与生成代码/constructor-native-status.json)
- [官方生成器来源及哈希](证据/Astar声明与生成代码/official-generator-evidence.json)
- [三个旧生成源的GUID引用核验](证据/Astar声明与生成代码/archived-generator-guid-references.json)
- [完整交付证据清单](证据/Astar声明与生成代码/evidence-manifest.json)

复现和核验工具位于`work/astar-repair`；严格占位诊断工具位于`work/astar-missing-diagnostics`；两构造的原metadata清单位于`work/astar-constructors`。这些工具不会运行恢复程序集的方法或启动Unity。
