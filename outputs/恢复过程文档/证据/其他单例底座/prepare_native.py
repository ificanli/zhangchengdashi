import json,shutil
from pathlib import Path
root=Path(__file__).resolve().parents[2]
own=root/'work/other-singleton-recovery'
ida=own/'ida';ida.mkdir(exist_ok=True)
data=json.loads((root/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
addresses=sorted(data['Addresses'])
namespaces={0x5FBE9CC:'L_Tools.Singleton<T>.Instance',0x5FBE6D4:'L_Tools.Singleton<T>.SingletonCreator.cctor',0x5FBE6CC:'L_Tools.Singleton<T>.SingletonCreator.ctor',0x5FBEA38:'L_Tools.Singleton<T>.ctor',0x5FBEB64:'QuickTutor.Singleton<T>.Instance',0x5FBEC60:'QuickTutor.Singleton<T>.cctor',0x513BB8C:'QuickTutor.Singleton<T>.cctor.factory',0x5FBEB5C:'QuickTutor.Singleton<T>.ctor',0x408159C:'LocalizationModule.Runtime.CustomBundlesManager.Instance',0x4081B04:'LocalizationModule.Runtime.CustomBundlesManager.ctor'}
statics={0x5FBE9CC,0x5FBE6D4,0x5FBEB64,0x5FBEC60,0x408159C}
returns={0x5FBE9CC,0x5FBEB64,0x513BB8C,0x408159C}
targets=[]
for m in data['ScriptMethod']:
    a=m['Address']
    if a not in namespaces:continue
    row={'name':m['Name'],'owning_type_and_member':namespaces[a],'address':a,'end':next(x for x in addresses if x>a),'signature':m['Signature'],'prototype':('void*' if a in returns else 'void')+f' OtherSingleton_{a:x}('+('' if a in statics else 'void* self, ')+'const MethodInfo* method);'}
    targets.append(row)
(ida/'targets.json').write_text(json.dumps(targets,indent=2),encoding='utf-8')
script=(root/'work/ida-constructor-recovery/analyze.py').read_text(encoding='utf-8').replace('work\\ida-constructor-recovery','work\\other-singleton-recovery\\ida')
(ida/'analyze.py').write_text(script,encoding='utf-8')
shutil.copyfile(root/'work/ida-targeted/minimal-types.h',ida/'minimal-types.h')
print(len(targets),'targets prepared')
