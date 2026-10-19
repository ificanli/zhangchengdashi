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
	[Token(Token = "0x20004D7")]
	public class AssetResLoader : ResLoader
	{
		[Token(Token = "0x20004D8")]
		private sealed class _00BCÁ_0085_00ABaZ : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4001FCB")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4001FCC")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4001FCD")]
			[FieldOffset(Offset = "0x20")]
			public AssetResLoader _003C_003E4__this;

			[Token(Token = "0x4001FCE")]
			[FieldOffset(Offset = "0x28")]
			private AssetBundleLoadBundleOperation _003Crequest_003E5__2;

			[Token(Token = "0x1700124F")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60073B0")]
				[Address(RVA = "0x72F2F94", Offset = "0x72EEF94", VA = "0x72F2F94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17001250")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60073B2")]
				[Address(RVA = "0x72F2FD4", Offset = "0x72EEFD4", VA = "0x72F2FD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60073AD")]
			[Address(RVA = "0x72F1A10", Offset = "0x72EDA10", VA = "0x72F1A10")]
			[DebuggerHidden]
			public _00BCÁ_0085_00ABaZ(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60073AE")]
			[Address(RVA = "0x72F2AAC", Offset = "0x72EEAAC", VA = "0x72F2AAC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60073AF")]
			[Address(RVA = "0x72F2AB0", Offset = "0x72EEAB0", VA = "0x72F2AB0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60073B0")]
			[Address(RVA = "0x72F2F94", Offset = "0x72EEF94", VA = "0x72F2F94", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60073B1")]
			[Address(RVA = "0x72F2F9C", Offset = "0x72EEF9C", VA = "0x72F2F9C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60073B2")]
			[Address(RVA = "0x72F2FD4", Offset = "0x72EEFD4", VA = "0x72F2FD4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4001FC8")]
		[FieldOffset(Offset = "0x48")]
		protected AssetBundle _bundle;

		[Token(Token = "0x4001FC9")]
		[FieldOffset(Offset = "0x50")]
		protected bool _hasError;

		[Token(Token = "0x4001FCA")]
		[FieldOffset(Offset = "0x58")]
		private string[] _008BJ_008CÂrl;

		[Token(Token = "0x600737F")]
		[Address(RVA = "0x72F19AC", Offset = "0x72ED9AC", VA = "0x72F19AC", Slot = "41")]
		protected virtual IEnumerator O_007F_005E_005DG_00BC()
		{
			return null;
		}

		[Token(Token = "0x6007380")]
		[Address(RVA = "0x72F1A38", Offset = "0x72EDA38", VA = "0x72F1A38", Slot = "42")]
		protected virtual void _00A9t_008C_007F_0087n()
		{
		}

		[Token(Token = "0x6007381")]
		[Address(RVA = "0x72F1A3C", Offset = "0x72EDA3C", VA = "0x72F1A3C", Slot = "43")]
		protected virtual IEnumerator Ar_009E_008Bn_00B0()
		{
			return null;
		}

		[Token(Token = "0x6007382")]
		[Address(RVA = "0x72F1A9C", Offset = "0x72EDA9C", VA = "0x72F1A9C", Slot = "44")]
		protected virtual IEnumerator S_00A2_0083_0094T_007B()
		{
			return null;
		}

		[Token(Token = "0x6007383")]
		[Address(RVA = "0x72F1B00", Offset = "0x72EDB00", VA = "0x72F1B00")]
		private void TYg_007FQ_00B7(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x6007384")]
		[Address(RVA = "0x72F1B68", Offset = "0x72EDB68", VA = "0x72F1B68")]
		private void XKFB_0098_00A3(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x6007385")]
		[Address(RVA = "0x72F1BD0", Offset = "0x72EDBD0", VA = "0x72F1BD0")]
		private void _00B6BsbOZ(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x6007386")]
		[Address(RVA = "0x72F1C38", Offset = "0x72EDC38", VA = "0x72F1C38", Slot = "45")]
		protected virtual void Â_008C_0097A_00BE_005E()
		{
		}

		[Token(Token = "0x6007387")]
		[Address(RVA = "0x72F1C3C", Offset = "0x72EDC3C", VA = "0x72F1C3C")]
		private void sWz_0086_00B7_00AE(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x6007388")]
		[Address(RVA = "0x72F1CA0", Offset = "0x72EDCA0", VA = "0x72F1CA0")]
		public AssetResLoader()
		{
		}

		[Token(Token = "0x6007389")]
		[Address(RVA = "0x72F1CA4", Offset = "0x72EDCA4", VA = "0x72F1CA4", Slot = "46")]
		protected virtual void _00A2_00B6_009Bgtu()
		{
		}

		[Token(Token = "0x600738A")]
		[Address(RVA = "0x72F1CA8", Offset = "0x72EDCA8", VA = "0x72F1CA8", Slot = "47")]
		[IteratorStateMachine(typeof(_00BCÁ_0085_00ABaZ))]
		protected virtual IEnumerator LoadFromPackage()
		{
			return null;
		}

		[Token(Token = "0x600738B")]
		[Address(RVA = "0x72F1D08", Offset = "0x72EDD08", VA = "0x72F1D08")]
		private void _008C_008EP_00AC_0099_00BB(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x600738C")]
		[Address(RVA = "0x72F1D70", Offset = "0x72EDD70", VA = "0x72F1D70")]
		private void PZMjq_008B(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x600738D")]
		[Address(RVA = "0x72F1DD8", Offset = "0x72EDDD8", VA = "0x72F1DD8", Slot = "27")]
		public override void LoadBundle()
		{
		}

		[Token(Token = "0x600738E")]
		[Address(RVA = "0x72F1E14", Offset = "0x72EDE14", VA = "0x72F1E14")]
		private void _0099_0082_0097µ_009C_0082(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x600738F")]
		[Address(RVA = "0x72F1E78", Offset = "0x72EDE78", VA = "0x72F1E78")]
		private void _00A1_00A9_00B6_008FIq(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x6007390")]
		[Address(RVA = "0x72F1EDC", Offset = "0x72EDEDC", VA = "0x72F1EDC", Slot = "48")]
		protected virtual void LoadFromEditor()
		{
		}

		[Token(Token = "0x6007391")]
		[Address(RVA = "0x72F1EE0", Offset = "0x72EDEE0", VA = "0x72F1EE0")]
		private void _0085_00B7PB_0098_0081(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x6007392")]
		[Address(RVA = "0x72F1F44", Offset = "0x72EDF44", VA = "0x72F1F44", Slot = "49")]
		protected virtual IEnumerator _0089Djaq_00A9()
		{
			return null;
		}

		[Token(Token = "0x6007393")]
		[Address(RVA = "0x72F1FA4", Offset = "0x72EDFA4", VA = "0x72F1FA4")]
		private void _00A3_0094iUª_007C(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x6007394")]
		[Address(RVA = "0x72F2008", Offset = "0x72EE008", VA = "0x72F2008")]
		private void _00AF_00AD_00BD_008DSC(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x6007395")]
		[Address(RVA = "0x72F206C", Offset = "0x72EE06C", VA = "0x72F206C", Slot = "50")]
		protected virtual IEnumerator xµH_005B_0096Y()
		{
			return null;
		}

		[Token(Token = "0x6007396")]
		[Address(RVA = "0x72F20D0", Offset = "0x72EE0D0", VA = "0x72F20D0", Slot = "51")]
		protected virtual void kFR_00BE_00AE_005E()
		{
		}

		[Token(Token = "0x6007397")]
		[Address(RVA = "0x72F20D4", Offset = "0x72EE0D4", VA = "0x72F20D4", Slot = "52")]
		protected virtual void n_00A1ioZ_008F()
		{
		}

		[Token(Token = "0x6007398")]
		[Address(RVA = "0x72F20D8", Offset = "0x72EE0D8", VA = "0x72F20D8")]
		private void _009Ch_00A7Ya_0089(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x6007399")]
		[Address(RVA = "0x72F2140", Offset = "0x72EE140", VA = "0x72F2140")]
		private void _005D_00A1_008Dt_0093µ(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x600739A")]
		[Address(RVA = "0x72F21A8", Offset = "0x72EE1A8", VA = "0x72F21A8")]
		private void _00B4Hf_008A_00B7L(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x600739B")]
		[Address(RVA = "0x72F2210", Offset = "0x72EE210", VA = "0x72F2210", Slot = "53")]
		protected virtual void N_00B9d_009AR_009C()
		{
		}

		[Token(Token = "0x600739C")]
		[Address(RVA = "0x72F2214", Offset = "0x72EE214", VA = "0x72F2214", Slot = "54")]
		protected virtual void _009AJC_0097_0086n()
		{
		}

		[Token(Token = "0x600739D")]
		[Address(RVA = "0x72F2218", Offset = "0x72EE218", VA = "0x72F2218", Slot = "55")]
		protected virtual void _0080_008B_0084_0081U_007D()
		{
		}

		[Token(Token = "0x600739E")]
		[Address(RVA = "0x72F221C", Offset = "0x72EE21C", VA = "0x72F221C", Slot = "13")]
		public override void Start(bool _0093MMLC_008B = false)
		{
		}

		[Token(Token = "0x600739F")]
		[Address(RVA = "0x72F23B4", Offset = "0x72EE3B4", VA = "0x72F23B4")]
		private void N_009C_0095_0091IH(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x60073A0")]
		[Address(RVA = "0x72F241C", Offset = "0x72EE41C", VA = "0x72F241C")]
		private void s_0086_00A0_008E_00B9_00A2(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x60073A1")]
		[Address(RVA = "0x72F2480", Offset = "0x72EE480", VA = "0x72F2480")]
		private void _009D_007FR_0081_0093y(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x60073A2")]
		[Address(RVA = "0x72F24E4", Offset = "0x72EE4E4", VA = "0x72F24E4")]
		private void _009E_009AAcÁ_00A2(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x60073A3")]
		[Address(RVA = "0x72F2548", Offset = "0x72EE548", VA = "0x72F2548", Slot = "17")]
		protected override void Complete()
		{
		}

		[Token(Token = "0x60073A4")]
		[Address(RVA = "0x72F27D8", Offset = "0x72EE7D8", VA = "0x72F27D8")]
		private void ata_005Bp_009F(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x60073A5")]
		[Address(RVA = "0x72F283C", Offset = "0x72EE83C", VA = "0x72F283C", Slot = "56")]
		protected virtual IEnumerator _0094_00A1n_00BF_0082L()
		{
			return null;
		}

		[Token(Token = "0x60073A6")]
		[Address(RVA = "0x72F28A0", Offset = "0x72EE8A0", VA = "0x72F28A0", Slot = "38")]
		protected override void Error()
		{
		}

		[Token(Token = "0x60073A7")]
		[Address(RVA = "0x72F28B8", Offset = "0x72EE8B8", VA = "0x72F28B8", Slot = "57")]
		protected virtual void _00AFÁ_00ABt_009D_007B()
		{
		}

		[Token(Token = "0x60073A8")]
		[Address(RVA = "0x72F28BC", Offset = "0x72EE8BC", VA = "0x72F28BC")]
		private void iN_007FH_00B9_008F(ResourcesInfo _0094tAsnz)
		{
		}

		[Token(Token = "0x60073A9")]
		[Address(RVA = "0x72F2924", Offset = "0x72EE924", VA = "0x72F2924", Slot = "58")]
		protected virtual IEnumerator _0087_0092z_008BZ_009D()
		{
			return null;
		}

		[Token(Token = "0x60073AA")]
		[Address(RVA = "0x72F2984", Offset = "0x72EE984", VA = "0x72F2984", Slot = "59")]
		protected virtual IEnumerator _0084_00B2µ_00BE_0099_008A()
		{
			return null;
		}

		[Token(Token = "0x60073AB")]
		[Address(RVA = "0x72F29E4", Offset = "0x72EE9E4", VA = "0x72F29E4", Slot = "60")]
		protected virtual IEnumerator _0099_00A8_00ADhDx()
		{
			return null;
		}

		[Token(Token = "0x60073AC")]
		[Address(RVA = "0x72F2A48", Offset = "0x72EEA48", VA = "0x72F2A48")]
		private void O_0095_0099v_0060_00A5(ResourcesInfo _0094tAsnz)
		{
		}
	}
}
