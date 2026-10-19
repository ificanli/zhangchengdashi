"""Read-only original ELF call/reference audit for external unit-production consumers."""
import bisect,hashlib,json,struct,sys
from pathlib import Path
ROOT=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20')
OUT=ROOT/'work/parallel-44-battle/scene-validation/consumer-chain';OUT.mkdir(exist_ok=True)
sys.path.insert(0,str(ROOT/'work/tools/legacy-inspection'))
import capstone
from capstone.arm64 import ARM64_OP_IMM,ARM64_OP_MEM
mapping=json.loads((ROOT/'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'))
methods={x['Address']:x for x in mapping['ScriptMethod']};bounds=sorted(set(mapping['Addresses']))
metadata={x['Address']:dict(category=k,**x) for k in ('ScriptMetadata','ScriptMetadataMethod','ScriptString') for x in mapping[k]}
raw=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes()
phoff=struct.unpack_from('<Q',raw,32)[0];phsize,phnum=struct.unpack_from('<HH',raw,54)
segs=[struct.unpack_from('<IIQQQQQQ',raw,phoff+i*phsize) for i in range(phnum)]
shoff=struct.unpack_from('<Q',raw,40)[0];shsize,shnum=struct.unpack_from('<HH',raw,58)
sections=[struct.unpack_from('<IIQQQQIIQQ',raw,shoff+i*shsize) for i in range(shnum)]
relocs={}
for s in sections:
    if s[1]!=4:continue
    for p in range(s[4],s[4]+s[5],s[9] or 24):
        target,info,addend=struct.unpack_from('<QQq',raw,p)
        if info&0xffffffff==1027:relocs[target]=addend
def read_rva(a,n):
    s=next(s for s in segs if s[0]==1 and s[3]<=a and a+n<=s[3]+s[5]);off=s[2]+a-s[3]
    return raw[off:off+n]
selected=[x for x in methods.values() if x['Name'].startswith(('GameModule.CoreGameManager','GameModule.BarracksArchitectureBehaviour')) and not x['Name'].endswith('$$SetStateMachine')]
def export(x):
    start=x['Address'];end=bounds[bisect.bisect_right(bounds,start)];code=read_rva(start,end-start)
    md=capstone.Cs(capstone.CS_ARCH_ARM64,capstone.CS_MODE_LITTLE_ENDIAN);md.detail=True
    registers={};calls=[];refs=[];lines=[]
    for insn in md.disasm(code,start):
        ops=insn.operands;comment=[]
        if insn.mnemonic in ('adrp','adr') and len(ops)>1 and ops[1].type==ARM64_OP_IMM:
            registers[insn.reg_name(ops[0].reg)]=ops[1].imm
        elif insn.mnemonic=='add' and len(ops)>2 and ops[2].type==ARM64_OP_IMM:
            src=insn.reg_name(ops[1].reg);dst=insn.reg_name(ops[0].reg)
            if src in registers:
                registers[dst]=registers[src]+ops[2].imm
                ref=metadata.get(registers[dst])
                if ref:refs.append(dict(instruction=hex(insn.address),**ref));comment.append(ref.get('Name',ref.get('Value','')))
        elif insn.mnemonic in ('ldr','ldur') and len(ops)>1 and ops[1].type==ARM64_OP_MEM:
            base=insn.reg_name(ops[1].mem.base)
            if base in registers:
                slot=registers[base]+ops[1].mem.disp;actual=relocs.get(slot,slot);ref=metadata.get(actual)
                if ref:refs.append(dict(instruction=hex(insn.address),loadedFrom=hex(slot),**ref));comment.append(ref.get('Name',ref.get('Value','')))
            registers.pop(insn.reg_name(ops[0].reg),None)
        elif insn.mnemonic in ('bl','b') and ops and ops[0].type==ARM64_OP_IMM:
            target=methods.get(ops[0].imm)
            if target:calls.append(dict(instruction=hex(insn.address),**target));comment.append(target['Name'])
        lines.append(f'{insn.address:#x}: {insn.bytes.hex()} {insn.mnemonic:<8} {insn.op_str}'+(' // '+'; '.join(comment) if comment else ''))
    (OUT/(hex(start)+'.asm.txt')).write_text('\n'.join(lines)+'\n',encoding='utf-8')
    return dict(name=x['Name'],signature=x['Signature'],address=hex(start),end=hex(end),code_sha256=hashlib.sha256(code).hexdigest(),calls=calls,metadata_references=refs)
rows=[export(x) for x in selected]
report=dict(elf_sha256=hashlib.sha256(raw).hexdigest(),scope='Original ELF plus exact script.json method bounds; external sources read-only; call and metadata references are evidence, not recovered methods.',methods=rows)
(OUT/'consumer-chain.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
for row in rows:
    if '.<StartGame>' in row['name'] or '.<LoadRoleAssets>' in row['name'] or '.<CreatRole>' in row['name']:
        print(row['name'],row['address']);print('  Calls: '+' | '.join(x['Name'] for x in row['calls'] if any(w in x['Name'] for w in ('SceneManager','RoleBehaviour','Barracks','LoadAsset','CoreGame','CreatRole','Spawn','Instantiate'))))
        print('  Strings: '+' | '.join(dict.fromkeys(x['Value'] for x in row['metadata_references'] if x['category']=='ScriptString')))
print('CONSUMER_CHAIN methods='+str(len(rows)))
