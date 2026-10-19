from pathlib import Path
import hashlib
import json

WORK=Path(__file__).resolve().parent
ROOT=WORK.parents[1]
PROJECT=ROOT/'outputs/OccupyCityRecovered'
REL='Assets/Scripts/Assembly-CSharp/DataModule/DataManager.cs'
before=(WORK/'DataManager-before.cs').read_text(encoding='utf-8-sig')
gold=json.loads((WORK/'native-golden.json').read_text())
order=next(row['calls'] for row in gold if row['kind']=='LoadAllSaveData' and row['missingIndex']==-1)
assert len(order)==15 and len(set(order))==15

def replace_method(source,signature,body,new_signature=None):
    start=source.index(signature)
    opening=source.index('{',start)
    level=1
    ending=opening+1
    while level:
        if source[ending]=='{':level+=1
        elif source[ending]=='}':level-=1
        ending+=1
    return source[:start]+(new_signature or signature)+'\n\t\t{\n'+body+'\n\t\t}'+source[ending:]

bodies={
    'ChooseConflict':('\t\t\tComflictStatus = comflictStatus;\n\t\t\tSaveConflictCheckFinish = true;'),
    'LoadData':'''\t\t\twhile (!loadConfigComplete)
\t\t\t    await UniTask.WaitForSeconds(0.1f);
\t\t\tLoadDataCompleted = false;
\t\t\twhile (!SaveConflictCheckFinish)
\t\t\t    await UniTask.WaitForSeconds(0.1f);
\t\t\tLoadAllSaveData();
\t\t\tif (!DbtSaveDataManager_PlayerCoreData.I.Data.LoginSuccessfully)
\t\t\t{
\t\t\t    DbtSaveDataManager_PlayerCoreData.I.Data.LoginSuccessfully = true;
\t\t\t    DbtSaveDataManager_PlayerCoreData.I.Save();
\t\t\t}
\t\t\tLoadDataCompleted = true;''',
    'LoadAllSaveData':'\n'.join(f'\t\t\t{name}.I.CanSave = true;\n\t\t\t{name}.I.Load();' for name in order),
    'StopAllSave':'\n'.join(f'\t\t\t{name}.I.CanSave = false;' for name in order),
}
signatures={
    'ChooseConflict':'public void ChooseConflict(ComflictStatus comflictStatus)',
    'LoadData':'public UniTask LoadData()',
    'LoadAllSaveData':'private void LoadAllSaveData()',
    'StopAllSave':'public void StopAllSave()',
}
candidate=before
for name,signature in signatures.items():
    candidate=replace_method(candidate,signature,bodies[name],'public async UniTask LoadData()' if name=='LoadData' else None)
candidate=candidate.replace('\t\t[AsyncStateMachine(typeof(_003CLoadData_003Ed__16))]\n','')
target=WORK/'candidate'/REL
target.parent.mkdir(parents=True,exist_ok=True)
target.write_text(candidate,encoding='utf-8')
manifest=dict(stage=45,files=[dict(path=REL,beforeSha256=hashlib.sha256((WORK/'DataManager-before.cs').read_bytes()).hexdigest(),
    candidateSha256=hashlib.sha256(target.read_bytes()).hexdigest(),metaSha256=hashlib.sha256(Path(str(PROJECT/REL)+'.meta').read_bytes()).hexdigest())],
    methods=[dict(name=name,signature=signature) for name,signature in signatures.items()],nativeModelsInLoadOrder=order,
    preservedGates=['loadConfigComplete','SaveConflictCheckFinish'],
    originalFieldWrite='PlayerCoreData.LoginSuccessfully=true only after all actual Load calls; Save before LoadDataCompleted=true',
    notRestored=['SaveAllData','ClearAllData','conflict decision producer','concrete data defaults/init bodies'])
(WORK/'candidate-manifest.json').write_text(json.dumps(manifest,ensure_ascii=False,indent=2),encoding='utf-8')
print('Prepared four original methods; native ordered models:',len(order))
