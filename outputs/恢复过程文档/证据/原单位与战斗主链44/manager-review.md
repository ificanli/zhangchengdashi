# BattleGameManager 独立复核记录

本次作为 44 号内部独立复核，只读检查父代理的 `candidate/Assets/Scripts/Assembly-CSharp/GameModule/BattleGameManager.cs`、`prepare_manager.py`、34 方法清单，以及专属 IDA `.annotated.txt`/ASM、`extra-native.json` 和原初始化器证据。未修改候选、共享工程、数据库或其他代理文件。下面结论区分原生证据核实与适配执行验证；没有启动 Unity。

## 发现与修正

1. **Countdown 随机区间（已解决，最终脚本与候选均已读回）**：原 `0x3DEA6D0` 为 `MOV W1,#0x65`，即 101；`0x3DEA6D4` 为 W0=0，`0x3DEA6DC` 调用 Random.Range。原区间为 `Range(0,101)`，随后 `CMP W0,#79 / B.GT`，触发门是 <=79。初始候选写为 `Range(0,100)`，改变抽样分布。已读回生成脚本及候选均为 `Range(0,101)<=79`；父代理实际提取夹具已捕获参数。
2. **Countdown 暂停恢复的状态门（已读回修正）**：原 state=1 恢复于 `0x3DEA770`，直接进入 `0x3DEA77C get_IsGamePaused`，不会重新读取 `_timeLeft` 的外层门。初始候选 `if(paused){yield;continue;}` 在恢复后先回外层时间判断，暂停期间若 `_timeLeft` 被外部置零会提前结束。已读回父代理改成外层内的 `while(IsGamePaused) yield return ...`，与原门控相符。
3. **已销毁 AniInstancing 的分支归属（已解决，最终脚本与候选均已读回）**：原 `ApplyAnimationPauseToSingleRole` 先执行纯托管类型检查，符合 AniInstancing 类型和 driver/组件条件后进入该分支；随后 `0x3DE5CD8` 才用 Unity `op_Inequality` 检查对象存活。Unity 对象已销毁时直接保存空的恢复标记，仍不会改走 GPU fallback。初始候选把 `instancing != null` 的 Unity 存活判断放在最外层条件，会错误进入 GPU fallback。已读回候选及生成脚本均以 `animation is AnimationInstancing.AnimationInstancing` 做外层类型门，内层再检查 `instancing != null`。

曾基于伪 C 的 `<=` 打印推测 Countdown 外层 NaN 行为不同；随后直接核对 ASM，`0x3DEA764` 明确为 B.GT，已即时撤回该建议。**外层 `while(_timeLeft > 0f)` 正确，应保留。** 这是本轮坚持 ASM 核实而未采纳伪 C 推测的记录，不计为候选缺陷。

## 重点原生证据

### GetTimeCutDownString 的两次 Format

直接以原 `script.json` 方法表解析到：

- `0x750AA4C` = `System.String.Format(string, object, object)`，签名接收两个装箱 int。
- `0x750AAD4` = `System.String.Format(string, object[])`，第二参数来自真实 `Array.Empty<object>()`。

原调用点分别为 `0x3DE6008` 与 `0x3DE6070`。候选 `string.Format(string.Format(format,minutes,seconds),Array.Empty<object>())` 正确保留原两次调用。三个原字符串分别为 `{0}:{1}0`、`{0}:0{1}`、`{0}:{1}`，按 seconds==0、seconds<=9、其他分支选择。分钟/秒均先 float32 除法或 fmodf，再 FloorToInt；候选没有替换成 int 截断。

### GameEnd 的 out 参数与异步次序

`0x3DEAC34` 加载原 HexDescribesPanel 路径，`0x3DEAC38` 明确 X2 指向栈上 out 槽，X3=0，随后调用 `UIManager.IsPanelShowing`。返回为真时重新取得 UIManager，用相同路径调用 HidePanel，out 值后续不使用。因此 `out _` 正确，不能省略 out 参数，也不能把它当成 bool 输入。

