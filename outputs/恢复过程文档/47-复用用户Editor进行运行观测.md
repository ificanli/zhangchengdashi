# 47：复用用户已经打开的Unity Editor

当前状态：**已在用户的图形Editor实际执行只读状态快照，项目、场景和进程身份确认正确；后续原场景PlayMode仍须单独记录结果。**

## 为什么改变运行方式

前四轮原Main观察使用独立batchmode/nographics Unity进程。用户随后从Hub打开恢复工程，图形Editor进程为3808，原Game.unity处于编辑模式。Unity对同一工程有独占限制，因此不能继续另开该工程的批处理，也不能关闭用户正在查看的窗口。

本阶段在原独立Recovery Editor程序集内增加窄命令桥。协调脚本只把请求写入本任务work/recovery-ledger/editor-command.json。桥提供固定的Snapshot、独立资源验证和原Main观察动作；原Main另有用户明确授权后才使用的丢弃未保存修改变体，不执行任意方法名或shell命令。请求使用独立GUID，SessionState记录已处理ID，跨正常domain reload仍只执行一次。

## 观察与保存边界

Snapshot只读取Unity进程ID、工程路径、活动场景、Unity版本及Play状态，不读取启动参数或账号信息，不调用任何游戏方法。

ObserveOriginalMain复用既有ObserveRecoveryPlayMode，正常打开原MineGameMain并进入PlayMode，继续按原每2秒字段快照、错误即停和时长结束规则执行。它使用RunConfigured独立入口，参数less Run仍保留供Unity executeMethod，避免重载名称使原批处理反射查找产生歧义。报告路径限制在本任务ledger，时长仅接受10至180秒的有限数。

用户已经在Play或准备进入Play时，命令等待，不接管用户的Play会话。默认有任一已打开场景存在未保存修改时，观察拒绝启动并写明原因，不自动保存或丢弃用户编辑。用户随后明确要求“直接切，不保存”，才新增固定的ObserveOriginalMainDiscardUnsaved命令并记录authorizedDiscard=true；普通观察仍保持保护。正常结束观察只退出Play，保持图形Editor打开。没有设置任何游戏完成门。

## 已取得的真实证据

实际Snapshot回执状态completed、进程3808、工程路径为本任务OccupyCityRecovered、版本2022.3.62f3c1、batchMode=false、playing=false、活动场景为Assets/_Scene/Game.unity。它证实新源码已被正在使用的Editor导入并执行；同时有界Editor日志未发现当前C#/Burst编译错误。

这不是地图或UI视觉验收。静态Game场景已经打开，也不意味着原初始化和玩法运行完成；本轮尚未执行ObserveOriginalMain。后续每次真实观察结果继续追加到第10篇，不能把Snapshot或已有独立编译结果代替PlayMode证据。

证据：[实际Editor回执](证据/交互式Editor观测/actual-editor-snapshot.json)、[命令桥源码](证据/交互式Editor观测/RecoveryEditorCommands.cs.txt)、[共用观察器源码](证据/交互式Editor观测/ObserveRecoveryPlayMode.cs.txt)、[源码SHA](证据/交互式Editor观测/source-hashes.json)。


## 后续实际运行与刷新

第五轮原Main已经在用户明确授权丢弃未保存修改后执行，frame1因真实CoreBlit渲染错误退出，详情见第10篇。命令桥另增加固定的独立资源Probe入口；Probe2使用私有资源provider，17秒完成实际34载荷、50旧TextAsset和5142官方定位检查，未改场景和原共享provider状态。该结果追加在第39篇，不冒充启动链通过。

Windows Computer Use用于选择唯一的OccupyCityRecovered Unity窗口、读取新UIA状态并执行Ctrl+R刷新。初次截图/窗口观察曾返回FrameArrived超时或窗口最小化，均重新观测后再操作；没有使用旧坐标，也没有通过截图结果宣称游戏画面通过。最终UIA确认原MineGameMain与GameView，程序集更新时间和实际Probe回执确认刷新已生效。
