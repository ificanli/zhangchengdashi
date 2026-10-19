import difflib
import hashlib
import json
import re
from pathlib import Path

ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/stage37-entry'
PROJECT=ROOT/'outputs/OccupyCityRecovered'
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
plan=json.loads((OWN/'write-plan.json').read_text(encoding='utf-8'))
original=json.loads((ROOT/'work/start-entry-plan/original-method-metadata.json').read_text(encoding='utf-8'))
minimal=json.loads((ROOT/'outputs/恢复过程文档/证据/首场景框架入口恢复/minimal-recovery-plan.json').read_text(encoding='utf-8'))
native=json.loads((ROOT/'work/start-entry-plan/native-evidence.json').read_text(encoding='utf-8'))
byaddr={int(m['address'],16):m for m in native['methods']}
for statusfile in [OWN/'ida/status-bounded.json',OWN/'ida/status-supplement.json',ROOT/'work/ida-framework-assets/status-framework-entry.json']:
    status=json.loads(statusfile.read_text(encoding='utf-8'))
    assert status['stage']=='complete'
    for method in status['methods']:
        assert method['actual_function_start']==hex(method['address']) and method['actual_function_end']==hex(method['end'])
        byaddr.setdefault(method['address'],dict(address=hex(method['address']),end=hex(method['end']),bytes=method['end']-method['address'],assembly=str(statusfile.parent/'pseudocode'/(hex(method['address'])+'.asm.txt'))))

def body_span(text,token):
    pos=text.index('[Token(Token = "'+token+'")]')
    begin=text.index('{',pos)
    depth=1;end=begin+1
    while depth:
        if text[end]=='{':depth+=1
        elif text[end]=='}':depth-=1
        end+=1
    return begin,end

records=[]
identities=[]
for item in plan['files']:
    relative=item['path'];source=PROJECT/relative;before=OWN/'source-before'/relative;candidate=OWN/'candidate'/relative
    assert source.read_bytes()==candidate.read_bytes(),relative
    assert sha(source.with_suffix('.cs.meta'))==sha(before.with_suffix('.cs.meta'))
    old=before.read_text(encoding='utf-8-sig');new=source.read_text(encoding='utf-8-sig')
    oldtokens=re.findall(r'\[Token\(Token = "([^"]+)"\)\]',old)
    newtokens=re.findall(r'\[Token\(Token = "([^"]+)"\)\]',new)
    assert [t for t in newtokens if t!='0x60055DE']==oldtokens
    reverted=new
    for token in item['restoredTokens']:
        a,b=body_span(reverted,token);oa,ob=body_span(old,token)
        reverted=reverted[:a]+old[oa:ob]+reverted[b:]
    if relative.endswith('/GameStartEntry.cs'):
        reverted=reverted.replace('public bool isShowInitGameLog = true;','public bool isShowInitGameLog;').replace('private int tRJqx_0095 = 3001;','private int tRJqx_0095;').replace('private LocalELangLibrary langLibrary = LocalELangLibrary.ZH_CN;','private LocalELangLibrary langLibrary;')
    if relative.endswith('/GameFrameEntry.cs'):
        pos=reverted.index('        [Token(Token = "0x60055DE")]')
        a,b=body_span(reverted,'0x60055DE')
        reverted=reverted[:pos]+reverted[b+1:]
    if relative.endswith('/ljzs_lt/GameStart.cs'):
        anchor='\t\tprivate IEnumerator OpenLoadingUI(Action loadOver)'
        reverted=reverted.replace(anchor,'\t\t[IteratorStateMachine(typeof(_003COpenLoadingUI_003Ed__4))]\n'+anchor)
    normalize_blank_lines=lambda value:re.sub(r'\n(?:[ \t]*\n)+','\n',value)
    assert normalize_blank_lines(reverted)==normalize_blank_lines(old), 'unexpected source change: '+relative
    patch='\n'.join(difflib.unified_diff(old.splitlines(),new.splitlines(),fromfile='before/'+relative,tofile='after/'+relative,lineterm=''))
    out=OWN/'diff'/(source.stem+'.patch');out.parent.mkdir(exist_ok=True);out.write_text(patch,encoding='utf-8')
    type_name={'GameStartEntry':'GameFramework.Base.GameStartEntry','GameFrameEntry':'GameFramework.GameFrameEntry','IGameStart':'GameFramework.Base.IGameStart','GameStart':'ljzs_lt.GameStart'}[source.stem]
    pe=next(t for t in original['types'] if t['type']==type_name)
    wanted=item['restoredTokens']+(['0x60055DE'] if source.stem=='GameFrameEntry' else [])
    for token in wanted:
        original_method=next(m for m in pe['methods'] if int(m['physicalToken'],16)==int(token,16))
        strings=original_method['originalAttributeHexStrings']
        assert any(any(s.lower()==token.lower() for s in row) for row in strings)
        address=next((int(row[0],16) for row in strings if len(row)>1),None)
        if address is None:
            address=int(next(m for m in minimal['methodInventory'] if m.get('declaringType')==type_name and int(m['token'],16)==int(token,16))['rva'],16)
        assert address in byaddr,(type_name,token,hex(address))
        identities.append(dict(type=type_name,token=token,name=original_method['name'],address=hex(address),nativeBytes=byaddr[address]['bytes']))
    records.append(dict(path=relative,sourceBeforeSha256=sha(before),sourceAfterSha256=sha(source),metaSha256=sha(source.with_suffix('.cs.meta')),methods=item['restoredMethods'],fieldInitializers=item['fieldInitializers']))

