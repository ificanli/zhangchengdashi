from pathlib import Path
import json, struct, sys, random, itertools

ROOT = Path(__file__).resolve().parents[2]
sys.path.insert(0, str(ROOT / 'work/tools/unicorn-recovery'))
from unicorn import Uc, UC_ARCH_ARM64, UC_MODE_ARM
from unicorn.arm64_const import UC_ARM64_REG_X0, UC_ARM64_REG_X1, UC_ARM64_REG_X30, UC_ARM64_REG_SP, UC_ARM64_REG_W0

with (ROOT / 'work/ida-input/libil2cpp-arm64.so').open('rb') as source:
    source.seek(0x3D26600)
    code = source.read(160)
vectors = list(itertools.product(range(-2,3), repeat=4))
rng = random.Random(20261019)
vectors += [tuple(rng.randint(-2147483648,2147483647) for _ in range(4)) for _ in range(512)]
rows = []
for aq, ar, bq, br in vectors:
    cpu = Uc(UC_ARCH_ARM64, UC_MODE_ARM)
    cpu.mem_map(0x3D2A000, 0x2000)
    cpu.mem_write(0x3D2A600, code)
    cpu.mem_map(0x1000000, 0x2000)
    cpu.reg_write(UC_ARM64_REG_SP, 0x1001000)
    cpu.reg_write(UC_ARM64_REG_X30, 0x3D2B000)
    # Enter with the runtime metadata/class initialization guards already satisfied.
    # The method's complete original 160-byte body runs; no game arithmetic is replaced.
    cpu.mem_map(0x8FFD000, 0x1000)
    cpu.mem_write(0x8FFD24D, b'\x01')
    cpu.mem_map(0x8ACC000, 0x1000)
    cpu.mem_write(0x8ACC8F0, struct.pack('<Q', 0x9000000))
    cpu.mem_map(0x9000000, 0x2000)
    cpu.mem_write(0x9000000, struct.pack('<Q', 0x9001000))
    cpu.mem_write(0x90010E0, struct.pack('<I', 1))
    cpu.reg_write(UC_ARM64_REG_X0, (aq & 0xFFFFFFFF) | ((ar & 0xFFFFFFFF) << 32))
    cpu.reg_write(UC_ARM64_REG_X1, (bq & 0xFFFFFFFF) | ((br & 0xFFFFFFFF) << 32))
    cpu.emu_start(0x3D2A600, 0x3D2B000, count=100)
    result = struct.unpack('<i', struct.pack('<I', cpu.reg_read(UC_ARM64_REG_W0)))[0]
    rows.append(dict(aq=aq, ar=ar, bq=bq, br=br, native=result))
target = ROOT / 'work/il-recovery/native-hex-golden.json'
target.write_text(json.dumps(rows, indent=2), encoding='utf-8')
print(f'Executed complete original HexDistance body with initialized runtime guards for {len(rows)} vectors -> {target}')
