import json
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gamemanager-recovery';mapping=json.loads((root/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));ends=sorted(mapping['Addresses']);targets=[]
for m in mapping['ScriptMethod']:
    a=m['Address']
    if a not in {0x3E1D2F0,0x3E1AB50}:continue
    targets.append(dict(name=m['Name'],address=a,end=next(e for e in ends if e>a),signature=m['Signature'],prototype=('void* GM_Reward(void* self, unsigned char win, const MethodInfo* method);' if a==0x3E1AB50 else 'void GM_Init_MoveNext(void* self, const MethodInfo* method);')))
(own/'ida/targets-large.json').write_text(json.dumps(targets,indent=2),encoding='utf-8');script=(own/'ida/analyze.py').read_text(encoding='utf-8').replace('targets.json','targets-large.json').replace('status-bounded.json','status-large-once.json');(own/'ida/analyze_large_once.py').write_text(script,encoding='utf-8');print('Prepared 2 one-shot large methods; complete original ASM already saved')
