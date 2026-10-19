from pathlib import Path
import json, sys

ROOT = Path(__file__).resolve().parents[2]
sys.path.insert(0, str(ROOT / 'work/tools/unicorn-recovery'))
from unicorn import Uc, UC_ARCH_ARM64, UC_MODE_ARM
import unicorn.arm64_const as arm

SIZES = {'System.Boolean':1,'System.Byte':1,'System.SByte':1,'System.Int16':2,'System.UInt16':2,'System.Int32':4,'System.UInt32':4,'System.Int64':8,'System.UInt64':8,'System.Single':4,'System.Double':8}
def bits_for(kind, case, parameter=0):
    if kind == 'System.Boolean': return [1,0,1][case]
    if kind == 'System.Single': return [0x3FC00000,0xBF400000,0x4B800001][case]
    if kind == 'System.Double': return [0x3FF8000000000000,0xBFE8000000000000,0x4340000000000001][case]
    return [17 + parameter*3, -7 - parameter*5, 123456789 + parameter*7][case] & ((1 << (8*SIZES[kind]))-1)
def text(value, kind): return f'{value:0{SIZES[kind]*2}X}'
def result(cpu, kind):
    register = arm.UC_ARM64_REG_S0 if kind == 'System.Single' else arm.UC_ARM64_REG_D0 if kind == 'System.Double' else arm.UC_ARM64_REG_X0
    return cpu.reg_read(register) & ((1 << (8*SIZES[kind]))-1)

folder = Path(sys.argv[1]) if len(sys.argv)>1 else ROOT/'work/il-recovery/sample100-probe'
manifest = json.loads((folder/'sample-manifest.json').read_text(encoding='utf-8'))
golden = []
for index, sample in enumerate(manifest):
    cases=[]
    try:
        for case in range(3):
            cpu=Uc(UC_ARCH_ARM64, UC_MODE_ARM)
            address=int(sample['Address'],16)
            page=address & ~0xFFF
            cpu.mem_map(page,0x2000)
            cpu.mem_write(address,bytes.fromhex(sample['CodeHex']))
            cpu.mem_map(0x10000000,0x10000)
            cpu.reg_write(arm.UC_ARM64_REG_X30,page+0x1000)
            integer=0 if sample['IsStatic'] else 1
            floating=0
            if not sample['IsStatic']: cpu.reg_write(arm.UC_ARM64_REG_X0,0x10000000)
            arguments=[]
            for param,kind in enumerate(sample['ParameterTypes']):
                bits=bits_for(kind,case,param)
                arguments.append(text(bits,kind))
                if kind in ('System.Single','System.Double'):
                    register=getattr(arm,('UC_ARM64_REG_S' if kind=='System.Single' else 'UC_ARM64_REG_D')+str(floating))
                    floating+=1
                else:
                    register=getattr(arm,'UC_ARM64_REG_X'+str(integer))
                    integer+=1
                cpu.reg_write(register,bits)
            initial=None
            if sample['FieldType']:
                kind=sample['FieldType']
                initial=bits_for(kind,case)
                if sample['Kind']=='setter': initial = (initial ^ ((1 << (8*SIZES[kind]))-1)) if kind!='System.Boolean' else 1-initial
                cpu.mem_write(0x10000000+sample['FieldOffset'],initial.to_bytes(SIZES[kind],'little'))
            cpu.emu_start(address,page+0x1000,count=100)
            if sample['Kind']=='setter':
                kind=sample['FieldType']
                expected=int.from_bytes(cpu.mem_read(0x10000000+sample['FieldOffset'],SIZES[kind]),'little')
            else:
                kind=sample['ReturnType']
                expected=result(cpu,kind)
            cases.append(dict(arguments=arguments,fieldInitialBits=text(initial,sample['FieldType']) if initial is not None else None,expectedBits=text(expected,kind)))
        constant_output=sample['Kind']=='arithmetic' and len({row['expectedBits'] for row in cases})==1
        golden.append(dict(index=index,method=sample['Method'],kind=sample['Kind'],cases=cases,constantOutput=constant_output,nativeError=None))
    except Exception as error:
        golden.append(dict(index=index,method=sample['Method'],kind=sample['Kind'],cases=cases,constantOutput=False,nativeError=repr(error)))
(folder/'sample-native-golden.json').write_text(json.dumps(golden,indent=2),encoding='utf-8')
print(f'SAMPLE_NATIVE methods={len(golden)} cases={sum(len(x["cases"]) for x in golden)} errors={sum(x["nativeError"] is not None for x in golden)} constantOnly={sum(x["constantOutput"] for x in golden)}')
