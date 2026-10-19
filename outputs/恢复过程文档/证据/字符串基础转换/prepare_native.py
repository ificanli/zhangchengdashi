import json,shutil
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/stringtool-recovery';ida=own/'ida';ida.mkdir(parents=True,exist_ok=True)
data=json.loads((root/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));ends=sorted(data['Addresses']);targets=[]
for m in data['ScriptMethod']:
    a=m['Address']
    if a not in {0x3F73A70,0x3F75418}:continue
    targets.append(dict(name=m['Name'],address=a,end=next(e for e in ends if e>a),signature=m['Signature'],prototype=('int' if a==0x3F73A70 else 'unsigned char')+f' StringTool_{a:x}(void* value, '+('unsigned char trimSpaces, ' if a==0x3F75418 else '')+'const MethodInfo* method);'))
(ida/'targets.json').write_text(json.dumps(targets,indent=2),encoding='utf-8')
script=(root/'work/ida-framework-assets/analyze_supplement.py').read_text(encoding='utf-8').replace('work\\ida-framework-assets','work\\stringtool-recovery\\ida').replace('targets-supplement.json','targets.json').replace('status-supplement.json','status-bounded.json')
(ida/'analyze.py').write_text(script,encoding='utf-8');shutil.copyfile(root/'work/ida-targeted/minimal-types.h',ida/'minimal-types.h');print('Prepared',len(targets),'StringTool targets')
