using System.Runtime.CompilerServices;
using Beebyte.Obfuscator;
using GameFramework;
using Il2CppDummyDll;

[Token(Token = "0x2000073")]
[Skip]
public class DbtSaveDataManagerBase<T, TD> : DataManagerBase where T : DbtSaveDataManagerBase<T, TD> where TD : ServerBaseData, new()
{
	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x0")]
	public static T I;

	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x0")]
	private string _name;

	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x0")]
	private string _lastSaveData;

	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x0")]
	public bool CanSave;

	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x0")]
	private bool _cleared;

	[Token(Token = "0x1700001F")]
	public TD Data
	{
		[Token(Token = "0x6000265")]
		[CompilerGenerated]
		get
;		[Token(Token = "0x6000266")]
		[CompilerGenerated]
		private set
;	}

	[Token(Token = "0x6000267")]
	public override void OnInit()
	{
    Log(0, "OnInit");
    I = this as T;
    _name = typeof(T).Name;
    _lastSaveData = ReadLocalData();
    UpdataData(false);
}

	[Token(Token = "0x6000268")]
	public string ReLoadLocalData()
	{
    _lastSaveData = ReadLocalData();
    return _lastSaveData;
}

	[Token(Token = "0x6000269")]
	protected override void UpdateDataCallBack(string str)
	{
    Log(1, "UpdateDataCallBack:   " + str);
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
    }
}

	[Token(Token = "0x600026A")]
	public override void OnSave()
	{
    if (!_cleared)
        SaveLocalData(_lastSaveData);
}

	[Token(Token = "0x600026B")]
	public override void OnRelease()
	{
	}

	[Token(Token = "0x600026C")]
	public void Load()
	{
    if (Data == null)
    {
        if (string.IsNullOrEmpty(_lastSaveData))
            _lastSaveData = ReadLocalData();
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
    }
}

	[Token(Token = "0x600026D")]
	public TD GetData(string str)
	{
    if (string.IsNullOrEmpty(str))
    {
        TD data = new TD();
        data.InitFromDefaults();
        return data;
    }

    return Newtonsoft.Json.JsonConvert.DeserializeObject<TD>(L_Tools.DataCompressTools.GZipDecompressString(str));
}

	[Token(Token = "0x600026E")]
	public void LoadFormMemory(TD data)
	{
    Data = data;
    Data.Init();
}

	[Token(Token = "0x600026F")]
	public void Save()
	{
    if (!_cleared && CanSave && LoadingModule.LoadingManager.EnterHome)
    {
        OnBeforeSerializeForSave();
        string str = L_Tools.DataCompressTools.GZipCompressString(Newtonsoft.Json.JsonConvert.SerializeObject(Data));
        if (!string.IsNullOrEmpty(str))
        {
            _lastSaveData = str;
            SaveLocalData(str);
        }
    }
}

	[Token(Token = "0x6000270")]
	public void LogVersion()
	{
	}

	[Token(Token = "0x6000271")]
	protected virtual void OnBeforeSerializeForSave()
	{
	}

	[Token(Token = "0x6000272")]
	public void Clear()
	{
    if (!_cleared)
    {
        _cleared = true;
        Log(0, "Clear Save");
        SaveLocalData("");
    }
}

	[Token(Token = "0x6000273")]
	private void Log(int type, string msg)
	{
    if (type == 0)
        CLog.Log(_name + "   " + msg);
    else if (type == 1)
        CLog.Warning(_name + "   " + msg);
    else if (type == 2)
        CLog.Error(_name + "   " + msg);
}

	[Token(Token = "0x6000274")]
	public DbtSaveDataManagerBase()
	{
    _lastSaveData = "";
}
}
