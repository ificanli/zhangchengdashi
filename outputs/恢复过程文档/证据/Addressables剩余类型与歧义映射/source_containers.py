"""Read-only original source container/preload identity investigation."""
from pathlib import Path
import collections
import gc
import hashlib
import json
import sys
import zipfile
import UnityPy

sys.stdout.reconfigure(encoding='utf-8')
root = Path(__file__).resolve().parents[2]
own = Path(__file__).resolve().parent
project = root / 'outputs/OccupyCityRecovered'
catalog = json.loads((root / 'work/startup-restore/catalog-entries.json').read_text(encoding='utf-8'))
plan = json.loads((root / 'work/startup-restore/addressable-recovery-plan.json').read_text(encoding='utf-8'))
validation = json.loads((project / 'RecoveryReports/addressables-validation-report.json').read_text(encoding='utf-8-sig'))
build = json.loads((project / 'RecoveryReports/addressables-build-report.json').read_text(encoding='utf-8-sig'))
pathmap = json.loads((root / 'work/recovery-ledger/path_id_map.json').read_text(encoding='utf-8'))
source_map = {(file['Name'].casefold(), asset['PathID']): asset for file in pathmap['Files'] for asset in file['Assets']}
targets = {row['catalogIndex'] for row in validation['validationFailures'] + build['locatorFailures']}
groups = collections.defaultdict(list)
for index in sorted(targets):
    row = catalog[index]
    groups[catalog[row['dependencyEntryIndexes'][0]]['primaryKey']].append(row)

def pointer(ptr):
    af = ptr.assetsfile
    filename = af.name if ptr.m_FileID == 0 else af.externals[ptr.m_FileID-1].path.rsplit('/', 1)[-1]
    match = source_map.get((filename.casefold(), ptr.m_PathID), {})
    record = {'fileId': ptr.m_FileID, 'pathId': str(ptr.m_PathID), 'serializedFile': filename,
              'type': match.get('Type'), 'name': match.get('Name')}
    if ptr.m_FileID == 0 and ptr.m_PathID in af.objects:
        obj = af.objects[ptr.m_PathID]
        record['type'] = obj.type.name
        try:
            data = obj.read(check_read=False)
            record['name'] = getattr(data, 'm_Name', None)
        except Exception as error:
            record['readError'] = str(error)
    return record

def jsonable(value):
    if isinstance(value, dict): return {key: jsonable(item) for key, item in value.items()}
    if isinstance(value, (list, tuple)): return [jsonable(item) for item in value]
    if isinstance(value, bytes): return {'byteCount': len(value), 'sha256': hashlib.sha256(value).hexdigest()}
    if hasattr(value, '__dict__'): return jsonable(vars(value))
    return value

rows = []
with zipfile.ZipFile(root / 'work/apk-intake/zhancheng-dashi-1.04.apk') as apk:
    for bundle, requested in groups.items():
        env = UnityPy.load(apk.read('assets/aa/Android/' + bundle))
        bundles = [obj.read() for obj in env.objects if obj.type.name == 'AssetBundle']
        for target in requested:
            row = {'catalogIndex': target['index'], 'address': target['internalId'], 'requestedType': target['resourceType']['m_ClassName'],
                   'searchBundle': bundle, 'matches': []}
            for asset_bundle in bundles:
                for key, info in asset_bundle.m_Container:
                    if key.casefold() != target['internalId'].casefold(): continue
                    match = {'containerKey': key, 'root': pointer(info.asset), 'preloadIndex': info.preloadIndex, 'preloadSize': info.preloadSize,
                             'preload': [pointer(ptr) for ptr in asset_bundle.m_PreloadTable[info.preloadIndex: info.preloadIndex + info.preloadSize]]}
                    if info.asset.m_FileID == 0:
                        obj = info.asset.deref()
                        tree = obj.read_typetree(check_read=False)
                        fields = ['m_Name', 'material', 'm_AtlasTextures', 'm_RendererFeatures', 'spriteSheet', 'm_SavedProperties', 'm_SpriteGlyphTable',
                                  'm_Rect', 'm_Pivot', 'm_Border', 'm_PixelsToUnits', 'm_RenderDataKey', 'm_RD']
                        match['rootSelectedFields'] = {field: jsonable(tree[field]) for field in fields if field in tree}
                        related = []
                        for ptr in asset_bundle.m_PreloadTable[info.preloadIndex: info.preloadIndex + info.preloadSize]:
                            if ptr.m_FileID or ptr.m_PathID == info.asset.m_PathID: continue
                            obj = ptr.deref()
                            if obj.type.name not in ('Sprite', 'Material', 'Texture2D', 'MonoBehaviour'): continue
                            tree = obj.read_typetree(check_read=False)
                            related.append({'identity': pointer(ptr), 'selectedFields': {field: jsonable(tree[field]) for field in fields if field in tree}})
                        match['relatedObjects'] = related
                    row['matches'].append(match)
            rows.append(row)
        (own / 'original-source-containers.json').write_text(json.dumps(rows, ensure_ascii=False, indent=2) + '\n', encoding='utf-8')
        print(bundle, 'targets=', len(requested), 'matches=', sum(len(row['matches']) for row in rows if row['searchBundle'] == bundle), flush=True)
        del env, bundles
        gc.collect()
print(json.dumps({'rows': len(rows), 'unmatched': [row['catalogIndex'] for row in rows if not row['matches']]}, ensure_ascii=True))
