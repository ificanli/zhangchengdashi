"""Read-only task 41 source/row dependency inventory; no Unity or IDA use."""
import bisect
import hashlib
import json
import re
import struct
import sys
from pathlib import Path

ROOT = Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20')
PROJECT = ROOT / 'outputs/OccupyCityRecovered'
OUT = ROOT / 'work/parallel-41-config/evidence/source-chain'
sys.path.insert(0, str(ROOT / 'work/tools/legacy-inspection'))
import capstone
from capstone.arm64 import ARM64_OP_IMM, ARM64_OP_MEM

OUT.mkdir(parents=True, exist_ok=True)
source = PROJECT / 'Assets/Scripts/Assembly-CSharp/ljzs_lt/ConfigMgr.cs'
mgr = source.read_text(encoding='utf-8-sig')
types = re.findall(r'public readonly Dictionary<object, ([\w]+)> (\w+);', mgr)
types += [(t, f) for t, f in re.findall(r'public (SettingConfig|WorldCupbaseConfigConfig|BaseConfigConfig) (\w+);', mgr)]
mapping = json.loads((ROOT / 'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
methods = {r['Name']: r for r in mapping['ScriptMethod']}
method_rvas = {r['Address']: r for r in mapping['ScriptMethod']}
boundaries = sorted(set(mapping['Addresses']))
refs = {}
for category in ('ScriptMetadata', 'ScriptMetadataMethod', 'ScriptString'):
    for row in mapping.get(category, []):
        refs[row['Address']] = {'category': category, **row}
raw = (ROOT / 'work/ida-input/libil2cpp-arm64.so').read_bytes()
phoff = struct.unpack_from('<Q', raw, 32)[0]
phsize, phnum = struct.unpack_from('<HH', raw, 54)
segments = [struct.unpack_from('<IIQQQQQQ', raw, phoff+i*phsize) for i in range(phnum)]
shoff = struct.unpack_from('<Q', raw, 40)[0]
shsize, shnum = struct.unpack_from('<HH', raw, 58)
sections = [struct.unpack_from('<IIQQQQIIQQ', raw, shoff+i*shsize) for i in range(shnum)]
relocations = {}
for s in sections:
    if s[1] != 4:
        continue
    for pos in range(s[4], s[4]+s[5], s[9] or 24):
        offset, info, addend = struct.unpack_from('<QQq', raw, pos)
        if info & 0xffffffff == 1027:
            relocations[offset] = addend

def read_rva(start, size):
    seg = next(s for s in segments if s[0] == 1 and s[3] <= start and start+size <= s[3]+s[5])
    offset = seg[2]+start-seg[3]
    return raw[offset:offset+size]

def dump_method(name):
    m = methods[name]
    start = m['Address']
    end = boundaries[bisect.bisect_right(boundaries, start)]
    body = read_rva(start, end-start)
    md = capstone.Cs(capstone.CS_ARCH_ARM64, capstone.CS_MODE_LITTLE_ENDIAN)
    md.detail = True
    registers = {}
    lines, calls, metadata, member_loads = [], [], [], []
    for insn in md.disasm(body, start):
        ops = insn.operands
        comments = []
        if insn.mnemonic in ('adrp', 'adr') and len(ops) > 1 and ops[1].type == ARM64_OP_IMM:
            registers[insn.reg_name(ops[0].reg)] = ops[1].imm
        elif insn.mnemonic == 'add' and len(ops) > 2 and ops[2].type == ARM64_OP_IMM:
            dst, src = insn.reg_name(ops[0].reg), insn.reg_name(ops[1].reg)
            if src in registers:
                registers[dst] = registers[src] + ops[2].imm
        elif insn.mnemonic in ('ldr', 'ldur') and len(ops) > 1 and ops[1].type == ARM64_OP_MEM:
            base = insn.reg_name(ops[1].mem.base)
            if base in ('x0', 'x19', 'x20'):
                member_loads.append({'instruction': hex(insn.address), 'destination': insn.reg_name(ops[0].reg), 'base': base, 'offset': hex(ops[1].mem.disp)})
            if base in registers:
                slot = registers[base] + ops[1].mem.disp
                actual = relocations.get(slot, slot)
                ref = refs.get(actual)
                if ref:
                    metadata.append({'instruction': hex(insn.address), 'slot': hex(actual), **ref})
                    comments.append(ref.get('Name', ref.get('Value', '')))
            registers.pop(insn.reg_name(ops[0].reg), None)
        elif insn.mnemonic in ('b', 'bl') and ops and ops[0].type == ARM64_OP_IMM:
            target = method_rvas.get(ops[0].imm)
            if target:
                calls.append({'instruction': hex(insn.address), **target})
                comments.append(target['Name'])
        lines.append(f'{insn.address:#x}: {insn.bytes.hex()} {insn.mnemonic:<8} {insn.op_str}'+(' // '+'; '.join(comments) if comments else ''))
    file = OUT / 'row-native' / (hex(start)+'.asm.txt')
    file.parent.mkdir(exist_ok=True)
    file.write_text('\n'.join(lines)+'\n', encoding='utf-8')
    return {'name': name, 'rva': hex(start), 'end': hex(end), 'signature': m['Signature'], 'codeSha256': hashlib.sha256(body).hexdigest(), 'assembly': str(file), 'directCalls': calls, 'metadataReferences': metadata, 'memberLoads': member_loads, 'instructions': lines}

def line_of(text, index):
    return text[:index].count('\n')+1

rows = []
for type_name, manager_field in types:
    p = PROJECT / f'Assets/Scripts/Assembly-CSharp/ljzs_lt/{type_name}.cs'
    text = p.read_text(encoding='utf-8-sig')
    fields = [{'token': m[1], 'offset': m[2], 'type': m[3], 'name': m[4], 'line': line_of(text, m.start())}
              for m in re.finditer(r'\[Token\(Token = "(0x[\dA-Fa-f]+)"\)\]\s*\[FieldOffset\(Offset = "(0x[\dA-Fa-f]+)"\)\]\s*public ([\w\[\]]+) (\w+);', text)]
    getter = re.search(r'public override object UniqueID\s*\{\s*\[Token\(Token = "(0x[\dA-Fa-f]+)"\)\]\s*\[Address\(RVA = "(0x[\dA-Fa-f]+)"[^\n]+\]\s*get\s*\{([^}]+)\}', text)
    ctor = re.search(r'\[Token\(Token = "(0x[\dA-Fa-f]+)"\)\]\s*\[Address\(RVA = "(0x[\dA-Fa-f]+)"[^\n]+\]\s*public '+type_name+r'\(\)\s*\{([^}]*)\}', text)
    native_getter = dump_method('ljzs_lt.'+type_name+'$$get_UniqueID')
    native_ctor = dump_method('ljzs_lt.'+type_name+'$$.ctor')
    # All owned consumers are object boxed int keys at +0x10; expose evidence and confidence per row.
    key_field = next((f for f in fields if f['offset'].lower() == '0x10'), None)
    int_load = any(l['offset'] == '0x10' and l['destination'].startswith('w') for l in native_getter['memberLoads'])
    candidate = ('return '+key_field['name']+';') if key_field and key_field['type'] == 'int' and int_load else None
    rows.append({'type': type_name, 'consumerField': manager_field, 'kind': 'table' if manager_field.startswith('dic') else 'object', 'path': p.relative_to(PROJECT).as_posix(), 'absolutePath': str(p), 'sourceSha256': hashlib.sha256(p.read_bytes()).hexdigest(), 'fields': fields,
                 'UniqueID': {'token': getter[1], 'rva': getter[2], 'line': line_of(text, getter.start()), 'body': getter[3].strip(), 'recommendedCandidate': candidate, 'candidateEvidence': 'Original ARM64 loads int32 member +0x10 then IL2CPP boxes Int32' if candidate else 'Needs additional analysis; no inference from JSON key name', 'native': native_getter},
                 'constructor': {'token': ctor[1], 'rva': ctor[2], 'line': line_of(text, ctor.start()), 'body': ctor[3].strip(), 'recommendedCandidate': '{}', 'candidateEvidence': 'Compare exact native direct calls; implicit BaseConfig .ctor remains compiler-emitted', 'native': native_ctor}})
inventory = {'stage': 41, 'scope': 'Read-only source and original ARM64 row dependency inventory; no shared source writes', 'elfSha256': hashlib.sha256(raw).hexdigest(), 'counts': {'types': len(rows), 'tables': sum(r['kind'] == 'table' for r in rows), 'objects': sum(r['kind'] == 'object' for r in rows), 'emptyUniqueID': sum(r['UniqueID']['body'] == 'return null;' for r in rows), 'fieldReturnCandidates': sum(bool(r['UniqueID']['recommendedCandidate']) for r in rows)}, 'rows': rows}
(OUT / 'row-dependencies.json').write_text(json.dumps(inventory, ensure_ascii=False, indent=2), encoding='utf-8')
print(json.dumps({'counts': inventory['counts'], 'needsAdditionalAnalysis': [r['type'] for r in rows if not r['UniqueID']['recommendedCandidate']], 'output': str(OUT/'row-dependencies.json')}, ensure_ascii=False, indent=2))
