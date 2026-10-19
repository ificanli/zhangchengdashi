from pathlib import Path
import hashlib
import json
import struct
import sys

OWN = Path(__file__).resolve().parent
ROOT = OWN.parents[2]
sys.path.insert(0, str(ROOT / 'work/tools/unicorn-recovery'))
from unicorn import Uc, UC_ARCH_ARM64, UC_MODE_ARM, UC_HOOK_CODE
import unicorn.arm64_const as A

ELF = (ROOT / 'work/ida-input/libil2cpp-arm64.so').read_bytes()
def elf_bytes(address, size):
    phoff = struct.unpack_from('<Q', ELF, 32)[0]
    esize, count = struct.unpack_from('<HH', ELF, 54)
    for index in range(count):
        typ, flags, offset, va, physical, fsize, msize, align = struct.unpack_from('<IIQQQQQQ', ELF, phoff + esize * index)
        if typ == 1 and va <= address and address + size <= va + fsize:
            return ELF[offset + address - va:offset + address - va + size]
    raise ValueError(hex(address))

class Native:
    def __init__(self, full_name='Owner.X', name=None, null_type=False, fail_getter=False, cold=False):
        self.cpu = Uc(UC_ARCH_ARM64, UC_MODE_ARM)
        self.pages, self.strings, self.trace, self.error = set(), {}, [], None
        self.heap = 0x40000000
        self.fail_getter = fail_getter
        self.write(0x511d668, elf_bytes(0x511d668, 116))
        self.write(0x71e37c0, elf_bytes(0x71e37c0, 148))
        self.method, self.context, self.klass, self.type = [self.alloc() for _ in range(4)]
        self.handle = self.type
        self.ptr(self.type, self.klass)
        self.ptr(self.klass + 0x308, 0x30000000)
        self.ptr(self.klass + 0x310, self.method)
        self.ptr(self.method + 0x38, 0 if cold else self.context)
        self.ptr(self.context, self.handle)
        self.ptr(0x8acc830, 0x8ceea50)
        self.ptr(0x8ceea50, self.klass)
        self.write(self.klass + 0xe0, struct.pack('<I', 1))
        self.write(0x9009678, b'\x01')
        self.ptr(0x8b0de68, 0x8d857d0)
        self.format_string = self.string('{0}.{1}')
        self.ptr(0x8d857d0, self.format_string)
        self.full_name = self.string(full_name)
        self.name = self.string(name)
        self.type_argument = 0 if null_type else self.type
        self.stop = 0x30001000
        self.write(self.stop, b'\xc0\x03\x5f\xd6')
        self.reg('sp', self.alloc(0x10000) + 0xf000)
        self.reg('x30', self.stop)
        for address in [0x30000000, 0x750a620, 0x750aa4c, 0x76935a4, 0x3c3d280, 0x3c3d294, 0x3c503fc, 0x3c3d4cc]:
            self.write(address, b'\xc0\x03\x5f\xd6')
        self.cpu.hook_add(UC_HOOK_CODE, self.hook)
    def write(self, address, data):
        for page in range(address & ~4095, (address + len(data) + 4095) & ~4095, 4096):
            if page not in self.pages:
                self.cpu.mem_map(page, 4096)
                self.pages.add(page)
        self.cpu.mem_write(address, data)
    def alloc(self, size=0x1000):
        address = self.heap
        self.heap += (size + 4095) & ~4095
        self.write(address, bytes(size))
        return address
    def ptr(self, address, value): self.write(address, struct.pack('<Q', value))
    def reg(self, name, value=None):
        reg = getattr(A, 'UC_ARM64_REG_' + name.upper())
        if value is None: return self.cpu.reg_read(reg)
        self.cpu.reg_write(reg, value)
    def string(self, value):
        if value is None: return 0
        address = self.alloc()
        self.strings[address] = value
        return address
    def ret(self, result=None):
        if result is not None: self.reg('x0', result)
        self.reg('pc', self.reg('x30'))
    def abort(self, error):
        self.error = error
        self.cpu.emu_stop()
    def hook(self, cpu, address, size, user):
        if address == self.stop: self.cpu.emu_stop()
        elif address == 0x30000000:
            self.trace.append('Type.FullName')
            if self.fail_getter: self.abort('ProbeException')
            else: self.ret(self.full_name)
        elif address == 0x750a620:
            self.trace.append('String.IsNullOrEmpty')
            self.ret(int(self.strings.get(self.reg('x0')) in [None, '']))
        elif address == 0x750aa4c:
            self.trace.append('String.Format')
            assert self.reg('x0') == self.format_string
            first, second = self.strings.get(self.reg('x1')), self.strings.get(self.reg('x2'))
            self.ret(self.string((first or '') + '.' + (second or '')))
        elif address == 0x76935a4:
            self.trace.append('Type.GetTypeFromHandle')
            assert self.reg('x0') == self.handle
            self.ret(self.type)
        elif address in [0x3c3d280, 0x3c3d294]:
            self.trace.append('IL2CPP.initialize_runtime_metadata')
            self.ret()
        elif address == 0x3c503fc:
            self.trace.append('IL2CPP.inflate_generic_context')
            assert self.reg('x0') == self.method
            self.ptr(self.method + 0x38, self.context)
            self.ret()
        elif address == 0x3c3d4cc: self.abort('NullReferenceException')
    def run(self, generic=False):
        self.reg('x0', self.name if generic else self.type_argument)
        self.reg('x1', self.method if generic else self.name)
        self.reg('x2', 0)
        try:
            self.cpu.emu_start(0x511d668 if generic else 0x71e37c0, 0, count=2000)
        except Exception as error:
            raise RuntimeError(dict(pc=hex(self.reg('pc')), trace=self.trace, x0=hex(self.reg('x0')), x1=hex(self.reg('x1')), x8=hex(self.reg('x8')), x9=hex(self.reg('x9')), sp=hex(self.reg('sp')))) from error
        return dict(value=self.strings.get(self.reg('x0')), returnedOriginalFullName=self.reg('x0') == self.full_name, error=self.error, trace=self.trace)

