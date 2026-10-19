using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace YooAsset
{
	[Token(Token = "0x20000D8")]
	public abstract class AsyncOperationBase : IEnumerator
	{
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x10")]
		private Action<AsyncOperationBase> p_007EVSds;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x18")]
		private EOperationStatus _0084xno_0093_00AD;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x20")]
		private string p_009D_0084_00A9_009Br;

		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x28")]
		private long _00B8_0060Qª_00AE_00B9;

		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x30")]
		private float J_009FP_00BEfm;

		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x38")]
		private TaskCompletionSource<object> _0096L_009B_0097P_00B2;

		[Token(Token = "0x1700008B")]
		public EOperationStatus Status
		{
			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0x731CADC", Offset = "0x7318ADC", VA = "0x731CADC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x731CAE4", Offset = "0x7318AE4", VA = "0x731CAE4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public string Error
		{
			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0x731CAEC", Offset = "0x7318AEC", VA = "0x731CAEC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BA5")]
			[Address(RVA = "0x731CAF4", Offset = "0x7318AF4", VA = "0x731CAF4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public long ErrorCode
		{
			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x731CAFC", Offset = "0x7318AFC", VA = "0x731CAFC")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x731CB04", Offset = "0x7318B04", VA = "0x731CB04")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public float Progress
		{
			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0x731CB0C", Offset = "0x7318B0C", VA = "0x731CB0C")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0x731CB14", Offset = "0x7318B14", VA = "0x731CB14")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public bool IsDone
		{
			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0x7313054", Offset = "0x730F054", VA = "0x7313054")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000090")]
		public Task Task
		{
			[Token(Token = "0x6000BAD")]
			[Address(RVA = "0x731CCA4", Offset = "0x7318CA4", VA = "0x731CCA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x731CE18", Offset = "0x7318E18", VA = "0x731CE18", Slot = "5")]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x14000007")]
		public event Action<AsyncOperationBase> Completed
		{
			[Token(Token = "0x6000BAB")]
			[Address(RVA = "0x731CB1C", Offset = "0x7318B1C", VA = "0x731CB1C")]
			add
			{
			}
			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0x731CBFC", Offset = "0x7318BFC", VA = "0x731CBFC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000BAE")]
		internal abstract void GL_008Ccx_00A1();

		[Token(Token = "0x6000BAF")]
		internal abstract void _007EZ_00A7_008E_0095U();

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x731CD6C", Offset = "0x7318D6C", VA = "0x731CD6C")]
		internal void HR_0086sw_0091()
		{
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x731CDEC", Offset = "0x7318DEC", VA = "0x731CDEC")]
		internal void g_00BBJ_00A5_0080_0086()
		{
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x731CDF8", Offset = "0x7318DF8", VA = "0x731CDF8")]
		protected void ClearCompletedCallback()
		{
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x731CE00", Offset = "0x7318E00", VA = "0x731CE00", Slot = "4")]
bool System.Collections.IEnumerator.MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000BB4")]
		[Address(RVA = "0x731CE14", Offset = "0x7318E14", VA = "0x731CE14", Slot = "6")]
void System.Collections.IEnumerator.Reset()
		{
		}

		[Token(Token = "0x6000BB5")]
		[Address(RVA = "0x731CE18", Offset = "0x7318E18", VA = "0x731CE18", Slot = "5")]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x731CE20", Offset = "0x7318E20", VA = "0x731CE20")]
		protected AsyncOperationBase()
		{
		}
	}
}