ils={name:(OWN/'compile/actual'/(name+'.il.txt')).read_text(encoding='utf-8') for name in ['GameStartEntry','GameFrameEntry','IGameStart','GameStart']}
def method(type_name,member):
    text=ils[type_name]
    found=re.search(r'\} // end of method '+re.escape(type_name+'::'+member)+r'\s*\n',text)
    assert found,(type_name,member)
    end=found.start()
    start=text.rfind('.method ',0,end)
    return text[start:end]
initialize=method('GameFrameEntry','Initialize')
awake=method('GameStartEntry','Awake')
start=method('GameFrameEntry','Start')
config=method('GameStart','InitConfig')
register=method('GameStart','RegisterLogicCtr')
checks={
 'Initialize_only_callback_store_and_virtual_call':initialize.count('stfld')==1 and 'System.Action' in initialize and initialize.index('stfld')<initialize.index('::Initialize(object[])') and 'Action::Invoke' not in initialize and 'stfld bool' not in initialize,
 'Awake_original_GetComponent_and_binding':'GetComponent<class GameFramework.Base.IGameStart>()' in awake and '::_007Dye_0080_00BCa' in awake,
 'Awake_original_Version_first_gate':'GetModule<class GameFramework.VersionMondule>()' in awake and '::Initialize(class GameFramework.GameFrameModule' in awake,
 'Awake_before_hook_before_Version':awake.index('::BeforeGameFrameworkInit()')<awake.index('GetModule<class GameFramework.VersionMondule>()'),
 'module_resolver_original_type_api':'System.Type::GetType(string)' in method('GameFrameEntry','K_0086_009C_0083_0084_0089') and 'System.String::StartsWith(string)' in method('GameFrameEntry','K_0086_009C_0083_0084_0089'),
 'module_creation_uses_Activator_and_original_list':'System.Activator::CreateInstance(' in method('GameFrameEntry','_00B9X_0081_0093_0095_009B') and '::AddBefore(' in method('GameFrameEntry','_00B9X_0081_0093_0095_009B'),
 'Start_flag_written_after_real_Start_calls':start.index('GameFrameModule::Start()')<start.index('stsfld bool') and 'finally' in start,
 'original_cctor_identity_and_list':'LinkedList`1<class GameFramework.GameFrameModule>::.ctor()' in method('GameFrameEntry','.cctor'),
 'IGameStart_config_bridge_calls_original_internal_helper':'::whJq_00B8_00B9()' in method('IGameStart','InitConfigOver'),
 'config_init_before_completion_bridge':config.index('::SetConfigABRes(')<config.index('::Initialize()')<config.index('::InitConfigOver()'),
 'original_control_registration_order':register.index('ServerTimeMgr')<register.index('PurchaseControl')<register.index('EmailControl'),
 'original_PreLoad_generic_start':'StartProcedure<class ljzs_lt.Procedure.ProcedurePreLoad>()' in method('GameStart','StartGame'),
 'real_iterator_recompiled':"'<OpenLoadingUI>d__" in ils['GameStart'] and bool(re.search(r'box \[[^\]]+\]System.Int32',ils['GameStart'])),
}
assert all(checks.values()),checks
build=json.loads((OWN/'compile/actual/result.json').read_text(encoding='utf-8-sig'))
assert len(build)==2 and all(b['exitCode']==0 and b['errorCount']==0 for b in build)
assert 'RESULT scenarios=23 checks=71 failures=0' in (OWN/'tests/actual-run.log').read_text(encoding='utf-8-sig')
assert 'RESULT scenarios=23 checks=15 failures=23' in (OWN/'tests/baseline-run.log').read_text(encoding='utf-8-sig')
oracle=json.loads((OWN/'initialize-native-oracle.json').read_text(encoding='utf-8'))
assert len(oracle['cases'])==3 and all(c['initialReady']==c['finalReady'] for c in oracle['cases'])
observation=json.loads((ROOT/'work/recovery-ledger/unity-play-main3.json').read_text(encoding='utf-8-sig'))
assert observation['status']=='observation_completed_core_gameplay_not_accepted' and observation['coreGameplayAccepted']==False and len(observation['errors'])==0
observed4=json.loads((ROOT/'work/recovery-ledger/unity-play-main4.json').read_text(encoding='utf-8-sig'))
assert observed4['status']=='observation_completed_core_gameplay_not_accepted' and not observed4['coreGameplayAccepted'] and not observed4['errors']
for snapshot in observed4['snapshots']:
    frame=snapshot['framework']
    assert frame['observedExistingEntry'] and len(frame['modules'])==1
    module=frame['modules'][0]
    assert module['type']=='GameFramework.VersionMondule'
    assert 'GameFrameModule.x_0080_008D_00B1f_0086=False' in module['fields']
    assert 'GameFrameModule.Àª_00A6_00A3_00BDE=delegate:GameFramework.Base.GameStartEntry.vj_00B7_0098_008A_007F' in module['fields']
    assert 'GameFrameEntry.O_00B8_005D_00A1_008B_005E=False' in frame['entryFields']
    for name in ['persistentABRes','streamingABRes','CurrBundleServices']:
        assert 'VersionMondule.'+name+'=<null>' in module['fields']
