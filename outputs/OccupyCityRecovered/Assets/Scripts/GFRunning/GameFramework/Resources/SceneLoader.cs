using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AssetBundles;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework.Resources
{
	[Token(Token = "0x20004E1")]
	public class SceneLoader : ResLoader
	{
		[Token(Token = "0x20004E2")]
		private sealed class _009B_009DRh_007C_00A8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001FF2")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001FF3")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001FF4")]
			[FieldOffset(Offset = "0x20")]
			public SceneLoader _003C_003E4__this;

			[Token(Token = "0x4001FF5")]
			[FieldOffset(Offset = "0x28")]
			private float _003CstartTime_003E5__2;

			[Token(Token = "0x4001FF6")]
			[FieldOffset(Offset = "0x30")]
			private AssetBundleLoadOperation _003Crequest_003E5__3;

			[Token(Token = "0x1700125B")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6007480")]
				[Address(RVA = "0x72FAA98", Offset = "0x72F6A98", VA = "0x72FAA98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700125C")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6007482")]
				[Address(RVA = "0x72FAAD8", Offset = "0x72F6AD8", VA = "0x72FAAD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600747D")]
			[Address(RVA = "0x72F9A7C", Offset = "0x72F5A7C", VA = "0x72F9A7C")]
			[DebuggerHidden]
			public _009B_009DRh_007C_00A8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600747E")]
			[Address(RVA = "0x72FA734", Offset = "0x72F6734", VA = "0x72FA734", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600747F")]
			[Address(RVA = "0x72FA738", Offset = "0x72F6738", VA = "0x72FA738", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6007480")]
			[Address(RVA = "0x72FAA98", Offset = "0x72F6A98", VA = "0x72FAA98", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6007481")]
			[Address(RVA = "0x72FAAA0", Offset = "0x72F6AA0", VA = "0x72FAAA0", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6007482")]
			[Address(RVA = "0x72FAAD8", Offset = "0x72F6AD8", VA = "0x72FAAD8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4001FEF")]
		[FieldOffset(Offset = "0x48")]
		internal string x_008A_00BE_0098_007Ej;

		[Token(Token = "0x4001FF0")]
		[FieldOffset(Offset = "0x50")]
		internal bool _005Ddk_00A3Ol;

		[Token(Token = "0x4001FF1")]
		[FieldOffset(Offset = "0x58")]
		private WaitForEndOfFrame _0092_00A4_008AJ_0096V;

		[Token(Token = "0x6007459")]
		[Address(RVA = "0x72F9A18", Offset = "0x72F5A18", VA = "0x72F9A18", Slot = "41")]
		protected virtual IEnumerator Em_00B7_0094_00BD_0094()
		{
			return null;
		}

		[Token(Token = "0x600745A")]
		[Address(RVA = "0x72F9AA4", Offset = "0x72F5AA4", VA = "0x72F9AA4", Slot = "17")]
		protected override void Complete()
		{
		}

		[Token(Token = "0x600745B")]
		[Address(RVA = "0x72F9AB0", Offset = "0x72F5AB0", VA = "0x72F9AB0", Slot = "27")]
		public override void LoadBundle()
		{
		}

		[Token(Token = "0x600745C")]
		[Address(RVA = "0x72F9AEC", Offset = "0x72F5AEC", VA = "0x72F9AEC", Slot = "13")]
		public override void Start(bool _0093MMLC_008B = false)
		{
		}

		[Token(Token = "0x600745D")]
		[Address(RVA = "0x72F9B58", Offset = "0x72F5B58", VA = "0x72F9B58", Slot = "42")]
		protected virtual IEnumerator _0084_00B2µ_00BE_0099_008A()
		{
			return null;
		}

		[Token(Token = "0x600745E")]
		[Address(RVA = "0x72F9BB8", Offset = "0x72F5BB8", VA = "0x72F9BB8", Slot = "43")]
		protected virtual IEnumerator _0085h_00B1V_00ADX()
		{
			return null;
		}

		[Token(Token = "0x600745F")]
		[Address(RVA = "0x72F9C1C", Offset = "0x72F5C1C", VA = "0x72F9C1C", Slot = "44")]
		protected virtual IEnumerator _00B9_00A3oHqU()
		{
			return null;
		}

		[Token(Token = "0x6007460")]
		[Address(RVA = "0x72F9C7C", Offset = "0x72F5C7C", VA = "0x72F9C7C", Slot = "45")]
		protected virtual IEnumerator r_0097Ann_007D()
		{
			return null;
		}

		[Token(Token = "0x6007461")]
		[Address(RVA = "0x72F9CDC", Offset = "0x72F5CDC", VA = "0x72F9CDC", Slot = "46")]
		protected virtual IEnumerator Ar_009E_008Bn_00B0()
		{
			return null;
		}

		[Token(Token = "0x6007462")]
		[Address(RVA = "0x72F9D40", Offset = "0x72F5D40", VA = "0x72F9D40", Slot = "47")]
		protected virtual IEnumerator F_0086ªh_0089_007F()
		{
			return null;
		}

		[Token(Token = "0x6007463")]
		[Address(RVA = "0x72F9DA4", Offset = "0x72F5DA4", VA = "0x72F9DA4", Slot = "48")]
		protected virtual IEnumerator _00BCn_009C_0099_00B7_00BF()
		{
			return null;
		}

		[Token(Token = "0x6007464")]
		[Address(RVA = "0x72F9E04", Offset = "0x72F5E04", VA = "0x72F9E04", Slot = "49")]
		protected virtual IEnumerator xµH_005B_0096Y()
		{
			return null;
		}

		[Token(Token = "0x6007465")]
		[Address(RVA = "0x72F9E64", Offset = "0x72F5E64", VA = "0x72F9E64", Slot = "50")]
		protected virtual IEnumerator vªO_00B0_005E_009F()
		{
			return null;
		}

		[Token(Token = "0x6007466")]
		[Address(RVA = "0x72F9EC8", Offset = "0x72F5EC8", VA = "0x72F9EC8", Slot = "51")]
		protected virtual IEnumerator B_007B_00B7_0088_00B8_0082()
		{
			return null;
		}

		[Token(Token = "0x6007467")]
		[Address(RVA = "0x72F9F2C", Offset = "0x72F5F2C", VA = "0x72F9F2C", Slot = "52")]
		protected virtual IEnumerator _00BDc_00B8ºEM()
		{
			return null;
		}

		[Token(Token = "0x6007468")]
		[Address(RVA = "0x72F9F90", Offset = "0x72F5F90", VA = "0x72F9F90", Slot = "53")]
		protected virtual IEnumerator H_00A7m_009F_007F_008E()
		{
			return null;
		}

		[Token(Token = "0x6007469")]
		[Address(RVA = "0x72F9FF0", Offset = "0x72F5FF0", VA = "0x72F9FF0", Slot = "54")]
		protected virtual IEnumerator _00BF_00A2p_0090_00AC_00AE()
		{
			return null;
		}

		[Token(Token = "0x600746A")]
		[Address(RVA = "0x72FA054", Offset = "0x72F6054", VA = "0x72FA054", Slot = "55")]
		protected virtual IEnumerator _00AD_00B3_00AC_007D_005E_00A7()
		{
			return null;
		}

		[Token(Token = "0x600746B")]
		[Address(RVA = "0x72FA0B4", Offset = "0x72F60B4", VA = "0x72FA0B4", Slot = "56")]
		protected virtual IEnumerator kEE_00B0_00B7D()
		{
			return null;
		}

		[Token(Token = "0x600746C")]
		[Address(RVA = "0x72FA118", Offset = "0x72F6118", VA = "0x72FA118", Slot = "57")]
		protected virtual IEnumerator _0096wy_00ACiL()
		{
			return null;
		}

		[Token(Token = "0x600746D")]
		[Address(RVA = "0x72F699C", Offset = "0x72F299C", VA = "0x72F699C")]
		public SceneLoader()
		{
		}

		[Token(Token = "0x600746E")]
		[Address(RVA = "0x72FA178", Offset = "0x72F6178", VA = "0x72FA178", Slot = "58")]
		protected virtual IEnumerator _0094_00A1n_00BF_0082L()
		{
			return null;
		}

		[Token(Token = "0x600746F")]
		[Address(RVA = "0x72FA1DC", Offset = "0x72F61DC", VA = "0x72FA1DC", Slot = "59")]
		protected virtual IEnumerator Z_0080k_005E_009F_009B()
		{
			return null;
		}

		[Token(Token = "0x6007470")]
		[Address(RVA = "0x72FA23C", Offset = "0x72F623C", VA = "0x72FA23C", Slot = "60")]
		protected virtual IEnumerator a_00B7dQb_0085()
		{
			return null;
		}

		[Token(Token = "0x6007471")]
		[Address(RVA = "0x72FA29C", Offset = "0x72F629C", VA = "0x72FA29C", Slot = "61")]
		protected virtual IEnumerator _00B0_0083_0082jxI()
		{
			return null;
		}

		[Token(Token = "0x6007472")]
		[Address(RVA = "0x72FA2FC", Offset = "0x72F62FC", VA = "0x72FA2FC", Slot = "62")]
		protected virtual IEnumerator _00B9_0088_005EC_00A9N()
		{
			return null;
		}

		[Token(Token = "0x6007473")]
		[Address(RVA = "0x72FA360", Offset = "0x72F6360", VA = "0x72FA360", Slot = "63")]
		protected virtual IEnumerator _0087_0092z_008BZ_009D()
		{
			return null;
		}

		[Token(Token = "0x6007474")]
		[Address(RVA = "0x72FA3C4", Offset = "0x72F63C4", VA = "0x72FA3C4", Slot = "64")]
		protected virtual IEnumerator _0089Djaq_00A9()
		{
			return null;
		}

		[Token(Token = "0x6007475")]
		[Address(RVA = "0x72FA428", Offset = "0x72F6428", VA = "0x72FA428", Slot = "65")]
		protected virtual IEnumerator _00A8c_00AF_007DmA()
		{
			return null;
		}

		[Token(Token = "0x6007476")]
		[Address(RVA = "0x72FA488", Offset = "0x72F6488", VA = "0x72FA488", Slot = "66")]
		protected virtual IEnumerator _0084g_008Fg_00A0f()
		{
			return null;
		}

		[Token(Token = "0x6007477")]
		[Address(RVA = "0x72FA4E8", Offset = "0x72F64E8", VA = "0x72FA4E8", Slot = "67")]
		protected virtual IEnumerator _00A7zz_0087_00A7_009F()
		{
			return null;
		}

		[Token(Token = "0x6007478")]
		[Address(RVA = "0x72FA54C", Offset = "0x72F654C", VA = "0x72FA54C", Slot = "68")]
		protected virtual IEnumerator L_0080yHHx()
		{
			return null;
		}

		[Token(Token = "0x6007479")]
		[Address(RVA = "0x72FA5AC", Offset = "0x72F65AC", VA = "0x72FA5AC", Slot = "69")]
		[IteratorStateMachine(typeof(_009B_009DRh_007C_00A8))]
		protected virtual IEnumerator LoadFromPackage()
		{
			return null;
		}

		[Token(Token = "0x600747A")]
		[Address(RVA = "0x72FA60C", Offset = "0x72F660C", VA = "0x72FA60C", Slot = "70")]
		protected virtual IEnumerator _0099_00A8_00ADhDx()
		{
			return null;
		}

		[Token(Token = "0x600747B")]
		[Address(RVA = "0x72FA670", Offset = "0x72F6670", VA = "0x72FA670", Slot = "71")]
		protected virtual IEnumerator _0085Z_00A1_00A3N_00AB()
		{
			return null;
		}

		[Token(Token = "0x600747C")]
		[Address(RVA = "0x72FA6D0", Offset = "0x72F66D0", VA = "0x72FA6D0", Slot = "72")]
		protected virtual IEnumerator O_007F_005E_005DG_00BC()
		{
			return null;
		}
	}
}
