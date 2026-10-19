using System.IO;
using System.Runtime.CompilerServices;
using GameFramework.Obfuscator;
using Il2CppDummyDll;

[Token(Token = "0x200002F")]
[Confuse]
public class BundleStream : Stream
{
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x28")]
	private int _007Drr_009E_00B9_008C;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x2C")]
	private byte _0096_009A_009F_0084AÂ;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x30")]
	private FileStream _007C_0097Nh_00BDI;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x38")]
	private int º_00A3_00BBig_00BD;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x3C")]
	private bool _00A6_008Da_00B3YD;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x40")]
	private readonly object _00AFdV_00B8_00A5_0097;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x48")]
	private long Qº_0085_0093_009Ed;

	[Token(Token = "0x17000025")]
	public bool HaveError
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x708219C", Offset = "0x707E19C", VA = "0x708219C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000026")]
	public override bool CanRead
	{
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x7080064", Offset = "0x707C064", VA = "0x7080064", Slot = "7")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000027")]
	public override bool CanSeek
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x7081AA8", Offset = "0x707DAA8", VA = "0x7081AA8", Slot = "8")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000028")]
	public override bool CanWrite
	{
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x7081C68", Offset = "0x707DC68", VA = "0x7081C68", Slot = "10")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000029")]
	public override long Length
	{
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x707FAD4", Offset = "0x707BAD4", VA = "0x707FAD4", Slot = "11")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700002A")]
	public override long Position
	{
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x707FDDC", Offset = "0x707BDDC", VA = "0x707FDDC", Slot = "12")]
		get
		{
			return default;
		}
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x707FCF8", Offset = "0x707BCF8", VA = "0x707FCF8", Slot = "13")]
		set
		{
		}
	}

	[SpecialName]
	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x707FEB0", Offset = "0x707BEB0", VA = "0x707FEB0")]
	public bool yc_00A7_00BFS_0088()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x707FF88", Offset = "0x707BF88", VA = "0x707FF88")]
	public bool _00AFz_009ERf_008C()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x708006C", Offset = "0x707C06C", VA = "0x708006C")]
	public bool _00A3_0088OVzT()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x7080144", Offset = "0x707C144", VA = "0x7080144")]
	public bool iE_00B9_0090_005B_009C()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x7080220", Offset = "0x707C220", VA = "0x7080220")]
	public bool D_00A4_00B7_008F_007B_00BF()
	{
		return default;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x70802FC", Offset = "0x707C2FC", VA = "0x70802FC", Slot = "34")]
	public override int Read(byte[] a_009Cy_00AE_00BDf, int e_00A7_0098_00BFD_0094, int _00BEHAM_0091_0089)
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x7080634", Offset = "0x707C634", VA = "0x7080634")]
	public bool _00B8_009FL_00BF_00A3_00BE()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x7080710", Offset = "0x707C710", VA = "0x7080710")]
	public bool _008FºjO_0084_00A3()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x70807F0", Offset = "0x707C7F0", VA = "0x70807F0")]
	public bool _009Du_00B9_0095_005Ba()
	{
		return default;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x70808C8", Offset = "0x707C8C8", VA = "0x70808C8", Slot = "33")]
	public override void SetLength(long _00A3_0092T_007E_00ABc)
	{
	}

	[SpecialName]
	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x70808CC", Offset = "0x707C8CC", VA = "0x70808CC")]
	public bool _009ED_0095_0087_0080_008B()
	{
		return default;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x70809A4", Offset = "0x707C9A4", VA = "0x70809A4", Slot = "37")]
	public override void Write(byte[] a_009Cy_00AE_00BDf, int e_00A7_0098_00BFD_0094, int _00BEHAM_0091_0089)
	{
	}

	[SpecialName]
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x70809A8", Offset = "0x707C9A8", VA = "0x70809A8")]
	public bool _00A1MP_00B6_0092_008E()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x7080A80", Offset = "0x707CA80", VA = "0x7080A80")]
	public bool _007F_009CaFn_00A2()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x7080B5C", Offset = "0x707CB5C", VA = "0x7080B5C")]
	public bool b_008Cy_00AF_009F_00A8()
	{
		return default;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x7080C38", Offset = "0x707CC38", VA = "0x7080C38", Slot = "32")]
	public override long Seek(long e_00A7_0098_00BFD_0094, SeekOrigin j_005E_00B1_00BE_0081w)
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x7080E58", Offset = "0x707CE58", VA = "0x7080E58")]
	public bool Kv_00A5b_00B0T()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x7080F30", Offset = "0x707CF30", VA = "0x7080F30")]
	public bool x_0083_00ACPª_00AB()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x7081008", Offset = "0x707D008", VA = "0x7081008")]
	public bool C_0087W_00A8_0092_00A6()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x70810E4", Offset = "0x707D0E4", VA = "0x70810E4")]
	public bool f_0095_007Ers_007C()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x70811BC", Offset = "0x707D1BC", VA = "0x70811BC")]
	public bool _008DY_0093_009CºD()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x7081298", Offset = "0x707D298", VA = "0x7081298")]
	public bool _007Fbjnjb()
	{
		return default;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x7081370", Offset = "0x707D370", VA = "0x7081370")]
	public BundleStream(int g_0097mKyÂ, byte ROC_00A8iF, int e_00A7_0098_00BFD_0094, string P_0084c_007DÀ_00A3)
	{
	}

	[SpecialName]
	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x7081580", Offset = "0x707D580", VA = "0x7081580")]
	public bool _009Ak_009D_007FBr()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x7081660", Offset = "0x707D660", VA = "0x7081660")]
	public bool Z_0082knnN()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000200")]
	[Address(RVA = "0x708173C", Offset = "0x707D73C", VA = "0x708173C")]
	public bool aMf_0097_0091_009A()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000201")]
	[Address(RVA = "0x7081818", Offset = "0x707D818", VA = "0x7081818")]
	public bool _00A4_00B6W_0097_0084d()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000202")]
	[Address(RVA = "0x70818F0", Offset = "0x707D8F0", VA = "0x70818F0")]
	public bool º_0098_00A7_00B6WJ()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000203")]
	[Address(RVA = "0x70819CC", Offset = "0x707D9CC", VA = "0x70819CC")]
	public bool E_0085oK_00B6r()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000205")]
	[Address(RVA = "0x7081AB0", Offset = "0x707DAB0", VA = "0x7081AB0")]
	public bool a_00ADC_008F_008EQ()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000206")]
	[Address(RVA = "0x7081B88", Offset = "0x707DB88", VA = "0x7081B88")]
	public bool _00B3Nk_005Do_007F()
	{
		return default;
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x7081C64", Offset = "0x707DC64", VA = "0x7081C64", Slot = "22")]
	public override void Flush()
	{
	}

	[SpecialName]
	[Token(Token = "0x6000209")]
	[Address(RVA = "0x7081C70", Offset = "0x707DC70", VA = "0x7081C70")]
	public bool _00B6mh_0085K_009F()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x600020A")]
	[Address(RVA = "0x7081D48", Offset = "0x707DD48", VA = "0x7081D48")]
	public bool Zn_0099_00AF_008A_0097()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x600020B")]
	[Address(RVA = "0x7081E24", Offset = "0x707DE24", VA = "0x7081E24")]
	public bool eVH_005E_00A1_0086()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x600020C")]
	[Address(RVA = "0x7081F00", Offset = "0x707DF00", VA = "0x7081F00")]
	public bool _00A2i_007E_005DI_008D()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x600020D")]
	[Address(RVA = "0x7081FE0", Offset = "0x707DFE0", VA = "0x7081FE0")]
	public bool qtªt_00AC_00BC()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x600020E")]
	[Address(RVA = "0x70820C0", Offset = "0x707E0C0", VA = "0x70820C0")]
	public bool hbg_0090Q_008B()
	{
		return default;
	}

	[SpecialName]
	[Token(Token = "0x6000210")]
	[Address(RVA = "0x7082278", Offset = "0x707E278", VA = "0x7082278")]
	public bool _0083uI_0099_0082_00B1()
	{
		return default;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x7082354", Offset = "0x707E354", VA = "0x7082354", Slot = "21")]
	protected override void Dispose(bool _008ASp_0084_009D_008C)
	{
	}
}
