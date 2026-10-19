"""Read original TextAssets and original ARM64 UniqueID getters; never edits sources."""
import bisect
import hashlib
import json
import re
import struct
import sys
from pathlib import Path

ROOT = Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20')
OUT = ROOT / 'work/parallel-41-config/evidence/ida-chain'
sys.path.insert(0, str(ROOT / 'work/tools/legacy-inspection'))
import capstone
from capstone.arm64 import ARM64_OP_MEM

mapping = json.loads((ROOT / 'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'))
boundaries = sorted(set(mapping['Addresses']))
methods = {r['Name']: r for r in mapping['ScriptMethod']}
raw = (ROOT / 'work/ida-input/libil2cpp-arm64.so').read_bytes()
phoff = struct.unpack_from('<Q', raw, 32)[0]
phsize, phnum = struct.unpack_from('<HH', raw, 54)
segments = [struct.unpack_from('<IIQQQQQQ', raw, phoff+i*phsize) for i in range(phnum)]
def read_rva(address, size):
    segment = next(s for s in segments if s[0] == 1 and s[3] <= address and address+size <= s[3]+s[5])
    start = segment[2]+address-segment[3]
    return raw[start:start+size]

native = json.loads((ROOT/'outputs/旧框架资源恢复/证据/消费者与物理设置/native-consumer-evidence.json').read_text())
read = next(m for m in native['methods'] if m['address'] == '0x4399658')
calls = [r for r in read['metadataReferences'] if r['category'] == 'ScriptMetadataMethod' and int(r['instruction'],16) >= 0x4399880]
assert len(calls) == 41
resources = json.loads((ROOT/'outputs/旧框架资源恢复/原名与PathID映射.json').read_text())
resources = {r['textAssetName']:r for r in resources}
md = capstone.Cs(capstone.CS_ARCH_ARM64, capstone.CS_MODE_LITTLE_ENDIAN)
md.detail = True
rows = []
for index, call in enumerate(calls):
    name = re.search(r'<([^>]+)>',call['Name']).group(1)
    resource = resources[name]
    data = (ROOT/'outputs/旧框架资源恢复'/resource['deliveryPath']).read_bytes()
    assert hashlib.sha256(data).hexdigest() == resource['sha256']
    body = json.loads(data.decode('utf-8-sig'))
    source_path = ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/ljzs_lt'/f'{name}.cs'
    source = source_path.read_text(encoding='utf-8-sig')
    row = {'order':index+1,'name':name,'kind':'table' if 'Datas' in body else 'object','genericMethod':call['Name'],
           'genericLoadInstruction':call['instruction'],'resource':resource,
           'fields':sorted(set().union(*(r.keys() for r in body['Datas']))) if 'Datas' in body else sorted(body),
           'sourceSha256':hashlib.sha256(source_path.read_bytes()).hexdigest()}
    if 'Datas' in body:
        getter = methods[f'ljzs_lt.{name}$$get_UniqueID']
        start = getter['Address']; end = boundaries[bisect.bisect_right(boundaries,start)]
        code = read_rva(start,end-start)
        insns = list(md.disasm(code,start))
        getter_asm = '\n'.join(f'{i.address:#x}: {i.mnemonic} {i.op_str}' for i in insns)
        (OUT/f'{start:#x}-UniqueID.asm.txt').write_text(getter_asm,encoding='utf-8')
        offsets = [o.mem.disp for i in insns if i.mnemonic == 'ldr' for o in i.operands
                   if o.type == ARM64_OP_MEM and i.reg_name(o.mem.base) in ('x19','x20') and 0x10 <= o.mem.disp < 0x80]
        assert len(set(offsets)) == 1,(name,offsets,getter_asm)
        offset = offsets[0]
        fields = list(re.finditer(r'\[FieldOffset\(Offset = "(0x[0-9A-Fa-f]+)"\)\]\s+public\s+([^;]+)\s+(\w+);',source))
        keyfield = next(f for f in fields if int(f[1],16) == offset)
        keyname = keyfield[3]; keytype = keyfield[2]
        values = [v[keyname] for v in body['Datas']]
        token_match = re.search(r'public override object UniqueID.*?Token = "(0x[0-9A-Fa-f]+)"',source,re.S)
        row.update(count=len(values),primaryKey=keyname,primaryKeyType=keytype,keyOffset=hex(offset),
                   distinctKeys=len(set(values)),duplicateKeys=sorted(set(v for v in values if values.count(v)>1)),
                   firstKey=values[0] if values else None,lastKey=values[-1] if values else None,
                   sampleRecords=body['Datas'][:2],
                   uniqueIdNative={'token':token_match[1] if token_match else None,'start':hex(start),'end':hex(end),
                                   'prototype':getter['Signature'],'codeSha256':hashlib.sha256(code).hexdigest()})
    else:
        row.update(count=1,primaryKey=None,values=body)
    rows.append(row)

# Export setter's actual offset as independent confirmation of Initialize's write.
setter = methods['GameFramework.AppSetting$$set_IsUseMemoryPack']
start=setter['Address']; end=boundaries[bisect.bisect_right(boundaries,start)]
(OUT/f'{start:#x}-IsUseMemoryPack.asm.txt').write_text('\n'.join(f'{i.address:#x}: {i.mnemonic} {i.op_str}' for i in md.disasm(read_rva(start,end-start),start)),encoding='utf-8')
result={'originalElfSha256':hashlib.sha256(raw).hexdigest(),'directReadCount':len(rows),
        'tableCount':sum(r['kind']=='table' for r in rows),'objectCount':sum(r['kind']=='object' for r in rows),
        'totalTableRows':sum(r['count'] for r in rows if r['kind']=='table'),
        'allResourceHashesMatch':True,'allPrimaryKeysUnique':all(not r.get('duplicateKeys') for r in rows),
        'rows':rows}
(OUT/'resource-audit-41.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({k:v for k,v in result.items() if k!='rows'},ensure_ascii=False,indent=2))
print('\n'.join(f"{r['order']:2}: {r['name']:28} {r['kind']:6} {r['count']:4} PK={r['primaryKey']}" for r in rows))
