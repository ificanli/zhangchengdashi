import hashlib,json,shutil
from pathlib import Path
root=Path(__file__).resolve().parents[2]
work=root/'work/stage33-time'
project=(root/'outputs/OccupyCityRecovered').resolve()
manifest=json.loads((work/'candidate-manifest.json').read_text(encoding='utf-8'))
def rawhash(path):return hashlib.sha256(path.read_bytes()).hexdigest().upper()
def originalhash(path):
    with path.open('r',encoding='utf-8-sig',newline='') as f:return hashlib.sha256(f.read().encode('utf-8')).hexdigest().upper()
for row in manifest:
    path=(project/row['file']).resolve()
    assert path.is_relative_to(project),path
    assert originalhash(path)==row['beforeSha256'],('Source changed',path)
    assert rawhash(Path(str(path)+'.meta'))==row['metaSha256'],('Meta changed',path)
    candidate=work/'candidate'/row['file']
    assert rawhash(candidate)==row['candidateSha256'],('Candidate changed',candidate)
    backup=root/'work/recovery-stubs/stage33-time-before'/row['file']
    assert not backup.exists(),('Backup exists',backup)
for row in manifest:
    path=project/row['file'];candidate=work/'candidate'/row['file']
    backup=root/'work/recovery-stubs/stage33-time-before'/row['file']
    backup.parent.mkdir(parents=True,exist_ok=True)
    shutil.copy2(path,backup);shutil.copy2(Path(str(path)+'.meta'),Path(str(backup)+'.meta'))
    path.write_bytes(candidate.read_bytes())
    assert rawhash(path)==row['candidateSha256']
    assert rawhash(Path(str(path)+'.meta'))==row['metaSha256']
    row['productionSha256']=rawhash(path)
    row['backup']=str(backup)
(work/'applied.json').write_text(json.dumps(manifest,ensure_ascii=False,indent=2),encoding='utf-8')
print('Stable: 2 source files applied; both meta hashes unchanged. 41 bodies + original cctor + 3 properties; no further source writes.')
