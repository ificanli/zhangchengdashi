import json
import shutil
from pathlib import Path

ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/stage37-entry'
IDA=OWN/'ida'
IDA.mkdir(parents=True,exist_ok=True)
mapping=json.loads((ROOT/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
boundaries=sorted(mapping['Addresses'])
selected={0x4C8C90C,0x715BAE8,0x715B144,0x715B260,0x715B350,0x72E8B14,0x72E6FBC,0x72EA93C,0x72EAB28,0x72E7FF4,0x72E5690,0x72E75A0,0x72EAE70,0x72EAE78,0x72EAE90,0x439B9B0,0x439B9F4,0x439BC8C,0x439BD18,0x439BEE4,0x439C028,0x439C0BC,0x715BD8C,0x72E86A4,0x72E5DD0}
statics={0x4C8C90C,0x715BAE8,0x715B144,0x715B260,0x715B350}
targets=[]
for row in mapping['ScriptMethod']:
    address=row['Address']
    if address not in selected:continue
    returns='void*' if address in {0x4C8C90C,0x439BD18} else 'unsigned char' if address==0x439C0BC else 'void'
    args=[] if address in statics else ['void* self']
    if address in {0x72E7FF4,0x439B9B0}:args.append('void* resources')
    if address==0x439BD18:args.append('void* callback')
    if address in {0x715B144,0x715B260}:args+=['float elapsed','float realElapsed']
    args.append('const MethodInfo* method')
    targets.append(dict(name=row['Name'],address=address,end=next(a for a in boundaries if a>address),signature=row['Signature'],prototype=f'{returns} Entry_{address:x}('+','.join(args)+');'))
(IDA/'targets.json').write_text(json.dumps(targets,indent=2),encoding='utf-8')
script=(ROOT/'work/gamemanager-recovery/ida/analyze.py').read_text(encoding='utf-8').replace('work\\gamemanager-recovery\\ida','work\\stage37-entry\\ida')
(IDA/'analyze.py').write_text(script,encoding='utf-8')
shutil.copy2(ROOT/'work/gamemanager-recovery/ida/minimal-types.h',IDA/'minimal-types.h')
annotator=(ROOT/'work/gamemanager-recovery/annotate_native.py').read_text().replace('work/gamemanager-recovery','work/stage37-entry')
(OWN/'annotate_native.py').write_text(annotator,encoding='utf-8')
print('prepared',len(targets),'bounded entry methods')
