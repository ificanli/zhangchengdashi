"""Build a reviewable C# candidate using explicit original native mappings."""
import json,re
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
WORK=ROOT/'work/new-config-restore'
BASE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp'
survey=json.loads((WORK/'field-callback-survey.json').read_text(encoding='utf-8'))
native=json.loads((WORK/'native-consumer-evidence.json').read_text(encoding='utf-8'))
mapping=json.loads((ROOT/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
methods={m['Name']:m for m in mapping['ScriptMethod']}
asm=(WORK/'0x435df2c.asm.txt').read_text(encoding='utf-8').splitlines()
records={}; last_callback=None; segment=[]
for line in asm:
    address=int(line.split(':')[0],16)
    if not 0x435f390<=address<0x4360bfc:continue
    match=re.search(r'Method\$DataModule.GlobalInfo\.<InitInfo>b__92_(\d+)\(\)',line)
    if match:last_callback=int(match.group(1));segment=[]
    if last_callback is not None:segment.append(line)
    if '// DataModule.GlobalInfo$$LoadGlobalInfo<object>' in line:
        paths=re.findall(r'// (Assets/_Res/[^\r\n]+)', '\n'.join(segment))
        records[last_callback]={'callback':last_callback,'callsite':hex(address),'paths':paths}
assert set(records)==set(range(72)),sorted(set(range(72))-set(records))
PREFIX='Assets/_Res/Addressable/01FirstBundle/JsonData/'
def quoted(s):return json.dumps(s,ensure_ascii=False)
def callback_name(i):return '_003CInitInfo_003Eb__92_'+str(i)
def data_type(i):return survey['callbacks'][i]['stores'][0]['type'][5:-1]
def call(i,path=None):
    if path is None:
        if len(records[i]['paths'])!=1:raise ValueError((i,records[i]))
        path=quoted(records[i]['paths'][0])
    return f'LoadGlobalInfo<{data_type(i)}>({path}, {callback_name(i)});'
lines=[]
def add(s=''):lines.extend(s.splitlines() if s else [''])
add('if (ABTestManager.Instance.NewMachineCardIsB)\n{\n    HeadShotIDS.Add("1027");\n    HeadShotIDS.Add("1028");\n}')
add('if (ABTestManager.Instance.NewCardsV1IsB)\n{'+''.join('\n    HeadShotIDS.Add("'+str(i)+'");' for i in range(1029,1034))+'\n}')
add('if (ABTestManager.Instance.WeeklyCardEventIsB)\n{'+''.join('\n    HeadShotIDS.Add("'+str(i)+'");' for i in range(1034,1038))+'\n}')
for i in range(1038,1041):add(f'HeadShotIDS.Add("{i}");')
for i in range(13):add(call(i))
add('string propPath = ABTestManager.Instance.NewArtifactsPlayIsBTest ? '+quoted(PREFIX+'GlobalPropInfoBTest.json')+' : '+quoted(PREFIX+'GlobalPropInfoATest.json')+';')
add(call(13,'propPath'))
for i in (14,15,16):add(call(i))
add('string architecturePath;\nstring rolePath;\nstring heroCardPath;\nif (ABTestManager.Instance.ShopImproveV1IsBTest)\n{\n    architecturePath = '+quoted(PREFIX+'GlobalArchitectureInfoshop_improve_v1.json')+';\n    rolePath = '+quoted(PREFIX+'GlobalRoleInfoshop_improve_v1.json')+';\n    heroCardPath = '+quoted(PREFIX+'GlobalHeroCardInfoshop_improve_v1.json')+';\n    UnityEngine.Debug.Log("建筑角色卡牌表使用shop_improve_v1数值");\n}\nelse\n{\n    architecturePath = '+quoted(PREFIX+'GlobalArchitectureInfogameplay_improve_01.json')+';\n    rolePath = '+quoted(PREFIX+'GlobalRoleInfogameplay_improve_01.json')+';\n    heroCardPath = '+quoted(PREFIX+'GlobalHeroCardInfoSheet5.json')+';\n    UnityEngine.Debug.Log("建筑角色卡牌表使用gameplay_improve_01数值");\n}')
add(call(17))
add('if (ABTestManager.Instance.AbilitiesInAdvanceIsBTest)\n{\n    '+call(19)+'\n}\nelse\n{\n    '+call(18)+'\n}')
add(call(20));add(call(21,'heroCardPath'));add(call(22,'architecturePath'));add(call(23,'rolePath'))
for i in (24,25,26):add(call(i))
add('if (ABTestManager.Instance.NewArenaProcessIsBTest)\n{\n    '+call(27)+'\n}\nelse\n{\n    '+call(28)+'\n}')
for i in (29,30,31):add(call(i))
add('if (ABTestManager.Instance.NewArenaProcessIsBTest)\n{\n    '+call(32)+'\n}\nelse\n{\n    '+call(33)+'\n}')
add('if (ABTestManager.Instance.NewbieTutorialIsBTest)\n{\n    '+call(34)+'\n}\nelse\n{\n    '+call(35)+'\n}')
for i in (36,37,38):add(call(i))
add('if (ABTestManager.Instance.ShopImproveV1IsBTest)\n{\n    '+call(39)+'\n}\nelse\n{\n    '+call(40)+'\n}')
add('string enemyDifficultyPath;\nstring arenaBalancePath;\nint gameplayVariant = ABTestManager.Instance.GamePlayImproveV2Variant;\nif (gameplayVariant == 1)\n{\n    enemyDifficultyPath = '+quoted(PREFIX+'EnemyDifficultLevelInfosgameplay_improve_v2_01.json')+';\n    arenaBalancePath = '+quoted(PREFIX+'ArenaEnemyBalanceInfogameplay_improve_v2_01.json')+';\n}\nelse if (gameplayVariant == 2)\n{\n    enemyDifficultyPath = '+quoted(PREFIX+'EnemyDifficultLevelInfosgameplay_improve_v2_02.json')+';\n    arenaBalancePath = '+quoted(PREFIX+'ArenaEnemyBalanceInfogameplay_improve_v2_02.json')+';\n}\nelse\n{\n    enemyDifficultyPath = '+quoted(PREFIX+'EnemyDifficultLevelInfosgameplay_improve_01.json')+';\n    if (ABTestManager.Instance.BalanceAdjustment03IsBTest)\n    {\n        arenaBalancePath = '+quoted(PREFIX+'ArenaEnemyBalanceInfobalance_adjustment_03_on.json')+';\n        UnityEngine.Debug.Log("竞技场敌人平衡表使用 BalanceAdjustment03 的 B 组数值");\n    }\n    else\n    {\n        arenaBalancePath = '+quoted(PREFIX+'ArenaEnemyBalanceInfogameplay_improve_01.json')+';\n        UnityEngine.Debug.Log("竞技场敌人平衡表使用 BalanceAdjustment03 的 A 组数值");\n    }\n}')
add(call(41,'enemyDifficultyPath'));add(call(42,'arenaBalancePath'))
for i in range(43,66):add(call(i))
add('if (ABTestManager.Instance.WeeklyClashImprove01IsBTest)\n{\n    '+call(66)+'\n}\nelse\n{\n    '+call(67)+'\n}')
add(call(68))
add('if (ABTestManager.Instance.WeeklyClashImprove01IsBTest)\n{\n    '+call(69)+'\n}\nelse\n{\n    '+call(70)+'\n}')
add(call(71));add('await UniTask.WaitUntil('+callback_name(72)+');')
init_body='\n'.join(lines)

def type_fields(name):
    path=next(BASE.rglob(name+'.cs'));text=path.read_text(encoding='utf-8-sig')
    result={int(m.group(1),16):m.group(2) for m in re.finditer(r'FieldOffset\(Offset = "(0x[0-9A-Fa-f]+)"\)\]\s*public\s+[^;\n]+?\s+(\w+);',text)}
    base=re.search(r'class\s+'+name+r'\s*:\s*(\w+)',text)
    if base and base.group(1)=='GlobalInfoBase':result={**type_fields('GlobalInfoBase'),**result}
    return result
callbacks=[]; callback_ledger=[]
for row in survey['callbacks']:
    i=row['index'];address=row['address']
    if i==72:
        body='return loadingConfig.Count < 1;';ret='bool';args=''
    else:
        typ=data_type(i);ret='void';args='List<'+typ+'> list'
        fs=row['stores'];body=fs[0]['name']+' = list;'
        if i==47:
            body+='\ntileInfos = new List<GlobalMapInfo>();\ntileInfoDic = new Dictionary<string, GlobalMapInfo>();\nforeach (GlobalMainCityMapInfo map in mapInfos)\n{\n    foreach (GlobalMapInfo tile in JsonMapper.ToObject<List<GlobalMapInfo>>(map.infos))\n    {\n        tileInfos.Add(tile);\n        tileInfoDic.TryAdd(tile.tileKey, tile);\n    }\n}'
        elif len(fs)==2:
            keyoff=int(row['keyLoads'][-1],16); member=type_fields(typ)[keyoff]
            dic=fs[1];ls=fs[0]['name']; body+='\n'+dic['name']+' = new '+dic['type']+'();\nfor (int index = 0; index < '+ls+'.Count; ++index)\n{\n    '+dic['name']+'.Add('
            key=f'{ls}[index].{member}'
            if i in (41,45):key='StringTool.ToInt('+key+')'
            body+=key+', '+ls+'[index]);\n}'
            if i==21:body+='\nUnityEngine.Debug.Log("OOO卡牌B测试，加载完配置，一共条数据" + heroCardInfos.Count.ToString());'
        callback_ledger.append({'index':i,'address':address,'type':typ,'fieldStores':fs,'keyMember':member if len(fs)==2 else None,'keyOffset':hex(keyoff) if len(fs)==2 else None})
    callbacks.append('[CompilerGenerated]\n[Address(RVA = "'+address.upper().replace('0X','0x')+'", VA = "'+address.upper().replace('0X','0x')+'")]\nprivate '+ret+' '+callback_name(i)+'('+args+')\n{\n'+''.join('    '+s+'\n' for s in body.splitlines())+'}')
(WORK/'init-info-body.candidate.txt').write_text(init_body+'\n',encoding='utf-8')
(WORK/'callbacks.candidate.txt').write_text('\n\n'.join(callbacks)+'\n',encoding='utf-8')
(WORK/'load-request-map.json').write_text(json.dumps(records,ensure_ascii=False,indent=2),encoding='utf-8')
(WORK/'callback-ledger.json').write_text(json.dumps(callback_ledger,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps({'callbacks':len(callbacks),'loadRequests':len(records),'candidateInitLines':len(lines),'dictionaryCallbacks':sum(len(r['stores'])==2 for r in survey['callbacks']),'allOriginalPathsInSource':len(set(re.findall(r'Assets/_Res/[^"\n]+\.json',init_body)))},indent=2))
