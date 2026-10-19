using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000027")]
internal sealed class _0098aµduq
{
	[Token(Token = "0x2000028")]
	public delegate void LogCallbackDelegate(string ºº_008BJl_009F, string _0098Á_007F_00AByl, LogType _007BgpR_00A0V);

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string yqg_00ABX_00B9;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int _009C_00A2VLmp;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int _00B0RZ_00B1_00A4_007B;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x10")]
	private static bool b_0088_0080j_007F_008A;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x18")]
	private static AndroidJavaClass _00A7r_00A3Y_0083_007B;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x20")]
	private static string w_00AB_00AF_00AEªQ;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x28")]
	private static string _007B_008Bb_00BE_00B1P;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x30")]
	private static string AQYÂc_005D;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x38")]
	private static long _0083_009B_009E_00B0_0092y;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x40")]
	private static bool t_0090uRN_00A0;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x48")]
	private static LogCallbackDelegate tVp_0082c_0085__BackingField;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x50")]
	private static bool FZLFº_0080;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x54")]
	private static LogSeverity _00A4_00BE_0084_0087h_00BF;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x58")]
	private static int H_008A_00A7bFB;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x60")]
	private static string _007EX_0094_0098I_00BC;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x68")]
	private static bool DJ_0095_00A4d_0083;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x69")]
	private static bool _00BB_0086_00A5_0085_005E_00B3;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x6C")]
	private static readonly int sUµ_0090_00AEB;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x70")]
	private static readonly int _007D_007CF_007EIp;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x78")]
	private static readonly string p_00A6_00B6_007E_009EX;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x80")]
	private static Func<Dictionary<string, string>> u_0089º_009Fkk;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x88")]
	private static bool H_00B6_008B_007Eµ_008A;

