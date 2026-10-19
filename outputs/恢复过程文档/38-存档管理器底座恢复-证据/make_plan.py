import json
from pathlib import Path
w=Path(__file__).parent
files=[]
def file(path,auto=[],helper=None,cls=None):
    row=dict(path=path,methods=[],autoProperties=auto)
    if helper:row.update(helperClassToken=cls,addHelper=helper)
    files.append(row);return row['methods']
def add(ms,token,body):ms.append(dict(token=token,body='{\n'+body+'\n}',makeAsync=False,iterator=False))
m=file('Assets/Scripts/Assembly-CSharp/DbtSaveDataManagerBase.cs',['0x1700001F'])
add(m,'0x6000267','''Log(0, "OnInit");
I = this as T;
_name = typeof(T).Name;
_lastSaveData = ReadLocalData();
UpdataData(false);''')
add(m,'0x6000268','''_lastSaveData = ReadLocalData();
return _lastSaveData;''')
add(m,'0x6000269','''Log(1, "UpdateDataCallBack:   " + str);
if (!string.IsNullOrEmpty(str) || L_Tools.LoginControl.I != null && L_Tools.LoginControl.I.IsProxyLogin)
{
    _lastSaveData = str;
}
else if (!string.IsNullOrEmpty(_lastSaveData) && !L_Tools.PlayerPrefs2RunTime.IsBindingAccount)
{
    Log(2, "本地有数据而服务器数据为空");
    var report = DBTSDK.ReportManager.Instance.GetNewReportJsonData<DBTSDK.NewReport.JsonProperties.activity_complete>(true, false);
    report.game_name = AppSetting.MineGameName;
    report.activity_name = "LTDataEmpty";
    report.activity_mode1 = "LTDataEmpty";
    DBTSDK.ReportManager.Instance.NewReport_activity_complete(report);
}''')
add(m,'0x600026A','if (!_cleared) SaveLocalData(_lastSaveData);')
add(m,'0x600026C','''if (Data == null)
{
    if (string.IsNullOrEmpty(_lastSaveData)) _lastSaveData = ReadLocalData();
    if (string.IsNullOrEmpty(_lastSaveData))
    {
        Data = new TD();
        Data.InitFromDefaults();
    }
    else
    {
        Data = Newtonsoft.Json.JsonConvert.DeserializeObject<TD>(L_Tools.DataCompressTools.GZipDecompressString(_lastSaveData));
    }
    Data.Init();
}''')
add(m,'0x600026D','''if (string.IsNullOrEmpty(str))
{
    TD data = new TD();
    data.InitFromDefaults();
    return data;
}
return Newtonsoft.Json.JsonConvert.DeserializeObject<TD>(L_Tools.DataCompressTools.GZipDecompressString(str));''')
add(m,'0x600026E','Data = data;\nData.Init();')
add(m,'0x600026F','''if (!_cleared && CanSave && LoadingModule.LoadingManager.EnterHome)
{
    OnBeforeSerializeForSave();
    string str = L_Tools.DataCompressTools.GZipCompressString(Newtonsoft.Json.JsonConvert.SerializeObject(Data));
    if (!string.IsNullOrEmpty(str))
    {
        _lastSaveData = str;
        SaveLocalData(str);
    }
}''')
add(m,'0x6000272','''if (!_cleared)
{
    _cleared = true;
    Log(0, "Clear Save");
    SaveLocalData("");
}''')
add(m,'0x6000273','''if (type == 0) CLog.Log(_name + "   " + msg);
else if (type == 1) CLog.Warning(_name + "   " + msg);
else if (type == 2) CLog.Error(_name + "   " + msg);''')
add(m,'0x6000274','_lastSaveData = "";')
helper='''// Explicit Editor platform adapter. It stores original compressed strings only under this recovery task's work folder.
private static class LocalEditorStore
{
    private static readonly string Root = System.IO.Path.GetFullPath(System.IO.Path.Combine(UnityEngine.Application.dataPath, "../../../work/occupycity-localeditor-store"));
    private static string PathFor(string key)
    {
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(key);
        using (var sha = System.Security.Cryptography.SHA256.Create())
        {
            string name = System.BitConverter.ToString(sha.ComputeHash(bytes)).Replace("-", "");
            return System.IO.Path.Combine(Root, name + ".save");
        }
    }
    internal static string Read(string key)
    {
        string path = PathFor(key);
        UnityEngine.Debug.Log("[Recovery] LocalEditorStore read: " + path + " key=" + key);
        return System.IO.File.Exists(path) ? System.IO.File.ReadAllText(path, System.Text.Encoding.UTF8) : string.Empty;
    }
    internal static void Write(string key, string value)
    {
        string path = PathFor(key);
        System.IO.Directory.CreateDirectory(Root);
        System.IO.File.WriteAllText(path, value, new System.Text.UTF8Encoding(false));
        UnityEngine.Debug.Log("[Recovery] LocalEditorStore write: " + path + " key=" + key);
    }
}
'''
m=file('Assets/Scripts/GFRunning/GameFramework/DataManagerBase.cs',helper=helper,cls='0x200035A')
add(m,'0x6005815','return GetType().Name;')
add(m,'0x600581A','''#if UNITY_EDITOR
if (UnityEngine.Application.isEditor)
{
    if (_007C_007Ev_00A8G_00BB && DataManagerPool.CanSaveLocalData && (int)GameFramework.Login.ILoginProcedure.accountType >= 10)
        LocalEditorStore.Write(DataKey, _008C_00A8_00A1cf_00A6);
    return;
}
#endif
throw new System.NotImplementedException("RECOVERY_UNIMPLEMENTED original DataManagerBase.SaveLocalData RVA=0x7171E48: native user/server storage dependencies remain unresolved; LocalEditorStore is Editor only.");''')
add(m,'0x600581C','''#if UNITY_EDITOR
if (UnityEngine.Application.isEditor) return LocalEditorStore.Read(DataKey);
#endif
throw new System.NotImplementedException("RECOVERY_UNIMPLEMENTED original DataManagerBase.ReadLocalData RVA=0x717284C: native user/server storage dependencies remain unresolved; LocalEditorStore is Editor only.");''')
add(m,'0x600581D','''if (L_008AM_0060_005D_0080 && DBTSDK.AppUserManager.Instance.IsUseServer && _00B1_009C_00AB_007DRS)
{
    GameFramework.GameData.GameDataVersionMgr.Instance.Á_0090_0090_00B8_00B9_0086(DataKey);
    return;
}
UpdateDataCallBack(ReadLocalData());''')
add(m,'0x600581E','''string str = _008C_00A8_00A1cf_00A6;
if (Rr_00A1_00B8f_008C) str = Utils.DecompressData(DataKey, str);
UpdateDataCallBack(str);
if (DataManagerPool.CanSaveLocalData) T_00BD_007BLGZ(str);''')
add(m,'0x600581B','''#if UNITY_EDITOR
if (UnityEngine.Application.isEditor)
{
    if ((int)GameFramework.Login.ILoginProcedure.accountType >= 10 && DataManagerPool.CanSaveLocalData)
        LocalEditorStore.Write(DataKey, _008C_00A8_00A1cf_00A6);
    return;
}
#endif
throw new System.NotImplementedException("RECOVERY_UNIMPLEMENTED original DataManagerBase local storage writer RVA=0x71722B8: native file service remains unresolved.");''')
add(m,'0x6005820','SynServerTime(_0081_007Dº_0093u_008D);')
add(m,'0x6005822','''_007C_007Ev_00A8G_00BB = true;
_00B1_009C_00AB_007DRS = true;
s_00B0W_0099w_009C = string.Empty;''')
m=file('Assets/Scripts/Assembly-CSharp/DataModule/PlayerTimeData.cs')
add(m,'0x60059C2','timeInfoDic = new Dictionary<string, TimeInfo>();')
gzip_cctor='''[Token(Token = "0x6005E0E")]
[Address(RVA = "0x43F9614", Offset = "0x43F5614", VA = "0x43F9614")]
static DataCompressTools() { _swapString = "1234567890"; _encryptKey = 90; }'''
m=file('Assets/Scripts/Assembly-CSharp/L_Tools/DataCompressTools.cs',helper=gzip_cctor,cls='0x2000FB1')
add(m,'0x6005E08','''if (string.IsNullOrEmpty(rawString)) return string.Empty;
byte[] data = System.Text.Encoding.UTF8.GetBytes(rawString);
for (int i = 0; i < data.Length; i++) data[i] ^= unchecked((byte)~_encryptKey);
return System.Convert.ToBase64String(data) + _swapString;''')
add(m,'0x6005E09','''if (string.IsNullOrEmpty(encryptedString)) return string.Empty;
if (!encryptedString.EndsWith(_swapString)) return encryptedString;
byte[] data = System.Convert.FromBase64String(encryptedString.Substring(0, encryptedString.Length - _swapString.Length));
for (int i = 0; i < data.Length; i++) data[i] ^= unchecked((byte)~_encryptKey);
return System.Text.Encoding.UTF8.GetString(data);''')
add(m,'0x6005E0A','''if (string.IsNullOrEmpty(rawString) || rawString.Length == 0) return string.Empty;
byte[] data = System.Text.Encoding.UTF8.GetBytes(rawString.ToString());
return EncryptString(System.Convert.ToBase64String(Compress(data)));''')
add(m,'0x6005E0B','''using (var stream = new System.IO.MemoryStream())
{
    using (var gzip = new System.IO.Compression.GZipStream(stream, System.IO.Compression.CompressionMode.Compress, true))
    {
        gzip.Write(rawData, 0, rawData.Length);
        gzip.Close();
    }
    return stream.ToArray();
}''')
add(m,'0x6005E0C','''if (string.IsNullOrEmpty(zippedString) || zippedString.Length == 0) return string.Empty;
byte[] data = System.Convert.FromBase64String(DecryptString(zippedString).ToString());
return System.Text.Encoding.UTF8.GetString(Decompress(data));''')
add(m,'0x6005E0D','''using (var input = new System.IO.MemoryStream(zippedData))
using (var gzip = new System.IO.Compression.GZipStream(input, System.IO.Compression.CompressionMode.Decompress))
using (var output = new System.IO.MemoryStream())
{
    byte[] buffer = new byte[32768];
    int count;
    while ((count = gzip.Read(buffer, 0, buffer.Length)) > 0) output.Write(buffer, 0, count);
    return output.ToArray();
}''')
pool_cctor='''[Token(Token = "0x600587E")]
[Address(RVA = "0x717B0B8", Offset = "0x71770B8", VA = "0x717B0B8")]
static DataManagerPool() { u_0080ÂF_008BÁ = false; CanSaveLocalData = true; }'''
m=file('Assets/Scripts/GFRunning/GameFramework/DataManagerPool.cs',helper=pool_cctor,cls='0x200035C')
add(m,'0x6005866','''if (_0060_0083_00A4_00A6_0095t == null) _0060_0083_00A4_00A6_0095t = new DataManagerPool();
return _0060_0083_00A4_00A6_0095t;''')
add(m,'0x600585D','E_00BDb_009C_00A3_0080 = true;')
add(m,'0x6005861','''u_0080ÂF_008BÁ = false;
_00A3_00A3_0094ÁD_0083 = new Dictionary<Type, DataManagerBase>();
i_00A6a_0099_007D_00A3 = new _00B3_0092_00BF_0080d_0084();
i_00A6a_0099_007D_00A3._007Dye_0080_00BCa();
if (E_00BDb_009C_00A3_0080) _00A3ºFe_0091p();
CLog._009Ay_0097Eo_007D("初始化DataManagerPool完成");''')
add(m,'0x600585B','''T model = SqR_0089Z_00AD;
Type type = model.GetType();
if (_00A3_00A3_0094ÁD_0083.ContainsKey(type))
{
    CLog.Error("已添加过数据管理器:" + model.ToString());
    return model;
}
var attr = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<ModelRegister>(type);
model._00B1_009C_00AB_007DRS = attr != null && attr.AutoSyn;
_00A3_00A3_0094ÁD_0083[type] = model;
if (J_0098SX_00AD_00A7) model.OnInit();
return model;''')
add(m,'0x6005860','''Type type = typeof(T);
if (_00A3_00A3_0094ÁD_0083 != null && _00A3_00A3_0094ÁD_0083.ContainsKey(type))
    return _00A3_00A3_0094ÁD_0083[type] as T;
CLog.Warning("未找到[" + type.FullName + "]数据管理器");
return null;''')
add(m,'0x6005864','''Type type = h_00B9_00B8_005E_00BDY;
if (type == null)
{
    object[] args = new object[1];
    args[1] = "Web file request timeout : ";
    CLog.Error(args);
    return null;
}
if (_00A3_00A3_0094ÁD_0083 != null && _00A3_00A3_0094ÁD_0083.ContainsKey(type))
    return _00A3_00A3_0094ÁD_0083[type];
object[] missingArgs = new object[1];
missingArgs[1] = "请检查商品配置表，商品配置表未包含GameKey" + type.FullName + "kewan is not support";
CLog.Error(missingArgs);
return null;''')
add(m,'0x6005869','return _00A3_00A3_0094ÁD_0083;')
add(m,'0x6005877','''Type[] types = Utility.AssemblyUtility.LoadCSharpAssembly().GetTypes();
foreach (Type type in types)
{
    if (!type.IsSubclassOf(typeof(DataManagerBase))) continue;
    var attr = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<ModelRegister>(type);
    if (attr == null || attr.GameName != AppSetting.MineGameName) continue;
    var model = (DataManagerBase)Activator.CreateInstance(type);
    model._00B1_009C_00AB_007DRS = attr.AutoSyn;
    model.Rr_00A1_00B8f_008C = attr.CompressData;
    model.OnInit();
    _00A3_00A3_0094ÁD_0083[type] = model;
}''')
m=file('Assets/Scripts/GFRunning/GameFramework/ModelRegister.cs')
add(m,'0x60057EB','''zjH_005B_00A8_00B1 = true;
_00A3_00BBC_005E_00ABY = _00A3_00A9h_007Fqn;
zjH_005B_00A8_00B1 = _00B7_005D_00A7u_007CJ;
_0060E_007FhjN = _00A5_008Eg_008Cu_009D;''')
add(m,'0x60057E4','return _00A3_00BBC_005E_00ABY;')
add(m,'0x60057D1','return zjH_005B_00A8_00B1;')
add(m,'0x60057F1','return _0060E_007FhjN;')
m=file('Assets/Scripts/GFRunning/----d-.cs')
add(m,'0x60070A8','''_0083UV_00A0_00A5_0091 = new List<_00A5_0091_007FQ_0080_00A6>();
DkwÂ_00A9Z = true;
Do_00AC_009Co_0093 = 3;
_0088_0080_00A3_0096_00B3c = 8192;
m_008B_008FX_008Fq = new List<_00B4bv_00B0C_00BE>();''')
add(m,'0x60070B1','''_0083UV_00A0_00A5_0091.Clear();
_0085_00A5ª_0081_00BDl = UpdateManager.AddHandle(_0090_00A2Y_00B2_00B4_0094);
GameFramework.MsgDispatcher.AddEventListener("GF_HttpServerErrorCode", Â_0080TU_00BEn);
GameFramework.MsgDispatcher.AddEventListener("GF_HttpWebRequestError", Y_00A9cR_0088B);
GameFramework.MsgDispatcher.AddEventListener("GF_HttpServerSuccess", _00A5dWfk_0081);
UnityEngine.Debug.LogWarning("[Recovery] Save backend registered its original Update/Msg callbacks; callback consumers and MsgDispatcher are unresolved. This does not confirm server storage readiness.");''')
utility_cctor='''[Token(Token = "0x600600A")]
[Address(RVA = "0x71E1E44", Offset = "0x71DDE44", VA = "0x71E1E44")]
static AssemblyUtility() { _00A2_0090qª_009Bº = new Dictionary<string, Assembly>(); }'''
m=file('Assets/Scripts/GFRunning/GameFramework/Utility.cs',helper=utility_cctor,cls='0x20003D7')
add(m,'0x6006008','''Assembly assembly;
if (!_00A2_0090qª_009Bº.TryGetValue(_008DtSh_005Dq, out assembly))
{
    assembly = Assembly.Load(_008DtSh_005Dq);
    if (assembly != null) _00A2_0090qª_009Bº.Add(_008DtSh_005Dq, assembly);
}
return assembly;''')
add(m,'0x6006009','''Assembly assembly = LoadAssembly("Assembly-CSharp");
if (assembly == null)
{
    UnityEngine.Debug.LogError("加载C#程序集错误");
    return null;
}
return assembly;''')
(w/'write-plan.json').write_text(json.dumps(dict(files=files),ensure_ascii=False,indent=2),encoding='utf-8')
print('Prepared',len(files),'owned files;',sum(len(f['methods']) for f in files),'body targets, 3 original cctors, 1 auto property, explicit Editor I/O and unresolved native storage diagnostics')
