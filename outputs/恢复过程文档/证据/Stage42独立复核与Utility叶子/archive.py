import hashlib
import json
import shutil
from pathlib import Path

OWN = Path(__file__).resolve().parent
ROOT = OWN.parents[1]
DEST = ROOT / 'outputs/恢复过程文档/证据/Stage42独立复核与Utility叶子'
sha = lambda path: hashlib.sha256(path.read_bytes()).hexdigest()
utility = json.loads((OWN / 'utility/final-audit.json').read_text(encoding='utf-8'))
source = ROOT / 'outputs/OccupyCityRecovered' / utility['source']
assert sha(source) == utility['sourceSha256'] and sha(source.with_suffix('.cs.meta')) == utility['metaSha256']
files = {}
for path in OWN.rglob('*'):
    if not path.is_file(): continue
    rel = path.relative_to(OWN)
    if any(part in ['bin', 'obj', '__pycache__'] for part in rel.parts) or path.suffix.lower() in ['.dll', '.pdb', '.exe'] or path.name.endswith('.all.il.txt'):
        continue
    files[path] = rel
for name in ['stage42-independent-review.json', 'stage42-utility-handoff.json', 'stage42-handoff.json']:
    files[ROOT / 'work/parallel-coordination' / name] = Path(name)
report = ROOT / 'outputs/恢复过程文档/42A-原流程独立复核与命名依赖扩展.md'
files[report] = Path(report.name)
status = ROOT / 'work/ida-framework-assets/status-stage42-utility.json'
files[status] = Path('original-native/status-stage42-utility.json')
for address in ['0x511d668', '0x71e37c0']:
    for suffix in ['.c', '.asm.txt']:
        p = ROOT / 'work/ida-framework-assets/pseudocode' / (address + suffix)
        assert p.exists(), str(p)
        files[p] = Path('original-native') / p.name
review = json.loads((ROOT / 'work/parallel-coordination/stage42-independent-review.json').read_text(encoding='utf-8'))
for row in review['nativeSamples']:
    p = ROOT / 'work/parallel-42-fsm/ida/pseudocode' / (row['start'] + '.asm.txt')
    assert sha(p) == row['asmSha256']
    files[p] = Path('original-native/stage42-samples') / p.name
manifest = []
for src, rel in sorted(files.items(), key=lambda entry: str(entry[1])):
    target = DEST / rel
    target.parent.mkdir(parents=True, exist_ok=True)
    shutil.copy2(src, target)
    assert sha(src) == sha(target)
    manifest.append(dict(path=rel.as_posix(), bytes=target.stat().st_size, sha256=sha(target)))
result = dict(stage='42-independent-review-and-required-Utility-leaf', status='stable-verified-runtime-not-accepted', fileCount=len(manifest), totalBytes=sum(row['bytes'] for row in manifest), utilitySourceSha256=utility['sourceSha256'], utilityMetaSha256=utility['metaSha256'], production42IntegrationOwner='root', UnityOperations=0, files=manifest)
(DEST / 'archive-manifest.json').write_text(json.dumps(result, ensure_ascii=False, indent=2), encoding='utf-8')
print(json.dumps({k: v for k, v in result.items() if k != 'files'}, ensure_ascii=True, indent=2))
