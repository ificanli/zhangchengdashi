from pathlib import Path
import hashlib
import json
import re
import sys
import zipfile
import UnityPy

root=Path(__file__).resolve().parents[2]
project=root/'outputs/OccupyCityRecovered'
delivery=root/'outputs/旧框架资源恢复'
own=Path(__file__).resolve().parent
rows=json.loads((delivery/'Editor导入与资源映射计划.json').read_text(encoding='utf-8'))['importRows']
orig=json.loads((delivery/'原名与PathID映射.json').read_text(encoding='utf-8'))
assert len(rows)==len(orig)==50
mapped={row['pathId']:row for row in orig}
output=[]
for row in rows:
    source=delivery/row['source']; raw=source.read_bytes(); expected=mapped[row['pathId']]
    assert len(raw)==row['bytes'] and hashlib.sha256(raw).hexdigest()==row['sha256']==expected['sha256']
    target=project/row['proposedEditorAssetPath']; target.parent.mkdir(parents=True,exist_ok=True)
    if target.exists():assert target.read_bytes()==raw, f'Refuse overwrite: {target}'
    else:target.write_bytes(raw)
    guid=hashlib.md5(('OccupyCityRecoveryLegacy|'+expected['bundleStoredName']+'|'+row['pathId']).encode()).hexdigest()
    meta=Path(str(target)+'.meta')
    text='fileFormatVersion: 2\nguid: '+guid+'\nTextScriptImporter:\n  externalObjects: {}\n  userData: \n  assetBundleName: \n  assetBundleVariant: \n'
    if meta.exists():assert re.search(r'^guid: ([0-9a-f]{32})$',meta.read_text(encoding='utf-8'),re.M)[1]==guid
    else:meta.write_text(text,encoding='utf-8')
    output.append({'logicalBundle':expected['bundleLogicalName'],'sourceStoredBundle':expected['bundleStoredName'],
                   'sourceContainer':expected['bundleContainerPath'],'sourcePathId':expected['pathId'],
                   'assetName':expected['textAssetName'],'assetPath':row['proposedEditorAssetPath'],'guid':guid,
                   'bytes':len(raw),'sha256':row['sha256'],'directConfigConsumer':expected['directConfigMgrConsumer']})

manifest_raw=(delivery/'解码资源/ABFiles.txt').read_bytes()
manifest_target=project/'Assets/RecoveredLegacy/ABFiles.txt'
if manifest_target.exists():assert manifest_target.read_bytes()==manifest_raw
else:manifest_target.write_bytes(manifest_raw)
manifest_guid=hashlib.md5(b'OccupyCityRecoveryLegacy|ABFiles|decoded').hexdigest()
manifest_meta=Path(str(manifest_target)+'.meta')
if not manifest_meta.exists():manifest_meta.write_text('fileFormatVersion: 2\nguid: '+manifest_guid+'\nTextScriptImporter:\n  externalObjects: {}\n  userData: \n  assetBundleName: \n  assetBundleVariant: \n',encoding='utf-8')

with zipfile.ZipFile(root/'work/apk-intake/zhancheng-dashi-1.04.apk') as apk:
    raw=apk.read('assets/Android/ljzs_lt/e6f946c5d31096ee29c3d3f5c3aa16cf.unity3d')
    offset=raw.find(b'UnityFS\x00'); assert offset==16
    env=UnityPy.load(raw[offset:])
    matches=[]
    for obj in env.objects:
        if obj.type.name!='AssetBundle':continue
        for key,info in obj.read().m_Container:
            if key.casefold()=='assets/gameres/bundleres/ui/uiroot.prefab':
                source=info.asset.deref(); parsed=source.read();assert source.type.name=='GameObject' and parsed.m_Name=='UIRoot'
                matches.append({'sourceContainer':key,'sourceFile':source.assets_file.name,'sourcePathId':str(source.path_id),'sourceType':source.type.name,'sourceName':parsed.m_Name})
    assert len(matches)==1
    ui=matches[0]
ui_path='Assets/gameres/bundleres/ui/UIRoot.prefab'
ui_asset=project/ui_path
assert ui_asset.exists() and 'm_Name: UIRoot' in ui_asset.read_text(encoding='utf-8') and 'RectTransform:' in ui_asset.read_text(encoding='utf-8')
ui.update(logicalBundle='ui/uiroot.prefab.unity3d',sourceStoredBundle='e6f946c5d31096ee29c3d3f5c3aa16cf.unity3d',
          assetName='UIRoot',assetPath=ui_path,requestedType='UnityEngine.GameObject',sha256=hashlib.sha256(ui_asset.read_bytes()).hexdigest(),
          guid=re.search(r'^guid: ([0-9a-f]{32})$',Path(str(ui_asset)+'.meta').read_text(encoding='utf-8'),re.M)[1])
registry={'schemaVersion':1,'providerId':'LocalEditorResourcesProvider','applicationName':'ljzs_lt',
          'apkRelativePath':'work/apk-intake/zhancheng-dashi-1.04.apk','apkSha256':'4544b6323c6a2b11dd801fb75d99dbe6fc59253443bde5a24738d772694b0a2d',
          'manifestAssetPath':'Assets/RecoveredLegacy/ABFiles.txt','manifestBytes':len(manifest_raw),
          'manifestSha256':hashlib.sha256(manifest_raw).hexdigest(),'textAssets':output,'prefabs':[ui]}
target=project/'Assets/RecoveredLegacy/LocalEditorResourceRegistry.json'
target.write_text(json.dumps(registry,ensure_ascii=False,indent=2)+'\n',encoding='utf-8')
meta=Path(str(target)+'.meta')
if not meta.exists():meta.write_text('fileFormatVersion: 2\nguid: '+hashlib.md5(b'OccupyCityRecoveryLegacy|LocalEditorResourceRegistry').hexdigest()+'\nTextScriptImporter:\n  externalObjects: {}\n  userData: \n  assetBundleName: \n  assetBundleVariant: \n',encoding='utf-8')
(own/'legacy-import-applied.json').write_text(json.dumps({'textAssets':output,'prefabs':[ui],'manifestAssetPath':registry['manifestAssetPath'],
    'manifestSha256':registry['manifestSha256'],'registrySha256':hashlib.sha256(target.read_bytes()).hexdigest(),
    'unityTypedLoad':'not-run','scope':'Original bytes imported at declared recovery-owned paths; actual typed loading remains a mandatory provider runtime check'},ensure_ascii=False,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'textAssets':len(output),'directConfigConsumers':sum(row['directConfigConsumer'] for row in output),'uiRootOriginalIdentity':ui},ensure_ascii=True))
