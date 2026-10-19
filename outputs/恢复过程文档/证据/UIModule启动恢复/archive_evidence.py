import hashlib
import json
import shutil
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/stage40-ui'
DEST=ROOT/'outputs/恢复过程文档/证据/UIModule启动恢复'
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
audit=json.loads((OWN/'final-audit.json').read_text(encoding='utf-8'))
source=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/GFRunning/GameFramework/UIModule.cs'
assert sha(source)==audit['sourceSha256']
files={}
for path in OWN.rglob('*'):
    if not path.is_file():continue
    relative=path.relative_to(OWN)
    if any(part in {'bin','obj','__pycache__'}for part in relative.parts):continue
    if path.suffix.lower()in{'.dll','.exe','.pdb','.i64','.idb'}or path.name=='GFRunning.full.il.txt':continue
    files[path]=relative
files[source]=Path('source-after/UIModule.cs')
files[source.with_suffix('.cs.meta')]=Path('source-after/UIModule.cs.meta')
files[ROOT/'work/ida-framework-assets/status-stage40-ui.json']=Path('ida/status-stage40-ui.json')
files[ROOT/'work/parallel-coordination/stage40-handoff.json']=Path('stage40-handoff.json')
files[ROOT/'outputs/恢复过程文档/40-UIModule原始启动恢复.md']=Path('40-UIModule原始启动恢复.md')
manifest=[]
for original,relative in sorted(files.items(),key=lambda p:str(p[1])):
    target=DEST/relative;target.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(original,target);assert sha(original)==sha(target)
    manifest.append(dict(path=relative.as_posix(),bytes=target.stat().st_size,sha256=sha(target)))
result=dict(stage=40,status=audit['status'],fileCount=len(manifest),totalBytes=sum(e['bytes']for e in manifest),files=manifest)
(DEST/'archive-manifest.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({k:v for k,v in result.items()if k!='files'},indent=2))
