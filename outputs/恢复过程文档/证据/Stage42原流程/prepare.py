import bisect
import hashlib
import json
import re
import shutil
from pathlib import Path

ROOT = Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20')
WORK = ROOT / 'work/parallel-42-fsm'
PROJECT = ROOT / 'outputs/OccupyCityRecovered'
mapping = json.loads((ROOT/'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'))
prefixes = ['GameFramework.Fsm.Fsm<object>$$', 'GameFramework.Fsm.FsmBase$$', 'GameFramework.Fsm.FsmManager$$', 'GameFramework.Fsm.FsmState<object>$$', 'GameFramework.Procedure.ProcedureManager$$', 'GameFramework.Procedure.ProcedureBase$$']
methods = [m for m in mapping['ScriptMethod'] if any(m['Name'].startswith(p) for p in prefixes)]
ends = sorted(set(mapping['Addresses']))
targets = []
for m in methods:
    # These methods contain reference parameters plus scalar float/bool/int only;
    # pointer pointee aliases do not affect the AAPCS64 calling convention.
    sig = re.sub(r'\b[A-Za-z_][A-Za-z0-9_]*\s*\*', 'void*', m['Signature'])
    sig = sig.replace('int32_t', 'int').replace('bool', 'unsigned char')
    sig = re.sub(r'const void\*', 'const MethodInfo*', sig)
    targets.append({'name': re.sub('[^a-zA-Z0-9_]', '_', m['Name'])+'_'+hex(m['Address'])[2:], 'original_name':m['Name'], 'address':m['Address'], 'end':ends[bisect.bisect_right(ends,m['Address'])], 'prototype':sig, 'original_signature':m['Signature']})
(WORK/'ida/targets-supplement.json').write_text(json.dumps(targets,ensure_ascii=False,indent=2),encoding='utf-8')
files = sorted((PROJECT/'Assets/Scripts/GFRunning/GameFramework/Fsm').glob('*.cs'))
files += [PROJECT/'Assets/Scripts/GFRunning/GameFramework/Procedure'/n for n in ['ProcedureManager.cs','ProcedureBase.cs']]
scope = {'task':'stage42','project':str(PROJECT),'methods':targets,'files':[],'existing_nonempty_bodies':[]}
for f in files:
    rel=f.relative_to(PROJECT)
    dest=WORK/'source-before'/rel
    dest.parent.mkdir(parents=True,exist_ok=True)
    if dest.exists():
        raise RuntimeError('Refusing to replace initial source snapshot: '+str(dest))
    shutil.copyfile(f,dest)
    src=f.read_text(encoding='utf-8-sig')
    tokens = re.findall(r'\[Token\(Token = "(0x[0-9A-Fa-f]+)"\)\]',src)
    scope['files'].append({'path':rel.as_posix(),'source_before_sha256':hashlib.sha256(f.read_bytes()).hexdigest(),'tokens':tokens,'meta_sha256':hashlib.sha256(Path(str(f)+'.meta').read_bytes()).hexdigest()})
    # All source is preserved byte-for-byte. Record every nonempty brace leaf,
    # including default-return stubs, so preexisting implementation is explicit.
    for match in re.finditer(r'\{([^{}]+)\}',src):
        if match.group(1).strip():
            scope['existing_nonempty_bodies'].append({'file':rel.as_posix(),'line':src[:match.start()].count('\n')+1,'text':match.group(1).strip()})
(WORK/'owned-scope.json').write_text(json.dumps(scope,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({'files':len(files),'native_targets':len(targets),'nonempty_leaf_bodies':len(scope['existing_nonempty_bodies'])}))
