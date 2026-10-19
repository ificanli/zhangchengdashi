using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Pathfinding.Collections
{
	[Token(Token = "0x200026D")]
	public struct SlabAllocator<T> where T : unmanaged
	{
		[Token(Token = "0x200026E")]
		private struct AllocatorData
		{
			[Token(Token = "0x4000B67")]
			[FieldOffset(Offset = "0x0")]
			public UnsafeList<byte> mem;

			[Token(Token = "0x4000B68")]
			[FieldOffset(Offset = "0x0")]
			public unsafe fixed int freeHeads[13];
		}

		[Token(Token = "0x2000270")]
		private struct Header
		{
			[Token(Token = "0x4000B6A")]
			[FieldOffset(Offset = "0x0")]
			public uint length;
		}

		[Token(Token = "0x2000271")]
		private struct NextBlock
		{
			[Token(Token = "0x4000B6B")]
			[FieldOffset(Offset = "0x0")]
			public int next;
		}

		[Token(Token = "0x2000272")]
		public ref struct List
		{
			[Token(Token = "0x4000B6C")]
			[FieldOffset(Offset = "0x0")]
			public UnsafeSpan<T> span;

			[Token(Token = "0x4000B6D")]
			[FieldOffset(Offset = "0x0")]
			private SlabAllocator<T> allocator;

			[Token(Token = "0x4000B6E")]
			[FieldOffset(Offset = "0x0")]
			public int allocationIndex;

			[Token(Token = "0x1700024D")]
			public int Length
			{
				[Token(Token = "0x6000F88")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700024E")]
			public unsafe ref T this[int index]
			{
				[MethodImpl(MethodImplOptions.AggressiveInlining)]
				[Token(Token = "0x6000F89")]
				get
				{
					return ref *(T*)null;
				}
			}

			[Token(Token = "0x6000F84")]
			public List(SlabAllocator<T> allocator, int allocationIndex)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SlabAllocator.List..ctor RVA= Token=0x6000F84");
}

			[Token(Token = "0x6000F85")]
			public void Add(T value)
			{
			}

			[Token(Token = "0x6000F86")]
			public void RemoveAt(int index)
			{
			}

			[Token(Token = "0x6000F87")]
			public void Clear()
			{
			}
		}

		[Token(Token = "0x4000B5F")]
		public const int InvalidAllocation = -2;

		[Token(Token = "0x4000B60")]
		public const int ZeroLengthArray = -1;

		[Token(Token = "0x4000B61")]
		public const int MaxAllocationSizeIndex = 12;

		[Token(Token = "0x4000B62")]
		public const int MaxAllocationSize = 4096;

		[Token(Token = "0x4000B63")]
		private const uint UsedBit = 2147483648u;

		[Token(Token = "0x4000B64")]
		private const uint AllocatedBit = 1073741824u;

		[Token(Token = "0x4000B65")]
		private const uint LengthMask = 1073741823u;

		[Token(Token = "0x4000B66")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe AllocatorData* data;

		[Token(Token = "0x1700024A")]
		public bool IsDebugAllocator
		{
			[Token(Token = "0x6000F75")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700024B")]
		public bool IsCreated
		{
			[Token(Token = "0x6000F76")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700024C")]
		public int ByteSize
		{
			[Token(Token = "0x6000F77")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000F73")]
		internal static int SizeIndexToElements(int sizeIndex)
		{
			return default;
		}

		[Token(Token = "0x6000F74")]
		internal static int ElementsToSizeIndex(int nElements)
		{
			return default;
		}

		[Token(Token = "0x6000F78")]
		public SlabAllocator(int initialCapacityBytes, AllocatorManager.AllocatorHandle allocator)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED SlabAllocator..ctor RVA= Token=0x6000F78");
}

		[Token(Token = "0x6000F79")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000F7A")]
		public UnsafeSpan<T> GetSpan(int allocatedIndex)
		{
			return default;
		}

		[Token(Token = "0x6000F7B")]
		public void Realloc(ref int allocatedIndex, int nElements)
		{
		}

		[Token(Token = "0x6000F7C")]
		public int Allocate(List<T> values)
		{
			return default;
		}

		[Token(Token = "0x6000F7D")]
		public int Allocate(NativeList<T> values)
		{
			return default;
		}

		[Token(Token = "0x6000F7E")]
		public int Allocate(int nElements)
		{
			return default;
		}

		[Token(Token = "0x6000F7F")]
		public void Free(int allocatedIndex)
		{
		}

		[Token(Token = "0x6000F80")]
		public void CopyTo(SlabAllocator<T> other)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F81")]
		private void CheckDisposed()
		{
		}

		[Token(Token = "0x6000F82")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000F83")]
		public List GetList(int allocatedIndex)
		{
			return default;
		}
	}
}
