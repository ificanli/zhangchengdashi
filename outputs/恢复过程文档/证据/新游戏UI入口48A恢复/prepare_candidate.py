import hashlib
import json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2];OWN=ROOT/'work/stage48-new-ui';SOURCE=ROOT/'outputs/OccupyCityRecovered/Assets/Scripts/Assembly-CSharp/UIFramework/UIManager.cs'
old=(OWN/'source-before/UIManager.cs').read_text(encoding='utf-8-sig')
bodies={
'0x6004C57':'''
_uiPanelsDict = new Dictionary<string, UIPanel>();
_panelsParent = new GameObject("UIPanelsRoot").transform;
initcomplete = true;
''',
'0x6004C58':'''
if (_uiPanelsDict.ContainsKey(panelPath))
    return _uiPanelsDict[panelPath];
return await LoadPanel(panelPath);
''',
'0x6004C5C':'''
GameObject prefab = await AssetsModule.AssetsManager.Instance.LoadAssetAsync<GameObject>(panelPath);
if (_uiPanelsDict.TryGetValue(panelPath, out UIPanel cachedPanel))
    return cachedPanel;
if (prefab)
{
    UIPanel panel = UnityEngine.Object.Instantiate(prefab, _panelsParent).GetComponent<UIPanel>();
    if (panel)
    {
        panel.name = panel.name.Replace("(Clone)", string.Empty);
        panel.gameObject.SetActive(false);
        _uiPanelsDict.Add(panelPath, panel);
        if (panel.transform.TryGetComponent(out Canvas canvas))
        {
            canvas.renderMode = RenderMode.ScreenSpaceCamera;
            canvas.worldCamera = CameraModule.CameraManager.Instance.UICamera;
            DataModule.PanelConfig config = DataModule.DataManager.Instance.GlobalInfo.panelConfigs.Find(item => item.panelName == panel.name);
            if (config != null)
                canvas.sortingOrder = config.layer;
            else
                UnityEngine.Debug.LogError("这个页面没有在PanelConfig表中配置，必须要配置=>" + panelPath);
            panel.Init(config);
        }
    }
    else
        UnityEngine.Debug.LogError("UIManager.GetPanel()==>  " + panelPath + "预制体上,没有挂载对应的Panel脚本");
    return panel;
}
return null;
''',
}
text=old
for token,body in bodies.items():
    pos=text.index('[Token(Token = "'+token+'")]');begin=text.index('{',pos);end=begin+1;depth=1
    while depth:
        if text[end]=='{':depth+=1
        elif text[end]=='}':depth-=1
        end+=1
    text=text[:begin]+'{\n'+'\n'.join('\t\t\t'+line if line else''for line in body.strip().splitlines())+'\n\t\t}'+text[end:]
text=text.replace('public override UniTask Init()','public override async UniTask Init()').replace('public UniTask<UIPanel> GetPanel(string panelPath)','public async UniTask<UIPanel> GetPanel(string panelPath)').replace('private Task<UIPanel> LoadPanel(string panelPath)','private async Task<UIPanel> LoadPanel(string panelPath)')
for name in ['Init','GetPanel','LoadPanel']:
    text=text.replace('\t\t[AsyncStateMachine(typeof(_003C'+name+'_003Ed__'+{'Init':'6','GetPanel':'7','LoadPanel':'11'}[name]+'))]\n','')
# Exact original strings are taken from metadata; preserve original punctuation and spacing.
mapping=json.loads((ROOT/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'));strings={r['Address']:r['Value']for r in mapping['ScriptString']}
for address,approx in [(0x8D891A0,'这个页面没有在PanelConfig表中配置，必须要配置=>'),(0x8D74850,'UIManager.GetPanel()==>  '),(0x8D89428,'预制体上,没有挂载对应的Panel脚本')]:
    text=text.replace(json.dumps(approx,ensure_ascii=False),json.dumps(strings[address],ensure_ascii=True))
(OWN/'UIManager.candidate.cs').write_text(text,encoding='utf-8')
result=dict(status='work-candidate-only-not-applied',sourceSha256=hashlib.sha256(SOURCE.read_bytes()).hexdigest(),beforeSha256=hashlib.sha256((OWN/'source-before/UIManager.cs').read_bytes()).hexdigest(),candidateSha256=hashlib.sha256((OWN/'UIManager.candidate.cs').read_bytes()).hexdigest(),methodTokens=list(bodies),additionalNecessaryLeaf='UIFramework.UIPanel.Init(PanelConfig), Token 0x06004C4C/RVA 0x4275658: original field store; remains unchanged awaiting root scope',productionSourceEdits=0,knownRemainingCameraDependency='CameraModule.CameraManager.UICamera currently returns null; source owned by no stage48 implementation yet')
assert result['sourceSha256']==result['beforeSha256']
(OWN/'candidate-provenance.json').write_text(json.dumps(result,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps(result,ensure_ascii=True,indent=2))
