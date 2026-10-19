using System;
using System.IO;
using System.Runtime.CompilerServices;
using GameFramework.Base;
using GameFramework.Download;
using Il2CppDummyDll;

[Token(Token = "0x2000499")]
internal class _0088B_00A1_0084Q_008A : global::_008D_0084v_0097zh<_00AF_0083a_00A2S_0060>
{
	[Token(Token = "0x4001EEC")]
	[FieldOffset(Offset = "0x10")]
	private readonly IDownloadAgentHelper _00AC_00A2º_007F_0097_00A8;

	[Token(Token = "0x4001EED")]
	[FieldOffset(Offset = "0x18")]
	private _00AF_0083a_00A2S_0060 zP_00B1a_0091_007F;

	[Token(Token = "0x4001EEE")]
	[FieldOffset(Offset = "0x20")]
	private FileStream _0083_00B8_0095I_00AF_00A4;

	[Token(Token = "0x4001EEF")]
	[FieldOffset(Offset = "0x28")]
	private int FJ_0092W_005Eª;

	[Token(Token = "0x4001EF0")]
	[FieldOffset(Offset = "0x2C")]
	private float Q_0098Â_0083_00B4_00A1;

	[Token(Token = "0x4001EF1")]
	[FieldOffset(Offset = "0x30")]
	private int Âvs_0060_0091Z;

	[Token(Token = "0x4001EF2")]
	[FieldOffset(Offset = "0x34")]
	private int C_00B2_00AC_00BEoH;

	[Token(Token = "0x4001EF3")]
	[FieldOffset(Offset = "0x38")]
	private int A_00A6_00A4CT_005E;

	[Token(Token = "0x4001EF4")]
	[FieldOffset(Offset = "0x3C")]
	private bool YDSE_0060u;

	[Token(Token = "0x4001EF5")]
	[FieldOffset(Offset = "0x40")]
	public Action<_0088B_00A1_0084Q_008A> DownloadAgentStart;

	[Token(Token = "0x4001EF6")]
	[FieldOffset(Offset = "0x48")]
	public Action<_0088B_00A1_0084Q_008A, int> DownloadAgentUpdate;

	[Token(Token = "0x4001EF7")]
	[FieldOffset(Offset = "0x50")]
	public Action<_0088B_00A1_0084Q_008A, int> DownloadAgentSuccess;

	[Token(Token = "0x4001EF8")]
	[FieldOffset(Offset = "0x58")]
	public Action<_0088B_00A1_0084Q_008A, string> DownloadAgentFailure;

	[Token(Token = "0x4001EF9")]
	[FieldOffset(Offset = "0x60")]
	private float _0091_009AUC_00BFG;

