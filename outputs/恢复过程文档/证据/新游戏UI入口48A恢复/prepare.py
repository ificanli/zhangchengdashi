import json
import shutil
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];OWN=ROOT/'work/stage48-new-ui';OWN.mkdir(exist_ok=True);IDA=OWN/'ida';IDA.mkdir(exist_ok=True)
SOURCE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/UIFramework/UIManager.cs';BEFORE=OWN/'source-before';BEFORE.mkdir(exist_ok=True)
for path in [SOURCE,SOURCE.with_suffix('.cs.meta')]:
    target=BEFORE/path.name
    if not target.exists():shutil.copy2(path,target)
helper=(ROOT/'work/gamemanager-recovery/inspect_native.py').read_text(encoding='utf-8').replace('work/gamemanager-recovery','work/stage48-new-ui')
helper=helper.replace("entries=[e for e in mapping['ScriptMethod'] if e['Name'].startswith('GameModule.GameManager') ]","entries=[e for e in mapping['ScriptMethod'] if e['Name'].startswith('UIFramework.UIManager') or e['Address'] in {0x427520C,0x4275214,0x4275278,0x4275280,0x42752A0,0x4275334,0x4275338,0x4275744,0x42753BC,0x4275658,0x4275660}]")
(OWN/'inspect_native.py').write_text(helper,encoding='utf-8')
mapping=json.loads((ROOT/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));ends=sorted(mapping['Addresses']);targets=[]
selected={0x4275B7C,0x4275C18,0x4275C9C,0x4275D78,0x4275E1C,0x4275E74,0x4275FEC,0x42760D8,0x4276180,0x4276218,0x4276314,0x4276644,0x42766FC,0x42767AC,0x4276F18,0x42771B0,0x4277A28,0x4276B58,0x4275658,0x42753BC,0x4275744}
for row in mapping['ScriptMethod']:
    a=row['Address']
    if a not in selected:continue
    extra=''
    if a in{0x4275C9C,0x4275E1C,0x4275FEC,0x4276180,0x4276218,0x4276644}:extra='void* path,'
    if a==0x4275D78:extra='void* path,void** panel,'
    if a==0x4275E74:extra='void* path,void* panel,'
    if a==0x42760D8:extra='void* path,void* args,'
    if a==0x4276314:extra='void* go,int layer,'
    if a==0x4275658:extra='void* config,'
    returns='void*'if a in{0x4275B7C,0x4275C9C,0x4275FEC,0x4276644}else'unsigned char'if a in{0x4275D78,0x4275E1C}else'void'
    if a in{0x4275C18,0x4275C9C,0x42760D8,0x4276180}:returns='void' # async factory ABI uses structs; full signature is recorded, logic comes from MoveNext.
    targets.append(dict(name=row['Name'],address=a,end=next(e for e in ends if e>a),signature=row['Signature'],prototype=f'{returns} NewUI_{a:x}(void* self,'+extra+'const MethodInfo* method);'))
(IDA/'targets.json').write_text(json.dumps(targets,indent=2),encoding='utf-8')
analyzer=(ROOT/'work/gamemanager-recovery/ida/analyze.py').read_text(encoding='utf-8').replace('work\\gamemanager-recovery\\ida','work\\stage48-new-ui\\ida')
(IDA/'analyze.py').write_text(analyzer,encoding='utf-8');shutil.copy2(ROOT/'work/gamemanager-recovery/ida/minimal-types.h',IDA/'minimal-types.h')
annotator=(ROOT/'work/gamemanager-recovery/annotate_native.py').read_text(encoding='utf-8').replace('work/gamemanager-recovery','work/stage48-new-ui');(OWN/'annotate_native.py').write_text(annotator,encoding='utf-8')
print('prepared',len(targets),'original native targets; production untouched')
