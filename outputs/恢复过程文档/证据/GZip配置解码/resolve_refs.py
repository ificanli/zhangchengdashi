import json,re
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gzip-recovery';data=json.loads((root/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));mapping={}
for kind,rows in data.items():
    if isinstance(rows,list):
        for r in rows:
            if isinstance(r,dict) and 'Address' in r:mapping[r['Address']]=dict(category=kind,**r)
out={}
for p in (own/'ida/pseudocode').glob('*.c'):
    refs={int(a,16) for a in re.findall(r'(?:qword|off|unk)_([0-9a-fA-F]+)',p.read_text(encoding='utf-8'))};out[p.name]=[mapping[a] for a in sorted(refs) if a in mapping]
(own/'native-refs.json').write_text(json.dumps(out,ensure_ascii=False,indent=2),encoding='utf-8')
for p in ['0x3f80b3c.c','0x3f80978.c']:
    print(p)
    for r in out[p]:print(hex(r['Address']),r.get('Name',r.get('Value')))
