import difflib
import hashlib
import json
import re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/stage40-ui'
SOURCE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/GFRunning/GameFramework/UIModule.cs'
BEFORE=OWN/'source-before/UIModule.cs'
sha=lambda path:hashlib.sha256(path.read_bytes()).hexdigest()
proof=json.loads((OWN/'candidate-provenance.json').read_text(encoding='utf-8'))
assert SOURCE.read_bytes()==(OWN/'UIModule.candidate.cs').read_bytes()
assert SOURCE.with_suffix('.cs.meta').read_bytes()==BEFORE.with_suffix('.cs.meta').read_bytes()
old=BEFORE.read_text(encoding='utf-8-sig');new=SOURCE.read_text(encoding='utf-8-sig')
tokens=lambda text:re.findall(r'\[Token\(Token = "([^"]+)"\)\]',text)
assert tokens(old)==[t for t in tokens(new) if t!=proof['staticConstructorToken']]
def body_span(text,token):
    begin=text.index('{',text.index('[Token(Token = "'+token+'")]'));depth=1;end=begin+1
    while depth:
        if text[end]=='{':depth+=1
        elif text[end]=='}':depth-=1
        end+=1
    return begin,end
reverse=new
for token in proof['methodTokens']:
    a,b=body_span(reverse,token);oa,ob=body_span(old,token);reverse=reverse[:a]+old[oa:ob]+reverse[b:]
for old_field,new_field in proof['fieldInitializers'].items():reverse=reverse.replace(new_field,old_field)
pos=reverse.index('\t\t[Token(Token = "'+proof['staticConstructorToken']+'")]',reverse.index('public UIModule()'))
start,end=body_span(reverse,proof['staticConstructorToken'])
reverse=reverse[:pos]+reverse[end+1:]
assert re.sub(r'\n(?:[ \t]*\n)+','\n',reverse)==re.sub(r'\n(?:[ \t]*\n)+','\n',old)
(OWN/'UIModule.patch').write_text('\n'.join(difflib.unified_diff(old.splitlines(),new.splitlines(),fromfile='before/UIModule.cs',tofile='after/UIModule.cs',lineterm='')),encoding='utf-8')
native=json.loads((OWN/'native-consumer-evidence.json').read_text(encoding='utf-8'))
native_by_address={m['address']:m for m in native['methods']}
targets=json.loads((OWN/'native-targets.json').read_text(encoding='utf-8'))
status=json.loads((ROOT/'work/ida-framework-assets/status-stage40-ui.json').read_text(encoding='utf-8'))
assert len(status['methods'])==11 and status['stage']=='complete'
assert all(m['actual_function_start']==hex(m['address'])and m['actual_function_end']==hex(m['end'])for m in status['methods'])
identities=[]
for token in proof['methodTokens']+[proof['restoredConstructorToken']]:
    pos=old.index('[Token(Token = "'+token+'")]');segment=old[pos:old.index('{',pos)]
    address=re.search(r'RVA = "(0x[\da-fA-F]+)"',segment)
    address=hex(int(address[1],16))if address else '0x507ae88'
    assert address in native_by_address
    item=native_by_address[address]
    identities.append(dict(token=token,address=address,name=item['name'],nativeBytes=item['bytes'],codeSha256=item['codeSha256']))
item=native_by_address['0x71d8ea4']
identities.append(dict(token=proof['staticConstructorToken'],address='0x71d8ea4',name=item['name'],nativeBytes=item['bytes'],codeSha256=item['codeSha256']))
full=OWN/'compile/actual/GFRunning.full.il.txt'
target=OWN/'compile/actual/UIModule.il.txt'
if full.exists():
    text=full.read_text(encoding='utf-8-sig')
    end=re.search(r'\} // end of class GameFramework\.UIModule\s*\n',text);assert end
    begin=text.rfind('\n.class ',0,end.start())+1
    target.write_text(text[begin:end.end()],encoding='utf-8')
il=target.read_text(encoding='utf-8')
def method(owner,name):
    end=re.search(r'\} // end of method '+re.escape(owner+'::'+name)+r'\s*\n',il);assert end,(owner,name)
    start=il.rfind('.method ',0,end.start());return il[start:end.start()]
