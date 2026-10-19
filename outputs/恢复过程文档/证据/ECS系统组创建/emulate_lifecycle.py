"""Execute the four original ARM64 lifecycle methods with external API hooks."""
import hashlib
import json
import struct
import sys
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]
OWN = ROOT / 'work/ecs-group-recovery'
sys.path.insert(0, str(ROOT / 'work/tools/unicorn-recovery'))
from unicorn import Uc, UC_ARCH_ARM64, UC_MODE_ARM, UC_HOOK_CODE
import unicorn.arm64_const as arm

raw = (ROOT / 'work/ida-input/libil2cpp-arm64.so').read_bytes()
phoff = struct.unpack_from('<Q', raw, 32)[0]
ps, pn = struct.unpack_from('<HH', raw, 54)
segments = [struct.unpack_from('<IIQQQQQQ', raw, phoff+i*ps) for i in range(pn)]
shoff = struct.unpack_from('<Q', raw, 40)[0]
ss, sn = struct.unpack_from('<HH', raw, 58)
sections = [struct.unpack_from('<IIQQQQIIQQ', raw, shoff+i*ss) for i in range(sn)]
relocs = {}
for section in sections:
    if section[1] != 4:
        continue
    for pos in range(section[4], section[4]+section[5], section[9] or 24):
        offset, info, addend = struct.unpack_from('<QQq', raw, pos)
        if info & 0xffffffff == 1027:
            relocs[offset] = addend


def read(address, count):
    segment = next(s for s in segments if s[0] == 1 and s[3] <= address and address+count <= s[3]+s[5])
    pos = segment[2]+address-segment[3]
    return raw[pos:pos+count]


cpu = Uc(UC_ARCH_ARM64, UC_MODE_ARM)
mapped = set()


def write(address, data):
    for page in range(address & ~0xfff, (address+len(data)+0xfff) & ~0xfff, 0x1000):
        if page not in mapped:
            cpu.mem_map(page, 0x1000)
            mapped.add(page)
    cpu.mem_write(address, data)


def qwrite(address, value):
    write(address, struct.pack('<Q', value))


def qread(address):
    return struct.unpack('<Q', cpu.mem_read(address, 8))[0]


GROUP, MANAGER, CLASS, HIERARCHY = 0x10000000, 0x10002000, 0x10008000, 0x10009000
STOP, STACK = 0x30000000, 0x20000000
write(0x44cd000, read(0x44cd000, 0x1000))
write(GROUP, bytes(0x1000))
write(MANAGER, bytes(0x1000))
write(CLASS, bytes(0x1000))
qwrite(CLASS+0xc8, HIERARCHY)
write(CLASS+0x130, bytes([1]))
qwrite(HIERARCHY, CLASS)
qwrite(MANAGER, CLASS)
write(STACK, bytes(0x10000))
write(STOP, bytes.fromhex('c0035fd6'))
for address in [0x90010B8, 0x90010B9, 0x90010BE, 0x90010BF]:
    write(address, bytes([1]))
for slot in [0x8B00D50, 0x8B00D80, 0x8B00D78]:
    qwrite(slot, relocs[slot])
qwrite(relocs[0x8B00D50], CLASS)
qwrite(relocs[0x8B00D80], 0x60001000)
qwrite(relocs[0x8B00D78], 0x60002000)

trace = []
allocations = []
disposed = []
mode = 'normal'
failed = None
external = {0x7e4383c: 'base-create', 0x7e4395c: 'base-destroy', 0x3c3d4c4: 'new-manager', 0x76c770c: 'object-ctor', 0x7e0e9a4: 'allocator', 0x5b94074: 'list-ctor', 0x5b94760: 'list-dispose'}
null_error = 0x3c3d3a8
# The exact null-exception helper target is decoded from the original OnDestroy BL.
instruction = struct.unpack('<I', read(0x44cd654, 4))[0]
offset = instruction & 0x3ffffff
offset = offset if offset < 0x2000000 else offset-0x4000000
null_error = 0x44cd654+offset*4
external[null_error] = 'null-reference'
for address in external:
    write(address, bytes.fromhex('c0035fd6'))


