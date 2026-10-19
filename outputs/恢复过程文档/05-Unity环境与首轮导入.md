# 05：Unity环境排障与恢复工程首轮导入

## 先隔离环境问题

原包资源版本为2022.3.62f3，本机可用编辑器为2022.3.62f3c1。先在work/unity-runtime-probe创建空工程，目的是验证编辑器本身能正常启动、处理包和导入；不是原游戏运行验收。

第一次createProject与第二次projectPath均在Package Manager阶段退出：

```text
The "path" argument must be of type string. Received undefined
Failed to resolve packages ... No packages loaded.
```

空工程也失败，说明不能先归因于恢复资源或游戏脚本。

## 根因定位

1. 检查Editor.log和upm.log，确认UPM已连接IPC，但处理resolve-packages立即失败。
2. 读取本机UPM的JavaScript实现，找到全局配置路径构造。
3. 在单独的诊断UPM进程中对Node路径函数增加只记录参数类型和异常栈的包装，不修改安装目录文件。
4. 错误栈指向`getGlobalConfigRoot/getDeprecatedGlobalConfigRoot`。
5. 对应实现为`path.join(process.env.ALLUSERSPROFILE, "Unity/config")`。
6. 当前执行环境中`ALLUSERSPROFILE`为空，`ProgramData`正常为`C:\ProgramData`。

所以问题不是manifest里的包版本，而是启动环境缺少Windows标准变量。

## 最小修复与验证

仅给本次Unity子进程补变量，不修改系统或用户持久环境：

```powershell
$unity = 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Unity.exe'
$project = 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\unity-runtime-probe'
$log = 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\recovery-ledger\unity-env-fixed.log'
Start-Process -FilePath $unity -ArgumentList @(
  '-batchmode', '-nographics', '-quit',
  '-projectPath', ('"' + $project + '"'),
  '-logFile', ('"' + $log + '"')
) -Environment @{ ALLUSERSPROFILE = 'C:\ProgramData' } -WindowStyle Hidden
```

这里`-Environment`需要本机使用的PowerShell7能力。若用其他shell，应使用其子进程环境参数，不应覆盖HOME或CODEx配置目录。

修复后日志出现`Exiting batchmode successfully now!`，最终return code 0。AssetDatabase初始刷新完成。诊断UPM进程随后关闭。

## 恢复工程第一次导入

工程：`outputs/OccupyCityRecovered`，使用相同子进程环境。Unity成功进入导入和脚本编译阶段，随后退出1，明确报：

```text
One or more cyclic dependencies detected between assemblies
Scripts have compiler errors.
```

导出asmdef将运行时类型和泛型展开的依赖带回工程，多个Unity库、第三方库与游戏程序集形成循环。此时应恢复真实依赖和程序集边界，不应删掉所有业务脚本、把空方法当成实现，或只隐藏错误日志。

第06篇记录实际依赖替换和GUID迁移。首次导入失败是基线证据，不代表Unity环境仍然不可用；两层错误已经区分。

## 第二次导入：进入具体C#错误

首批真实Unity包、UniTask和Newtonsoft替换并完成GUID迁移后，再次执行Unity导入。包注册成功，原来的程序集循环依赖已消除，编译程序能生成任务图。编译继续执行后，去重得到500条C#错误，主要集中在仍为空壳的第三方库：MeshBakerCore126、GPUInstancer85、PolyFew扩展版MeshSimplifier81、LitJson64、MemoryPack22等。

这些错误多为显式接口或迭代器状态机的声明信息丢失，不能靠补空接口方法来代表真实运行库恢复。目前按官方来源、版本和API兼容性逐批替换。恢复工程第二次导入仍退出1，尚未达到编译或运行验收。

## 验收边界

- 空工程启动与导入：已通过。
- 恢复工程脚本编译：当前尚未通过。
- 原场景PlayMode与核心玩法：尚未运行。
- Unity与原包版本后缀不同的兼容性：尚需真实工程验证。

## 第三、四轮：错误数量与编译层级

