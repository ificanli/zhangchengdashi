using System.IO;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200007B")]
internal sealed class _00B2Oyq_005E_0093 : _0081_0090_00A9hh_00B4
{
	[Token(Token = "0x200007C")]
	private enum kG_0099_0090_008F_00A9
	{
		[Token(Token = "0x4000170")]
		None = 0,
		[Token(Token = "0x4000171")]
		Download = 1,
		[Token(Token = "0x4000172")]
		CheckDownload = 2,
		[Token(Token = "0x4000173")]
		Unpack = 3,
		[Token(Token = "0x4000174")]
		CheckUnpack = 4,
		[Token(Token = "0x4000175")]
		LoadBundleFile = 5,
		[Token(Token = "0x4000176")]
		LoadDeliveryFile = 6,
		[Token(Token = "0x4000177")]
		CheckLoadFile = 7,
		[Token(Token = "0x4000178")]
		Done = 8
	}

	[Token(Token = "0x4000167")]
	[FieldOffset(Offset = "0x60")]
	private kG_0099_0090_008F_00A9 _008F_009DWK_0080_008A;

	[Token(Token = "0x4000168")]
	[FieldOffset(Offset = "0x64")]
	private bool _005B_008FnG_00B4D;

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x65")]
	private bool fK_0089FX_00B1;

	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x68")]
	private _00A3_00BD_00B8Mpb Àng_00A3_008F_00BB;

	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x70")]
	private _00A3_00BD_00B8Mpb Z_00BF_0098_00BFA_00B0;

	[Token(Token = "0x400016C")]
	[FieldOffset(Offset = "0x78")]
	private AssetBundleCreateRequest fHy_00BF_00B0_0090;

	[Token(Token = "0x400016D")]
	[FieldOffset(Offset = "0x80")]
	private Stream _0099_005ET_00B1r_00B9;

	[Token(Token = "0x400016E")]
	[FieldOffset(Offset = "0x88")]
	private int _0088m_00AFM_007Eo;

	[Token(Token = "0x600060C")]
	[Address(RVA = "0x7191D68", Offset = "0x718DD68", VA = "0x7191D68")]
	private void rb_009C_0084µ_00A8()
	{
	}

