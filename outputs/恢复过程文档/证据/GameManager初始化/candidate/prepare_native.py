import json,shutil
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gamemanager-recovery';own.mkdir(parents=True,exist_ok=True);ida=own/'ida';ida.mkdir(exist_ok=True)
inspector=(root/'work/new-config-restore/inspect_native.py').read_text(encoding='utf-8').replace("work/new-config-restore","work/gamemanager-recovery")
start=inspector.index('entries=[e for e in mapping[\'ScriptMethod\']')
stop=inspector.index('\nreport=',start)
inspector=inspector[:start]+"entries=[e for e in mapping['ScriptMethod'] if e['Name'].startswith('GameModule.GameManager') ]"+inspector[stop:]
(own/'inspect_native.py').write_text(inspector,encoding='utf-8')
data=json.loads((root/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));ends=sorted(data['Addresses']);targets=[]
selected={0x3E1984C,0x3E198F0,0x3E19BC0,0x3E1CF94,0x3E1A918,0x3E1A9EC,0x3E1AA70,0x3E19DC4,0x3E1A2C4}
for m in data['ScriptMethod']:
    a=m['Address']
    if a not in selected:continue
    isObj=a in {0x3E19BC0,0x3E1A918,0x3E1A9EC};extra='void* action, ' if a==0x3E1984C else 'void* obj, ' if isObj else ''
    targets.append(dict(name=m['Name'],address=a,end=next(e for e in ends if e>a),signature=m['Signature'],prototype=f'void GameManager_{a:x}(void* self, '+extra+'const MethodInfo* method);'))
(ida/'targets.json').write_text(json.dumps(targets,indent=2),encoding='utf-8')
script=(root/'work/ida-framework-assets/analyze_supplement.py').read_text(encoding='utf-8').replace('work\\ida-framework-assets','work\\gamemanager-recovery\\ida').replace('targets-supplement.json','targets.json').replace('status-supplement.json','status-bounded.json')
(ida/'analyze.py').write_text(script,encoding='utf-8');shutil.copyfile(root/'work/ida-targeted/minimal-types.h',ida/'minimal-types.h');print('Prepared complete ASM scanner and',len(targets),'short IDA methods; large Init excluded from Hex-Rays')
