"""Execute original ARM64 Initialize/ReadConfig with hooks only at their consumers.

Config parsing and Pool grouping are boundary hooks.  All flag writes, generic
MethodInfo selection, dictionary arguments, object assignments and control flow
are executed from original ELF instructions, independent of C# candidates.
"""
from pathlib import Path
import hashlib
import json
import re
import struct
import sys

ROOT=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20')
OUT=ROOT/'work/parallel-41-config/evidence/ida-chain'
sys.path.insert(0,str(ROOT/'work/tools/unicorn-recovery'))
from unicorn import Uc,UC_ARCH_ARM64,UC_MODE_ARM,UC_HOOK_CODE
import unicorn.arm64_const as arm

mapping=json.loads((ROOT/'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'))
meta={x['Address']:x['Name'] for x in mapping['ScriptMetadataMethod']}
raw=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes()
phoff=struct.unpack_from('<Q',raw,32)[0]; phsize,phnum=struct.unpack_from('<HH',raw,54)
segments=[struct.unpack_from('<IIQQQQQQ',raw,phoff+i*phsize) for i in range(phnum)]
def read_rva(address,size):
    s=next(s for s in segments if s[0]==1 and s[3]<=address and address+size<=s[3]+s[5])
    return raw[s[2]+address-s[3]:s[2]+address-s[3]+size]