WeeklyCard 胜利任务仅在 isVictory 为真且 IsBTest 为真时触发，任务枚举原装箱值=1，现 `WeekLyTaskType.GameWin` 也是 1。其后依次为写 isVictory、可选 DoAni、Gaming=false、GameEnd 事件、isCountDowning=false、停止原协程、ForceCloseTutorial、关闭原面板、可选 2.3 秒等待、SettlementAnimation。候选次序一致。原 `WaitForSeconds` 的 ignoreTimeScale=false、PlayerLoopTiming.Update=8、默认 token/立即取消参数与候选默认值相符。

### Update 的 NaN 与有符号零

原 `0x3DE5128 FCMP S8,#0 / 0x3DE512C B.LE` 在 hornTime<=0 或 unordered(NaN) 时退出。因此候选 `isCountDowning && hornIng && hornTime>0f` 正确：NaN、±0、负数均不会调用 Time.deltaTime；正有限值或 +Infinity 才执行 FSUB。没有新增边界偏差。复核者另从原 ELF 独立执行 40 组 Update 原 ARM64 输入（两 bool 的四种组合×正负零、正负有限值、qNaN/sNaN、正负无穷、最小非正规值、floatMax），仅 Time.get_deltaTime 使用 0.5f hook；调用次数及逐位输出存于 `manager-review-validation/update-native.json`，NaN 未调用 deltaTime，原 NaN payload 保持。

### ChangeCoin 的整数与调用顺序

原从输入到累计、余额截断都使用 W 寄存器。`NEG/CNEG` 对 int.MinValue 回绕，不能替换成会抛异常的 `Math.Abs`；候选 unchecked 条件取负正确。余额不足限制采用 signed CMP + CSNEG。最后先 int32 ADD 回绕，再 CSEL 上界 10,000,000，再 BIC 清除负数，与 `Mathf.Clamp(unchecked(hasCoin+coinNum),0,10000000)` 等价。此方法无浮点数，NaN 不适用。

原先发 PlayerGameCostCoin（按请求数，未截断），回读事件后的 hasCoin，再限制实际花费并累计；然后按 CoinChangeUpdateGamePanel→PlayerCoinChange→SubGameBuffManager.OnCoinChanged(false,hasCoin) 次序调用。零增量仍发送后两事件和 buff。候选保留了这些次序，原 9 组整数极值/回绕案例已由父代理执行对照，复核未发现差异。

### 构造初值

原 `0x3DE99CC` 构造在基构造前创建暂停字典，写入 hornTime=5f、timeString="3:00"、PropBTestChargeTime=[30,90,210]、perfPanelScale=1f。数组原元数据字节 `1e0000005a000000d2000000` 的 SHA256 对应原 `<PrivateImplementationDetails>` 字段哈希。候选五个字段初始化器正确；初值都在基构造前完成。

## 34 方法逐项核对摘要

