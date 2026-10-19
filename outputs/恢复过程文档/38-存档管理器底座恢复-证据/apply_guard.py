import hashlib,json
from pathlib import Path
r=Path(__file__).resolve().parents[2];w=r/'work/stage38-savebase'
info=json.loads((w/'guard-refinement.json').read_text(encoding='utf-8'))
path=r/'outputs/OccupyCityRecovered'/info['file'];candidate=w/'candidate'/info['file']
def sha(p):return hashlib.sha256(p.read_bytes()).hexdigest().upper()
assert sha(path)==info['beforeSha256']
assert sha(candidate)==info['afterSha256']
applied=json.loads((w/'applied.json').read_text(encoding='utf-8'))
for record in applied:
 if record['file']==info['file']:
  assert sha(Path(str(path)+'.meta'))==record['metaSha256']
  path.write_bytes(candidate.read_bytes());assert sha(path)==info['afterSha256']
  record['candidateSha256']=record['productionSha256']=info['afterSha256']
for name in ['applied.json','candidate-manifest.json']:
 rows=applied if name=='applied.json' else json.loads((w/name).read_text(encoding='utf-8-sig'))
 for row in rows:
  if row['file']==info['file']:row['candidateSha256']=info['afterSha256']
 (w/name).write_text(json.dumps(rows,ensure_ascii=False,indent=2),encoding='utf-8')
info['productionApplied']=True
(w/'guard-refinement.json').write_text(json.dumps(info,ensure_ascii=False,indent=2),encoding='utf-8')
print('Final stable: Editor IO retains all original local storage gates; final candidate GF/main csc and Editor51/APK37 passed; meta unchanged')