def run(kind,initial=False,fail=-1):
    cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM); pages=set()
    def write(address,data):
        for page in range(address&~4095,(address+len(data)+4095)&~4095,4096):
            if page not in pages: cpu.mem_map(page,4096); pages.add(page)
        cpu.mem_write(address,data)
    def ptr(address,value): write(address,struct.pack('<Q',value))
    def word(address,value): write(address,struct.pack('<I',value))
    def readptr(address):return struct.unpack('<Q',cpu.mem_read(address,8))[0]
    starts=[(0x4399578,0x4399658),(0x4399658,0x4399BEC)]
    asm=''
    for start,end in starts:
        write(start,read_rva(start,end-start))
        asm+=(ROOT/'work/parallel-41-config/ida/pseudocode'/f'{start:#x}.asm.txt').read_text()+'\n'
    for got,slot in re.findall(r'#off_([0-9A-F]+)@PAGEOFF\];\s*(?:off|qword)_([0-9A-F]+)',asm):
        ptr(int(got,16),int(slot,16))
    for guard in set(re.findall(r'byte_([0-9A-F]+)',asm)):write(int(guard,16),b'\1')
    config_class,app_class=0x20000000,0x20001000
    config_static,app_static=0x21000000,0x21001000
    for klass,static,slot in [(config_class,config_static,0x8CE5BB8),(app_class,app_static,0x8CE40C8)]:
        write(klass,bytes(512));write(static,bytes(256));ptr(klass+0xB8,static);word(klass+0xE0,1);ptr(slot,klass)
    write(config_static,b'\0');write(app_static+0x3C,b'\1')
    # Unique nonzero MethodInfo identities preserve the original generic slots.
    method_identities={}
    for slot in sorted(set(int(x,16) for x in re.findall(r'(?:off|qword)_([0-9A-F]{7,})',asm)) & meta.keys()):
        identity=0x23000000+len(method_identities)*0x100
        ptr(slot,identity);method_identities[identity]=meta[slot]
    instance=0x22000000;write(instance,bytes(0x200));write(instance+0x10,bytes([initial]))
    for n in range(38):ptr(instance+0x18+n*8,0x24000000+n*0x100)
    sentinel=0x25000000;write(sentinel,b'\x1f\x20\x03\xd5')
    write(0x26000000,bytes(0x4000));cpu.reg_write(arm.UC_ARM64_REG_SP,0x26002000)
    cpu.reg_write(arm.UC_ARM64_REG_X30,sentinel);cpu.reg_write(arm.UC_ARM64_REG_X0,instance)
    trace=[];error=[];objects={};boundary_calls=[]
    for hookaddr in [0x4B8CADC,0x4B8D360,0x4399BEC]:write(hookaddr,b'\xc0\x03\x5f\xd6')
    if kind=='Initialize':write(0x4399658,b'\xc0\x03\x5f\xd6')
    def hook(machine,address,size,data):
        if kind=='Initialize' and address in [0x4399658,0x4399BEC]:
            boundary_calls.append('ReadConfig' if address==0x4399658 else 'customRead')
            assert machine.reg_read(arm.UC_ARM64_REG_X0)==instance
            assert machine.mem_read(config_static,1)==b'\1'
            assert machine.mem_read(app_static+0x3C,1)==b'\0'
            if len(boundary_calls)-1==fail:error.append('consumer_exception');machine.emu_stop()
        elif kind=='ReadConfig' and address in [0x4B8CADC,0x4B8D360]:
            value=machine.reg_read(arm.UC_ARM64_REG_X0)
            method=value if address==0x4B8D360 else machine.reg_read(arm.UC_ARM64_REG_X1)
            name=method_identities[method]
            index=len(trace)
            if address==0x4B8CADC:assert value==0x24000000+index*0x100
            trace.append({'index':index,'name':name,'methodInfo':hex(method),'dictionary':hex(value) if address==0x4B8CADC else None})
            if index==fail:error.append('consumer_exception');machine.emu_stop();return
            if address==0x4B8D360:
                result=0x27000000+index*0x100
                objects[name]=result;machine.reg_write(arm.UC_ARM64_REG_X0,result)
    cpu.hook_add(UC_HOOK_CODE,hook)
    start,end=starts[0 if kind=='Initialize' else 1]
    cpu.emu_start(start,sentinel,count=10000)
    assert error or cpu.reg_read(arm.UC_ARM64_REG_PC)==sentinel
    assigned=[hex(readptr(instance+offset)) for offset in [0x148,0x150,0x158]]
    row={'kind':kind,'initial':initial,'failIndex':fail,'error':error[0] if error else None,
         'boundaryCalls':boundary_calls,'trace':trace,'IsInitialize':bool(cpu.mem_read(instance+0x10,1)[0]),
         'IsUserJsonUtility':bool(cpu.mem_read(config_static,1)[0]),
         'IsUseMemoryPack':bool(cpu.mem_read(app_static+0x3C,1)[0]),'assignedObjectPointers':assigned,
         'codeStart':hex(start),'codeEnd':hex(end),'originalCodeSha256':hashlib.sha256(read_rva(start,end-start)).hexdigest()}
    if kind=='Initialize':
        assert row['IsUserJsonUtility'] and not row['IsUseMemoryPack']
        assert row['IsInitialize']==(initial or fail<0)
        assert boundary_calls==([] if initial else ['ReadConfig'] if fail==0 else ['ReadConfig','customRead'])
    elif fail<0:
        assert len(trace)==41
        assert assigned==[hex(0x27000000+n*0x100) for n in [38,39,40]]
    else:assert len(trace)==fail+1
    return row

rows=[run('Initialize',initial,fail) for initial,fail in [(False,-1),(True,-1),(False,0),(False,1)]]
rows.extend(run('ReadConfig',fail=fail) for fail in [-1]+list(range(41)))
(OUT/'native-chain-golden.json').write_text(json.dumps({'caseCount':len(rows),'elfSha256':hashlib.sha256(raw).hexdigest(),
    'boundaryScope':'Only consumers are hooks; original instructions perform all dispatch/assignment/flag writes. This is not Unity runtime.',
    'cases':rows},ensure_ascii=False,indent=2),encoding='utf-8')
print(f'PASS: {len(rows)} original ARM64 cases; Initialize flag/error ordering and all 41 ReadConfig MethodInfo identities/arguments/assignment boundaries')
