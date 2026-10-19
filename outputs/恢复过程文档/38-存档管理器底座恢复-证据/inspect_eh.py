from pathlib import Path
import json
r=Path.cwd();w=r/'work/stage38-savebase';rows=[]
for t in json.loads((w/'native-targets.json').read_text(encoding='utf-8')):
 lines=(r/'work/ida-framework-assets/pseudocode'/f"0x{t['address']:x}.asm.txt").read_text(encoding='utf-8').splitlines()
 calls=[i for i,l in enumerate(lines) if '__cxa_begin_catch' in l]
 if calls:
  excerpts=['\n'.join(lines[max(0,i-5):min(len(lines),i+45)]) for i in calls]
  rows.append(dict(name=t['name'],rva=hex(t['address']),catchBlocks=len(calls),excerpts=excerpts))
(w/'exception-boundaries.json').write_text(json.dumps(rows,ensure_ascii=False,indent=2),encoding='utf-8')
for row in rows:print(row['rva'],row['name'],row['catchBlocks'])
