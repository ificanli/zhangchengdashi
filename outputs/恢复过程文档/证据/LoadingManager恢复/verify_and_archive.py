"""Archive and audit source/native evidence without running Unity."""
import difflib
import hashlib
import json
import shutil
from pathlib import Path

ROOT=Path(__file__).resolve().parents[2]
WORK=ROOT/'work/loadingmanager-restore'
OUT=ROOT/'outputs/恢复过程文档/证据/LoadingManager恢复'
OUT.mkdir(parents=True,exist_ok=True)
SOURCE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/LoadingModule/LoadingManager.cs'
raw=SOURCE.read_bytes(); text=raw.decode('utf-8-sig').replace('\r\n','\n')
before=json.loads((WORK/'source-before.json').read_text(encoding='utf-8'))
meta=Path(str(SOURCE)+'.meta').read_bytes()
status=json.loads((ROOT/'work/ida-framework-assets/status-loading-astar.json').read_text(encoding='utf-8'))
target_rvas={0x40831a4,0x4082bf0,0x4082e2c,0x4082eb4}
targets=[r for r in status['methods'] if r['address'] in target_rvas]
native=json.loads((WORK/'native-consumer-evidence.json').read_text(encoding='utf-8'))
ordered=['while (!DataManager.Instance.LoadDataCompleted)','while (!TutorialManager.Instance.InitSteerInfoEnd)','TriggerEvent("OnLoadingCompleted", null)','while (!GameManager.Instance.InitComplete)','IsLoadingCompleted = true;','EnterHome = true;','HWIAPManager.Instance.EnterHomeInit();','new DailyTask("GemCheck")','TriggerEvent("LoadEnd", null)','if (!CompareCheat.Instance.StartCheck())','_loadingPanel.UpdateInfo(1f);','UnityEngine.Object.Destroy(_loadingPanel.gameObject);','TriggerEvent("CloseLoadPanel", null)']
positions=[text.index(s) for s in ordered]
checks={
 'metaUnchanged':hashlib.sha256(meta).hexdigest()==before['metaSha256'],
 'loadingSceneOriginalOrder':positions==sorted(positions),
 'noDataTutorialGameReadyAssignments':all(s not in text for s in ('LoadDataCompleted =','InitSteerInfoEnd =','InitComplete =')),
 'compareCheatFalseRetainsYieldBreak':'if (!CompareCheat.Instance.StartCheck())\n\t\t\t{\n\t\t\t\tyield break;' in text,
 'gemChecksPreserved':all(s in text for s in ('lastGemCount == 0 && gemCount >= 50001','unchecked(gemCount - lastGemCount) >= 50001','PlayerPrefs2Center.SetInt("LastGemCheck", gemCount);','gemCheck.Status = DailyTaskStatus.Finish;')),
 'progressCtorNativeConstants':all(s in text for s in ('currentMaxProgress = 0.2f;','progress1 = 0.64f;','progress2 = 0.9f;')),
 'timedWaitOnlyAssetProgress': 'while (AssetsManager.Instance.BundleLoadingProgress < 1f && loadingTimer < MaxLoadingTime)' in text,
 'realSceneLoadingPanelLookup': 'GameObject.Find("LoadingPanel").GetComponent<UIPanel>()' in text,
 'originalShowResultIgnored': '_ = _loadingPanel?.Show(Array.Empty<object>());' in text,
 'originalFloatUpdateInfoConsumer': all(s in text for s in ('_loadingPanel.UpdateInfo(p);','_loadingPanel.UpdateInfo(0f);','_loadingPanel.UpdateInfo(1f);')),
 'noPanelSubstitute': 'new GameObject' not in text and 'AddComponent' not in text,
 'originalUploadOptionGate': 'if (GameConfigManager.GameGlobalConfig.OpenUploadDataLogic)' in text,
 'originalGetDataAndSanitize':all(s in text for s in ('File.Exists(filePath) ? File.ReadAllText(filePath) : string.Empty','key.Replace("/", "_").Replace("\\\\", "_")','Path.Combine(SaveDirectory, key + ".txt")')),
 'oldEmptyStateMachineAttributesRemoved': '[IteratorStateMachine(typeof(_003CLoadingScene_003Ed__12))]' not in text and '[AsyncStateMachine(typeof(_003CInit_003Ed__19))]' not in text,
 'shortIdaMethodsCorrectlyBounded':len(targets)==4 and all(r.get('prototype_applied') and r.get('actual_function_start')==hex(r['address']) and r.get('actual_function_end')==hex(r['end']) and not r.get('unresolved_jumpout') for r in targets),
}
dependency_paths=[
 'GameConfigModule/GameConfigManager.cs','GameConfigModule/GameGlobalConfig.cs',
 'UIFramework/UIPanel.cs','UIModuleO/LoadingPanel.cs','DataModule/DataManager.cs',
 'QuickTutor/TutorialManager.cs','GameModule/GameManager.cs','DataModule/CompareCheat.cs',
 'SDKModule/HWIAPManager.cs','GameModule/UserResourcesManager.cs','GameModule/ReportEventsManager.cs',
 'DailyTask.cs','L_Tools/PlayerPrefs2Center.cs','ToolModule/StringTool.cs']
