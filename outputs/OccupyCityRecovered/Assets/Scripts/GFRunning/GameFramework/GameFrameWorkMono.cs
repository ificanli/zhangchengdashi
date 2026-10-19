using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DBTSDK;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;

namespace GameFramework
{
	[Token(Token = "0x2000334")]
	public class GameFrameWorkMono : MonoBehaviour
	{
		[Token(Token = "0x2000335")]
		internal enum _00ABH_0092_0098A_00A0
		{
			[Token(Token = "0x400199C")]
			Normal = 0,
			[Token(Token = "0x400199D")]
			Pause = 1
		}

		[Token(Token = "0x2000336")]
		private enum _0080_00AE_0080FDu
		{
			[Token(Token = "0x400199F")]
			AppFocus = 0,
			[Token(Token = "0x40019A0")]
			AppPause = 1,
			[Token(Token = "0x40019A1")]
			ActiveTriggerPause = 2
		}

		[Token(Token = "0x2000337")]
		private sealed class A_0096qÀ_00A2_008E : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40019A2")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40019A3")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40019A4")]
			[FieldOffset(Offset = "0x20")]
			public string path;

			[Token(Token = "0x40019A5")]
			[FieldOffset(Offset = "0x28")]
			public GameFrameWorkMono _003C_003E4__this;

			[Token(Token = "0x40019A6")]
			[FieldOffset(Offset = "0x30")]
			private UnityWebRequest _003Crequest_003E5__2;

