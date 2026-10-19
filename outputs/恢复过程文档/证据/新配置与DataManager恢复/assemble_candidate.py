"""Compose owned-file candidates in work; does not mutate the Unity project."""
import base64,gzip,hashlib,json,re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
WORK=ROOT/'work/new-config-restore'
BASE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/DataModule'
def replace_body(source,signature,body):
    start=source.index('{',source.index(signature));depth=0
    for end in range(start,len(source)):
        if source[end]=='{':depth+=1
        elif source[end]=='}':
            depth-=1
            if depth==0:break
    return source[:start]+'{\n'+''.join('\t\t\t'+line+'\n' for line in body.splitlines())+'\t\t}'+source[end+1:]

global_source=(BASE/'GlobalInfo.cs').read_text(encoding='utf-8-sig')
global_source=global_source.replace('using Cysharp.Threading.Tasks;','using Cysharp.Threading.Tasks;\nusing AssetsModule;\nusing LitJson;\nusing SDKModule;\nusing ToolModule;\nusing UnityEngine;')
global_source=global_source.replace('\t\t[AsyncStateMachine(typeof(_003CInitInfo_003Ed__92))]\n','').replace('\t\t[AsyncStateMachine(typeof(_003CLoadGlobalInfo_003Ed__94<>))]\n','')
global_source=global_source.replace('public Task InitInfo()','public async Task InitInfo()').replace('private void LoadGlobalInfo<T>','private async void LoadGlobalInfo<T>')
global_source=replace_body(global_source,'public async Task InitInfo()', (WORK/'init-info-body.candidate.txt').read_text(encoding='utf-8').rstrip())
load='''if (hadLoadInfo.Contains(jsonPath))
{
    UnityEngine.Debug.LogError("配置文件文件多次加载：" + jsonPath);
}
else
{
    hadLoadInfo.Add(jsonPath);
}
loadingConfig.Add(jsonPath);
int slashIndex = jsonPath.LastIndexOf('/');
int dotIndex = jsonPath.LastIndexOf('.');
string resourceName = jsonPath.Substring(slashIndex + 1, dotIndex - slashIndex - 1);
TextAsset asset = UnityEngine.Resources.Load<TextAsset>("JsonData/" + resourceName);
if (asset == null)
{
    UnityEngine.Debug.LogWarning("配置文件文件不在Resources目录下，尝试从StreamingAssets目录加载：" + jsonPath);
    asset = await AssetsManager.Instance.LoadAssetAsync<TextAsset>(jsonPath);
}
onComplete?.Invoke(GlobalStringToConfig<T>(jsonPath, asset.text));
loadingConfig.Remove(jsonPath);'''
global_source=replace_body(global_source,'private async void LoadGlobalInfo<T>',load)
parser='''try
{
    jsonStr = GZipTool.DecompressFromBase64(jsonStr);
    return JsonMapper.ToObject<List<T>>(jsonStr);
}
catch (Exception exception)
{
    Console.WriteLine(exception);
    UnityEngine.Debug.LogError(string.Format("GlobalStringToConfig Fail => T = {0} jsonStr = {1}", typeof(T), jsonStr));
    throw;
}'''
global_source=replace_body(global_source,'private List<T> GlobalStringToConfig<T>',parser)
head_ids=['1003','1002']+[str(i) for i in range(1004,1014)]+[str(i) for i in range(1016,1027)]
ctor='loadingConfig = new List<string>();\nHeadShotIDS = new List<string> { '+', '.join(json.dumps(s) for s in head_ids)+' };\nhadLoadInfo = new List<string>();'
global_source=replace_body(global_source,'public GlobalInfo()',ctor)
callbacks=(WORK/'callbacks.candidate.txt').read_text(encoding='utf-8').rstrip()
last=global_source.rfind('\n\t}\n}')
global_source=global_source[:last]+'\n\n'+''.join('\t\t'+s+'\n' for s in callbacks.splitlines())+global_source[last:]
(WORK/'GlobalInfo.candidate.cs').write_text(global_source,encoding='utf-8')

