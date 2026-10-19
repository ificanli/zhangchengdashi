"""Original UnityJson dictionary helper oracle; parsing/containers/virtual UID/log are hooks."""
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
raw=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes()
start,end=0x4B8BF38,0x4B8C16C
code=raw[start-0x4000:end-0x4000]
assert code[:4] == bytes.fromhex('fe0f1af8') # STR X30,[SP,#-0x60]!
asm=(ROOT/'work/parallel-41-config/ida/pseudocode/0x4b8bf38.asm.txt').read_text()

def run(spec):
    cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM);pages=set()
    def write(address,data):
        for page in range(address&~4095,(address+len(data)+4095)&~4095,4096):
            if page not in pages:cpu.mem_map(page,4096);pages.add(page)
        cpu.mem_write(address,data)
    def ptr(address,value):write(address,struct.pack('<Q',value))
    def word(address,value):write(address,struct.pack('<I',value))
    def reg(n):return cpu.reg_read(getattr(arm,'UC_ARM64_REG_X'+str(n)))
    def ret(value):cpu.reg_write(arm.UC_ARM64_REG_X0,value)
    def fail(message):errors.append(message);cpu.emu_stop()
    write(start,code)
    for got,slot in re.findall(r'#off_([0-9A-F]+)@PAGEOFF\];\s*(?:off|qword)_([0-9A-F]+)',asm):ptr(int(got,16),int(slot,16))
    for i,slot in enumerate([0x8CE5250,0x8CE5BB8,0x8CE3258]):
        klass=0x20000000+i*0x1000;write(klass,bytes(512));word(klass+0xE0,1);ptr(slot,klass)
    ptr(0x8D88368,0x21000000)
    method,rgctx=0x22000000,0x22001000
    write(method,bytes(128));write(rgctx,bytes(128));ptr(method+0x38,rgctx)
    for i in range(8):ptr(rgctx+8*i,0x23000000+0x100*i)
    listaddr=0x24000000;write(listaddr,bytes(128))
    rowclass=0x24100000;write(rowclass,bytes(512));uid=0x28000000
    ptr(rowclass+0x178,uid);ptr(rowclass+0x180,0x28100000)
    pointers=[];row_by_ptr={};keys=spec.get('rows',[])
    for i,key in enumerate(keys):
        address=0 if key=='null_row' else 0x24200000+i*0x100
        pointers.append(address)
        if address:write(address,bytes(64));ptr(address,rowclass);row_by_ptr[address]=i
    word(listaddr+24,len(keys))
    source=0 if spec.get('nullSource') else 0x25000000
    result=dict(spec.get('existing',{}));errors=[];calls=[];uidcounts={};formats=[]
    hooks=[0x4B8BEB4,0x574F26C,0x6C06EB4,0x6C06CC0,0x750AA4C,0x71F3550,
           0x3C3D320,0x3C3D3B4,0x3C3D4CC,0x3C3D4D4,0x3C3D4F0,0x3C3D3A0,uid]
    for address in hooks:write(address,b'\xc0\x03\x5f\xd6')
    sentinel=0x29000000;write(sentinel,b'\x1f\x20\x03\xd5');write(0x2A000000,bytes(16384))
    cpu.reg_write(arm.UC_ARM64_REG_SP,0x2A002000);cpu.reg_write(arm.UC_ARM64_REG_X30,sentinel)
    for n,v in enumerate([0x2B000000,source,0x2C000000,method]):cpu.reg_write(getattr(arm,'UC_ARM64_REG_X'+str(n)),v)
    allocation=[0x2D000000]
    def hook(machine,address,size,data):
        if address==0x4B8BEB4:
            calls.append({'call':'parse'});ret(0 if spec.get('nullList') else listaddr)
        elif address==0x574F26C:
            i=reg(1);assert reg(0)==listaddr;calls.append({'call':'get_Item','index':i});ret(pointers[i])
        elif address==uid:
            i=row_by_ptr[reg(0)];assert reg(1)==0x28100000
            uidcounts[i]=uidcounts.get(i,0)+1
            calls.append({'call':'UniqueID','index':i,'time':uidcounts[i]})
            if spec.get('uidFail')==[i,uidcounts[i]]:fail('UniqueIDException');return
            value=keys[i]
            if isinstance(value,list):value=value[min(uidcounts[i]-1,len(value)-1)]
            ret(0 if value is None else value)
        elif address==0x6C06EB4:
            assert reg(0)==source and reg(2)==0x23000500
            key=reg(1);calls.append({'call':'ContainsKey','key':key})
            if key==0:fail('ArgumentNullException');return
            if spec.get('containsFail')==key:fail('ContainsException');return
            ret(1 if str(key) in result else 0)
        elif address==0x6C06CC0:
            assert reg(0)==source and reg(3)==0x23000600
            key=reg(1);i=row_by_ptr[reg(2)];calls.append({'call':'Add','key':key,'row':i})
            if spec.get('addFail')==key:fail('AddException');return
            assert str(key) not in result;result[str(key)]=f'row{i}'
        elif address==0x3C3D320:
            assert reg(1)==1
            a=allocation[0];allocation[0]+=0x100;write(a,bytes(128));ptr(a,0x20002000);word(a+24,1);ret(a)
        elif address==0x3C3D3B4:ret(reg(0))
        elif address==0x750AA4C:
            assert reg(0)==0x21000000 and reg(1)==0x2C000000
            formats.append(reg(2));calls.append({'call':'FormatDuplicate','key':reg(2)});ret(0x2E000000)
        elif address==0x71F3550:calls.append({'call':'Error'})
        elif address==0x3C3D4CC:fail('NullReferenceException')
        elif address in [0x3C3D4D4,0x3C3D4F0,0x3C3D3A0]:fail('UnexpectedRuntimeThrow')
    cpu.hook_add(UC_HOOK_CODE,hook)
    cpu.emu_start(start,sentinel,count=10000)
    assert errors or cpu.reg_read(arm.UC_ARM64_REG_PC)==sentinel
    row={'name':spec['name'],'input':spec,'dictionary':result,'uidCallCounts':{str(k):v for k,v in uidcounts.items()},
         'duplicateLogKeys':formats,'error':errors[0] if errors else None,'calls':calls}
    for k in ['dictionary','uidCallCounts','duplicateLogKeys','error']:
        if k in spec.get('expected',{}):assert row[k]==spec['expected'][k],(spec['name'],k,row[k],spec['expected'][k])
    return row

