using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace Pathfinding.Collections
{
	[Token(Token = "0x2000263")]
	public struct CircularBuffer<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
	{
		[Token(Token = "0x2000264")]
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__39 : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B3D")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000B3E")]
			[FieldOffset(Offset = "0x0")]
			private T _003C_003E2__current;

			[Token(Token = "0x4000B3F")]
			[FieldOffset(Offset = "0x0")]
			public CircularBuffer<T> _003C_003E4__this;

			[Token(Token = "0x4000B40")]
			[FieldOffset(Offset = "0x0")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000235")]
T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x6000F16")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000236")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F18")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000F13")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__39(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000F14")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F15")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000F16")]
			[DebuggerHidden]
			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current()
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CircularBuffer._003CGetEnumerator_003Ed__39.System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current RVA= Token=0x6000F16");
}

			[Token(Token = "0x6000F17")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000F18")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000265")]
		[CompilerGenerated]
		private sealed class _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B41")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000B42")]
			[FieldOffset(Offset = "0x0")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000B43")]
			[FieldOffset(Offset = "0x0")]
			public CircularBuffer<T> _003C_003E4__this;

			[Token(Token = "0x4000B44")]
			[FieldOffset(Offset = "0x0")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000237")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000F1C")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000238")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F1E")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000F19")]
			[DebuggerHidden]
			public _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__40(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000F1A")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F1B")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000F1C")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000F1D")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000F1E")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000B3A")]
		[FieldOffset(Offset = "0x0")]
		internal T[] data;

		[Token(Token = "0x4000B3B")]
		[FieldOffset(Offset = "0x0")]
		internal int head;

		[Token(Token = "0x4000B3C")]
		[FieldOffset(Offset = "0x0")]
		private int length;

		[Token(Token = "0x1700022E")]
		public readonly int Length
		{
			[Token(Token = "0x6000EF3")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700022F")]
		public readonly int AbsoluteStartIndex
		{
			[Token(Token = "0x6000EF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000230")]
		public readonly int AbsoluteEndIndex
		{
			[Token(Token = "0x6000EF5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000231")]
		public unsafe readonly ref T First
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000EF6")]
			[IgnoredByDeepProfiler]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CircularBuffer.First.get RVA= Token=0x6000EF6");
}
		}

		[Token(Token = "0x17000232")]
		public unsafe readonly ref T Last
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000EF7")]
			[IgnoredByDeepProfiler]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CircularBuffer.Last.get RVA= Token=0x6000EF7");
}
		}

		[Token(Token = "0x17000233")]
readonly int System.Collections.Generic.IReadOnlyCollection<T>.Count
		{
			[Token(Token = "0x6000EF8")]
			[IgnoredByDeepProfiler]
			get
			{
				return System_002ECollections_002EGeneric_002EIReadOnlyCollection_003CT_003E_002Eget_Count();
			}
		}

		[Token(Token = "0x17000234")]
		public T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F0A")]
			[IgnoredByDeepProfiler]
			readonly get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CircularBuffer.indexer.get RVA= Token=0x6000F0A");
}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F0B")]
			[IgnoredByDeepProfiler]
			set
			{
			}
		}

		[Token(Token = "0x6000EF8")]
		[IgnoredByDeepProfiler]
		private readonly int System_002ECollections_002EGeneric_002EIReadOnlyCollection_003CT_003E_002Eget_Count()
		{
			return default;
		}

		[Token(Token = "0x6000EF9")]
		public CircularBuffer(int initialCapacity)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CircularBuffer..ctor RVA= Token=0x6000EF9");
}

		[Token(Token = "0x6000EFA")]
		public CircularBuffer(T[] backingArray)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CircularBuffer..ctor RVA= Token=0x6000EFA");
}

		[Token(Token = "0x6000EFB")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000EFC")]
		public void AddRange(List<T> items)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000EFD")]
		[IgnoredByDeepProfiler]
		public void PushStart(T item)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000EFE")]
		[IgnoredByDeepProfiler]
		public void PushEnd(T item)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000EFF")]
		[IgnoredByDeepProfiler]
		public void Push(bool toStart, T item)
		{
		}

		[Token(Token = "0x6000F00")]
		[IgnoredByDeepProfiler]
		public T PopStart()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CircularBuffer.PopStart RVA= Token=0x6000F00");
}

		[Token(Token = "0x6000F01")]
		[IgnoredByDeepProfiler]
		public T PopEnd()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CircularBuffer.PopEnd RVA= Token=0x6000F01");
}

		[Token(Token = "0x6000F02")]
		[IgnoredByDeepProfiler]
		public T Pop(bool fromStart)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CircularBuffer.Pop RVA= Token=0x6000F02");
}

		[Token(Token = "0x6000F03")]
		public readonly T GetBoundaryValue(bool start)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CircularBuffer.GetBoundaryValue RVA= Token=0x6000F03");
}

		[Token(Token = "0x6000F04")]
		public void InsertAbsolute(int index, T item)
		{
		}

		[Token(Token = "0x6000F05")]
		public void Splice(int startIndex, int toRemove, List<T> toInsert)
		{
		}

		[Token(Token = "0x6000F06")]
		public void SpliceAbsolute(int startIndex, int toRemove, List<T> toInsert)
		{
		}

		[Token(Token = "0x6000F07")]
		public void SpliceUninitialized(int startIndex, int toRemove, int toInsert)
		{
		}

		[Token(Token = "0x6000F08")]
		public void SpliceUninitializedAbsolute(int startIndex, int toRemove, int toInsert)
		{
		}

		[Token(Token = "0x6000F09")]
		private void MoveAbsolute(int startIndex, int endIndex, int deltaIndex)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F0C")]
		[IgnoredByDeepProfiler]
		public readonly T GetAbsolute(int index)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED CircularBuffer.GetAbsolute RVA= Token=0x6000F0C");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F0D")]
		[IgnoredByDeepProfiler]
		public readonly void SetAbsolute(int index, T value)
		{
		}

		[Token(Token = "0x6000F0E")]
		private void Grow()
		{
		}

		[Token(Token = "0x6000F0F")]
		public void Pool()
		{
		}

		[Token(Token = "0x6000F10")]
		[IteratorStateMachine(typeof(CircularBuffer<>._003CGetEnumerator_003Ed__39))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000F11")]
		[IteratorStateMachine(typeof(CircularBuffer<>._003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__40))]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000F12")]
		public CircularBuffer<T> Clone()
		{
			return default;
		}
	}
}
