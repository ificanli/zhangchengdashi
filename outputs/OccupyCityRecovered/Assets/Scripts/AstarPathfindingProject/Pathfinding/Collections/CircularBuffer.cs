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
			{ this._003C_003E1__state = _003C_003E1__state; }

			[Token(Token = "0x6000F14")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F15")]
bool System.Collections.IEnumerator.MoveNext()
			{
    int state = _003C_003E1__state;
    if (state == 0) { _003C_003E1__state = -1; _003Ci_003E5__2 = 0; }
    else if (state == 1) { _003C_003E1__state = -1; _003Ci_003E5__2 = unchecked(_003Ci_003E5__2 + 1); }
    else return false;
    if (_003Ci_003E5__2 >= _003C_003E4__this.Length) return false;
    _003C_003E2__current = _003C_003E4__this[_003Ci_003E5__2];
    _003C_003E1__state = 1;
    return true;
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
			{ throw new System.NotSupportedException(); }

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
			{ this._003C_003E1__state = _003C_003E1__state; }

			[Token(Token = "0x6000F1A")]
			[DebuggerHidden]
void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000F1B")]
bool System.Collections.IEnumerator.MoveNext()
			{
    int state = _003C_003E1__state;
    if (state == 0) { _003C_003E1__state = -1; _003Ci_003E5__2 = 0; }
    else if (state == 1) { _003C_003E1__state = -1; _003Ci_003E5__2 = unchecked(_003Ci_003E5__2 + 1); }
    else return false;
    if (_003Ci_003E5__2 >= _003C_003E4__this.Length) return false;
    _003C_003E2__current = _003C_003E4__this[_003Ci_003E5__2];
    _003C_003E1__state = 1;
    return true;
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
			{ throw new System.NotSupportedException(); }

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
                return length;
            }
		}

		[Token(Token = "0x1700022F")]
		public readonly int AbsoluteStartIndex
		{
			[Token(Token = "0x6000EF4")]
			get
			{ return head; }
		}

		[Token(Token = "0x17000230")]
		public readonly int AbsoluteEndIndex
		{
			[Token(Token = "0x6000EF5")]
			get
			{ return unchecked(head + length - 1); }
		}

		[Token(Token = "0x17000231")]
		public unsafe readonly ref T First
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000EF6")]
			[IgnoredByDeepProfiler]
			get
			{ return ref data[head & unchecked(data.Length - 1)]; }
		}

		[Token(Token = "0x17000232")]
		public unsafe readonly ref T Last
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000EF7")]
			[IgnoredByDeepProfiler]
			get
			{ return ref data[unchecked(head + length - 1) & unchecked(data.Length - 1)]; }
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
			{ return data[unchecked(head + index) & unchecked(data.Length - 1)]; }
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F0B")]
			[IgnoredByDeepProfiler]
			set
			{ data[unchecked(head + index) & unchecked(data.Length - 1)] = value; }
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
    data = Pathfinding.Pooling.ArrayPool<T>.Claim(initialCapacity);
    head = 0;
    length = 0;
}

		[Token(Token = "0x6000EFA")]
		public CircularBuffer(T[] backingArray)
		{ data = backingArray; head = 0; length = 0; }

		[Token(Token = "0x6000EFB")]
		public void Clear()
		{
    head = 0;
    length = 0;
}

		[Token(Token = "0x6000EFC")]
		public void AddRange(List<T> items)
		{
    for (int i = 0; i < items.Count; i = unchecked(i + 1)) PushEnd(items[i]);
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000EFD")]
		[IgnoredByDeepProfiler]
		public void PushStart(T item)
		{
    if (data == null || length >= data.Length) Grow();
    head = unchecked(head - 1);
    length = unchecked(length + 1);
    data[head & unchecked(data.Length - 1)] = item;
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000EFE")]
		[IgnoredByDeepProfiler]
		public void PushEnd(T item)
		{
    if (data == null || length >= data.Length) Grow();
    int index = length;
    length = unchecked(length + 1);
    data[unchecked(head + index) & unchecked(data.Length - 1)] = item;
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000EFF")]
		[IgnoredByDeepProfiler]
		public void Push(bool toStart, T item)
		{ if (toStart) PushStart(item); else PushEnd(item); }

		[Token(Token = "0x6000F00")]
		[IgnoredByDeepProfiler]
		public T PopStart()
		{
    if (length == 0) throw new System.InvalidOperationException();
    T value = data[head & unchecked(data.Length - 1)];
    head = unchecked(head + 1);
    length = unchecked(length - 1);
    return value;
}

		[Token(Token = "0x6000F01")]
		[IgnoredByDeepProfiler]
		public T PopEnd()
		{
    if (length == 0) throw new System.InvalidOperationException();
    T value = data[unchecked(head + length - 1) & unchecked(data.Length - 1)];
    length = unchecked(length - 1);
    return value;
}

		[Token(Token = "0x6000F02")]
		[IgnoredByDeepProfiler]
		public T Pop(bool fromStart)
		{ return fromStart ? PopStart() : PopEnd(); }

		[Token(Token = "0x6000F03")]
		public readonly T GetBoundaryValue(bool start)
		{ return data[(start ? head : unchecked(head + length - 1)) & unchecked(data.Length - 1)]; }

		[Token(Token = "0x6000F04")]
		public void InsertAbsolute(int index, T item)
		{
    SpliceUninitializedAbsolute(index, 0, 1);
    data[index & unchecked(data.Length - 1)] = item;
}

		[Token(Token = "0x6000F05")]
		public void Splice(int startIndex, int toRemove, List<T> toInsert)
		{ SpliceAbsolute(unchecked(head + startIndex), toRemove, toInsert); }

		[Token(Token = "0x6000F06")]
		public void SpliceAbsolute(int startIndex, int toRemove, List<T> toInsert)
		{
    SpliceUninitializedAbsolute(startIndex, toRemove, toInsert == null ? 0 : toInsert.Count);
    if (toInsert != null)
        for (int i = 0; i < toInsert.Count; i = unchecked(i + 1))
            data[unchecked(startIndex + i) & unchecked(data.Length - 1)] = toInsert[i];
}

		[Token(Token = "0x6000F07")]
		public void SpliceUninitialized(int startIndex, int toRemove, int toInsert)
		{ SpliceUninitializedAbsolute(unchecked(head + startIndex), toRemove, toInsert); }

		[Token(Token = "0x6000F08")]
		public void SpliceUninitializedAbsolute(int startIndex, int toRemove, int toInsert)
		{
    int delta = unchecked(toInsert - toRemove);
    while (unchecked(length + delta) > data.Length) Grow();
    MoveAbsolute(unchecked(startIndex + toRemove), unchecked(head + length - 1), delta);
    length = unchecked(length + delta);
}

		[Token(Token = "0x6000F09")]
		private void MoveAbsolute(int startIndex, int endIndex, int deltaIndex)
		{
    if (deltaIndex > 0)
        for (int i = endIndex; i >= startIndex; i = unchecked(i - 1))
            data[unchecked(i + deltaIndex) & unchecked(data.Length - 1)] = data[i & unchecked(data.Length - 1)];
    else if (deltaIndex < 0)
        for (int i = startIndex; i <= endIndex; i = unchecked(i + 1))
            data[unchecked(i + deltaIndex) & unchecked(data.Length - 1)] = data[i & unchecked(data.Length - 1)];
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F0C")]
		[IgnoredByDeepProfiler]
		public readonly T GetAbsolute(int index)
		{ return data[index & unchecked(data.Length - 1)]; }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F0D")]
		[IgnoredByDeepProfiler]
		public readonly void SetAbsolute(int index, T value)
		{ data[index & unchecked(data.Length - 1)] = value; }

		[Token(Token = "0x6000F0E")]
		private void Grow()
		{
    int doubled = data == null ? 0 : unchecked(data.Length * 2);
    int capacity = doubled > 4 ? doubled : 4;
    T[] newData = Pathfinding.Pooling.ArrayPool<T>.Claim(capacity);
    if (data != null)
    {
        int start = head & unchecked(data.Length - 1);
        int tail = unchecked(data.Length - start);
        System.Array.Copy(data, start, newData, head & unchecked(newData.Length - 1), tail);
        int remaining = unchecked(length - tail);
        if (remaining > 0)
            System.Array.Copy(data, 0, newData, unchecked(head + tail) & unchecked(newData.Length - 1), remaining);
        Pathfinding.Pooling.ArrayPool<T>.Release(ref data);
    }
    data = newData;
}

		[Token(Token = "0x6000F0F")]
		public void Pool()
		{
    Pathfinding.Pooling.ArrayPool<T>.Release(ref data);
    head = 0;
    length = 0;
}

		[Token(Token = "0x6000F10")]
		[IteratorStateMachine(typeof(CircularBuffer<>._003CGetEnumerator_003Ed__39))]
		public IEnumerator<T> GetEnumerator()
		{ return new _003CGetEnumerator_003Ed__39(0) { _003C_003E4__this = this }; }

		[Token(Token = "0x6000F11")]
		[IteratorStateMachine(typeof(CircularBuffer<>._003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__40))]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{ return new _003CSystem_002DCollections_002DIEnumerable_002DGetEnumerator_003Ed__40(0) { _003C_003E4__this = this }; }

		[Token(Token = "0x6000F12")]
		public CircularBuffer<T> Clone()
		{
    CircularBuffer<T> copy;
    copy.data = data == null ? null : (T[])data.Clone();
    copy.head = head;
    copy.length = length;
    return copy;
}
	}
}
