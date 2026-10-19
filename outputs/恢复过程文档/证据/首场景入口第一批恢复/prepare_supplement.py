import json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/stage37-entry'
mapping=json.loads((ROOT/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
ends=sorted(mapping['Addresses'])
selected={0x72E692C,0x72E58F4,0x72E6B44,0x72E7EA8}
targets=[]
for row in mapping['ScriptMethod']:
    a=row['Address']
    if a not in selected:continue
    args='void* self,'+('void* args,' if a in {0x72E58F4,0x72E7EA8} else '')+'const MethodInfo* method'
    targets.append(dict(name=row['Name'],address=a,end=next(e for e in ends if e>a),signature=row['Signature'],prototype=f'void Entry_{a:x}({args});'))
(OWN/'ida/targets-supplement.json').write_text(json.dumps(targets,indent=2),encoding='utf-8')
script=(OWN/'ida/analyze.py').read_text(encoding='utf-8').replace('targets.json','targets-supplement.json').replace('status-bounded.json','status-supplement.json')
(OWN/'ida/analyze_supplement.py').write_text(script,encoding='utf-8')
for a in ['0x715af54','0x715af7c','0x4c8c5c0','0x715b680','0x715b7c8']:
    for suffix in ['.c','.asm.txt']:
        target=OWN/'ida/pseudocode'/(a+suffix)
        target.write_bytes((ROOT/'work/ida-framework-assets/pseudocode'/(a+suffix)).read_bytes())
helper=(ROOT/'work/gamemanager-recovery/inspect_native.py').read_text(encoding='utf-8').split("entries=[e for e in mapping['ScriptMethod']")[0].replace('work/gamemanager-recovery','work/stage37-entry')
exec(compile(helper,str(__file__)+':native','exec'))
from capstone.arm64 import ARM64_OP_IMM
md=capstone.Cs(capstone.CS_ARCH_ARM64,capstone.CS_MODE_LITTLE_ENDIAN)
md.detail=True
lines=[]
for ins in md.disasm(read_rva(0x856EAF8,0x30),0x856EAF8):
    lines.append(f'{ins.address:#x}: {ins.bytes.hex()} {ins.mnemonic} {ins.op_str}')
    if ins.mnemonic=='b':break
(OWN/'Start-outlined-block.asm.txt').write_text('\n'.join(lines),encoding='utf-8')
print('supplement',len(targets),'methods; Start outlined block:\n'+'\n'.join(lines))
