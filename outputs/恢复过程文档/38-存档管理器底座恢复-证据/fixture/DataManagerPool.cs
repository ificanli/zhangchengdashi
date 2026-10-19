using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameFramework.GameData;

namespace GameFramework
{
	public class DataManagerPool
	{
		private Dictionary<Type, DataManagerBase> _00A3_00A3_0094ÁD_0083;
		private static DataManagerPool _0060_0083_00A4_00A6_0095t;
		private _00B3_0092_00BF_0080d_0084 i_00A6a_0099_007D_00A3;
		internal bool E_00BDb_009C_00A3_0080;
		internal static bool u_0080ÂF_008BÁ;
		public static bool CanSaveLocalData;
		public static DataManagerPool Instance
		{
			get
			{
    if (_0060_0083_00A4_00A6_0095t == null)
        _0060_0083_00A4_00A6_0095t = new DataManagerPool();
    return _0060_0083_00A4_00A6_0095t;
}
		}
		internal Dictionary<Type, DataManagerBase> Fh_0090kE_0091
		{
			get
			{
    return _00A3_00A3_0094ÁD_0083;
}
		}
		public T AddModel<T>(T SqR_0089Z_00AD, bool J_0098SX_00AD_00A7 = true) where T : DataManagerBase
		{
    T model = SqR_0089Z_00AD;
    Type type = model.GetType();
    if (_00A3_00A3_0094ÁD_0083.ContainsKey(type))
    {
        CLog.Error("已添加过数据管理器:" + model.ToString());
        return model;
    }

    var attr = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<ModelRegister>(type);
    model._00B1_009C_00AB_007DRS = attr != null && attr.AutoSyn;
    _00A3_00A3_0094ÁD_0083[type] = model;
    if (J_0098SX_00AD_00A7)
        model.OnInit();
    return model;
}
		public DataManagerPool()
		{
    E_00BDb_009C_00A3_0080 = true;
}
		public T GetModel<T>() where T : DataManagerBase
		{
    Type type = typeof(T);
    if (_00A3_00A3_0094ÁD_0083 != null && _00A3_00A3_0094ÁD_0083.ContainsKey(type))
        return _00A3_00A3_0094ÁD_0083[type] as T;
    CLog.Warning("未找到[" + type.FullName + "]数据管理器");
    return null;
}
		public void OnInit()
		{
    u_0080ÂF_008BÁ = false;
    _00A3_00A3_0094ÁD_0083 = new Dictionary<Type, DataManagerBase>();
    i_00A6a_0099_007D_00A3 = new _00B3_0092_00BF_0080d_0084();
    i_00A6a_0099_007D_00A3._007Dye_0080_00BCa();
    if (E_00BDb_009C_00A3_0080)
        _00A3ºFe_0091p();
    CLog._009Ay_0097Eo_007D("初始化DataManagerPool完成");
}
		public DataManagerBase d_0088_00A0_0089_00B3v(Type h_00B9_00B8_005E_00BDY)
		{
    Type type = h_00B9_00B8_005E_00BDY;
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
    return null;
}
		internal Dictionary<Type, DataManagerBase> _0092Hz_0085_009D_00B9()
		{
    return _00A3_00A3_0094ÁD_0083;
}
		private void _00A3ºFe_0091p()
		{
    Type[] types = Utility.AssemblyUtility.LoadCSharpAssembly().GetTypes();
    foreach (Type type in types)
    {
        if (!type.IsSubclassOf(typeof(DataManagerBase)))
            continue;
        var attr = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<ModelRegister>(type);
        if (attr == null || attr.GameName != AppSetting.MineGameName)
            continue;
        var model = (DataManagerBase)Activator.CreateInstance(type);
        model._00B1_009C_00AB_007DRS = attr.AutoSyn;
        model.Rr_00A1_00B8f_008C = attr.CompressData;
        model.OnInit();
        _00A3_00A3_0094ÁD_0083[type] = model;
    }
}
static DataManagerPool()
{
    u_0080ÂF_008BÁ = false;
    CanSaveLocalData = true;
}	}
}