			[Token(Token = "0x170010C4")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005624")]
				[Address(RVA = "0x715EA54", Offset = "0x715AA54", VA = "0x715EA54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170010C5")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005626")]
				[Address(RVA = "0x715EA94", Offset = "0x715AA94", VA = "0x715EA94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005621")]
			[Address(RVA = "0x715CB08", Offset = "0x7158B08", VA = "0x715CB08")]
			[DebuggerHidden]
			public A_0096qÀ_00A2_008E(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005622")]
			[Address(RVA = "0x715E6E4", Offset = "0x715A6E4", VA = "0x715E6E4", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005623")]
			[Address(RVA = "0x715E6E8", Offset = "0x715A6E8", VA = "0x715E6E8", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005624")]
			[Address(RVA = "0x715EA54", Offset = "0x715AA54", VA = "0x715EA54", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005625")]
			[Address(RVA = "0x715EA5C", Offset = "0x715AA5C", VA = "0x715EA5C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005626")]
			[Address(RVA = "0x715EA94", Offset = "0x715AA94", VA = "0x715EA94", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4001992")]
		[FieldOffset(Offset = "0x20")]
		internal _00ABH_0092_0098A_00A0 q_009E_009E_00B8_00B6_007D;

		[Token(Token = "0x4001993")]
		[FieldOffset(Offset = "0x24")]
		private _0080_00AE_0080FDu _00B7_00B1_0082i_00B1_0089;

		[Token(Token = "0x4001994")]
		[FieldOffset(Offset = "0x0")]
		private static GameFrameWorkMono _0060_0083_00A4_00A6_0095t;

		[Token(Token = "0x4001995")]
		[FieldOffset(Offset = "0x28")]
		internal bool _0092Y_00B1_0082Á_00A5;

		[Token(Token = "0x4001996")]
		[FieldOffset(Offset = "0x8")]
		internal static int _00ADC_00A5_0095_0083_005B;

		[Token(Token = "0x4001997")]
		private const string z_00A7g_008C_00B3T = "net_status_game_statistic_filter";

		[Token(Token = "0x4001998")]
		[FieldOffset(Offset = "0x29")]
		internal bool ªK_00A2_008E_005E_005B;

		[Token(Token = "0x4001999")]
		[FieldOffset(Offset = "0x30")]
		private DomainData N_00A7_009E_00BD_0081s;

		[Token(Token = "0x400199A")]
		[FieldOffset(Offset = "0x38")]
		private bool s_008C_00B9ZP_007E;

		[Token(Token = "0x170010C3")]
		internal static GameFrameWorkMono LL_0090_0087X_00B0
		{
			[Token(Token = "0x600560D")]
			[Address(RVA = "0x715A368", Offset = "0x7156368", VA = "0x715A368")]
			get
			{
				return wN_00A6So_0098();
			}
		}

		[Token(Token = "0x60055F3")]
		[Address(RVA = "0x715C10C", Offset = "0x715810C", VA = "0x715C10C")]
		internal void µ_0080dxªr()
		{
		}

		[Token(Token = "0x60055F4")]
		[Address(RVA = "0x715C228", Offset = "0x7158228", VA = "0x715C228")]
		internal void _00AB_00ACp_00B9zA()
		{
		}

		[Token(Token = "0x60055F5")]
		[Address(RVA = "0x715C4FC", Offset = "0x71584FC", VA = "0x715C4FC")]
		private void _00B9p_00A6_005BDc()
		{
		}

		[Token(Token = "0x60055F6")]
		[Address(RVA = "0x715C500", Offset = "0x7158500", VA = "0x715C500")]
		private void OnApplicationPause(bool _008EsRFxT)
		{
		}

		[Token(Token = "0x60055F7")]
		[Address(RVA = "0x715C22C", Offset = "0x715822C", VA = "0x715C22C")]
		private void _00B4L_0081_007ClI()
		{
		}

		[Token(Token = "0x60055F8")]
		[Address(RVA = "0x715C704", Offset = "0x7158704", VA = "0x715C704")]
		internal void _0084e_009BVq_00A9()
		{
		}

		[Token(Token = "0x60055F9")]
		[Address(RVA = "0x715A828", Offset = "0x7156828", VA = "0x715A828")]
		internal void q_00A9S_00B8_009E_008E()
		{
		}

		[Token(Token = "0x60055FA")]
		[Address(RVA = "0x715C708", Offset = "0x7158708", VA = "0x715C708")]
		internal void _007C_00A1a_0094_00BE_009B(bool _0086_0060_0097Cv_007F)
		{
		}

		[Token(Token = "0x60055FB")]
		[Address(RVA = "0x715C95C", Offset = "0x715895C", VA = "0x715C95C")]
		private void ÁX_008EZ_009Bz()
		{
		}

		[Token(Token = "0x60055FC")]
		[Address(RVA = "0x715CA9C", Offset = "0x7158A9C", VA = "0x715CA9C")]
		[IteratorStateMachine(typeof(A_0096qÀ_00A2_008E))]
		private IEnumerator Cm_00A4iºa(string P_0084c_007DÀ_00A3)
		{
			return null;
		}

		[Token(Token = "0x60055FD")]
		[Address(RVA = "0x715CB30", Offset = "0x7158B30", VA = "0x715CB30")]
		private void Start()
		{
		}

		[Token(Token = "0x60055FE")]
		[Address(RVA = "0x715CB34", Offset = "0x7158B34", VA = "0x715CB34")]
		public static void Lvx_008F_0091p()
		{
		}

		[Token(Token = "0x60055FF")]
		[Address(RVA = "0x715C518", Offset = "0x7158518", VA = "0x715C518")]
		private void _0088yj_00AD_00BE_00AD(bool _0086_0060_0097Cv_007F, _0080_00AE_0080FDu RÀ_0060_00A4_00B8_005E)
		{
		}

		[Token(Token = "0x6005600")]
		[Address(RVA = "0x715CDF0", Offset = "0x7158DF0", VA = "0x715CDF0")]
		internal string Y_008D_008C_00BBy_00B8(string l_00B6µ_00A2_0099_009A, DType c_00BDÁ_0084_0086_00B9, string _00AF_007Bt_00A8_008Cp = "")
		{
			return null;
		}

		[Token(Token = "0x6005601")]
		[Address(RVA = "0x715C720", Offset = "0x7158720", VA = "0x715C720")]
		private void _00BE_0092_00BB_0087Ml(bool _0086_0060_0097Cv_007F, _0080_00AE_0080FDu RÀ_0060_00A4_00B8_005E)
		{
		}

		[Token(Token = "0x6005602")]
		[Address(RVA = "0x715D1D4", Offset = "0x71591D4", VA = "0x715D1D4")]
		private void _0085_00A4zWSe()
		{
		}

		[Token(Token = "0x6005603")]
		[Address(RVA = "0x715D1D8", Offset = "0x71591D8", VA = "0x715D1D8")]
		internal string pNs_0095ÁK(string l_00B6µ_00A2_0099_009A, DType c_00BDÁ_0084_0086_00B9, string _00AF_007Bt_00A8_008Cp = "")
		{
			return null;
		}

		[Token(Token = "0x6005604")]
		[Address(RVA = "0x715D480", Offset = "0x7159480", VA = "0x715D480")]
		private void _007F_00B4_00A7eFp(bool _0086_0060_0097Cv_007F, _0080_00AE_0080FDu RÀ_0060_00A4_00B8_005E)
		{
		}

		[Token(Token = "0x6005605")]
		[Address(RVA = "0x715D6A0", Offset = "0x71596A0", VA = "0x715D6A0")]
		internal void _00A4wWª_00B0G()
		{
		}

		[Token(Token = "0x6005606")]
		[Address(RVA = "0x715D74C", Offset = "0x715974C", VA = "0x715D74C")]
		private void BtC_00BFr_00A9(bool _0084_0060ÁjW_00BB)
		{
		}

		[Token(Token = "0x6005607")]
		[Address(RVA = "0x715D098", Offset = "0x7159098", VA = "0x715D098")]
		private void _007Df_0094_00BF_007CÂ()
		{
		}

		[Token(Token = "0x6005608")]
		[Address(RVA = "0x715D7B0", Offset = "0x71597B0", VA = "0x715D7B0")]
		public static void Init()
		{
		}

		[Token(Token = "0x6005609")]
		[Address(RVA = "0x715D928", Offset = "0x7159928", VA = "0x715D928")]
		private IEnumerator Rj_009Emhk(string P_0084c_007DÀ_00A3)
		{
			return null;
		}

		[Token(Token = "0x600560A")]
		[Address(RVA = "0x715D998", Offset = "0x7159998", VA = "0x715D998")]
		private void OnApplicationFocus(bool _0084_0060ÁjW_00BB)
		{
		}

		[Token(Token = "0x600560B")]
		[Address(RVA = "0x715D9E0", Offset = "0x71599E0", VA = "0x715D9E0")]
		internal void ª_0092PA_00A4i()
		{
		}

		[Token(Token = "0x600560C")]
		[Address(RVA = "0x715A4C4", Offset = "0x71564C4", VA = "0x715A4C4")]
		internal void _0090Wxv_00ACÂ(bool _0086_0060_0097Cv_007F)
		{
		}

		[Token(Token = "0x600560D")]
		[Address(RVA = "0x715A368", Offset = "0x7156368", VA = "0x715A368")]
		internal static GameFrameWorkMono wN_00A6So_0098()
		{
			return null;
		}

		[Token(Token = "0x600560E")]
		[Address(RVA = "0x715D9E4", Offset = "0x71599E4", VA = "0x715D9E4")]
		internal void _008Cmp_00BF_00B2_00B7(bool _0086_0060_0097Cv_007F)
		{
		}

		[Token(Token = "0x600560F")]
		[Address(RVA = "0x715CCB0", Offset = "0x7158CB0", VA = "0x715CCB0")]
		private void _00AC_0084_00B4Z_009A_00B7()
		{
		}

		[Token(Token = "0x6005610")]
		[Address(RVA = "0x715DC4C", Offset = "0x7159C4C", VA = "0x715DC4C")]
		internal void _0060_007F_007Ec_007Bc(bool _0086_0060_0097Cv_007F)
		{
		}

		[Token(Token = "0x6005611")]
		[Address(RVA = "0x715DC64", Offset = "0x7159C64", VA = "0x715DC64")]
		internal string _00AExZ_00AE_0087_00A7(string l_00B6µ_00A2_0099_009A, DType c_00BDÁ_0084_0086_00B9, string _00AF_007Bt_00A8_008Cp = "")
		{
			return null;
		}

		[Token(Token = "0x6005612")]
		[Address(RVA = "0x715DF04", Offset = "0x7159F04", VA = "0x715DF04")]
		private void h_0099_00B4NJ_008C()
		{
		}

		[Token(Token = "0x6005613")]
		[Address(RVA = "0x715D9FC", Offset = "0x71599FC", VA = "0x715D9FC")]
		private void N_00AFg_0099_00A1_0093(bool _0086_0060_0097Cv_007F, _0080_00AE_0080FDu RÀ_0060_00A4_00B8_005E)
		{
		}

		[Token(Token = "0x6005614")]
		[Address(RVA = "0x715DF08", Offset = "0x7159F08", VA = "0x715DF08")]
		public static void _00A9_00B6Z_009F_007C_0082()
		{
		}

		[Token(Token = "0x6005615")]
		[Address(RVA = "0x715D790", Offset = "0x7159790", VA = "0x715D790")]
		private void AªNV_0088_0087(bool Àk_0099ª_009DI)
		{
		}

		[Token(Token = "0x6005616")]
		[Address(RVA = "0x715E164", Offset = "0x715A164", VA = "0x715E164")]
		private void _00B2_0083_00BC_005D_00B3_009B(bool _0084_0060ÁjW_00BB)
		{
		}

		[Token(Token = "0x6005617")]
		[Address(RVA = "0x715E1AC", Offset = "0x715A1AC", VA = "0x715E1AC")]
		private IEnumerator _00BF_008CuÁ_00ABB(string P_0084c_007DÀ_00A3)
		{
			return null;
		}

		[Token(Token = "0x6005618")]
		[Address(RVA = "0x715E218", Offset = "0x715A218", VA = "0x715E218")]
		private void s_0082_0095_008AJ_009C(bool _008EsRFxT)
		{
		}

		[Token(Token = "0x6005619")]
		[Address(RVA = "0x715E230", Offset = "0x715A230", VA = "0x715E230")]
		private void _00B7B_005BmdI(bool _0084_0060ÁjW_00BB)
		{
		}

		[Token(Token = "0x600561A")]
		[Address(RVA = "0x715E274", Offset = "0x715A274", VA = "0x715E274")]
		internal void _008A_009FF_007B_009BD()
		{
		}

		[Token(Token = "0x600561B")]
		[Address(RVA = "0x715E080", Offset = "0x715A080", VA = "0x715E080")]
		private void _00A6_0092M_007Fd_0099()
		{
		}

		[Token(Token = "0x600561C")]
		[Address(RVA = "0x715E320", Offset = "0x715A320", VA = "0x715E320")]
		public GameFrameWorkMono()
		{
		}

		[Token(Token = "0x600561D")]
		[Address(RVA = "0x715C1B8", Offset = "0x71581B8", VA = "0x715C1B8")]
		private IEnumerator _00AD_00B1F_00B6_007E_007C(string P_0084c_007DÀ_00A3)
		{
			return null;
		}

		[Token(Token = "0x600561E")]
		[Address(RVA = "0x715E404", Offset = "0x715A404", VA = "0x715E404")]
		private void wªyI_00A8s()
		{
		}

		[Token(Token = "0x600561F")]
		[Address(RVA = "0x715E6DC", Offset = "0x715A6DC", VA = "0x715E6DC")]
		internal void m_0086z_008E_00B4_0097()
		{
		}

		[Token(Token = "0x6005620")]
		[Address(RVA = "0x715E6E0", Offset = "0x715A6E0", VA = "0x715E6E0")]
		private void ª_00B7_009E_009B_00AFk()
		{
		}
	}
}
