# 30｜Burst布尔互操作布局修复

第十三轮导入已经越过C#编译，实际脚本加载期出现Burst BC1063。故障来自两个按ref传入函数指针的结构体中的bool字段，属于当前Editor/Burst的互操作布局检查；不能用“C#编译通过”宣称该层已通过。

本阶段仅在2个原文件的3个bool字段上增加MarshalAs(UnmanagedType.U1)。**这是保留原一字节native布局的Editor/Burst ABI兼容适配，原MarshalInfo并未恢复：原DummyDll明确没有这些MarshalInfo标记。算法实现恢复计数为0。**

没有关闭Burst、排除Astar或移除寻路系统，没有改变业务body、字段类型、函数参数或ref传递方式。独立csc成功，实际输出DLL已读回3项NativeType.U1；正式Unity/Burst重新编译及运行结果仍由主流程下一轮验证。

## 1. 从有界真实日志定位故障

import13日志当时为510,492,328字节，后段因另一资源导入错误重复刷屏。主流程已停止对应Unity进程21760；本子任务没有启动Unity，也没有用Get-Content -Tail读取该大日志。

本轮先读主流程已保存的有界摘要，再用Python执行固定seek/read：从偏移0最多读取8,526,038字节，止于首个资源重复错误前的位置。该范围内完整提取到4条BC1063，原字节偏移与文本保存在交付证据中。

其中两条指向JobRepairPathHelpers.PathTracerInfo.isStale，分别来自原UpdateReachedEndInfo和导出BurstManaged伴生方法经当前ILPP生成的DirectCall.Invoke；另外两条指向TileHandler.CutCollection.cuttingRequired，来自两个CutTiles桥接入口。四条均明确说明：ref结构体进入calli函数指针签名时，未声明互操作布局的bool不被视为blittable，并建议字段级MarshalAs(U1)。

资源ReadObjectThreaded故障由主流程另行处理，与本次BC1063不是同一个根因。本报告不将大日志后段的刷屏内容当作Burst诊断数量，也不扩展修改资源资产。

## 2. 原metadata和实际导入DLL的证据

独立Mono.Cecil分别读取原DummyDll/AstarPathfindingProject.dll与import13实际Library/ScriptAssemblies/AstarPathfindingProject.dll，不执行其中方法。核实如下：

| 原类型/字段 | 原TypeToken | 原FieldToken | 原native偏移 | 原/导入13 MarshalInfo |
| --- | --- | --- | --- | --- |
| PathTracerInfo.isStale | 0x0200034B | 0x04000EA1 | 0x10 | 均没有 |
| PathTracerInfo.hasValidEndPoint | 0x0200034B | 0x04000EA2 | 0x11 | 均没有 |
| CutCollection.cuttingRequired | 0x020001C9 | 0x04000896 | 0x60 | 均没有 |

PathTracerInfo的两个bool紧邻偏移0x10与0x11，直接证明原native按一字节存储；原il2cpp.h也把两个字段声明为bool。isStale是编译器遇到的首个失败字段，同一个ref结构体中紧随其后的hasValidEndPoint具有相同布局要求，因此两者一并做字段级适配。

CutCollection前四个字段为UnsafeList结构，原偏移分别为0x0、0x18、0x30、0x48，cuttingRequired位于0x60。原il2cpp.h明确将其声明为bool，原类型与字段身份和当前源码一致。这里只处理已经由实际BC1063点名的CutCollection；没有对其他ContourMeta或全Astar的bool字段批量加属性。

原FieldOffset来自Il2CppDummyDll的说明属性，不是CLR的显式布局指令。当前源码仍保留这些原偏移证据，不通过更改原字段类型为byte、强制StructLayout或重写参数绕过检查。

## 3. 为什么是当前函数指针边界触发

官方Burst1.8.21的ILPostProcessing会把Burst方法参数直接复制到生成delegate与DirectCall.Invoke，再创建CallingConvention.C的CallSite，发出calli指令。此处原签名包含`ref PathTracerInfo`或`ref CutCollection`，所以Burst需要检查整个结构体的interop可传递性。

