using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Pathfinding.Collections
{
	[Token(Token = "0x2000275")]
	public static class SpanExtensions
	{
		[Token(Token = "0x4000B72")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int AllocatorOffset;

		[Token(Token = "0x6000FA1")]
		public static void FillZeros<T>(this UnsafeSpan<T> span) where T : unmanaged
		{ unsafe { if (span.length != 0) UnsafeUtility.MemSet(span.ptr, 0, (long)span.length * sizeof(T)); } }

		[Token(Token = "0x6000FA2")]
		public static void Fill<T>(this UnsafeSpan<T> span, T value) where T : unmanaged
		{
 if (span.length != 0) {
  unsafe {
   if (span.length > int.MaxValue / sizeof(T)) throw new System.ArgumentException("Span is too large to fill");
   UnsafeUtility.MemCpyReplicate(span.ptr, &value, sizeof(T), unchecked((int)span.length));
  }
 }
}

		[Token(Token = "0x6000FA3")]
		public static void CopyFrom<T>(this UnsafeSpan<T> span, NativeArray<T> array) where T : unmanaged
		{
 unsafe {
  var source = new UnsafeSpan<T>(NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr(array), array.Length, Allocator.None);
  source.CopyTo(span);
 }
}

		[Token(Token = "0x6000FA4")]
		public static void CopyFrom<T>(this UnsafeSpan<T> span, UnsafeSpan<T> other) where T : unmanaged
		{ other.CopyTo(span); }

		[Token(Token = "0x6000FA5")]
		public static void CopyFrom<T>(this UnsafeSpan<T> span, T[] array) where T : unmanaged
		{
 if (unchecked((int)span.length) < array.Length) throw new System.InvalidOperationException();
 if (array.Length != 0) {
  unsafe {
   ulong gcHandle;
   void* source = UnsafeUtility.PinGCArrayAndGetDataAddress(array, out gcHandle);
   UnsafeUtility.MemCpy(span.ptr, source, (long)array.Length * sizeof(T));
   UnsafeUtility.ReleaseGCObject(gcHandle);
  }
 }
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000FA6")]
		public static UnsafeSpan<T> AsUnsafeSpan<T>(this UnsafeAppendBuffer buffer) where T : unmanaged
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000FA7")]
		public static UnsafeSpan<T> AsUnsafeSpan<T>(this NativeList<T> list) where T : unmanaged
		{
 unsafe { return new UnsafeSpan<T>(Unity.Collections.LowLevel.Unsafe.NativeListUnsafeUtility.GetUnsafePtr(list), list.Length); }
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000FA8")]
		public static UnsafeSpan<T> AsUnsafeSpan<T>(this NativeArray<T> arr) where T : unmanaged
		{ unsafe { return new UnsafeSpan<T>(Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafePtr(arr),arr.Length); } }

		[Token(Token = "0x6000FA9")]
		public static UnsafeSpan<T> MoveToUnsafeSpan<T>(this NativeArray<T> arr) where T : unmanaged
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000FAA")]
		public static UnsafeSpan<T> AsUnsafeSpanNoChecks<T>(this NativeArray<T> arr) where T : unmanaged
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000FAB")]
		public static UnsafeSpan<T> AsUnsafeReadOnlySpan<T>(this NativeArray<T> arr) where T : unmanaged
		{
 unsafe { return new UnsafeSpan<T>(Unity.Collections.LowLevel.Unsafe.NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr(arr),arr.Length); }
}

		[Token(Token = "0x6000FAC")]
		public static Allocator GetAllocator<T>(this NativeArray<T> arr) where T : struct
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000FAD")]
		public static UnsafeSpan<T> AsUnsafeSpan<T>(this UnsafeList<T> arr) where T : unmanaged
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000FAE")]
		public static UnsafeSpan<T> AsUnsafeSpan<T>(this NativeSlice<T> slice) where T : unmanaged
		{
			return default;
		}

		[Token(Token = "0x6000FAF")]
		public static bool Contains<T>(this UnsafeSpan<T> span, T value) where T : unmanaged, IEquatable<T>
		{
			return default;
		}

		[Token(Token = "0x6000FB0")]
		public static int IndexOf<T>(this UnsafeSpan<T> span, T value) where T : unmanaged, IEquatable<T>
		{
			return default;
		}

		[Token(Token = "0x6000FB1")]
		public static void Sort<T>(this UnsafeSpan<T> span) where T : unmanaged, IComparable<T>
		{
 unsafe { Unity.Collections.NativeSortExtension.Sort(span.ptr, span.Length); }
}

		[Token(Token = "0x6000FB2")]
		public static void Sort<T, U>(this UnsafeSpan<T> span, U comp) where T : unmanaged where U : IComparer<T>
		{
		}

		[Token(Token = "0x6000FB3")]
		public static void InsertRange<T>(this NativeList<T> list, int index, int count) where T : unmanaged
		{
		}
	}
}
