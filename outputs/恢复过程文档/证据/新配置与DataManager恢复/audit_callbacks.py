"""Validate original payload keys consumed by recovered native callback maps."""
import base64,collections,gzip,json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
WORK=ROOT/'work/new-config-restore'
PREFIX='Assets/_Res/Addressable/01FirstBundle/JsonData/'
requests={int(k):v for k,v in json.loads((WORK/'load-request-map.json').read_text(encoding='utf-8')).items()}
ledger=json.loads((WORK/'callback-ledger.json').read_text(encoding='utf-8'))
extra={
 13:['GlobalPropInfoBTest.json','GlobalPropInfoATest.json'],
 21:['GlobalHeroCardInfoshop_improve_v1.json','GlobalHeroCardInfoSheet5.json'],
 22:['GlobalArchitectureInfoshop_improve_v1.json','GlobalArchitectureInfogameplay_improve_01.json'],
 23:['GlobalRoleInfoshop_improve_v1.json','GlobalRoleInfogameplay_improve_01.json'],
 41:['EnemyDifficultLevelInfosgameplay_improve_v2_01.json','EnemyDifficultLevelInfosgameplay_improve_v2_02.json','EnemyDifficultLevelInfosgameplay_improve_01.json'],
 42:['ArenaEnemyBalanceInfogameplay_improve_v2_01.json','ArenaEnemyBalanceInfogameplay_improve_v2_02.json','ArenaEnemyBalanceInfobalance_adjustment_03_on.json','ArenaEnemyBalanceInfogameplay_improve_01.json']}
def read(path):
    raw=(ROOT/'outputs/OccupyCityRecovered'/path).read_bytes()
    return json.loads(gzip.decompress(base64.b64decode(raw,validate=True)))
audit=[]
for callback in ledger:
    if len(callback['fieldStores'])!=2:continue
    i=callback['index']; paths=[PREFIX+n for n in extra[i]] if i in extra else requests[i]['paths']
    assert paths,i
    for path in paths:
        rows=read(path); keys=[]; errors=[]
        for index,row in enumerate(rows):
            key=row.get(callback['keyMember'])
            if i in (41,45):
                try:key=int(key)
                except Exception:errors.append({'row':index,'key':key,'reason':'not an integer fixture key'})
            if key is None:errors.append({'row':index,'reason':'null dictionary key'})
            keys.append(key)
        counts=collections.Counter(keys)
        duplicates=[{'key':key,'count':count} for key,count in counts.items() if count>1]
        audit.append({'callback':i,'address':callback['address'],'type':callback['type'],'path':path,'keyMember':callback['keyMember'],'keyOffset':callback['keyOffset'],'records':len(rows),'duplicates':duplicates,'keyErrors':errors,'originalDictionaryAddCanAcceptAllKeys':not duplicates and not errors})
maps=read(PREFIX+'GlobalMainCityMapInfo.json');tiles=[tile for row in maps for tile in json.loads(row['infos'])]
tile_counts=collections.Counter(tile['tileKey'] for tile in tiles)
report={'scope':'Original gzip JSON payload analysis, not C# deserialization or Unity runtime execution','dictionaryFixtures':audit,'all25DictionaryCallbackFixtureKeysValid':all(r['originalDictionaryAddCanAcceptAllKeys'] for r in audit),
 'mainCityMap':{'outerRecords':len(maps),'flattenedTileRecords':len(tiles),'uniqueTileKeys':len(tile_counts),'duplicateTileKeys':sum(n-1 for n in tile_counts.values()),'nativePolicy':'List.Add every tile, Dictionary.TryAdd by tileKey; first value retained on duplicate'}}
(WORK/'callback-resource-audit.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({'dictionaryCallbackIDs':len({r['callback'] for r in audit}),'dictionaryVariantFixtures':len(audit),'allFixtureKeysValid':report['all25DictionaryCallbackFixtureKeysValid'],'mainCityMap':report['mainCityMap']},ensure_ascii=True,indent=2))
