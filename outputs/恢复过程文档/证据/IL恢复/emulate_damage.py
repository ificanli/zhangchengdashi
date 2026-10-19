from pathlib import Path
import json, struct, sys, random

ROOT = Path(__file__).resolve().parents[2]
sys.path.insert(0, str(ROOT / 'work/tools/unicorn-recovery'))
from unicorn import Uc, UC_ARCH_ARM64, UC_MODE_ARM
from unicorn.arm64_const import UC_ARM64_REG_X30, UC_ARM64_REG_W0, UC_ARM64_REG_W1, UC_ARM64_REG_W2, UC_ARM64_REG_W3, UC_ARM64_REG_W4

binary = ROOT / 'work/ida-input/libil2cpp-arm64.so'
with binary.open('rb') as source:
    source.seek(0x3E0B6F0)
    code = source.read(56)
vectors = []
for attack in [0, 1, 2, 3, -1, -3, 100, 16777217, 16777219, 2147483647, -2147483648]:
    for count in [3, 4]:
        for enemy in [False, True]:
            vectors.append((attack, enemy, count, 4))
rng = random.Random(20261019)
for _ in range(512):
    vectors.append((rng.randint(-2147483648, 2147483647), bool(rng.randrange(2)), rng.randint(-2147483648, 2147483647), rng.randint(-2147483648, 2147483647)))
rows = []
for attack, enemy, count, required in vectors:
    cpu = Uc(UC_ARCH_ARM64, UC_MODE_ARM)
    cpu.mem_map(0x3E0F000, 0x2000)
    cpu.mem_write(0x3E0F6F0, code)
    cpu.reg_write(UC_ARM64_REG_X30, 0x3E10000)
    for register, value in [(UC_ARM64_REG_W0, 0), (UC_ARM64_REG_W1, attack), (UC_ARM64_REG_W2, int(enemy)), (UC_ARM64_REG_W3, count), (UC_ARM64_REG_W4, required)]:
        cpu.reg_write(register, value & 0xFFFFFFFF)
    cpu.emu_start(0x3E0F6F0, 0x3E10000, count=100)
    result = struct.unpack('<i', struct.pack('<I', cpu.reg_read(UC_ARM64_REG_W0)))[0]
    rows.append(dict(attack=attack, enemy=enemy, count=count, required=required, native=result))
target = ROOT / 'work/il-recovery/native-damage-golden.json'
target.write_text(json.dumps(rows, indent=2), encoding='utf-8')
print(f'Executed original ARM64 method bytes for {len(rows)} vectors -> {target}')
