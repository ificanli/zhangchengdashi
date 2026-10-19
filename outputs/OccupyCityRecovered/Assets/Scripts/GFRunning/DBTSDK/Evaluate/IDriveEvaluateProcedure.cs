using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace DBTSDK.Evaluate
{
	[Token(Token = "0x20002D2")]
	public abstract class IDriveEvaluateProcedure
	{
		[Token(Token = "0x20002D3")]
		private sealed class _005BQF_00B0_007EY : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40017B5")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40017B6")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40017B7")]
			[FieldOffset(Offset = "0x20")]
			public IDriveEvaluateProcedure _003C_003E4__this;

			[Token(Token = "0x17001094")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600512A")]
				[Address(RVA = "0x711D474", Offset = "0x7119474", VA = "0x711D474", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17001095")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600512C")]
				[Address(RVA = "0x711D4B4", Offset = "0x71194B4", VA = "0x711D4B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005127")]
			[Address(RVA = "0x711D390", Offset = "0x7119390", VA = "0x711D390")]
			[DebuggerHidden]
			public _005BQF_00B0_007EY(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005128")]
			[Address(RVA = "0x711D3CC", Offset = "0x71193CC", VA = "0x711D3CC", Slot = "5")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6005129")]
			[Address(RVA = "0x711D3D0", Offset = "0x71193D0", VA = "0x711D3D0", Slot = "6")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600512A")]
			[Address(RVA = "0x711D474", Offset = "0x7119474", VA = "0x711D474", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600512B")]
			[Address(RVA = "0x711D47C", Offset = "0x711947C", VA = "0x711D47C", Slot = "8")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600512C")]
			[Address(RVA = "0x711D4B4", Offset = "0x71194B4", VA = "0x711D4B4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40017B2")]
		[FieldOffset(Offset = "0x10")]
		private _009A_009C_00B9_00B4_00ABB Y_007E_00A2P_00B0º;

		[Token(Token = "0x40017B3")]
		[FieldOffset(Offset = "0x14")]
		private int _0084_00B0ÁJ_00A3_0097;

		[Token(Token = "0x40017B4")]
		[FieldOffset(Offset = "0x18")]
		private bool _007B_0093_0099z_00B7_0084;

		[Token(Token = "0x6005120")]
		[Address(RVA = "0x711D0E4", Offset = "0x71190E4", VA = "0x711D0E4")]
		internal void _008BT_008F_00BEy_008D(string K_00B3I_00B7_00B6_00AE)
		{
		}

		[Token(Token = "0x6005121")]
		[Address(RVA = "0x711D190", Offset = "0x7119190", VA = "0x711D190")]
		internal void _0098_009E_008E_0080S_0089(int i_009FL_00A1a_00AB)
		{
		}

		[Token(Token = "0x6005122")]
		[Address(RVA = "0x711D330", Offset = "0x7119330", VA = "0x711D330")]
		[IteratorStateMachine(typeof(global::DBTSDK.Evaluate.IDriveEvaluateProcedure._005BQF_00B0_007EY))]
		private IEnumerator L_00B6m_0088_007DJ()
		{
			return null;
		}

		[Token(Token = "0x6005123")]
		public abstract void OpenDirveEvaluateUI();

		[Token(Token = "0x6005124")]
		public abstract void SendReward();

		[Token(Token = "0x6005125")]
		public abstract void CloseDirveEvaluateUI();

		[Token(Token = "0x6005126")]
		[Address(RVA = "0x711D3B8", Offset = "0x71193B8", VA = "0x711D3B8")]
		protected IDriveEvaluateProcedure()
		{
		}
	}
}
