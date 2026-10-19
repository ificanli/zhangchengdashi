import hashlib,json,re,shutil
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];W=Path(__file__).resolve().parent
OUT=ROOT/'outputs/恢复过程文档';E=OUT/'证据/原单位与战斗主链44';E.mkdir(parents=True,exist_ok=True)
def read(p):return json.loads((W/p).read_text(encoding='utf-8-sig'))
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest()
manifest=read('delivery-manifest.json');compile_result=read('compile/result.json');status=read('ida/status-supplement.json')
assert compile_result['exit_code']==0 and not compile_result['errors']
assert all(compile_result['candidate_sha256'][r['path']]==r['candidate_sha256'] for r in manifest['files'])
assert status['stage']=='complete' and len(status['methods'])==476
manager=read('manager-validation/result.json');scene=read('scene-validation/candidate-result.json');scene_base=read('scene-validation/baseline-result.json')
synergy=read('synergy-validation/audit.json');role=read('role-handoff.json');lifecycle=read('manager-lifecycle-validation/result.json')
hashes={Path(r['path']).name:r['candidate_sha256'] for r in manifest['files']}
assert synergy['candidateSha256']==hashes['SynergyEffectManager.cs']
assert role['owned_files'][0]['candidate_sha256']==hashes['RoleBehaviour.cs']
assert lifecycle['candidate']['sourceSha256']==hashes['BattleGameManager.cs']
scene_handoff=read('scene-handoff.json');assert scene_handoff['candidate_sha256']==hashes['BattleGameSceneManager.cs']
il=read('manager-il-audit.json');assert all(il.values())
native=read('manager-validation/native-summary.json')
def summary(log):
 text=(W/log).read_text(encoding='utf-8-sig');matches=re.findall(r'\{[^\r\n]+\}',text)
 return matches[-1] if matches else text.strip().splitlines()[-1]
rowtable='\n'.join(f"| `{Path(r['path']).name}` | {r['restored_bodies']} | `{r['source_before_sha256']}` | `{r['candidate_sha256']}` |" for r in manifest['files'])
remaining=[
 dict(owner='44后续原正文',dependency='RoleBehaviour.Init / MyUpdate / FindTarget / Move / Atk / AtkCallBack及部分完整特效/攻击回调',impact='被击和死亡已恢复并不自动提供原角色属性、目标驱动、移动到攻击和真实伤害发起。'),
 dict(owner='44后续原正文',dependency='BattleGameSceneManager.GetRoleBornPos及其Hex邻接/三角形随机采样闭包',impact='StartGame/LoadMapGround已按原入口恢复，产兵仍需原出生点算法，不能用任意位置替代。'),
 dict(owner='44后续原正文',dependency='BattleGameSceneManager.SettlementAnimation / EndGame，BattleGameManager.SettlementAnimationEnd / RecordGameResult / GameEndRewardUser等后结算链',impact='本批恢复原胜负判定和结束调用顺序，完整动画结算、奖励应用与返回流程仍需原正文。'),
 dict(owner='主窗口',dependency='CoreGameManager.Init / StartGame / Gaming / BattleContext与真实配置/存档/资源前置',impact='原主入口必须真实推进；禁止直接置Gaming或跳过等待。'),
 dict(owner='原兵营/派生兵种负责者',dependency='BarracksArchitectureBehaviour.CreatRole / OnCanSpawnRole、ArchitectureBehaviour.MyUpdate、Terran/Undead/Machine等派生Init/AtkCallBack、RolePropertyTemp构造',impact='原兵堆生产、属性来源及各兵种伤害回调仍须补齐。'),
 dict(owner='43地图窗口',dependency='GenerateHexBehaviour.Generate/LoadGround，HexManager.TryGetHexAt/GetHexBehaviour，HexBehaviour角色阵营索引/IsCombo/MyUpdate等',impact='候选保留这些真实调用；本窗口没有写地图文件。'),
 dict(owner='寻路/动画/资源负责者',dependency='FollowerEntity/AIDestinationSetter、AIMovementSystemGroup.OnUpdate/ShouldGroupUpdate、WebGLNavigationManager、IAnimation具体驱动、对象池/RoleShadow/HP与特效资源',impact='声明可编译不代表原寻路、GPU动画和资源真实执行。'),
 dict(owner='主窗口统一验收',dependency='Unity原场景/真实地图/开格占领/兵堆移动攻击/死亡回收/胜负/视觉输入',impact='本任务未启动Unity，全部runtime验收为not-run。'),
]
tests=[dict(name='Unity原rsp独立csc',**compile_result),dict(name='Manager候选/负对照',**manager),dict(name='Scene候选/负对照',candidate={k:v for k,v in scene.items() if k!='results'},baseline={k:v for k,v in scene_base.items() if k!='results'}),dict(name='Synergy',audit=synergy),dict(name='Role',details=role),dict(name='Manager生命周期',details=lifecycle),dict(name='Manager编译IL',checks=il),dict(name='Apply源SHA门禁',details=read('apply-validation.json'))]
for r in manifest['files']:
 for m in r['methods']:
  m['native_asm']=str(W/'ida/pseudocode'/(m['rva'].lower()+'.asm.txt'))
  m['native_pseudocode']=str(W/'ida/pseudocode'/(m['rva'].lower()+'.c'))
