import bisect,json,struct,sys
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];W=Path(__file__).resolve().parent
sys.path.insert(0,str(ROOT/'work/tools/legacy-inspection'))
import capstone
data=json.loads((ROOT/'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'))
raw=(ROOT/'work/ida-input/libil2cpp-arm64.so').read_bytes()
ph=struct.unpack_from('<Q',raw,32)[0];sz,num=struct.unpack_from('<HH',raw,54)
segments=[struct.unpack_from('<IIQQQQQQ',raw,ph+i*sz) for i in range(num)]
md=capstone.Cs(capstone.CS_ARCH_ARM64,capstone.CS_MODE_LITTLE_ENDIAN)
targets=[(r['Address'],r['Address']+160,r['Name']) for r in data['ScriptMethod'] if 'BattleGameManager$$<BeginStartCountDown>b__82_0' in r['Name']]
targets += [(0x856dfa0,0x856e080,'BeginStartCountDown outlined await GetResult island')]
ends=sorted(set(data['Addresses']))
out=[]
for a,b,name in targets:
    if a in ends:b=ends[bisect.bisect_right(ends,a)]
    s=next(s for s in segments if s[0]==1 and s[3]<=a and b<=s[3]+s[5]);o=s[2]+a-s[3]
    code=raw[o:o+b-a]
    text='\n'.join(f'{i.address:#x}: {i.mnemonic} {i.op_str}' for i in md.disasm(code,a))
    (W/'ida/pseudocode'/f'{a:#x}.extra.asm.txt').write_text(text,encoding='utf-8')
    out.append(dict(name=name,start=hex(a),end=hex(b),asm=text))
(W/'extra-native.json').write_text(json.dumps(out,indent=2),encoding='utf-8');print(json.dumps(out,indent=2))
