import hashlib,json,re,sys
from pathlib import Path
root=Path(__file__).resolve().parents[2]
own=root/'work/game-launcher-recovery'
source=root/('work/recovery-stubs/game-launcher-before/GameLauncher.cs' if '--baseline' in sys.argv else 'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/CoreModule/GameLauncher.cs')
text=source.read_text(encoding='utf-8-sig')
names=['Awake','InitBaseManager','Start','Login','GameLogic','RunInitManager','InitManager','StartBackgroundManagersInit','LoadingCompleted','StartLoadingCompletedListening','StopLoadingCompletedListening','InitGame','SetOptimalPerformanceSettings','ApplyThirtyFpsRenderingSettings','ApplyThirtyFpsLightingSettings','DisablePostProcessingForLoadedCameras','TrySetRendererFeatureActive','TryGetDefaultRendererData','TrySetPropertyOrField']
methods=[]
hashes={}
for name in names:
    match=re.search(r'\bprivate\s+(?:async\s+)?[\w<>]+\s+'+name+r'(?:<T>)?\([^\n]*\)\s*\{',text)
    if not match: raise ValueError(name)
    start=match.start(); i=text.index('{',start); depth=1; j=i+1
    # Bodies contain no strings with braces in this source. Check the native source at review.
    while depth:
        depth += (text[j]=='{')-(text[j]=='}'); j+=1
    method=text[start:j]
    hashes[name]=hashlib.sha256(method.encode()).hexdigest()
    method=method.replace('UniTask.WaitUntil','TestTasks.WaitUntil').replace('UniTask.WhenAll','Task.WhenAll').replace('UniTaskVoid','Task').replace('UniTask','Task')
    if '--baseline' in sys.argv and name=='TryGetDefaultRendererData':
        method=method.replace('return default;','rendererData = null; return default;')
    methods.append(method)
usings=['System','System.Reflection','System.Threading.Tasks','UnityEngine','UnityEngine.Rendering','UnityEngine.Rendering.Universal','AssetsModule','DataModule','EventModule','GameConfigModule','GameModule','LoadingModule','LocalizationModule.Runtime','SDKModule','TimeModuleO','TutorModule','UIFramework','UIModuleO']
fixture='// Generated from current GameLauncher.cs; TEST ONLY, not installed into Unity.\n'+'\n'.join(f'using {u};' for u in usings)+'\nnamespace CoreModule { public class GameLauncher : MonoBehaviour { private Task _initBaseManagerTask; private bool _isLoadingCompletedListening;\n'+'\n\n'.join(methods)+'\n}}\n'
(own/'tests').mkdir(exist_ok=True)
(own/'tests/LauncherFixture.cs').write_text(fixture,encoding='utf-8')
(own/'fixture-source-hashes.json').write_text(json.dumps({'source':str(source),'sha256':hashlib.sha256(text.encode()).hexdigest(),'methods':hashes,'adaptations':['UniTask task-like type replaced by System.Threading.Tasks.Task only inside work fixture','WaitUntil replaced with manually ticked predicate scheduler','UniTask.WhenAll replaced with Task.WhenAll','baseline out-parameter assigned null to compile the pre-existing illegal stub']},indent=2),encoding='utf-8')
background=['TutorModule.FeatureUnlockManager','AudioManager','UIModuleO.UIHUDManager','AssetsModule.EffectManager','UIModuleO.UITextEffectManager','AssetsModule.MaterialsManager','GameModule.SteerManager','GameModule.CheckStayGetRewardManager','GameModule.ReportEventsManager','GameModule.PanelPopHandleManager','GameModule.PacksTipManager','UIModuleO.PropDetailsManager','SDKModule.AdButtonManager','AnnouncementManager','GameModule.ResourceObtainGuideManager','CheckInRewardManager','GameModule.SubGameChaosTrailsManager']
regular=background+['GameModule.UserResourcesManager','CameraModule.CameraManager','GameModule.GameManager','SDKModule.HWIAPManager','GameConfigModule.GameConfigManager']
decls=[]
for full in regular:
    namespace,_,name=full.rpartition('.')
    body=f'public class {name} {{ public static {name} Instance {{ get; }} = new(); public Task Init() => Env.Begin("{name}"); }}'
    decls.append(f'namespace {namespace} {{ {body} }}' if namespace else body)
(own/'tests/GeneratedManagers.cs').write_text('using System.Threading.Tasks;\n'+'\n'.join(decls),encoding='utf-8')
print('Extracted',len(methods),'actual method bodies from',source)
