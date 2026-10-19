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
			{
				return default;
			}
		}

		[Token(Token = "0x17000250")]
		public unsafe ref T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F91")]
			[IgnoredByDeepProfiler]
			get
			{
				return ref *(T*)null;
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
				return ref *(T*)null;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F8C")]
		public unsafe UnsafeSpan(void* ptr, int length, Allocator allocator = Allocator.None)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeSpan..ctor RVA= Token=0x6000F8C");
}

		[Token(Token = "0x6000F8D")]
		public UnsafeSpan(T[] data, Allocator allocator)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeSpan..ctor RVA= Token=0x6000F8D");
}

		[Token(Token = "0x6000F8E")]
		public UnsafeSpan(T[] data, out ulong gcHandle)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeSpan..ctor RVA= Token=0x6000F8E");
}

		[Token(Token = "0x6000F8F")]
		public UnsafeSpan(T[,] data, out ulong gcHandle)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeSpan..ctor RVA= Token=0x6000F8F");
}

		[Token(Token = "0x6000F90")]
		public UnsafeSpan(Allocator allocator, int length)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED UnsafeSpan..ctor RVA= Token=0x6000F90");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F93")]
		public UnsafeSpan<U> Reinterpret<U>() where U : unmanaged
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F94")]
		public UnsafeSpan<U> Reinterpret<U>(int expectedOriginalTypeSize) where U : unmanaged
		{
			return default;
		}

		[Token(Token = "0x6000F95")]
		public UnsafeSpan<T> Slice(int start, int length)
		{
			return default;
		}

		[Token(Token = "0x6000F96")]
		public UnsafeSpan<T> Slice(int start)
		{
			return default;
		}

		[Token(Token = "0x6000F97")]
		public void Move(int startIndex, int toIndex, int count)
		{
		}

		[Token(Token = "0x6000F98")]
		public static void RemoveAt(ref UnsafeSpan<T> span, int index)
		{
		}

		[Token(Token = "0x6000F99")]
		public void CopyTo(UnsafeSpan<T> other)
		{
		}

		[Token(Token = "0x6000F9A")]
		public void CopyTo(List<T> buffer)
		{
		}

		[Token(Token = "0x6000F9B")]
		public UnsafeSpan<T> Clone(Allocator allocator)
		{
			return default;
		}

		[Token(Token = "0x6000F9C")]
		public T[] ToArray()
		{
			return null;
		}

		[Token(Token = "0x6000F9D")]
		public NativeArray<T> MoveToNativeArray(Allocator allocator)
		{
			return default;
		}

		[Token(Token = "0x6000F9E")]
		public void Free(Allocator expectedAllocator)
		{
		}

		[Token(Token = "0x6000F9F")]
		public void Free()
		{
		}

		[Token(Token = "0x6000FA0")]
		public UnsafeSpan<T> Reallocate(Allocator allocator, int newSize)
		{
			return default;
		}
	}
}
