"""Read-only structure/content and original ProjectSettings collision evidence."""
import collections
import hashlib
import json
import re
import struct
import zipfile
from pathlib import Path

import UnityPy

ROOT=Path(__file__).resolve().parents[2]
DECODED=ROOT/'work/startup-restore/legacy-decoded'
OUT=ROOT/'work/startup-restore/legacy-consumers'
OUT.mkdir(exist_ok=True)
decode_report=json.loads((DECODED/'data-bundles-decode-report.json').read_text(encoding='utf-8'))
native=json.loads((OUT/'native-consumer-evidence.json').read_text(encoding='utf-8'))
readconfig=next(r for r in native['methods'] if r['name']=='ljzs_lt.ConfigMgr$$ReadConfig')
config_consumer_names=set()
for ref in readconfig['metadataReferences']:
    match=re.search(r'ConfigRead\.readConfig(?:V)?ByUnityJson<([^>]+)>',ref.get('Name',''))
    if match:config_consumer_names.add(match.group(1))
rows=[]; containers=[]
for bundle in decode_report:
    bundle_path=DECODED/Path(bundle['apkEntry']).name
    env=UnityPy.load(bundle_path.read_bytes())
    for obj in env.objects:
        if obj.type.name=='AssetBundle':
            tree=obj.read_typetree(check_read=True)
            containers.append({'bundle':bundle_path.name,'logicalName':bundle['logicalName'],'pathId':str(obj.path_id),'tree':tree})
    for source in bundle['textAssets']:
        file=DECODED/'textassets'/Path(source['output']).name
        raw=file.read_bytes()
        assert len(raw)==source['bytes'] and hashlib.sha256(raw).hexdigest()==source['sha256']
        text=raw.decode('utf-8-sig')
        row={**source,'output':file.relative_to(ROOT).as_posix(),'logicalBundleName':bundle['logicalName'],'utf8Valid':True,'utf8Bom':raw.startswith(b'\xef\xbb\xbf'),'configMgrReadConfigDirectTypeEvidence':source['name'] in config_consumer_names}
        if not text.strip():
            row.update(format='empty-text',rawHex=raw.hex(),contentMeaning='Only BOM and line ending; no collision/config rows in original payload')
        else:
            parsed=json.loads(text)
            row.update(format='json',rootType=type(parsed).__name__,keys=list(parsed) if isinstance(parsed,dict) else None)
            if isinstance(parsed,dict) and isinstance(parsed.get('Datas'),list):
                datas=parsed['Datas']; fields=sorted({k for item in datas if isinstance(item,dict) for k in item})
                row.update(shape='Datas-table',recordCount=len(datas),fields=fields)
            else:
                row.update(shape='config-object',value=parsed)
        rows.append(row)
report={'textAssets':rows,'formatCounts':dict(collections.Counter(r.get('shape',r['format']) for r in rows)),
        'configMgrDirectConsumedCount':sum(r['configMgrReadConfigDirectTypeEvidence'] for r in rows),
        'configMgrDirectConsumedNames':sorted(config_consumer_names),'assetBundleObjects':containers}
(OUT/'content-structure.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')

physics=[]
apk_path=ROOT/'work/apk-intake/zhancheng-dashi-1.04.apk'
with zipfile.ZipFile(apk_path) as apk:
    bundle_raw=apk.read('assets/bin/Data/data.unity3d')
env=UnityPy.load(bundle_raw)
for obj in env.objects:
    if obj.type.name not in ('PhysicsManager','Physics2DSettings','TagManager'):continue
    tree=obj.read_typetree(check_read=True)
    row={'serializedFile':obj.assets_file.name,'pathId':str(obj.path_id),'type':obj.type.name,'treeReadComplete':True,'tree':tree}
    target={'PhysicsManager':'DynamicsManager.asset','Physics2DSettings':'Physics2DSettings.asset','TagManager':'TagManager.asset'}[obj.type.name]
    exported=ROOT/'outputs/OccupyCityRecovered/ProjectSettings'/target
    yaml=exported.read_text(encoding='utf-8-sig')
    row.update(exportedPath=exported.relative_to(ROOT).as_posix(),exportedSha256=hashlib.sha256(exported.read_bytes()).hexdigest())
    if 'm_LayerCollisionMatrix' in tree:
        original=tree['m_LayerCollisionMatrix']
        if isinstance(original,list):original=struct.pack('<'+'I'*len(original),*(v & 0xffffffff for v in original))
        if isinstance(original,bytes):original=original.hex()
        match=re.search(r'^\s*m_LayerCollisionMatrix:\s*([0-9a-f]+)\s*$',yaml,re.MULTILINE)
        row.update(originalMatrixHex=original,exportedMatrixHex=match.group(1) if match else None,
                   originalMatchesExported=original==match.group(1) if match else False)
    physics.append(row)
physics_report={'sourceApkEntry':'assets/bin/Data/data.unity3d','sourceSha256':hashlib.sha256(bundle_raw).hexdigest(),
                'sourceBytes':len(bundle_raw),'objects':physics}
(OUT/'physics-original-vs-export.json').write_text(json.dumps(physics_report,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({'formatCounts':report['formatCounts'],'textAssetCount':len(rows),'configMgrDirectConsumedCount':report['configMgrDirectConsumedCount'],'physicsObjects':[{'type':r['type'],'file':r['serializedFile'],'pathId':r['pathId'],'matrixMatches':r.get('originalMatchesExported')} for r in physics]},ensure_ascii=True,indent=2))
