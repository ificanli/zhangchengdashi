import hashlib
import json
import shutil
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/stage37-entry'
DEST=ROOT/'outputs/恢复过程文档/证据/首场景入口第一批恢复'
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
audit=json.loads((OWN/'final-audit.json').read_text(encoding='utf-8'))
files={}
for path in OWN.rglob('*'):
    if not path.is_file():continue
    relative=path.relative_to(OWN)
    if any(part in {'bin','obj','__pycache__','candidate'} for part in relative.parts):continue
    if path.suffix.lower() in {'.dll','.exe','.pdb','.i64','.idb','.cache'}:continue
    files[path]=relative
for item in audit['files']:
    source=ROOT/'outputs/OccupyCityRecovered'/item['path']
    assert sha(source)==item['sourceAfterSha256']
    files[source]=Path('source-after')/item['path']
    files[source.with_suffix('.cs.meta')]=Path('source-after')/(item['path']+'.meta')
original=ROOT/'outputs/恢复过程文档/证据/首场景框架入口恢复'
for name in ['native-evidence.json','original-method-metadata.json','minimal-recovery-plan.json']:
    files[original/name]=Path('stage32-reference')/name
for item in audit['identities']:
    address=item['address']
    for suffix in ['.asm.txt','.c','.annotated.txt']:
        source=OWN/'ida/pseudocode'/(address+suffix)
        if not source.exists():source=ROOT/'work/start-entry-plan/native'/(address+suffix)
        if source.exists():files[source]=Path('restored-native')/(address+suffix)
for name in ['unity-play-main3.json','unity-play-main4.json']:
    files[ROOT/'work/recovery-ledger'/name]=Path('root-observations')/name
files[ROOT/'outputs/恢复过程文档/37-首场景入口第一批恢复.md']=Path('37-首场景入口第一批恢复.md')
entries=[]
for source,relative in sorted(files.items(),key=lambda x:str(x[1])):
    target=DEST/relative
    target.parent.mkdir(parents=True,exist_ok=True)
    shutil.copy2(source,target)
    assert sha(source)==sha(target)
    entries.append(dict(path=relative.as_posix(),bytes=target.stat().st_size,sha256=sha(target)))
result=dict(stage=37,status=audit['status'],fileCount=len(entries),totalBytes=sum(e['bytes'] for e in entries),files=entries)
(DEST/'archive-manifest.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({k:v for k,v in result.items() if k!='files'},indent=2))
