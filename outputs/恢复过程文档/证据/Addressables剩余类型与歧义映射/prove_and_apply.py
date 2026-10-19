"""Apply only native-container/reference-proven mappings and five importer field pairs."""
from pathlib import Path
import collections
import copy
import hashlib
import json
import re
import sys

root = Path(__file__).resolve().parents[2]
sys.path.insert(0, str(root / 'work/startup-restore'))
from recovery_plan_io import write_json_atomic

own = Path(__file__).resolve().parent
project = root / 'outputs/OccupyCityRecovered'
plan_path = root / 'work/startup-restore/addressable-recovery-plan.json'
graph = json.loads((own / 'current-reference-graph.json').read_text(encoding='utf-8'))
original = json.loads((own / 'original-source-containers.json').read_text(encoding='utf-8'))
plan = json.loads(plan_path.read_text(encoding='utf-8'))
assert hashlib.sha256(plan_path.read_bytes()).hexdigest() == graph['planSha256'], 'Shared plan changed since this audit'
before = copy.deepcopy(plan)
path_id_map = json.loads((root/'work/recovery-ledger/path_id_map.json').read_text(encoding='utf-8'))
path_id_index = {(file['Name'].casefold(),str(asset['PathID'])):asset for file in path_id_map['Files'] for asset in file['Assets']}
by_id = {row['catalogIndex']: row for row in plan['entries']}
native = {row['catalogIndex']: row for row in original}
current = {row['catalogIndex']: row for row in graph['validationFailures']}
guid_paths = {}
for meta in (project/'Assets').rglob('*.meta'):
    match = re.search(rb'^guid: ([0-9a-f]{32})$', meta.read_bytes()[:1024], re.M)
    if match: guid_paths.setdefault(match[1].decode(), []).append(Path(str(meta)[:-5]))

def sha(path): return hashlib.sha256(path.read_bytes()).hexdigest()
def yaml(path): return path.read_text(encoding='utf-8')
def path_for_guid(guid):
    paths = guid_paths[guid]
    assert len(paths) == 1, (guid, paths)
    return paths[0]
def export_guid(path): return re.search(r'^guid: ([0-9a-f]{32})$', Path(str(path)+'.meta').read_text(encoding='utf-8'), re.M)[1]
def direct_type(index, kind):
    values = [match for match in native[index]['matches'] if match['root']['type'] == kind]
    assert len(values) == 1, (index, kind)
    return values[0]
def old_map_confirms(source):
    row = path_id_index.get((source['serializedFile'].casefold(),source['pathId']))
    return bool(row and row['Type']==source['type'] and row['Name']==source['name'])
def root_type(index): return direct_type(index, 'MonoBehaviour')
def key_guid(text, key):
    pattern = r'^  '+re.escape(key)+r': \{fileID: -?\d+, guid: ([0-9a-f]{32}), type: \d+\}'
    return re.search(pattern, text, re.M)[1]
def material_texture_guid(text, key):
    return re.search(r'^      '+re.escape(key)+r':\n        m_Texture: \{fileID: -?\d+, guid: ([0-9a-f]{32}), type: \d+\}', text, re.M)[1]

proofs = []
def map_to(index, target, original_match, relation):
    entry = by_id[index]
    source = original_match['root']
    text = yaml(target) if target.suffix != '.png' else ''
    requested = entry['requestedType'].rsplit('.', 1)[-1]
    if requested == 'Material': assert text.startswith('%YAML') and '--- !u!21 &' in text
    if requested == 'Sprite': assert '--- !u!213 &' in text
    entry.update(assetPath=target.relative_to(project).as_posix(), guid=export_guid(target),
                 exportType=requested if requested != 'RenderObjects' else 'MonoBehaviour', exportName=source['name'],
                 evidenceKind='source-container-typed-object-and-serialized-reference',
                 sourceFile=source['serializedFile'], sourcePathId=source['pathId'], sourceType=source['type'],
                 sourceName=source['name'], sourceBundle='assets/aa/Android/'+native[index]['searchBundle'], pathIdMapConfirmed=old_map_confirms(source))
    proofs.append({'catalogIndex': index, 'before': next(row for row in before['entries'] if row['catalogIndex']==index),
                   'after': copy.deepcopy(entry), 'sourceContainerKey': original_match['containerKey'],
                   'sourceIdentity': source, 'nativeContainerConfirmed':True, 'serializedRelation': relation, 'exportSha256': sha(target)})

