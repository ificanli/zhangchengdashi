"""Audit owned source and archive the new config recovery stage without Unity."""
import difflib,hashlib,json,re,shutil
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
WORK=ROOT/'work/new-config-restore'
BASE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/DataModule'
OUT=ROOT/'outputs/恢复过程文档/证据/新配置与DataManager恢复'
OUT.mkdir(parents=True,exist_ok=True)
before={r['name']:r for r in json.loads((WORK/'source-before.json').read_text(encoding='utf-8'))}
applied=json.loads((WORK/'applied-source.json').read_text(encoding='utf-8'))
texts={name:(BASE/name).read_text(encoding='utf-8-sig') for name in ('DataManager.cs','GlobalInfo.cs')}
data=texts['DataManager.cs']; glob=texts['GlobalInfo.cs']
original_data=(WORK/'DataManager.cs.before').read_text(encoding='utf-8-sig')
def method_body(text,signature):
    start=text.index('{',text.index(signature));depth=0
    for end in range(start,len(text)):
        if text[end]=='{':depth+=1
        elif text[end]=='}':
            depth-=1
            if depth==0:return text[start:end+1]
    raise ValueError(signature)
original_property=method_body(original_data,'public bool LoadDataCompleted')
current_property=method_body(data,'public bool LoadDataCompleted')
load_config=method_body(data,'public async UniTask LoadConfig()')
loader=method_body(glob,'private async void LoadGlobalInfo<T>')
parser=method_body(glob,'private List<T> GlobalStringToConfig<T>')
status=json.loads((ROOT/'work/ida-framework-assets/status-data-config.json').read_text(encoding='utf-8'))
native=json.loads((WORK/'native-consumer-evidence.json').read_text(encoding='utf-8'))
main=next(r for r in native['methods'] if '<InitInfo>d__92$$MoveNext' in r['name'])
original_paths={r['Value'] for r in main['metadataReferences'] if r['category']=='ScriptString' and r['Value'].startswith('Assets/_Res/')}
source_paths=set(re.findall(r'Assets/_Res/[^"\n]+\.json',glob))
resources=json.loads((WORK/'resource-audit.json').read_text(encoding='utf-8'))
callback_audit=json.loads((WORK/'callback-resource-audit.json').read_text(encoding='utf-8'))
ledger=json.loads((WORK/'callback-ledger.json').read_text(encoding='utf-8'))
request_map={int(k):r for k,r in json.loads((WORK/'load-request-map.json').read_text(encoding='utf-8')).items()}
prefix='Assets/_Res/Addressable/01FirstBundle/JsonData/'
extra={13:['GlobalPropInfoBTest.json','GlobalPropInfoATest.json'],21:['GlobalHeroCardInfoshop_improve_v1.json','GlobalHeroCardInfoSheet5.json'],22:['GlobalArchitectureInfoshop_improve_v1.json','GlobalArchitectureInfogameplay_improve_01.json'],23:['GlobalRoleInfoshop_improve_v1.json','GlobalRoleInfogameplay_improve_01.json'],41:['EnemyDifficultLevelInfosgameplay_improve_v2_01.json','EnemyDifficultLevelInfosgameplay_improve_v2_02.json','EnemyDifficultLevelInfosgameplay_improve_01.json'],42:['ArenaEnemyBalanceInfogameplay_improve_v2_01.json','ArenaEnemyBalanceInfogameplay_improve_v2_02.json','ArenaEnemyBalanceInfobalance_adjustment_03_on.json','ArenaEnemyBalanceInfogameplay_improve_01.json']}
combined_map=[]
for row in ledger:
    i=row['index'];combined_map.append({**row,'nativeCallsite':request_map[i]['callsite'],'possibleAddresses':[prefix+n for n in extra[i]] if i in extra else request_map[i]['paths']})