specs=[
 {'name':'nullList_nullSource','nullList':True,'nullSource':True,'expected':{'dictionary':{},'uidCallCounts':{},'error':None}},
 {'name':'emptyList_nullSource','rows':[],'nullSource':True,'expected':{'dictionary':{},'uidCallCounts':{},'error':None}},
 {'name':'single','rows':[1],'expected':{'dictionary':{'1':'row0'},'uidCallCounts':{'0':2},'error':None}},
 {'name':'threeUnique','rows':[1,2,3],'expected':{'dictionary':{'1':'row0','2':'row1','3':'row2'},'uidCallCounts':{'0':2,'1':2,'2':2},'error':None}},
 {'name':'duplicateRetainsFirst','rows':[1,1],'expected':{'dictionary':{'1':'row0'},'uidCallCounts':{'0':2,'1':2},'duplicateLogKeys':[1],'error':None}},
 {'name':'existingRetained','rows':[1],'existing':{'1':'existing'},'expected':{'dictionary':{'1':'existing'},'uidCallCounts':{'0':2},'duplicateLogKeys':[1],'error':None}},
 {'name':'nullSourceAfterFirstUID','rows':[1],'nullSource':True,'expected':{'dictionary':{},'uidCallCounts':{'0':1},'error':'NullReferenceException'}},
 {'name':'nullFirstRow','rows':['null_row',1],'expected':{'dictionary':{},'uidCallCounts':{},'error':'NullReferenceException'}},
 {'name':'nullSecondRowPreservesPrefix','rows':[1,'null_row',3],'expected':{'dictionary':{'1':'row0'},'uidCallCounts':{'0':2},'error':'NullReferenceException'}},
 {'name':'UIDThrowsFirst','rows':[1,2],'uidFail':[0,1],'expected':{'dictionary':{},'uidCallCounts':{'0':1},'error':'UniqueIDException'}},
 {'name':'UIDThrowsSecond','rows':[1,2],'uidFail':[0,2],'expected':{'dictionary':{},'uidCallCounts':{'0':2},'error':'UniqueIDException'}},
 {'name':'ContainsThrowsPreservesPrefix','rows':[1,2,3],'containsFail':2,'expected':{'dictionary':{'1':'row0'},'uidCallCounts':{'0':2,'1':1},'error':'ContainsException'}},
 {'name':'AddThrowsPreservesPrefix','rows':[1,2,3],'addFail':2,'expected':{'dictionary':{'1':'row0'},'uidCallCounts':{'0':2,'1':2},'error':'AddException'}},
 {'name':'nullKeyRejectedAtContains','rows':[None,2],'expected':{'dictionary':{},'uidCallCounts':{'0':1},'error':'ArgumentNullException'}},
 {'name':'changingUIDUsedAgainForAdd','rows':[[1,2]],'expected':{'dictionary':{'2':'row0'},'uidCallCounts':{'0':2},'error':None}},
 {'name':'changingUIDUsedAgainForLog','rows':[[1,2]],'existing':{'1':'existing'},'expected':{'dictionary':{'1':'existing'},'uidCallCounts':{'0':2},'duplicateLogKeys':[2],'error':None}},
]
rows=[run(s) for s in specs]
(OUT/'native-dictionary-golden.json').write_text(json.dumps({'caseCount':len(rows),'codeStart':hex(start),'codeEnd':hex(end),
    'codeSha256':hashlib.sha256(code).hexdigest(),'scope':'Original helper instructions; only parser, List/Dictionary, virtual UniqueID, allocation/format/log are boundary hooks. No C# candidate executes.',
    'cases':rows},ensure_ascii=False,indent=2),encoding='utf-8')
print(f'PASS: {len(rows)} original ARM64 dictionary helper cases; null/empty/source/rows/duplicates/object identity/UID repetitions/partial exceptions')