def hook(uc, address, size, userdata):
    global failed
    if address not in external:
        return
    name = external[address]
    arg = cpu.reg_read(arm.UC_ARM64_REG_X0)
    if name == 'new-manager':
        assert arg == CLASS
        trace.append(name)
        cpu.reg_write(arm.UC_ARM64_REG_X0, MANAGER)
    elif name == 'object-ctor':
        assert arg == MANAGER
        trace.append({'call': name, 'maximumDtBits': struct.unpack('<I', cpu.mem_read(MANAGER+0x1c, 4))[0], 'customScale': struct.unpack('<d', cpu.mem_read(MANAGER+0x48, 8))[0]})
    elif name == 'allocator':
        assert arg == 4
        cpu.reg_write(arm.UC_ARM64_REG_X0, 4)
    elif name == 'list-ctor':
        assert cpu.reg_read(arm.UC_ARM64_REG_X1) == 4
        assert cpu.reg_read(arm.UC_ARM64_REG_X2) == 0x60001000
        pointer = 0x11000000+len(allocations)*0x1000
        qwrite(arg, pointer)
        allocations.append(pointer)
        trace.append({'call': name, 'allocator': 4, 'index': len(allocations)})
    elif name == 'list-dispose':
        assert cpu.reg_read(arm.UC_ARM64_REG_X1) == 0x60002000
        disposed.append(qread(arg))
        trace.append({'call': name, 'fieldOffset': arg-MANAGER})
        qwrite(arg, 0)
    elif name == 'null-reference':
        trace.append(name)
        failed = name
        cpu.emu_stop()
        return
    else:
        assert arg == GROUP
        trace.append(name)
    cpu.reg_write(arm.UC_ARM64_REG_PC, cpu.reg_read(arm.UC_ARM64_REG_LR))


cpu.hook_add(UC_HOOK_CODE, hook)


def execute(address, self_pointer):
    cpu.reg_write(arm.UC_ARM64_REG_SP, STACK+0x10000)
    cpu.reg_write(arm.UC_ARM64_REG_X0, self_pointer)
    cpu.reg_write(arm.UC_ARM64_REG_X1, 0)
    cpu.reg_write(arm.UC_ARM64_REG_LR, STOP)
    cpu.emu_start(address, STOP, count=1000)


execute(0x44cd6ac, GROUP)
assert qread(GROUP+0x88) == MANAGER
assert struct.unpack('<I', cpu.mem_read(MANAGER+0x1c, 4))[0] == 1023969417
assert struct.unpack('<d', cpu.mem_read(MANAGER+0x48, 8))[0] == 1.0
assert qread(MANAGER+0x28) == allocations[0]
assert qread(MANAGER+0x30) == allocations[1]
created_trace = trace[:]
execute(0x44cd5d4, GROUP)
assert disposed == allocations
assert trace[-3:] == ['base-destroy', {'call': 'list-dispose', 'fieldOffset': 40}, {'call': 'list-dispose', 'fieldOffset': 48}]
normal_trace = trace[:]
qwrite(GROUP+0x88, 0)
trace.clear()
execute(0x44cd5d4, GROUP)
assert failed == 'null-reference' and trace == ['base-destroy', 'null-reference']
null_trace = trace[:]
failed = None
OTHER_CLASS = 0x1000a000
write(OTHER_CLASS, bytes(0x1000))
qwrite(MANAGER, OTHER_CLASS)
qwrite(GROUP+0x88, MANAGER)
trace.clear()
execute(0x44cd5d4, GROUP)
assert failed == 'null-reference' and trace == ['base-destroy', 'null-reference']
result = dict(scope='Original ARM64 executes all four methods; external Unity allocation/base APIs are hooks, not Unity runtime', normalTrace=normal_trace, createdTrace=created_trace, nullManagerTrace=null_trace, wrongTypeTrace=trace, groupRateManagerOffset='0x88', maximumDtBits=1023969417, customTimeScale=1.0, queueOffsets=['0x28','0x30'], persistentAllocator=4, cases=3, methods=[{'address':hex(a),'end':hex(b),'sha256':hashlib.sha256(read(a,b-a)).hexdigest()} for a,b in [(0x44cd6ac,0x44cd70c),(0x44cd70c,0x44cd7c4),(0x44cd5d4,0x44cd658),(0x44cd658,0x44cd6ac)]])
(OWN/'native-lifecycle-oracle.json').write_text(json.dumps(result,indent=2),encoding='utf-8')
print(json.dumps(result,indent=2))
