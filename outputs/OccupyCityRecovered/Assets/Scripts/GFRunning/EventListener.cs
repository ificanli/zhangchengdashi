using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x2000038")]
public class EventListener : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IUpdateSelectedHandler, ISelectHandler, IMoveHandler
{
	[Token(Token = "0x2000039")]
	public delegate void BaseDataDelegate(BaseEventData _0091C_00B2_00AEe_00AD);

	[Token(Token = "0x200003A")]
	public delegate void PointerDataDelegate(PointerEventData _0091C_00B2_00AEe_00AD);

	[Token(Token = "0x200003B")]
	public delegate void AxisDataDelegate(AxisEventData _0091C_00B2_00AEe_00AD);

	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x20")]
	public PointerDataDelegate onClick;

	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x28")]
	public PointerDataDelegate onDown;

	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x30")]
	public PointerDataDelegate onEnter;

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x38")]
	public PointerDataDelegate onExit;

	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x40")]
	public PointerDataDelegate onUp;

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x48")]
	public BaseDataDelegate onSelect;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x50")]
	public BaseDataDelegate onUpdateSelect;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x58")]
	public AxisDataDelegate onMove;

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x708C534", Offset = "0x7088534", VA = "0x708C534")]
	public static EventListener Oto_005BN_0094(Component _0095_0083uµ_008Fd)
	{
		return null;
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x708C610", Offset = "0x7088610", VA = "0x708C610", Slot = "12")]
	public void _008B_0098_007Ej_00B7f(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x708C62C", Offset = "0x708862C", VA = "0x708C62C", Slot = "13")]
	public void _00BF_00B6Yk_00B3_0087(AxisEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x708C648", Offset = "0x7088648", VA = "0x708C648", Slot = "14")]
	public void _00B8jHViW(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x708C664", Offset = "0x7088664", VA = "0x708C664", Slot = "15")]
	public void _00B2fY_00A4_00B7e(AxisEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x708C680", Offset = "0x7088680", VA = "0x708C680", Slot = "16")]
	public void MEYy_00AE_0088(BaseEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x708C69C", Offset = "0x708869C", VA = "0x708C69C", Slot = "10")]
	public void OnSelect(BaseEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x708C6B8", Offset = "0x70886B8", VA = "0x708C6B8", Slot = "11")]
	public void OnMove(AxisEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x708C6D4", Offset = "0x70886D4", VA = "0x708C6D4", Slot = "9")]
	public void OnUpdateSelected(BaseEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x708C6F0", Offset = "0x70886F0", VA = "0x708C6F0")]
	public static EventListener _0092IkBn_009D(Component _0095_0083uµ_008Fd)
	{
		return null;
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x708C7CC", Offset = "0x70887CC", VA = "0x708C7CC", Slot = "4")]
	public void OnPointerEnter(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x708C7E8", Offset = "0x70887E8", VA = "0x708C7E8", Slot = "17")]
	public void mLO_0098_00AD_0086(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x708C804", Offset = "0x7088804", VA = "0x708C804", Slot = "18")]
	public void _00A1_00BD_0098o_00A3_0083(BaseEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x708C820", Offset = "0x7088820", VA = "0x708C820", Slot = "19")]
	public void _00AF_0094z_0098_00BC_00AD(BaseEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x708C83C", Offset = "0x708883C", VA = "0x708C83C", Slot = "20")]
	public void _00A1_00A7_00B6_007D_008E_00A7(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x708C858", Offset = "0x7088858", VA = "0x708C858", Slot = "7")]
	public void OnPointerUp(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x708C874", Offset = "0x7088874", VA = "0x708C874", Slot = "21")]
	public void _0097_009FSYr_00A6(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x708C890", Offset = "0x7088890", VA = "0x708C890", Slot = "22")]
	public void _00A4_0092ª_0097OM(BaseEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x708C8AC", Offset = "0x70888AC", VA = "0x708C8AC")]
	public static EventListener Get(GameObject _0095_0083uµ_008Fd)
	{
		return null;
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x708C96C", Offset = "0x708896C", VA = "0x708C96C", Slot = "23")]
	public void _007C_00B7_0096_00AB_008B_00A2(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x708C988", Offset = "0x7088988", VA = "0x708C988", Slot = "24")]
	public void _009AÀ_00A9OÁ_007F(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x708C9A4", Offset = "0x70889A4", VA = "0x708C9A4", Slot = "8")]
	public void OnPointerClick(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x708C9C0", Offset = "0x70889C0", VA = "0x708C9C0", Slot = "25")]
	public void h_00A3_00A8dzj(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x708C9DC", Offset = "0x70889DC", VA = "0x708C9DC")]
	public static EventListener _0081zÀ_00BDh_00A2(GameObject _0095_0083uµ_008Fd)
	{
		return null;
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x708CA9C", Offset = "0x7088A9C", VA = "0x708CA9C", Slot = "26")]
	public void _0083_0087_00BEX_00BEa(AxisEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x708CAB8", Offset = "0x7088AB8", VA = "0x708CAB8", Slot = "5")]
	public void OnPointerExit(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x708CAD4", Offset = "0x7088AD4", VA = "0x708CAD4", Slot = "27")]
	public void NOS_00ACw_00B4(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x708CAF0", Offset = "0x7088AF0", VA = "0x708CAF0", Slot = "28")]
	public void ªmd_00B2_00B7º(BaseEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x708CB0C", Offset = "0x7088B0C", VA = "0x708CB0C", Slot = "29")]
	public void _009FJk_00BE_0094_00A2(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x708CB28", Offset = "0x7088B28", VA = "0x708CB28")]
	public static EventListener R_0092_0086M_00A1_0099(Component _0095_0083uµ_008Fd)
	{
		return null;
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x708CB44", Offset = "0x7088B44", VA = "0x708CB44")]
	public EventListener()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x708CB4C", Offset = "0x7088B4C", VA = "0x708CB4C", Slot = "30")]
	public void _00B3_008E_00BDt_0088_00A0(BaseEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x708C70C", Offset = "0x708870C", VA = "0x708C70C")]
	public static EventListener _00BD_0089Am_0083e(GameObject _0095_0083uµ_008Fd)
	{
		return null;
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x708CB68", Offset = "0x7088B68", VA = "0x708CB68", Slot = "31")]
	public void b_00A8eÁZ_00A5(BaseEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x708CB84", Offset = "0x7088B84", VA = "0x708CB84")]
	public static EventListener _00B1_0090ÀgP_0084(Component _0095_0083uµ_008Fd)
	{
		return null;
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x708CBA0", Offset = "0x7088BA0", VA = "0x708CBA0", Slot = "6")]
	public void OnPointerDown(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x708CBBC", Offset = "0x7088BBC", VA = "0x708CBBC")]
	public static EventListener Get(Component _0095_0083uµ_008Fd)
	{
		return null;
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x708CBD8", Offset = "0x7088BD8", VA = "0x708CBD8", Slot = "32")]
	public void _009F_008E_0081I_00B6_00AB(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x708CBF4", Offset = "0x7088BF4", VA = "0x708CBF4", Slot = "33")]
	public void _0081Rb_0085Âº(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x708CC10", Offset = "0x7088C10", VA = "0x708CC10", Slot = "34")]
	public void ªC_008ErQ_00AD(BaseEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x708C550", Offset = "0x7088550", VA = "0x708C550")]
	public static EventListener QdÁµ_00B2K(GameObject _0095_0083uµ_008Fd)
	{
		return null;
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x708CC2C", Offset = "0x7088C2C", VA = "0x708CC2C", Slot = "35")]
	public void b_0098_0091Hµ_0097(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x708CC48", Offset = "0x7088C48", VA = "0x708CC48", Slot = "36")]
	public void qu_00AC_008F_00A1_0090(BaseEventData _0091C_00B2_00AEe_00AD)
	{
	}
}
