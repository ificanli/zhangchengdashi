using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using GameFramework.Resources;
using Il2CppDummyDll;
using UnityEngine;
using YooAsset;

namespace GameFramework
{
	[Token(Token = "0x2000348")]
	public class ConfigRead
	{
		[Token(Token = "0x200034A")]
		private sealed class _00BFSM_00A7yV<T> where T : BaseConfig
		{
			[Token(Token = "0x40019CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<object, T> source;

			[Token(Token = "0x40019D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string custConfigPath;

			[Token(Token = "0x6005777")]
			public _00BFSM_00A7yV()
			{
			}

			[Token(Token = "0x6005778")]
			internal void ai_005DFI_00B4(AssetOperationHandle assetOperationHandle)
			{
			}
		}

		[Token(Token = "0x200034B")]
		private sealed class kPN_008D_00A0_008F<T> where T : BaseConfig
		{
			[Token(Token = "0x40019D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<object, T> source;

			[Token(Token = "0x40019D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string custConfigPath;

			[Token(Token = "0x6005779")]
			public kPN_008D_00A0_008F()
			{
			}

			[Token(Token = "0x600577A")]
			internal void _00A3dSzy_00BB(AssetOperationHandle assetOperationHandle)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200034C")]
		private struct _0091_008AslS_00B9<T> : IAsyncStateMachine where T : BaseConfig
		{
			[Token(Token = "0x40019D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40019D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40019D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ConfigType configType;

			[Token(Token = "0x40019D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string custConfigPath;

			[Token(Token = "0x40019D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<object, T> source;

			[Token(Token = "0x40019D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x600577B")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600577C")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200034D")]
		private struct _005B_00B3Iz_0081_008B<T> : IAsyncStateMachine where T : BaseConfig
		{
			[Token(Token = "0x40019D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40019DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40019DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string custConfigPath;

			[Token(Token = "0x40019DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<object, T> source;

			[Token(Token = "0x40019DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x600577D")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600577E")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200034E")]
		private struct f_005E_0089_00ADmX<T> : IAsyncStateMachine where T : BaseConfig
		{
			[Token(Token = "0x40019DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40019DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40019E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string custConfigPath;

			[Token(Token = "0x40019E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Dictionary<object, T> source;

			[Token(Token = "0x40019E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TaskAwaiter<AssetOperationHandle> _003C_003Eu__1;

			[Token(Token = "0x600577F")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005780")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200034F")]
		private struct B_00A9_00A6_00B2_00BED : IAsyncStateMachine
		{
			[Token(Token = "0x40019E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40019E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40019E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private object _003C_003Eu__1;

			[Token(Token = "0x6005781")]
			[Address(RVA = "0x716CFA0", Offset = "0x7168FA0", VA = "0x716CFA0", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6005782")]
			[Address(RVA = "0x716D28C", Offset = "0x716928C", VA = "0x716D28C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40019C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool IsUserJsonUtility;

		[Token(Token = "0x40019C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static AssetOperationHandle configRes_yo;

		[Token(Token = "0x40019C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static ResourcesInfo configRes;

		[Token(Token = "0x40019C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Dictionary<string, UnityEngine.Object> newResLoadForWebgl;

		[Token(Token = "0x40019C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool isUseNewRes;

		[Token(Token = "0x40019C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static int n_00B9XZd_009C;

		[Token(Token = "0x40019C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static int uGÀ_009AV_00A1;

		[Token(Token = "0x40019CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string configAssetbundle;

		[Token(Token = "0x40019CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static bool _0092_0096uWU_008B;

		[Token(Token = "0x40019CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static AllAssetsOperationHandle _0089_008E_0060_00B1_00B3_00B9;

		[Token(Token = "0x600572F")]
		[Address(RVA = "0x71662BC", Offset = "0x71622BC", VA = "0x71662BC")]
		private static TextAsset C_00A5Z_0092us(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x6005730")]
		[Address(RVA = "0x716682C", Offset = "0x716282C", VA = "0x716682C")]
		public static void ke_0096_00BCB_005D(AllAssetsOperationHandle Fp_007C_0084U_00BD)
		{
		}

		[Token(Token = "0x6005731")]
		public static T readConfigVByUnityJson<T>() where T : BaseConfig
		{
			string configName = typeof(T).Name;
			TextAsset asset = _0083_0098it_007EW(configName);
			if (asset != null)
			{
			    string text = asset.text;
			    return JsonUtility.FromJson<T>(text.Substring(text.IndexOf("{")));
			}
			CLog.Error("配置文件不存在" + configName);
			return null;
		}

		[Token(Token = "0x6005732")]
		[Address(RVA = "0x7166A84", Offset = "0x7162A84", VA = "0x7166A84")]
		public static void _00BB_007EJJpK(AllAssetsOperationHandle Fp_007C_0084U_00BD)
		{
		}

		[Token(Token = "0x6005733")]
		[Address(RVA = "0x7166CC4", Offset = "0x7162CC4", VA = "0x7166CC4")]
		public static void _00B9_00A3t_00A4_0098_007F(AllAssetsOperationHandle Fp_007C_0084U_00BD)
		{
		}

		[Token(Token = "0x6005734")]
		[Address(RVA = "0x7166F08", Offset = "0x7162F08", VA = "0x7166F08")]
		public static UnityEngine.Object GetConfigDataForNewResWebgl(string _0093_00B8_0082eyc)
		{
			UnityEngine.Object asset;
			if (newResLoadForWebgl == null)
			    CLog.Error("newResLoadForWebgl is null, unable to get config object. Requested configName=" + _0093_00B8_0082eyc);
			else if (newResLoadForWebgl.TryGetValue(_0093_00B8_0082eyc, out asset))
			    return asset;
			else
			    CLog.Error("GetConfig Object Failed ObjName=" + _0093_00B8_0082eyc);
			return null;
		}

		[Token(Token = "0x6005735")]
		private static void _0060_007Fit_008Bg<T>(string _00AD_0092zG_00ABd, Dictionary<object, T> _0081C_0082m_00A4G, string _0093_00B8_0082eyc) where T : BaseConfig
		{
			List<T> list = _0060_007Fit_008Bg<T>(_00AD_0092zG_00ABd);
			if (list != null)
			{
			    for (int i = 0; i < list.Count; i++)
			    {
			        if (_0081C_0082m_00A4G.ContainsKey(list[i].UniqueID))
			            CLog.Error(string.Format("表[{0}]中有相同键({1})", _0093_00B8_0082eyc, list[i].UniqueID));
			        else
			            _0081C_0082m_00A4G.Add(list[i].UniqueID, list[i]);
			    }
			}
		}

		[Token(Token = "0x6005736")]
		[AsyncStateMachine(typeof(global::GameFramework.ConfigRead._0091_008AslS_00B9<>))]
		public static Task readCustomConfigAsync<T>(string _0099k_005B_007DfÂ, Dictionary<object, T> _0081C_0082m_00A4G, ConfigType _009CqHÁ_009Bn) where T : BaseConfig
		{
			return null;
		}

		[Token(Token = "0x6005737")]
		private static void A_0086_00A3_00B8_00BDi<T>(Dictionary<object, T> _0081C_0082m_00A4G, TextAsset _0094wxV_00B9N, string _0093_00B8_0082eyc, ConfigType _009CqHÁ_009Bn) where T : BaseConfig
		{
			if (_0094wxV_00B9N != null)
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
			CLog.Error("配置文件不存在" + _0093_00B8_0082eyc);
		}

		[Token(Token = "0x6005738")]
		[Address(RVA = "0x71670B0", Offset = "0x71630B0", VA = "0x71670B0")]
		public ConfigRead()
		{
		}

		[Token(Token = "0x6005739")]
		public static Dictionary<object, string> readConfigB<T>() where T : BaseConfig
		{
			return null;
		}

		[Token(Token = "0x600573A")]
		[Address(RVA = "0x71670B8", Offset = "0x71630B8", VA = "0x71670B8")]
		public static UnityEngine.Object _007C_00B4_0095_008E_0096C(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x600573B")]
		[Address(RVA = "0x71672A8", Offset = "0x71632A8", VA = "0x71672A8")]
		private static Dictionary<object, string> _0084_009D_0090X_00BE_00AE(string _00AD_0092zG_00ABd, string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x600573C")]
		[Address(RVA = "0x71675D0", Offset = "0x71635D0", VA = "0x71675D0")]
		public static UnityEngine.Object Z_0090j_008FW_00BE(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x600573D")]
		public static Dictionary<object, string> readConfigBByMemoryPack<T>() where T : BaseConfig
		{
			return null;
		}

		[Token(Token = "0x600573E")]
		[Address(RVA = "0x71677C0", Offset = "0x71637C0", VA = "0x71677C0")]
		public static void SetDictForNewResWebgl(AllAssetsOperationHandle Fp_007C_0084U_00BD)
		{
		}

		[Token(Token = "0x600573F")]
		[Address(RVA = "0x7167A1C", Offset = "0x7163A1C", VA = "0x7167A1C")]
		private static Dictionary<object, string> _0095º_0095_00B8_005B_0060(string _00AD_0092zG_00ABd, string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x6005740")]
		[Address(RVA = "0x7167D60", Offset = "0x7163D60", VA = "0x7167D60")]
		[AsyncStateMachine(typeof(B_00A9_00A6_00B2_00BED))]
		public static Task waitLoadComplate()
		{
			return null;
		}

		[Token(Token = "0x6005741")]
		[Obsolete("LitJson解析方式已弃用，请使用UnityJson或者MemoryPack解析方式")]
		public static void ReloadConfig<T>(Dictionary<object, T> _0081C_0082m_00A4G) where T : BaseConfig
		{
		}

		[Token(Token = "0x6005742")]
		[Address(RVA = "0x7167E1C", Offset = "0x7163E1C", VA = "0x7167E1C")]
		public static void UC_0091MµÀ(Dictionary<string, float> _0081C_0082m_00A4G)
		{
		}

		[Token(Token = "0x6005743")]
		private static void _00B9_0087_00A9_00BF_0097_00BF<T>(string _00AD_0092zG_00ABd, Dictionary<object, T> _0081C_0082m_00A4G, string _0093_00B8_0082eyc) where T : BaseConfig
		{
		}

		[Token(Token = "0x6005744")]
		[AsyncStateMachine(typeof(global::GameFramework.ConfigRead.f_005E_0089_00ADmX<>))]
		public static Task readCustomConfigByUnityJsonAsync<T>(string _0099k_005B_007DfÂ, Dictionary<object, T> _0081C_0082m_00A4G) where T : BaseConfig
		{
			return null;
		}

		[Token(Token = "0x6005745")]
		[Address(RVA = "0x7168590", Offset = "0x7164590", VA = "0x7168590")]
		private static TextAsset _009CSRÁ_00ABU(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x6005746")]
		[Address(RVA = "0x7168914", Offset = "0x7164914", VA = "0x7168914")]
		public static void CleaWebglConfigHandler()
		{
		}

		[Token(Token = "0x6005747")]
		[Address(RVA = "0x716899C", Offset = "0x716499C", VA = "0x716899C")]
		public static void readOnceAudioConfig(Dictionary<string, float> _0081C_0082m_00A4G)
		{
		}

		[Token(Token = "0x6005748")]
		[Address(RVA = "0x7169104", Offset = "0x7165104", VA = "0x7169104")]
		public static void snm_00B6IY(AllAssetsOperationHandle Fp_007C_0084U_00BD)
		{
		}

		[Token(Token = "0x6005749")]
		[Address(RVA = "0x716935C", Offset = "0x716535C", VA = "0x716935C")]
		public static void n_0093_00A0f_008BB(Dictionary<string, float> _0081C_0082m_00A4G)
		{
		}

		[Token(Token = "0x600574A")]
		[Address(RVA = "0x7169AC8", Offset = "0x7165AC8", VA = "0x7169AC8")]
		public static void _0081_009AS_0097_00BFq(AllAssetsOperationHandle Fp_007C_0084U_00BD)
		{
		}

		[Token(Token = "0x600574B")]
		[Address(RVA = "0x716663C", Offset = "0x716263C", VA = "0x716663C")]
		public static UnityEngine.Object M_00AC_00A0_009D_00BD_00A3(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x600574C")]
		[Address(RVA = "0x7169D24", Offset = "0x7165D24", VA = "0x7169D24")]
		public static UnityEngine.Object _0083ÁbS_00A7_005E(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x600574D")]
		public static List<T> readConfig<T>(string Ha_0088wBM) where T : BaseConfig
		{
			return null;
		}

		[Token(Token = "0x600574E")]
		[Obsolete("LitJson解析方式已弃用，请使用UnityJson或者MemoryPack解析方式")]
		public static void readConfig<T>(Dictionary<object, T> _0081C_0082m_00A4G) where T : BaseConfig
		{
		}

		[Token(Token = "0x600574F")]
		[Address(RVA = "0x7169F14", Offset = "0x7165F14", VA = "0x7169F14")]
		public static void _00BF_00B7_00B4W_0089H()
		{
		}

		[Token(Token = "0x6005750")]
		private static List<T> _0060_007Fit_008Bg<T>(string _00AD_0092zG_00ABd) where T : BaseConfig
		{
			return JsonUtility.FromJson<UnSerialization<T>>(_00AD_0092zG_00ABd.Substring(_00AD_0092zG_00ABd.IndexOf("{"))).Datas;
		}

		[Token(Token = "0x6005751")]
		[Address(RVA = "0x7169F9C", Offset = "0x7165F9C", VA = "0x7169F9C")]
		private static TextAsset _007EW_00A6_00ACa_00AF(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x6005752")]
		[Address(RVA = "0x716A320", Offset = "0x7166320", VA = "0x716A320")]
		private static TextAsset o_005E_0092_0096A_00B7(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x6005753")]
		[AsyncStateMachine(typeof(global::GameFramework.ConfigRead._005B_00B3Iz_0081_008B<>))]
		public static Task readCustomConfigByMemoryPackAsync<T>(string _0099k_005B_007DfÂ, Dictionary<object, T> _0081C_0082m_00A4G) where T : BaseConfig
		{
			return null;
		}

		[Token(Token = "0x6005754")]
		public static void readCustomConfigByMemoryPack<T>(string _0099k_005B_007DfÂ, Dictionary<object, T> _0081C_0082m_00A4G) where T : BaseConfig
		{
		}

		[Token(Token = "0x6005755")]
		[Address(RVA = "0x716A84C", Offset = "0x716684C", VA = "0x716A84C")]
		private static Dictionary<object, string> Á_009Bl_0097_00B4_008C(string _00AD_0092zG_00ABd, string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x6005756")]
		[Address(RVA = "0x716AB38", Offset = "0x7166B38", VA = "0x716AB38")]
		public static void _007D_00BC_008CvÀ_0095(AllAssetsOperationHandle Fp_007C_0084U_00BD)
		{
		}

		[Token(Token = "0x6005757")]
		public static List<T> readConfig<T>() where T : BaseConfig
		{
			return null;
		}

		[Token(Token = "0x6005758")]
		[Obsolete("LitJson解析方式已弃用，请使用UnityJson或者MemoryPack解析方式")]
		public static T readConfigV<T>() where T : BaseConfig
		{
			return null;
		}

		[Token(Token = "0x6005759")]
		[Address(RVA = "0x716AD78", Offset = "0x7166D78", VA = "0x716AD78")]
		private static Dictionary<object, string> M_0085i_0098_00BD_008F(string _00AD_0092zG_00ABd, string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x600575A")]
		[Address(RVA = "0x716B090", Offset = "0x7167090", VA = "0x716B090")]
		public static void l_00A3_00B0_0098Z_00BF(Dictionary<string, float> _0081C_0082m_00A4G)
		{
		}

		[Token(Token = "0x600575B")]
		[Address(RVA = "0x716B478", Offset = "0x7167478", VA = "0x716B478")]
		public static Task _0094_0086W_009Do_00B0()
		{
			return null;
		}

		[Token(Token = "0x600575C")]
		[Address(RVA = "0x716A6A0", Offset = "0x71666A0", VA = "0x716A6A0")]
		public static UnityEngine.Object t_00AE_00A7s_007DÁ(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x600575D")]
		[Address(RVA = "0x716B534", Offset = "0x7167534", VA = "0x716B534")]
		public static void _008AbG_00A6_0090_0099(Dictionary<string, float> _0081C_0082m_00A4G)
		{
		}

		[Token(Token = "0x600575E")]
		[Address(RVA = "0x7168D84", Offset = "0x7164D84", VA = "0x7168D84")]
		private static TextAsset _0083_0098it_007EW(string _0093_00B8_0082eyc)
		{
			if (configRes == null && !AppSetting.UseNewRes)
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
			return configRes.LoadAsset<TextAsset>(null, _0093_00B8_0082eyc);
		}

		[Token(Token = "0x600575F")]
		public static void readConfigByUnityJson<T>(Dictionary<object, T> _0081C_0082m_00A4G) where T : BaseConfig
		{
			string configName = typeof(T).Name;
			TextAsset asset = _0083_0098it_007EW(configName);
			A_0086_00A3_00B8_00BDi(_0081C_0082m_00A4G, asset, configName, ConfigType.UnityJson);
			n_00B9XZd_009C++;
		}

		[Token(Token = "0x6005760")]
		[Address(RVA = "0x716B924", Offset = "0x7167924", VA = "0x716B924")]
		public static UnityEngine.Object _008DW_0093_00BExu(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x6005761")]
		private static List<T> _00A3_00B1f_008AI_00BF<T>(byte[] lD_009F_0098_0080_00B0) where T : BaseConfig
		{
			return null;
		}

		[Token(Token = "0x6005762")]
		[Address(RVA = "0x716BB14", Offset = "0x7167B14", VA = "0x716BB14")]
		public static void b_0098Sn_0088n(AllAssetsOperationHandle Fp_007C_0084U_00BD)
		{
		}

		[Token(Token = "0x6005763")]
		public static void readConfigForDict<T>(string Ha_0088wBM, Dictionary<object, T> _0081C_0082m_00A4G) where T : BaseConfig
		{
		}

		[Token(Token = "0x6005764")]
		[Address(RVA = "0x716BD54", Offset = "0x7167D54", VA = "0x716BD54")]
		public static void PZ_008B_00AB_00ADS(Dictionary<string, float> _0081C_0082m_00A4G)
		{
		}

		[Token(Token = "0x6005766")]
		[Address(RVA = "0x716C238", Offset = "0x7168238", VA = "0x716C238")]
		public static void Lªq_0083W_00AF()
		{
		}

		[Token(Token = "0x6005767")]
		[Address(RVA = "0x716C2C0", Offset = "0x71682C0", VA = "0x716C2C0")]
		public static void _0087_0083_00B2_0088u_00A4(AllAssetsOperationHandle Fp_007C_0084U_00BD)
		{
		}

		[Token(Token = "0x6005768")]
		public static T readConfigVByMemoryPack<T>() where T : BaseConfig
		{
			return null;
		}

		[Token(Token = "0x6005769")]
		public static void readCustomConfig<T>(string _0099k_005B_007DfÂ, Dictionary<object, T> _0081C_0082m_00A4G, ConfigType _009CqHÁ_009Bn) where T : BaseConfig
		{
		}

		[Token(Token = "0x600576A")]
		public static void readConfigByMemoryPack<T>(Dictionary<object, T> _0081C_0082m_00A4G) where T : BaseConfig
		{
		}

		[Token(Token = "0x600576B")]
		public static void ReloadConfigByMemoryPack<T>(Dictionary<object, T> _0081C_0082m_00A4G) where T : BaseConfig
		{
		}

		[Token(Token = "0x600576C")]
		[Address(RVA = "0x716820C", Offset = "0x716420C", VA = "0x716820C")]
		private static TextAsset tx_009C_0085c_00AE(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x600576D")]
		[Address(RVA = "0x716C518", Offset = "0x7168518", VA = "0x716C518")]
		public static UnityEngine.Object kH_0085º_0091_0092(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x600576E")]
		public static void readCustomConfigByUnityJson<T>(string _0099k_005B_007DfÂ, Dictionary<object, T> _0081C_0082m_00A4G) where T : BaseConfig
		{
		}

		[Token(Token = "0x600576F")]
		private static List<T> _00B9_0087_00A9_00BF_0097_00BF<T>(string _00AD_0092zG_00ABd) where T : BaseConfig
		{
			return null;
		}

		[Token(Token = "0x6005770")]
		private static void _00A3_00B1f_008AI_00BF<T>(byte[] lD_009F_0098_0080_00B0, Dictionary<object, T> _0081C_0082m_00A4G, string _0093_00B8_0082eyc) where T : BaseConfig
		{
		}

		[Token(Token = "0x6005771")]
		[Address(RVA = "0x716C708", Offset = "0x7168708", VA = "0x716C708")]
		public static void _00B0kk_0099_00ADV(Dictionary<string, float> _0081C_0082m_00A4G)
		{
		}

		[Token(Token = "0x6005772")]
		[Address(RVA = "0x7169744", Offset = "0x7165744", VA = "0x7169744")]
		private static TextAsset _0088_0089XV_00A6_00B7(string _0093_00B8_0082eyc)
		{
			return null;
		}

		[Token(Token = "0x6005773")]
		[Address(RVA = "0x716CAF4", Offset = "0x7168AF4", VA = "0x716CAF4")]
		public static void _00A9B_00BCu_008DL(Dictionary<string, float> _0081C_0082m_00A4G)
		{
		}
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

	}
}
