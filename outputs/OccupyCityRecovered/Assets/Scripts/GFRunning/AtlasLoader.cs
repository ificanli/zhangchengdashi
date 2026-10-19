using System;
using GameFramework.Resources;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;

[Token(Token = "0x2000063")]
public class AtlasLoader : MonoBehaviour
{
	[Token(Token = "0x2000064")]
	private sealed class _0086_00A2_00A5_00B6_00ADt
	{
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x10")]
		public string tag;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x18")]
		public SpriteAtlas spriteAtlas;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x20")]
		public AtlasLoader _003C_003E4__this;

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x7097C28", Offset = "0x7093C28", VA = "0x7097C28")]
		public _0086_00A2_00A5_00B6_00ADt()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x709BEE0", Offset = "0x7097EE0", VA = "0x709BEE0")]
		internal void _00B0_00B3_00B8_007E_00BBP(ResourcesInfo Info)
		{
		}
	}

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x0")]
	public static bool IsDisabled;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x20")]
	[Header("在优化内存时，请设置为false，方便图集引用释放。为true时，图集引用会错乱")]
	public bool isAutoLoaderAtlas;

	[Token(Token = "0x400013C")]
	private const string _00B1_00B4_007B_00A6_0060F = "UIAtlas/";

	[Token(Token = "0x400013D")]
	private const string _00A4_00BC_0090Ooc = ".spriteatlas";

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x28")]
	private Action<SpriteAtlas> _009F_00A8drªP;

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x70975C0", Offset = "0x70935C0", VA = "0x70975C0")]
	private void LK_0097Sd_0091(ResourcesInfo D_0093ªºJ_0099)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x7097840", Offset = "0x7093840", VA = "0x7097840")]
	private void _0092_007D_008AUNY(string N_00BFA_007Ev_00A2, Action<SpriteAtlas> _00A3Y_0082I_00A7_00B4)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x709805C", Offset = "0x709405C", VA = "0x709805C")]
	private SpriteAtlas µW_009AC_0083_00B9(string j_0081xY_0088_0088)
	{
		return null;
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x7098064", Offset = "0x7094064", VA = "0x7098064")]
	private SpriteAtlas E_0081UW_0093_00BC(string j_0081xY_0088_0088)
	{
		return null;
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x709806C", Offset = "0x709406C", VA = "0x709806C")]
	private SpriteAtlas _0088la_00AE_008AF(string j_0081xY_0088_0088)
	{
		return null;
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x7098074", Offset = "0x7094074", VA = "0x7098074")]
	private void m_00BF_0084_00A2_00BB_005D(ResourcesInfo D_0093ªºJ_0099)
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x70982F4", Offset = "0x70942F4", VA = "0x70982F4")]
	private SpriteAtlas _0080_0080s_00A0_0088_00A9(string j_0081xY_0088_0088)
	{
		return null;
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x70982FC", Offset = "0x70942FC", VA = "0x70982FC")]
	private void _008BU_009B_009Cr_0083()
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x70983E4", Offset = "0x70943E4", VA = "0x70983E4")]
	private SpriteAtlas P_00B9_0083_005EwV(string j_0081xY_0088_0088, string _0092_00BB_00A9_0081DÀ)
	{
		return null;
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x70987F0", Offset = "0x70947F0", VA = "0x70987F0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x70988D8", Offset = "0x70948D8", VA = "0x70988D8")]
	private void _008DK_00ACkeA()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x70989C0", Offset = "0x70949C0", VA = "0x70989C0")]
	private SpriteAtlas _009BBAp_0098_0097(string j_0081xY_0088_0088)
	{
		return null;
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x70989C8", Offset = "0x70949C8", VA = "0x70989C8")]
	private SpriteAtlas _008A_007EU_0084_00BBª(string j_0081xY_0088_0088, string _0092_00BB_00A9_0081DÀ)
	{
		return null;
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x7098DCC", Offset = "0x7094DCC", VA = "0x7098DCC")]
	private void _00A6_00B1_00A5_0082_0092A(ResourcesInfo D_0093ªºJ_0099)
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x709904C", Offset = "0x709504C", VA = "0x709904C")]
	private SpriteAtlas _00A2ew_00BB_0094_00BB(string j_0081xY_0088_0088)
	{
		return null;
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x7097C30", Offset = "0x7093C30", VA = "0x7097C30")]
	private SpriteAtlas _008E_0085G_0081ª_009B(string j_0081xY_0088_0088, string _0092_00BB_00A9_0081DÀ)
	{
		return null;
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x7099054", Offset = "0x7095054", VA = "0x7099054")]
	private void _009F_009B_00BD_0094_0086R()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x709913C", Offset = "0x709513C", VA = "0x709913C")]
	private void WS_00AFXª_00B7()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x7099224", Offset = "0x7095224", VA = "0x7099224")]
	private void k_007ERSm_0083()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x709930C", Offset = "0x709530C", VA = "0x709930C")]
	private SpriteAtlas Y_0080_00B2_008Cµ_0086(string j_0081xY_0088_0088)
	{
		return null;
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x7099314", Offset = "0x7095314", VA = "0x7099314")]
	private SpriteAtlas ºB_00B9_009CM_00B7(string j_0081xY_0088_0088)
	{
		return null;
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x709931C", Offset = "0x709531C", VA = "0x709931C")]
	private SpriteAtlas sK_0098º_008C_0090(string j_0081xY_0088_0088)
	{
		return null;
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x7099324", Offset = "0x7095324", VA = "0x7099324")]
	private SpriteAtlas _00AC_00B3Â_008DZ_005E(string j_0081xY_0088_0088)
	{
		return null;
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x709932C", Offset = "0x709532C", VA = "0x709932C")]
	public AtlasLoader()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x709933C", Offset = "0x709533C", VA = "0x709933C")]
	private void u_0086_00A7d_00A7º(ResourcesInfo D_0093ªºJ_0099)
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x70995B8", Offset = "0x70955B8", VA = "0x70995B8")]
	private SpriteAtlas jw_0093fvc(string j_0081xY_0088_0088, string _0092_00BB_00A9_0081DÀ)
	{
		return null;
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x70999B8", Offset = "0x70959B8", VA = "0x70999B8")]
	private void gwV_0094_00BF_00AC()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x7099AA0", Offset = "0x7095AA0", VA = "0x7099AA0")]
	private void _008Bf_00AEXS_008C(ResourcesInfo D_0093ªºJ_0099)
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x7099D20", Offset = "0x7095D20", VA = "0x7099D20")]
	private void ª_00BDF_0090N_007E(string N_00BFA_007Ev_00A2, Action<SpriteAtlas> _00A3Y_0082I_00A7_00B4)
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x709A120", Offset = "0x7096120", VA = "0x709A120")]
	private void _0084FmMm_00AB()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x709A208", Offset = "0x7096208", VA = "0x709A208")]
	private void N_008Ddb_008EZ(ResourcesInfo D_0093ªºJ_0099)
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x709A488", Offset = "0x7096488", VA = "0x709A488")]
	private void _009E_0091_00A6AR_00B8()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x709A570", Offset = "0x7096570", VA = "0x709A570")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x709A658", Offset = "0x7096658", VA = "0x709A658")]
	private void _008Eªb_00AFs_00AC(ResourcesInfo D_0093ªºJ_0099)
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x709A8D8", Offset = "0x70968D8", VA = "0x709A8D8")]
	private void _007D_00BD_0095Hª_00A0(ResourcesInfo D_0093ªºJ_0099)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x709AB54", Offset = "0x7096B54", VA = "0x709AB54")]
	private SpriteAtlas _009BL_0083_00BF_009E_005B(string j_0081xY_0088_0088, string _0092_00BB_00A9_0081DÀ)
	{
		return null;
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x709AF68", Offset = "0x7096F68", VA = "0x709AF68")]
	private SpriteAtlas _00AB_0091_0094G_0090t(string j_0081xY_0088_0088, string _0092_00BB_00A9_0081DÀ)
	{
		return null;
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x709B370", Offset = "0x7097370", VA = "0x709B370")]
	private void oNnts_0089(string N_00BFA_007Ev_00A2, Action<SpriteAtlas> _00A3Y_0082I_00A7_00B4)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x709B770", Offset = "0x7097770", VA = "0x709B770")]
	private void _00BDpeGn_0096()
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x709B858", Offset = "0x7097858", VA = "0x709B858")]
	private SpriteAtlas _0098egUnj(string j_0081xY_0088_0088, string _0092_00BB_00A9_0081DÀ)
	{
		return null;
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x709BC58", Offset = "0x7097C58", VA = "0x709BC58")]
	private SpriteAtlas H_00B0_0080_0093fJ(string j_0081xY_0088_0088)
	{
		return null;
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x709BC60", Offset = "0x7097C60", VA = "0x709BC60")]
	private void _00BD_0085_00A4z_00A4i(ResourcesInfo D_0093ªºJ_0099)
	{
	}
}
