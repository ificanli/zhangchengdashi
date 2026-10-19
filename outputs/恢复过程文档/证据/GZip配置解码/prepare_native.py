import json,shutil
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gzip-recovery';ida=own/'ida';ida.mkdir(parents=True,exist_ok=True)
data=json.loads((root/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));ends=sorted(data['Addresses']);targets=[]
for m in data['ScriptMethod']:
    if not m['Name'].startswith('ToolModule.GZipTool$$') and m['Address']!=0x4D652A0:continue
    a=m['Address'];cctor=m['Name'].endswith('$$.cctor')
    targets.append(dict(name=m['Name'],address=a,end=next(x for x in ends if x>a),signature=m['Signature'],prototype=('unsigned char' if a==0x4D652A0 else 'void' if cctor else 'void*')+f' GZip_{a:x}('+('' if cctor else 'void* input, ')+'const MethodInfo* method);'))
(ida/'targets.json').write_text(json.dumps(targets,indent=2),encoding='utf-8')
script=(root/'work/ida-framework-assets/analyze_supplement.py').read_text(encoding='utf-8').replace('work\\ida-framework-assets','work\\gzip-recovery\\ida').replace('targets-supplement.json','targets.json').replace('status-supplement.json','status-bounded.json')
(ida/'analyze.py').write_text(script,encoding='utf-8');shutil.copyfile(root/'work/ida-targeted/minimal-types.h',ida/'minimal-types.h');print('Prepared',len(targets),'GZip targets')
