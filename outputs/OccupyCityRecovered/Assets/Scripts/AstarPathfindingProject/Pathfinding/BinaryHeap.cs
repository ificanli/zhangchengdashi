using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Pathfinding.Collections;
using Unity.Burst;

namespace Pathfinding
{
	[Token(Token = "0x200005A")]
	[BurstCompile]
	public struct BinaryHeap
	{
		[Token(Token = "0x200005B")]
		public enum TieBreaking : byte
		{
			[Token(Token = "0x4000211")]
			HScore = 0,
			[Token(Token = "0x4000212")]
			InsertionOrder = 1
		}

		[Token(Token = "0x200005C")]
		private struct HeapNode
		{
			[Token(Token = "0x4000213")]
			[FieldOffset(Offset = "0x0")]
			public uint pathNodeIndex;

			[Token(Token = "0x4000214")]
			[FieldOffset(Offset = "0x8")]
			public ulong sortKey;

			[Token(Token = "0x170000D1")]
			public uint F
			{
				[Token(Token = "0x6000398")]
				[Address(RVA = "0x44F3208", Offset = "0x44EF208", VA = "0x44F3208")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000399")]
				[Address(RVA = "0x44F32D4", Offset = "0x44EF2D4", VA = "0x44F32D4")]
				set
				{
				}
			}

			[Token(Token = "0x170000D2")]
			public uint TieBreaker
			{
				[Token(Token = "0x600039A")]
				[Address(RVA = "0x44F3164", Offset = "0x44EF164", VA = "0x44F3164")]
				get
				{
					return default;
				}
				[Token(Token = "0x600039B")]
				[Address(RVA = "0x44F32CC", Offset = "0x44EF2CC", VA = "0x44F32CC")]
				set
				{
				}
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x44F442C", Offset = "0x44F042C", VA = "0x44F442C")]
			public HeapNode(uint pathNodeIndex, uint tieBreaker, uint f)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BinaryHeap.HeapNode..ctor RVA=0x44F442C Token=0x6000397");
}
		}

		[Token(Token = "0x200005D")]
		public delegate void Add_0000036E_0024PostfixBurstDelegate(ref BinaryHeap binaryHeap, ref UnsafeSpan<PathNode> nodes, uint pathNodeIndex, uint g, uint h, uint insertionOrder, TieBreaking tieBreaking);