cases = []
for name in [None, '', 'normal', 'A.B', ' ', ' name ', '\u4e2d\u6587', '{0}', '.']:
    n = Native(name=name)
    row = n.run()
    assert row['error'] is None
    assert row['value'] == ('Owner.X' if name in [None, ''] else 'Owner.X.' + name)
    assert row['returnedOriginalFullName'] == (name in [None, ''])
    assert row['trace'] == ['Type.FullName', 'String.IsNullOrEmpty'] + ([] if name in [None, ''] else ['String.Format'])
    cases.append(dict(case='typed_name_' + repr(name), **row))
for full_name in [None, '']:
    for name in [None, '', 'X']:
        row = Native(full_name=full_name, name=name).run()
        assert row['value'] == (full_name if name in [None, ''] else '.X') and row['error'] is None
        cases.append(dict(case='typed_fullname_' + repr(full_name) + '_name_' + repr(name), **row))
for name in [None, '', 'X']:
    row = Native(name=name, null_type=True).run()
    assert row['error'] == 'NullReferenceException' and row['trace'] == []
    cases.append(dict(case='null_type_' + repr(name), **row))
    row = Native(name=name, fail_getter=True).run()
    assert row['error'] == 'ProbeException' and row['trace'] == ['Type.FullName']
    cases.append(dict(case='getter_abort_' + repr(name), **row))
for cold in [False, True]:
    for name in [None, '', 'X']:
        row = Native(name=name, cold=cold).run(generic=True)
        assert row['error'] is None and row['value'] == ('Owner.X' if name in [None, ''] else 'Owner.X.X')
        assert row['trace'].count('Type.GetTypeFromHandle') == 1
        assert ('IL2CPP.inflate_generic_context' in row['trace']) == cold
        cases.append(dict(case='generic_' + ('cold_' if cold else 'warm_') + repr(name), **row))
status = json.loads((ROOT / 'work/ida-framework-assets/status-stage42-utility.json').read_text(encoding='utf-8'))
assert status['stage'] == 'complete' and all(m['actual_function_start'] == hex(m['address']) and m['actual_function_end'] == hex(m['end']) for m in status['methods'])
report = dict(passed=len(cases), cases=cases, elfSha256=hashlib.sha256(ELF).hexdigest(), codeHashes={hex(a): hashlib.sha256(elf_bytes(a, size)).hexdigest() for a, size in [(0x511d668, 116), (0x71e37c0, 148)]}, originalTemplate=dict(metadataAddress='0x8D857D0', value='{0}.{1}'), boundaries=['System.Type.FullName virtual accessor, Type.GetTypeFromHandle, string.IsNullOrEmpty and string.Format are runtime boundary adapters', 'The original helper machine branches, generic dispatch, exact returned reference and ordering execute in Unicorn', 'Getter error stops at the callback boundary; managed exception unwinding is verified by C# fixtures'], independentBoundedNativeStatus='work/ida-framework-assets/status-stage42-utility.json')
(OWN / 'native-results.json').write_text(json.dumps(report, ensure_ascii=False, indent=2), encoding='utf-8')
print('Original helper ARM64 cases passed:', len(cases))
print(json.dumps(report['codeHashes'], indent=2))
