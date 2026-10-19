import struct,sys
from pathlib import Path
root=Path(__file__).resolve().parents[2];sys.path.insert(0,str(root/'work/tools/legacy-inspection'));import capstone
raw=(root/'work/ida-input/libil2cpp-arm64.so').read_bytes();phoff=struct.unpack_from('<Q',raw,32)[0];phsize,phnum=struct.unpack_from('<HH',raw,54);segments=[struct.unpack_from('<IIQQQQQQ',raw,phoff+i*phsize) for i in range(phnum)]
for start,size in [(0x35C1130,512)]:
    seg=next(s for s in segments if s[0]==1 and s[3]<=start<start+size<=s[3]+s[5]);offset=seg[2]+start-seg[3];md=capstone.Cs(capstone.CS_ARCH_ARM64,capstone.CS_MODE_LITTLE_ENDIAN)
    lines=[f'{i.address:#x}: {i.mnemonic} {i.op_str}' for i in md.disasm(raw[offset:offset+size],start)]
    (root/'work/gzip-recovery'/f'{start:#x}.runtime-window.txt').write_text('\n'.join(lines),encoding='utf-8');print('\n'.join(lines[:55]))