		[Token(Token = "0x200005E")]
		internal static class Add_0000036E_0024BurstDirectCall
		{
			[Token(Token = "0x4000215")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000216")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x44F4C18", Offset = "0x44F0C18", VA = "0x44F4C18")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x44F4D34", Offset = "0x44F0D34", VA = "0x44F4D34")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x44F4D90", Offset = "0x44F0D90", VA = "0x44F4D90")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x44F4E38", Offset = "0x44F0E38", VA = "0x44F4E38")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x44F366C", Offset = "0x44EF66C", VA = "0x44F366C")]
			public static void Invoke(ref BinaryHeap binaryHeap, ref UnsafeSpan<PathNode> nodes, uint pathNodeIndex, uint g, uint h, uint insertionOrder, TieBreaking tieBreaking)
			{
			}
		}

		[Token(Token = "0x200005F")]
		public delegate uint Remove_00000371_0024PostfixBurstDelegate(ref UnsafeSpan<PathNode> nodes, ref BinaryHeap binaryHeap, [NoAlias] out uint removedTieBreaker, [NoAlias] out uint removedF);

		[Token(Token = "0x2000060")]
		internal static class Remove_00000371_0024BurstDirectCall
		{
			[Token(Token = "0x4000217")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			[Token(Token = "0x4000218")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x44F5028", Offset = "0x44F1028", VA = "0x44F5028")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x44F5144", Offset = "0x44F1144", VA = "0x44F5144")]
			private static IntPtr GetFunctionPointer()
			{
				return default;
			}

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x44F51A0", Offset = "0x44F11A0", VA = "0x44F51A0")]
			public static void Constructor()
			{
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x44F5248", Offset = "0x44F1248", VA = "0x44F5248")]
			public static void Initialize()
			{
			}

			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x44F3AE8", Offset = "0x44EFAE8", VA = "0x44F3AE8")]
			public static uint Invoke(ref UnsafeSpan<PathNode> nodes, ref BinaryHeap binaryHeap, [NoAlias] out uint removedTieBreaker, [NoAlias] out uint removedF)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BinaryHeap.Remove_00000371_0024BurstDirectCall.Invoke RVA=0x44F3AE8 Token=0x60003AF");
}
		}

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x0")]
		private UnsafeSpan<HeapNode> heap;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x10")]
		public int numberOfItems;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x14")]
		private uint insertionOrder;

		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x18")]
		public TieBreaking tieBreaking;

		[Token(Token = "0x400020D")]
		public const float GrowthFactor = 2f;

		[Token(Token = "0x400020E")]
		private const int D = 4;

		[Token(Token = "0x400020F")]
		public const ushort NotInHeap = ushort.MaxValue;

		[Token(Token = "0x170000D0")]
		public bool isEmpty
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x44F2D50", Offset = "0x44EED50", VA = "0x44F2D50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x44F2D60", Offset = "0x44EED60", VA = "0x44F2D60")]
		private static int RoundUpToNextMultipleMod1(int v)
		{
			return default;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x44F2D98", Offset = "0x44EED98", VA = "0x44F2D98")]
		public BinaryHeap(int capacity)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BinaryHeap..ctor RVA=0x44F2D98 Token=0x6000386");
}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x44F2E44", Offset = "0x44EEE44", VA = "0x44F2E44")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x44F2EE8", Offset = "0x44EEEE8", VA = "0x44F2EE8")]
		public void Clear(UnsafeSpan<PathNode> pathNodes)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x44F301C", Offset = "0x44EF01C", VA = "0x44F301C")]
		public uint GetPathNodeIndex(int heapIndex)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x44F30B8", Offset = "0x44EF0B8", VA = "0x44F30B8")]
		public uint GetH(int heapIndex)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x44F316C", Offset = "0x44EF16C", VA = "0x44F316C")]
		public uint GetF(int heapIndex)
		{
			return default;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x44F3210", Offset = "0x44EF210", VA = "0x44F3210")]
		public void SetH(int heapIndex, uint h)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x44F32DC", Offset = "0x44EF2DC", VA = "0x44F32DC")]
		private static void Expand(ref UnsafeSpan<HeapNode> heap)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x44F3590", Offset = "0x44EF590", VA = "0x44F3590")]
		public void Add(UnsafeSpan<PathNode> nodes, uint pathNodeIndex, uint g, uint h)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x44F35D0", Offset = "0x44EF5D0", VA = "0x44F35D0")]
		[BurstCompile]
		private static void Add(ref BinaryHeap binaryHeap, ref UnsafeSpan<PathNode> nodes, uint pathNodeIndex, uint g, uint h, uint insertionOrder, TieBreaking tieBreaking)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x44F377C", Offset = "0x44EF77C", VA = "0x44F377C")]
		private static void DecreaseKey(UnsafeSpan<HeapNode> heap, UnsafeSpan<PathNode> nodes, HeapNode node, ushort index)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x44F3A08", Offset = "0x44EFA08", VA = "0x44F3A08")]
		public uint Remove(UnsafeSpan<PathNode> nodes, out uint g, out uint h)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BinaryHeap.Remove RVA=0x44F3A08 Token=0x6000391");
}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x44F3A6C", Offset = "0x44EFA6C", VA = "0x44F3A6C")]
		[BurstCompile]
		private static uint Remove(ref UnsafeSpan<PathNode> nodes, ref BinaryHeap binaryHeap, [NoAlias] out uint removedTieBreaker, [NoAlias] out uint removedF)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BinaryHeap.Remove RVA=0x44F3A6C Token=0x6000392");
}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x44F3BC8", Offset = "0x44EFBC8", VA = "0x44F3BC8")]
		[Conditional("VALIDATE_BINARY_HEAP")]
		private static void Validate(ref UnsafeSpan<PathNode> nodes, ref BinaryHeap binaryHeap)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x44F4018", Offset = "0x44F0018", VA = "0x44F4018")]
		public void Rebuild(UnsafeSpan<PathNode> nodes)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x44F42B4", Offset = "0x44F02B4", VA = "0x44F42B4")]
		[BurstCompile]
		public static void Add_0024BurstManaged(ref BinaryHeap binaryHeap, ref UnsafeSpan<PathNode> nodes, uint pathNodeIndex, uint g, uint h, uint insertionOrder, TieBreaking tieBreaking)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x44F4440", Offset = "0x44F0440", VA = "0x44F4440")]
		[BurstCompile]
		public static uint Remove_0024BurstManaged(ref UnsafeSpan<PathNode> nodes, ref BinaryHeap binaryHeap, [NoAlias] out uint removedTieBreaker, [NoAlias] out uint removedF)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED BinaryHeap.Remove_0024BurstManaged RVA=0x44F4440 Token=0x6000396");
}
	}
}
