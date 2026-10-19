import difflib
import json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];OWN=ROOT/'work/bundleassetinfo-recovery'
SOURCE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/GFRunning/GameFramework/Resources/BundleAssetInfo.cs'
BEFORE=OWN/'source-before/BundleAssetInfo.cs'
assert SOURCE.read_bytes()==BEFORE.read_bytes()and SOURCE.with_suffix('.cs.meta').read_bytes()==BEFORE.with_suffix('.cs.meta').read_bytes()
lines=list(difflib.unified_diff(SOURCE.read_text(encoding='utf-8-sig').splitlines(),(OWN/'BundleAssetInfo.candidate.cs').read_text(encoding='utf-8').splitlines(),n=10,lineterm=''))[2:]
print(json.dumps('*** Begin Patch\n*** Update File: '+SOURCE.as_posix()+'\n'+'\n'.join('@@'if line.startswith('@@')else line for line in lines)+'\n*** End Patch',ensure_ascii=True))
