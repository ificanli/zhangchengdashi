import json,re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
WORK=Path(__file__).resolve().parent
data=json.loads((ROOT/'outputs/IDA分析材料/Il2Cpp导出/script.json').read_text(encoding='utf-8-sig'))
byaddr={r['Address']:r for rows in data.values() if isinstance(rows,list) for r in rows if isinstance(r,dict) and 'Address' in r}
for p in (WORK/'ida/pseudocode').glob('*.c'):
    def repl(m):
        row=byaddr.get(int(m[2],16));name=row.get('Name',row.get('Value')) if row else None
        return m[0] if name is None else m[0]+' /* '+str(name)+' */'
    (p.parent/(p.stem+'.annotated.txt')).write_text(re.sub(r'((?:qword|off|unk)_)([0-9A-Fa-f]+)',repl,p.read_text(encoding='utf-8')),encoding='utf-8')
status=json.loads((WORK/'ida/status-supplement.json').read_text())
print(json.dumps(dict(stage=status['stage'],count=len(status['methods']),boundary_mismatch=[r['name'] for r in status['methods'] if r.get('actual_function_start')!=hex(r['address']) or r.get('actual_function_end')!=hex(r['end'])],jumpouts=[dict(name=r['name'],address=hex(r['address'])) for r in status['methods'] if r.get('unresolved_jumpout')]),ensure_ascii=False))
