import json,struct,bisect
from pathlib import Path
r=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20');w=r/'work/parallel-44-battle/synergy-validation';m=json.loads((r/'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'));mm={x['Address']:x for x in m['ScriptMethod']};bounds=sorted(mm);targets={a:x for a,x in mm.items() if x['Name'].startswith('GameModule.SynergyEffectManager')};raw=(r/'work/ida-input/libil2cpp-arm64.so').read_bytes();po=struct.unpack_from('<Q',raw,32)[0];ps,pn=struct.unpack_from('<HH',raw,54);rows=[]
for i in range(pn):
 s=struct.unpack_from('<IIQQQQQQ',raw,po+i*ps)
 if s[0]!=1 or not s[1]&1:continue
 for j,(word,) in enumerate(struct.iter_unpack('<I',raw[s[2]:s[2]+s[5]//4*4])):
  if word&0x7c000000!=0x14000000:continue
  a=s[3]+j*4;imm=word&0x3ffffff;imm=imm if imm<0x2000000 else imm-0x4000000;dst=a+imm*4
  if dst not in targets:continue
  idx=bisect.bisect_right(bounds,a)-1;caller=mm[bounds[idx]] if idx>=0 else {'Address':a,'Name':'Unmapped native thunk (before first metadata method)'}
  if caller['Address'] in targets:continue
  rows.append({'callsite':hex(a),'opcode':'BL' if word&0x80000000 else 'B','target':targets[dst],'caller':caller})
(w/'native-callers.json').write_text(json.dumps(rows,ensure_ascii=False,indent=2),encoding='utf-8')
for row in rows:print(row['caller']['Name'],'->',row['target']['Name'])
print('callsites',len(rows))

