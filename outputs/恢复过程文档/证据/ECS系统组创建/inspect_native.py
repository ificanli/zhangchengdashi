"""Read-only ARM64 consumer-chain evidence from original ELF + recovered metadata."""
import bisect
import hashlib
import json
import struct
import sys
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]
sys.path.insert(0, str(ROOT / 'work/tools/legacy-inspection'))
import capstone
from capstone.arm64 import ARM64_OP_IMM, ARM64_OP_MEM, ARM64_OP_REG

OUT = ROOT / 'work/ecs-group-recovery'
OUT.mkdir(exist_ok=True)
mapping = json.loads((ROOT/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
method_map = {e['Address']: e for e in mapping['ScriptMethod']}
boundaries = sorted(set(mapping['Addresses']))
metadata_map = {}
for category in ('ScriptMetadata','ScriptMetadataMethod','ScriptString'):
    for row in mapping.get(category,[]):
        metadata_map[row['Address']] = {'category':category, **row}

TARGETS = []
ELF=ROOT/'work/ida-input/libil2cpp-arm64.so'
raw=ELF.read_bytes()
assert raw[:6] == b'\x7fELF\x02\x01'
phoff=struct.unpack_from('<Q',raw,32)[0]
phsize,phnum=struct.unpack_from('<HH',raw,54)
segments=[struct.unpack_from('<IIQQQQQQ',raw,phoff+i*phsize) for i in range(phnum)]
shoff=struct.unpack_from('<Q',raw,40)[0]
shsize,shnum=struct.unpack_from('<HH',raw,58)
sections=[struct.unpack_from('<IIQQQQIIQQ',raw,shoff+i*shsize) for i in range(shnum)]
relocations={}
for section in sections:
    if section[1]!=4: continue
    for pos in range(section[4],section[4]+section[5],section[9] or 24):
        offset,info,addend=struct.unpack_from('<QQq',raw,pos)
        if info & 0xffffffff==1027: relocations[offset]=addend

def read_rva(start,size):
    seg=next(s for s in segments if s[0]==1 and s[3]<=start and start+size<=s[3]+s[5])
    off=seg[2]+start-seg[3]
    return raw[off:off+size]

def dump_method(entry):
    start=entry['Address']; index=bisect.bisect_right(boundaries,start); end=boundaries[index]
    data=read_rva(start,end-start)
    md=capstone.Cs(capstone.CS_ARCH_ARM64,capstone.CS_MODE_LITTLE_ENDIAN); md.detail=True
    registers={}; lines=[]; calls=[]; refs=[]
    for insn in md.disasm(data,start):
        comment=[]; ops=insn.operands
        if insn.mnemonic in ('adrp','adr') and len(ops)>1 and ops[1].type==ARM64_OP_IMM:
            registers[insn.reg_name(ops[0].reg)]=ops[1].imm
        elif insn.mnemonic=='add' and len(ops)>2 and ops[2].type==ARM64_OP_IMM:
            src=insn.reg_name(ops[1].reg); dst=insn.reg_name(ops[0].reg)
            if src in registers:
                registers[dst]=registers[src]+ops[2].imm
                ref=metadata_map.get(registers[dst])
                if ref: refs.append({'instruction':hex(insn.address),'slot':hex(registers[dst]),**ref}); comment.append(ref.get('Name',ref.get('Value','')))
        elif insn.mnemonic in ('ldr','ldur') and len(ops)>1 and ops[1].type==ARM64_OP_MEM:
            base=insn.reg_name(ops[1].mem.base)
            if base in registers:
                slot=registers[base]+ops[1].mem.disp; actual=relocations.get(slot,slot); ref=metadata_map.get(actual)
                if ref: refs.append({'instruction':hex(insn.address),'loadedFrom':hex(slot),'slot':hex(actual),**ref}); comment.append(ref.get('Name',ref.get('Value','')))
            registers.pop(insn.reg_name(ops[0].reg),None)
        elif insn.mnemonic in ('b','bl') and ops and ops[0].type==ARM64_OP_IMM:
            dest=ops[0].imm; target=method_map.get(dest)
            if target:
                calls.append({'instruction':hex(insn.address),'destination':hex(dest),**target}); comment.append(target['Name'])
        lines.append(f'{insn.address:#x}: {insn.bytes.hex()} {insn.mnemonic:<8} {insn.op_str}'+(' // '+'; '.join(comment) if comment else ''))
    file=OUT/(hex(start)+'.asm.txt'); file.write_text('\n'.join(lines)+'\n',encoding='utf-8')
    return {'name':entry['Name'],'address':hex(start),'end':hex(end),'bytes':len(data),'codeSha256':hashlib.sha256(data).hexdigest(),'assembly':file.relative_to(ROOT).as_posix(),'directCalls':calls,'metadataReferences':refs}

entries=[e for e in mapping['ScriptMethod'] if e['Name'].startswith('Pathfinding.ECS.AIMovementSystemGroup') or e['Address'] in {0x7E47174,0x7E4717C}]
report={'elfSha256':hashlib.sha256(raw).hexdigest(),'decoder':'capstone '+capstone.__version__,'scope':'Read-only original ARM64 bytes; method boundaries from recovered script.json; declarations are not treated as recovered bodies.','methods':[dump_method(e) for e in entries],'notFound':[n for n in TARGETS if not any(e['Name']==n for e in entries)]}
(OUT/'native-consumer-evidence.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps([{'name':r['name'],'address':r['address'],'calls':len(r['directCalls']),'refs':len(r['metadataReferences'])} for r in report['methods']],ensure_ascii=True,indent=2))
