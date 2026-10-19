from pathlib import Path
import datetime,hashlib,json,re,shutil,struct
R=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20');W=R/'work/stage51-config-keys';P=R/'outputs/OccupyCityRecovered';D=R/'outputs/恢复过程文档';E=D/'51-旧配置主键访问器恢复-证据';E.mkdir(parents=True,exist_ok=True)
def sha(p):return hashlib.sha256(Path(p).read_bytes()).hexdigest()
def read(p):return json.loads(Path(p).read_text(encoding='utf-8-sig'))
manifest=[]
def copy(src,rel):
    src=Path(src);out=E/rel;out.parent.mkdir(parents=True,exist_ok=True);shutil.copyfile(src,out)
    assert sha(src)==sha(out);manifest.append({'source':str(src),'path':str(rel),'sha256':sha(out),'bytes':out.stat().st_size})
plan=read(W/'write-plan.json');apply=read(W/'apply-result.json');review=read(W/'independent-scope-review.json')
assert apply['applied'] and apply['productionSourceWrites']==38 and apply['productionMetaWrites']==0
assert review['decision']=='supported' and not review['findings']
for f in plan['files']:
    p=P/f['path'];assert sha(p)==f['candidateSha256'] and sha(p.with_suffix('.cs.meta'))==f['metaSha256']
    copy(W/'source-before'/f['path'],Path('source-before')/f['path'])
    copy(W/'candidate'/f['path'],Path('candidate')/f['path'])
    copy(p,Path('production-source')/f['path'])
    copy(p.with_suffix('.cs.meta'),Path('production-source')/Path(f['path']).with_suffix('.cs.meta'))
    copy(f['nativeEvidence']['path'],Path('native')/(f['rva']+'.asm.txt'))
raw=(R/'work/ida-input/libil2cpp-arm64.so').read_bytes();offset=struct.unpack_from('<Q',raw,32)[0];z,n=struct.unpack_from('<HH',raw,54);segs=[struct.unpack_from('<IIQQQQQQ',raw,offset+i*z) for i in range(n)]
for f in plan['files']:
    a,b=int(f['rva'],16),int(f['endRva'],16);s=next(s for s in segs if s[0]==1 and s[3]<=a and b<=s[3]+s[5]);code=raw[s[2]+a-s[3]:s[2]+b-s[3]];assert hashlib.sha256(code).hexdigest()==f['nativeCodeSha256']
    p=E/'native'/(f['rva']+'.bin');p.write_bytes(code);manifest.append({'source':'original ELF range '+f['rva']+'..'+f['endRva'],'path':str(p.relative_to(E)),'sha256':sha(p),'bytes':len(code)})
for name in ['plan.md','write-plan.json','prepare.py','apply.py','apply-result.json','compile_main.py','config_fixture.py','archive.py','independent-source-baseline.json','independent_scope_review.py','independent-scope-review.json']:
    copy(W/name,Path('workflow')/name)
for mode in ['before','candidate','actual']:
    for file in ['GetterBoundaryFixture.csproj','expected.json','provenance.json','build.log','run.log','result.json','run-summary.json']:
        copy(W/'getter-fixture'/mode/file,Path('getter-fixture')/mode/file)
    copy(W/'getter-fixture'/mode/'bin/Release/net10.0/GetterBoundaryFixture.dll',Path('getter-fixture')/mode/'GetterBoundaryFixture.dll')
    for file in ['ConfigChainHarness.csproj','Program.cs','inputs-before.json','inputs-after.json','result.json','run.log','summary.json']:
        copy(W/'config-fixture'/mode/file,Path('config-fixture')/mode/file)
copy(W/'getter-fixture/Program.cs','getter-fixture/Program.cs');copy(W/'getter-fixture/run_fixture.py','getter-fixture/run_fixture.py')
postcompile_reference_changes=[]
for mode in ['candidate','actual']:
    for file in ['Assembly-CSharp.rsp','compile.log','inputs-before.json','inputs-after.json','result.json','Assembly-CSharp.dll']:
        copy(W/'compile'/mode/file,Path('compile')/mode/file)
for name in ['stage41-handoff.json','stage41-independent-review.json','stage41-getter-scope-review.json','stage41-required-getter-targets.json']:
    copy(R/'work/parallel-coordination'/name,Path('coordination')/name)
copy(R/'work/parallel-41-config/tests/BoundaryAdapters.cs','shared-fixture/BoundaryAdapters.cs')
copy(R/'work/parallel-41-config/tests/generated/candidate-current-getters/expected.json','shared-fixture/expected-payloads.json')
before=read(W/'getter-fixture/before/result.json');candidate=read(W/'getter-fixture/candidate/result.json');actual=read(W/'getter-fixture/actual/result.json')
assert before['failedTypeCount']==38 and before['failedTestCount']==1140 and before['observedExpectedNegative']
assert candidate['passed'] and actual['passed'] and actual['totalTestCount']==1178
for mode in ['candidate','actual']:
    cf=read(W/'config-fixture'/mode/'summary.json');cc=read(W/'compile'/mode/'result.json')
    assert cf['checks']==830 and (cf['rowsCompared'],cf['fieldsCompared'],cf['identitiesCompared'])==(927,7424,930) and cf['generatedGetterBusinessSubstitutions']==0
    assert cc['exitCode']==0 and cc['errorCount']==0 and cc['inputsStable']
    inputs=read(W/'compile'/mode/'inputs-after.json')
    changes=[{'mode':mode,'path':p,'compiledInputSha256':s,'archiveInputSha256':sha(p)} for p,s in inputs.items() if sha(p)!=s]
    assert all(Path(x['path']).suffix=='.dll' and '/Library/Bee/' in x['path'].replace('\\','/') for x in changes),'Production source drift before final archive'
    postcompile_reference_changes.extend(changes)