# Renderer feature: exact original container typed object plus actual renderer-feature GUID.
feature = [match for match in native[716]['matches'] if match['root']['name']=='Render Effects']
assert len(feature)==1
renderer = next(match for match in native[716]['matches'] if match['root']['name']=='SamplesForwardRenderer')
assert feature[0]['root']['pathId'] in [str(pointer['m_PathID']) for pointer in renderer['rootSelectedFields']['m_RendererFeatures']]
renderer_text = yaml(project/by_id[716]['assetPath'])
feature_guid = re.search(r'^  m_RendererFeatures:\n  - \{fileID: 11400000, guid: ([0-9a-f]{32}), type: 2\}', renderer_text, re.M)[1]
feature_target = path_for_guid(feature_guid)
assert key_guid(yaml(feature_target), 'm_Script') == '6b3d386ba5cd94485973aee1479b272e'
package_script = project/'Library/PackageCache/com.unity.render-pipelines.universal@14.0.12/Runtime/RendererFeatures/RenderObjects.cs'
assert 'namespace UnityEngine.Experimental.Rendering.Universal' in yaml(package_script)
map_to(716, feature_target, feature[0], 'Original renderer m_RendererFeatures -> original Render Effects PathID; exported renderer GUID -> feature using actual URP RenderObjects script')

# Font material and atlas: both source pointers and current GUIDs must point to the typed container root.
for texture_id, material_id in [(720,721),(741,742)]:
    font = root_type(texture_id)
    texture = direct_type(texture_id, 'Texture2D')
    material = direct_type(material_id, 'Material')
    assert font['rootSelectedFields']['material']['m_PathID'] == int(material['root']['pathId'])
    assert font['rootSelectedFields']['m_AtlasTextures'] == [{'m_FileID':0,'m_PathID':int(texture['root']['pathId'])}]
    text = yaml(project/by_id[texture_id]['assetPath'])
    material_path = path_for_guid(key_guid(text, 'material'))
    atlas_guid = re.search(r'^  m_AtlasTextures:\n  - \{fileID: 2800000, guid: ([0-9a-f]{32}), type: 3\}',text,re.M)[1]
    atlas_path = path_for_guid(atlas_guid)
    assert material_texture_guid(yaml(material_path), '_MainTex') == atlas_guid
    map_to(texture_id, atlas_path, texture, 'Original font atlas PPtr and exported m_AtlasTextures GUID agree; material _MainTex shares the same atlas GUID')
    map_to(material_id, material_path, material, 'Original font material PPtr and exported material GUID agree')

# Crown original material is a direct same-key container entry; current material=0 is preserved.
crown = root_type(2758); crown_material = direct_type(2758,'Material')
original_sheet = crown['rootSelectedFields']['spriteSheet']['m_PathID']
original_material_texture = dict(crown_material['rootSelectedFields']['m_SavedProperties']['m_TexEnvs'])['_MainTex']['m_Texture']['m_PathID']
assert original_sheet == original_material_texture
sheet_guid = key_guid(yaml(project/by_id[2758]['assetPath']), 'spriteSheet')
matches = []
for path in (project/'Assets').rglob('*.mat'):
    text = yaml(path)
    if 'm_Name: '+crown_material['root']['name'] in text and re.search(r'^      _MainTex:\n        m_Texture: \{fileID: 2800000, guid: '+sheet_guid+r', type: 3\}',text,re.M): matches.append(path)
assert len(matches)==1
map_to(2758,matches[0],crown_material,'Original same-key Material _MainTex PPtr equals Crown.spriteSheet PPtr; exported material _MainTex GUID equals Crown.spriteSheet GUID; original material=0 unchanged')

