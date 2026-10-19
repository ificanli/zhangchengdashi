"""Execute exact original ARM64 scalar decision suffixes; no recreated business oracle."""
import hashlib,json,random,struct,sys
from pathlib import Path
ROOT=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20')
OUT=ROOT/'work/parallel-44-battle/scene-validation'
sys.path.insert(0,str(ROOT/'work/tools/unicorn-recovery'))
from unicorn import Uc,UC_ARCH_ARM64,UC_MODE_ARM
import unicorn.arm64_const as arm
raw=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes()
phoff=struct.unpack_from('<Q',raw,32)[0]; phsize,phnum=struct.unpack_from('<HH',raw,54)
segs=[struct.unpack_from('<IIQQQQQQ',raw,phoff+i*phsize) for i in range(phnum)]
def read_rva(a,n):
    s=next(s for s in segs if s[0]==1 and s[3]<=a and a+n<=s[3]+s[5])
    off=s[2]+a-s[3]; return raw[off:off+n]
def i32(x): return (x+2**31)%2**32-2**31
ranges={'can':(0x3DED968,0x3DED998),'slots':(0x3DEDA20,0x3DEDA60),'reserve':(0x3DEDAF8,0x3DEDB1C),'release':(0x3DEDBB4,0x3DEDBE0),'hash':(0x3DF9758,0x3DF978C),'goldmine':(0x3DFE6D4,0x3DFE6F0)}
cpu=Uc(UC_ARCH_ARM64,UC_MODE_ARM)
cpu.mem_map(0x3DED000,0x1000);cpu.mem_map(0x3DF9000,0x1000);cpu.mem_map(0x3DFE000,0x1000);cpu.mem_map(0x10000000,0x10000)
for start,end in ranges.values(): cpu.mem_write(start,read_rva(start,end-start))
randomizer=random.Random(440019)
boundary=[-2**31,-2**31+1,-100,-1,0,1,98,99,100,101,2**31-2,2**31-1]
cases=[]
for index in range(480):
    values=[randomizer.choice(boundary) if index<200 else randomizer.randrange(-2**31,2**31) for _ in range(5)]
    pc,ec,pr,er,count=values; enemy=bool(index&1); ab=bool((index>>1)&1)
    case=dict(player=pc,enemy=ec,playerReserved=pr,enemyReserved=er,count=count,isEnemy=enemy,ab=ab)
    for name in ('can','slots','reserve','release'):
        cpu.mem_write(0x10000200,struct.pack('<iiii',pc,ec,pr,er))
        cpu.reg_write(arm.UC_ARM64_REG_X19,0x10000000)
        cpu.reg_write(arm.UC_ARM64_REG_W0,int(ab))
        cpu.reg_write(arm.UC_ARM64_REG_W20,(count&0xffffffff) if name in ('reserve','release') else int(enemy))
        cpu.reg_write(arm.UC_ARM64_REG_W21,int(enemy))
        cpu.emu_start(*ranges[name],count=40)
        if name in ('can','slots'): case[name]=i32(cpu.reg_read(arm.UC_ARM64_REG_W0))
        else: case[name]=list(struct.unpack('<iiii',cpu.mem_read(0x10000200,16)))[2:]
    cases.append(case)
hashes=[]
for index in range(512):
    q,r,bucket=[randomizer.choice(boundary) if index<200 else randomizer.randrange(-2**31,2**31) for _ in range(3)]
    enemy=bool(index&1)
    cpu.mem_write(0x10000000,struct.pack('<B3xiii',int(enemy),q,r,bucket))
    cpu.reg_write(arm.UC_ARM64_REG_X0,0x10000000)
    cpu.emu_start(*ranges['hash'],count=20)
    hashes.append(dict(isEnemy=enemy,q=q,r=r,bucket=bucket,hash=i32(cpu.reg_read(arm.UC_ARM64_REG_W0))))
goldmine=[]
for index in range(256):
    count=randomizer.choice(boundary)if index<100 else randomizer.randrange(-2**31,2**31);ab=bool(index&1)
    cpu.mem_write(0x100001AC,struct.pack('<ii',count,-777))
    cpu.reg_write(arm.UC_ARM64_REG_X20,0x10000000);cpu.reg_write(arm.UC_ARM64_REG_W9,count&0xffffffff);cpu.reg_write(arm.UC_ARM64_REG_W0,int(ab))
    cpu.emu_start(*ranges['goldmine'],count=12)
    total,mirror=struct.unpack('<ii',cpu.mem_read(0x100001AC,8))
    goldmine.append(dict(count=count,ab=ab,total=total,mirror=mirror))
report=dict(elf_sha256=hashlib.sha256(raw).hexdigest(),scope='Original ARM64 instruction suffixes after AB getter; W0 is the controlled AB dependency result; instance layout unchanged.',ranges={k:dict(start=hex(a),end=hex(b),sha256=hashlib.sha256(read_rva(a,b-a)).hexdigest()) for k,(a,b) in ranges.items()},capacity=cases,hashes=hashes,goldmine=goldmine)
(OUT/'native-golden.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
print('NATIVE_GOLDEN capacity_cases=480 capacity_operations=1920 hashes=512 goldmine=256 total=2688 errors=0')
