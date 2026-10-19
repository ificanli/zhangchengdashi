import hashlib
import json
import shutil
from pathlib import Path

ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/ecs-group-recovery'
DEST=ROOT/'outputs/恢复过程文档/证据/ECS系统组创建'
SOURCE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/AstarPathfindingProject/Pathfinding/ECS/AIMovementSystemGroup.cs'
sha=lambda path:hashlib.sha256(path.read_bytes()).hexdigest()
audit=json.loads((OWN/'final-audit.json').read_text())
assert sha(SOURCE)==audit['sourceAfterSha256']
files={}
for path in OWN.rglob('*'):
    if not path.is_file():continue
    relative=path.relative_to(OWN)
    if any(part in {'bin','obj','__pycache__'} for part in relative.parts):continue
    if path.suffix.lower() in {'.exe','.dll','.pdb','.i64','.idb'}:continue
    files[path]=relative
files[SOURCE]=Path('source-after/AIMovementSystemGroup.cs')
files[SOURCE.with_suffix('.cs.meta')]=Path('source-after/AIMovementSystemGroup.cs.meta')
for name in ['status-ecs-create.json','status-ecs-dispose.json']:
    files[ROOT/'work/ida-framework-assets'/name]=Path('ida')/name
for address in ['0x44cd6ac','0x44cd70c','0x44cd5d4','0x44cd658']:
    for suffix in ['.c','.asm.txt']:
        files[ROOT/'work/ida-framework-assets/pseudocode'/(address+suffix)]=Path('ida')/(address+suffix)
files[ROOT/'outputs/恢复过程文档/34-ECS系统组原生创建恢复.md']=Path('34-ECS系统组原生创建恢复.md')
manifest=[]
for source,relative in sorted(files.items(),key=lambda item:str(item[1])):
    target=DEST/relative
    target.parent.mkdir(parents=True,exist_ok=True)
    shutil.copy2(source,target)
    assert sha(source)==sha(target)
    manifest.append(dict(path=relative.as_posix(),bytes=target.stat().st_size,sha256=sha(target)))
result=dict(stage=34,status=audit['status'],fileCount=len(manifest),totalBytes=sum(item['bytes'] for item in manifest),sourceSha256=audit['sourceAfterSha256'],metaSha256=audit['metaSha256'],files=manifest)
(DEST/'archive-manifest.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({k:v for k,v in result.items() if k!='files'},ensure_ascii=False,indent=2))
