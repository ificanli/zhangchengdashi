import base64,gzip,hashlib,json,re
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/stringtool-recovery';resources=json.loads((root/'work/gzip-recovery/resource-oracle.json').read_text(encoding='utf-8'));records=[]
for r in resources:
    address=r['address'];field='id' if 'EnemyDifficultLevelInfos' in address else 'level' if Path(address).stem=='UserLevelInfo' else None
    if field is None:continue
    path=Path(r['path']);plain=gzip.decompress(base64.b64decode(path.read_text(encoding='utf-8-sig')));data=json.loads(plain.decode('utf-8'));strings=[row[field] for row in data]
    assert all(isinstance(v,str) and re.fullmatch(r'[+-]?[0-9]+',v) for v in strings)
    values=[int(v) for v in strings];assert len(set(values))==len(values);assert all(-2**31<=v<2**31 for v in values)
    records.append(dict(path=str(path),address=address,category=r['category'],sourceSha256=hashlib.sha256(path.read_bytes()).hexdigest(),field=field,keys=strings,expectedIntegers=values,rowCount=len(data),jsonSha256=hashlib.sha256(plain).hexdigest()))
assert len(records)==8 and sum(r['rowCount'] for r in records)==350
(own/'key-oracle.json').write_text(json.dumps(records,ensure_ascii=False,indent=2),encoding='utf-8');print('Original key oracle:',len(records),'actual files,',sum(r['rowCount'] for r in records),'keys; source id/level independently checked')
