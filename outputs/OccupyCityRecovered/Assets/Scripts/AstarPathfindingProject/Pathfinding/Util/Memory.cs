using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace Pathfinding.Util
{
	[Token(Token = "0x200028B")]
	public static class Memory
	{
		[Token(Token = "0x600101E")]
		public static T[] ShrinkArray<T>(T[] arr, int newLength)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600101F")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x6001020")]
		public static void Realloc<T>(ref NativeArray<T> arr, int newSize, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory) where T : struct
		{
		}

		[Token(Token = "0x6001021")]
		public static void Realloc<T>(ref T[] arr, int newSize)
		{ if (arr != null && arr.Length >= newSize) return; var result = new T[newSize]; if (arr != null) arr.CopyTo(result, 0); arr = result; }

		[Token(Token = "0x6001022")]
		public static T[] UnsafeAppendBufferToArray<T>(UnsafeAppendBuffer src) where T : struct
		{
			return null;
		}

		[Token(Token = "0x6001023")]
		public static bool SequenceEqual<T>(T[] a, T[] b) where T : IEquatable<T>
		{
			return default;
		}

		[Token(Token = "0x6001024")]
		public static void Rotate3DArray<T>(T[] arr, int3 size, int dx, int dz)
		{
		}
	}
}
