using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[Token(Token = "0x200003D")]
public class LongPressOrClickEventTrigger : UIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler, IPointerClickHandler
{
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x20")]
	[Tooltip("How long must pointer be down on this object to trigger a long press")]
	public float durationThreshold;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x24")]
	public float moveDisCancel;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent onLongPress;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent onClick;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x38")]
	private bool s_008AVstQ;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x39")]
	private bool _00AB_007C_009D_0084_00A2_0095;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x3C")]
	private float _00B9g_008Ej_0095z;

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x708DD40", Offset = "0x7089D40", VA = "0x708DD40", Slot = "21")]
	public void _00BDLPUºI(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x708DD48", Offset = "0x7089D48", VA = "0x708DD48", Slot = "22")]
	public void _0089_00A3_00ACr_0060_00AF(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x708DE08", Offset = "0x7089E08", VA = "0x708DE08", Slot = "23")]
	public void b_0098_0091Hµ_0097(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x708DE3C", Offset = "0x7089E3C", VA = "0x708DE3C", Slot = "24")]
	public void o_0092r_00ABLi(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x708DEF8", Offset = "0x7089EF8", VA = "0x708DEF8", Slot = "25")]
	public void _0082Wµ_00ACmÂ(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x708DF1C", Offset = "0x7089F1C", VA = "0x708DF1C", Slot = "17")]
	public void OnPointerDown(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x708DF40", Offset = "0x7089F40", VA = "0x708DF40", Slot = "26")]
	public void _0080ª_00B1_00B8_007Eº(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x708E000", Offset = "0x708A000", VA = "0x708E000")]
	private void m_00A4_008Dc_00A6_00B9()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x708E05C", Offset = "0x708A05C", VA = "0x708E05C", Slot = "27")]
	public void _009E_0099_00A6B_00B0_008A(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x708E11C", Offset = "0x708A11C", VA = "0x708E11C", Slot = "28")]
	public void _009FJk_00BE_0094_00A2(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x708E13C", Offset = "0x708A13C", VA = "0x708E13C")]
	private void _00A1wtib_00A2()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x708E194", Offset = "0x708A194", VA = "0x708E194", Slot = "29")]
	public void Z_0087_007D_0060GG(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x708E250", Offset = "0x708A250", VA = "0x708E250", Slot = "30")]
	public void V_0098_0088_00A2_00BFÀ(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x708E274", Offset = "0x708A274", VA = "0x708E274", Slot = "31")]
	public void fG_00A3À_007E_0082(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x708E334", Offset = "0x708A334", VA = "0x708E334", Slot = "32")]
	public void _00A1X_0092JW_0081(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x708E33C", Offset = "0x708A33C", VA = "0x708E33C")]
	private void _00A8_0091_0096_0098_0095_0091()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x708E398", Offset = "0x708A398", VA = "0x708E398", Slot = "33")]
	public void _00B4NFq_00A7_007D(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x708E3C8", Offset = "0x708A3C8", VA = "0x708E3C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x708E424", Offset = "0x708A424", VA = "0x708E424", Slot = "34")]
	public void p_00B2Y_008Fl_0093(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x708E4E4", Offset = "0x708A4E4", VA = "0x708E4E4")]
	public LongPressOrClickEventTrigger()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x708E568", Offset = "0x708A568", VA = "0x708E568", Slot = "35")]
	public void _00BE_00B9_007DI_005E_009D(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x708E58C", Offset = "0x708A58C", VA = "0x708E58C")]
	private void r_00A3_0083º_00AD_00B9()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x708E5E8", Offset = "0x708A5E8", VA = "0x708E5E8", Slot = "36")]
	public void _00BF_0097cY_0085R(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x708E6A4", Offset = "0x708A6A4", VA = "0x708E6A4", Slot = "37")]
	public void _009CCÀ_0087_0085_00A7(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x708E6D4", Offset = "0x708A6D4", VA = "0x708E6D4", Slot = "38")]
	public void _00B8jHViW(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x708E704", Offset = "0x708A704", VA = "0x708E704", Slot = "39")]
	public void b_0087c_00BDNz(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x708E738", Offset = "0x708A738", VA = "0x708E738", Slot = "40")]
	public void _0097_009FSYr_00A6(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x708E76C", Offset = "0x708A76C", VA = "0x708E76C")]
	private void _0081LY_00AF_0092b()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x708E7C8", Offset = "0x708A7C8", VA = "0x708E7C8", Slot = "41")]
	public void _00BD_0095qÂ_00A0_009E(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x708E7D4", Offset = "0x708A7D4", VA = "0x708E7D4", Slot = "42")]
	public void E_00A4_0091W_009Fa(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x708E808", Offset = "0x708A808", VA = "0x708E808", Slot = "19")]
	public void OnPointerExit(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x708E810", Offset = "0x708A810", VA = "0x708E810", Slot = "43")]
	public void o_009Ai_00ABº_007E(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x708E834", Offset = "0x708A834", VA = "0x708E834", Slot = "44")]
	public void mLO_0098_00AD_0086(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x708E8F4", Offset = "0x708A8F4", VA = "0x708E8F4", Slot = "45")]
	public void _0087_00BBH_007Ci_00A6(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x708E9B0", Offset = "0x708A9B0", VA = "0x708E9B0")]
	private void T_00B0_00B2d_0082U()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x708EA08", Offset = "0x708AA08", VA = "0x708EA08", Slot = "20")]
	public void OnPointerClick(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x708EA38", Offset = "0x708AA38", VA = "0x708EA38", Slot = "46")]
	public void µ_008B_0095_00BBQ_00BC(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x708EA40", Offset = "0x708AA40", VA = "0x708EA40", Slot = "47")]
	public void _0099GPºH_009B(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x708EA70", Offset = "0x708AA70", VA = "0x708EA70", Slot = "48")]
	public void _00AC_00B1_00AC_00A8N_0080(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x708EA90", Offset = "0x708AA90", VA = "0x708EA90", Slot = "49")]
	public void Y_0093_0099_0088uS(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x708EA98", Offset = "0x708AA98", VA = "0x708EA98", Slot = "50")]
	public void _008FAjQ_0099_00BD(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x708EABC", Offset = "0x708AABC", VA = "0x708EABC")]
	private void RV_009C_00B4_007C_00A5()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x708EB18", Offset = "0x708AB18", VA = "0x708EB18", Slot = "51")]
	public void v_00A2µc_00A1w(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x708EB20", Offset = "0x708AB20", VA = "0x708EB20", Slot = "52")]
	public void _0095_005B_007E_00B4M_00A0(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x708EB50", Offset = "0x708AB50", VA = "0x708EB50", Slot = "18")]
	public void OnPointerUp(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x708EC0C", Offset = "0x708AC0C", VA = "0x708EC0C", Slot = "53")]
	public void _00B8u_00BB_0093M_0080(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}
}