handoff=dict(state='ready_for_integration',task=44,thread_id=manifest['thread_id'],batch='原证据支持的单位战斗稳定候选批次',main_chain_complete=False,unity_runtime='not-run',shared_project_modified=False,project=manifest['project'],candidate_root=manifest['candidate_root'],owned_files=manifest['files'],total_new_method_bodies=manifest['total_new_bodies'],native_export=dict(methods=476,boundaries_match=True,status=str(W/'ida/status-supplement.json'),outlined_alias_note='JUMPOUT与Dead内部metadata别名见原ASM和专项报告，不按伪C长度推断所有真实边界'),tests=tests,apply_script=str(W/'apply_candidates.py'),preflight_command=f'& "{Path(__import__("sys").executable)}" -X utf8 "{W / "apply_candidates.py"}"',apply_command=f'& "{Path(__import__("sys").executable)}" -X utf8 "{W / "apply_candidates.py"}" --apply',still_open_dependencies=remaining,report=str(OUT/'44-原单位与战斗主链.md'),per_method_manifest=str(W/'delivery-manifest.json'))
coord=ROOT/'work/parallel-coordination/stage44-handoff.json';coord.parent.mkdir(parents=True,exist_ok=True)
# Archive source/evidence only. Never copy IDA databases or experimental binaries.
allowed={'.py','.ps1','.cs','.csproj','.json','.log','.md','.txt','.patch','.c','.h'}
for p in list(W.rglob('*')):
 if not p.is_file() or p.suffix.lower() not in allowed:continue
 rel=p.relative_to(W)
 if any(x in ('bin','obj','__pycache__','apply-test-project','stable-53','stable-60','candidate-next') for x in rel.parts):continue
 if rel.as_posix()=='ida/batch-export.log':continue
 if rel.parts[:2]==('compile','il'):continue
 if rel.parts and rel.parts[0]=='compile' and p.name not in ('result.json','candidate.log','manager.il.txt','attempt1-result.json','attempt2-result.json','attempt3-result.json'):continue
 dest=E/rel;dest.parent.mkdir(parents=True,exist_ok=True);shutil.copyfile(p,dest)
for name in ['role-report.md','scene-report.md','synergy-report.md','manager-review.md','manager-lifecycle-report.md']:
 p=W/name
 if p.exists():shutil.copyfile(p,E/name)