# Embedded gradient texture is exactly the original material property and current GUID reference.
material = direct_type(3042,'Material'); texture = direct_type(3042,'Texture2D')
native_gradient = dict(material['rootSelectedFields']['m_SavedProperties']['m_TexEnvs'])['_ColorRampTexGradient']['m_Texture']['m_PathID']
assert native_gradient == int(texture['root']['pathId'])
gradient_path = path_for_guid(material_texture_guid(yaml(project/by_id[3042]['assetPath']), '_ColorRampTexGradient'))
map_to(3042,gradient_path,texture,'Original _ColorRampTexGradient PPtr equals typed texture container PathID; exported material property GUID resolves this PNG')

def prove_sprite(index, candidate):
    source = direct_type(index,'Sprite')
    source_texture = direct_type(index,'Texture2D')
    rd = source['rootSelectedFields']['m_RD']
    assert rd['texture']['m_PathID'] == int(source_texture['root']['pathId'])
    text = yaml(candidate)
    data = re.search(r'^      _typelessdata: ([0-9a-fA-F]+)$',text,re.M)[1]
    indices = re.search(r'^    m_IndexBuffer: ([0-9a-fA-F]+)$',text,re.M)[1]
    assert hashlib.sha256(bytes.fromhex(data)).hexdigest() == rd['m_VertexData']['m_DataSize']['sha256']
    assert bytes.fromhex(indices) == bytes(rd['m_IndexBuffer'])
    texture_guid = export_guid(project/next(row for row in before['entries'] if row['catalogIndex']==index)['assetPath'])
    assert re.search(r'^    texture: \{fileID: 2800000, guid: '+texture_guid+r', type: 3\}',text,re.M)
    return source

for index in [2166,4183]:
    candidates = current[index]['exportedSiblingSprites']
    assert len(candidates)==1
    target = project/candidates[0]['path']
    source = prove_sprite(index,target)
    map_to(index,target,source,'Unique original same-address Sprite and Texture PathIDs; exported Sprite points to the same PNG GUID; original vertex/index bytes exactly match')

# Do not choose one from an original multi-Sprite container. All four remain explicitly pending.
moved_pending = []
for index in [2116,2118,2120,2150]:
    row = by_id.pop(index)
    sprites = [match['root'] for match in native[index]['matches'] if match['root']['type']=='Sprite']
    assert len(sprites) in (3,4)
    pending = {key:value for key,value in row.items() if key not in ['assetPath','guid','exportType','exportName','evidenceKind','sourceFile','sourcePathId','sourceType','sourceName','sourceBundle','pathIdMapConfirmed']}
    pending.update(reason='Original address has multiple Sprite container roots; exact singular typed request/local-ID behavior is not established. No arbitrary sprite or importer slice selected.',
                   sources=[dict(sourceFile=value['serializedFile'], sourcePathId=value['pathId'], sourceType='Sprite',sourceName=value['name'],bundle='assets/aa/Android/'+native[index]['searchBundle'],pathIdMapConfirmed=old_map_confirms(value),nativeContainerConfirmed=True) for value in sprites],
                   candidatePaths=[value['path'] for value in current[index]['exportedSiblingSprites']])
    moved_pending.append(pending)