实际import13 DLL中确实存在4个带这两个ref参数的calli；故障不是只存在于导出伪代码或旧生成源中的猜测。官方DiagnosticId将BC1063定义为ERR_TypeNotBlittableForFunctionPointer，函数指针文档也明确参数/返回值受DllImport及internal-call的同类限制。

普通C# bool可在托管代码和Burst内部运算中使用，不代表它自动具有函数指针边界要求的未托管布尔布局。新增U1明确采用一字节无符号布尔表示，与本包原native字段的一字节布局一致。

原DummyDll没有MarshalInfo，无法把本轮新增属性称为“找回原MarshalAs源码”。本轮的依据是：真实BC1063、官方当前Burst生成机制、原字段身份与原native一字节布局。这是兼容适配层，计0算法恢复。

## 4. 最小修改及边界

仅修改：

- Pathfinding/ECS/JobRepairPathHelpers.cs：isStale、hasValidEndPoint。
- Pathfinding/Graphs/Navmesh/TileHandler.cs：CutCollection.cuttingRequired。

每项新增：

```csharp
[global::System.Runtime.InteropServices.MarshalAs(
    global::System.Runtime.InteropServices.UnmanagedType.U1)]
```

使用完整限定名避免与原Il2CppDummyDll.FieldOffset或其他命名空间产生导入歧义。原bool类型、字段/类型Token、Il2CppDummyDll.FieldOffset、全部函数签名和body保留；原meta/GUID哈希不变。

修改前完整文件备份位于项目外`work/recovery-stubs/burst-bool-abi-before`。没有移除BurstCompile、改指针签名、关闭DirectCall或修改原寻路计算方法。

## 5. 已完成验证与尚未完成的验收

独立Roslyn读回确认两个实际文件只有3个attribute list新增；移除这3个新增属性后，语法树与备份等价。43个body块文本逐字不变，meta哈希与备份记录一致。

再次使用Unity自带csc和Astar原rsp，保留全部引用、define、analyzer/source generator，输出仅至`work/burst-bool-abi`，结果为**exitCode=0、errors=0**。随后用独立Cecil读取实际输出DLL，3个目标字段均具有`MarshalInfo.NativeType=U1`，字段类型仍为System.Boolean，原Field/Type Token及偏移证据保持。

本子任务没有运行Unity后处理后的新DLL，没有启动官方Burst重新编译，因而当前状态应记为：

| 验证层 | 状态 |
| --- | --- |
| 原字段身份、偏移与原无MarshalInfo事实 | 已核实 |
| import13实际calli与4条BC1063 | 已核实 |
| 最小源码差异、43body不变、meta/GUID | 已核实 |
| 独立完整Astar C#编译 | 已通过，exitCode=0 |
| 实际输出DLL的3项U1 metadata | 已通过 |
| 下一轮Unity ILPP及官方Burst重新编译 | 待主流程验证 |
| 寻路/RVO/原核心玩法运行 | 本阶段未验收 |

源码已向主流程发出稳定点，之后冻结这两个工程文件，仅整理本报告与证据。即使下一轮BC1063消失，也仍需将其与原寻路方法body恢复和运行效果分开记录。

## 6. 交付证据

- [固定范围日志读取与4条原BC1063](证据/Burst布尔互操作/bounded-bc1063-log.json)
- [原DummyDll与import13实际DLL布局/MarshalInfo/calli](证据/Burst布尔互操作/original-and-import13-layout.json)
- [两文件三字段实际修改与哈希](证据/Burst布尔互操作/applied.json)
- [独立源码及实际U1 metadata读回](证据/Burst布尔互操作/independent-verification.json)
- [独立csc结果](证据/Burst布尔互操作/u1-adapter-errors.json)
- [实际编译日志](证据/Burst布尔互操作/u1-adapter.log)
- [原native布局摘录](证据/Burst布尔互操作/original-native-layout-excerpts.h)
- [官方Burst生成器及文档依据](证据/Burst布尔互操作/official-evidence.json)
- [完整交付哈希清单](证据/Burst布尔互操作/evidence-manifest.json)

证据中同时保存两个文件适配前/后副本及原meta。检查、修复与核验工具位于`work/burst-bool-abi`，没有调用恢复程序集的业务方法。
