import hashlib,json,re
from pathlib import Path
root=Path(__file__).resolve().parents[2];own=root/'work/gamemanager-recovery';source=root/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/GameModule/GameManager.cs'
text=source.read_text(encoding='utf-8-sig');old=text
text=text.replace('using System.Diagnostics;','using System.Diagnostics;\nusing System.Linq;\nusing BadgeGraph;\nusing DataModule;\nusing EventModule;\nusing SDKModule;\nusing QuickTutor;\nusing UIFramework;\nusing ljzs_lt;\nusing Debug = UnityEngine.Debug;')
text=text.replace('public UpdateController updateController;','public UpdateController updateController = new UpdateController();')
methods={
'Init':(own/'Init.body.txt').read_text(encoding='utf-8'),
'RegisterOnTimeToZero':(own/'RegisterOnTimeToZero.body.txt').read_text(encoding='utf-8'),
'RegisterOnTimeToMonDayZero':(own/'RegisterOnTimeToMonDayZero.body.txt').read_text(encoding='utf-8'),
'CheckNetworkState':(own/'CheckNetworkState.body.txt').read_text(encoding='utf-8'),
'StartCoreGame':(own/'StartCoreGame.body.txt').read_text(encoding='utf-8'),
'RegisterOnGameManagerInitComplete':'''{
    if (InitComplete)
        action?.Invoke();
    else
        onGameManagerInitComplete += action;
}''',
'Update':'''{
    if (InitComplete)
        updateController?.ToUpdate(Time.deltaTime);
}''',
'PauseGame':'''{
    if (BattleGameManager.Instance != null)
        BattleGameManager.Instance.SetGamePaused(true);
    if (AIBehaviourManager.Instance != null)
        AIBehaviourManager.Instance.SetGamePaused(true);
}''',
'ResumeGame':'''{
    if (BattleGameManager.Instance != null)
        BattleGameManager.Instance.SetGamePaused(false);
    if (AIBehaviourManager.Instance != null)
        AIBehaviourManager.Instance.SetGamePaused(false);
}''',
'EnterMeta':'''{
    if (TrainingGroundManager.IsInTrainingGround)
    {
        MetaGameManager.Instance.ShowMetaSwitchPanel(2);
        PanelPopHandleManager.Instance.PanelPopPlay();
    }
    else
    {
        switch (BattleGameManager.Instance.GameType)
        {
            case GameType.PVP:
                MetaGameManager.Instance.ShowMetaSwitchPanel(2);
                PanelPopHandleManager.Instance.PanelPopPlay();
                break;
            case GameType.PVE:
                MetaGameManager.Instance.ShowMetaSwitchPanel(3);
                break;
            case GameType.SeasonPVP:
                MetaGameManager.Instance.ShowMetaSwitchPanel(2);
                break;
            case GameType.SubGamePVP:
                MetaGameManager.Instance.ShowMetaSwitchPanel(2);
                PanelPopHandleManager.Instance.PanelPopPlay();
                if (SubGameChaosTrailsManager.Instance != null)
                    SubGameChaosTrailsManager.Instance.TryReturnToPanelAfterEnterMeta(obj as BattleResult);
                break;
        }
    }
}''',
'DanChangeUpdateInfo':'''{
    RankManager.Instance.UpdateRankInfo();
}''',
'ShowCardProbabilityPanel':'''{
    await UniTask.WaitForSeconds(0.05f);
    _ = UIManager.Instance.ShowPanel("Assets/_Res/Addressable/02CoreGameBundle/Prefabs/UI/Panels/HexDescribesPanel.prefab", Array.Empty<object>());
}''',
'ShowConfirmPanel':'''{
    _ = UIManager.Instance.ShowPanel("Assets/_Res/Addressable/Prefabs/UI/Panels/ConfirmPanel.prefab",
        new object[] { titleStr, contentStr, buttonTextStr, canCancelPanel, onClick });
}''',
'FetterSteerEnd':'''{
    if (ABTestManager.Instance.GameCenterIsBTest)
        GameCenterManager.Instance.AllowGameCenter().Forget();
}''',
'CloseLoadPanel':'''{
    closeLoadPanel = true;
    DBTSDK.SDKToolManager.Instance.ReportGameInteractive("");
    if (!_isFirstThroghGame)
        PacksTipManager.Instance.FirstPopPacks();
    DBT.StartupGift.StartupGiftSystem.CheckAndGrantGift();
}''',
'LoadEnd':'''{
    if (_isFirstThroghGame)
        EventManager.Instance.TriggerEvent("OnArenaUIBGItemStartBtnClicked", null);
}'''
}
for name,body in methods.items():
    match=re.search(r'\b(?:public|private)\s+(?:override\s+)?(?:[\w<>]+)\s+'+name+r'\([^\n]*\)\s*\{',text)
    assert match,name
    start=text.index('{',match.start());end=start+1;depth=1
    while depth:depth+=(text[end]=='{')-(text[end]=='}');end+=1
    previous=text[start:end];assert previous.strip() in {'{\n\t\t}', '{\n\t\t\treturn default;\n\t\t}', '{\n\t\t\treturn null;\n\t\t}'},(name,previous)
    body=body.rstrip();lines=body.splitlines();body='\n'.join(lines[:1]+['\t\t'+line for line in lines[1:]])
    text=text[:start]+body+text[end:]
text=text.replace('[AsyncStateMachine(typeof(_003CInit_003Ed__9))]\n\t\tpublic override UniTask Init()', 'public override async UniTask Init()')
text=text.replace('[AsyncStateMachine(typeof(_003CEnterMeta_003Ed__20))]\n\t\tprivate void EnterMeta(object obj)', 'private async void EnterMeta(object obj)')
text=text.replace('[AsyncStateMachine(typeof(_003CShowCardProbabilityPanel_003Ed__24))]\n\t\tprivate void ShowCardProbabilityPanel(object o)', 'private async void ShowCardProbabilityPanel(object o)')
text=text.replace('\t\t[IteratorStateMachine(typeof(_003CCheckNetworkState_003Ed__14))]\n','')
(own/'GameManager.candidate.cs').write_bytes(text.replace('\n','\r\n').encode('utf-8'))
(own/'candidate-provenance.json').write_text(json.dumps({'beforeSha256':hashlib.sha256(source.read_bytes()).hexdigest(),'metaSha256':hashlib.sha256(source.with_suffix('.cs.meta').read_bytes()).hexdigest(),'candidateMethods':list(methods),'fieldInitializer':'new UpdateController()'},indent=2),encoding='utf-8')
print('Prepared',len(methods),'native-backed methods and UpdateController initializer; production source unchanged')
