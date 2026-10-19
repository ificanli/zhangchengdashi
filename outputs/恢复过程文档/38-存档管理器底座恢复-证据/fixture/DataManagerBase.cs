using System;

namespace GameFramework
{
	public abstract class DataManagerBase
	{
		internal bool _007C_007Ev_00A8G_00BB;
		internal bool _00B1_009C_00AB_007DRS;
		internal bool Rr_00A1_00B8f_008C;
		internal string s_00B0W_0099w_009C;
		private bool N_00A4P_0099_00AE_0091;
		public virtual string DataKey
		{
			get
			{
    return GetType().Name;
}
		}
		public abstract void OnInit();
		public abstract void OnSave();
		public abstract void OnRelease();
		private bool _008E_00B6F_00B6dB()
		{
			return default;
		}
		protected virtual void SaveLocalData(string _008C_00A8_00A1cf_00A6)
		{
#if UNITY_EDITOR
if (UnityEngine.Application.isEditor)
{
    if (_007C_007Ev_00A8G_00BB && DataManagerPool.CanSaveLocalData && (int)GameFramework.Login.ILoginProcedure.accountType >= 10)
        LocalEditorStore.Write(DataKey, _008C_00A8_00A1cf_00A6);
    return;
}
#endif
    throw new System.NotImplementedException("RECOVERY_UNIMPLEMENTED original DataManagerBase.SaveLocalData RVA=0x7171E48: native user/server storage dependencies remain unresolved; LocalEditorStore is Editor only.");
}
		private void T_00BD_007BLGZ(string _008C_00A8_00A1cf_00A6)
		{
#if UNITY_EDITOR
if (UnityEngine.Application.isEditor)
{
    if ((int)GameFramework.Login.ILoginProcedure.accountType >= 10 && DataManagerPool.CanSaveLocalData)
        LocalEditorStore.Write(DataKey, _008C_00A8_00A1cf_00A6);
    return;
}
#endif
    throw new System.NotImplementedException("RECOVERY_UNIMPLEMENTED original DataManagerBase local storage writer RVA=0x71722B8: native file service remains unresolved.");
}
		[Obsolete("请使用UpdataData方法更新数据，并在UpdateDataCallBack中解析收到的数据")]
		protected virtual string ReadLocalData()
		{
#if UNITY_EDITOR
if (UnityEngine.Application.isEditor) return LocalEditorStore.Read(DataKey);
#endif
    throw new System.NotImplementedException("RECOVERY_UNIMPLEMENTED original DataManagerBase.ReadLocalData RVA=0x717284C: native user/server storage dependencies remain unresolved; LocalEditorStore is Editor only.");
}
		public virtual void UpdataData(bool L_008AM_0060_005D_0080 = true)
		{
    if (L_008AM_0060_005D_0080 && DBTSDK.AppUserManager.Instance.IsUseServer && _00B1_009C_00AB_007DRS)
    {
        GameFramework.GameData.GameDataVersionMgr.Instance.Á_0090_0090_00B8_00B9_0086(DataKey);
        return;
    }

    UpdateDataCallBack(ReadLocalData());
}
		internal void _009Al_0084DD_0095(string _008C_00A8_00A1cf_00A6)
		{
    string str = _008C_00A8_00A1cf_00A6;
    if (Rr_00A1_00B8f_008C)
        str = Utils.DecompressData(DataKey, str);
    UpdateDataCallBack(str);
    if (DataManagerPool.CanSaveLocalData)
        T_00BD_007BLGZ(str);
}
		protected virtual void UpdateDataCallBack(string _008C_00A8_00A1cf_00A6)
		{
		}
		internal void _005Duv_0094_009F_009B(long _0081_007Dº_0093u_008D)
		{
    SynServerTime(_0081_007Dº_0093u_008D);
}
		protected virtual void SynServerTime(long _0081_007Dº_0093u_008D)
		{
		}
		protected DataManagerBase()
		{
    _007C_007Ev_00A8G_00BB = true;
    _00B1_009C_00AB_007DRS = true;
    s_00B0W_0099w_009C = string.Empty;
}

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
}	}
}
