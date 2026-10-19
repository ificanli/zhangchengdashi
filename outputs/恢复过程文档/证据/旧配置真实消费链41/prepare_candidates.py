from pathlib import Path
import re,json,hashlib,shutil
ROOT=Path(r'C:\Users\luxinyu\Documents\Codex\2026-10-19\x20'); W=ROOT/'work/parallel-41-config';P=ROOT/'outputs/OccupyCityRecovered'
paths={'mgr':'Assets/Scripts/Assembly-CSharp/ljzs_lt/ConfigMgr.cs','read':'Assets/Scripts/GFRunning/GameFramework/ConfigRead.cs','base':'Assets/Scripts/GFRunning/GameFramework/BaseConfig.cs'}
bodies={key:{} for key in paths}
def body(key,token,text):bodies[key][token]=text.strip()
def span(text,token):
 pos=text.index('[Token(Token = "'+token+'")');a=text.index('{',pos);b=a+1;depth=1
 while depth:
  depth+=(text[b]=='{')-(text[b]=='}');b+=1
 return a,b
def replace(text,token,value):
 a,b=span(text,token);return text[:a]+'{\n'+''.join('\t\t\t'+line+'\n' for line in value.splitlines())+'\t\t}'+text[b:]
original=(W/'source-before'/paths['mgr']).read_text(encoding='utf-8-sig')
dictionaries=re.findall(r'public readonly (Dictionary<[^;]+>) (\w+);',original)
tables=re.findall(r'public readonly Dictionary<object, (\w+)> (\w+);',original)
body('mgr','0x6005AEA','if (_instance == null)\n    _instance = new ConfigMgr();\nreturn _instance;')
body('mgr','0x6005AE7','''GameFramework.ConfigRead.IsUserJsonUtility = true;
GameFramework.AppSetting.IsUseMemoryPack = false;
if (!IsInitialize)
{
    ReadConfig();
    customRead();
    IsInitialize = true;
}''')
body('mgr','0x6005AE8','\n'.join('GameFramework.ConfigRead.readConfigByUnityJson<'+t+'>('+n+');' for t,n in tables)+'''\nsettingConfig = GameFramework.ConfigRead.readConfigVByUnityJson<SettingConfig>();
worldCupbaseConfigConfig = GameFramework.ConfigRead.readConfigVByUnityJson<WorldCupbaseConfigConfig>();
baseConfigConfig = GameFramework.ConfigRead.readConfigVByUnityJson<BaseConfigConfig>();''')
body('mgr','0x6005AE9','GameFramework.ConfigRead.configRes = resourcesInfo;')
body('mgr','0x6005AEB','''dicPoolConfigByPoolId.Clear();
foreach (KeyValuePair<object, PoolConfigConfig> pair in dicPoolConfig)
{
    PoolConfigConfig value = pair.Value;
    if (value == null || value.pool_id < 1)
        continue;
    List<PoolConfigConfig> list;
    if (!dicPoolConfigByPoolId.TryGetValue(value.pool_id, out list))
    {
        list = new List<PoolConfigConfig>();
        dicPoolConfigByPoolId.Add(value.pool_id, list);
    }
    list.Add(value);
}''')
body('mgr','0x6005AED','\n'.join(n+' = new '+t+'();' for t,n in dictionaries))
body('read','0x6005731','''string configName = typeof(T).Name;
TextAsset asset = _0083_0098it_007EW(configName);
if (asset != null)
{
    string text = asset.text;
    return JsonUtility.FromJson<T>(text.Substring(text.IndexOf("{")));
}
CLog.Error("配置文件不存在" + configName);
return null;''')
body('read','0x6005735','''List<T> list = _0060_007Fit_008Bg<T>(_00AD_0092zG_00ABd);
if (list != null)
{
    for (int i = 0; i < list.Count; i++)
    {
        if (_0081C_0082m_00A4G.ContainsKey(list[i].UniqueID))
            CLog.Error(string.Format("表[{0}]中有相同键({1})", _0093_00B8_0082eyc, list[i].UniqueID));
        else
            _0081C_0082m_00A4G.Add(list[i].UniqueID, list[i]);
    }
}''')
body('read','0x6005737','''if (_0094wxV_00B9N != null)
{
    switch (_009CqHÁ_009Bn)
    {
        case ConfigType.LitJson:
            _00B9_0087_00A9_00BF_0097_00BF(_0094wxV_00B9N.text, _0081C_0082m_00A4G, _0093_00B8_0082eyc);
            return;
        case ConfigType.UnityJson:
            _0060_007Fit_008Bg(_0094wxV_00B9N.text, _0081C_0082m_00A4G, _0093_00B8_0082eyc);
            return;
        case ConfigType.MemoryPack:
            _00A3_00B1f_008AI_00BF(_0094wxV_00B9N.bytes, _0081C_0082m_00A4G, _0093_00B8_0082eyc);
            return;
        default:
            CLog.Error("ConfigType error" + _009CqHÁ_009Bn.ToString());
            return;
    }
}
CLog.Error("配置文件不存在" + _0093_00B8_0082eyc);''')
body('read','0x6005750','''return JsonUtility.FromJson<UnSerialization<T>>(_00AD_0092zG_00ABd.Substring(_00AD_0092zG_00ABd.IndexOf("{"))).Datas;''')
body('read','0x600575E','''if (configRes == null && !AppSetting.UseNewRes)
    CLog.Error("ResourcesInfo为NULL");
if (isUseNewRes)
{
    if (_0092_0096uWU_008B)
    {
        if (newResLoadForWebgl == null)
            CLog.Error("allAssetsOperationHandle  == null");
        return GetConfigDataForNewResWebgl(_0093_00B8_0082eyc) as TextAsset;
    }
    AssetOperationHandle handle = NewResLoadHelper.LoadAssetSync<TextAsset>(_0093_00B8_0082eyc);
    TextAsset asset = (TextAsset)handle.mainObject;
    handle.Release();
    return asset;
}
return configRes.LoadAsset<TextAsset>(null, _0093_00B8_0082eyc);''')
body('read','0x600575F','''string configName = typeof(T).Name;
TextAsset asset = _0083_0098it_007EW(configName);
A_0086_00A3_00B8_00BDi(_0081C_0082m_00A4G, asset, configName, ConfigType.UnityJson);
n_00B9XZd_009C++;''')
body('read','0x6005734','''UnityEngine.Object asset;
if (newResLoadForWebgl == null)
    CLog.Error("newResLoadForWebgl is null, unable to get config object. Requested configName=" + _0093_00B8_0082eyc);
else if (newResLoadForWebgl.TryGetValue(_0093_00B8_0082eyc, out asset))
    return asset;
else
    CLog.Error("GetConfig Object Failed ObjName=" + _0093_00B8_0082eyc);
return null;''')
body('base','0x600571D','throw new NotImplementedException();')
results=[]
for key,rel in paths.items():
 before=W/'source-before'/rel;text=before.read_text(encoding='utf-8-sig')
 for token,value in bodies[key].items():text=replace(text,token,value)
 if key=='read':
  cctor='''
        [Token(Token = "0x6005765")]
        [Address(RVA = "0x716C144", Offset = "0x7168144", VA = "0x716C144")]
        static ConfigRead()
        {
            IsUserJsonUtility = false;
            isUseNewRes = AppSetting.UseNewRes;
            n_00B9XZd_009C = 0;
            uGÀ_009AV_00A1 = 0;
            configAssetbundle = "Data/Config/".TrimEnd('/');
            _0092_0096uWU_008B = false;
        }
'''
  text=text[:text.rfind('\n\t}')]+cctor+text[text.rfind('\n\t}'):]
 dst=W/'candidate'/rel;dst.parent.mkdir(parents=True,exist_ok=True);dst.write_text(text,encoding='utf-8')
 results.append({'path':rel,'sourceBeforeSha256':hashlib.sha256(before.read_bytes()).hexdigest(),'candidateSha256':hashlib.sha256(dst.read_bytes()).hexdigest(),'restoredTokens':list(bodies[key])+(['0x6005765'] if key=='read' else []),'retainedOriginalEmptyMethods': ['0x6005AEC'] if key=='mgr' else [],'metaSha256':hashlib.sha256((P/rel).with_suffix('.cs.meta').read_bytes()).hexdigest()})
(W/'write-plan.json').write_text(json.dumps({'stage':41,'files':results},ensure_ascii=False,indent=2),encoding='utf-8')
(W/'bodies.json').write_text(json.dumps(bodies,ensure_ascii=False,indent=2),encoding='utf-8')
print(json.dumps(results,ensure_ascii=False,indent=2))
