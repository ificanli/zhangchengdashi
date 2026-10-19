import json
import shutil
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/stage40-ui'
SOURCE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/GFRunning/GameFramework/UIModule.cs'
before=OWN/'source-before';before.mkdir(exist_ok=True)
for source in [SOURCE,SOURCE.with_suffix('.cs.meta')]:
    target=before/source.name
    if not target.exists():shutil.copy2(source,target)
inspector=(ROOT/'work/gamemanager-recovery/inspect_native.py').read_text(encoding='utf-8').replace('work/gamemanager-recovery','work/stage40-ui')
inspector=inspector.replace("entries=[e for e in mapping['ScriptMethod'] if e['Name'].startswith('GameModule.GameManager') ]","entries=[e for e in mapping['ScriptMethod'] if e['Name'].startswith('GameFramework.UIModule')]")
(OWN/'inspect_native.py').write_text(inspector,encoding='utf-8')
ida=OWN/'ida';ida.mkdir(exist_ok=True)
for address in [0x71D7558,0x507AE88,0x71D7FD4,0x71D8034,0x71D9768,0x71D976C,0x71D97DC,0x71D97E4,0x71D981C,0x71D805C,0x71D8D5C]:
    for suffix in ['.c','.asm.txt']:
        source=ROOT/'work/ida-framework-assets/pseudocode'/(hex(address)+suffix)
        shutil.copy2(source,ida/source.name)
annotator=(ROOT/'work/gamemanager-recovery/annotate_native.py').read_text(encoding='utf-8').replace('work/gamemanager-recovery','work/stage40-ui').replace("own/'ida/pseudocode'","own/'ida'")
(OWN/'annotate_native.py').write_text(annotator,encoding='utf-8')
print('prepared read-only source-before and native evidence')
