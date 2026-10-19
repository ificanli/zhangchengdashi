from pathlib import Path
import hashlib
import json
import re
import struct
import sys

ROOT=Path(__file__).resolve().parents[2]
sys.path.insert(0,str(ROOT/'work/tools/unicorn-recovery'))
from unicorn import Uc,UC_ARCH_ARM64,UC_MODE_ARM,UC_HOOK_CODE
import unicorn.arm64_const as arm

WORK=Path(__file__).resolve().parent
MAPPING=json.loads((ROOT/'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'))
META={x['Address']:x['Name'] for x in MAPPING['ScriptMetadata']}
METHOD={x['Address']:x['Name'] for x in MAPPING['ScriptMetadataMethod']}
CODE=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes()
TARGETS={t['name'].split('$$')[-1]:t for t in json.loads((WORK/'native-targets.json').read_text())}
MODEL_TYPES={address:re.match(r'DbtSaveDataManagerBase<([^,]+),',name).group(1)
             for address,name in META.items() if name.startswith('DbtSaveDataManagerBase<') and name.endswith('_TypeInfo')}

def run(kind,missing=-1,choice=0):
    target=TARGETS[kind]
    start,end=target['address'],target['end']
    asm=(ROOT/'work/ida-framework-assets/pseudocode'/f'{start:#x}.asm.txt').read_text()
    cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM)
    pages=set()
    def write(address,data):
        for page in range(address&~4095,(address+len(data)+4095)&~4095,4096):
            if page not in pages:cpu.mem_map(page,4096);pages.add(page)
        cpu.mem_write(address,data)
    def ptr(address,value):write(address,struct.pack('<Q',value))
    write(start,CODE[start-0x4000:end-0x4000])
    for got,var in re.findall(r'#off_([0-9A-F]+)@PAGEOFF\];\s*(?:off|qword)_([0-9A-F]+)',asm):
        ptr(int(got,16),int(var,16))
    for guard in set(re.findall(r'byte_(900[0-9A-F]+)',asm)):write(int(guard,16),b'\x01')
    references=set(int(x,16) for x in re.findall(r'(?:off|qword)_([0-9A-F]{7,})',asm))
    types=sorted(address for address in references if address in MODEL_TYPES)
    objects={}
    ptr_to_model={}
    for index,address in enumerate(types):
        cls,stat,instance=0x20000000+index*0x1000,0x21000000+index*0x1000,0x22000000+index*0x1000
        ptr(address,cls);ptr(cls+0xB8,stat);ptr(stat,instance)
        write(instance,bytes(128));write(instance+64,bytes([kind=='StopAllSave']))
        objects[MODEL_TYPES[address]]=instance
        ptr_to_model[instance]=MODEL_TYPES[address]
    method_to_model={}
    for index,address in enumerate(sorted(references & METHOD.keys())):
        mock_method=0x23000000+index*0x100
        ptr(address,mock_method)
        match=re.match(r'Method\$DbtSaveDataManagerBase<([^,]+),',METHOD[address])
        if match:method_to_model[mock_method]=match.group(1)
    # Enumerate distinct metadata slots from the original assembly, independently
    # of any C# candidate. The success trace below records actual Load call order.
    access=[]
    for address in re.findall(r'; off_([0-9A-F]+)',asm):
        address=int(address,16)
        if address in MODEL_TYPES and MODEL_TYPES[address] not in access:access.append(MODEL_TYPES[address])
    if missing>=0:
        missing_name=access[missing]
        address=next(address for address in types if MODEL_TYPES[address]==missing_name)
        index=types.index(address)
        ptr(0x21000000+index*0x1000,0)
    if kind=='ChooseConflict':
        ptr(0x8CE6168,0x24000000);ptr(0x24000000+0xB8,0x24001000)
        write(0x24001000,bytes([0,1,0,0])+struct.pack('<i',-7))
        cpu.reg_write(arm.UC_ARM64_REG_W1,choice&0xFFFFFFFF)
    sentinel=0x25000000
    write(sentinel,b'\x1f\x20\x03\xd5')
    write(0x26000000,bytes(8192))
    cpu.reg_write(arm.UC_ARM64_REG_SP,0x26001000)
    cpu.reg_write(arm.UC_ARM64_REG_X30,sentinel)
    cpu.reg_write(arm.UC_ARM64_REG_X0,0x26001800)
    write(0x6AF4198,b'\xc0\x03\x5f\xd6')
    write(0x3C3D4CC,b'\xc0\x03\x5f\xd6')
    calls=[]
    error=[]
    def hook(machine,address,size,data):
        if address==0x6AF4198:
            instance=machine.reg_read(arm.UC_ARM64_REG_X0)
            method=machine.reg_read(arm.UC_ARM64_REG_X1)
            name=ptr_to_model[instance]
            assert method_to_model[method]==name
            calls.append(name)
            assert machine.mem_read(instance+64,1)==b'\x01'
            machine.reg_write(arm.UC_ARM64_REG_PC,machine.reg_read(arm.UC_ARM64_REG_X30))
        elif address==0x3C3D4CC:
            error.append('NullReferenceException');machine.emu_stop()
    cpu.hook_add(UC_HOOK_CODE,hook)
    cpu.emu_start(start,sentinel,count=5000)
    if not error:assert cpu.reg_read(arm.UC_ARM64_REG_PC)==sentinel
    result=dict(kind=kind,missingIndex=missing,choice=choice,calls=calls,error=error[0] if error else None,
                slotOrder=access,flags={name:bool(cpu.mem_read(instance+64,1)[0]) for name,instance in objects.items()},
                originalCodeSha256=hashlib.sha256(CODE[start-0x4000:end-0x4000]).hexdigest())
    if kind=='ChooseConflict':
        raw=bytes(cpu.mem_read(0x24001000,8))
        result.update(conflictFinish=raw[0]!=0,hasChecked=raw[1]!=0,status=struct.unpack('<i',raw[4:8])[0])
    return result

rows=[]
for kind in ['LoadAllSaveData','StopAllSave']:
    rows.append(run(kind))
    for missing in range(15):rows.append(run(kind,missing))
for value in [0,1,2,-1,2147483647,-2147483648]:rows.append(run('ChooseConflict',choice=value))
(WORK/'native-golden.json').write_text(json.dumps(rows,indent=2),encoding='utf-8')
print('Original ARM64 executions:',len(rows),'success; original Load calls are boundary hooks, all state writes/order run natively')