result=dict(stage=37,status='actual-four-source-applied-and-verified',restoredMethods=sum(r['methods'] for r in records),fieldInitializers=3,identities=identities,files=records,ILChecks=checks,independentActualSourceCompile=build,adaptedControlFlowScenarios=23,adaptedControlFlowChecks=71,baselineFailures=23,originalInitializeNativeCases=3,originalBoundedAuditMethods=104,mainPlay3=dict(errors=0,snapshots=len(observation['snapshots']),seconds=observation['duration'],coreGameplayAccepted=False),mainPlay4=dict(errors=0,snapshots=len(observed4['snapshots']),seconds=observed4['duration'],firstFrame=observed4['snapshots'][0]['frame'],lastFrame=observed4['snapshots'][-1]['frame'],onlyExistingModule='GameFramework.VersionMondule',ready=False,originalCallbackObserved=True,frameworkStarted=False,resourceInputsNull=True,coreGameplayAccepted=False),currentFirstCallbackGate='VersionMondule.Initialize empty body; root MainPlay4 observed actual existing module, original callback and ready=false; original dispatcher never fakes ready or callback',remainingDependencies=['AppSetting actual properties/cctor/culture','UserDataPrefs.OnInit','VersionMondule/UpdateManager/SDK/file inputs','old/new resource backend and UI real completion','seven secondary module real Initialize/Start','old ConfigMgr actual parse/construct','MineGameLogicModule/ProcedureManager/Fsm real consumers','SDK/platform/CommonSettings','new resource config callback branch','exit/app lifecycle callbacks'])
(OWN/'final-audit.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({k:v for k,v in result.items() if k not in {'identities','independentActualSourceCompile'}},ensure_ascii=True,indent=2))
