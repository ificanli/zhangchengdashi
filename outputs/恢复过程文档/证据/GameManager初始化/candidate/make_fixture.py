import hashlib,json,re,sys
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gamemanager-recovery';proof=json.loads((own/'candidate-provenance.json').read_text(encoding='utf-8'))
path=own/'GameManager.candidate.cs' if '--candidate' in sys.argv else root/'work/recovery-stubs/gamemanager-before/GameManager.cs' if '--baseline' in sys.argv else root/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/GameModule/GameManager.cs'
text=path.read_text(encoding='utf-8-sig');methods=[];hashes={}
for name in proof['candidateMethods']:
    m=re.search(r'\b(?:public|private)\s+(?:override\s+)?(?:async\s+)?[\w<>]+\s+'+name+r'\([^\n]*\)\s*\{',text);assert m,name;i=text.index('{',m.start());j=i+1;depth=1
    while depth:depth+=(text[j]=='{')-(text[j]=='}');j+=1
    code=text[m.start():j];hashes[name]=hashlib.sha256(code.encode()).hexdigest();code=code.replace('override ','').replace('UniTask.WaitForSeconds','TestTasks.WaitForSeconds').replace('UniTask','Task');methods.append(code)
fields='''public bool InitComplete; private bool _isFirstThroghGame; public UpdateController updateController'''+(' = new UpdateController();' if 'updateController = new UpdateController()' in text else ';')+''' private GameObject APostProcess,BPostProcess; private TimeManager.Timer canPushGiftPackTimer; private Action onGameManagerInitComplete; private bool showNoInternetPanel,closeLoadPanel;'''
usings=['System','System.Collections','System.Collections.Generic','System.Linq','System.Threading.Tasks','BadgeGraph','DataModule','EventModule','SDKModule','QuickTutor','UIFramework','ljzs_lt','TimeModuleO','ToolModule','UnityEngine']
fixture='// Extracted actual source bodies. Task/Unity adapters only exist in this work fixture.\n'+'\n'.join('using '+u+';' for u in usings)+'\nnamespace GameModule { public class GameManager : MonoBehaviour {\n'+fields+'\n'+'\n'.join(methods)+'\nprivate void CardSteerEnd(object o) {}\n}}'
(own/'tests').mkdir(exist_ok=True);(own/'tests/GameManager.fixture.cs').write_text(fixture,encoding='utf-8');(own/'fixture-provenance.json').write_text(json.dumps(dict(source=str(path),sourceSha256=hashlib.sha256(path.read_bytes()).hexdigest(),methods=hashes,adaptations=['UniTask replaced by Task within work fixture','Unity and other business dependencies are controlled adapters, not runtime acceptance']),indent=2),encoding='utf-8');print('Extracted',len(methods),'actual bodies')
regular=['HWLeaderboardManager','HomelLandCtrl','HomelLandCtrlNew','BadgeManager','BoxManager','ArenaProgressManager','TrophyProgressManager','PlayerCustomizationManager','PlayerLevelManager','UserLableManager','UserLablePushPackManager','MetaBtnSecondClickManager','SkinManager','SynergyEffectManager','RoleShadowManager','GiftChainManager','GiftChainManager2','MultistageNewcomerPackageManager','UpgradeRewardManager','MysteriousStoreManager','BackpackManager','WeeklyCardActivityManager','MysteryAdventureManager','WorldCupActivityManager','FundManager']
namespaces={'HWLeaderboardManager':'SDKModule','BadgeManager':'BadgeGraph'}
out='using System.Threading.Tasks;\n'+'\n'.join('namespace '+namespaces.get(n,'GameModule')+' { public class '+n+' { public static '+n+' Instance {get;}=new(); public Task Init()=>Env.Begin("'+n+'"); } }' for n in regular)
(own/'tests/GeneratedManagers.cs').write_text(out,encoding='utf-8')
