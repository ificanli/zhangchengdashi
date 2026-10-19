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
		{
		}

		[Token(Token = "0x6000FA2")]
		public static void Fill<T>(this UnsafeSpan<T> span, T value) where T : unmanaged
		{
		}

		[Token(Token = "0x6000FA3")]
		public static void CopyFrom<T>(this UnsafeSpan<T> span, NativeArray<T> array) where T : unmanaged
		{
		}

		[Token(Token = "0x6000FA4")]
		public static void CopyFrom<T>(this UnsafeSpan<T> span, UnsafeSpan<T> other) where T : unmanaged
		{
		}

		[Token(Token = "0x6000FA5")]
		public static void CopyFrom<T>(this UnsafeSpan<T> span, T[] array) where T : unmanaged
		{
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
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000FA8")]
		public static UnsafeSpan<T> AsUnsafeSpan<T>(this NativeArray<T> arr) where T : unmanaged
		{
			return default;
		}

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
			return default;
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
