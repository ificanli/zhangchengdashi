import difflib,hashlib,json,re,sys
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gamemanager-recovery';source=root/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/GameModule/GameManager.cs';before=root/'work/recovery-stubs/gamemanager-before/GameManager.cs';actual='--actual' in sys.argv;path=source if actual else own/'GameManager.candidate.cs';sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
text=path.read_text(encoding='utf-8-sig');old=before.read_text(encoding='utf-8-sig');tokens=lambda s:re.findall(r'\[Token\(Token = "(0x[0-9A-Fa-f]+)"\)\]',s);assert tokens(text)==tokens(old)
assert sha(source.with_suffix('.cs.meta'))==sha(before.with_suffix('.cs.meta'))
if actual:assert text==(own/'GameManager.candidate.cs').read_text(encoding='utf-8-sig')
else:assert source.read_bytes()==before.read_bytes()
il=(own/('compile/actual.il.txt' if actual else 'compile/candidate.il.txt')).read_text(encoding='utf-8-sig')
def state(name):
 m=re.search(r"\t\.class nested[^\n]*'<"+name+r">d__\d+'",il);assert m,name;end=il.index('\n\t} // end of class',m.start());return il[m.start():end]
init=state('Init');show=state('ShowCardProbabilityPanel');enter=state('EnterMeta');iterator=state('CheckNetworkState')
checks={'Init_two_real_awaits':init.count('::AwaitUnsafeOnCompleted<')==2,'ShowPanel_one_real_await':show.count('::AwaitUnsafeOnCompleted<')==1,'EnterMeta_async_void_no_await':enter.count('::AwaitUnsafeOnCompleted<')==0 and 'AsyncVoidMethodBuilder::SetException' in enter,'callback_before_flag_before_report':init.index('System.Action::Invoke()')<init.index('stfld bool GameModule.GameManager::InitComplete')<init.index('GameModule.ReportEventsManager::AppOpenEvent()'),'one_InitComplete_write':il.count('stfld bool GameModule.GameManager::InitComplete')==1,'Init_has_SetException':'AsyncUniTaskMethodBuilder::SetException' in init,'iterator_uses_real_Unity_equality':'UnityEngine.Object::op_Inequality' in iterator,'no_extra_TaskCompleted_shortcut':'CompletedTask' not in text,'source_async_attributes_recompiled':il.count('AsyncStateMachineAttribute::.ctor')==3 and il.count('IteratorStateMachineAttribute::.ctor')==1,'constructor_before_base':il.index("GameModule.UpdateController::.ctor()")<il.index("ToolModule.ManagerBase`1<class GameModule.GameManager>::.ctor()")}
assert all(checks.values()),checks
native=[]
for name in ['status-bounded.json','status-large-once.json']:
 data=json.loads((own/'ida'/name).read_text());assert data['stage']=='complete';native+=data['methods']
assert len(native)==43 and all(m['actual_function_start']==hex(m['address']) and m['actual_function_end']==hex(m['end']) for m in native)
log=(own/('tests/actual-run.log' if actual else 'tests/candidate-run.log')).read_text(encoding='utf-8-sig');assert 'RESULT scenarios=30 checks=227 failures=0' in log
proof=json.loads((own/'candidate-provenance.json').read_text());metadata=json.loads((own/'metadata-identities.json').read_text());gm=next(t for t in metadata if t['type']=='GameModule.GameManager')
members=[m for m in gm['methods'] if m['Name'] in proof['candidateMethods']]
assert len(members)==16
result=dict(status='actual-source-written' if actual else 'candidate-ready-production-source-unchanged',restoredDirectMethods=16,originalLambdaBodiesRestored=10,fieldInitializer='UpdateController',sourceBeforeSha256=sha(before),candidateSha256=sha(own/'GameManager.candidate.cs'),productionSourceSha256=sha(source),metaSha256=sha(source.with_suffix('.cs.meta')),tokenSequenceUnchanged=True,nativeBoundariesVerified=43,ILChecks=checks,adaptedControlFlowScenarios=30,adaptedControlFlowChecks=227,monthlyBonusNativeInputs=143,methodIdentities=members,knownOriginalNetworkPrerequisiteLoop='while this valid with missing Time/Data/Init flag has no yield before ready; do not bypass flags',UnityRuntimeValidation='not-run by this stage')
(own/('final-audit.json' if actual else 'candidate-audit.json')).write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8');(own/'GameManager.patch').write_text('\n'.join(difflib.unified_diff(old.splitlines(),text.splitlines(),fromfile='before/GameManager.cs',tofile='after/GameManager.cs',lineterm='')),encoding='utf-8');print(json.dumps({k:v for k,v in result.items() if k!='methodIdentities'},ensure_ascii=False,indent=2))
