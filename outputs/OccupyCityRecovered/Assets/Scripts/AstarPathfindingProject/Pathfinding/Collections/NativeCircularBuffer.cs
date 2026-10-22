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
			{ this._003C_003E1__state = _003C_003E1__state; }

			[Token(Token = "0x6000F68")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F69")]
bool System.Collections.IEnumerator.MoveNext()
			{
    int state = _003C_003E1__state;
    if (state == 0)
    {
        _003C_003E1__state = -1;
        _003Ci_003E5__2 = 0;
    }
    else if (state == 1)
    {
        _003C_003E1__state = -1;
        _003Ci_003E5__2 = unchecked(_003Ci_003E5__2 + 1);
    }
    else return false;
    if (_003Ci_003E5__2 >= _003C_003E4__this.Length) return false;
    _003C_003E2__current = _003C_003E4__this[_003Ci_003E5__2];
    _003C_003E1__state = 1;
    return true;
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
			{ throw new global::System.NotSupportedException(); }

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
			{ this._003C_003E1__state = _003C_003E1__state; }

			[Token(Token = "0x6000F6E")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F6F")]
bool System.Collections.IEnumerator.MoveNext()
			{
    int state = _003C_003E1__state;
    if (state == 0)
    {
        _003C_003E1__state = -1;
        _003Ci_003E5__2 = 0;
    }
    else if (state == 1)
    {
        _003C_003E1__state = -1;
        _003Ci_003E5__2 = unchecked(_003Ci_003E5__2 + 1);
    }
    else return false;
    if (_003Ci_003E5__2 >= _003C_003E4__this.Length) return false;
    _003C_003E2__current = _003C_003E4__this[_003Ci_003E5__2];
    _003C_003E1__state = 1;
    return true;
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
			{ throw new global::System.NotSupportedException(); }

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
            return length;
        }
		}

		[Token(Token = "0x1700023F")]
		public readonly int AbsoluteStartIndex
		{
			[Token(Token = "0x6000F46")]
			get
			{
            return head;
        }
		}

		[Token(Token = "0x17000240")]
		public readonly int AbsoluteEndIndex
		{
			[Token(Token = "0x6000F47")]
			get
			{
            return unchecked(head + length - 1);
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
            return ref data[head & capacityMask];
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
            return ref data[unchecked(head + length - 1) & capacityMask];
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
            unsafe { return data != null; }
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
            unsafe { return data[unchecked(head + index) & capacityMask]; }
        }
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F60")]
			[IgnoredByDeepProfiler]
			set
			{
            unsafe { data[unchecked(head + index) & capacityMask] = value; }
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
            unsafe { data = null; }
            head = 0;
            length = 0;
            capacityMask = -1;
            Allocator = allocator;
        }

		[Token(Token = "0x6000F4D")]
		public NativeCircularBuffer(int initialCapacity, AllocatorManager.AllocatorHandle allocator)
		{
            int mask = unchecked(initialCapacity - 1);
            mask |= mask >> 1;
            mask |= mask >> 2;
            mask |= mask >> 4;
            mask |= mask >> 8;
            mask |= mask >> 16;
            unsafe { data = AllocatorManager.Allocate<T>(allocator, unchecked(mask + 1)); }
            head = 0;
            length = 0;
            capacityMask = mask;
            Allocator = allocator;
        }

		[Token(Token = "0x6000F4E")]
		public NativeCircularBuffer(CircularBuffer<T> buffer, out ulong gcHandle)
            : this(buffer.data, buffer.head, buffer.Length, out gcHandle)
		{
        }

		[Token(Token = "0x6000F4F")]
		public NativeCircularBuffer(T[] data, int head, int length, out ulong gcHandle)
		{
    unsafe { this.data = (T*)UnsafeUtility.PinGCArrayAndGetDataAddress(data, out gcHandle); }
    int arrayLength = data.Length;
    this.head = head;
    this.length = length;
    capacityMask = unchecked(arrayLength - 1);
    Allocator = Unity.Collections.Allocator.None;
}

		[Token(Token = "0x6000F50")]
		public void Clear()
		{
            head = 0;
            length = 0;
        }

		[Token(Token = "0x6000F51")]
		public void AddRange(List<T> items)
		{
    for (int i = 0; i < items.Count; i = unchecked(i + 1)) PushEnd(items[i]);
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F52")]
		[IgnoredByDeepProfiler]
		public void PushStart(T item)
		{
            if (length > capacityMask) Grow();
            head = unchecked(head - 1);
            length = unchecked(length + 1);
            unsafe { data[head & capacityMask] = item; }
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F53")]
		[IgnoredByDeepProfiler]
		public void PushEnd(T item)
		{
            if (length > capacityMask) Grow();
            int index = length;
            length = unchecked(length + 1);
            unsafe { data[unchecked(head + index) & capacityMask] = item; }
        }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F54")]
		public void Push(bool toStart, T item)
		{
            if (toStart) PushStart(item);
            else PushEnd(item);
        }

		[Token(Token = "0x6000F55")]
		[IgnoredByDeepProfiler]
		public T PopStart()
		{
            unsafe
            {
                T value = data[head & capacityMask];
                head = unchecked(head + 1);
                length = unchecked(length - 1);
                return value;
            }
        }

		[Token(Token = "0x6000F56")]
		[IgnoredByDeepProfiler]
		public T PopEnd()
		{
            unsafe
            {
                T value = data[unchecked(head + length - 1) & capacityMask];
                length = unchecked(length - 1);
                return value;
            }
        }

		[Token(Token = "0x6000F57")]
		public T Pop(bool fromStart)
		{
            return fromStart ? PopStart() : PopEnd();
        }

		[Token(Token = "0x6000F58")]
		public readonly T GetBoundaryValue(bool start)
		{
            unsafe { return data[(start ? head : unchecked(head + length - 1)) & capacityMask]; }
        }

		[Token(Token = "0x6000F59")]
		public void TrimTo(int length)
		{
            this.length = this.length < length ? this.length : length;
        }

		[Token(Token = "0x6000F5A")]
		public void Splice(int startIndex, int toRemove, List<T> toInsert)
		{
    SpliceAbsolute(unchecked(head + startIndex), toRemove, toInsert);
}

		[Token(Token = "0x6000F5B")]
		public void SpliceAbsolute(int startIndex, int toRemove, List<T> toInsert)
		{
    SpliceUninitializedAbsolute(startIndex, toRemove, toInsert.Count);
    for (int i = 0; i < toInsert.Count; i = unchecked(i + 1))
    {
        unsafe { data[unchecked(startIndex + i) & capacityMask] = toInsert[i]; }
    }
}

		[Token(Token = "0x6000F5C")]
		public void SpliceUninitialized(int startIndex, int toRemove, int toInsert)
		{
    SpliceUninitializedAbsolute(unchecked(head + startIndex), toRemove, toInsert);
}

		[Token(Token = "0x6000F5D")]
		public void SpliceUninitializedAbsolute(int startIndex, int toRemove, int toInsert)
		{
    int delta = unchecked(toInsert - toRemove);
    while (unchecked(length + delta) > unchecked(capacityMask + 1)) Grow();
    MoveAbsolute(unchecked(startIndex + toRemove), unchecked(head + length - 1), delta);
    length = unchecked(length + delta);
}

		[Token(Token = "0x6000F5E")]
		private void MoveAbsolute(int startIndex, int endIndex, int deltaIndex)
		{
    unsafe
    {
        if (deltaIndex > 0)
        {
            for (int i = endIndex; i >= startIndex; i = unchecked(i - 1))
                data[unchecked(i + deltaIndex) & capacityMask] = data[i & capacityMask];
        }
        else if (deltaIndex < 0)
        {
            for (int i = startIndex; i <= endIndex; i = unchecked(i + 1))
                data[unchecked(i + deltaIndex) & capacityMask] = data[i & capacityMask];
        }
    }
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F61")]
		[IgnoredByDeepProfiler]
		public readonly T GetAbsolute(int index)
		{
            unsafe { return data[index & capacityMask]; }
        }

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Token(Token = "0x6000F62")]
		private void Grow()
		{
            // Original closed ARM64 instances preserve absolute head and copy the old physical tail.
            int oldCapacity = unchecked(capacityMask + 1);
            int doubledCapacity = unchecked(oldCapacity * 2);
            int newCapacity = doubledCapacity > 4 ? doubledCapacity : 4;
            int newMask = unchecked(newCapacity - 1);
            unsafe
            {
                T* newData = AllocatorManager.Allocate<T>(Allocator, newCapacity);
                if (data != null)
                {
                    int start = head & capacityMask;
                    int tailCount = unchecked(oldCapacity - start);
                    UnsafeUtility.MemCpy(newData + (head & newMask), data + start, unchecked(tailCount * sizeof(T)));
                    int remaining = unchecked(length - tailCount);
                    if (remaining > 0)
                    {
                        UnsafeUtility.MemCpy(newData + (unchecked(head + tailCount) & newMask), data, unchecked(remaining * sizeof(T)));
                    }
                    AllocatorManager.Free<T>(Allocator, data, 1);
                }
                capacityMask = newMask;
                data = newData;
            }
        }

		[Token(Token = "0x6000F63")]
		public void Dispose()
		{
            capacityMask = -1;
            head = 0;
            length = 0;
            unsafe
            {
                AllocatorManager.Free<T>(Allocator, data, 1);
                data = null;
            }
        }

		[Token(Token = "0x6000F64")]
		[IteratorStateMachine(typeof(NativeCircularBuffer<>._003CGetEnumerator_003Ed__44))]
		public IEnumerator<T> GetEnumerator()
		{
    return new _003CGetEnumerator_003Ed__44(0) { _003C_003E4__this = this };
}

		[Token(Token = "0x6000F65")]
		[IteratorStateMachine(typeof(NativeCircularBuffer<>._003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__45))]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
    return new _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__45(0) { _003C_003E4__this = this };
}

		[Token(Token = "0x6000F66")]
		public NativeCircularBuffer<T> Clone()
		{
    unsafe
    {
        if (data == null) return default;
        NativeCircularBuffer<T> copy;
        copy.data = AllocatorManager.Allocate<T>(Allocator, unchecked(capacityMask + 1));
        UnsafeUtility.MemCpy(copy.data, data, unchecked(length * sizeof(T)));
        copy.head = head;
        copy.length = length;
        copy.capacityMask = capacityMask;
        copy.Allocator = Allocator;
        return copy;
    }
}
	}
}
