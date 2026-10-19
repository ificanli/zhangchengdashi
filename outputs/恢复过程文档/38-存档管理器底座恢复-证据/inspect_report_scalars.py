from pathlib import Path
import re,struct,json
r=Path.cwd();f=r/'outputs/OccupyCityRecovered/Assets/Scripts/GFRunning/DBTSDK/NewReport/JsonProperties/activity_complete.cs';src=f.read_text(encoding='utf-8-sig');dll=r/'work/recovery-input/lib/arm64-v8a/libil2cpp.so';matches=[]
with dll.open('rb') as b:
 for m in re.finditer(r'public string (\w+)\s*\{(.*?)(?=\n\t\t\[Token|\Z)',src,re.S):
  for access in re.finditer(r'Address\(RVA = "(0x[0-9A-Fa-f]+)".*?\b(get|set)\b',m[2],re.S):
   rva=int(access[1],16);b.seek(rva-0x4000);ops=struct.unpack('<4I',b.read(16));off=[]
   for op in ops:
    if op==0xD65F03C0:break
    if (op&0xFFC003FF)==0xF9400000 or (op&0xFFC003FF)==0xF9000001:off.append(((op>>10)&0xFFF)*8)
   if any(v in (0x40,0x58) for v in off):matches.append(dict(property=m[1],accessor=access[2],rva=hex(rva),offsets=off,firstOpcodes=[hex(x) for x in ops]))
Path('work/stage38-savebase/report-scalar-native-read.json').write_text(json.dumps(matches,ensure_ascii=False,indent=2),encoding='utf-8');print(json.dumps(matches,ensure_ascii=False))
