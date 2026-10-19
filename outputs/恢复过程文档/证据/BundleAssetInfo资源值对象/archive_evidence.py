import hashlib
import json
import shutil
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];OWN=ROOT/'work/bundleassetinfo-recovery';DEST=ROOT/'outputs/恢复过程文档/证据/BundleAssetInfo资源值对象'
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
audit=json.loads((OWN/'final-audit.json').read_text(encoding='utf-8'))
source=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/GFRunning/GameFramework/Resources/BundleAssetInfo.cs';assert sha(source)==audit['sourceSha256']
files={}
for path in OWN.rglob('*'):
    if not path.is_file():continue
    rel=path.relative_to(OWN)
    if any(part in{'bin','obj','__pycache__'}for part in rel.parts)or path.suffix.lower()in{'.dll','.exe','.pdb','.i64','.idb'}:continue
    files[path]=rel
files[source]=Path('source-after/BundleAssetInfo.cs');files[source.with_suffix('.cs.meta')]=Path('source-after/BundleAssetInfo.cs.meta')
for name in ['0x72eb4ac.c','0x72eb4ac.asm.txt']:
    files[ROOT/'work/ida-framework-assets/pseudocode'/name]=Path('ida')/name
files[ROOT/'work/parallel-coordination/stage39-bundleassetinfo-handoff.json']=Path('stage39-bundleassetinfo-handoff.json')
files[ROOT/'outputs/恢复过程文档/40-UIModule原始启动恢复.md']=Path('40-UIModule原始启动恢复.md')
manifest=[]
for original,rel in sorted(files.items(),key=lambda x:str(x[1])):
    target=DEST/rel;target.parent.mkdir(parents=True,exist_ok=True);shutil.copy2(original,target);assert sha(original)==sha(target);manifest.append(dict(path=rel.as_posix(),bytes=target.stat().st_size,sha256=sha(target)))
result=dict(status=audit['status'],fileCount=len(manifest),totalBytes=sum(m['bytes']for m in manifest),files=manifest)
(DEST/'archive-manifest.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8');print(json.dumps({k:v for k,v in result.items()if k!='files'},indent=2))