	[Token(Token = "0x170011F1")]
	public float FreeWaitTimes
	{
		[Token(Token = "0x6006D39")]
		[Address(RVA = "0x7299BCC", Offset = "0x7295BCC", VA = "0x7299BCC", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x6006D4A")]
		[Address(RVA = "0x729AEA4", Offset = "0x7296EA4", VA = "0x729AEA4", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170011F2")]
	public _00AF_0083a_00A2S_0060 Task
	{
		[Token(Token = "0x6006D43")]
		[Address(RVA = "0x729A9AC", Offset = "0x72969AC", VA = "0x729A9AC", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011F3")]
	public float WaitTime
	{
		[Token(Token = "0x6006D40")]
		[Address(RVA = "0x729A458", Offset = "0x7296458", VA = "0x729A458")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170011F4")]
	public float StartLength
	{
		[Token(Token = "0x6006D18")]
		[Address(RVA = "0x72977B8", Offset = "0x72937B8", VA = "0x72977B8")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170011F5")]
	public float DownloadedLength
	{
		[Token(Token = "0x6006D36")]
		[Address(RVA = "0x72998BC", Offset = "0x72958BC", VA = "0x72998BC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170011F6")]
	public int CurrentLength
	{
		[Token(Token = "0x6006D2D")]
		[Address(RVA = "0x7298D64", Offset = "0x7294D64", VA = "0x7298D64")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170011F7")]
	public float SavedLength
	{
		[Token(Token = "0x6006D2F")]
		[Address(RVA = "0x7298DA8", Offset = "0x7294DA8", VA = "0x7298DA8")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6006D15")]
	[Address(RVA = "0x72971B4", Offset = "0x72931B4", VA = "0x72971B4", Slot = "12")]
	public void _00B1W_009F_0095eX()
	{
	}

	[SpecialName]
	[Token(Token = "0x6006D16")]
	[Address(RVA = "0x72974B0", Offset = "0x72934B0", VA = "0x72974B0")]
	public float _008C_00B7_00B1ÀÀU()
	{
		return default;
	}

	[Token(Token = "0x6006D17")]
	[Address(RVA = "0x72974BC", Offset = "0x72934BC", VA = "0x72974BC", Slot = "13")]
	public void sPQ_00AB_00A2_00B9()
	{
	}

	[Token(Token = "0x6006D19")]
	[Address(RVA = "0x72977C4", Offset = "0x72937C4", VA = "0x72977C4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6006D1A")]
	[Address(RVA = "0x7297878", Offset = "0x7293878", VA = "0x7297878", Slot = "14")]
	public void _0084_00A8RuOU()
	{
	}

	[SpecialName]
	[Token(Token = "0x6006D1B")]
	[Address(RVA = "0x729795C", Offset = "0x729395C", VA = "0x729795C")]
	public float _00B4_0086o_0085_0060_00AB()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6006D1C")]
	[Address(RVA = "0x7297968", Offset = "0x7293968", VA = "0x7297968")]
	public int _00B9_007E_007D_00A9GL()
	{
		return default;
	}

	[Token(Token = "0x6006D1D")]
	[Address(RVA = "0x7297840", Offset = "0x7293840", VA = "0x7297840")]
	private void c_00B0_009A_008D_00A6_00A8(bool _008ASp_0084_009D_008C)
	{
	}

	[Token(Token = "0x6006D1E")]
	[Address(RVA = "0x7297974", Offset = "0x7293974", VA = "0x7297974")]
	public _0088B_00A1_0084Q_008A(IDownloadAgentHelper _00B7_00B9_009A_00A8b_00AE)
	{
	}

	[Token(Token = "0x6006D1F")]
	[Address(RVA = "0x72979FC", Offset = "0x72939FC", VA = "0x72979FC")]
	private void aq_00BEaT_007B(object _00B2w_00B7_00A7h_00B9, DownloadAgentHelperUpdateLengthEventArgs yJª_0085o_0086)
	{
	}

	[Token(Token = "0x6006D20")]
	[Address(RVA = "0x7297A40", Offset = "0x7293A40", VA = "0x7297A40")]
	private void YX_00B3Vs_00AB(object _00B2w_00B7_00A7h_00B9, DownloadAgentHelperUpdateBytesEventArgs yJª_0085o_0086)
	{
	}

	[SpecialName]
	[Token(Token = "0x6006D21")]
	[Address(RVA = "0x7297D60", Offset = "0x7293D60", VA = "0x7297D60")]
	public float _009D_008C_008F_007F_008FY()
	{
		return default;
	}

	[Token(Token = "0x6006D22")]
	[Address(RVA = "0x7297D6C", Offset = "0x7293D6C", VA = "0x7297D6C", Slot = "9")]
	public void Update(float _008EJ_0092_009BUc, float rfjÀ_0098L)
	{
	}

	[Token(Token = "0x6006D23")]
	[Address(RVA = "0x7297EEC", Offset = "0x7293EEC", VA = "0x7297EEC", Slot = "15")]
	public void H_0091_00AE_009Eqk()
	{
	}

	[SpecialName]
	[Token(Token = "0x6006D24")]
	[Address(RVA = "0x72981E8", Offset = "0x72941E8", VA = "0x72981E8", Slot = "16")]
	public _00AF_0083a_00A2S_0060 _0092_00B0_008E_00AD_0092_008C()
	{
		return null;
	}

	[Token(Token = "0x6006D25")]
	[Address(RVA = "0x72981F0", Offset = "0x72941F0", VA = "0x72981F0", Slot = "17")]
	public void _0090QÂOÀ_00B6()
	{
	}

	[SpecialName]
	[Token(Token = "0x6006D26")]
	[Address(RVA = "0x72982D8", Offset = "0x72942D8", VA = "0x72982D8")]
	public float _008Eo_008D_00BE_00BBO()
	{
		return default;
	}

	[Token(Token = "0x6006D27")]
	[Address(RVA = "0x72982E4", Offset = "0x72942E4", VA = "0x72982E4", Slot = "11")]
	public void Shutdown()
	{
	}

	[Token(Token = "0x6006D28")]
	[Address(RVA = "0x7298650", Offset = "0x7294650", VA = "0x7298650", Slot = "7")]
	public void Initialize()
	{
	}

	[SpecialName]
	[Token(Token = "0x6006D29")]
	[Address(RVA = "0x729894C", Offset = "0x729494C", VA = "0x729894C", Slot = "18")]
	public _00AF_0083a_00A2S_0060 nk_009B_00AD_008F_00B6()
	{
		return null;
	}

	[Token(Token = "0x6006D2A")]
	[Address(RVA = "0x7298954", Offset = "0x7294954", VA = "0x7298954")]
	private void _009Fcz_009BEµ(object _00B2w_00B7_00A7h_00B9, DownloadAgentHelperUpdateLengthEventArgs yJª_0085o_0086)
	{
	}

	[Token(Token = "0x6006D2B")]
	[Address(RVA = "0x7298998", Offset = "0x7294998", VA = "0x7298998")]
	private void _0085_0080_0088_00AD_00BCw(object _00B2w_00B7_00A7h_00B9, DownloadAgentHelperCompleteEventArgs yJª_0085o_0086)
	{
	}

	[Token(Token = "0x6006D2C")]
	[Address(RVA = "0x7298B8C", Offset = "0x7294B8C", VA = "0x7298B8C")]
	private void s_00B8V_00A7_009A_00AD(object _00B2w_00B7_00A7h_00B9, DownloadAgentHelperUpdateBytesEventArgs yJª_0085o_0086)
	{
	}

	[Token(Token = "0x6006D2E")]
	[Address(RVA = "0x7298D70", Offset = "0x7294D70", VA = "0x7298D70")]
	private void _007B_0093_00A8_005E_0060_008C(bool _008ASp_0084_009D_008C)
	{
	}

	[Token(Token = "0x6006D30")]
	[Address(RVA = "0x7298DB4", Offset = "0x7294DB4", VA = "0x7298DB4")]
	private void U_00ABa_009A_00BCI(object _00B2w_00B7_00A7h_00B9, DownloadAgentHelperUpdateLengthEventArgs yJª_0085o_0086)
	{
	}

	[Token(Token = "0x6006D31")]
	[Address(RVA = "0x7298DF8", Offset = "0x7294DF8", VA = "0x7298DF8")]
	private void _007EjxSi_005E(object _00B2w_00B7_00A7h_00B9, DownloadAgentHelperCompleteEventArgs yJª_0085o_0086)
	{
	}

	[Token(Token = "0x6006D32")]
	[Address(RVA = "0x7298FDC", Offset = "0x7294FDC", VA = "0x7298FDC")]
	private void JÂ_0094_0081C_0091(object _00B2w_00B7_00A7h_00B9, DownloadAgentHelperUpdateBytesEventArgs yJª_0085o_0086)
	{
	}

	[SpecialName]
	[Token(Token = "0x6006D33")]
	[Address(RVA = "0x7299148", Offset = "0x7295148", VA = "0x7299148")]
	public int _007FM_00A8_00A0Qv()
	{
		return default;
	}

	[Token(Token = "0x6006D34")]
	[Address(RVA = "0x7299154", Offset = "0x7295154", VA = "0x7299154", Slot = "19")]
	public StartTaskStatus _00B3cQr_0094_0094(_00AF_0083a_00A2S_0060 Z_00B6_0093D_0098q)
	{
		return default;
	}

	[Token(Token = "0x6006D35")]
	[Address(RVA = "0x72995C0", Offset = "0x72955C0", VA = "0x72995C0", Slot = "20")]
	public void oZD_0094_009Dt()
	{
	}

	[SpecialName]
	[Token(Token = "0x6006D37")]
	[Address(RVA = "0x72998C8", Offset = "0x72958C8", VA = "0x72998C8", Slot = "21")]
	public void u_009DiPjX(float _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6006D38")]
	[Address(RVA = "0x72998D0", Offset = "0x72958D0", VA = "0x72998D0", Slot = "22")]
	public void _00B8O_00A1I_008Fª()
	{
	}

	[Token(Token = "0x6006D3A")]
	[Address(RVA = "0x7299BD4", Offset = "0x7295BD4", VA = "0x7299BD4", Slot = "8")]
	public StartTaskStatus Start(_00AF_0083a_00A2S_0060 Z_00B6_0093D_0098q)
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6006D3B")]
	[Address(RVA = "0x729A034", Offset = "0x7296034", VA = "0x729A034")]
	public float Wg_008B_00A1z_007E()
	{
		return default;
	}

	[Token(Token = "0x6006D3C")]
	[Address(RVA = "0x729A040", Offset = "0x7296040", VA = "0x729A040")]
	private void pR_007E_00A6_0093_0089(object _00B2w_00B7_00A7h_00B9, DownloadAgentHelperUpdateLengthEventArgs yJª_0085o_0086)
	{
	}

	[SpecialName]
	[Token(Token = "0x6006D3D")]
	[Address(RVA = "0x729A084", Offset = "0x7296084", VA = "0x729A084", Slot = "23")]
	public float POMkJ_0091()
	{
		return default;
	}

	[Token(Token = "0x6006D3E")]
	[Address(RVA = "0x729A08C", Offset = "0x729608C", VA = "0x729A08C", Slot = "24")]
	public void KQcN_00A6_0082()
	{
	}

	[Token(Token = "0x6006D3F")]
	[Address(RVA = "0x729A388", Offset = "0x7296388", VA = "0x729A388", Slot = "10")]
	public void Reset()
	{
	}

	[Token(Token = "0x6006D41")]
	[Address(RVA = "0x729A460", Offset = "0x7296460", VA = "0x729A460")]
	public void _007F_0082_00ABaXx()
	{
	}

	[Token(Token = "0x6006D42")]
	[Address(RVA = "0x729A4DC", Offset = "0x72964DC", VA = "0x729A4DC", Slot = "25")]
	public StartTaskStatus z_00A6_0090W_005D_008E(_00AF_0083a_00A2S_0060 Z_00B6_0093D_0098q)
	{
		return default;
	}

	[Token(Token = "0x6006D44")]
	[Address(RVA = "0x729A9B4", Offset = "0x72969B4", VA = "0x729A9B4")]
	private void _00AC_00ACl_0088OG(object _00B2w_00B7_00A7h_00B9, DownloadAgentHelperCompleteEventArgs yJª_0085o_0086)
	{
	}

	[SpecialName]
	[Token(Token = "0x6006D45")]
	[Address(RVA = "0x729AB94", Offset = "0x7296B94", VA = "0x729AB94")]
	public float _0097VU_008Dc_008D()
	{
		return default;
	}

	[Token(Token = "0x6006D46")]
	[Address(RVA = "0x7297C18", Offset = "0x7293C18", VA = "0x7297C18")]
	private void _007B_00A3XP_00B6Q(object _00B2w_00B7_00A7h_00B9, DownloadAgentHelperErrorEventArgs yJª_0085o_0086)
	{
	}

	[SpecialName]
	[Token(Token = "0x6006D47")]
	[Address(RVA = "0x729ABA0", Offset = "0x7296BA0", VA = "0x729ABA0", Slot = "26")]
	public float _007F_00BD_00A9_0086_00BB_00AF()
	{
		return default;
	}

	[Token(Token = "0x6006D48")]
	[Address(RVA = "0x729ABA8", Offset = "0x7296BA8", VA = "0x729ABA8", Slot = "27")]
	public void J_0088al_00B0_0080()
	{
	}

	[SpecialName]
	[Token(Token = "0x6006D49")]
	[Address(RVA = "0x7298B80", Offset = "0x7294B80", VA = "0x7298B80")]
	public int cÂ_0091k_0087x()
	{
		return default;
	}

	[Token(Token = "0x6006D4B")]
	[Address(RVA = "0x729AEAC", Offset = "0x7296EAC", VA = "0x729AEAC", Slot = "28")]
	public void BOhg_009B_007E()
	{
	}

	[Token(Token = "0x6006D4C")]
	[Address(RVA = "0x729AF84", Offset = "0x7296F84", VA = "0x729AF84")]
	public void _008BrOQYª()
	{
	}
}
