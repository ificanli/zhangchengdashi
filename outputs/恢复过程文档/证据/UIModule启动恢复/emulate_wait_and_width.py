import hashlib
import json
import math
import struct
import sys
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/stage40-ui'
sys.path.insert(0,str(ROOT/'work/tools/unicorn-recovery'))
from unicorn import Uc,UC_ARCH_ARM64,UC_MODE_ARM,UC_HOOK_CODE
import unicorn.arm64_const as arm
raw=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes()
ph=struct.unpack_from('<Q',raw,32)[0];ps,pn=struct.unpack_from('<HH',raw,54)
segments=[struct.unpack_from('<IIQQQQQQ',raw,ph+i*ps)for i in range(pn)]
def read(a,n):
    s=next(s for s in segments if s[0]==1 and s[3]<=a and a+n<=s[3]+s[5]);p=s[2]+a-s[3];return raw[p:p+n]
wait=[]
for has_action in [False,True]:
    cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM);cpu.mem_map(0x71d9000,0x1000);cpu.mem_write(0x71d976c,read(0x71d976c,112));cpu.mem_map(0x10000000,0x10000)
    obj,callback,hook_at,stop=0x10000000,0x10001000,0x10003000,0x10004000
    cpu.mem_write(obj+0x20,struct.pack('<Q',callback if has_action else 0));cpu.mem_write(callback+0x18,struct.pack('<Q',hook_at));cpu.mem_write(callback+0x40,struct.pack('<Q',0x10005000));cpu.mem_write(callback+0x28,struct.pack('<Q',0x10006000));cpu.mem_write(hook_at,bytes.fromhex('c0035fd6'))
    invoked=[]
    def invoke(uc,pc,size,user):
        if pc==hook_at:
            assert struct.unpack('<i',cpu.mem_read(obj+0x10,4))[0]==-1
            assert cpu.reg_read(arm.UC_ARM64_REG_X0)==0x10005000 and cpu.reg_read(arm.UC_ARM64_REG_X1)==0x10006000
            invoked.append(True);cpu.reg_write(arm.UC_ARM64_REG_PC,cpu.reg_read(arm.UC_ARM64_REG_LR))
    cpu.hook_add(UC_HOOK_CODE,invoke)
    steps=[]
    for index in range(4):
        cpu.reg_write(arm.UC_ARM64_REG_SP,0x10010000);cpu.reg_write(arm.UC_ARM64_REG_X0,obj);cpu.reg_write(arm.UC_ARM64_REG_LR,stop);cpu.emu_start(0x71d976c,stop,count=64)
        steps.append(dict(result=cpu.reg_read(arm.UC_ARM64_REG_W0)&0xff,state=struct.unpack('<i',cpu.mem_read(obj+0x10,4))[0],current=struct.unpack('<Q',cpu.mem_read(obj+0x18,8))[0],callbackCount=len(invoked)))
    assert [s['result']for s in steps]==[1,1,0,0]
    assert [s['state']for s in steps]==[1,2,-1,-1]
    assert all(s['current']==0 for s in steps) and len(invoked)==int(has_action)
    wait.append(dict(actionPresent=has_action,steps=steps))
width=[]
for value in [719.0,720.0,721.0,float('-inf'),float('inf'),float('nan')]:
    cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM);cpu.mem_map(0x507b000,0x1000);cpu.mem_write(0x507b19c,read(0x507b19c,16));cpu.reg_write(arm.UC_ARM64_REG_S0,struct.unpack('<I',struct.pack('<f',value))[0]);skip=[]
    def branch(uc,pc,size,user):
        if pc==0x507b1f0:skip.append(True);cpu.emu_stop()
    cpu.hook_add(UC_HOOK_CODE,branch);cpu.emu_start(0x507b19c,0x507b1ac,count=8)
    crop=not bool(skip)
    assert crop==(value>720.0)
    width.append(dict(input='NaN' if math.isnan(value) else str(value),crop=crop))
result=dict(waitAddress='0x71d976c',waitBytes=112,waitCodeSha256=hashlib.sha256(read(0x71d976c,112)).hexdigest(),waitCases=wait,widthAddress='0x507b19c',widthCodeSha256=hashlib.sha256(read(0x507b19c,16)).hexdigest(),widthCases=width,scope='Original ARM64 state machine and width-branch instructions; delegate invokes an external hook only')
(OWN/'native-wait-and-width-oracle.json').write_text(json.dumps(result,indent=2),encoding='utf-8')
print('original wait MoveNext: 2 action cases x 4 steps; original float width branch: 6 cases; all pass')
