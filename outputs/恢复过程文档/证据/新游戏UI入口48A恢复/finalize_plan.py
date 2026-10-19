import hashlib
import json
import re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];OWN=ROOT/'work/stage48-new-ui';PROJECT=ROOT/'outputs/OccupyCityRecovered'
source=PROJECT/'Assets/Scripts/Assembly-CSharp/UIFramework/UIManager.cs';before=OWN/'source-before/UIManager.cs'
sha=lambda p:hashlib.sha256(p.read_bytes()).hexdigest()
assert source.read_bytes()==before.read_bytes()
assert source.with_suffix('.cs.meta').read_bytes()==before.with_suffix('.cs.meta').read_bytes()
metadata=json.loads((OWN/'native-consumer-evidence.json').read_text(encoding='utf-8'))
methods={m['address']:m for m in metadata['methods']}
native_status=json.loads((OWN/'ida/status-bounded.json').read_text(encoding='utf-8'))
assert native_status['stage']=='complete'and len(native_status['methods'])==21
assert all(m['actual_function_start']==hex(m['address'])and m['actual_function_end']==hex(m['end'])for m in native_status['methods'])
method_plan=[
 dict(file='Assets/Scripts/Assembly-CSharp/UIFramework/UIManager.cs',method='Init',token='0x06004C57',rva='0x4275c18',body='0x4276f18',awaits=0),
 dict(file='Assets/Scripts/Assembly-CSharp/UIFramework/UIManager.cs',method='GetPanel',token='0x06004C58',rva='0x4275c9c',body='0x42767ac',awaits=1),
 dict(file='Assets/Scripts/Assembly-CSharp/UIFramework/UIManager.cs',method='LoadPanel',token='0x06004C5C',rva='0x4275fec',body='0x42771b0',awaits=1),
]
for item in method_plan:
    body=methods[item['body']];item.update(nativeBodyBytes=body['bytes'],nativeBodySha256=body['codeSha256'])
dependencies=[
 dict(file='Assets/Scripts/Assembly-CSharp/UIFramework/UIPanel.cs',method='Init(PanelConfig)',token='0x06004C4C',rva='0x4275658',currentBody='empty',neededScope='proposed exact leaf extension; original 8-byte field store to +0x38, no other UIPanel edits'),
 dict(file='Assets/Scripts/Assembly-CSharp/CameraModule/CameraManager.cs',method='UICamera getter',token='0x060020A7',rva='0x3f0e8cc',currentBody='return null',neededScope='separate native camera producer/retrieval audit before claiming original worldCamera binding'),
 dict(file='Assets/Scripts/Assembly-CSharp/UIFramework/UIPanel.cs',method='Show/Hide/IsShowing/Canvas/TweenRoot',token='0x06004C44 / 45 / 41 / 42 / 3E / 3F',rva='0x4275338 / 0x42753bc / 0x4275280 / 0x42752a0 / 0x427520c / 0x4275214',currentBody='exported stubs',neededScope='later actual display/animation closure; minimum preload does not call Show'),
 dict(file='Assets/Scripts/Assembly-CSharp/UIModuleO/NoInternetPanel.cs',method='Show override and component binding',token='0x06003E88',rva='0x416f664',body='0x416fee0',currentBody='exported stubs',neededScope='later concrete first-panel display/connection policy; not authorized in minimum manager-only step'),
 dict(file='Assets/Scripts/Assembly-CSharp/DataModule/GlobalInfo.cs',method='panelConfigs real load/deserialize',currentBody='stage41 owner',neededScope='read-only dependency; use actual loaded config, no injected substitute rows'),
]
baselines=[]
for relative in [method_plan[0]['file'],dependencies[0]['file'],dependencies[1]['file'],'Assets/Scripts/Assembly-CSharp/UIModuleO/NoInternetPanel.cs','Assets/Scripts/Assembly-CSharp/AssetsModule/AssetsManager.cs','Assets/Scripts/Assembly-CSharp/CoreModule/GameLauncher.cs']:
    path=PROJECT/relative;baselines.append(dict(path=relative,sha256=sha(path),metaSha256=sha(path.with_suffix('.cs.meta'))))
plan=dict(stage=48,status='read-only-work-candidate-preflight-awaiting-root-scope',proposedOwnedFiles=[method_plan[0]['file']],proposedMinimumMethods=method_plan,requiredNarrowLeafExtension=dependencies[0],dependencies=dependencies[1:],protectedNonempty=[dict(file=method_plan[0]['file'],method='IsPanelShowing',token='0x06004C59',rva='0x4275d78',protection='explicit RECOVERY_UNIMPLEMENTED diagnostic retained byte-for-byte; not part of minimum candidate'),dict(file=dependencies[0]['file'],method='IsPlayTween getter',token='0x06004C40',rva='0x4275278',protection='existing restored field getter untouched'),dict(file='Assets/Scripts/Assembly-CSharp/AssetsModule/AssetsManager.cs',method='LoadAssetAsync<T>',protection='reuse actual typed Addressables/cache/reference-count implementation; do not replace with placeholder/provider shortcut')],baselines=baselines,firstRoot='Original new GameObject("UIPanelsRoot").transform in async-no-await Init; no GF UIRoot prefab or GFUICanvas dependency',firstPanel='GameLauncher.InitManager only preloads NoInternetPanel through GetPanel; originally hidden in cache, not a mandated visible first screen',candidate=dict(path='work/stage48-new-ui/UIManager.candidate.cs',sha256=sha(OWN/'UIManager.candidate.cs'),independentCompileErrors=0,independentCompileWarnings=9,referenceSource='Formally imported actual Unity/UniTask/Main/GF metadata; no experiment DLL installed'),nativeTargets='work/stage48-new-ui/ida/targets.json',nativeTargetsBounded=21,inspectedMethods=len(metadata['methods']),inspectedBytes=sum(m['bytes']for m in metadata['methods']),productionSourceEdits=0,UnityLaunches=0,actualTypedUnityLoad=False,UIVisibleAcceptance=False,tests='not-run in this read-only planning stage',plannedVerification=['actual source vs candidate narrow/Token/meta readback','controlled Task/UniTask cold/cache/after-await race/failure/null/missing-component/config-order tests','full Main source compile with real dependencies','root GUI official typed Addressables load + actual clone/cache/activeSelf/config/camera identities without forced Show or flags'])
(OWN/'minimal-recovery-plan.json').write_text(json.dumps(plan,ensure_ascii=False,indent=2),encoding='utf-8')
(ROOT/'work/parallel-coordination/stage48-ui-plan-handoff.json').write_text(json.dumps(plan,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({k:v for k,v in plan.items()if k not in{'baselines','dependencies','protectedNonempty','plannedVerification'}},ensure_ascii=True,indent=2))