provenance=read(W/'getter-fixture/actual/provenance.json')
assert all(sha(x['path'])==x['sha256'] for x in provenance['files'])
hand={'stage':51,'extensionOfStage':41,'state':'applied_and_static_managed_verified','task':'38个旧配置UniqueID访问器原行为恢复','createdAt':datetime.datetime.now().astimezone().isoformat(),'projectRoot':str(P),'workRoot':str(W),'report':str(D/'51-旧配置主键访问器恢复.md'),'evidenceRoot':str(E),'ownedFileCount':38,'restoredBodyCount':38,'nativeBoundedTargetCount':38,'nativeCodeBytes':3496,'ownedFiles':plan['files'],'productionSourceApplied':True,'productionSourceWrites':38,'productionMetaWrites':0,'backup':apply['backup'],'nonGetterEntireSourceBytesPreserved':True,'allTokenRvaFieldJsonCtorNontargetPreserved':True,'metaShaGuidUnchangedCount':38,'independentReview':{'path':str(W/'independent-scope-review.json'),'sha256':sha(W/'independent-scope-review.json'),'decision':review['decision'],'findings':review['findings']},'directGetterFixture':{'before':read(W/'getter-fixture/before/run-summary.json'),'candidate':read(W/'getter-fixture/candidate/run-summary.json'),'actual':read(W/'getter-fixture/actual/run-summary.json')},'actualProduction41ConfigChainBoundaryFixture':{mode:read(W/'config-fixture'/mode/'summary.json') for mode in ['before','candidate','actual']},'compile':{mode:read(W/'compile'/mode/'result.json') for mode in ['candidate','actual']},'postCompileExternalReferenceDrift':postcompile_reference_changes,'postCompileDriftInterpretation':'Both candidate/actual compilation inputs were stable during each compile. Later Unity recompilation refreshed two external Bee ref DLLs; no38 target production source drift. Prior full compile is accepted at its saved input snapshot only. No new build/test was run after Root noted subsequent Unity Main7 progress.','rowUniqueIDDependencyClosed':True,'candidateRowGetterBusinessSubstitutions':0,'productionConfigClosureComplete':False,'UnityJsonUtilityAccepted':False,'UnityEditorRun':'not-run by this task; Root owns real Unity validation','coreGameplayAccepted':False,'sharedUnityControlled':False,'sharedIdaDatabaseTouched':False,'unclosedDependencies':['Original AppSetting.UseNewRes/IsUseMemoryPack accessor field contracts and CLog.Error remain independent framework scope.','Real Unity JsonUtility generic wrapper/constructor/null/exception behavior and real ResourcesInfo/provider/GameStart callback are not accepted by System.Text.Json boundary fixture.','Original scene/map/capture/troop/combat/runtime acceptance remains Root scope.'],'excludedObjects':['SettingConfig','WorldCupbaseConfigConfig','BaseConfigConfig'],'excludedExtraTables':['MLanguageImageConfig','EffectConfig','AudioConfig','LanguageConfig','VideoBtnConfig'],'notes':['The prior stage41 current-getters null-key failure is now fixed by actual production38 getter bodies. Prior historical handoff/review retain their original snapshot statements.','The830 postapply checks compile actual3 ConfigMgr/ConfigRead/BaseConfig production sources and38 actual production getters; no test-local rowgetter mutation. External adapter boundary remains explicit.','Before getter harness exit1 was preserved; it reports1140 failed assertions across38 null getter types. Candidate and actual report1178 checks0fail.']}
hp=R/'work/parallel-coordination/stage51-handoff.json';hp.write_text(json.dumps(hand,ensure_ascii=False,indent=2),encoding='utf-8');copy(hp,'coordination/stage51-handoff.json')
rows='\n'.join('| '+f['type']+' | '+f['token']+' | '+f['rva']+' | '+f['candidateBody'].replace(';','')+' |' for f in plan['files'])
report=f'''# 51：旧配置主键访问器恢复

已将原同步配置链必需的 **38 个 UniqueID.get** 应用生产。每个 getter 只返回原生 this+0x10 的 int 字段，由 C# 保留原 System.Int32 装箱；字段、JSON 声明、构造器、其他正文、Token/RVA 和全部38份 meta/GUID 保持。

此前实际38类getter均返回null，原41配置读取在首表GoalRewardConfig的Dictionary.ContainsKey(null)抛ArgumentNullException，IsInitialize=false、表计数0。现在实际生产源经过同一受控资源与JSON边界，可以完成38表927行及3对象读取。该结论是managed源码与受控边界验证，**正式 Unity 配置链闭包仍为false**。

| 验证 | 实际结果 | 范围 |
|---|---|---|
| before直接getter负对照 | build0、harness1；38失败类型、1140/1178失败 | 真实null getter；非零失败保留 |
| candidate直接getter | 1178检查、0失败 | int.MinValue/-1/0/1/int.MaxValue、box类型/字典键/字段重读 |
| postapply实际getter | 1178检查、0失败 | Compile Include实际生产38源、virtual UniqueID调用 |
| before原41配置链 | 50项预期失败行为检查通过 | 首表null-key、ready=false、counter0 |
| candidate原41配置链 | 830检查、0失败；927行、7424字段、930身份 | 正式生产3文件+候选38行类，getter业务替身0 |
| postapply原41配置链 | 830检查、0失败；927行、7424字段、930身份 | 全部实际生产41类/3链文件，getter业务替身0 |
| full main候选官方rsp | exit0、error0；2239输入稳定 | 仅替换38候选源码 |
| full main实际官方rsp | exit0、error0；2239输入稳定 | candidate source substitution=0 |
| 独立结构review | supported、0发现 | 38全文精确反演、getter外字节保留、meta/GUID保留 |

原native证据来自38段各92字节的精确ARM64范围，共3496字节。独立review已核全部原始asm字节与ELF、Token/RVA/end、int字段和元数据：每个getter读this+0x10，把Int32值写到栈上传给boxing helper。ELF导出il2cpp_value_box与getter调用跳板均跳至0x3C54D50，未按id/Level/Type/arnenaLevel命名猜测字段。

候选38源分别按token定位，只把return null替成原字段返回；独立反演还原后，整份文件字节与固定基线完全一致。全部源码和meta预检在首次写入前完成，原源码备份在项目外的work/recovery-stubs/stage51-config-keys，实际38生产源哈希等于候选。

| 类型 | 原getter Token | 原RVA | 恢复返回 |
|---|---|---|---|
{rows}

三份对象SettingConfig、WorldCupbaseConfigConfig、BaseConfigConfig由readConfigVByUnityJson读取，不使用UniqueID；额外交付的MLanguageImageConfig、EffectConfig、AudioConfig、LanguageConfig、VideoBtnConfig不在原同步ConfigMgr路径，均未修改。

保留了原字典不Clear、不覆盖、重复键日志后保留原对象、空/null Datas不访问source、null行/source异常、解析/资源异常不增加计数、pool9组/51真实行引用和Initialize异常前缀契约。测试解析器仍是System.Text.Json adapter；AppSetting/CLog/ResourcesInfo、TextAsset/YooAsset边界明确是受控adapter。它们不能证明真实Unity JsonUtility的null/构造器/异常细节或真实provider/GameStart回调。

AppSetting资源/格式模式属性、CLog真实诊断、真实Unity解析及资源桥集成仍为分别归属的依赖。未控制Unity、未打开或操作IDA。编译结果不等于场景、开图、占领、兵团战斗或最终玩法验收。

两次full main编译期间2239源码/引用输入均稳定。归档时Unity同期重编译更新GFRunning.ref.dll和OccupyCity.Recovery.LocalResources.Editor.ref.dll，38目标源与meta无变化。handoff逐项保存编译时与归档时引用哈希；编译证据只对应其明确的输入快照。Root后续Main7运行进展另属其Unity证据，本任务未因引用刷新重复运行构建或测试。

本证据目录保存38原生ASM/原始码片段、38修改前/候选/生产源及meta、独立scope/fixture结果、官方rsp及全部编译输入哈希、实际主程序集、apply与handoff。索引见manifest.json。
'''
rp=D/'51-旧配置主键访问器恢复.md';rp.write_text(report,encoding='utf-8');hand['reportSha256']=sha(rp);hp.write_text(json.dumps(hand,ensure_ascii=False,indent=2),encoding='utf-8');shutil.copyfile(hp,E/'coordination/stage51-handoff.json')
for item in manifest:
    if item['path']=='coordination\\stage51-handoff.json' or item['path']=='coordination/stage51-handoff.json':item['sha256']=sha(E/'coordination/stage51-handoff.json');item['bytes']=(E/'coordination/stage51-handoff.json').stat().st_size
manifest.sort(key=lambda x:x['path']);(E/'manifest.json').write_text(json.dumps({'stage':51,'createdAt':datetime.datetime.now().astimezone().isoformat(),'fileCount':len(manifest),'files':manifest},ensure_ascii=False,indent=2),encoding='utf-8')
assert all(sha(E/x['path'])==x['sha256'] for x in manifest)
print(json.dumps({'report':str(rp),'handoff':str(hp),'handoffSha256':sha(hp),'evidence':str(E),'evidenceFiles':len(manifest),'production38Verified':True,'rowGetterDependencyClosed':True,'productionConfigClosureComplete':False},ensure_ascii=False))
