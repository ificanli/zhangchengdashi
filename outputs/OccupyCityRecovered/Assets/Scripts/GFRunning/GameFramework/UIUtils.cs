using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework
{
	[Token(Token = "0x20003CE")]
	public class UIUtils
	{
		[Token(Token = "0x20003D0")]
		private sealed class AsÂr_009Dm
		{
			[Token(Token = "0x4001C8C")]
			[FieldOffset(Offset = "0x10")]
			public CanvasGroup canvasGroup;

			[Token(Token = "0x6005FBC")]
			[Address(RVA = "0x71DC150", Offset = "0x71D8150", VA = "0x71DC150")]
			public AsÂr_009Dm()
			{
			}

			[Token(Token = "0x6005FBD")]
			[Address(RVA = "0x71DC158", Offset = "0x71D8158", VA = "0x71DC158")]
			internal void wd_009E_00A9r_00B3(float x)
			{
			}

			[Token(Token = "0x6005FBE")]
			[Address(RVA = "0x71DC174", Offset = "0x71D8174", VA = "0x71DC174")]
			internal void _00BC_00B0_00A2_008EcU(float x)
			{
			}
		}

		[Token(Token = "0x20003D1")]
		private sealed class _0086UP_0086T_00B4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001C8D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001C8E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001C8F")]
			[FieldOffset(Offset = "0x20")]
			public EUIAnim anim;

			[Token(Token = "0x4001C90")]
			[FieldOffset(Offset = "0x28")]
			public GameObject target;

			[Token(Token = "0x4001C91")]
			[FieldOffset(Offset = "0x30")]
			public float time;

			[Token(Token = "0x17001169")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6005FC2")]
				[Address(RVA = "0x71DC73C", Offset = "0x71D873C", VA = "0x71DC73C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700116A")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6005FC4")]
				[Address(RVA = "0x71DC77C", Offset = "0x71D877C", VA = "0x71DC77C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005FBF")]
			[Address(RVA = "0x71DB068", Offset = "0x71D7068", VA = "0x71DB068")]
			[DebuggerHidden]
			public _0086UP_0086T_00B4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005FC0")]
			[Address(RVA = "0x71DC190", Offset = "0x71D8190", VA = "0x71DC190", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005FC1")]
			[Address(RVA = "0x71DC194", Offset = "0x71D8194", VA = "0x71DC194", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005FC2")]
			[Address(RVA = "0x71DC73C", Offset = "0x71D873C", VA = "0x71DC73C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005FC3")]
			[Address(RVA = "0x71DC744", Offset = "0x71D8744", VA = "0x71DC744", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6005FC4")]
			[Address(RVA = "0x71DC77C", Offset = "0x71D877C", VA = "0x71DC77C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x6005F94")]
		[Address(RVA = "0x71DAFE4", Offset = "0x71D6FE4", VA = "0x71DAFE4")]
		public static IEnumerator W_008Cw_00ABqn(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005F95")]
		[Address(RVA = "0x71DB090", Offset = "0x71D7090", VA = "0x71DB090")]
		public static IEnumerator _00A8_00BE_00A8XªD(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005F96")]
		[Address(RVA = "0x71DB114", Offset = "0x71D7114", VA = "0x71DB114")]
		public static IEnumerator _00A0GrmnQ(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005F97")]
		[Address(RVA = "0x71DB194", Offset = "0x71D7194", VA = "0x71DB194")]
		public static IEnumerator e_0092_008FIR_005E(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005F98")]
		[Address(RVA = "0x71DB218", Offset = "0x71D7218", VA = "0x71DB218")]
		public static IEnumerator n_0086_00AF_0087_00A9_0087(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005F99")]
		[Address(RVA = "0x71DB298", Offset = "0x71D7298", VA = "0x71DB298")]
		public static IEnumerator _005E_009DMU_00A2ª(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005F9A")]
		[Address(RVA = "0x71DB31C", Offset = "0x71D731C", VA = "0x71DB31C")]
		public static IEnumerator c_009DGO_00B0_009D(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005F9B")]
		[Address(RVA = "0x71DB3A0", Offset = "0x71D73A0", VA = "0x71DB3A0")]
		public static IEnumerator D_0098_007CQgk(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005F9C")]
		[Address(RVA = "0x71DB420", Offset = "0x71D7420", VA = "0x71DB420")]
		public static IEnumerator vJSÂr_0087(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005F9D")]
		[Address(RVA = "0x71DB4A4", Offset = "0x71D74A4", VA = "0x71DB4A4")]
		public static IEnumerator Pl_00AF_00ADC_0081(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005F9E")]
		[Address(RVA = "0x71DB528", Offset = "0x71D7528", VA = "0x71DB528")]
		public static IEnumerator V_008Dfµ_008F_00BF(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0x71DB5AC", Offset = "0x71D75AC", VA = "0x71DB5AC")]
		public static IEnumerator _009C_005D_00AE_009FU_0089(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FA0")]
		[Address(RVA = "0x71DB62C", Offset = "0x71D762C", VA = "0x71DB62C")]
		public static IEnumerator _0097_00A3L_00B1_0091H(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FA1")]
		[Address(RVA = "0x71DB6AC", Offset = "0x71D76AC", VA = "0x71DB6AC")]
		public static IEnumerator _009D_0090CbB_00A9(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FA2")]
		[Address(RVA = "0x71DB730", Offset = "0x71D7730", VA = "0x71DB730")]
		public static IEnumerator _00BDn_00B9_0084Á_0082(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FA3")]
		[Address(RVA = "0x71DB7B0", Offset = "0x71D77B0", VA = "0x71DB7B0")]
		public static IEnumerator W_0090Yµªt(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FA4")]
		[Address(RVA = "0x71DB830", Offset = "0x71D7830", VA = "0x71DB830")]
		public static IEnumerator _00A6_00AF_0087_0096SQ(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0x71DB8B4", Offset = "0x71D78B4", VA = "0x71DB8B4")]
		public static IEnumerator ZSE_00A9Qt(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0x71DB934", Offset = "0x71D7934", VA = "0x71DB934")]
		public static IEnumerator _00B8OM_00A2_00A6_0095(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0x71DB9B4", Offset = "0x71D79B4", VA = "0x71DB9B4")]
		public static IEnumerator W_00BE_00AEap_008D(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FA8")]
		[Address(RVA = "0x71DBA34", Offset = "0x71D7A34", VA = "0x71DBA34")]
		public static IEnumerator HERAv_00A9(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FA9")]
		[Address(RVA = "0x71DBAB4", Offset = "0x71D7AB4", VA = "0x71DBAB4")]
		public static IEnumerator sH_0081_00A8_00A7A(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FAA")]
		[Address(RVA = "0x71DBB38", Offset = "0x71D7B38", VA = "0x71DBB38")]
		public static IEnumerator Y_0090_009BH_00AB_00B6(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FAB")]
		[Address(RVA = "0x71DBBB8", Offset = "0x71D7BB8", VA = "0x71DBBB8")]
		public static IEnumerator _0087µeÁ_008Fµ(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FAC")]
		[Address(RVA = "0x71DBC3C", Offset = "0x71D7C3C", VA = "0x71DBC3C")]
		public static IEnumerator _0086vw_005D_00B9_00A7(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FAD")]
		[Address(RVA = "0x71DBCC0", Offset = "0x71D7CC0", VA = "0x71DBCC0")]
		public static IEnumerator xA_00BBpA_0091(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FAE")]
		[Address(RVA = "0x71DBD44", Offset = "0x71D7D44", VA = "0x71DBD44")]
		public static IEnumerator C_00BFM_00B7_005E_00A6(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FAF")]
		[Address(RVA = "0x71D96A0", Offset = "0x71D56A0", VA = "0x71D96A0")]
		[IteratorStateMachine(typeof(_0086UP_0086T_00B4))]
		public static IEnumerator ObjectAnim(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FB0")]
		[Address(RVA = "0x71DBDC4", Offset = "0x71D7DC4", VA = "0x71DBDC4")]
		public static IEnumerator _00BFs_0088kvm(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FB1")]
		[Address(RVA = "0x71DBE48", Offset = "0x71D7E48", VA = "0x71DBE48")]
		public static IEnumerator _009F_007E_00A8jr_005E(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FB2")]
		[Address(RVA = "0x71DBECC", Offset = "0x71D7ECC", VA = "0x71DBECC")]
		public static IEnumerator _007E_007DF_00A0_009E_00B7(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FB3")]
		[Address(RVA = "0x71DBF50", Offset = "0x71D7F50", VA = "0x71DBF50")]
		public UIUtils()
		{
		}

		[Token(Token = "0x6005FB4")]
		[Address(RVA = "0x71DBF58", Offset = "0x71D7F58", VA = "0x71DBF58")]
		public static IEnumerator _00B0_00B0_00AC_00B1_009C_0089(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FB5")]
		public static void RefreshList<T, T1>(List<T> d_0089_00AE_008EFh, List<T1> _0081_0088_0089_00B8_0094_007B, Action<T, T1> _0099_0091_0083_007F_00BC_00A6, Action<T1> ºo_00ABpÂ_0091) where T : BaseItem
		{
		}

		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0x71DBFDC", Offset = "0x71D7FDC", VA = "0x71DBFDC")]
		public static IEnumerator K_007CHMAr(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}

		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0x71DC05C", Offset = "0x71D805C", VA = "0x71DC05C")]
		public static IEnumerator i_008EB_00A9ªº(GameObject f_005B_0098_00B6_008DÀ, EUIAnim e_00AE_007FZL_007D, float _00A9_008ETG_0095_00B7 = 0.5f)
		{
			return null;
		}
	}
}
