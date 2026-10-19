from pathlib import Path
import json,hashlib
from restore_role import ROOT,WORK,DEST
own=WORK/'role-validation';audit=json.loads((own/'final-audit.json').read_text(encoding='utf-8'));prov=json.loads((own/'restored-methods.json').read_text(encoding='utf-8'));compile=json.loads((own/'compile-final/result.json').read_text(encoding='utf-8'))
missing=[{'method':n,'rva':r,'state':'original_placeholder_retained'} for n,r in [('Awake','0x3D7F7E0'),('Init','0x3D7FF14'),('InitAnimationAsync / MoveNext','0x3D816E8 / 0x3D92288'),('FindTarget','0x3D818CC'),('MyUpdate','0x3D853A0'),('Move','0x3D85A88'),('Atk / MoveNext','0x3D87FB0 / 0x3D8F208'),('AtkCallBack','0x3D88050'),('MeleeAtkCallBackLogic / MoveNext','0x3D79130 / 0x3D924DC'),('RemoteAtkCallBackLogic','0x3D8C544'),('UpdateHpBar','0x3D8BF30'),('HellFireDeadCallBack / MoveNext','0x3D87E38 / 0x3D91B54')]]
py=r'C:\Users\luxinyu\AppData\Local\Programs\idapromcp\source\.venv\Scripts\python.exe'
commands=[{'command':f'& "{py}" -X utf8 "{own / script}"','result':result} for script,result in [('native_oracle.py','17 methods / 2040 ARM64 cases'),('wound_oracle.py','240 ARM64 Wound scenarios'),('death_oracle.py','64 ARM64 Dead scenarios / 96 phases'),('build_probe.py','32 exact method bodies extracted'),('build_wound_probe.py','exact Wound body extracted'),('build_death_probe.py','exact original Dead wrapper, MoveNext, SetStateMachine extracted'),('audit.py','7 preservation checks passed'),('compile_final.py','Unity original rsp / exit0 / errors0 / warnings7790')]]
for project,oracle,checks,basefails in [('RoleProbe.csproj','native-oracle.json',2061,1470),('WoundProbe.csproj','wound-native-oracle.json',1200,631),('DeathProbe.csproj','death-native-oracle.json',384,312)]:commands.append({'command':f'dotnet run --project "{own/project}" -- "{own/oracle}"','result':f'{checks} checks / 0 failures; original-placeholder negative control {basefails} failures'})
handoff={'state':'ready_for_integration','role':'RoleBehaviour original-unit and damage/death candidate subtask','owned_files':[{'path':'Assets/Scripts/Assembly-CSharp/GameModule/RoleBehaviour.cs','source_before_sha256':audit['source_sha256'],'candidate_sha256':audit['candidate_sha256'],'candidate_path':str(DEST),'original_rva_members':183,'restored_methods':64,'preserved_nonempty_rvas':audit['preserved_nonempty']}],'changed_members':audit['restored'],'method_provenance':str(own/'restored-methods.json'),'preservation_audit':str(own/'final-audit.json'),'commands':commands,'verification':{'arm64_scalar_cases':2040,'arm64_wound_scenarios':240,'arm64_death_scenarios':64,'arm64_death_phases':96,'candidate_checks':3645,'candidate_failures':0,'negative_control_failures':2413,'unity_started':False,'unity_runtime':'not-run','compile_result':str(own/'compile-final/result.json'),'compile_exit':compile['exit_code'],'compile_errors':compile['errors'],'compile_warnings':compile['warning_count']},'main_chain_unrestored':missing,'external_dependencies':['EntityBase.MyUpdate/FindTarget original bodies remain placeholders','RolePropertyTemp constructor and GameEventArgs constructor/real TalentBase dispatch remain external recovery dependencies','Terran/Undead/Machine and concrete unit Init/AtkCallBack/Wound overrides remain original placeholders','CoreGameManager.Gaming and original startup producer must be restored by owner','HexManager.TryGetHexAt/HexBehaviour registration belong to task43; this task only restores original Role calls','FollowerEntity/AIDestinationSetter/AstarPath/WebGLNavigationManager and ECS update group must supply actual navigation execution','IAnimation implementation, GPU crowd, effects/audio/UI managers and ObjPoolManager must supply actual resource/runtime consumers','DeadCallBack/OnRecycle recovered from native evidence and compile checked, but their full original runtime dependencies not executed in Unity','Special HellFireDeadCallBack remains placeholder'],'report_draft':str(WORK/'role-report.md'),'frozen':True}
(WORK/'role-handoff.json').write_text(json.dumps(handoff,ensure_ascii=False,indent=2),encoding='utf-8')
rows='\n'.join(f"| `{x['rva']}` | `{x['token']}` | `{x['declaration'].replace('|','/').replace('`','')}` |" for x in audit['restored'])
text=f'''# 44 号 RoleBehaviour：原单位伤害、死亡与底层契约恢复

状态：**64 个原成员形成稳定候选，已冻结为可合入批次。** 本子任务仅写独立 work 候选；共享工程 RoleBehaviour、地图与派生兵种源码均未修改，未启动 Unity。

## 本批实际交付

候选：`{DEST}`。

起始 SHA256：`{audit['source_sha256']}`。

最终候选 SHA256：`{audit['candidate_sha256']}`。

183 个原带 RVA 成员、全部 Token/Address/字段/声明/属性标注保持不变。原先 3 个非空 getter `0x3D846A0`、`0x3D88158`、`0x3D88160` 的正文逐字节保留。`role-validation/final-audit.json` 的 7 项保护检查全部通过，共享源仍等于起始 SHA。

本批恢复了构造初值、AniInstancing 优先的真实动画驱动解析与缓存、角色目标保留/最近格距约束、导航速度/半径与控制门、路径刷新、当前格子登记、完整 Wound 原调用链、完整 Dead 原状态机与回调、普通回收清理/战后回收、血条移除和事件订阅解绑。没有把兵种派生类改成基类绕行，也没有用直接扣血演示替代原入口。

## 关键原理与原生对应

`Wound RVA 0x3D86A44` 保留 `CoreGameManager.Gaming`、已死、缺属性、零伤害、角色 ID 1012 施法状态等门。原 `OnHurtTalentTrigger` 先返回 `(int damage,float extraMiss)`，再执行 `Random.Range(0,101)` 闪避；减伤、Terran/Machine 羁绊、契约按剩余伤害顺序分摊之后，才写伤害文字、减 hp、血液特效和敌方承伤统计，再触发健康变化天赋，最后重新判断死亡并调用原 Dead/血条/击杀天赋或受击音效。契约转发保留全部原参数，并把 linkAttackObj 重置为 null。

原伤害转换是 `SCVTF/float32 multiply/FCVTZS`，额外把正无穷转换为 int.MinValue。候选以内联边界分支保留 NaN、超界饱和与正无穷特判，int32 减法明确 unchecked。父任务负责 SynergyEffectManager；本子任务没有触碰已验证 InternalCalculateDamage。

`Dead RVA 0x3D876CC` 使用原 `_003CDead_003Ed__190` 结构体和 AsyncVoidMethodBuilder 启动；`MoveNext RVA 0x3D90878`、`SetStateMachine RVA 0x3D914E4` 已恢复，保留原字段、Token 和状态机属性。初始阶段先停寻路、标死、移出当前格、终止 Tween、通知 HasRoleDead/子玩法/血条、计算并分配击杀币，再解绑地图事件、播放死亡动画、停移动、移出双方列表；等待 `DeadAnimationLength - 0.1f`（非正时 0.1f，Update 时序）之后才解绑影子并调用 DeadCallBack。挂起使用原 state=0/awaiter 字段，恢复清空 awaiter 并进入 state=-1，终态为 -2。

`DeadCallBack RVA 0x3D878E4` 保留传奇计数移除、OnDeadSkill 门、真实 DeadUnitInfo 入双方死亡字典、死亡特效开关、GPU crowd 原状态复位、停用与对象池回收、特殊地狱火分支及 OnRecycle。`OnRecycle RVA 0x3D8CE8C` 保留原格登记清理、动画/速度控制、HasHexOpen 解绑、冰冻/眩晕/临时特效/契约/Tween/天赋/目标/原攻击动画速度/寻路目标对象等清理顺序。地图操作只调用原 HexBehaviour API，未改地图窗口文件。

IDA 伪 C 曾省略 `RemoveRole` 的 player/role 参数及 `ModifyKillCoin` 的阵营参数，均按原 ASM 的 W2/X3 等传参校正。Dead.MoveNext 的地址区间内还出现 SubGameBuffManager 方法别名/outlined 区块；按真实 BL 及原声明保留调用，没有把同区间子函数的文本当作主函数顺序。

## 有效验证、负对照与修复

| 验证 | 实际范围 | 最终结果 | 原空壳负对照 |
| --- | --- | --- | --- |
| 原 ARM64 标量/布尔 oracle + 实际候选控制流夹具 | 17 个原方法 2040 组机器码输入，另 21 项构造/控制/格登记/目标保留调用顺序断言 | 2061 检查，0 失败 | 1470 失败 |
| 原 ARM64 Wound oracle + 实际候选重提取 | 240 场景，覆盖门、闪避、减伤/整数边界、羁绊/分摊、治疗后重新判死与调用序列 | 1200 检查，0 失败 | 631 失败 |
| 原 ARM64 Dead.MoveNext oracle + 实际候选原三正文重提取 | 64 场景、96 个初始/挂起/恢复阶段，币制/阵营/AB/难度门/float32 等待/awaiter/回调顺序 | 384 检查，0 失败 | 312 失败 |
| 原 Unity Assembly-CSharp.rsp 全引用/analyzer 独立 csc | 四个 44 号候选，含最终 Role SHA f4997760… | exit 0，errors 0，既有警告 7790 | 不适用 |
| 声明与保护审计 | 183 原成员，Token/Address/字段/属性/原 3 正文/共享源 SHA | 7 项通过 | 不适用 |

总计 **3645 项候选检查 0 失败**；原占位负对照共 **2413 项失败**。测试从候选真实文件重新提取正文，没有另写一套业务实现作为测试。外部 Unity/Manager/动画/路径 API 和虚方法通过可观察适配器记录契约；数值及主方法控制流由原 ARM64 作为独立 oracle。NaN 的位模式仅比较 NaN 分类，有限值、无穷和有符号零按原 float32 位模式比较。

最初 scalar 测试捕获 GetFollowerEntityMoveSpeed 8 个 NaN 差异：原 `FCSEL HI` 对 unordered 选择除法，伪 C 的 `>0.001` 不足，候选修正为 `!(_bornScaleX <= 0.001f)`。Wound 初版的 NaN 闪避比较也由原生对照发现，按真实分支恢复为 `dodge > roll` 才闪避。GetScaledRadius 按 FCMP+B.MI 恢复为 `!(baseRadius <0)`，保留 NaN 时仍访问 transform 的原副作用。这些修复之后重新跑完整提取验证。

最终编译日志与 SHA：`role-validation/compile-final/result.json`。全部测试 CLI 在 `role-handoff.json.commands`；负对照日志与最终日志均保存在 role-validation。Unity Editor、PlayMode、视觉、原场景地图/兵堆移动战斗验收均为 **not-run**。

## 主链完成度与后续阻塞

本批完成了原伤害/普通死亡及底层契约的候选恢复；**从生成到移动攻击的最小主链仍未闭合**。

| 原入口/阶段 | 当前候选状态 |
| --- | --- |
| 构造器 `0x3D8E1E4` | 已恢复原列表、容量、计时和 sentinel 初值 |
| Awake `0x3D7F7E0` | 原占位保留；Follower/Renderer/初始动画缓存仍未建立 |
| Init `0x3D7FF14` | 原占位保留；属性生产、战斗资源和 hadInit 门仍未闭合 |
| FindTarget `0x3D818CC` | 顶层仍占位；本批仅恢复有效性/节流/格距保留子方法 |
| MyUpdate `0x3D853A0` | 原占位保留 |
| Move `0x3D85A88` | 原占位保留，墙体/占用/卡住看门狗等尚未整体恢复 |
| Atk/MoveNext `0x3D87FB0 / 0x3D8F208` | 原占位保留；未以直接伤害替代攻击节奏 |
| Wound `0x3D86A44` | 完整正文恢复并有 240 场景原 ARM64 对照 |
| Dead/MoveNext `0x3D876CC / 0x3D90878` | 原状态机恢复并有 64 场景原 ARM64 对照 |
| DeadCallBack/OnRecycle `0x3D878E4 / 0x3D8CE8C` | 原正文恢复、独立编译通过；完整真实依赖运行未验收 |
| UpdateHpBar `0x3D8BF30` | 原占位保留；RemoveHPUI 已恢复 |
| HellFireDeadCallBack/MoveNext | 特殊分支仍占位，原调用点保留 |

RolePropertyTemp 与 GameEventArgs 的原构造/实际天赋触发、派生 Terran/Undead/Machine/具体兵种 Init/AtkCallBack/Wound、CoreGameManager.Gaming 的真实生产者、Astar/FollowerEntity/WebGLNavigationManager/ECS 更新组、GPU/动画/血条/特效/音效与对象池等必须由相应拥有者继续恢复。类型可编译和适配测试不能证明这些真实消费者可运行。RemoteInitInfo.MoveNext 与 FindIntermediateHexPath 的导出仍有 JUMPOUT，不据此猜写。

## 逐成员清单（64）

| 原 RVA | 原 Token | 原声明 |
| --- | --- | --- |
{rows}

本批交接状态：`ready_for_integration`，文件 `work/parallel-44-battle/role-handoff.json`。**64 成员稳定候选已冻结；本批没有完成原游戏单位生成、移动攻击、战斗胜负或 Unity 运行验收。**
'''
(WORK/'role-report.md').write_text(text,encoding='utf-8')
print('wrote role-handoff.json and role-report.md; frozen',audit['candidate_sha256'])
