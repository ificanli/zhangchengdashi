using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YooAsset;

[Token(Token = "0x20000DD")]
internal class _007DYXCc_008B
{
	[Token(Token = "0x20000DE")]
	public enum ELoadMode
	{
		[Token(Token = "0x4000313")]
		None = 0,
		[Token(Token = "0x4000314")]
		LoadFromDelivery = 1,
		[Token(Token = "0x4000315")]
		LoadFromStreaming = 2,
		[Token(Token = "0x4000316")]
		LoadFromCache = 3,
		[Token(Token = "0x4000317")]
		LoadFromRemote = 4,
		[Token(Token = "0x4000318")]
		LoadFromEditor = 5
	}

	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x10")]
	public readonly PackageBundle Bundle;

	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x18")]
	public readonly ELoadMode LoadMode;

	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x20")]
	private string c_00A7w_00B4_00A1_00A4;

	[Token(Token = "0x400030E")]
	[FieldOffset(Offset = "0x28")]
	private string T_00ADgE_009F_00BB;

	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x30")]
	private string m_00BD_0094_00ACtY;

	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0x38")]
	private ulong _0093µy_008A_008Bp;

	[Token(Token = "0x4000311")]
	[FieldOffset(Offset = "0x40")]
	public string[] IncludeAssets;

	[Token(Token = "0x1700009A")]
	public string RemoteMainURL
	{
		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x7322940", Offset = "0x731E940", VA = "0x7322940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x73228BC", Offset = "0x731E8BC", VA = "0x73228BC")]
		private set
		{
			sx_00ABU_0096_0060(value);
		}
	}