meta_changes = []
for ambiguity in graph['locatorAmbiguities']:
    index = ambiguity['catalogIndex']
    sprite_path = project/ambiguity['sprite']['path']
    # Validate original standalone Sprite geometry rather than selecting a locator result.
    original_sprite = direct_type(index,'Sprite')
    rd = original_sprite['rootSelectedFields']['m_RD']
    text = yaml(sprite_path)
    assert hashlib.sha256(bytes.fromhex(re.search(r'^      _typelessdata: ([0-9a-fA-F]+)$',text,re.M)[1])).hexdigest() == rd['m_VertexData']['m_DataSize']['sha256']
    assert bytes.fromhex(re.search(r'^    m_IndexBuffer: ([0-9a-fA-F]+)$',text,re.M)[1]) == bytes(rd['m_IndexBuffer'])
    refs = [row for row in ambiguity['png']['allSerializedReferences'] if not row['generatedAddressables']]
    assert len(refs)==1 and refs[0]['path']==ambiguity['sprite']['path'] and 'fileID: 2800000' in refs[0]['content']
    png = project/ambiguity['png']['path']; meta = Path(str(png)+'.meta'); old=meta.read_bytes()
    new,count_type = re.subn(rb'(?m)^(  textureType: )8(\r?)$',rb'\g<1>0\2',old)
    new,count_mode = re.subn(rb'(?m)^(  spriteMode: )1(\r?)$',rb'\g<1>0\2',new)
    assert count_type==count_mode==1
    assert ambiguity['png']['guid'] == re.search(rb'^guid: ([0-9a-f]{32})\r?$',old,re.M)[1].decode()
    meta_changes.append({'catalogIndex':index,'path':str(meta.relative_to(project)).replace('\\','/'),'guid':ambiguity['png']['guid'],
                         'beforeSha256':hashlib.sha256(old).hexdigest(),'afterSha256':hashlib.sha256(new).hexdigest(),
                         'pngSha256':sha(png),'retainedOriginalSprite':ambiguity['sprite']['path'],
                         'changedFields':{'textureType':[8,0],'spriteMode':[1,0]},'allOtherBytesPreserved':True,
                         '_before':old,'_after':new})

plan['entries'] = sorted(by_id.values(),key=lambda row:row['catalogIndex'])
plan['pending'] = sorted(plan['pending']+moved_pending,key=lambda row:row['catalogIndex'])
plan['summary'].update(resolvedRows=len(plan['entries']),pendingRows=len(plan['pending']),distinctExportGuids=len({row['guid'] for row in plan['entries']}),
                       sourceVerifiedDifferenceRows=sum(row['evidenceKind']!='original-path-preserved' for row in plan['entries']),
                       evidenceCounts=dict(collections.Counter(row['evidenceKind'] for row in plan['entries'])))
assert len(proofs)==9 and len(meta_changes)==5 and len(plan['entries'])==5142 and len(plan['pending'])==60
assert [row for row in plan['pending'] if row['catalogIndex'] not in {2116,2118,2120,2150}] == before['pending']
report={'scope':'Nine native typed-container/reference mappings, five exact PNG importer field pairs; no Unity execution',
        'originalPlanSha256':graph['planSha256'],'mappingChanges':proofs,'movedToPending':moved_pending,
        'metaChanges':[{key:value for key,value in row.items() if not key.startswith('_')} for row in meta_changes],
        'summaryAfter':plan['summary'],'unityValidation':'not-run','locatorVerification':'not-run','coreGameplayAccepted':False}
(own/'proposed-repair.json').write_text(json.dumps(report,ensure_ascii=False,indent=2)+'\n',encoding='utf-8')
if '--apply' in sys.argv:
    backup=own/'before'; backup.mkdir(exist_ok=True)
    (backup/'addressable-recovery-plan.json').write_bytes(plan_path.read_bytes())
    for row in meta_changes:
        path=project/row['path']; target=backup/row['path']; target.parent.mkdir(parents=True,exist_ok=True)
        target.write_bytes(row['_before']); path.write_bytes(row['_after'])
        assert sha(path)==row['afterSha256'] and sha(Path(str(path)[:-5]))==row['pngSha256']
    write_json_atomic(plan_path,plan)
    readback=json.loads(plan_path.read_text(encoding='utf-8'))
    assert readback==plan
    report.update(applied=True,planAfterSha256=sha(plan_path))
    (own/'applied-repair.json').write_text(json.dumps(report,ensure_ascii=False,indent=2)+'\n',encoding='utf-8')
print(json.dumps({'provedMappings':len(proofs),'metaChanges':len(meta_changes),'pending':len(plan['pending']),'applied':'--apply' in sys.argv},ensure_ascii=True))
