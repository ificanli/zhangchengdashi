"""Extract the currently delivered candidate bodies. Baseline mode extracts original stubs."""
import hashlib,json,re,sys
from pathlib import Path
WORK=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-44-battle')
sys.path.insert(0,str(WORK))
from bootstrap import members
is_next='--next' in sys.argv
mode=('baseline' if '--baseline' in sys.argv else 'candidate')+('-next' if is_next else '')
REL='Assets/Scripts/Assembly-CSharp/GameModule/BattleGameSceneManager.cs'
p=WORK/('source-before' if '--baseline' in sys.argv else ('candidate-next' if is_next else 'candidate'))/REL
text=p.read_text(encoding='utf-8-sig'); rows=members(text)
recovery=json.loads((WORK/('scene-recovery.next.json' if is_next else 'scene-recovery.json')).read_text(encoding='utf-8'))
addresses={int(x['rva'],16) for x in recovery['methods']}
key_start=text.index('private struct RoleTargetFrameCacheKey')
brace=text.index('{',key_start);depth=1;end=brace+1
while depth:
    if text[end]=='{':depth+=1
    if text[end]=='}':depth-=1
    end+=1
key=re.sub(r'^\s*\[[^\n]*\]\s*$', '', text[key_start:end], flags=re.M).replace('private struct','public struct',1)
fields=['_currentRoleInstanceID','_playerRoleRoot','_enemyRoleRoot','_generateHexObjRoot','_generateHexBehaviour','_roleTargetFrameCache','_roleTargetFrameCacheFrame','_playerRoleCount','_enemyRoleCount','_playerReservedCount','_enemyReservedCount','_playerWaitingBarracks','_enemyWaitingBarracks','_playerLegendaryUnitCount','_enemyLegendaryUnitCount','_playerLegendaryBarracksCount','_enemyLegendaryBarracksCount','allPlayerRoleObj','allEnemyRoleObj','allPlayerRoleBehaviour','allEnemyRoleBehaviour','allRoleBehaviour','allPlayerStayOpenHexObj','allEnemyStayOpenHexObj','allHexObj','allPlayerHasOpenHexObj','allEnemyHasOpenHexObj','allPlayerArchitectureObj','allEnemyArchitectureObj','allHexObjBehaviour','allHexObjMat','allEnemyStayOpenHexObjBehaviours','allArchitectureBehaviours','allPlayerArchitectureBehaviours','allEnemyArchitectureBehaviours','specialHexPos','_playerArchitectureRoot','_enemyArchitectureRoot','_destroyObjRoot','_specialHexRoot','_webGLNavigationManager','_skillIndicator','_skillIndicatorRenderer','_playerComboWallCount','_enemyComboWallCount','currentUpdateInterTime','updateInterTime','upgradeing','playerCanGetWoodNum','enemyCanGetWoodNum','playerMainTowerIsDestroy','enemyMainTowerIsDestroy','sceneGoldMineCanCreatCount','sceneGoldMineMirrorSideCount']
declarations=[]
for f in fields:
    match=re.search(r'^\s*(?:private|public|protected)\s+[^\n{};]+\b'+re.escape(f)+r'\b[^\n;]*;',text,re.M)
    assert match,f
    declarations.append(re.sub(r'\bprivate\b|\bprotected\b','public',match[0].strip()))
parts=['using System;\nusing System.Collections.Generic;\nusing System.Threading.Tasks;\nusing UnityEngine;\nnamespace GameModule { public class BattleGameSceneManager {',key,'public Transform transform = new Transform();','public struct RoleTargetFrameCacheValue { public RoleBehaviour target; }','const int MAX_ROLE_COUNT=100; const int BATCH_SIZE=50; const int RoleTargetMaxHexSearchRing=10; const float RoleTargetRangeCachePrecision=100f;',*declarations]
for m in rows:
    a=int(m['rva'],16)
    if a not in addresses or a>=0x3df9650:continue
    signature=re.sub(r'\[[^\n]*\]\s*','',m['signature'])
    if a in (0x3ded8ec,0x3dea55c,0x3dea5b4):
        name={0x3ded8ec:'MaxRoleCount',0x3dea55c:'PlayerHasHex',0x3dea5b4:'EnemyHasHex'}[a]
        parts.append('public int '+name+' { get {'+m['body']+'} }'); continue
    signature=re.sub(r'\bprivate\b|\bprotected\b','public',signature)
    signature=re.sub(r'\boverride\s+','',signature).replace('UniTaskVoid','Task').replace('UniTask','Task')
    if a==0x3dee5d0:signature=re.sub(r'public\s+(?:async\s+)?void\s+StartGame','public async Task StartGame',signature)
    body=m['body'].replace('UniTask.WhenAll(', 'Task.WhenAll(').replace('UniTask.Yield()', 'BatchScheduler.Yield()')
    parts.append(signature+' {'+body+'}')
parts.append('} }')
(WORK/'scene-validation/Scene.fixture.cs').write_text('\n'.join(parts),encoding='utf-8')
(WORK/'scene-validation/extraction.json').write_text(json.dumps(dict(mode=mode,source=str(p),sha256=hashlib.sha256(p.read_bytes()).hexdigest(),methods=len(addresses),adaptation='Original bodies copied; access changed private to public; Unity/manager dependencies are test-controlled adapters; no business implementation duplicate.'),indent=2),encoding='utf-8')
print(f'EXTRACTED {mode} methods={len(addresses)} source_sha256={hashlib.sha256(p.read_bytes()).hexdigest()}')
