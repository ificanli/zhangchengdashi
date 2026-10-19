import json,re
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gamemanager-recovery';data=json.loads((root/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));byaddr={r['Address']:r for k,rows in data.items() if isinstance(rows,list) for r in rows if isinstance(r,dict) and 'Address' in r}
for p in (own/'ida/pseudocode').glob('*.c'):
    text=p.read_text(encoding='utf-8')
    def repl(m):
        row=byaddr.get(int(m[2],16));name=row.get('Name',row.get('Value')) if row else None
        return m[0] if name is None else m[0]+' /* '+name+' */'
    text=re.sub(r'((?:qword|off|unk)_)([0-9A-Fa-f]+)',repl,text)
    (own/'ida/pseudocode'/f'{p.stem}.annotated.txt').write_text(text,encoding='utf-8')
print('Annotated',len(list((own/'ida/pseudocode').glob('*.c'))),'functions')
