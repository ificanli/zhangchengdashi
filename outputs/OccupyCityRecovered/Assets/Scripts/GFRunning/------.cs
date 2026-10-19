using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YooAsset;

[Token(Token = "0x2000085")]
internal class _0091_0083_0084_0094_0085_0096 : _0081_0090_00A9hh_00B4
{
	[Token(Token = "0x2000086")]
	private enum _00A3_0097_0094YtD
	{
		[Token(Token = "0x40001A6")]
		None = 0,
		[Token(Token = "0x40001A7")]
		Download = 1,
		[Token(Token = "0x40001A8")]
		CheckDownload = 2,
		[Token(Token = "0x40001A9")]
		Website = 3,
		[Token(Token = "0x40001AA")]
		CheckWebsite = 4,
		[Token(Token = "0x40001AB")]
		CheckFile = 5,
		[Token(Token = "0x40001AC")]
		Done = 6
	}

	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x60")]
	private _00A3_0097_0094YtD _008F_009DWK_0080_008A;

	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x68")]
	private _00A3_00BD_00B8Mpb V_0095n_00BEº_008C;

	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x70")]
	private _00A3_00BD_00B8Mpb Z_00BF_0098_00BFA_00B0;

	[Token(Token = "0x600068C")]
	[Address(RVA = "0x7198D38", Offset = "0x7194D38", VA = "0x7198D38", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0x7199138", Offset = "0x7195138", VA = "0x7199138")]
	public _0091_0083_0084_0094_0085_0096(_0087LLP_0097_00B8 k_0098_00A9_007D_00BBP, _007DYXCc_008B c_008F_00AF_00B4_00B9_007E) : base(k_0098_00A9_007D_00BBP, c_008F_00AF_00B4_00B9_007E)
	{
		}

	[Token(Token = "0x600068E")]
	[Address(RVA = "0x719913C", Offset = "0x719513C", VA = "0x719913C", Slot = "6")]
	public override void WaitForAsyncComplete()
	{
	}
}
[Token(Token = "0x200009F")]
internal enum _00BD_00A9_005E_00A1_0085_008B
{
	[Token(Token = "0x40001FD")]
	Exception = -7,
	[Token(Token = "0x40001FE")]
	CacheNotFound = -6,
	[Token(Token = "0x40001FF")]
	InfoFileNotExisted = -5,
	[Token(Token = "0x4000200")]
	DataFileNotExisted = -4,
	[Token(Token = "0x4000201")]
	FileNotComplete = -3,
	[Token(Token = "0x4000202")]
	FileOverflow = -2,
	[Token(Token = "0x4000203")]
	FileCrcError = -1,
	[Token(Token = "0x4000204")]
	None = 0,
	[Token(Token = "0x4000205")]
	Succeed = 1
}
[Token(Token = "0x20000F6")]
internal class _007D_00A3_00B3_0089_009E_00AC : AsyncOperationBase
{
	[Token(Token = "0x20000F7")]
	private enum _0080r_0088r_005B_00A8
	{
		[Token(Token = "0x400037B")]
		None = 0,
		[Token(Token = "0x400037C")]
		DeserializeFileHeader = 1,
		[Token(Token = "0x400037D")]
		PrepareAssetList = 2,
		[Token(Token = "0x400037E")]
		DeserializeAssetList = 3,
		[Token(Token = "0x400037F")]
		PrepareBundleList = 4,
		[Token(Token = "0x4000380")]
		DeserializeBundleList = 5,
		[Token(Token = "0x4000381")]
		Done = 6
	}

	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x40")]
	private readonly BufferReader _00AB_0088º_0098m_00AD;

	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x48")]
	private int i_0083_0086xb_0097;

	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x4C")]
	private int Q_008F_007C_005E_00B9_0083;

	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x50")]
	private int _0082mUºfm;

	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0x54")]
	private _0080r_0088r_005B_00A8 _008F_009DWK_0080_008A;

	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x58")]
	private PackageManifest _00A7a_00AFaK_007B;

	[Token(Token = "0x170000A9")]
	public PackageManifest Manifest
	{
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x732B2A8", Offset = "0x73272A8", VA = "0x732B2A8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x732B280", Offset = "0x7327280", VA = "0x732B280")]
		private set
		{
			U_007E_00BF_00AE_00AE_005B(value);
		}
	}

	[Token(Token = "0x6000D02")]
	[Address(RVA = "0x732A128", Offset = "0x7326128", VA = "0x732A128")]
	public _007D_00A3_00B3_0089_009E_00AC(byte[] rºf_009Bk_0081, string V_00B2_00BEHJA)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x732A1E8", Offset = "0x73261E8", VA = "0x732A1E8")]
	public PackageManifest _0095I_00A6n_0090_0089()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x732A1F0", Offset = "0x73261F0", VA = "0x732A1F0")]
	public PackageManifest _0089_005B_008Cv_00A9s()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x732A1F8", Offset = "0x73261F8", VA = "0x732A1F8")]
	public PackageManifest _00B7Z_00AB_00AC_007E_00A2()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x732A200", Offset = "0x7326200", VA = "0x732A200")]
	private void _00A0y_0060_00A7_0098_008C(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x732A208", Offset = "0x7326208", VA = "0x732A208")]
	private void Y_00AE_0080eL_0091(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x732A210", Offset = "0x7326210", VA = "0x732A210")]
	private void Á_008E_0088_007Cem(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x732A218", Offset = "0x7326218", VA = "0x732A218")]
	public PackageManifest _00BE_005D_008E_00AD_0099_00A3()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x732A220", Offset = "0x7326220", VA = "0x732A220")]
	public PackageManifest _00A8_009B_009A_008Fz_0090()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x732A228", Offset = "0x7326228", VA = "0x732A228")]
	public PackageManifest _00BBt_0095_008BSI()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0x732A230", Offset = "0x7326230", VA = "0x732A230")]
	private void _00ABnT_0095A_00BC(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0x732A238", Offset = "0x7326238", VA = "0x732A238", Slot = "8")]
	internal override void _007EZ_00A7_008E_0095U()
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x732B1D4", Offset = "0x73271D4", VA = "0x732B1D4")]
	public PackageManifest Oi_00AD_00B3_0090_00AD()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0x732B1DC", Offset = "0x73271DC", VA = "0x732B1DC")]
	private void n_00BF_008B_00A2_0094p(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D10")]
	[Address(RVA = "0x732B1E4", Offset = "0x73271E4", VA = "0x732B1E4")]
	private void _007F_008CAfÁ_0083(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000D11")]
	[Address(RVA = "0x732B1EC", Offset = "0x73271EC", VA = "0x732B1EC", Slot = "7")]
	internal override void GL_008Ccx_00A1()
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D12")]
	[Address(RVA = "0x732B1F8", Offset = "0x73271F8", VA = "0x732B1F8")]
	private void _00AB_005Brºje(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D13")]
	[Address(RVA = "0x732B200", Offset = "0x7327200", VA = "0x732B200")]
	public PackageManifest GsDsRq()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D14")]
	[Address(RVA = "0x732B208", Offset = "0x7327208", VA = "0x732B208")]
	public PackageManifest _008C_007C_0087_009CI_007E()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D15")]
	[Address(RVA = "0x732B210", Offset = "0x7327210", VA = "0x732B210")]
	public PackageManifest _0096ÀpG_00A1_009E()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x732B218", Offset = "0x7327218", VA = "0x732B218")]
	public PackageManifest _008C_005EÀ_0060N_00AC()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D17")]
	[Address(RVA = "0x732B220", Offset = "0x7327220", VA = "0x732B220")]
	private void G_00AFª_0094_00B4O(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D18")]
	[Address(RVA = "0x732B228", Offset = "0x7327228", VA = "0x732B228")]
	private void _00B0iR_008EZh(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D19")]
	[Address(RVA = "0x732B230", Offset = "0x7327230", VA = "0x732B230")]
	private void qB_00A6_00ACqP(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0x732B238", Offset = "0x7327238", VA = "0x732B238")]
	private void _009EIm_005D_009A_00A3(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D1B")]
	[Address(RVA = "0x732B240", Offset = "0x7327240", VA = "0x732B240")]
	public PackageManifest _00A6kM_00A2at()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0x732B248", Offset = "0x7327248", VA = "0x732B248")]
	private void A_008D_00B3_0092_00AEG(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D1D")]
	[Address(RVA = "0x732B250", Offset = "0x7327250", VA = "0x732B250")]
	public PackageManifest Wq_007Cy_00A0G()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0x732B258", Offset = "0x7327258", VA = "0x732B258")]
	public PackageManifest vfk_0081_00B7_008F()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x732B260", Offset = "0x7327260", VA = "0x732B260")]
	private void t_0087c_008C_00AC_007B(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D20")]
	[Address(RVA = "0x732B268", Offset = "0x7327268", VA = "0x732B268")]
	private void _0090ÀUGn_0088(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x732B270", Offset = "0x7327270", VA = "0x732B270")]
	private void _00BC_00B6_00A5ª_00B6º(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D22")]
	[Address(RVA = "0x732B278", Offset = "0x7327278", VA = "0x732B278")]
	public PackageManifest Zµn_00A7g_009F()
	{
		return null;
	}

	[Token(Token = "0x6000D23")]
	[Address(RVA = "0x732B280", Offset = "0x7327280", VA = "0x732B280")]
	private void U_007E_00BF_00AE_00AE_005B(PackageManifest _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000D24")]
	[Address(RVA = "0x732B288", Offset = "0x7327288", VA = "0x732B288")]
	public PackageManifest s_0090_009C_0085_005D_0087()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D25")]
	[Address(RVA = "0x732B290", Offset = "0x7327290", VA = "0x732B290")]
	public PackageManifest ºQ_005E_00BE_00BB_00A2()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D26")]
	[Address(RVA = "0x732B298", Offset = "0x7327298", VA = "0x732B298")]
	public PackageManifest _00A7V_0083Yjª()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D27")]
	[Address(RVA = "0x732B2A0", Offset = "0x73272A0", VA = "0x732B2A0")]
	public PackageManifest _00A3_00A6_00B9FbY()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000D29")]
	[Address(RVA = "0x732B2B0", Offset = "0x73272B0", VA = "0x732B2B0")]
	public PackageManifest z_009EQBa_0082()
	{
		return null;
	}
}
