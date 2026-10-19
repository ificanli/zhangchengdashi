"""Static evidence audit and archival; does not run or import Unity."""
import collections
import difflib
import hashlib
import json
import shutil
from pathlib import Path

ROOT=Path(__file__).resolve().parents[2]
WORK=ROOT/'work/assetsmanager-restore'
OUT=ROOT/'outputs/恢复过程文档/证据/AssetsManager恢复'
OUT.mkdir(parents=True,exist_ok=True)
SOURCE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/AssetsModule/AssetsManager.cs'
def sha(data):return hashlib.sha256(data).hexdigest()
before=json.loads((WORK/'source-before.json').read_text(encoding='utf-8'))
current=SOURCE.read_bytes(); text=current.decode('utf-8-sig')
meta=Path(str(SOURCE)+'.meta').read_bytes()
config_path=ROOT/'outputs/OccupyCityRecovered/Assets/Resources/AddressablesConfig.json'
config_raw=config_path.read_bytes(); original_config=ROOT/'work/asset-probe/textassets/data.unity3d-AddressablesConfig.bytes'
config=json.loads(config_raw)
counts=collections.Counter(r['assetPath'] for r in config['items'])
groups=collections.Counter(r['groupName'] for r in config['items'])
status=json.loads((ROOT/'work/ida-framework-assets/status-assets-init.json').read_text(encoding='utf-8'))
native=json.loads((WORK/'native-consumer-evidence.json').read_text(encoding='utf-8'))

def body(signature):
    start=text.index('{',text.index(signature)); depth=0
    for end in range(start,len(text)):
        if text[end]=='{':depth+=1
        elif text[end]=='}':
            depth-=1
            if depth==0:return text[start+1:end]
    raise ValueError(signature)
init=body('public override async UniTask Init()')
ordered=['await GenerateGroupsMap();','BundleLoadingProgress = 1f;','_ = ObjPoolManager.Instance.Init();','EventManager.Instance.TriggerEvent("AssetsManagerInitComplete", null);','initcomplete = true;']
positions=[init.index(s) for s in ordered]
load=body('public async UniTask<T> LoadAssetAsync<T>')
mapping=body('private async UniTask GenerateGroupsMap()')
checks={
 'metaUnchanged':sha(meta)==before['metaSha256'],
 'initOriginalOrder':positions==sorted(positions),
 'initFlagOnlyWrittenAtOriginalCompletion':text.count('initcomplete = true;')==1 and 'initcomplete = true;' in init,
 'poolInitNotAwaited':'await ObjPoolManager' not in init,
 'initNoCatchOrFinallyCompletion':'catch' not in init and 'finally' not in init,
 'groupResourceExact':'UnityEngine.Resources.Load<TextAsset>("AddressablesConfig")' in mapping,
 'groupPathDictionaryUsesAdd':'_assetGroupNameDict.Add(item.assetPath, item);' in mapping,
 'groupTrackingListsStartEmpty':'_assetGroupDict.Add(item.groupName, new List<string>());' in mapping and '.Add(item.assetPath)' not in mapping,
 'loadUsesRealAddressables':'Addressables.LoadAssetAsync<T>(assetPath)' in load,
 'loadHasTwoCacheChecks':load.count('_assetHandleMap.TryGetValue(')==2,
 'loadOriginalThreeTaskAwaits':load.count('await ')==3,
 'loadHasNoFakeSuccessReturn':'return default' not in load and 'UniTask.FromResult' not in load,
 'loadNoEditorAssetDatabaseSubstitution':'AssetDatabase' not in text and '#if UNITY_EDITOR' not in text,
 'nativeTargetBatchComplete':status['stage']=='complete' and all(r.get('prototype_applied') and r.get('actual_function_start')==hex(r['address']) and r.get('actual_function_end')==hex(r['end']) and not r.get('unresolved_jumpout') for r in status['methods']),
 'originalAddressablesConfigBytesPreserved':config_raw==original_config.read_bytes(),
 'addressablesConfigNoDuplicatePath':len(counts)==len(config['items']),
}
report={'scope':'Static source/native/byte evidence only; not C# execution, Unity compilation or Editor runtime acceptance',
 'source':str(SOURCE),'sourceBeforeSha256':before['sourceSha256'],'sourceAfterSha256':sha(current),'sourceAfterBytes':len(current),'metaSha256':sha(meta),
 'checks':checks,'allStaticChecksPassed':all(checks.values()),
 'addressablesConfig':{'path':str(config_path),'bytes':len(config_raw),'sha256':sha(config_raw),'items':len(config['items']),'uniquePaths':len(counts),'groupCount':len(groups),'groups':dict(groups)},
 'nativeMethods':[{'name':r['name'],'address':r['address'],'end':r['end'],'actualFunctionStart':r.get('actual_function_start'),'actualFunctionEnd':r.get('actual_function_end'),'unresolvedJumpout':r.get('unresolved_jumpout')} for r in status['methods']],
 'remainingLimitations':['ProcedurePreLoad upstream caller not restored by this file','ObjPoolManager.Init is still a separate original stub','InitGUIStyles is not restored in this stage','Addressables configuration presence does not prove Editor runtime resource load','ReaderWriterLockSlim lock span across task waits follows original method; runtime behavior requires Unity main-thread validation'],
 'unityRunThisStage':False,'unityCompileDelegatedToRoot':True}
(WORK/'static-verification.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
(OUT/'static-verification.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
diff=''.join(difflib.unified_diff([r+'\n' for r in (WORK/'AssetsManager.before.cs').read_text(encoding='utf-8-sig').splitlines()],[r+'\n' for r in text.splitlines()],fromfile='AssetsManager.before.cs',tofile='AssetsManager.cs'))
(OUT/'AssetsManager.patch').write_text(diff,encoding='utf-8')
(OUT/'AssetsManager.before.cs.txt').write_bytes((WORK/'AssetsManager.before.cs').read_bytes())
(OUT/'AssetsManager.recovered.cs.txt').write_bytes(current)
for name in ('native-consumer-evidence.json','source-before.json','verify_and_archive.py'):
    shutil.copyfile(WORK/name,OUT/name)
for method in native['methods']:
    source=ROOT/method['assembly']; shutil.copyfile(source,OUT/source.name)
for rva in ('0x3f136bc','0x3f13590','0x6891b6c','0x5194ae0'):
    for suffix in ('.c','.asm.txt'):
        source=ROOT/'work/ida-framework-assets/pseudocode'/(rva+suffix)
        shutil.copyfile(source,OUT/('ida-'+source.name))
for suffix in ('.c','.asm.txt'):
    source=ROOT/'work/ida-startup-bounded/pseudocode'/('0x3f13be4'+suffix)
    shutil.copyfile(source,OUT/('ida-'+source.name))
shutil.copyfile(ROOT/'work/ida-framework-assets/status-assets-init.json',OUT/'status-assets-init.json')
print(json.dumps({'sourceAfterSha256':report['sourceAfterSha256'],'checks':checks,'allStaticChecksPassed':all(checks.values()),'configItems':len(config['items']),'configGroups':len(groups),'archive':str(OUT)},ensure_ascii=True,indent=2))
if not all(checks.values()):raise SystemExit(1)
