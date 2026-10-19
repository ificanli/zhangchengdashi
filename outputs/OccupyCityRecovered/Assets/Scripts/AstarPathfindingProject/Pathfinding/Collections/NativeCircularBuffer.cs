using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

namespace Pathfinding.Collections
{
	[Token(Token = "0x200026A")]
	public struct NativeCircularBuffer<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T> where T : unmanaged
	{
		[Token(Token = "0x200026B")]
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__44 : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B57")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000B58")]
			[FieldOffset(Offset = "0x0")]
			private T _003C_003E2__current;

			[Token(Token = "0x4000B59")]
			[FieldOffset(Offset = "0x0")]
			public NativeCircularBuffer<T> _003C_003E4__this;

			[Token(Token = "0x4000B5A")]
			[FieldOffset(Offset = "0x0")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000246")]
T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x6000F6A")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000247")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F6C")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000F67")]
			[DebuggerHidden]
			public _003CGetEnumerator_003Ed__44(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000F68")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F69")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000F6A")]
			[DebuggerHidden]
			private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current()
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeCircularBuffer._003CGetEnumerator_003Ed__44.System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002Eget_Current RVA= Token=0x6000F6A");
}

			[Token(Token = "0x6000F6B")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000F6C")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200026C")]
		[CompilerGenerated]
		private sealed class _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000B5B")]
			[FieldOffset(Offset = "0x0")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000B5C")]
			[FieldOffset(Offset = "0x0")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000B5D")]
			[FieldOffset(Offset = "0x0")]
			public NativeCircularBuffer<T> _003C_003E4__this;

			[Token(Token = "0x4000B5E")]
			[FieldOffset(Offset = "0x0")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000248")]
object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000F70")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000249")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F72")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000F6D")]
			[DebuggerHidden]
			public _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__45(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000F6E")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F6F")]
bool System.Collections.IEnumerator.MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000F70")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000F71")]
			[DebuggerHidden]
void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000F72")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000B52")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe T* data;

		[Token(Token = "0x4000B53")]
		[FieldOffset(Offset = "0x0")]
		internal int head;

		[Token(Token = "0x4000B54")]
		[FieldOffset(Offset = "0x0")]
		private int length;

		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x0")]
		private int capacityMask;

		[Token(Token = "0x4000B56")]
		[FieldOffset(Offset = "0x0")]
		public AllocatorManager.AllocatorHandle Allocator;

		[Token(Token = "0x1700023E")]
		public readonly int Length
		{
			[Token(Token = "0x6000F45")]
			[IgnoredByDeepProfiler]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700023F")]
		public readonly int AbsoluteStartIndex
		{
			[Token(Token = "0x6000F46")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000240")]
		public readonly int AbsoluteEndIndex
		{
			[Token(Token = "0x6000F47")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000241")]
		public unsafe readonly ref T First
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F48")]
			[IgnoredByDeepProfiler]
			get
			{
				return ref *(T*)null;
			}
		}

		[Token(Token = "0x17000242")]
		public unsafe readonly ref T Last
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F49")]
			[IgnoredByDeepProfiler]
			get
			{
				return ref *(T*)null;
			}
		}

		[Token(Token = "0x17000243")]
readonly int System.Collections.Generic.IReadOnlyCollection<T>.Count
		{
			[Token(Token = "0x6000F4A")]
			get
			{
				return System_002ECollections_002EGeneric_002EIReadOnlyCollection_003CT_003E_002Eget_Count();
			}
		}

		[Token(Token = "0x17000244")]
		public readonly bool IsCreated
		{
			[Token(Token = "0x6000F4B")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000245")]
		public T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F5F")]
			[IgnoredByDeepProfiler]
			readonly get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeCircularBuffer.indexer.get RVA= Token=0x6000F5F");
}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F60")]
			[IgnoredByDeepProfiler]
			set
			{
			}
		}

		[Token(Token = "0x6000F4A")]
		private readonly int System_002ECollections_002EGeneric_002EIReadOnlyCollection_003CT_003E_002Eget_Count()
		{
			return default;
		}

		[Token(Token = "0x6000F4C")]
		public NativeCircularBuffer(AllocatorManager.AllocatorHandle allocator)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeCircularBuffer..ctor RVA= Token=0x6000F4C");
}

		[Token(Token = "0x6000F4D")]
		public NativeCircularBuffer(int initialCapacity, AllocatorManager.AllocatorHandle allocator)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeCircularBuffer..ctor RVA= Token=0x6000F4D");
}

		[Token(Token = "0x6000F4E")]
		public NativeCircularBuffer(CircularBuffer<T> buffer, out ulong gcHandle)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeCircularBuffer..ctor RVA= Token=0x6000F4E");
}

		[Token(Token = "0x6000F4F")]
		public NativeCircularBuffer(T[] data, int head, int length, out ulong gcHandle)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeCircularBuffer..ctor RVA= Token=0x6000F4F");
}

		[Token(Token = "0x6000F50")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000F51")]
		public void AddRange(List<T> items)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F52")]
		[IgnoredByDeepProfiler]
		public void PushStart(T item)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F53")]
		[IgnoredByDeepProfiler]
		public void PushEnd(T item)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F54")]
		public void Push(bool toStart, T item)
		{
		}

		[Token(Token = "0x6000F55")]
		[IgnoredByDeepProfiler]
		public T PopStart()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeCircularBuffer.PopStart RVA= Token=0x6000F55");
}

		[Token(Token = "0x6000F56")]
		[IgnoredByDeepProfiler]
		public T PopEnd()
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeCircularBuffer.PopEnd RVA= Token=0x6000F56");
}

		[Token(Token = "0x6000F57")]
		public T Pop(bool fromStart)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeCircularBuffer.Pop RVA= Token=0x6000F57");
}

		[Token(Token = "0x6000F58")]
		public readonly T GetBoundaryValue(bool start)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeCircularBuffer.GetBoundaryValue RVA= Token=0x6000F58");
}

		[Token(Token = "0x6000F59")]
		public void TrimTo(int length)
		{
		}

		[Token(Token = "0x6000F5A")]
		public void Splice(int startIndex, int toRemove, List<T> toInsert)
		{
		}

		[Token(Token = "0x6000F5B")]
		public void SpliceAbsolute(int startIndex, int toRemove, List<T> toInsert)
		{
		}

		[Token(Token = "0x6000F5C")]
		public void SpliceUninitialized(int startIndex, int toRemove, int toInsert)
		{
		}

		[Token(Token = "0x6000F5D")]
		public void SpliceUninitializedAbsolute(int startIndex, int toRemove, int toInsert)
		{
		}

		[Token(Token = "0x6000F5E")]
		private void MoveAbsolute(int startIndex, int endIndex, int deltaIndex)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F61")]
		[IgnoredByDeepProfiler]
		public readonly T GetAbsolute(int index)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NativeCircularBuffer.GetAbsolute RVA= Token=0x6000F61");
}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Token(Token = "0x6000F62")]
		private void Grow()
		{
		}

		[Token(Token = "0x6000F63")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000F64")]
		[IteratorStateMachine(typeof(NativeCircularBuffer<>._003CGetEnumerator_003Ed__44))]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000F65")]
		[IteratorStateMachine(typeof(NativeCircularBuffer<>._003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__45))]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000F66")]
		public NativeCircularBuffer<T> Clone()
		{
			return default;
		}
	}
}
