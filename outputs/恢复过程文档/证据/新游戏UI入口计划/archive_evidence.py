import hashlib
import json
import shutil
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];OWN=ROOT/'work/stage48-new-ui';DEST=ROOT/'outputs/恢复过程文档/证据/新游戏UI入口计划'
SOURCE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/UIFramework/UIManager.cs'
assert SOURCE.read_bytes()==(OWN/'source-before/UIManager.cs').read_bytes()
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
files={}
for path in OWN.rglob('*'):
    if not path.is_file():continue
    rel=path.relative_to(OWN)
    if any(part in{'bin','obj','__pycache__'}for part in rel.parts)or path.suffix.lower()in{'.dll','.exe','.pdb','.i64','.idb'}:continue
    files[path]=rel
files[ROOT/'outputs/恢复过程文档/48-新游戏UI入口最小恢复路线.md']=Path('48-新游戏UI入口最小恢复路线.md')
files[ROOT/'work/parallel-coordination/stage48-ui-plan-handoff.json']=Path('stage48-ui-plan-handoff.json')
manifest=[]
for source,rel in sorted(files.items(),key=lambda x:str(x[1])):
    target=DEST/rel;target.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(source,target);assert sha(source)==sha(target);manifest.append(dict(path=rel.as_posix(),bytes=target.stat().st_size,sha256=sha(target)))
result=dict(stage=48,status='read-only-plan-and-work-candidate-production-unchanged',sourceSha256=sha(SOURCE),fileCount=len(manifest),totalBytes=sum(m['bytes']for m in manifest),files=manifest)
(DEST/'archive-manifest.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8');print(json.dumps({k:v for k,v in result.items()if k!='files'},indent=2))