	[Token(Token = "0x1700009B")]
	public string RemoteFallbackURL
	{
		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x7322824", Offset = "0x731E824", VA = "0x7322824")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x7322B08", Offset = "0x731EB08", VA = "0x7322B08")]
		private set
		{
			_00BCP_00B9_00B4_0092_00AF(value);
		}
	}

	[Token(Token = "0x1700009C")]
	public string DeliveryFilePath
	{
		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x7322A54", Offset = "0x731EA54", VA = "0x7322A54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x7322814", Offset = "0x731E814", VA = "0x7322814")]
		private set
		{
			_0084_007E_008Eº_0092_0094(value);
		}
	}

	[Token(Token = "0x1700009D")]
	public ulong DeliveryFileOffset
	{
		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x7322B00", Offset = "0x731EB00", VA = "0x7322B00")]
		[CompilerGenerated]
		get
		{
			return default;
		}
		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x7322A64", Offset = "0x731EA64", VA = "0x7322A64")]
		private set
		{
			PN_005B_00BB_0093_007D(value);
		}
	}

	[SpecialName]
	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x7322764", Offset = "0x731E764", VA = "0x7322764")]
	public string _0094hZ_00A4_0096X()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000C1E")]
	[Address(RVA = "0x732276C", Offset = "0x731E76C", VA = "0x732276C")]
	private void _0092Oh_0060Dx(string _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0x7322774", Offset = "0x731E774", VA = "0x7322774")]
	private void Á_0082IÁ_00AC_00A9(string _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C20")]
	[Address(RVA = "0x732277C", Offset = "0x731E77C", VA = "0x732277C")]
	public ulong _00A5_0080k_005B_00A8_005D()
	{
		return default;
	}

	[Token(Token = "0x6000C21")]
	[Address(RVA = "0x7322784", Offset = "0x731E784", VA = "0x7322784")]
	public _007DYXCc_008B(PackageBundle _00B4_00BC_00B1eU_009A, ELoadMode _009A_00B2_009E_007Dee, string _00ABr_009F_0087_0099_00B9, ulong Foe_0085_0093_007B)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C22")]
	[Address(RVA = "0x732280C", Offset = "0x731E80C", VA = "0x732280C")]
	private void e_00AC_00B4_00BEbY(ulong _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x7322814", Offset = "0x731E814", VA = "0x7322814")]
	private void _0084_007E_008Eº_0092_0094(string _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x732281C", Offset = "0x731E81C", VA = "0x732281C")]
	private void Cl_0088_00AF_00AB_00A3(string _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x732282C", Offset = "0x731E82C", VA = "0x732282C")]
	private void OJR_00AEM_00A1(string _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C27")]
	[Address(RVA = "0x7322834", Offset = "0x731E834", VA = "0x7322834")]
	public string _00ACuI_007E_00BC_00B7()
	{
		return null;
	}

	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x732283C", Offset = "0x731E83C", VA = "0x732283C")]
	private _007DYXCc_008B()
	{
	}

	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x7322844", Offset = "0x731E844", VA = "0x7322844")]
	public _007DYXCc_008B(PackageBundle _00B4_00BC_00B1eU_009A, ELoadMode _009A_00B2_009E_007Dee)
	{
	}

	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x73228BC", Offset = "0x731E8BC", VA = "0x73228BC")]
	private void sx_00ABU_0096_0060(string _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0x73228C4", Offset = "0x731E8C4", VA = "0x73228C4")]
	public string X_0094_00A6X_00A9u()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x73228CC", Offset = "0x731E8CC", VA = "0x73228CC")]
	public string _005B_008C_00A4ºs_00B4()
	{
		return null;
	}

	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x73228D4", Offset = "0x731E8D4", VA = "0x73228D4")]
	public static bool j_0097z_0093_00B8z(string _0093_0094p_005E_00AFl)
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0x7322928", Offset = "0x731E928", VA = "0x7322928")]
	private void _007D_007DYQHl(ulong _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C2F")]
	[Address(RVA = "0x7322930", Offset = "0x731E930", VA = "0x7322930")]
	private void _008Ehc_00B0_0094O(ulong _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C30")]
	[Address(RVA = "0x7322938", Offset = "0x731E938", VA = "0x7322938")]
	private void _00A6_007C_0099sKH(string _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000C32")]
	[Address(RVA = "0x7322948", Offset = "0x731E948", VA = "0x7322948")]
	public static bool f_009D_0090_0086w_00AC(string _0093_0094p_005E_00AFl)
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000C33")]
	[Address(RVA = "0x732299C", Offset = "0x731E99C", VA = "0x732299C")]
	public string _009EE_00B6a_00ADd()
	{
		return null;
	}

	[Token(Token = "0x6000C34")]
	[Address(RVA = "0x73229A4", Offset = "0x731E9A4", VA = "0x73229A4")]
	public _007DYXCc_008B(PackageBundle _00B4_00BC_00B1eU_009A, ELoadMode _009A_00B2_009E_007Dee, string _00BEN_0095O_00A1_0081, string N_0083_00A5_00AF_009Cv)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C35")]
	[Address(RVA = "0x7322A2C", Offset = "0x731EA2C", VA = "0x7322A2C")]
	public string _007D_0097_00A1nYz()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000C36")]
	[Address(RVA = "0x7322A34", Offset = "0x731EA34", VA = "0x7322A34")]
	public string _0093f_007C_005BZ_008D()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000C37")]
	[Address(RVA = "0x7322A3C", Offset = "0x731EA3C", VA = "0x7322A3C")]
	private void _00AD_00A1_009FK_00B8_005D(string _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C38")]
	[Address(RVA = "0x7322A44", Offset = "0x731EA44", VA = "0x7322A44")]
	private void _0088_0090e_00A1xr(string _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C39")]
	[Address(RVA = "0x7322A4C", Offset = "0x731EA4C", VA = "0x7322A4C")]
	public string _0082Dw_00A5F_00B7()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0x7322A5C", Offset = "0x731EA5C", VA = "0x7322A5C")]
	private void w_00AEN_00B9_00A0u(ulong _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0x7322A64", Offset = "0x731EA64", VA = "0x7322A64")]
	private void PN_005B_00BB_0093_007D(ulong _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0x7322A6C", Offset = "0x731EA6C", VA = "0x7322A6C")]
	private void _0096dS_0088d_00A1(string _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0x7322A74", Offset = "0x731EA74", VA = "0x7322A74")]
	public static bool _0094OIPc_005B(string _0093_0094p_005E_00AFl)
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x7322AC8", Offset = "0x731EAC8", VA = "0x7322AC8")]
	public ulong _00A9F_0082_00B6_00A4_007D()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x7322AD0", Offset = "0x731EAD0", VA = "0x7322AD0")]
	public ulong _0088_00A6oFyG()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x7322AD8", Offset = "0x731EAD8", VA = "0x7322AD8")]
	private void _00B4_00BCaX_0087_0081(ulong _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x7322AE0", Offset = "0x731EAE0", VA = "0x7322AE0")]
	public string _0089b_00A1_008E_00B9_0093()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000C43")]
	[Address(RVA = "0x7322AE8", Offset = "0x731EAE8", VA = "0x7322AE8")]
	public ulong Q_00B4W_0096s_0092()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000C44")]
	[Address(RVA = "0x7322AF0", Offset = "0x731EAF0", VA = "0x7322AF0")]
	private void _00ADT_00A9oÀh(ulong _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x6000C45")]
	[Address(RVA = "0x7322AF8", Offset = "0x731EAF8", VA = "0x7322AF8")]
	public ulong xKª_0084_0094_00A7()
	{
		return default;
	}

	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x7322B08", Offset = "0x731EB08", VA = "0x7322B08")]
	private void _00BCP_00B9_00B4_0092_00AF(string _00A3_0092T_007E_00ABc)
	{
	}

	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x7322B10", Offset = "0x731EB10", VA = "0x7322B10")]
	public static bool IsBuildinJarFile(string _0093_0094p_005E_00AFl)
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x7322B64", Offset = "0x731EB64", VA = "0x7322B64")]
	public string Á_008E_00AFÁD_007B()
	{
		return null;
	}

	[SpecialName]
	[Token(Token = "0x6000C4A")]
	[Address(RVA = "0x7322B6C", Offset = "0x731EB6C", VA = "0x7322B6C")]
	public ulong ºH_008EB_00A8_0060()
	{
		return default;
	}

	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x7322B74", Offset = "0x731EB74", VA = "0x7322B74")]
	public static bool _008E_0086fÀ_00A8p(string _0093_0094p_005E_00AFl)
	{
		return default;
	}
}