| RVA | 方法 | 复核结果 |
|---|---|---|
| 0x3DE3A9C | 已用时 getter | countDownTime 先 SCVTF，再减 _timeLeft；一致 |
| 0x3DE3AAC | IsGamePaused getter | 显式暂停短路；否则原 Tutorial 单例 tutorialing；一致 |
| 0x3DE3B48 | BetReward getter | 原字段返回；一致 |
| 0x3DE3B50 | Init | 先 await FloatingText.Init，再按原顺序注册 13 监听，再构造 4 字典；一致 |
| 0x3DE3BDC | BetRecordRewardNum | 原对象虚调用 ToString，null 仍抛；一致 |
| 0x3DE3C0C | RecordCardCount | ContainsKey→get+unchecked1→set，否则 Add1；一致 |
| 0x3DE3CEC | GuidOneEndAddCoin | ChangeCoin(200)；一致 |
| 0x3DE3F10 | RecordCoinCount | W ADD 累计；unchecked 一致 |
| 0x3DE3F20 | PlayerHornEmitIng | hornIng=true；一致 |
| 0x3DE3F2C | PlayerHornEmitEnd | hornIng=false；一致 |
| 0x3DE3F34 | GameEndCheck | 玩家建筑为零短路，否则查敌方；任一零则 GameEnd(playerCount!=0,false)；一致 |
| 0x3DE4088 | CloseMatchPanel | canCutDown=true；一致 |
| 0x3DE3FD8 | GameEnd | 比对原 MoveNext/out 参数/2.3 秒等待/结算顺序；一致 |
| 0x3DE50F8 | PlayerOpenHexCountAdd | W ADD1；unchecked 一致 |
| 0x3DE5108 | Update | 两 bool 门和 hornTime FCMP/B.LE，NaN/零一致 |
| 0x3DE3CF4 | ChangeCoin | 请求事件→实际截断→累计→Clamp→两事件→buff；一致 |
| 0x3DE514C | CoinChangeUpdateGamePanel | 原 object[2] 的 coin/timeString 次序；一致 |
| 0x3DE5278 | Countdown | 随机区间与暂停恢复两项见修正记录；其他更新时间、等待、减一、触发次序一致 |
| 0x3DE5300 | SetGamePaused | 相同显式字段直接返回；否则写字段再遍历角色；一致 |
| 0x3DE5424 | OnPauseGame | SetGamePaused(true)；一致 |
| 0x3DE5444 | OnResumeGame | SetGamePaused(false)；一致 |
| 0x3DE531C | ApplyAnimationPauseToAllRoles | 原 Unity-null Scene 守卫、先玩家后敌方、恢复后清快照；一致 |
| 0x3DE545C | ApplyAnimationPauseToRoleList | null/空列表守卫，从 Count-1 到 0，Unity-null 角色跳过；一致 |
| 0x3DE5D94 | TryApplyPauseToNewRole | getter包含Tutorial暂停，Unity-null守卫；一致 |
| 0x3DE5540 | ApplyAnimationPauseToSingleRole | 已销毁AniInstancing的类型门偏差见修正；Animator保存恢复、已有快照不重入、GPU速度与快照删除一致 |
| 0x3DE5E20 | GetTimeCutDownString | 原两个 Format overload、三格式字符串、floor/remainder；一致 |
| 0x3DE6088 | RecordDamage | ContainsKey→unchecked累计或Add；一致 |
| 0x3DE6178 | RecordBuildDamage | 同上，tower字典；一致 |
| 0x3DE65C8 | AddDeadUnit | 已有id不替换；否则Add；一致 |
| 0x3DE666C | RemoveDeadUnit | ContainsKey才Remove；一致 |
| 0x3DE66FC | CountDownEnd | 先Stop，timeScale守卫、先地块再兵数、平局+10重启；一致 |
| 0x3DE6788 | BeginStartCountDown | isCountDowning前后双守卫、等待canCutDown、Unity对象存活、先Stop再Start；一致 |
| 0x3DE6814 | StartGame | 原arena默认1001、buff修改倒数、先UI再初始金币、两回调及字典次序；一致 |
| 0x3DE6DAC | EndGame | 先FPS/回调，再清状态/停止/字典，hornTime恢复5f，canCutDown=false；一致 |

StartGame 的 UI 更新原本发生在新初始金币赋值前，候选按原保留，复核不建议“顺手纠正”。EndGame 没有主动调用 ApplyAnimationPauseToAllRoles(false)，候选也没有增加这项行为。BeginStartCountDown 原 outlined `0x856DFA0` 是 await GetResult 分派岛，已通过 `extra-native.json` 证明回到 `0x3DEA01C`；候选 await 保留这条行为，不将 JUMPOUT 当成缺失业务。

本复核未对 SDK、Unity 物体销毁状态、GPU API、协程调度或动画运行做真实 Unity 验收。父代理已在实际候选重提取 29 正文后执行 120 场景、333 检查、0 失败，包含暂停/GPU 分支适配与随机参数捕获。已只读核实 `compile/result.json`：四候选使用原 rsp 独立 csc，exit=0、errors=[]、DLL 实际存在、7798 项保留工程警告。没有发现需要另写战斗系统的缺口；本记录只评价当前 34 个恢复候选与原证据的对应。

最终读回结论：三项发现均已在生成脚本及候选中解决，当前34方法范围未发现其他未解决的重大语义偏差。复核候选 SHA256：`13228c84736658776651f1bbd6cb3093e4e9f8be4f670320b32a398c8a38bba8`。复核没有改动候选源码。