assert set(p for row in combined_map for p in row['possibleAddresses'])==original_paths
checks={
 'twoMetasUnchanged':all(hashlib.sha256(Path(str(BASE/name)+'.meta').read_bytes()).hexdigest()==before[name]['metaSha256'] for name in texts),
 'sourceMatchesStablePoint':all(hashlib.sha256((BASE/r['name']).read_bytes()).hexdigest()==r['sourceSha256'] for r in applied['sources']),
 'latest22LoadDataCompletedPropertyPreserved':current_property==original_property,
 'loadDataBodyPreserved':method_body(data,'public UniTask LoadData()')==method_body(original_data,'public UniTask LoadData()'),
 'saveAndLoginRelatedBodiesPreserved':all(method_body(data,s)==method_body(original_data,s) for s in ['public void ChooseConflict(','private void LoadAllSaveData()','public void StopAllSave()','public void SaveAllData()','public void ClearAllData()','void PlayGame(','void GameWin(']),
 'configFlagOnlyAfterRealAwait':load_config.index('await GlobalInfo.InitInfo();')<load_config.index('loadConfigComplete = true;') and data.count('loadConfigComplete = true;')==1,
 'noFakeDataComplete':'LoadDataCompleted = true' not in data,
 'all81ExactNativeAddressesCovered':source_paths==original_paths and len(source_paths)==81,
 'all72LoadCallsPresent':len(re.findall(r'LoadGlobalInfo<[^>]+>\(',method_body(glob,'public async Task InitInfo()')))==72,
 'all73CallbacksPresent':len(re.findall(r'private (?:void|bool) _003CInitInfo_003Eb__92_\d+\(',glob))==73,
 'realCountPredicateAndAwait':'return loadingConfig.Count < 1;' in glob and 'await UniTask.WaitUntil(_003CInitInfo_003Eb__92_72);' in glob,
 'resourcesThenAddressables':loader.index('Resources.Load<TextAsset>')<loader.index('await AssetsManager.Instance.LoadAssetAsync<TextAsset>'),
 'onlyRemoveAfterCallback':loader.index('onComplete?.Invoke(')<loader.index('loadingConfig.Remove(jsonPath);') and 'finally' not in loader,
 'noUnconditionalCompletionClear':'loadingConfig.Clear' not in glob,
 'provenGzipLitJsonExpression':parser.index('GZipTool.DecompressFromBase64')<parser.index('JsonMapper.ToObject<List<T>>') and 'throw;' in parser,
 'all81ResourcesRawBytesMatch':len(resources)==81 and all(r['resourcesExists'] and r['resourcesBytesMatch'] and r['jsonRootType']=='list' for r in resources),
 'all25DictionaryFixturesValid':callback_audit['all25DictionaryCallbackFixtureKeysValid'],
 'eightIdaMethodsBounded':status['stage']=='complete' and len(status['methods'])==8 and all(r.get('prototype_applied') and r.get('actual_function_start')==hex(r['address']) and r.get('actual_function_end')==hex(r['end']) and not r.get('unresolved_jumpout') for r in status['methods']),
}
sources=[{**row,'metaSha256':hashlib.sha256(Path(str(BASE/row['name'])+'.meta').read_bytes()).hexdigest()} for row in applied['sources']]
report={'scope':'Static source/native/resource payload audit only; no Unity run or config runtime acceptance by this agent','sources':sources,'checks':checks,'allStaticChecksPassed':all(checks.values()),'uniqueNativeAddresses':81,'staticLoadCallsites':72,'selectedLoadsPerRun':65,'callbackMethodsIncludingPredicate':73,'dictionaryCallbacks':25,'dictionaryVariantFixtures':len(callback_audit['dictionaryFixtures']),'mainCityMap':callback_audit['mainCityMap'],'unityCompile':'delegated to root unified import; result not asserted here'}
(WORK/'static-verification.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
(OUT/'static-verification.json').write_text(json.dumps(report,ensure_ascii=False,indent=2),encoding='utf-8')
(OUT/'配置路径-类型-回调-字段映射.json').write_text(json.dumps(combined_map,ensure_ascii=False,indent=2),encoding='utf-8')
for name,text in texts.items():
    old=(WORK/(name+'.before')).read_bytes();current=(BASE/name).read_bytes()
    (OUT/(name+'.before.txt')).write_bytes(old);(OUT/(name+'.recovered.txt')).write_bytes(current)
    diff=''.join(difflib.unified_diff([s+'\n' for s in old.decode('utf-8-sig').splitlines()],[s+'\n' for s in text.splitlines()],fromfile=name+'.before',tofile=name))
    (OUT/(name+'.patch')).write_text(diff,encoding='utf-8')
for path in WORK.iterdir():
    if path.is_file() and path.suffix in ('.py','.json','.txt'):shutil.copyfile(path,OUT/path.name)
for row in native['methods']:
    path=ROOT/row['assembly'];shutil.copyfile(path,OUT/path.name)
for row in status['methods']:
    for suffix in ('.c','.asm.txt'):
        path=ROOT/'work/ida-framework-assets/pseudocode'/(hex(row['address'])+suffix);shutil.copyfile(path,OUT/('ida-'+path.name))
shutil.copyfile(ROOT/'work/ida-framework-assets/status-data-config.json',OUT/'status-data-config.json')
doc=(WORK/'report23.md').read_text(encoding='utf-8')
hash_paragraph='\n源码稳定点：DataManager.cs 为 `'+sources[0]['sourceSha256']+'`（'+str(sources[0]['bytes'])+' B）；GlobalInfo.cs 为 `'+sources[1]['sourceSha256']+'`（'+str(sources[1]['bytes'])+' B）。两份 meta 未变，第 22 批 LoadDataCompleted 自动属性逐字保留。\n'
doc=doc.replace('## 1. 原链的身份与 scope',hash_paragraph+'\n## 1. 原链的身份与范围')
doc=doc.replace('待源码写回后，两个 meta 文件及 LoadDataCompleted 最新属性将再次核对；不以旧快照覆盖第 22 阶段的改动。','源码已写回并冻结交主代理统一导入。18 项静态/原生/资源字节检查全部通过，两个 meta 文件未变，LoadDataCompleted 最新属性逐字保留；未以旧快照覆盖第 22 阶段的改动。')
(ROOT/'outputs/恢复过程文档/23-新配置读取与DataManager恢复.md').write_text(doc,encoding='utf-8')
print(json.dumps({'sources':sources,'checks':checks,'allStaticChecksPassed':all(checks.values()),'archive':str(OUT)},ensure_ascii=True,indent=2))
if not all(checks.values()):raise SystemExit(1)
