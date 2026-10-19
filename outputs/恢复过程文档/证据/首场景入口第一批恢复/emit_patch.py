import difflib
import hashlib
import json
from pathlib import Path

ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/stage37-entry'
plan=json.loads((OWN/'write-plan.json').read_text(encoding='utf-8'))
parts=['*** Begin Patch']
for entry in plan['files']:
    source=ROOT/'outputs/OccupyCityRecovered'/entry['path']
    candidate=OWN/'candidate'/entry['path']
    before=OWN/'source-before'/entry['path']
    assert hashlib.sha256(source.read_bytes()).hexdigest()==entry['beforeSha256']
    assert source.with_suffix('.cs.meta').read_bytes()==before.with_suffix('.cs.meta').read_bytes()
    lines=list(difflib.unified_diff(source.read_text(encoding='utf-8-sig').splitlines(),candidate.read_text(encoding='utf-8-sig').splitlines(),n=3,lineterm=''))[2:]
    parts.append('*** Update File: '+source.as_posix())
    parts.extend('@@' if line.startswith('@@') else line for line in lines)
parts.append('*** End Patch')
print(json.dumps('\n'.join(parts),ensure_ascii=True))
