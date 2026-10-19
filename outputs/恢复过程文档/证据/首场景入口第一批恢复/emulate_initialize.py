import hashlib
import json
import struct
import sys
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
sys.path.insert(0,str(ROOT/'work/tools/unicorn-recovery'))
from unicorn import Uc,UC_ARCH_ARM64,UC_MODE_ARM,UC_HOOK_CODE
import unicorn.arm64_const as arm
raw=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes()
phoff=struct.unpack_from('<Q',raw,32)[0]
ps,pn=struct.unpack_from('<HH',raw,54)
segments=[struct.unpack_from('<IIQQQQQQ',raw,phoff+i*ps) for i in range(pn)]
address,end=0x715AF54,0x715AF7C
seg=next(s for s in segments if s[0]==1 and s[3]<=address and end<=s[3]+s[5])
pos=seg[2]+address-seg[3]
code=raw[pos:pos+end-address]
cases=[]
for initial_ready,null_module in [(0,False),(1,False),(0,True)]:
    cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM)
    for page,size in [(address&~0xfff,0x1000),(0x10000000,0x8000),(0x3c3d000,0x1000)]:cpu.mem_map(page,size)
    cpu.mem_write(address,code)
    module,klass,callback,args,handler,stop,method=0x10000000,0x10001000,0x12345678,0x10003000,0x10004000,0x10005000,0x87654321
    cpu.mem_write(module,struct.pack('<Q',klass))
    cpu.mem_write(module+0x10,bytes([initial_ready]))
    cpu.mem_write(klass+0x188,struct.pack('<QQ',handler,method))
    cpu.mem_write(handler,bytes.fromhex('c0035fd6'))
    cpu.mem_write(0x3c3d4cc,bytes.fromhex('c0035fd6'))
    cpu.reg_write(arm.UC_ARM64_REG_SP,0x10008000)
    cpu.reg_write(arm.UC_ARM64_REG_X0,0 if null_module else module)
    cpu.reg_write(arm.UC_ARM64_REG_X1,callback)
    cpu.reg_write(arm.UC_ARM64_REG_X2,args)
    cpu.reg_write(arm.UC_ARM64_REG_LR,stop)
    calls=[]
    def hook(uc,at,size,user):
        if at==handler:
            saved=struct.unpack('<Q',cpu.mem_read(module+0x18,8))[0]
            actual_args=cpu.reg_read(arm.UC_ARM64_REG_X1)
            actual_method=cpu.reg_read(arm.UC_ARM64_REG_X2)
            assert saved==callback and actual_args==args and actual_method==method
            calls.append(dict(virtualInitialize=True,callbackAlreadyStored=True,argsPreserved=True,readyAtInvoke=cpu.mem_read(module+0x10,1)[0]))
            cpu.reg_write(arm.UC_ARM64_REG_PC,cpu.reg_read(arm.UC_ARM64_REG_LR))
        elif at==0x3c3d4cc:
            calls.append('null-reference')
            cpu.emu_stop()
    cpu.hook_add(UC_HOOK_CODE,hook)
    cpu.emu_start(address,stop,count=64)
    ready=cpu.mem_read(module+0x10,1)[0]
    assert ready==initial_ready
    assert calls==['null-reference'] if null_module else len(calls)==1 and isinstance(calls[0],dict)
    cases.append(dict(initialReady=initial_ready,nullModule=null_module,finalReady=ready,calls=calls))
result=dict(address=hex(address),end=hex(end),bytes=len(code),codeSha256=hashlib.sha256(code).hexdigest(),cases=cases,scope='Original ARM64 dispatcher executes; virtual module Initialize is an external hook, callback is never invoked by dispatcher')
(ROOT/'work/stage37-entry/initialize-native-oracle.json').write_text(json.dumps(result,indent=2),encoding='utf-8')
print(json.dumps(result,indent=2))