第三轮导入在真实LitJson、MemoryPack和Spine替换后有400条去重错误；第四轮在更多上游库恢复后有603条，其中GFRunning435条、MeshBakerCore106条、RuntimeInspector21条、PolyFew17条，其余24条。两轮均退出1。

错误总数不能直接当作恢复百分比。上游程序集修好后，Unity才会编译依赖它的下游程序集，因此会暴露此前未出现的错误。第四轮的GFRunning声明错误就是新进入的层级。同时，前轮已确认的真实PolyFew构造字段赋值错误消失。

下一轮将验证显式接口、状态机声明、官方DOTween模块，以及编译期生成物的处理。错误原文和程序集分组已筛选存入[第三轮统计](证据/声明与构造/import3-error-summary.json)及[第四轮统计](证据/声明与构造/import4-error-summary.json)，不复制含授权信息的整份Editor日志。

## 第五、六轮：声明错误消失后继续展开正文检查

两轮均正常进入Unity脚本编译，随后因尚未恢复的代码退出1；没有进入PlayMode。

| 导入轮次 | 去重错误 | 关键变化 |
|---|---:|---|
| 第四轮 | 603 | GFRunning435，仍含大量接口和状态机声明错误 |
| 第五轮 | 321 | GFRunning降到15，Clipper/Drawing/BurstTriangulator进入更深正文检查 |
| 第六轮 | 182 | 上一轮所有接口/override问题消失；GFRunning新暴露179项正文或基构造错误，另Drawing2、Crowd1 |

第六轮182项按编译代码分为：CS0177（out未赋值）98、CS7036（缺基构造实参）39、CS0171（结构体字段未赋值）22、CS0037（空桩返回null不合法）18、CS1729（不存在无参构造）5。

这些数字描述本轮编译器已执行到的层级，不代表剩余所有问题；Assembly-CSharp仍可能在上游程序集通过后继续暴露新错误。不能从182条推断已经接近整游戏完成。

报告11/12/14分别记录声明、编译生成物和框架元数据修正。每轮只用一个Unity进程，源码拥有者释放后冻结Assets/Packages/ProjectSettings再导入。所有Unity进程继续只在子进程环境补ALLUSERSPROFILE，不改系统环境。

证据：[第五轮](证据/声明与构造/import5-error-summary.json)、[第六轮](证据/声明与构造/import6-error-summary.json)。真实场景及核心玩法仍未验收。


## 第七至十三轮：业务编译层与首次完整资产导入

| 轮次 | 去重C#错误 | 实际展开的层级 |
|---|---:|---|
| 7 | 8 | Debug/GFHanldMono/PackageTools的显式接口 |
| 8 | 30 | 调试工具构造链及少量空桩 |
| 9 | 306 | Astar首次进入编译 |
| 10 | 1 | firstpass的旧生成TypeRegistry |
| 11 | 18 | 主程序集枚举默认参数和旧生成类 |
| 12 | 440 | 主程序集out/结构体空桩及75构造链 |
| 13 | 0已记录 | 已进入正式资产导入，但Burst与原生资源错误阻止成功退出 |

第13轮不能写成工程通过：有4条Burst BC1063布尔互操作布局错误，随后一个持久ScriptableObject指向场景组件触发原生导入循环，任务进程被终止。第30、31篇分别处理两种故障。主程序集226个显式缺失诊断、67个本地转发构造、8个部分构造由第27篇单列，不能因编译推进而算作玩法恢复。

主程序集16个枚举默认值按原DummyDLL参数Token、枚举类型及常量恢复正确cast，全部body/meta不变；firstpass与main的旧TypeRegistry/JobReflection生成源按真实Entities/Collections ILPP归档，完整保留原件与零序列化引用证据。

## 第14轮：正式完整导入通过

Unity正常退出return code0。逐字检查当前日志：C#诊断0、Burst错误0、ReadObjectThreaded错误0；日志不再无限增长。图形/玩法仍未验收。此后正式执行了Addressables类型与Locator验证、真实GlobalInfo消费、首次原MineGameMain Play观察，结果分别见第36/28/10篇；运行观察已经暴露更下游的真实缺失，不能把本次导入成功扩大为游戏恢复完成。
