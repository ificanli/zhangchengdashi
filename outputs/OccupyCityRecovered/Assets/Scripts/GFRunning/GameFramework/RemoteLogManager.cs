using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x2000411")]
	internal class RemoteLogManager : MonoBehaviour
	{
		[Token(Token = "0x2000412")]
		private class _00BER_00B1_00BF_0093a
		{
			[Token(Token = "0x4001D6C")]
			[FieldOffset(Offset = "0x10")]
			public string code;

			[Token(Token = "0x4001D6D")]
			[FieldOffset(Offset = "0x18")]
			public string msg;

			[Token(Token = "0x6006374")]
			[Address(RVA = "0x7213B2C", Offset = "0x720FB2C", VA = "0x7213B2C")]
			public _00BER_00B1_00BF_0093a()
			{
			}
		}

		[Token(Token = "0x2000413")]
		private sealed class PY_0098QQ_00B7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001D6E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001D6F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x1700117C")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6006378")]
				[Address(RVA = "0x7213B94", Offset = "0x720FB94", VA = "0x7213B94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700117D")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600637A")]
				[Address(RVA = "0x7213BD4", Offset = "0x720FBD4", VA = "0x7213BD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6006375")]
			[Address(RVA = "0x7213B34", Offset = "0x720FB34", VA = "0x7213B34")]
			[DebuggerHidden]
			public PY_0098QQ_00B7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6006376")]
			[Address(RVA = "0x7213B5C", Offset = "0x720FB5C", VA = "0x7213B5C", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6006377")]
			[Address(RVA = "0x7213B60", Offset = "0x720FB60", VA = "0x7213B60", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6006378")]
			[Address(RVA = "0x7213B94", Offset = "0x720FB94", VA = "0x7213B94", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6006379")]
			[Address(RVA = "0x7213B9C", Offset = "0x720FB9C", VA = "0x7213B9C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600637A")]
			[Address(RVA = "0x7213BD4", Offset = "0x720FBD4", VA = "0x7213BD4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4001D56")]
		[FieldOffset(Offset = "0x0")]
		private static RemoteLogManager O_00BEªA_00BE_007C;

		[Token(Token = "0x4001D57")]
		[FieldOffset(Offset = "0x20")]
		private bool pE_00B4_00B2kz;

		[Token(Token = "0x4001D58")]
		private const string _0088Sµ_00BC_009AE = "Unity:";

		[Token(Token = "0x4001D59")]
		[FieldOffset(Offset = "0x28")]
		private string N_009F_00BF_0094_00B9S;

		[Token(Token = "0x4001D5A")]
		[FieldOffset(Offset = "0x30")]
		private string q_008Fg_007D_0097_0086;

		[Token(Token = "0x4001D5B")]
		[FieldOffset(Offset = "0x38")]
		private string IHzi_007BI;

		[Token(Token = "0x4001D5C")]
		[FieldOffset(Offset = "0x40")]
		private string ª_00B8cºK_0094;

		[Token(Token = "0x4001D5D")]
		[FieldOffset(Offset = "0x48")]
		private Queue<MsgLogData> a_009B_0099A_0098_00A3;

		[Token(Token = "0x4001D5E")]
		[FieldOffset(Offset = "0x50")]
		private List<MsgLogData> U_007B_0083_008C_00ACP;

		[Token(Token = "0x4001D5F")]
		[FieldOffset(Offset = "0x58")]
		private Queue<string> T_00BC_005B_00A6K_00A8;

		[Token(Token = "0x4001D60")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool IsActive;

		[Token(Token = "0x4001D61")]
		[FieldOffset(Offset = "0x68")]
		private StringBuilder s_008A_0091ho_0087;

		[Token(Token = "0x4001D62")]
		[FieldOffset(Offset = "0x70")]
		private int _0084i_00B1_0081_00BEm;

		[Token(Token = "0x4001D63")]
		private const int _00AFEBgd_009B = 50;

		[Token(Token = "0x4001D64")]
		[FieldOffset(Offset = "0x74")]
		private float _008Al_00B9_00A5_00A9_00BD;

		[Token(Token = "0x4001D65")]
		[FieldOffset(Offset = "0x78")]
		private float B_008E_00B2AXc;

		[Token(Token = "0x4001D66")]
		private const int _005D_007C_00B3_007Cx_0083 = 20;

		[Token(Token = "0x4001D67")]
		[FieldOffset(Offset = "0x7C")]
		private int _0086_00A3l_009F_00BEÁ;

		[Token(Token = "0x4001D68")]
		private const int PÀ_007E_0089ª_00BF = 20;

		[Token(Token = "0x4001D69")]
		[FieldOffset(Offset = "0x80")]
		private bool _007C_00AD_00A5ELe;

		[Token(Token = "0x4001D6A")]
		[FieldOffset(Offset = "0x84")]
		private float _0082_00A6I_00A5_0060Á;

		[Token(Token = "0x4001D6B")]
		[FieldOffset(Offset = "0x88")]
		private bool _007E_0083º_0094Cq;

		[Token(Token = "0x1700117B")]
		public static RemoteLogManager Instance
		{
			[Token(Token = "0x6006356")]
			[Address(RVA = "0x7211B68", Offset = "0x720DB68", VA = "0x7211B68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006343")]
		[Address(RVA = "0x7210370", Offset = "0x720C370", VA = "0x7210370")]
		private void _008A_0080M_00ACa_0083(string _008C_00A8_00A1cf_00A6)
		{
		}

		[Token(Token = "0x6006344")]
		[Address(RVA = "0x72104D4", Offset = "0x720C4D4", VA = "0x72104D4")]
		internal void _007Dye_0080_00BCa()
		{
		}

		[Token(Token = "0x6006345")]
		[Address(RVA = "0x7210660", Offset = "0x720C660", VA = "0x7210660")]
		private void WJ_00ABJs_0093()
		{
		}

		[SpecialName]
		[Token(Token = "0x6006346")]
		[Address(RVA = "0x7210938", Offset = "0x720C938", VA = "0x7210938")]
		public static RemoteLogManager _008D_008A_0088_008Eoc()
		{
			return null;
		}

		[Token(Token = "0x6006347")]
		[Address(RVA = "0x7210B14", Offset = "0x720CB14", VA = "0x7210B14")]
		private void Awake()
		{
		}

		[Token(Token = "0x6006348")]
		[Address(RVA = "0x7210CAC", Offset = "0x720CCAC", VA = "0x7210CAC")]
		private string _00A0_0089VtO_0097()
		{
			return null;
		}

		[Token(Token = "0x6006349")]
		[Address(RVA = "0x7210E2C", Offset = "0x720CE2C", VA = "0x7210E2C")]
		private void µ_009ByBQ_00A9()
		{
		}

		[Token(Token = "0x600634A")]
		[Address(RVA = "0x7211104", Offset = "0x720D104", VA = "0x7211104")]
		private void y_00B1_00BFo_00A2_009D(string iD_00B7m_0094À)
		{
		}

		[Token(Token = "0x600634B")]
		[Address(RVA = "0x7211188", Offset = "0x720D188", VA = "0x7211188")]
		private void _0080c_0097L_007D_008B(string iD_00B7m_0094À)
		{
		}

		[SpecialName]
		[Token(Token = "0x600634C")]
		[Address(RVA = "0x72111A8", Offset = "0x720D1A8", VA = "0x72111A8")]
		public static RemoteLogManager Fs_0087_007F_00A1_00A6()
		{
			return null;
		}

		[Token(Token = "0x600634D")]
		[Address(RVA = "0x7211384", Offset = "0x720D384", VA = "0x7211384")]
		private IEnumerator _007B_00A0J_00B1f_0082(string iD_00B7m_0094À)
		{
			return null;
		}

		[Token(Token = "0x600634E")]
		[Address(RVA = "0x72113DC", Offset = "0x720D3DC", VA = "0x72113DC")]
		private void CF_00B8I_009As(string ºº_008BJl_009F, string _00B6_0086_008D_00A3KZ, LogType _007BgpR_00A0V)
		{
		}

		[Token(Token = "0x600634F")]
		[Address(RVA = "0x7211554", Offset = "0x720D554", VA = "0x7211554")]
		private IEnumerator T_00B8YP_00B9Á(string iD_00B7m_0094À)
		{
			return null;
		}

		[Token(Token = "0x6006350")]
		[Address(RVA = "0x72115AC", Offset = "0x720D5AC", VA = "0x72115AC")]
		private void S_007E_007Fp_00BB_009C(string iD_00B7m_0094À)
		{
		}

		[Token(Token = "0x6006351")]
		[Address(RVA = "0x72115D8", Offset = "0x720D5D8", VA = "0x72115D8")]
		private void g_0095_00AC_00B3_009FB(string _008C_00A8_00A1cf_00A6)
		{
		}

		[Token(Token = "0x6006352")]
		[Address(RVA = "0x721173C", Offset = "0x720D73C", VA = "0x721173C")]
		private void _0095ª_00B0O_0096_009C()
		{
		}

		[Token(Token = "0x6006353")]
		[Address(RVA = "0x72117D0", Offset = "0x720D7D0", VA = "0x72117D0")]
		private void T_009FE_007E_0082_008A()
		{
		}

		[Token(Token = "0x6006354")]
		[Address(RVA = "0x7211968", Offset = "0x720D968", VA = "0x7211968")]
		private void IY_0087_00A3l_00AE()
		{
		}

		[Token(Token = "0x6006355")]
		[Address(RVA = "0x72119F8", Offset = "0x720D9F8", VA = "0x72119F8")]
		internal void bv_0084P_0098_0081()
		{
		}

		[Token(Token = "0x6006357")]
		[Address(RVA = "0x7211D30", Offset = "0x720DD30", VA = "0x7211D30")]
		private void _007C_0089_009D_00A4o_0090(string _008C_00A8_00A1cf_00A6)
		{
		}

		[Token(Token = "0x6006358")]
		[Address(RVA = "0x7211E90", Offset = "0x720DE90", VA = "0x7211E90")]
		private void _005EA_0097_0098_00B6_007F()
		{
		}

		[Token(Token = "0x6006359")]
		[Address(RVA = "0x7211F20", Offset = "0x720DF20", VA = "0x7211F20")]
		private void _008C_007B_0093_007FG_0087()
		{
		}

		[Token(Token = "0x600635A")]
		[Address(RVA = "0x72108D4", Offset = "0x720C8D4", VA = "0x72108D4")]
		private void _00A3rp_00B2Jg()
		{
		}

		[Token(Token = "0x600635B")]
		[Address(RVA = "0x7212230", Offset = "0x720E230", VA = "0x7212230")]
		public RemoteLogManager()
		{
		}

		[Token(Token = "0x600635C")]
		[Address(RVA = "0x7212298", Offset = "0x720E298", VA = "0x7212298")]
		private void G_0097Á_00A0b_008A()
		{
		}

		[Token(Token = "0x600635D")]
		[Address(RVA = "0x7211130", Offset = "0x720D130", VA = "0x7211130")]
		[IteratorStateMachine(typeof(PY_0098QQ_00B7))]
		private IEnumerator _00BC_00A2_007E_00AF_0098_0084(string iD_00B7m_0094À)
		{
			return null;
		}

		[Token(Token = "0x600635E")]
		[Address(RVA = "0x7212430", Offset = "0x720E430", VA = "0x7212430")]
		private void mÂ_00A6GA_008D(string _008C_00A8_00A1cf_00A6)
		{
		}

		[SpecialName]
		[Token(Token = "0x600635F")]
		[Address(RVA = "0x7212590", Offset = "0x720E590", VA = "0x7212590")]
		public static RemoteLogManager _00B7_0093V_00B8_005D_007E()
		{
			return null;
		}

		[Token(Token = "0x6006360")]
		[Address(RVA = "0x721276C", Offset = "0x720E76C", VA = "0x721276C")]
		internal void _0086_0097_00BD_00A3p_009A()
		{
		}

		[Token(Token = "0x6006361")]
		[Address(RVA = "0x72128E0", Offset = "0x720E8E0", VA = "0x72128E0")]
		private string _007Fª_007E_00BBO_00A3()
		{
			return null;
		}

		[Token(Token = "0x6006362")]
		[Address(RVA = "0x72110A0", Offset = "0x720D0A0", VA = "0x72110A0")]
		private void _00ACb_0094Q_00AC_00B3()
		{
		}

		[Token(Token = "0x6006363")]
		[Address(RVA = "0x7212A60", Offset = "0x720EA60", VA = "0x7212A60")]
		private void _009A_00B2_008A_0088C_00A0()
		{
		}

		[Token(Token = "0x6006364")]
		[Address(RVA = "0x7212BA0", Offset = "0x720EBA0", VA = "0x7212BA0")]
		internal void _008Fv_007D_00BE_00A5R()
		{
		}

		[SpecialName]
		[Token(Token = "0x6006365")]
		[Address(RVA = "0x7212D18", Offset = "0x720ED18", VA = "0x7212D18")]
		public static RemoteLogManager X_008D_007EO_00AE_00A7()
		{
			return null;
		}

		[Token(Token = "0x6006366")]
		[Address(RVA = "0x7212EF4", Offset = "0x720EEF4", VA = "0x7212EF4")]
		private void w_007B_009D_0097lN(string iD_00B7m_0094À)
		{
		}

		[Token(Token = "0x6006367")]
		[Address(RVA = "0x7212090", Offset = "0x720E090", VA = "0x7212090")]
		private string K_0093_008B_0087OÁ()
		{
			return null;
		}

		[Token(Token = "0x6006368")]
		[Address(RVA = "0x7212F20", Offset = "0x720EF20", VA = "0x7212F20")]
		private void WW_0094_009C_0081_007D()
		{
		}

		[Token(Token = "0x6006369")]
		[Address(RVA = "0x7212FB0", Offset = "0x720EFB0", VA = "0x7212FB0")]
		private void _0082iO_008ES_007C(string iD_00B7m_0094À)
		{
		}

		[Token(Token = "0x600636A")]
		[Address(RVA = "0x7212FDC", Offset = "0x720EFDC", VA = "0x7212FDC")]
		private void _00A8_0096Ghr_00B7()
		{
		}

		[Token(Token = "0x600636B")]
		[Address(RVA = "0x7213254", Offset = "0x720F254", VA = "0x7213254")]
		private void _00AC_00B7H_005Bqb()
		{
		}

		[Token(Token = "0x600636C")]
		[Address(RVA = "0x72134D4", Offset = "0x720F4D4", VA = "0x72134D4")]
		private void _0091_009A_00A4_00A8_0089J(string iD_00B7m_0094À)
		{
		}

		[Token(Token = "0x600636D")]
		[Address(RVA = "0x7212064", Offset = "0x720E064", VA = "0x7212064")]
		private void _0080YzÁL_008A(string iD_00B7m_0094À)
		{
		}

		[Token(Token = "0x600636E")]
		[Address(RVA = "0x7213500", Offset = "0x720F500", VA = "0x7213500")]
		private void _00A2_009AZ_00B2_007C_005B(string ºº_008BJl_009F, string _00B6_0086_008D_00A3KZ, LogType _007BgpR_00A0V)
		{
		}

		[Token(Token = "0x600636F")]
		[Address(RVA = "0x7213678", Offset = "0x720F678", VA = "0x7213678")]
		private void D_0093_00BFH_0085C()
		{
		}

		[Token(Token = "0x6006370")]
		[Address(RVA = "0x7213974", Offset = "0x720F974", VA = "0x7213974")]
		private void dª_0091_0098_0085_009A(string _008C_00A8_00A1cf_00A6)
		{
		}

		[Token(Token = "0x6006371")]
		[Address(RVA = "0x7213AD4", Offset = "0x720FAD4", VA = "0x7213AD4")]
		private IEnumerator _0098_0082_00A7_008AJ_00B9(string iD_00B7m_0094À)
		{
			return null;
		}

		[Token(Token = "0x6006372")]
		[Address(RVA = "0x7212210", Offset = "0x720E210", VA = "0x7212210")]
		private void _00B2i_0096_008Ec_0086(string iD_00B7m_0094À)
		{
		}

		[Token(Token = "0x6006373")]
		[Address(RVA = "0x7213910", Offset = "0x720F910", VA = "0x7213910")]
		private void A_00B3dIWS()
		{
		}
	}
}
