import json
import shutil
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]
OWN = ROOT / 'work/ecs-group-recovery'
SOURCE = ROOT / 'outputs/OccupyCityRecovered/Assets/Scripts/AstarPathfindingProject/Pathfinding/ECS/AIMovementSystemGroup.cs'
BEFORE = OWN / 'source-before'
BEFORE.mkdir(parents=True, exist_ok=True)
for path in [SOURCE, SOURCE.with_suffix('.cs.meta')]:
    target = BEFORE / path.name
    if not target.exists():
        shutil.copy2(path, target)

inspector = (ROOT / 'work/gamemanager-recovery/inspect_native.py').read_text(encoding='utf-8')
inspector = inspector.replace('work/gamemanager-recovery', 'work/ecs-group-recovery')
inspector = inspector.replace("entries=[e for e in mapping['ScriptMethod'] if e['Name'].startswith('GameModule.GameManager') ]", "entries=[e for e in mapping['ScriptMethod'] if e['Name'].startswith('Pathfinding.ECS.AIMovementSystemGroup') or e['Address'] in {0x7E47174,0x7E4717C}]")
(OWN / 'inspect_native.py').write_text(inspector, encoding='utf-8')

metadata = OWN / 'metadata'
metadata.mkdir(exist_ok=True)
program = (ROOT / 'work/gamemanager-recovery/metadata/Program.cs').read_text(encoding='utf-8')
begin = program.index('string[] names=')
end = program.index('\nvar data=', begin)
program = program[:begin] + 'string[] names=["Pathfinding.ECS.AIMovementSystemGroup","Pathfinding.ECS.AIMovementSystemGroup.TimeScaledRateManager","Unity.Entities.ComponentSystemGroup"];' + program[end:]
program = program.replace('t.FullName=="GameModule.GameManager"?', 'true?').replace('work/gamemanager-recovery/metadata-identities.json','work/ecs-group-recovery/metadata-identities.json').replace('GAMEMANAGER_METADATA','ECS_GROUP_METADATA')
(metadata / 'Program.cs').write_text(program, encoding='utf-8')
shutil.copy2(ROOT / 'work/gamemanager-recovery/metadata/GameManagerMetadata.csproj', metadata / 'ECSMetadata.csproj')
print('prepared source-before, read-only native scanner, metadata query')
