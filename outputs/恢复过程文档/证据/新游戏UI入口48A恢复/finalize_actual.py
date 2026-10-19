import hashlib
import json
from pathlib import Path

ROOT = Path(__file__).resolve().parents[2]
OWN = ROOT / 'work/stage48-new-ui'
PROJECT = ROOT / 'outputs/OccupyCityRecovered'
audit = json.loads((OWN / 'final-audit.json').read_text(encoding='utf-8'))
plan = json.loads((ROOT / 'work/parallel-coordination/stage48-ui-plan-handoff.json').read_text(encoding='utf-8'))
sha = lambda path: hashlib.sha256(path.read_bytes()).hexdigest()
for file in audit['files']:
    source = PROJECT / file['path']
    assert sha(source) == file['afterSha256']
    assert sha(source.with_suffix('.cs.meta')) == file['metaSha256']
result = dict(
    stage=48,
    status='stable-48A-actual-four-method-source-applied-and-verified-runtime-not-accepted',
    stable=True,
    ownedFiles=[file['path'] for file in audit['files']],
    files=audit['files'],
    restoredMethodCount=4,
    originalMethods=plan['proposedMinimumMethods'] + [dict(file='Assets/Scripts/Assembly-CSharp/UIFramework/UIPanel.cs', method='Init(PanelConfig)', token='0x06004C4C', rva='0x4275658', nativeBodyBytes=8, body='original panelConfig private field store')],
    protectedNonempty=plan['protectedNonempty'],
    originalTokenSequencePreserved=True,
    allOtherMethodBodiesAndMetasUnchanged=True,
    tests=audit['tests'],
    sourceChecks=audit['sourceChecks'],
    ILChecks=audit['ILChecks'],
    fullMainCompile=audit['fullMainCompile'],
    typedLoad='Existing AssetsManager.LoadAssetAsync<GameObject>(full panelPath), original await then second dictionary lookup, original Object.Instantiate(prefab,parent), actual UIPanel component',
    originalFailureSemantics='Asset/Instantiate failures before insertion do not cache. Hidden/cache insertion precedes camera/config; later dependency failures retain the original already-inserted hidden cache. No rollback or placeholder.',
    firstPanel=plan['firstPanel'],
    dependencies=plan['dependencies'],
    excludedScopes=['UICamera getter/CameraManager.Init', 'UIManager Show/Hide wrappers', 'UIPanel Show/Hide/IsShowing/Canvas/TweenRoot', 'NoInternetPanel.Show and component binding', 'stage50 CoreBlit2 shader error', 'stage39 old resource probe'],
    inspectedNativeMethods=38,
    inspectedNativeBytes=11772,
    boundedNativeTargets=21,
    UnityOperations=0,
    installedExperimentDll=False,
    actualTypedUnityLoad=False,
    UnityInstantiationAccepted=False,
    visibleUIAccepted=False,
    coreGameplayAccepted=False,
    stableNotifiedToParent=True,
    report='outputs/恢复过程文档/48-新游戏UI入口最小恢复路线.md',
    implementationEvidence='outputs/恢复过程文档/证据/新游戏UI入口48A恢复',
    previousPlanningEvidence='outputs/恢复过程文档/证据/新游戏UI入口计划',
    nextRuntimeObservation='Root only: official typed NoInternetPanel load and actual address/type/identity/parent/activeSelf/config/camera/cache readback under real upstream prerequisites; no forced Show or flags',
)
target = ROOT / 'work/parallel-coordination/stage48-handoff.json'
target.write_text(json.dumps(result, ensure_ascii=False, indent=2), encoding='utf-8')
print(json.dumps(dict(status=result['status'], stable=True, handoff=str(target), restoredMethodCount=4, tests=result['tests'], mainCompileErrors=result['fullMainCompile']['errorCount'], ILChecks=len(result['ILChecks'])), ensure_ascii=True, indent=2))
