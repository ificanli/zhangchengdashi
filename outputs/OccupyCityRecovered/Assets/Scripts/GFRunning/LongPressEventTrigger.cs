using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[Token(Token = "0x200003C")]
public class LongPressEventTrigger : UIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerExitHandler
{
	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x20")]
	[Tooltip("How long must pointer be down on this object to trigger a long press")]
	public float durationThreshold;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x24")]
	public float moveDisCancel;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent onLongPress;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x30")]
	private bool s_008AVstQ;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x31")]
	private bool _00AB_007C_009D_0084_00A2_0095;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x34")]
	private float _00B9g_008Ej_0095z;

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x708D024", Offset = "0x7089024", VA = "0x708D024", Slot = "20")]
	public void n_009CqbHh(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x708D030", Offset = "0x7089030", VA = "0x708D030")]
	public void s_00A8_0083_00A4_0083z(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x708D044", Offset = "0x7089044", VA = "0x708D044", Slot = "21")]
	public void _009Bvª_00AF_00A4S(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x708D100", Offset = "0x7089100", VA = "0x708D100")]
	private void _0083MND_008AM()
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x708D158", Offset = "0x7089158", VA = "0x708D158", Slot = "22")]
	public void _0097_005DUf_00A6_007C(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x708D160", Offset = "0x7089160", VA = "0x708D160", Slot = "23")]
	public void _0087_00BBH_007Ci_00A6(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x708D21C", Offset = "0x708921C", VA = "0x708D21C", Slot = "24")]
	public void _009FJk_00BE_0094_00A2(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x708D240", Offset = "0x7089240", VA = "0x708D240", Slot = "25")]
	public void V_0098_0088_00A2_00BFÀ(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x708D264", Offset = "0x7089264", VA = "0x708D264", Slot = "26")]
	public void c_00A3NbXB(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x708D270", Offset = "0x7089270", VA = "0x708D270")]
	private void Update()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x708D2CC", Offset = "0x70892CC", VA = "0x708D2CC")]
	public void OnPointerClick(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x708D2E0", Offset = "0x70892E0", VA = "0x708D2E0")]
	public void _007Bg_007F_00AC_007C_0081(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x708D2F8", Offset = "0x70892F8", VA = "0x708D2F8", Slot = "27")]
	public void p_00B2Y_008Fl_0093(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x708D3B8", Offset = "0x70893B8", VA = "0x708D3B8", Slot = "28")]
	public void _00A8z_00ACj_005DZ(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x708D474", Offset = "0x7089474", VA = "0x708D474", Slot = "29")]
	public void C_0098_00A0zz_00AC(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x708D534", Offset = "0x7089534", VA = "0x708D534")]
	public void z_00AB_00BCU_0090_0060(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x708D548", Offset = "0x7089548", VA = "0x708D548", Slot = "30")]
	public void _0095_00A1_00B3X_007EW(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x708D56C", Offset = "0x708956C", VA = "0x708D56C", Slot = "31")]
	public void _00AB_009D_008BnY_00AC(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x708D62C", Offset = "0x708962C", VA = "0x708D62C")]
	public LongPressEventTrigger()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x708D698", Offset = "0x7089698", VA = "0x708D698", Slot = "32")]
	public void µ_008B_0095_00BBQ_00BC(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x708D6A0", Offset = "0x70896A0", VA = "0x708D6A0")]
	public void _007Fed_00A8_00BB_00AF(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x708D6B8", Offset = "0x70896B8", VA = "0x708D6B8", Slot = "33")]
	public void _0095_00AD_00A4_00B1_00AB_008D(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x708D774", Offset = "0x7089774", VA = "0x708D774", Slot = "18")]
	public void OnPointerUp(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x708D830", Offset = "0x7089830", VA = "0x708D830", Slot = "19")]
	public void OnPointerExit(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x708D838", Offset = "0x7089838", VA = "0x708D838", Slot = "34")]
	public void _0094L_0060n_007B_005E(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x708D858", Offset = "0x7089858", VA = "0x708D858", Slot = "35")]
	public void n_0087_0089_0082OG(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x708D864", Offset = "0x7089864", VA = "0x708D864", Slot = "36")]
	public void d_00B8DiI_0082(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x708D888", Offset = "0x7089888", VA = "0x708D888")]
	public void _0099GPºH_009B(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x708D89C", Offset = "0x708989C", VA = "0x708D89C")]
	public void KUe_0094_00A3_00A7(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x708D8B0", Offset = "0x70898B0", VA = "0x708D8B0")]
	private void L_0091U_00ACT_00BD()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x708D90C", Offset = "0x708990C", VA = "0x708D90C")]
	public void b_0098_0091Hµ_0097(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x708D920", Offset = "0x7089920", VA = "0x708D920")]
	private void _0084Â_00BB_008BS_007D()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x708D978", Offset = "0x7089978", VA = "0x708D978", Slot = "37")]
	public void _007C_0097_00ACb_009Fp(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x708DA38", Offset = "0x7089A38", VA = "0x708DA38", Slot = "17")]
	public void OnPointerDown(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x708DA5C", Offset = "0x7089A5C", VA = "0x708DA5C", Slot = "38")]
	public void _00A5TZbKµ(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x708DB1C", Offset = "0x7089B1C", VA = "0x708DB1C")]
	public void a_0084_00BE_0097_007B_0085(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x708DB30", Offset = "0x7089B30", VA = "0x708DB30", Slot = "39")]
	public void d_0080e_009D_009C_0099(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x708DBEC", Offset = "0x7089BEC", VA = "0x708DBEC", Slot = "40")]
	public void L_00B1_0095fWª(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x708DBF8", Offset = "0x7089BF8", VA = "0x708DBF8", Slot = "41")]
	public void _00A8X_009F_007FV_007E(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x708DCB8", Offset = "0x7089CB8", VA = "0x708DCB8")]
	public void Q_0083ªªº_0099(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x708DCCC", Offset = "0x7089CCC", VA = "0x708DCCC", Slot = "42")]
	public void _008B_008Ap_005D_00A8_00BC(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x708DCD4", Offset = "0x7089CD4", VA = "0x708DCD4")]
	public void o_00A9hj_00B8_0096(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x708DCE8", Offset = "0x7089CE8", VA = "0x708DCE8")]
	private void _0090_0098IbZ_009A()
	{
	}
}
