import json,random,struct,sys
from pathlib import Path
root=Path(__file__).resolve().parents[2];sys.path.insert(0,str(root/'work/tools/unicorn-recovery'))
from unicorn import Uc,UC_ARCH_ARM64,UC_MODE_ARM
import unicorn.arm64_const as arm
raw=(root/'work/ida-input/libil2cpp-arm64.so').read_bytes();phoff=struct.unpack_from('<Q',raw,32)[0];ps,pn=struct.unpack_from('<HH',raw,54);segs=[struct.unpack_from('<IIQQQQQQ',raw,phoff+i*ps) for i in range(pn)]
def read(a,size):
    s=next(s for s in segs if s[0]==1 and s[3]<=a<a+size<=s[3]+s[5]);off=s[2]+a-s[3];return raw[off:off+size]
start,end=0x3E1B2AC,0x3E1B2DC;data=read(start,end-start);constant=read(0x1836F34,4);assert struct.unpack('<f',constant)[0]==struct.unpack('<f',struct.pack('<f',1.2))[0]
rng=random.Random(20261019);values=[-2**31,-2**31+1,-1789569707,-1789569600,-16777219,-1,0,1,3,10,16777219,1789569600,1789569707,2**31-2,2**31-1]+[rng.randint(-2**31,2**31-1) for _ in range(128)]
results=[]
for n in values:
    cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM);cpu.mem_map(start&~0xFFF,0x1000);cpu.mem_write(start,data);cpu.mem_map(0x1836000,0x1000);cpu.mem_write(0x1836F34,constant);cpu.mem_map(0x10000000,0x1000);cpu.reg_write(arm.UC_ARM64_REG_SP,0x10000000);cpu.reg_write(arm.UC_ARM64_REG_W0,n&0xffffffff);cpu.emu_start(start,end,count=32);v=cpu.reg_read(arm.UC_ARM64_REG_W8);v=v if v<2**31 else v-2**32;results.append(dict(input=n,expected=v))
(root/'work/gamemanager-recovery/month-bonus-native-golden.json').write_text(json.dumps(dict(start=hex(start),end=hex(end),codeHex=data.hex(),constantHex=constant.hex(),cases=results),indent=2),encoding='utf-8');print('Native monthly float32/FCVTZS oracle:',len(results),'cases; 1.2 bits',constant.hex())
