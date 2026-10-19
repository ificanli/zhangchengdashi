from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];W=Path(__file__).resolve().parent
# Reuse the earlier read-only ELF/relocation decoder, with this task's own output.
source=(ROOT/'work/gamemanager-recovery/inspect_native.py').read_text(encoding='utf-8')
source=source.replace("OUT = ROOT / 'work/gamemanager-recovery'", "OUT = ROOT / 'work/parallel-44-battle/native-entry'")
source=source.replace("entries=[e for e in mapping['ScriptMethod'] if e['Name'].startswith('GameModule.GameManager') ]", "entries=[e for e in mapping['ScriptMethod'] if (e['Name'].startswith('GameModule.CoreGameManager') and 'StartGame' in e['Name']) or (e['Name'].startswith('GameModule.BarracksArchitectureBehaviour') and any(k in e['Name'] for k in ['LoadRole','CreatRole','CreateRole','OnCanSpawnRole','TrySpawn'])) or e['Name'] in ['GameModule.GameManager$$StartCoreGame','GameModule.HexBehaviour$$OpenHex','GameModule.HexBehaviour$$DetermineHexCamp']]")
exec(compile(source,__file__,'exec'))