data_source=(BASE/'DataManager.cs').read_text(encoding='utf-8-sig')
data_source=data_source.replace('using ToolModule;','using ToolModule;\nusing EventModule;')
data_source=data_source.replace('\t\t[AsyncStateMachine(typeof(_003CLoadConfig_003Ed__15))]\n','').replace('\t\t[AsyncStateMachine(typeof(_003CInit_003Ed__14))]\n','')
data_source=data_source.replace('public UniTask LoadConfig()','public async UniTask LoadConfig()').replace('public override UniTask Init()','public override async UniTask Init()')
data_source=replace_body(data_source,'public async UniTask LoadConfig()','GlobalInfo = new GlobalInfo();\nawait GlobalInfo.InitInfo();\nloadConfigComplete = true;')
data_source=replace_body(data_source,'public override async UniTask Init()','EventManager.Instance.StartListening("StartGame", PlayGame);\nEventManager.Instance.StartListening("GameWin", GameWin);')
# Replace only the GlobalInfo property's original empty accessors. The earlier
# LoadDataCompleted auto-property is a separate, already-restored contract.
p=data_source.index('public GlobalInfo GlobalInfo')
end=data_source.index('\n\t\t[Token(Token = "0x6005730")]',p)
prop=data_source[p:end]
prop=prop.replace('get\n\t\t\t{\n\t\t\t\treturn null;\n\t\t\t}', 'get;').replace('private set\n\t\t\t{\n\t\t\t}', 'private set;')
data_source=data_source[:p]+prop+data_source[end:]
assert 'public bool LoadDataCompleted' in data_source
old_property=(BASE/'DataManager.cs').read_text(encoding='utf-8-sig').split('public bool LoadDataCompleted',1)[1].split('public GlobalInfo GlobalInfo',1)[0]
new_property=data_source.split('public bool LoadDataCompleted',1)[1].split('public GlobalInfo GlobalInfo',1)[0]
assert old_property==new_property
(WORK/'DataManager.candidate.cs').write_text(data_source,encoding='utf-8')

all_paths=set(re.findall(r'Assets/_Res/[^"\n]+\.json',global_source))
native=json.loads((WORK/'native-consumer-evidence.json').read_text(encoding='utf-8'))
init=next(r for r in native['methods'] if '<InitInfo>d__92$$MoveNext' in r['name'])
original_paths={r['Value'] for r in init['metadataReferences'] if r['category']=='ScriptString' and r['Value'].startswith('Assets/_Res/')}
assert all_paths==original_paths,(sorted(original_paths-all_paths),sorted(all_paths-original_paths))
resource_audit=[]
for original_path in sorted(all_paths):
    project=ROOT/'outputs/OccupyCityRecovered'/original_path
    resource=ROOT/'outputs/OccupyCityRecovered/Assets/Resources/JsonData'/(Path(original_path).stem+'.txt')
    raw=project.read_bytes();plain=gzip.decompress(base64.b64decode(raw,validate=True));obj=json.loads(plain)
    resource_audit.append({'originalAddress':original_path,'rawBytes':len(raw),'rawSha256':hashlib.sha256(raw).hexdigest(),'decodedBytes':len(plain),'decodedSha256':hashlib.sha256(plain).hexdigest(),'jsonRootType':type(obj).__name__,'recordCount':len(obj),'resourcesPath':str(resource),'resourcesExists':resource.is_file(),'resourcesBytesMatch':resource.is_file() and resource.read_bytes()==raw})
(WORK/'resource-audit.json').write_text(json.dumps(resource_audit,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({'nativePaths':len(original_paths),'candidatePaths':len(all_paths),'allPathsMatch':all_paths==original_paths,'all81GzipJsonValid':all(r['jsonRootType']=='list' for r in resource_audit),'resourcesPresent':sum(r['resourcesExists'] for r in resource_audit),'resourcesBytesMatch':sum(r['resourcesBytesMatch'] for r in resource_audit),'headshotIDs':head_ids,'dataCompletedPropertyPreserved':old_property==new_property},ensure_ascii=True,indent=2))