initialize=method('UIModule','Initialize');root=method('UIModule','LoadUIRootOver');ctor=method('UIModule','.ctor')
wait_ctor=method('_003Cwait2Fram_003Ed__19','.ctor')
wait=method('_003Cwait2Fram_003Ed__19','System.Collections.IEnumerator.MoveNext')
checks={
 'constructor_five_allocations_before_base':ctor.count('newobj')==5 and ctor.rfind('newobj')<ctor.index('GameFrameModule::.ctor()'),
 'original_priority_forty':'ldc.i4.s 40' in method('UIModule','get_Priority'),
 'original_canvas_tag_and_root_path':'ldstr "GFUICanvas"' in initialize and 'ldstr "UI/UIRoot"' in initialize,
 'old_load_before_Update_zero':initialize.index('ResourcesModule::LoadPrefab(')<initialize.index('GameFrameEntry::GetModule<class GameFramework.Resources.ResourcesModule>()',initialize.index('ResourcesModule::LoadPrefab(')),
 'no_startup_two_frame_insertion':'::wait2Fram('not in initialize+root,
 'instantiate_original_named_interface':'ldstr "UIRoot"' in root and 'IResCallBackInfo::Instantiate(string, bool)' in root,
 'real_rect_layout_before_ready':root.index('RectTransform::set_offsetMax(')<root.index('stfld bool GameFramework.GameFrameModule::x_0080_008D_00B1f_0086'),
 'ready_before_original_callback':root.index('stfld bool GameFramework.GameFrameModule::x_0080_008D_00B1f_0086')<root.index('System.Action::Invoke()'),
 'wait_original_state_before_action':wait.index('ldc.i4.m1')<wait.index('System.Action::Invoke()'),
 'wait_old_nested_factory_reused':'newobj instance void GameFramework.UIModule/_003Cwait2Fram_003Ed__19::.ctor(int32)' in method('UIModule','wait2Fram'),
 'node_dictionary_cache_and_original_fallback':'::TryGetValue('in method('UIModule','_GetUINode') and '::Add('in method('UIModule','_GetUINode'),
 'original_static_constructor_four_field_writes':method('UIModule','.cctor').count('stsfld')==4 and 'List`1<class GameFramework.BaseUI>::.ctor()' in method('UIModule','.cctor'),
}
assert all(checks.values()),checks
assert 'RESULT scenarios=23 checks=53 failures=0' in (OWN/'tests/actual-run.log').read_text(encoding='utf-8-sig')
assert 'RESULT scenarios=23 checks=9 failures=23' in (OWN/'tests/baseline-run.log').read_text(encoding='utf-8-sig')
build=json.loads((OWN/'compile/actual/result.json').read_text(encoding='utf-8-sig'));assert build['exitCode']==0 and build['errorCount']==0
oracle=json.loads((OWN/'native-wait-and-width-oracle.json').read_text(encoding='utf-8'));assert len(oracle['waitCases'])==2 and len(oracle['widthCases'])==6
result=dict(stage=40,status='single-source-applied-and-verified',sourceSha256=sha(SOURCE),sourceBeforeSha256=sha(BEFORE),metaSha256=sha(SOURCE.with_suffix('.cs.meta')),restoredMethods=12,fieldInitializers=5,staticConstructorFieldWrites=4,originalTokenSequencePreservedAndOriginalCctorAdded=True,originalIdentities=identities,IDAExactBoundaries=11,ILChecks=checks,actualGFCompile=build,adaptedScenarios=23,adaptedChecks=53,baselineFailures=23,nativeWaitCases=2,nativeWaitStepsPerCase=4,nativeWidthCases=6,UIRuntimeAcceptance='not-run; root owns Unity after true resource closure',remainingDependencies=['ResourcesModule.LoadPrefab typed real prefab and queue/update dispatch','ResourcesInfo.Instantiate named active clone','original scene GFUICanvas/UICamera and actual prefab RectTransform','AppSetting actual flags','other UI/close/refresh/anim methods remain outside scope'])
(OWN/'final-audit.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({k:v for k,v in result.items()if k not in{'originalIdentities','actualGFCompile'}},ensure_ascii=True,indent=2))