	[Token(Token = "0x17000021")]
	public static AndroidJavaClass GameAgent
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x70770D8", Offset = "0x70730D8", VA = "0x70770D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000022")]
	public static string PluginVersion
	{
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x707A90C", Offset = "0x707690C", VA = "0x707A90C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000023")]
	public static bool IsInitialized
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x70789B0", Offset = "0x70749B0", VA = "0x70789B0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000024")]
	public static bool AutoQuitApplicationAfterReport
	{
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x707A964", Offset = "0x7076964", VA = "0x707A964")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x14000001")]
	private static event LogCallbackDelegate tVp_0082c_0085
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x70784AC", Offset = "0x70744AC", VA = "0x70784AC")]
		add
		{
			ÁÁ_00BD_00A7_00AD_00B9(value);
		}
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x707866C", Offset = "0x707466C", VA = "0x707866C")]
		remove
		{
			_00B0_00A2M_00B4_008F_00B7(value);
		}
	}

	[SpecialName]
	[Token(Token = "0x6000146")]
	[Address(RVA = "0x7073B04", Offset = "0x706FB04", VA = "0x7073B04")]
	private static void _00B2_00AF_008Bb_00BCp(LogCallbackDelegate _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x7073BE0", Offset = "0x706FBE0", VA = "0x7073BE0")]
	public static void InitWithAppId(string n_00A7rtD_00B1)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x7074438", Offset = "0x7070438", VA = "0x7074438")]
	public static void q_00B4_00B7_007D_0094v(string _0088_00A7_00B0_00B8Y_0090, string _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x7074770", Offset = "0x7070770", VA = "0x7074770")]
	private static void _009Ep_00AE_00A2P_00A7(LogSeverity c_00ADµVF_0092, string _00AE_008C_009AiPJ, string aDÂ_005B_0091_0086, string _0098Á_007F_00AByl, bool _0091B_0093ªjv)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x7075A68", Offset = "0x7071A68", VA = "0x7075A68")]
	public static void _00AD_005DPAN_00A9(LogSeverity g_00BE_009A_0086mM)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x7075AC4", Offset = "0x7071AC4", VA = "0x7075AC4")]
	public static void SetUserId(string E_008F_00A4_0086Ht)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x7075D74", Offset = "0x7071D74", VA = "0x7075D74")]
	private static void _00AEXCY_00A9_0092(string ºº_008BJl_009F, string _0098Á_007F_00AByl, LogType _007BgpR_00A0V)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x7076958", Offset = "0x7072958", VA = "0x7076958")]
	public static void ConfigAutoQuitApplication(bool _0092s_00BCB_007ER)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x70769B8", Offset = "0x70729B8", VA = "0x70769B8")]
	public static void Uª_00B8Âra(Exception yJª_0085o_0086, string aDÂ_005B_0091_0086)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x70772A8", Offset = "0x70732A8", VA = "0x70772A8")]
	public static void m_009D_0089_008E_0083a(int C_008BÂ_00A1_00A5_007E)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x70775AC", Offset = "0x70735AC", VA = "0x70775AC")]
	private static void _008E_00A6_009EVc_00BE()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x7077954", Offset = "0x7073954", VA = "0x7077954")]
	public static void _00A7_00B0_00B7O_0083_0083(LogCallbackDelegate _0091_00BF_0099sB_007E)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x7077A44", Offset = "0x7073A44", VA = "0x7077A44")]
	private static void ªq_009C_0091ÀO()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x7077C3C", Offset = "0x7073C3C", VA = "0x7077C3C")]
	public static void hwiH_00A7_00AC(LogCallbackDelegate _0091_00BF_0099sB_007E)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x7077DFC", Offset = "0x7073DFC", VA = "0x7077DFC")]
	public static void _00B9_007Cz_0096_0085_008B(bool z_0094X_00A2_009C_0083)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x70780D4", Offset = "0x70740D4", VA = "0x70780D4")]
	public static void _009A_0094J_009E_008A_0090(LogSeverity g_00BE_009A_0086mM, string qkmY_00ADL, object[] _00BC_00AE_007DW_00A3_0090)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x7078418", Offset = "0x7074418", VA = "0x7078418")]
	private static void _0085_0090_00A7EÂ_0060(int _007BgpR_00A0V)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x70784AC", Offset = "0x70744AC", VA = "0x70784AC")]
	private static void ÁÁ_00BD_00A7_00AD_00B9(LogCallbackDelegate _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x7078588", Offset = "0x7074588", VA = "0x7078588")]
	public static void RegisterLogCallback(LogCallbackDelegate _0091_00BF_0099sB_007E)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x707866C", Offset = "0x707466C", VA = "0x707866C")]
	private static void _00B0_00A2M_00B4_008F_00B7(LogCallbackDelegate _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x600015B")]
	[Address(RVA = "0x7078748", Offset = "0x7074748", VA = "0x7078748")]
	private static void Clh_00BBÁ_007E(LogCallbackDelegate _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x7078824", Offset = "0x7074824", VA = "0x7078824")]
	private static void _0088_00A0F_007F_0088_0084(int _007BgpR_00A0V)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x70745A8", Offset = "0x70705A8", VA = "0x70745A8")]
	private static void A_00B3_0080_0082_009D_009B(string _0088_00A7_00B0_00B8Y_0090, string _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x7077404", Offset = "0x7073404", VA = "0x7077404")]
	private static void t_00B2_00B7w_0099_0080(int C_008BÂ_00A1_00A5_007E)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x70788B8", Offset = "0x70748B8", VA = "0x70788B8")]
	public static void _00ABe_0093L_0080D(LogSeverity g_00BE_009A_0086mM, string qkmY_00ADL, object[] _00BC_00AE_007DW_00A3_0090)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x7078958", Offset = "0x7074958", VA = "0x7078958")]
	public static bool ZN_00A0_007CV_0086()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x7077D20", Offset = "0x7073D20", VA = "0x7077D20")]
	private static void I_005B_00BB_0099_0092_0081(LogCallbackDelegate _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x7078A08", Offset = "0x7074A08", VA = "0x7078A08")]
	public static void SetScene(int C_008BÂ_00A1_00A5_007E)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x7078B64", Offset = "0x7074B64", VA = "0x7078B64")]
	private static void _0094_00A3_008FBP_007D(int c_00ADµVF_0092)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x7078B68", Offset = "0x7074B68", VA = "0x7078B68")]
	public static void ar_00B2_00BCx_00BD(Func<Dictionary<string, string>> _0091_00BF_0099sB_007E)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x7078C50", Offset = "0x7074C50", VA = "0x7078C50")]
	private static void st_007E_009C_008FY()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x7075BF8", Offset = "0x7071BF8", VA = "0x7075BF8")]
	private static void P_0090_00B6_00B1ª_0081(string _005EkW_0091_0093T)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x7078E48", Offset = "0x7074E48", VA = "0x7078E48")]
	private static void _0081Ác_007FRF(int _007BgpR_00A0V, string _00AE_008C_009AiPJ, string _00B1_00B1_00AC_00A8Y_00AE, string _0098Á_007F_00AByl, bool b_00A4_00A8_00A2_005B_0086)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x7073DCC", Offset = "0x706FDCC", VA = "0x7073DCC")]
	public static void DebugLog(string N_00BFA_007Ev_00A2, string qkmY_00ADL, params object[] _00BC_00AE_007DW_00A3_0090)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x7079134", Offset = "0x7075134", VA = "0x7079134")]
	public static void _009E_00AFRyAF(Exception yJª_0085o_0086, string aDÂ_005B_0091_0086)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x70798A0", Offset = "0x70758A0", VA = "0x70798A0")]
	private static void C_00BBm_00B4qC(object _00B2w_00B7_00A7h_00B9, UnhandledExceptionEventArgs _00BC_00AE_007DW_00A3_0090)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x7079B04", Offset = "0x7075B04", VA = "0x7079B04")]
	public static void ReportException(Exception yJª_0085o_0086, string aDÂ_005B_0091_0086)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x7078174", Offset = "0x7074174", VA = "0x7078174")]
	private static void Àp_0092_00A4v_008E(LogSeverity g_00BE_009A_0086mM, string aDÂ_005B_0091_0086)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x7079C78", Offset = "0x7075C78", VA = "0x7079C78")]
	public static void UnregisterLogCallback(LogCallbackDelegate _0091_00BF_0099sB_007E)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x7079D68", Offset = "0x7075D68", VA = "0x7079D68")]
	public static void ConfigCrashReporter(int _007BgpR_00A0V, int c_00ADµVF_0092)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x7079DC0", Offset = "0x7075DC0", VA = "0x7079DC0")]
	private static void _00ABk_00AD_007DpK(int C_008BÂ_00A1_00A5_007E)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x707A110", Offset = "0x7076110", VA = "0x707A110")]
	public static void ConfigDebugMode(bool z_0094X_00A2_009C_0083)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x7077F20", Offset = "0x7073F20", VA = "0x7077F20")]
	private static void O_0060k_00AF_009A_005B(bool z_0094X_00A2_009C_0083)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x707A234", Offset = "0x7076234", VA = "0x707A234")]
	public static void PrintLog(LogSeverity g_00BE_009A_0086mM, string qkmY_00ADL, params object[] _00BC_00AE_007DW_00A3_0090)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x707A2D4", Offset = "0x70762D4", VA = "0x707A2D4")]
	private static void _00AB_005EbW_009E_007B(string _00B0EQjC_007E, string V_00B2_00BEHJA, string fM_0082_00B3We, long _008AG_007C_00A8_00A7n)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x70792AC", Offset = "0x70752AC", VA = "0x70792AC")]
	private static void _0085_0087pQy_00B3(Exception yJª_0085o_0086, string aDÂ_005B_0091_0086, bool _0091B_0093ªjv)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x707A350", Offset = "0x7076350", VA = "0x707A350")]
	public static void SetLogCallbackExtrasHandler(Func<Dictionary<string, string>> _0091_00BF_0099sB_007E)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x707A438", Offset = "0x7076438", VA = "0x707A438")]
	public static void gS_008E_00B3Z_007E(string E_008F_00A4_0086Ht)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x707A56C", Offset = "0x707656C", VA = "0x707A56C")]
	public static void ReportException(string _00AE_008C_009AiPJ, string aDÂ_005B_0091_0086, string _0098Á_007F_00AByl)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x7076B28", Offset = "0x7072B28", VA = "0x7076B28")]
	private static void c_008BNfER(Exception yJª_0085o_0086, string aDÂ_005B_0091_0086, bool _0091B_0093ªjv)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x707A714", Offset = "0x7076714", VA = "0x707A714")]
	public static void _005Dm_00B0U_0097g(string n_00A7rtD_00B1)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x707A900", Offset = "0x7076900", VA = "0x707A900")]
	public _0098aµduq()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x70751D8", Offset = "0x70711D8", VA = "0x70751D8")]
	private static void _0093_00AB_009F_0081R_00B7(bool _0091B_0093ªjv, string _00AE_008C_009AiPJ, string _00B1_00B1_00AC_00A8Y_00AE, string _0098Á_007F_00AByl)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x707A908", Offset = "0x7076908", VA = "0x707A908")]
	private static void _00A7aT_00A4G_009E(string _0088_00A7_00B0_00B8Y_0090, string _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x707A9BC", Offset = "0x70769BC", VA = "0x707A9BC")]
	private static void _0094_00B9Nw_00B3b(int c_00ADµVF_0092)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x7073EBC", Offset = "0x706FEBC", VA = "0x7073EBC")]
	private static void X_00AFOµ_0097_0081(string n_00A7rtD_00B1)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x70777AC", Offset = "0x70737AC", VA = "0x70777AC")]
	private static void _0095_00ABG_008As_0085()
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x707A9C0", Offset = "0x70769C0", VA = "0x707A9C0")]
	public static void EnableExceptionHandler()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x707AB18", Offset = "0x7076B18", VA = "0x707AB18")]
	public static void ConfigDefault(string _00B0EQjC_007E, string V_00B2_00BEHJA, string fM_0082_00B3We, long _008AG_007C_00A8_00A7n)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x707ACBC", Offset = "0x7076CBC", VA = "0x707ACBC")]
	public static void e_008DUV_009E_0089(int C_008BÂ_00A1_00A5_007E)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x7075F10", Offset = "0x7071F10", VA = "0x7075F10")]
	private static void _0085_0087pQy_00B3(LogSeverity c_00ADµVF_0092, string _00AE_008C_009AiPJ, string aDÂ_005B_0091_0086, string _0098Á_007F_00AByl, bool _0091B_0093ªjv)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x707B0A8", Offset = "0x70770A8", VA = "0x707B0A8")]
	private static void P_00B4c_0088Zµ(int c_00ADµVF_0092)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x707B0AC", Offset = "0x70770AC", VA = "0x707B0AC")]
	private static void _0093_008FAµ_0094_00B6(LogCallbackDelegate _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x70741E0", Offset = "0x70701E0", VA = "0x70741E0")]
	private static void _00A0_00B4jR_009E_005E()
	{
	}

	[SpecialName]
	[Token(Token = "0x600018B")]
	[Address(RVA = "0x707B188", Offset = "0x7077188", VA = "0x707B188")]
	private static void _00B3_0086N_009BlR(LogCallbackDelegate _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x707B264", Offset = "0x7077264", VA = "0x707B264")]
	public static void _00A4aZ_00AFls(Func<Dictionary<string, string>> _0091_00BF_0099sB_007E)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x7079DBC", Offset = "0x7075DBC", VA = "0x7079DBC")]
	private static void u_0083J_00B9sº(int c_00ADµVF_0092)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x7079F6C", Offset = "0x7075F6C", VA = "0x7079F6C")]
	private static void _0084_0088U_0093rL()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x707B350", Offset = "0x7077350", VA = "0x707B350")]
	public static void AddSceneData(string _0088_00A7_00B0_00B8Y_0090, string _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x707B4C0", Offset = "0x70774C0", VA = "0x707B4C0")]
	public static void w_00B4_0096oF_008C(string _00AE_008C_009AiPJ, string aDÂ_005B_0091_0086, string _0098Á_007F_00AByl)
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x707AE18", Offset = "0x7076E18", VA = "0x707AE18")]
	private static void _00B8_00B9Y_0093wn(int C_008BÂ_00A1_00A5_007E)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x707B668", Offset = "0x7077668", VA = "0x707B668")]
	public static void _00ADjM_007FªQ(LogCallbackDelegate _0091_00BF_0099sB_007E)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x707B758", Offset = "0x7077758", VA = "0x707B758")]
	public static void ConfigAutoReportLogLevel(LogSeverity g_00BE_009A_0086mM)
	{
	}
}
