import sys,struct,json,hashlib
from pathlib import Path
r=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20');w=r/'work/parallel-44-battle/manager-review-validation';w.mkdir(exist_ok=True);sys.path.insert(0,str(r/'work/tools/unicorn-recovery'))
from unicorn import Uc,UC_ARCH_ARM64,UC_MODE_ARM,UC_HOOK_CODE
import unicorn.arm64_const as a
raw=(r/'work/ida-input/libil2cpp-arm64.so').read_bytes();po=struct.unpack_from('<Q',raw,32)[0];ps,pn=struct.unpack_from('<HH',raw,54);segs=[struct.unpack_from('<IIQQQQQQ',raw,po+i*ps) for i in range(pn)]
def read(ad,n):
 s=next(s for s in segs if s[0]==1 and s[3]<=ad and ad+n<=s[3]+s[5]);return raw[s[2]+ad-s[3]:s[2]+ad-s[3]+n]
cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM);cpu.mem_map(0x3de5000,0x1000);cpu.mem_write(0x3de5108,read(0x3de5108,0x44));SELF,STACK,STOP=0x10000000,0x20000000,0x30000000
for ad,n in [(SELF,0x1000),(STACK,0x10000),(STOP,0x1000)]:cpu.mem_map(ad,n)
word=struct.unpack('<I',read(0x3de5134,4))[0];of=word&0x3ffffff;of=of if of<0x2000000 else of-0x4000000;helper=0x3de5134+of*4;cpu.mem_map(helper&~0xfff,0x1000)
calls=0
def hook(uc,ad,size,data):
 global calls
 if ad==helper:calls+=1;cpu.reg_write(a.UC_ARM64_REG_S0,0x3f000000);cpu.reg_write(a.UC_ARM64_REG_PC,cpu.reg_read(a.UC_ARM64_REG_LR))
cpu.hook_add(UC_HOOK_CODE,hook);rows=[]
for counting in [False,True]:
 for horn in [False,True]:
  for bits in [0,0x80000000,0x3f800000,0xbf800000,0x7fc00000,0x7f800001,0x7f800000,0xff800000,1,0x7f7fffff]:
   cpu.mem_write(SELF+0x50,bytes([counting]));cpu.mem_write(SELF+0x64,bytes([horn]));cpu.mem_write(SELF+0x68,struct.pack('<I',bits));calls=0
   cpu.reg_write(a.UC_ARM64_REG_SP,STACK+0x10000);cpu.reg_write(a.UC_ARM64_REG_X0,SELF);cpu.reg_write(a.UC_ARM64_REG_LR,STOP);cpu.emu_start(0x3de5108,STOP,count=100)
   rows.append({'isCountDowning':counting,'hornIng':horn,'hornTimeBits':bits,'deltaTimeBits':0x3f000000,'deltaTimeCalls':calls,'afterBits':struct.unpack('<I',cpu.mem_read(SELF+0x68,4))[0]})
out={'originalMethodRVA':'0x3DE5108','deltaTimeRVA':hex(helper),'codeSha256':hashlib.sha256(read(0x3de5108,0x44)).hexdigest(),'scope':'Original Update ARM64, only Time.get_deltaTime library hook returns 0.5f','cases':rows};(w/'update-native.json').write_text(json.dumps(out,indent=2),encoding='utf-8');print('40 original Update cases exported; true/true results:');print(json.dumps(rows[-10:],indent=2))
