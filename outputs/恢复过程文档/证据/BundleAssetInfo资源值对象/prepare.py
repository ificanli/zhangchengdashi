import json
import shutil
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/bundleassetinfo-recovery'
OWN.mkdir(exist_ok=True)
SOURCE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/GFRunning/GameFramework/Resources/BundleAssetInfo.cs'
before=OWN/'source-before';before.mkdir(exist_ok=True)
for source in [SOURCE,SOURCE.with_suffix('.cs.meta')]:
    target=before/source.name
    if not target.exists():shutil.copy2(source,target)
script=(ROOT/'work/gamemanager-recovery/inspect_native.py').read_text(encoding='utf-8').replace('work/gamemanager-recovery','work/bundleassetinfo-recovery')
script=script.replace("entries=[e for e in mapping['ScriptMethod'] if e['Name'].startswith('GameModule.GameManager') ]","entries=[e for e in mapping['ScriptMethod'] if e['Name'].startswith('GameFramework.Resources.BundleAssetInfo')]")
(OWN/'inspect_native.py').write_text(script,encoding='utf-8')
print('prepared BundleAssetInfo source-before and original scanner')
