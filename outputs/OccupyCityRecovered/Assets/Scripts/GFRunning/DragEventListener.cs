using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x2000037")]
public class DragEventListener : UIBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IDropHandler, IPointerClickHandler
{
	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public EventListener.PointerDataDelegate onDrag;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public EventListener.PointerDataDelegate onBeginDrag;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EventListener.PointerDataDelegate onEndDrag;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public EventListener.PointerDataDelegate onDrop;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public EventListener.PointerDataDelegate onClick;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public object arg;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool En_0082ahj;

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x708B638", Offset = "0x7087638", VA = "0x708B638")]
	public static DragEventListener _009A_00ABYqU_00AB(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x708B700", Offset = "0x7087700", VA = "0x708B700")]
	public static DragEventListener _007Bz_008B_00A2l_007D(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x708B7C8", Offset = "0x70877C8", VA = "0x708B7C8")]
	public static DragEventListener _00BD_0089Am_0083e(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x708B890", Offset = "0x7087890", VA = "0x708B890", Slot = "22")]
	private void eR_0096OM_00A3(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x708B8C0", Offset = "0x70878C0", VA = "0x708B8C0", Slot = "23")]
	private void N_007BW_00B3Nµ(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x708B8F0", Offset = "0x70878F0", VA = "0x708B8F0")]
	public DragEventListener()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x708B8F8", Offset = "0x70878F8", VA = "0x708B8F8")]
	public static DragEventListener _00BB_0093ZwaQ(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x708B9C0", Offset = "0x70879C0", VA = "0x708B9C0", Slot = "21")]
	public void OnPointerClick(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x708B9E4", Offset = "0x70879E4", VA = "0x708B9E4", Slot = "19")]
void global::UnityEngine.EventSystems.IEndDragHandler.OnEndDrag(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x708BA10", Offset = "0x7087A10", VA = "0x708BA10", Slot = "24")]
	public void _00B4NFq_00A7_007D(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x708BA34", Offset = "0x7087A34", VA = "0x708BA34", Slot = "25")]
	private void aiZ_0085MO(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x708BA60", Offset = "0x7087A60", VA = "0x708BA60")]
	public static DragEventListener _00B1_0090ÀgP_0084(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x708BB28", Offset = "0x7087B28", VA = "0x708BB28")]
	public static DragEventListener _0085n_00B2_007Df_00AB(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x708BBF0", Offset = "0x7087BF0", VA = "0x708BBF0", Slot = "26")]
	private void _008BCA_005Dc_0094(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x708BC20", Offset = "0x7087C20", VA = "0x708BC20", Slot = "20")]
void global::UnityEngine.EventSystems.IDropHandler.OnDrop(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x708BC4C", Offset = "0x7087C4C", VA = "0x708BC4C", Slot = "17")]
void global::UnityEngine.EventSystems.IBeginDragHandler.OnBeginDrag(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x708BC7C", Offset = "0x7087C7C", VA = "0x708BC7C", Slot = "27")]
	private void _00BCª_009EePM(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x708BCA8", Offset = "0x7087CA8", VA = "0x708BCA8")]
	public static DragEventListener _007E_00B9Lw_0099k(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x708BD70", Offset = "0x7087D70", VA = "0x708BD70", Slot = "18")]
void global::UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x708BD8C", Offset = "0x7087D8C", VA = "0x708BD8C", Slot = "28")]
	private void _0087Á_007E_0097_0098N(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x708BDA8", Offset = "0x7087DA8", VA = "0x708BDA8", Slot = "29")]
	private void IT_0099_00A9e_00B9(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x708BDC4", Offset = "0x7087DC4", VA = "0x708BDC4", Slot = "30")]
	private void _009D_00A3_008C_00B2_0060_007B(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x708BDF0", Offset = "0x7087DF0", VA = "0x708BDF0", Slot = "31")]
	private void _007F_0084_00B0_0097_00BF_0087(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x708BE1C", Offset = "0x7087E1C", VA = "0x708BE1C", Slot = "32")]
	public void b_0087c_00BDNz(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x708BE40", Offset = "0x7087E40", VA = "0x708BE40", Slot = "33")]
	private void f_008FªvW_00B1(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x708BE5C", Offset = "0x7087E5C", VA = "0x708BE5C")]
	public static DragEventListener M_0092lhg_0090(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x708BF24", Offset = "0x7087F24", VA = "0x708BF24", Slot = "34")]
	private void _009Ft_00A8_00A1_00AD_00BC(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x708BF54", Offset = "0x7087F54", VA = "0x708BF54")]
	public static DragEventListener T_008Djd_0080_0088(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x708C01C", Offset = "0x708801C", VA = "0x708C01C", Slot = "35")]
	private void _0096T_00AC_00A4_00BCT(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x708C048", Offset = "0x7088048", VA = "0x708C048")]
	public static DragEventListener R_0092_0086M_00A1_0099(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x708C110", Offset = "0x7088110", VA = "0x708C110")]
	public static DragEventListener Get(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x708C1D8", Offset = "0x70881D8", VA = "0x708C1D8", Slot = "36")]
	private void B_0090ª_007C_007E_00A8(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x708C1F4", Offset = "0x70881F4", VA = "0x708C1F4")]
	public static DragEventListener _0081zÀ_00BDh_00A2(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x708C2BC", Offset = "0x70882BC", VA = "0x708C2BC", Slot = "37")]
	public void _00AF_0090_00AF_00B3_00A5_0086(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x708C2E0", Offset = "0x70882E0", VA = "0x708C2E0")]
	public static DragEventListener Mfo_009B_00AB_00AF(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x708C3A8", Offset = "0x70883A8", VA = "0x708C3A8", Slot = "38")]
	public void _0080_009C_00A6_005BMÀ(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x708C3CC", Offset = "0x70883CC", VA = "0x708C3CC", Slot = "39")]
	private void _008Fjy_0094G_007D(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x708C3FC", Offset = "0x70883FC", VA = "0x708C3FC", Slot = "40")]
	private void _008D_009A_0084s_0096_00B3(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x708C418", Offset = "0x7088418", VA = "0x708C418", Slot = "41")]
	private void _00A6µODWU(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x708C448", Offset = "0x7088448", VA = "0x708C448", Slot = "42")]
	public void u_00A0_00A2LS_00BB(PointerEventData _0091C_00B2_00AEe_00AD)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x708C46C", Offset = "0x708846C", VA = "0x708C46C")]
	public static DragEventListener _00B3_00B4_00AE_009B_00ADl(GameObject _0095_0083uµ_008Fd, [Optional] object _00A9_00A4_00B7M_0084k)
	{
		return null;
	}
}
