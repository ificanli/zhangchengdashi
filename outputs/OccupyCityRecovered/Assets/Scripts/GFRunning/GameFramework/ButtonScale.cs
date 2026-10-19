using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GameFramework
{
	[Token(Token = "0x200041A")]
	public class ButtonScale : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Token(Token = "0x4001D85")]
		[FieldOffset(Offset = "0x20")]
		public Transform tweenTarget;

		[Token(Token = "0x4001D86")]
		[FieldOffset(Offset = "0x28")]
		public bool showHover;

		[Token(Token = "0x4001D87")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 P_00AC_008El_0095_0093;

		[Token(Token = "0x4001D88")]
		[FieldOffset(Offset = "0x38")]
		public float hoverDuration;

		[Token(Token = "0x4001D89")]
		[FieldOffset(Offset = "0x3C")]
		public bool showPressed;

		[Token(Token = "0x4001D8A")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 ÀX_007FÁgr;

		[Token(Token = "0x4001D8B")]
		[FieldOffset(Offset = "0x4C")]
		public float pressedDuration;

		[Token(Token = "0x4001D8C")]
		[FieldOffset(Offset = "0x50")]
		public bool IsRepeating;

		[Token(Token = "0x4001D8D")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 _00B3_00BETxk_005D;

		[Token(Token = "0x4001D8E")]
		[FieldOffset(Offset = "0x60")]
		private bool iI_00A5P_00A5_0094;

		[Token(Token = "0x4001D8F")]
		[FieldOffset(Offset = "0x61")]
		private bool _00B2_008B_007C_007F_00B0J;

		[Token(Token = "0x4001D90")]
		[FieldOffset(Offset = "0x62")]
		private bool ÁgN_0081_005DF;

		[Token(Token = "0x60063F3")]
		[Address(RVA = "0x721BAFC", Offset = "0x7217AFC", VA = "0x721BAFC", Slot = "8")]
		public void _00BF_0097cY_0085R(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x60063F4")]
		[Address(RVA = "0x721BC74", Offset = "0x7217C74", VA = "0x721BC74")]
		private void _0099_009CH_00A8SX()
		{
		}

		[Token(Token = "0x60063F5")]
		[Address(RVA = "0x721BD58", Offset = "0x7217D58", VA = "0x721BD58")]
		public void OnHold()
		{
		}

		[Token(Token = "0x60063F6")]
		[Address(RVA = "0x721BE4C", Offset = "0x7217E4C", VA = "0x721BE4C", Slot = "9")]
		public void _0087_00BBH_007Ci_00A6(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x60063F7")]
		[Address(RVA = "0x721BFC4", Offset = "0x7217FC4", VA = "0x721BFC4", Slot = "10")]
		public void _0080_009DQY_0082_00AD(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x60063F8")]
		[Address(RVA = "0x721C0BC", Offset = "0x72180BC", VA = "0x721C0BC")]
		private void _00A1r_009Ak_00A2_0085(bool s_00BCf_00AE_00A8K)
		{
		}

		[Token(Token = "0x60063F9")]
		[Address(RVA = "0x721C21C", Offset = "0x721821C", VA = "0x721C21C", Slot = "11")]
		public void xµ_00B9p_0082a(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x60063FA")]
		[Address(RVA = "0x721C224", Offset = "0x7218224", VA = "0x721C224")]
		public void _008A_00AE_0082D_00AD_00A4()
		{
		}

		[Token(Token = "0x60063FB")]
		[Address(RVA = "0x721C31C", Offset = "0x721831C", VA = "0x721C31C", Slot = "12")]
		public void X_00B6_008F_00A2Án(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x60063FC")]
		[Address(RVA = "0x721BB10", Offset = "0x7217B10", VA = "0x721BB10")]
		private void _00A9_00A5XOOT(bool _0094_00BC_00B6_009FL_00B4)
		{
		}

		[Token(Token = "0x60063FD")]
		[Address(RVA = "0x721C348", Offset = "0x7218348", VA = "0x721C348")]
		private void j_00BEG_00B2L_00B4()
		{
		}

		[Token(Token = "0x60063FE")]
		[Address(RVA = "0x721C3EC", Offset = "0x72183EC", VA = "0x721C3EC")]
		private void _007C_00AE_007B_0091Q_0088(bool _0094_00BC_00B6_009FL_00B4)
		{
		}

		[Token(Token = "0x60063FF")]
		[Address(RVA = "0x721C550", Offset = "0x7218550", VA = "0x721C550")]
		private void m_0091_0084_00B9V_00AF()
		{
		}

		[Token(Token = "0x6006400")]
		[Address(RVA = "0x721C61C", Offset = "0x721861C", VA = "0x721C61C")]
		private void IGZ_00B7_005E_00BC()
		{
		}

		[Token(Token = "0x6006401")]
		[Address(RVA = "0x721BE60", Offset = "0x7217E60", VA = "0x721BE60")]
		private void o_008F_00B7fKµ(bool _0094_00BC_00B6_009FL_00B4)
		{
		}

		[Token(Token = "0x6006402")]
		[Address(RVA = "0x721C6C0", Offset = "0x72186C0", VA = "0x721C6C0", Slot = "5")]
		public void OnPointerExit(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x6006403")]
		[Address(RVA = "0x721C780", Offset = "0x7218780", VA = "0x721C780")]
		private void eA_00A2_00A3C_00A3()
		{
		}

		[Token(Token = "0x6006404")]
		[Address(RVA = "0x721C84C", Offset = "0x721884C", VA = "0x721C84C")]
		public void _0096n_008D_008DM_009B()
		{
		}

		[Token(Token = "0x6006405")]
		[Address(RVA = "0x721C940", Offset = "0x7218940", VA = "0x721C940", Slot = "13")]
		public void IZW_007Euh(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x6006406")]
		[Address(RVA = "0x721C948", Offset = "0x7218948", VA = "0x721C948")]
		private void _0094t_0091_009BmO()
		{
		}

		[Token(Token = "0x6006407")]
		[Address(RVA = "0x721CA14", Offset = "0x7218A14", VA = "0x721CA14", Slot = "14")]
		public void _0082K_00B0V_00ADm(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x6006408")]
		[Address(RVA = "0x721CB0C", Offset = "0x7218B0C", VA = "0x721CB0C", Slot = "15")]
		public void _009F_00AD_0095_0085ey(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x6006409")]
		[Address(RVA = "0x721CC04", Offset = "0x7218C04", VA = "0x721CC04")]
		private void _0084g_00B4_0083_0086s()
		{
		}

		[Token(Token = "0x600640A")]
		[Address(RVA = "0x721CCE8", Offset = "0x7218CE8", VA = "0x721CCE8")]
		private void _00A7_00B9_007BbF_008D()
		{
		}

		[Token(Token = "0x600640B")]
		[Address(RVA = "0x721CCF0", Offset = "0x7218CF0", VA = "0x721CCF0", Slot = "16")]
		public void h_00BF_00B4o_0098_009F(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x600640C")]
		[Address(RVA = "0x721CD1C", Offset = "0x7218D1C", VA = "0x721CD1C")]
		public void _005DZDBN_007B()
		{
		}

		[Token(Token = "0x600640D")]
		[Address(RVA = "0x721CB38", Offset = "0x7218B38", VA = "0x721CB38")]
		private void o_00A4_0088jrt()
		{
		}

		[Token(Token = "0x600640E")]
		[Address(RVA = "0x721CE14", Offset = "0x7218E14", VA = "0x721CE14")]
		[CompilerGenerated]
		private void _00A2_0090_00BDfV_007B()
		{
		}

		[Token(Token = "0x600640F")]
		[Address(RVA = "0x721CE20", Offset = "0x7218E20", VA = "0x721CE20")]
		[CompilerGenerated]
		private void R_008DbÂÂh()
		{
		}

		[Token(Token = "0x6006410")]
		[Address(RVA = "0x721C174", Offset = "0x7218174", VA = "0x721C174")]
		private void Start()
		{
		}

		[Token(Token = "0x6006411")]
		[Address(RVA = "0x721CF04", Offset = "0x7218F04", VA = "0x721CF04")]
		private void _0098_005B_009F_008C_00B3_009F(bool _0094_00BC_00B6_009FL_00B4)
		{
		}

		[Token(Token = "0x6006412")]
		[Address(RVA = "0x721D068", Offset = "0x7219068", VA = "0x721D068")]
		public void _0092dª_008A_00B1m()
		{
		}

		[Token(Token = "0x6006413")]
		[Address(RVA = "0x721D15C", Offset = "0x721915C", VA = "0x721D15C", Slot = "7")]
		public void OnPointerUp(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x6006414")]
		[Address(RVA = "0x721C6C8", Offset = "0x72186C8", VA = "0x721C6C8")]
		private void B_00BDyMp_00BE(bool s_00BCf_00AE_00A8K)
		{
		}

		[Token(Token = "0x6006415")]
		[Address(RVA = "0x721D170", Offset = "0x7219170", VA = "0x721D170", Slot = "17")]
		public void _00B6_005Bº_008E_0084_0093(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x6006416")]
		[Address(RVA = "0x721D230", Offset = "0x7219230", VA = "0x721D230", Slot = "18")]
		public void _0095_00AD_00A4_00B1_00AB_008D(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x6006417")]
		[Address(RVA = "0x721D178", Offset = "0x7219178", VA = "0x721D178")]
		private void _00B0_0097R_00BEm_0091(bool s_00BCf_00AE_00A8K)
		{
		}

		[Token(Token = "0x6006418")]
		[Address(RVA = "0x721D244", Offset = "0x7219244", VA = "0x721D244", Slot = "19")]
		public void _0081Rb_0085Âº(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x6006419")]
		[Address(RVA = "0x721D258", Offset = "0x7219258", VA = "0x721D258")]
		public void l_00B9_00A0_0082fo()
		{
		}

		[Token(Token = "0x600641A")]
		[Address(RVA = "0x721D34C", Offset = "0x721934C", VA = "0x721D34C")]
		public ButtonScale()
		{
		}

		[Token(Token = "0x600641B")]
		[Address(RVA = "0x721BFF0", Offset = "0x7217FF0", VA = "0x721BFF0")]
		private void À_0094_00AC_00B2_00BF_00A2()
		{
		}

		[Token(Token = "0x600641C")]
		[Address(RVA = "0x721D378", Offset = "0x7219378", VA = "0x721D378")]
		private void Cc_008C_009FD_0087()
		{
		}

		[Token(Token = "0x600641D")]
		[Address(RVA = "0x721D45C", Offset = "0x721945C", VA = "0x721D45C", Slot = "20")]
		public void _00A8_00B4_00B1_00B8j_0099(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x600641E")]
		[Address(RVA = "0x721D488", Offset = "0x7219488", VA = "0x721D488", Slot = "6")]
		public void OnPointerDown(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x600641F")]
		[Address(RVA = "0x721D4B4", Offset = "0x72194B4", VA = "0x721D4B4", Slot = "21")]
		public void V_0098_0088_00A2_00BFÀ(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x6006420")]
		[Address(RVA = "0x721D4E0", Offset = "0x72194E0", VA = "0x721D4E0")]
		private void m_00B2_0086_0081_0098_0082()
		{
		}

		[Token(Token = "0x6006421")]
		[Address(RVA = "0x721CA40", Offset = "0x7218A40", VA = "0x721CA40")]
		private void HSq_008Fi_005B()
		{
		}

		[Token(Token = "0x6006422")]
		[Address(RVA = "0x721D5C4", Offset = "0x72195C4", VA = "0x721D5C4", Slot = "4")]
		public void OnPointerEnter(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}

		[Token(Token = "0x6006423")]
		[Address(RVA = "0x721D5CC", Offset = "0x72195CC", VA = "0x721D5CC", Slot = "22")]
		public void _008EQÁ_0098_0092_0086(PointerEventData _0091C_00B2_00AEe_00AD)
		{
		}
	}
}
