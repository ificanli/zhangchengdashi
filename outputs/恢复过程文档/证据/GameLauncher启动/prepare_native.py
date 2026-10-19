import json
from pathlib import Path
root = Path(__file__).resolve().parents[2]
own = root / 'work/game-launcher-recovery/ida'
data = json.loads((root/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
addresses = sorted(data['Addresses'])
selected = {0x41914F8, 0x4191894, 0x41919FC, 0x41918A4, 0x4190FFC, 0x4191AD0, 0x4191BDC, 0x4191D50, 0x4191EA4, 0x4192068, 0x41922E0, 0x4C8CDC0, 0x4C8CF78}
targets=[]
for method in data['ScriptMethod']:
    a=method['Address']
    if a not in selected: continue
    row={'name':method['Name'],'address':a,'end':next(e for e in addresses if e>a),'signature':method['Signature']}
    row['prototype']=('unsigned char' if a in {0x4191EA4,0x4192068} else 'void')+f' Recovered_{a:x}(void* self, '+ ('void* asset, void* name, unsigned char active, ' if a==0x4191EA4 else 'void* asset, void** result, ' if a==0x4192068 else 'void* asset, ' if a in {0x4191AD0,0x4191BDC} else 'void* obj, ' if a==0x4191894 else '')+'const MethodInfo* method);'
    if a in {0x4C8CDC0,0x4C8CF78}:
        row['prototype']=f'unsigned char Recovered_{a:x}(void* self, void* target, void* propertyName, void* fieldName, '+('unsigned char value' if a==0x4C8CDC0 else 'void* value')+', const MethodInfo* method);'
    targets.append(row)
(own/'targets.json').write_text(json.dumps(targets,indent=2),encoding='utf-8')
script=(root/'work/ida-constructor-recovery/analyze.py').read_text(encoding='utf-8')
script=script.replace('work\\ida-constructor-recovery','work\\game-launcher-recovery\\ida')
(own/'analyze.py').write_text(script,encoding='utf-8')
print(len(targets),'native targets prepared')