dependency_snapshot=[]
for name in dependency_paths:
    path=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp'/name
    if path.exists():dependency_snapshot.append({'path':str(path),'sha256':hashlib.sha256(path.read_bytes()).hexdigest()})
report={'scope':'Static source/native evidence audit; not Unity compilation, coroutine execution or gameplay acceptance',
 'source':str(SOURCE),'sourceSha256':hashlib.sha256(raw).hexdigest(),'sourceBytes':len(raw),'metaSha256':hashlib.sha256(meta).hexdigest(),
 'checks':checks,'allStaticChecksPassed':all(checks.values()),
 'constructorConstants':json.loads((WORK/'constructor-constants.json').read_text(encoding='utf-8')),
 'shortIdaMethods':targets,'largeIterator':'Reconstructed from original complete ASM 0x4083954..0x4084190; no repeat Hex-Rays decompilation',
 'dependencySourceSnapshot':dependency_snapshot,
 'runtimeAcceptance':'not-run by this agent; unified Unity import delegated to root'}
(WORK/'static-verification.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
(OUT/'static-verification.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
(OUT/'LoadingManager.before.cs.txt').write_bytes((WORK/'LoadingManager.before.cs').read_bytes())
(OUT/'LoadingManager.recovered.cs.txt').write_bytes(raw)
diff=''.join(difflib.unified_diff([s+'\n' for s in (WORK/'LoadingManager.before.cs').read_text(encoding='utf-8-sig').splitlines()],[s+'\n' for s in text.splitlines()],fromfile='LoadingManager.before.cs',tofile='LoadingManager.cs'))
(OUT/'LoadingManager.patch').write_text(diff,encoding='utf-8')
for name in ('inspect_native.py','native-consumer-evidence.json','constructor-constants.json','source-before.json','verify_and_archive.py'):
    shutil.copyfile(WORK/name,OUT/name)
for method in native['methods']:
    source=ROOT/method['assembly'];shutil.copyfile(source,OUT/source.name)
for rva in target_rvas:
    for suffix in ('.c','.asm.txt'):
        source=ROOT/'work/ida-framework-assets/pseudocode'/(hex(rva)+suffix);shutil.copyfile(source,OUT/('ida-'+source.name))
for name in ('LoadingScene.candidate.cs','loading-state-machine.md','loading-constants.json'):
    shutil.copyfile(ROOT/'work/startup-restore'/name,OUT/name)
(OUT/'status-loading-short-methods.json').write_text(json.dumps({'sourceStatus':'status-loading-astar.json','stage':status['stage'],'methods':targets},ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({'sourceSha256':report['sourceSha256'],'checks':checks,'allStaticChecksPassed':all(checks.values()),'archive':str(OUT)},ensure_ascii=True,indent=2))
if not all(checks.values()):raise SystemExit(1)
