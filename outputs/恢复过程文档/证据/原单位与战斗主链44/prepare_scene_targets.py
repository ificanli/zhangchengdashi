import json,re
from pathlib import Path
w=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20\work\parallel-44-battle')
a=json.loads((w/'ida/targets-supplement.json').read_text(encoding='utf-8'))
names=['get_MaxRoleCount','CanSpawnRole','GetAvailableSlots','ReserveRoleSlot','ReleaseReservedSlot','GetRoleTargetsSync','GetRoleTargetSync','TryGetNearestRoleTarget','CollectRoleTargetsInRange','GetRoleTargetList','PrepareRoleTargetFrameCache','TryGetRoleTargetFrameCacheKey','TryGetCachedNearestRoleTarget','CacheNearestRoleTarget','IsRoleTargetValid','TryGetRoleTargetHexSearchRing','TryGetNearestRoleTargetFromHexRing','TryCollectRoleTargetsInRangeFromHexRing','TryGetNearestRoleTargetFromList','CollectRoleTargetsInRangeFromList','SortNearestRoleTargetsInPlace','AddPlayerRole','AddEnemyRole','RemovePlayerRole','RemoveEnemyRole','RegisterWaitingBarracks','UnregisterWaitingBarracks','TrySpawnFromWaitingBarracks','TrySpawnLegendaryFromWaitingBarracks','AddLegendaryBarracks','RemoveLegendaryBarracks','AddLegendaryUnit','RemoveLegendaryUnit','GetLegendaryUnitCount','GetLegendaryBarracksCount','CanSpawnLegendaryUnit','.ctor']
b=[dict(x,priority='capacity_registration_target_closure') for x in a if x['name'].startswith('GameModule.BattleGameSceneManager') and x['name'].split('$$')[-1] in names]
(w/'scene-targets.json').write_text(json.dumps(b,ensure_ascii=False,indent=2),encoding='utf-8')
print(len(b));print('\n'.join(x['name']+' '+hex(x['address']) for x in b))