deps='\n'.join(f"| {d['owner']} | {d['dependency']} | {d['impact']} |" for d in remaining)
report=f'''# 44 原单位与战斗主链：原生分析、候选恢复与验证

日期：2026-10-19。状态：**已形成可供主窗口按起始SHA合入的稳定候选批次，共{manifest['total_new_bodies']}个新增原方法/访问器/原状态机正文；原地图到兵堆战斗的完整主链尚未闭合。** 四个完整候选均位于本任务独立work目录。共享工程源码、地图文件、Packages、ProjectSettings和所有.meta未修改；未打开Unity、Hub或PlayMode。

## 范围、保护与交付

仅拥有BattleGameSceneManager、BattleGameManager、RoleBehaviour、SynergyEffectManager四个文件。起始Token/RVA、方法签名、全部起始正文与SHA、已有非空正文记录在[owned-scope.json](证据/原单位与战斗主链44/owned-scope.json)。最终独立审计确认全部原Token/Address序列保持，9段已有非空正文逐字节保持，包括InternalCalculateDamage的注释、float32计算和CRLF换行。原556组既有对照没有被整数除法或新算法取代；本批另有实际候选对照。

| 文件 | 新增正文数 | source-before SHA256 | candidate SHA256 |
|---|---:|---|---|
{rowtable}

新增正文数为经证据核实的源级正文差异，包含访问器、原状态机成员和原builder完成入口，**不等同于新增业务能力数**。原本无业务的Prewarm已核builder完成，未据此宣称恢复池预热。外部库声明、编译器新生成成员和字段初始化器不重复计入；构造原初值另记在各分报告和恢复清单中。完整差异、候选及逐方法身份见[delivery-manifest.json](证据/原单位与战斗主链44/delivery-manifest.json)。

规范交接文件：`{coord}`。当前threadId：`{manifest['thread_id']}`。

## 原生证据和边界

只操作44号专属`work/parallel-44-battle/ida/framework.i64`，未打开或写共享数据库。独立driver导出476项原方法，导出时actual start/end与本批元数据目标逐项一致，Hex-Rays9.4可用。未对所有导出方法一律套用可疑原型：original script.json的部分结构体this声明和缺类型导致prototype应用失败，恢复时仍逐项核ARM64寄存器、值类型传递、原字段偏移、真实泛型和虚调用。

首次导出标出12项JUMPOUT；具体恢复涉及的outlined islands均见专项ASM。BeginStartCountDown的0x856DFA0两指令岛返回0x3DEA01C，并非可删除的等待。Role.Dead范围内出现独立metadata别名/内部调用，不能把包含范围的单份伪C顺序直接当成主方法正文。完整导出状态见[status-supplement.json](证据/原单位与战斗主链44/ida/status-supplement.json)。

原ELF SHA256为`72770d00b2b404acf44cc75cc8bf7a3e06850e9ace1237c9cbb2bc72894220ed`。原生oracle直接执行该ELF的ARM64指令；只对各测试声明的外部库/单例/Unity/资源依赖设置可记录hooks，未用Python复制业务逻辑冒充原native。

## 原入口与资源消费链

```mermaid
flowchart TD
 A[原GameManager.StartCoreGame] --> B[CoreGameManager.StartGame及状态机]
 B --> C[BattleGameSceneManager.LoadMapGround / StartGame]
 C --> D[43号 GenerateHexBehaviour原地图生成]
 D --> E[原Hex开格 / 阵营 / 建筑登记]
 E --> F[原Barracks产兵 / RoleBornPos]
 F --> G[原Role.Init与派生兵种覆写]
 H[原Scene.Update / 四类列表批次] --> I[Role.MyUpdate / FindTarget / Move / Atk]
 G --> I
 I --> J[原Wound / Synergy / Dead / 回收]
 E --> K[原BattleGameManager胜负 / 倒计时]
 J --> K
```

上图表示原调用关系，不能把箭头当作全部正文已恢复。Core/Barracks/Hex入口的只读原ELF调用与metadata证据在[native-consumer-evidence.json](证据/原单位与战斗主链44/native-entry/native-consumer-evidence.json)，Scene专项另含38个原消费者函数和9项实际资源GUID/配置记录。原生成器、SkillIndicator、角色资源、原HP/死亡特效/动画驱动均按真实路径消费，未新建替代战场或另一套攻击规则。

## 四文件的恢复内容

- **战场侧**：原容器/根对象初始化与真实资源等待；容量和预占；双方登记移除；传奇计数与等待兵营优先序；同步选敌及按帧缓存、HexRing和列表回退；原Update到四类列表MyUpdate的批次驱动。后续入口恢复和所有原参数详见[Scene分报告](证据/原单位与战斗主链44/scene-report.md)。
- **战斗管理侧**：原Init的一次等待和13项事件订阅；StartGame真实配置/金币/回调生产；暂停及Animator/AniInstancing/GPUI快照；原Countdown/BeginStartCountDown/CountDownEnd；GameEnd的2.3秒等待和结算调用；EndGame回调与清理顺序；伤害/阵亡统计与金币事件。34正文及构造5初值均有逐方法复核，见[独立复核](证据/原单位与战斗主链44/manager-review.md)和[生命周期验证](证据/原单位与战斗主链44/manager-lifecycle-report.md)。
- **单位侧**：原移动/寻路调用契约、动画驱动选择、格子阵营登记、目标保留、控制清理、Wound及死亡回收链本批已恢复部分。每段是否通过原生/候选验证及具体未闭合入口，以[Role分报告](证据/原单位与战斗主链44/role-report.md)和其逐方法清单为准。
- **羁绊侧**：原双方计数来源、新旧模式、生产/伤害/随机/半血/邻近减伤等完整业务类正文；原Init状态机和构造AB读取。InternalCalculateDamage原正文保持。详见[Synergy分报告](证据/原单位与战斗主链44/synergy-report.md)。

## 关键失败、修复与原语义

1. 初次csc暴露GameEnd的IsPanelShowing缺out实参，以及存档类的全局命名空间/`I.Data`实例API。已按原ASM和实际声明修正，未改外部拥有者源码。
2. 原倒计时Random.Range上界为101、比较<=79；暂停yield恢复后直接回暂停门。独立复核修正两项，测试捕获原上界和暂停恢复边界。
3. 已销毁AniInstancing仍应先进入托管类型分支，再做Unity存活比较；修正了错误GPU fallback，并验证原快照恢复、新增Animator和GPU速度回放。
4. 原构造数组12字节为`1E0000005A000000D2000000`，即30/90/210；其SHA256与原PrivateImplementationDetails字段名一致。没有凭体验填默认计时。
5. 选敌不能绕过HexRing：已搜索但无目标时不强制改走全列表；原range/距离NaN比较、cache hash初值和容量int32溢出以ASM和原生对照为准。
6. 原等待兵营、triggerTrySpawn=false、每50项yield、异步异常后upgradeing仍true等原门均保留，未添加假ready、假回调或异常后继续机制。

## 验证结果与能证明的范围

| 层级 | 当前结果 | 边界 |
|---|---|---|
| 原专属IDA导出 | 476项，目标边界逐项匹配 | 仍需ASM核对outlined和别名，不能只信伪C |
| 完整原Assembly-CSharp.rsp独立csc | exit0，0错误，{compile_result['warning_count']}条保留工程警告，真实DLL已输出 | 保留全部原ref/define/analyzer；只重定向输出和4个候选，不等于UnityILPP/运行 |
| Manager原ARM64 | ChangeCoin/CountDownEnd共105案例，另Update40组逐位边界 | 外部事件/单例/UnityAPI为记录hooks |
| Manager实际候选29正文 | 160场景/413检查/0失败；source-before负对照105场景/129检查失败 | 包括调用顺序、等待门、回绕、暂停与GPU适配 |
| ManagerInit/GameEnd/StartGame | 102场景/1195检查/0失败；空壳935失败 | Task依赖适配不等于UnityPlayerLoop |
| Scene实际候选 | {scene['scenarios']}场景/{scene['checks']}检查/0失败；空壳{scene_base['failed']}场景失败 | 原生容量/hash/启动数量{scene['nativeOperations']}项；真实Hex/资源/帧系统仍需运行验收 |
| Synergy实际候选 | 6408检查/0失败；空壳3339失败；32方法3200个原ARM64案例 | 原生外部Unity/计数单例hook范围在分报告明确 |
| Role实际候选 | 3645检查/0失败；空壳2413失败；数值2040、Wound240、死亡64场景/96阶段原生对照 | 未把兵种派生/寻路/HP依赖当作已恢复 |
| Manager编译IL | {len(il)}项全部通过 | 原await/异常builder/Unity比较/事件数/Format/构造顺序均已读回 |
| 现有正文/Token/Address/.meta | 全通过，共享源SHA仍等于起始SHA | InternalCalculateDamage等9段已有正文逐字节保持 |
| apply脚本 | 只读预检、源变更拒绝且零部分写入、工作区内一次应用读回、重复应用拒绝均通过 | 实际共享工程仅预检，未应用 |
| Unity/Hub/PlayMode/视觉/原兵堆战斗 | **not-run** | 由主窗口统一合入和真实运行 |

测试生成器均从交付候选重提取正文或直接Compile Include候选，没有维护另一份战斗业务实现。负对照来自source-before原空桩。Manager首次一个断言只去掉LF未去掉CR导致9项字段比较误报，已改为整型序列比较；调用轨迹当时已经一致，修复夹具后全部通过。所有失败与修复都保留在各目录日志/复核记录。

## 未闭合依赖与不能宣称完成的内容

| 归属 | 依赖 | 影响 |
|---|---|---|
{deps}

具体本文件尚空的原方法逐项保留在源码和交接清单。尤其Role.Init/MyUpdate/Move/Atk等原主循环仍需后继恢复，已恢复伤害/死亡不构成完整战斗运行；没有补一套直接扣血示范来跨过这些门。

## 主窗口应用与复现

工作目录固定为`{ROOT}`。实际候选根为`{W / 'candidate'}`；apply脚本为`{W / 'apply_candidates.py'}`。脚本默认只读；`--apply`先检查四个源SHA、四个候选SHA及.meta SHA，任一不符就拒绝全部覆盖。当前实际共享工程的preflight已通过，但未执行应用。

```powershell
& 'C:/Users/luxinyu/AppData/Local/Programs/idapromcp/source/.venv/Scripts/python.exe' -X utf8 work/parallel-44-battle/apply_candidates.py
# 主窗口统一集成时：
& 'C:/Users/luxinyu/AppData/Local/Programs/idapromcp/source/.venv/Scripts/python.exe' -X utf8 work/parallel-44-battle/apply_candidates.py --apply
# 独立编译与正文保护：
& 'C:/Users/luxinyu/AppData/Local/Programs/idapromcp/source/.venv/Scripts/python.exe' -X utf8 work/parallel-44-battle/compile_candidates.py
& 'C:/Users/luxinyu/AppData/Local/Programs/idapromcp/source/.venv/Scripts/python.exe' -X utf8 work/parallel-44-battle/audit_delivery.py
& 'C:/Users/luxinyu/AppData/Local/Programs/idapromcp/source/.venv/Scripts/python.exe' -X utf8 work/parallel-44-battle/record_manager_checks.py
```

其他专项的完整复现命令、适配说明和负对照预期退出码见对应分报告。编译/适配测试/原生oracle/真实Unity验收分别记录。证据归档不含IDA大数据库、实验DLL、账号或授权文件。
'''
(OUT/'44-原单位与战斗主链.md').write_text(report,encoding='utf-8')
coord.write_text(json.dumps(handoff,ensure_ascii=False,indent=2),encoding='utf-8')
(E/'stage44-handoff.json').write_text(json.dumps(handoff,ensure_ascii=False,indent=2),encoding='utf-8')
# Final compact archive inventory, paths and hashes rather than duplicate large binaries.
inventory=[dict(path=p.relative_to(E).as_posix(),sha256=sha(p),bytes=p.stat().st_size) for p in E.rglob('*') if p.is_file() and p.name!='evidence-manifest.json']
(E/'evidence-manifest.json').write_text(json.dumps(inventory,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps(dict(handoff=str(coord),report=str(OUT/'44-原单位与战斗主链.md'),new_bodies=manifest['total_new_bodies'],evidence_files=len(inventory),state='ready_for_integration'),ensure_ascii=False,indent=2))
