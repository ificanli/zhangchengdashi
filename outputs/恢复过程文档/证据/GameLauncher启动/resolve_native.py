import json,re
from pathlib import Path
root=Path(__file__).resolve().parents[2]
own=root/'work/game-launcher-recovery'
data=json.loads((root/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
byaddr={}
for category,items in data.items():
    if isinstance(items,list):
        for row in items:
            if isinstance(row,dict) and 'Address' in row:
                byaddr[row['Address']]={'category':category,**row}
refs={}
for p in (own/'ida/pseudocode').glob('*.c'):
    text=p.read_text(encoding='utf-8')
    addresses={int(a,16) for a in re.findall(r'(?:qword|off|unk)_([A-Fa-f0-9]+)',text)}
    refs[p.name]=[byaddr[a] for a in sorted(addresses) if a in byaddr]
    def replace(m):
        row=byaddr.get(int(m[2],16),{})
        name=row.get('Name',row.get('Value'))
        return m[0] if not name else f'{m[0]} /* {name} */'
    (own/'ida/pseudocode'/f'{p.stem}.annotated.txt').write_text(re.sub(r'((?:qword|off|unk)_)([A-Fa-f0-9]+)',replace,text),encoding='utf-8')
(own/'native-refs.json').write_text(json.dumps(refs,indent=2,ensure_ascii=False),encoding='utf-8')
for k in ['0x41914f8.c','0x41919fc.c']:
    print(k)
    for r in refs[k]: print(hex(r['Address']),r.get('Name',r.get('Value')))
