import difflib,hashlib,json
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/other-singleton-recovery'
original=root/'work/recovery-stubs/other-singletons-before';source=root/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp'
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
mapping={'L_Tools/Singleton.cs':'L_Tools.Singleton.cs','QuickTutor/Singleton.cs':'QuickTutor.Singleton.cs','LocalizationModule/Runtime/CustomBundlesManager.cs':'CustomBundlesManager.cs'}
rows=[];diffs=[]
for relative,backup in mapping.items():
    path=source/relative;before=original/backup
    row={'path':relative,'before_sha256':sha(before),'after_sha256':sha(path),'meta_before_sha256':sha(original/(backup+'.meta')),'meta_after_sha256':sha(path.with_suffix('.cs.meta'))}
    assert row['meta_before_sha256']==row['meta_after_sha256'];rows.append(row)
    diffs.extend(difflib.unified_diff(before.read_text(encoding='utf-8-sig').splitlines(),path.read_text(encoding='utf-8-sig').splitlines(),fromfile='before/'+relative,tofile='after/'+relative,lineterm=''))
(own/'source.diff').write_text('\n'.join(diffs),encoding='utf-8')
il=(own/'compile/compiled.il.txt').read_text(encoding='utf-8-sig')
checks={'actual_generic_new_uses_Activator_twice':il.count('System.Activator::CreateInstance<!T>()')==2,'Lazy_factory_only_overload':'System.Lazy`1<!T>::.ctor(class [netstandard]System.Func`1<!0>)' in il,'Lazy_Value':'System.Lazy`1<!T>::get_Value()' in il,'Unity_Equality':'UnityEngine.Object::op_Equality(' in il,'Unity_GameObject_original_name':'ldstr "CustomBundlesManager"' in il,'Unity_AddComponent_correct_type':'AddComponent<class LocalizationModule.Runtime.CustomBundlesManager>()' in il,'Unity_DontDestroy':'UnityEngine.Object::DontDestroyOnLoad(' in il,'Custom_ctor_calls_original_base':'I2.Loc.RegisterBundlesManager::.ctor()' in il}
assert all(checks.values()),checks
native=json.loads((own/'ida/status-bounded.json').read_text(encoding='utf-8'))
assert native['stage']=='complete' and len(native['methods'])==10
assert all(m['actual_function_start']==hex(m['address']) and m['actual_function_end']==hex(m['end']) for m in native['methods'])
audit={'sources':rows,'IL_checks':checks,'native_boundary_checks':10,'production_business_flags_changed':False,'Unity_runtime_validation':'not-run; no lifecycle claims from .NET tests or IL'}
(own/'source-meta-il-audit.json').write_text(json.dumps(audit,indent=2),encoding='utf-8')
print(json.dumps(audit,indent=2))
