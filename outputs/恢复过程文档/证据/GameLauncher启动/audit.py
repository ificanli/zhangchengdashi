import hashlib,json,re
from pathlib import Path
root=Path(__file__).resolve().parents[2]
own=root/'work/game-launcher-recovery'
source=root/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/CoreModule/GameLauncher.cs'
before=root/'work/recovery-stubs/game-launcher-before'
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
il=(own/'compile/GameLauncher.compiled.il.txt').read_text(encoding='utf-8-sig')
expected={'InitBaseManager':3,'Start':1,'Login':1,'GameLogic':1,'RunInitManager':1,'InitManager':11,'InitGame':1}
asyncs=[]
for method,count in expected.items():
    match=re.search(r"\t\.class nested[^\n]*'<"+method+r">d__\d+'",il)
    stop=il.index('\n\t} // end of class',match.start())
    block=il[match.start():stop]
    awaits=block.count('::AwaitUnsafeOnCompleted<')
    asyncs.append({'method':method,'awaits':awaits,'expected_awaits':count,'set_exception': '::SetException(' in block,'set_result':'::SetResult(' in block})
    assert awaits==count
    assert asyncs[-1]['set_exception'] and asyncs[-1]['set_result']
assert il.count('AsyncStateMachineAttribute::.ctor')==7
body=(own/'fixture-source-hashes.json').read_text(encoding='utf-8')
audit={'source_sha256':sha(source),'before_sha256':sha(before/'GameLauncher.cs'),'meta_sha256':sha(source.with_suffix('.cs.meta')),'before_meta_sha256':sha(before/'GameLauncher.cs.meta'),'restored_method_count':len(json.loads(body)['methods']),'compiled_async_state_machines':asyncs,'compiled_async_attributes':7,'empty_exported_state_machines':'Retained as provenance with no AsyncStateMachineAttribute or runtime entry. Not counted as restored.','validation':'Actual source independently compiled with real Unity 2022.3/URP14/UniTask; Task-adapted source fixture tests only source control flow, not Unity or production managers.'}
assert audit['meta_sha256']==audit['before_meta_sha256']
(own/'source-il-audit.json').write_text(json.dumps(audit,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps(audit,ensure_ascii=False,indent=2))
