using System.Runtime.CompilerServices;
using GameFramework;
public class DbtSaveDataManagerBase<T, TD> : DataManagerBase where T : DbtSaveDataManagerBase<T, TD> where TD : ServerBaseData, new()
{
	public static T I;
	private string _name;
	private string _lastSaveData;
	public bool CanSave;
	private bool _cleared;
	public TD Data
	{
		[CompilerGenerated]
		get
;				[CompilerGenerated]
		private set
;	}
	public override void OnInit()
	{
    Log(0, "OnInit");
    I = this as T;
    _name = typeof(T).Name;
    _lastSaveData = ReadLocalData();
    UpdataData(false);
}
	public string ReLoadLocalData()
	{
    _lastSaveData = ReadLocalData();
    return _lastSaveData;
}
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
	public override void OnSave()
	{
    if (!_cleared)
        SaveLocalData(_lastSaveData);
}
	public override void OnRelease()
	{
	}
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
	public void LoadFormMemory(TD data)
	{
    Data = data;
    Data.Init();
}
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
	public void LogVersion()
	{
	}
	protected virtual void OnBeforeSerializeForSave()
	{
	}
	public void Clear()
	{
    if (!_cleared)
    {
        _cleared = true;
        Log(0, "Clear Save");
        SaveLocalData("");
    }
}
	private void Log(int type, string msg)
	{
    if (type == 0)
        CLog.Log(_name + "   " + msg);
    else if (type == 1)
        CLog.Warning(_name + "   " + msg);
    else if (type == 2)
        CLog.Error(_name + "   " + msg);
}
	public DbtSaveDataManagerBase()
	{
    _lastSaveData = "";
}
}