	[Token(Token = "0x600060D")]
	[Address(RVA = "0x7191D98", Offset = "0x718DD98", VA = "0x7191D98")]
	private void p_00B8_00A9ÀUO()
	{
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0x7191DC8", Offset = "0x718DDC8", VA = "0x7191DC8")]
	private void _0091_0098_0093_00A8_00AF_009A()
	{
	}

	[Token(Token = "0x600060F")]
	[Address(RVA = "0x7191DF8", Offset = "0x718DDF8", VA = "0x7191DF8")]
	private void _00A1Dl_0095_0060_007C()
	{
	}

	[Token(Token = "0x6000610")]
	[Address(RVA = "0x7191E28", Offset = "0x718DE28", VA = "0x7191E28")]
	private void _00ACÁ_00BFjD_0088()
	{
	}

	[Token(Token = "0x6000611")]
	[Address(RVA = "0x7191E58", Offset = "0x718DE58", VA = "0x7191E58")]
	private void _0096_00A0Y_007F_005B_0097()
	{
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x7191E88", Offset = "0x718DE88", VA = "0x7191E88")]
	private void _005E_00AD_00B7Q_0093h()
	{
	}

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x7191EB8", Offset = "0x718DEB8", VA = "0x7191EB8")]
	private void EQ_00AF_0091_00A5A()
	{
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x7191EE8", Offset = "0x718DEE8", VA = "0x7191EE8")]
	private void ntMd_008C_009E()
	{
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x7191F18", Offset = "0x718DF18", VA = "0x7191F18")]
	private void _0085EI_00AFÀv()
	{
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x7191F48", Offset = "0x718DF48", VA = "0x7191F48")]
	private void bV_0081_005B_0097_009B()
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x7191F78", Offset = "0x718DF78", VA = "0x7191F78")]
	private void _008D_00A0_0093µaT()
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x7191FA8", Offset = "0x718DFA8", VA = "0x7191FA8")]
	private void v_0081I_0091_007D_009E()
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x7191FD8", Offset = "0x718DFD8", VA = "0x7191FD8")]
	private void _00A1A_009A_00ABO_0088()
	{
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x7192008", Offset = "0x718E008", VA = "0x7192008")]
	private void _008A_00A9_007D_00B8xB()
	{
	}

	[Token(Token = "0x600061B")]
	[Address(RVA = "0x7192038", Offset = "0x718E038", VA = "0x7192038")]
	private void À_00A2d_008F_008CÂ()
	{
	}

	[Token(Token = "0x600061C")]
	[Address(RVA = "0x7192068", Offset = "0x718E068", VA = "0x7192068")]
	private void te_0085_009DA_00BF()
	{
	}

	[Token(Token = "0x600061D")]
	[Address(RVA = "0x7192098", Offset = "0x718E098", VA = "0x7192098")]
	private void BpD_00B0_00A1Z()
	{
	}

	[Token(Token = "0x600061E")]
	[Address(RVA = "0x71920C8", Offset = "0x718E0C8", VA = "0x71920C8")]
	private void _0083_00A6_0095_00A5_0087_0090()
	{
	}

	[Token(Token = "0x600061F")]
	[Address(RVA = "0x71920F8", Offset = "0x718E0F8", VA = "0x71920F8")]
	private void Ar_00A9Xx_00B3()
	{
	}

	[Token(Token = "0x6000620")]
	[Address(RVA = "0x7192128", Offset = "0x718E128", VA = "0x7192128")]
	private void sºQ_008F_00B1_007E()
	{
	}

	[Token(Token = "0x6000621")]
	[Address(RVA = "0x7192158", Offset = "0x718E158", VA = "0x7192158")]
	private void kª_008A_0095fW()
	{
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x7192188", Offset = "0x718E188", VA = "0x7192188")]
	private void _00A5ªgKGh()
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x71921B8", Offset = "0x718E1B8", VA = "0x71921B8")]
	private void _007E_00A4scre()
	{
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x71921E8", Offset = "0x718E1E8", VA = "0x71921E8")]
	private void _00BDk_00B9_0097_00A1t()
	{
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x7192218", Offset = "0x718E218", VA = "0x7192218")]
	private void _0080_00B7_005D_00BEµy()
	{
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x7192248", Offset = "0x718E248", VA = "0x7192248", Slot = "5")]
	public override void Destroy()
	{
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0x7192448", Offset = "0x718E448", VA = "0x7192448")]
	private void _0091Xm_008DG_007B()
	{
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0x7192478", Offset = "0x718E478", VA = "0x7192478")]
	private void ly_00A9À_00B3O()
	{
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0x71924A8", Offset = "0x718E4A8", VA = "0x71924A8", Slot = "6")]
	public override void WaitForAsyncComplete()
	{
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0x719266C", Offset = "0x718E66C", VA = "0x719266C")]
	private void ph_008D_0083Jº()
	{
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0x719269C", Offset = "0x718E69C", VA = "0x719269C")]
	private void _0085º_0089_0082_00B7_008A()
	{
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x71926CC", Offset = "0x718E6CC", VA = "0x71926CC")]
	private void tb_00BC_00BE_0093_008A()
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x71926FC", Offset = "0x718E6FC", VA = "0x71926FC")]
	private void _008AGZwJÂ()
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x719272C", Offset = "0x718E72C", VA = "0x719272C")]
	private void _0085_00B8_00B7_0097_00BB_0088()
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x719275C", Offset = "0x718E75C", VA = "0x719275C")]
	private void _00BFX_00B9j_00B3_00A2()
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x719278C", Offset = "0x718E78C", VA = "0x719278C", Slot = "4")]
	public override void Update()
	{
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x7193908", Offset = "0x718F908", VA = "0x7193908")]
	private void _0060J_0093_007E_009Eu()
	{
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x7193938", Offset = "0x718F938", VA = "0x7193938")]
	private void G_0096nodS()
	{
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x7193968", Offset = "0x718F968", VA = "0x7193968")]
	private void _007B_00ABJ_009E_0083i()
	{
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x7193998", Offset = "0x718F998", VA = "0x7193998")]
	private void v_0097_00A0_0084LK()
	{
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x71939C8", Offset = "0x718F9C8", VA = "0x71939C8")]
	public _00B2Oyq_005E_0093(_0087LLP_0097_00B8 k_0098_00A9_007D_00BBP, _007DYXCc_008B c_008F_00AF_00B4_00B9_007E) : base(k_0098_00A9_007D_00BBP, c_008F_00AF_00B4_00B9_007E)
	{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED _00B2Oyq_005E_0093..ctor RVA=0x71939C8 Token=0x06000635; original base constructor arguments recovered; remaining original constructor body pending.");
		}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0x7193A70", Offset = "0x718FA70", VA = "0x7193A70")]
	private void _00A3_0093p_00AB_009D_0093()
	{
	}

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x7193AA0", Offset = "0x718FAA0", VA = "0x7193AA0")]
	private void aqPN_0089_008D()
	{
	}
}
