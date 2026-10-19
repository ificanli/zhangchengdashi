# 16：PlayMode观察与验收工具准备

当前状态：**观察工具已在真实Unity场景执行四轮；最新增加已创建模块的只读观测，核心玩法未验收。**

## 目的与边界

后续恢复要从真实Unity生命周期里发现下一处未恢复调用。工具打开指定原场景，正常进入PlayMode，记录首个错误、已加载场景、帧数、时间与场景内管理器的原始字段。它不手工调用业务初始化，不设置登录成功、资源完成、数据完成等gate，也不创建替代地图或战斗逻辑。

入口为[ObserveRecoveryPlayMode.cs](../OccupyCityRecovered/Assets/RecoveryTools/Editor/ObserveRecoveryPlayMode.cs)，位于独立Recovery Editor程序集。对业务状态只读取字段，避免反射调用属性getter或单例访问器产生额外行为。

## 为什么需要跨domain reload保存观察

Unity正常进入PlayMode时会重载脚本域，普通Editor静态变量和回调可能丢失。工具把报告路径写入SessionState，使用InitializeOnLoad在重载后恢复观察和回调；不关闭domain reload，不改变原启动条件。正常退出PlayMode后清理会话标记。

每2秒取一次快照，遇到Error/Exception/Assert则保存原始位置后结束观察；进入PlayMode超过90秒也会记为超时。日志和快照写入work/recovery-ledger，后续生成正式运行报告时再筛选。

## 结果不能自动代表核心玩法通过

观察期无错误仅记录`observation_completed_core_gameplay_not_accepted`。`coreGameplayAccepted`始终为false。后续还必须检查原地图出现、真实开格/占领、单位生成、战斗和相应状态变化。

使用-nographics的批处理可验证生命周期/异常和加载状态，画面、输入及核心交互仍需要图形编辑器下的实际验证。第10篇留给该阶段的真实结果。

## 复现方式

从独立恢复工程启动，executeMethod为`OccupyCity.Recovery.Editor.ObserveRecoveryPlayMode.Run`。不要加-quit，工具将在退出PlayMode后结束批处理。

```powershell
$unity = 'C:\Program Files\Unity\Hub\Editor\2022.3.62f3c1\Editor\Unity.exe'
$project = 'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\outputs\OccupyCityRecovered'
Start-Process -FilePath $unity -ArgumentList @(
  '-batchmode', '-nographics', '-projectPath', ('"' + $project + '"'),
  '-executeMethod', 'OccupyCity.Recovery.Editor.ObserveRecoveryPlayMode.Run',
  '-recoveryScene', 'Assets/gameres/bundleres/Scene/MineGameMain.unity',
  '-recoveryPlaySeconds', '30'
) -Environment @{ ALLUSERSPROFILE = 'C:\ProgramData' } -WindowStyle Hidden
```

场景默认值为原MineGameMain；后续可按取证计划单独观察原Game场景并明确记录入口差异。报告路径限制在任务work/recovery-ledger内。

## 当前验证证据与一次失败

第一次准备独立csc响应文件时，执行工作目录设成了工程目录，脚本用cwd误找任务work目录，准备步骤失败。随后改为显式绝对workspace路径，复用已核实的Unity实际DLL引用和C#9编译选项；源码编译退出0、0错误、0警告，检查DLL仅保存在work目录。

源码SHA、编译配置和失败原因见[compile-result.json](证据/运行观察工具/compile-result.json)。该结果仅证明工具的编译，不证明它已经在Unity里执行。


## 第四轮补充：观察已经创建的纯C#模块

普通MonoBehaviour列表无法显示GameFrameEntry内部的纯C#版本模块。第四轮依据入口实际类型所在程序集，读取已经初始化的BCL LinkedList及模块自身和基类字段。原ready字段、资源引用是否存在、callback的Method描述均可记录，业务getter、单例访问器、GetModule和回调均不执行。对象引用只记录运行时类型，避免调用未知对象ToString；最多64模块，每层字段最多80项，观测异常只记诊断文本。

实际运行确认该工具记录到了VersionMondule的false完成状态和已保存的原回调，并未制造后继模块。进程19020退出0、15次快照、错误0。证据见[第10篇](10-Unity运行验收.md)及[完整模块观察](证据/运行验收/unity-play-main4.json)。早期独立编译验证仍保留，不能用它替代本次Unity实际执行证据。
