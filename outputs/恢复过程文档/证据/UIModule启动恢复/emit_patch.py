import difflib
import hashlib
import json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/stage40-ui'
SOURCE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/GFRunning/GameFramework/UIModule.cs'
BEFORE=OWN/'source-before/UIModule.cs'
assert SOURCE.read_bytes()==BEFORE.read_bytes()
assert SOURCE.with_suffix('.cs.meta').read_bytes()==BEFORE.with_suffix('.cs.meta').read_bytes()
new=(OWN/'UIModule.candidate.cs').read_text(encoding='utf-8')
lines=list(difflib.unified_diff(SOURCE.read_text(encoding='utf-8-sig').splitlines(),new.splitlines(),n=3,lineterm=''))[2:]
patch='*** Begin Patch\n*** Update File: '+SOURCE.as_posix()+'\n'+'\n'.join('@@' if line.startswith('@@')else line for line in lines)+'\n*** End Patch'
print(json.dumps(patch,ensure_ascii=True))
