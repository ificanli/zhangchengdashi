import hashlib
import json
import struct
import sys
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];OWN=ROOT/'work/bundleassetinfo-recovery'
sys.path.insert(0,str(ROOT/'work/tools/unicorn-recovery'))
from unicorn import Uc,UC_ARCH_ARM64,UC_MODE_ARM,UC_HOOK_CODE
import unicorn.arm64_const as arm
raw=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes();ph=struct.unpack_from('<Q',raw,32)[0];ps,pn=struct.unpack_from('<HH',raw,54)
segments=[struct.unpack_from('<IIQQQQQQ',raw,ph+i*ps)for i in range(pn)]
def read(a,n):
    s=next(s for s in segments if s[0]==1 and s[3]<=a and a+n<=s[3]+s[5]);p=s[2]+a-s[3];return raw[p:p+n]
sh=struct.unpack_from('<Q',raw,40)[0];ss,sn=struct.unpack_from('<HH',raw,58);relocs={}
for index in range(sn):
    s=struct.unpack_from('<IIQQQQIIQQ',raw,sh+index*ss)
    if s[1]!=4:continue
    for p in range(s[4],s[4]+s[5],s[9] or 24):
        a,i,v=struct.unpack_from('<QQq',raw,p)
        if i&0xffffffff==1027:relocs[a]=v
proof=json.loads((OWN/'candidate-provenance.json').read_text(encoding='utf-8'))
cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM);cpu.mem_map(0x72eb000,0x1000);cpu.mem_write(0x72eb000,read(0x72eb000,0x1000));cpu.mem_map(0x10000000,0x1000)
scalar=[]
for row in proof['accessors']:
    start=int(row['address'],16);offset=int(row['fieldOffset'],16);wide=row['fieldType']=='string';mask=0xffffffffffffffff if wide else 0xffffffff
    for value in ([0,0x12345678,0x7fff0000deadbeef]if wide else[0,0x7fffffff,0x80000000]):
        cpu.mem_write(0x10000000,bytes(0x1000));cpu.reg_write(arm.UC_ARM64_REG_X0,0x10000000);cpu.reg_write(arm.UC_ARM64_REG_LR,start+8)
        if row['operation']=='ldr':cpu.mem_write(0x10000000+offset,struct.pack('<Q'if wide else'<I',value))
        else:cpu.reg_write(arm.UC_ARM64_REG_X1,value)
        cpu.emu_start(start,start+8,count=2)
        actual=cpu.reg_read(arm.UC_ARM64_REG_X0)&mask if row['operation']=='ldr' else struct.unpack('<Q'if wide else'<I',cpu.mem_read(0x10000000+offset,8 if wide else 4))[0]
        assert actual==value,(row,value,actual)
        scalar.append(dict(address=row['address'],fieldOffset=row['fieldOffset'],operation=row['operation'],input=hex(value),actual=hex(actual)))
constructors=[]
for short,capability in [(False,False),(False,True),(True,False),(True,True)]:
    cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM);mapped=set()
    def write(a,data):
        for page in range(a&~0xfff,(a+len(data)+0xfff)&~0xfff,0x1000):
            if page not in mapped:cpu.mem_map(page,0x1000);mapped.add(page)
        cpu.mem_write(a,data)
    def q(a,v):write(a,struct.pack('<Q',v))
    obj,stack,stop=0x10000000,0x20000000,0x30000000
    write(0x72eb000,read(0x72eb000,0x1000));write(obj,bytes(0x10000));write(stack,bytes(0x10000));write(stop,bytes.fromhex('c0035fd6'));write(0x76c770c,bytes.fromhex('c0035fd6'))
    for a in [0x900A060,0x900A061]:write(a,b'\x01')
    for slot,klass,static in [(0x8ACD860,0x10008000,0x10009000),(0x8ACD478,0x1000a000,0x1000b000)]:
        q(slot,relocs[slot]);q(relocs[slot],klass);q(klass+0xb8,static);write(klass+0xe0,struct.pack('<I',1))
    q(0x1000b000,0x1000c000)
    base_observed=[]
    def hook(uc,pc,size,user):
        if pc==0x76c770c:
            assert cpu.mem_read(obj+0x40,1)==b'\x01'
            base_observed.append(True);cpu.reg_write(arm.UC_ARM64_REG_PC,cpu.reg_read(arm.UC_ARM64_REG_LR))
    cpu.hook_add(UC_HOOK_CODE,hook)
    cpu.reg_write(arm.UC_ARM64_REG_SP,stack+0x8000);cpu.reg_write(arm.UC_ARM64_REG_X0,obj);cpu.reg_write(arm.UC_ARM64_REG_X1,0x11111111);cpu.reg_write(arm.UC_ARM64_REG_X2,0x22222222);cpu.reg_write(arm.UC_ARM64_REG_LR,stop)
    if short:address=0x72eb4ac
    else:
        address=0x72eb0d0;cpu.reg_write(arm.UC_ARM64_REG_X3,0x33333333);cpu.reg_write(arm.UC_ARM64_REG_W4,0x80000000);cpu.reg_write(arm.UC_ARM64_REG_W5,1);cpu.reg_write(arm.UC_ARM64_REG_X6,0x44444444);cpu.reg_write(arm.UC_ARM64_REG_X7,0x55555555);write(stack+0x8000,bytes([int(capability)]))
    cpu.emu_start(address,stop,count=1024)
    values={hex(off):struct.unpack('<Q',cpu.mem_read(obj+off,8))[0]for off in[0x10,0x18,0x20,0x28,0x38]}
    version=struct.unpack('<I',cpu.mem_read(obj+0x30,4))[0];encrypted=cpu.mem_read(obj+0x34,1)[0];inapp=cpu.mem_read(obj+0x40,1)[0]
    assert base_observed==[True]
    if short:assert values=={'0x10':0x11111111,'0x18':0,'0x20':0x22222222,'0x28':0x1000c000,'0x38':0}and version==0 and encrypted==0 and inapp==1
    else:assert values=={'0x10':0x11111111,'0x18':0x44444444,'0x20':0x22222222,'0x28':0x33333333,'0x38':0x55555555}and version==0x80000000 and encrypted==1 and inapp==int(capability)
    constructors.append(dict(address=hex(address),shortConstructor=short,inAppArgument=capability,fieldValues={k:hex(v)for k,v in values.items()},versionBits=hex(version),encrypted=encrypted,inApp=inapp,initializerTrueBeforeObjectConstructor=True))
result=dict(scalarAccessors=52,scalarCases=len(scalar),scalarResults=scalar,constructorCases=constructors,scope='Original ARM64 executes; Object constructor is external hook and original logging gate disabled. Pointer words model identity, not actual Unity resources.')
(OWN/'native-oracle.json').write_text(json.dumps(result,indent=2),encoding='utf-8')
print('original ARM64:',len(scalar),'scalar cases +',len(constructors),'constructor cases passed')
