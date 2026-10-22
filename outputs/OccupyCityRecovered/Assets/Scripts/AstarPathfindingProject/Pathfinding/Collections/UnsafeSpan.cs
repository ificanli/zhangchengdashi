using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

namespace Pathfinding.Collections
{
	[Token(Token = "0x2000274")]
	public readonly struct UnsafeSpan<T> where T : unmanaged
	{
		[Token(Token = "0x4000B6F")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe readonly T* ptr;

		[Token(Token = "0x4000B70")]
		[FieldOffset(Offset = "0x0")]
		internal readonly uint length;

		[Token(Token = "0x4000B71")]
		[FieldOffset(Offset = "0x0")]
		public readonly Allocator Allocator;

		[Token(Token = "0x1700024F")]
		public int Length
		{
			[Token(Token = "0x6000F8B")]
			get
			{ return (int)length; }
		}

		[Token(Token = "0x17000250")]
		public unsafe ref T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F91")]
			[IgnoredByDeepProfiler]
			get
			{
 if ((uint)index >= length) throw new System.IndexOutOfRangeException();
 Unity.Burst.CompilerServices.Hint.Assume(ptr != null);
 return ref ptr[index];
}
		}

		[Token(Token = "0x17000251")]
		public unsafe ref T this[uint index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F92")]
			[IgnoredByDeepProfiler]
			get
			{
 if (index >= length) throw new System.IndexOutOfRangeException();
 Unity.Burst.CompilerServices.Hint.Assume(ptr != null);
 Unity.Burst.CompilerServices.Hint.Assume(ptr + index != null);
 return ref ptr[index];
}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F8C")]
		public unsafe UnsafeSpan(void* ptr, int length, Allocator allocator = Allocator.None)
		{
 if (length < 0) throw new System.ArgumentOutOfRangeException();
 if (ptr == null && length != 0) throw new System.ArgumentNullException();
 this.ptr = (T*)ptr;
 this.length = (uint)length;
 this.Allocator = allocator;
}

		[Token(Token = "0x6000F8D")]
		public UnsafeSpan(T[] data, Allocator allocator)
		{
 this = new UnsafeSpan<T>(allocator, data.Length);
 SpanExtensions.CopyFrom(this, data);
}

		[Token(Token = "0x6000F8E")]
		public UnsafeSpan(T[] data, out ulong gcHandle)
		{
 unsafe { this.ptr = (T*)UnsafeUtility.PinGCArrayAndGetDataAddress(data, out gcHandle); }
 this.length = unchecked((uint)data.Length);
 this.Allocator = Unity.Collections.Allocator.None;
}

		[Token(Token = "0x6000F8F")]
		public UnsafeSpan(T[,] data, out ulong gcHandle)
		{
 unsafe { this.ptr = (T*)UnsafeUtility.PinGCArrayAndGetDataAddress(data, out gcHandle); }
 this.length = unchecked((uint)data.Length);
 this.Allocator = Unity.Collections.Allocator.None;
}

		[Token(Token = "0x6000F90")]
		public UnsafeSpan(Allocator allocator, int length)
		{
  if (length < 0) throw new System.ArgumentOutOfRangeException();
  unsafe { this.ptr = length == 0 ? null : (T*)UnsafeUtility.MallocTracked((long)sizeof(T) * length, UnsafeUtility.AlignOf<T>(), allocator, 1); }
  this.length = unchecked((uint)length);
  this.Allocator = allocator;
 }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F93")]
		public UnsafeSpan<U> Reinterpret<U>() where U : unmanaged
		{
 unsafe { return new UnsafeSpan<U>(ptr,unchecked((int)length),Allocator); }
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F94")]
		public UnsafeSpan<U> Reinterpret<U>(int expectedOriginalTypeSize) where U : unmanaged
		{
 unsafe { return new UnsafeSpan<U>(ptr,unchecked((int)(length*(uint)sizeof(T)))/sizeof(U),Allocator); }
}

		[Token(Token = "0x6000F95")]
		public UnsafeSpan<T> Slice(int start, int length)
		{
 if ((start | length) < 0 || (long)start + length > this.length) throw new System.ArgumentOutOfRangeException();
 unsafe { return new UnsafeSpan<T>(ptr + start, length, Allocator); }
}

		[Token(Token = "0x6000F96")]
		public UnsafeSpan<T> Slice(int start)
		{ return Slice(start, unchecked((int)length - start)); }

		[Token(Token = "0x6000F97")]
		public void Move(int startIndex, int toIndex, int count)
		{
 if (count < 0 || startIndex < 0 || (long)unchecked(startIndex + count) > length || toIndex < 0 || (long)unchecked(toIndex + count) > length) throw new System.ArgumentOutOfRangeException();
 unsafe {
  if (count != 0) UnsafeUtility.MemMove(ptr + toIndex, ptr + startIndex, (long)count * sizeof(T));
 }
}

		[Token(Token = "0x6000F98")]
		public static void RemoveAt(ref UnsafeSpan<T> span, int index)
		{
 if (index < 0 || (uint)index >= span.length) throw new System.ArgumentOutOfRangeException();
 span.Move(unchecked(index + 1), index, unchecked((int)span.length - index - 1));
 span = span.Slice(0, unchecked((int)span.length - 1));
}

		[Token(Token = "0x6000F99")]
		public void CopyTo(UnsafeSpan<T> other)
		{ if (length > other.length) throw new System.ArgumentException(); unsafe { if (length != 0) UnsafeUtility.MemCpy(other.ptr, ptr, (long)length * sizeof(T)); } }

		[Token(Token = "0x6000F9A")]
		public void CopyTo(List<T> buffer)
		{
 if (buffer.Capacity < unchecked(buffer.Count + (int)length)) buffer.Capacity = unchecked(buffer.Count + (int)length);
 for (int i = 0; i < unchecked((int)length); i = unchecked(i + 1)) buffer.Add(this[i]);
}

		[Token(Token = "0x6000F9B")]
		public UnsafeSpan<T> Clone(Allocator allocator)
		{
 var result = new UnsafeSpan<T>(allocator, unchecked((int)length));
 CopyTo(result);
 return result;
}

		[Token(Token = "0x6000F9C")]
		public T[] ToArray()
		{
 var result = new T[length];
 unsafe {
  if (length != 0) {
   fixed (T* destination = result) UnsafeUtility.MemCpy(destination, ptr, (long)length * sizeof(T));
  }
 }
 return result;
}

		[Token(Token = "0x6000F9D")]
		public NativeArray<T> MoveToNativeArray(Allocator allocator)
		{
 unsafe { return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>(ptr, unchecked((int)length), allocator); }
}

		[Token(Token = "0x6000F9E")]
		public void Free(Allocator expectedAllocator)
		{ unsafe { if (length != 0) UnsafeUtility.FreeTracked(ptr, expectedAllocator); } }

		[Token(Token = "0x6000F9F")]
		public void Free()
		{ unsafe { if (length != 0) UnsafeUtility.FreeTracked(ptr, Allocator); } }

		[Token(Token = "0x6000FA0")]
		public UnsafeSpan<T> Reallocate(Allocator allocator, int newSize)
		{
    if (newSize < 0) throw new System.ArgumentOutOfRangeException(nameof(newSize), "New size must be non-negative");
    if (length == unchecked((uint)newSize)) return this;
    UnsafeSpan<T> result = new UnsafeSpan<T>(allocator, newSize);
    Slice(0, System.Math.Min(newSize, unchecked((int)length))).CopyTo(result);
    Free(allocator);
    return result;
}
	}
}
