using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Jobs;

namespace Pathfinding.Jobs
{
	[Token(Token = "0x2000189")]
	public struct JobHandleWithMainThreadWork<T> where T : struct
	{
		[Token(Token = "0x200018A")]
		[CompilerGenerated]
		private sealed class _003CCompleteTimeSliced_003Ed__4 : IEnumerable<T?>, IEnumerable, IEnumerator<T?>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007A7")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x40007A8")]
			[FieldOffset(Offset = "0x0")]
			private T? _003C_003E2__current;

			[Token(Token = "0x40007A9")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003El__initialThreadId;

			[Token(Token = "0x40007AA")]
			[FieldOffset(Offset = "0x0")]
			public JobHandleWithMainThreadWork<T> _003C_003E4__this;

			[Token(Token = "0x40007AB")]
			[FieldOffset(Offset = "0x0")]
			public JobHandleWithMainThreadWork<T> _003C_003E3___003C_003E4__this;

			[Token(Token = "0x40007AC")]
			[FieldOffset(Offset = "0x0")]
			private float maxMillisPerStep;

			[Token(Token = "0x40007AD")]
			[FieldOffset(Offset = "0x0")]
			public float _003C_003E3__maxMillisPerStep;

			[Token(Token = "0x170001F2")]
T? System.Collections.Generic.IEnumerator<T?>.Current
			{
				[Token(Token = "0x6000BC3")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CT_003F_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001F3")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BC5")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000BC0")]
			[DebuggerHidden]
			public _003CCompleteTimeSliced_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000BC1")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BC2")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000BC3")]
			[DebuggerHidden]
			private T? System_002ECollections_002EGeneric_002EIEnumerator_003CT_003F_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000BC4")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000BC5")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000BC6")]
			[DebuggerHidden]
IEnumerator<T?> System.Collections.Generic.IEnumerable<T?>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000BC7")]
			[DebuggerHidden]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x0")]
		private JobDependencyTracker tracker;

		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator<(JobHandle, T)> coroutine;

		[Token(Token = "0x6000BBD")]
		public JobHandleWithMainThreadWork(IEnumerator<(JobHandle, T)> handles, JobDependencyTracker tracker)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED JobHandleWithMainThreadWork..ctor RVA= Token=0x6000BBD");
}

		[Token(Token = "0x6000BBE")]
		public void Complete()
		{
		}

		[Token(Token = "0x6000BBF")]
		[IteratorStateMachine(typeof(JobHandleWithMainThreadWork<>._003CCompleteTimeSliced_003Ed__4))]
		public IEnumerable<T?> CompleteTimeSliced(float maxMillisPerStep)
		{
			return null;
		}
	}
}
