import hashlib
import json
from pathlib import Path
ROOT=Path(__file__).resolve().parents[2]
OWN=ROOT/'work/stage40-ui'
BEFORE=OWN/'source-before/UIModule.cs'
text=BEFORE.read_text(encoding='utf-8-sig')
bodies={
'0x6005F47':'return 40;',
'0x6005F48':'''
if (x_0080_008D_00B1f_0086)
{
    Àª_00A6_00A3_00BDE?.Invoke();
    return;
}
CLog.ReleaseLog("开始加载UIModule");
canvas = GameObject.FindGameObjectWithTag("GFUICanvas");
if (canvas == null)
    UnityEngine.Debug.LogError("UIcanvas未找到");
GameObject cameraObject = canvas != null ? canvas.transform.Find("UICamera").gameObject : null;
if (cameraObject == null)
    UnityEngine.Debug.LogError("UI相机未找到");
UICamera = cameraObject?.GetComponent<Camera>();
UnityEngine.Object.DontDestroyOnLoad(canvas);
if (AppSetting.UseNewRes)
    NewResLoadHelper.LoadPrefabOri("UI/UIRoot", LoadUIRootOver<AssetOperationHandle>, Array.Empty<object>());
else
{
    GameFrameEntry.GetModule<ResourcesModule>().LoadPrefab("UI/UIRoot", LoadUIRootOver<ResourcesInfo>, null);
    GameFrameEntry.GetModule<ResourcesModule>().Update(0f, 0f);
}
''',
'0x6005F49':'''
UIRoot = resources.Instantiate("UIRoot", true).GetComponent<RectTransform>();
UIRoot.transform.SetParent(canvas.transform);
UIRoot.localScale = Vector3.one;
UIRoot.anchorMin = Vector2.zero;
UIRoot.anchorMax = Vector2.one;
UIRoot.offsetMin = Vector2.zero;
UIRoot.offsetMax = Vector2.zero;
if (AppSetting.IsPortrait && canvas.GetComponent<UnityEngine.UI.CanvasScaler>().matchWidthOrHeight == 1f && AppSetting.isHeightCtrWidthFixedWidth)
{
    float width = canvas.GetComponent<RectTransform>().sizeDelta.x;
    if (width > 720f)
    {
        float margin = (width - 720f) * 0.5f;
        UIRoot.offsetMax = new Vector2(-margin, 0f);
        UIRoot.offsetMin = new Vector2(margin, 0f);
    }
}
x_0080_008D_00B1f_0086 = true;
Àª_00A6_00A3_00BDE?.Invoke();
''',
'0x6005F50':'return new _003Cwait2Fram_003Ed__19(0) { action = action };',
'0x6005F51':'''
Transform result;
if (!_uiNodeList.TryGetValue(node, out result))
{
    result = UIRoot.transform.Find(node);
    if (result == null)
    {
        CLog.Error("UI节点未找到：" + node);
        result = canvas.transform;
    }
    _uiNodeList.Add(node, result);
}
return result;
''',
'0x6005F73':'this._003C_003E1__state = _003C_003E1__state;',
'0x6005F75':'''
if (_003C_003E1__state == 0)
{
    _003C_003E2__current = null;
    _003C_003E1__state = 1;
    return true;
}
if (_003C_003E1__state == 1)
{
    _003C_003E2__current = null;
    _003C_003E1__state = 2;
    return true;
}
if (_003C_003E1__state == 2)
{
    _003C_003E1__state = -1;
    action?.Invoke();
}
return false;
''',
'0x6005F76':'return _003C_003E2__current;',
'0x6005F77':'throw new NotSupportedException();',
'0x6005F78':'return _003C_003E2__current;',
}
for token,body in bodies.items():
    pos=text.index('[Token(Token = "'+token+'")]')
    begin=text.index('{',pos);depth=1;end=begin+1
    while depth:
        if text[end]=='{':depth+=1
        elif text[end]=='}':depth-=1
        end+=1
    indent='\t\t\t' if token in {'0x6005F73','0x6005F75','0x6005F77'} else '\t\t\t\t' if token in {'0x6005F47','0x6005F76','0x6005F78'} else '\t\t'
    block='{\n'+'\n'.join(indent+'\t'+line if line else '' for line in body.strip().splitlines())+'\n'+indent+'}'
    text=text[:begin]+block+text[end:]
initializers={
 'private Dictionary<string, Transform> _uiNodeList;':'private Dictionary<string, Transform> _uiNodeList = new Dictionary<string, Transform>();',
 'private WaitForEndOfFrame wait;':'private WaitForEndOfFrame wait = new WaitForEndOfFrame();',
 'private WaitForSeconds waitAnim5;':'private WaitForSeconds waitAnim5 = new WaitForSeconds(0.5f);',
 'private WaitForSeconds waitAnim3;':'private WaitForSeconds waitAnim3 = new WaitForSeconds(0.3f);',
 'private Dictionary<string, BaseUI> _uiList;':'private Dictionary<string, BaseUI> _uiList = new Dictionary<string, BaseUI>();',
}
for old,new in initializers.items():
    assert old in text
    text=text.replace(old,new)
# Take the node-error string from original metadata instead of guessing its punctuation.
mapping=json.loads((ROOT/'work/il2cpp-dump-decoded/script.json').read_text(encoding='utf-8-sig'))
strings={row['Address']:row['Value'] for row in mapping['ScriptString']}
text=text.replace('"UI节点未找到："',json.dumps(strings[0x8D877F0],ensure_ascii=True))
metadata=json.loads((OWN/'original-metadata.json').read_text(encoding='utf-8'))
cctor=next(m for t in metadata if t['type']=='GameFramework.UIModule' for m in t['methods'] if m['Name']=='.cctor')
assert cctor['token']=='0x06005F64' and cctor['address']=='0x71D8EA4'
block='''
		[Token(Token = "0x6005F64")]
		[Address(RVA = "0x71D8EA4", Offset = "0x71D4EA4", VA = "0x71D8EA4")]
		static UIModule()
		{
			UIScaleInTime = 0.5f;
			UIFadeOutTime = 0.3f;
			UIScaleOutTime = 0.2f;
			openUIStack = new List<BaseUI>();
		}
'''
pos=text.rfind('\n\t}')
text=text[:pos]+block+text[pos:]
(OWN/'UIModule.candidate.cs').write_text(text,encoding='utf-8')
(OWN/'candidate-provenance.json').write_text(json.dumps(dict(methodTokens=list(bodies),restoredConstructorToken='0x6005F63',staticConstructorToken='0x6005F64',fieldInitializers=initializers,sourceBeforeSha256=hashlib.sha256(BEFORE.read_bytes()).hexdigest(),candidateSha256=hashlib.sha256((OWN/'UIModule.candidate.cs').read_bytes()).hexdigest()),ensure_ascii=False,indent=2),encoding='utf-8')
print('candidate methods',len(bodies)+2,'field initializers',len(initializers))
