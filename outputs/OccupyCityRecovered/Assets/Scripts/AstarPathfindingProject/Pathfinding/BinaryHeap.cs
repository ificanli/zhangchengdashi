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
 return unchecked((uint)(sortKey >> 32));
}
				[Token(Token = "0x6000399")]
				[Address(RVA = "0x44F32D4", Offset = "0x44EF2D4", VA = "0x44F32D4")]
				set
				{
 sortKey = ((ulong)value << 32) | (sortKey & 0xffffffffUL);
}
			}

			[Token(Token = "0x170000D2")]
			public uint TieBreaker
			{
				[Token(Token = "0x600039A")]
				[Address(RVA = "0x44F3164", Offset = "0x44EF164", VA = "0x44F3164")]
				get
				{
 return unchecked((uint)sortKey);
}
				[Token(Token = "0x600039B")]
				[Address(RVA = "0x44F32CC", Offset = "0x44EF2CC", VA = "0x44F32CC")]
				set
				{
 sortKey = (sortKey & 0xffffffff00000000UL) | value;
}
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x44F442C", Offset = "0x44F042C", VA = "0x44F442C")]
			public HeapNode(uint pathNodeIndex, uint tieBreaker, uint f)
			{
 this.pathNodeIndex = pathNodeIndex;
 this.sortKey = ((ulong)f << 32) | tieBreaker;
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
			private static IntPtr DeferredCompilation = BurstCompiler.CompileILPPMethod2(new Add_0000036E_0024PostfixBurstDelegate(BinaryHeap.Add).Method.MethodHandle);

			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x44F4C18", Offset = "0x44F0C18", VA = "0x44F4C18")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
 if (Pointer == IntPtr.Zero) {
  unsafe { Pointer = (IntPtr)BurstCompiler.GetILPPMethodFunctionPointer2(DeferredCompilation, new Add_0000036E_0024PostfixBurstDelegate(BinaryHeap.Add_0024BurstManaged).Method.MethodHandle, typeof(Add_0000036E_0024PostfixBurstDelegate).TypeHandle); }
 }
 P_0 = Pointer;
}

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x44F4D34", Offset = "0x44F0D34", VA = "0x44F4D34")]
			private static IntPtr GetFunctionPointer()
			{
 IntPtr pointer = IntPtr.Zero;
 GetFunctionPointerDiscard(ref pointer);
 return pointer;
}

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x44F4D90", Offset = "0x44F0D90", VA = "0x44F4D90")]
			public static void Constructor()
			{
 DeferredCompilation = BurstCompiler.CompileILPPMethod2(new Add_0000036E_0024PostfixBurstDelegate(BinaryHeap.Add).Method.MethodHandle);
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
 if (BurstCompiler.IsEnabled) {
  IntPtr pointer = GetFunctionPointer();
  if (pointer != IntPtr.Zero) {
   new FunctionPointer<Add_0000036E_0024PostfixBurstDelegate>(pointer).Invoke(ref binaryHeap, ref nodes, pathNodeIndex, g, h, insertionOrder, tieBreaking);
   return;
  }
 }
 BinaryHeap.Add_0024BurstManaged(ref binaryHeap, ref nodes, pathNodeIndex, g, h, insertionOrder, tieBreaking);
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
			private static IntPtr DeferredCompilation = BurstCompiler.CompileILPPMethod2(new Remove_00000371_0024PostfixBurstDelegate(BinaryHeap.Remove).Method.MethodHandle);

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x44F5028", Offset = "0x44F1028", VA = "0x44F5028")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
 if (Pointer == IntPtr.Zero) {
  unsafe { Pointer = (IntPtr)BurstCompiler.GetILPPMethodFunctionPointer2(DeferredCompilation, new Remove_00000371_0024PostfixBurstDelegate(BinaryHeap.Remove_0024BurstManaged).Method.MethodHandle, typeof(Remove_00000371_0024PostfixBurstDelegate).TypeHandle); }
 }
 P_0 = Pointer;
}

			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x44F5144", Offset = "0x44F1144", VA = "0x44F5144")]
			private static IntPtr GetFunctionPointer()
			{
 IntPtr pointer = IntPtr.Zero;
 GetFunctionPointerDiscard(ref pointer);
 return pointer;
}

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x44F51A0", Offset = "0x44F11A0", VA = "0x44F51A0")]
			public static void Constructor()
			{
 DeferredCompilation = BurstCompiler.CompileILPPMethod2(new Remove_00000371_0024PostfixBurstDelegate(BinaryHeap.Remove).Method.MethodHandle);
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
 if (BurstCompiler.IsEnabled) {
  IntPtr pointer = GetFunctionPointer();
  if (pointer != IntPtr.Zero) return new FunctionPointer<Remove_00000371_0024PostfixBurstDelegate>(pointer).Invoke(ref nodes, ref binaryHeap, out removedTieBreaker, out removedF);
 }
 return BinaryHeap.Remove_0024BurstManaged(ref nodes, ref binaryHeap, out removedTieBreaker, out removedF);
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
 return numberOfItems < 1;
}
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x44F2D60", Offset = "0x44EED60", VA = "0x44F2D60")]
		private static int RoundUpToNextMultipleMod1(int v)
		{
 unchecked { int remainder = (v - 1) % 4; return v + ((4 - remainder) % 4); }
}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x44F2D98", Offset = "0x44EED98", VA = "0x44F2D98")]
		public BinaryHeap(int capacity)
		{
 var allocated = new UnsafeSpan<HeapNode>(Unity.Collections.Allocator.Persistent, RoundUpToNextMultipleMod1(capacity));
 numberOfItems = 0;
 insertionOrder = 0;
 tieBreaking = TieBreaking.HScore;
 heap = allocated;
}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x44F2E44", Offset = "0x44EEE44", VA = "0x44F2E44")]
		public void Dispose()
		{
 heap.Free(Unity.Collections.Allocator.Persistent);
}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x44F2EE8", Offset = "0x44EEEE8", VA = "0x44F2EE8")]
		public void Clear(UnsafeSpan<PathNode> pathNodes)
		{
 for (int i = 0; i < numberOfItems; i++) pathNodes[heap[i].pathNodeIndex].heapIndex = NotInHeap;
 numberOfItems = 0;
 insertionOrder = 0;
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x44F301C", Offset = "0x44EF01C", VA = "0x44F301C")]
		public uint GetPathNodeIndex(int heapIndex)
		{
 return heap[heapIndex].pathNodeIndex;
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x44F30B8", Offset = "0x44EF0B8", VA = "0x44F30B8")]
		public uint GetH(int heapIndex)
		{
 return tieBreaking == TieBreaking.HScore ? heap[heapIndex].TieBreaker : 0;
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x44F316C", Offset = "0x44EF16C", VA = "0x44F316C")]
		public uint GetF(int heapIndex)
		{
 return heap[heapIndex].F;
}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x44F3210", Offset = "0x44EF210", VA = "0x44F3210")]
		public void SetH(int heapIndex, uint h)
		{
 ref HeapNode node = ref heap[heapIndex];
 node.F = unchecked(h - node.TieBreaker + node.F);
 node.TieBreaker = h;
}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x44F32DC", Offset = "0x44EF2DC", VA = "0x44F32DC")]
		private static void Expand(ref UnsafeSpan<HeapNode> heap)
		{
 int newCapacity = RoundUpToNextMultipleMod1(System.Math.Max(unchecked(heap.Length + 4), System.Math.Min(65533, UnityEngine.Mathf.RoundToInt(heap.Length * GrowthFactor))));
 if (newCapacity >= NotInHeap) throw new System.Exception("Binary Heap Size really large (>65534). A heap size this large is probably the cause of pathfinding running in an infinite loop. ");
 var next = new UnsafeSpan<HeapNode>(Unity.Collections.Allocator.Persistent, newCapacity);
 next.CopyFrom(heap);
 heap.Free(Unity.Collections.Allocator.Persistent);
 heap = next;
}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x44F3590", Offset = "0x44EF590", VA = "0x44F3590")]
		public void Add(UnsafeSpan<PathNode> nodes, uint pathNodeIndex, uint g, uint h)
		{
 uint order = insertionOrder;
 insertionOrder = unchecked(order + 1);
 Add(ref this, ref nodes, pathNodeIndex, g, h, order, tieBreaking);
}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x44F35D0", Offset = "0x44EF5D0", VA = "0x44F35D0")]
		[BurstCompile]
		private static void Add(ref BinaryHeap binaryHeap, ref UnsafeSpan<PathNode> nodes, uint pathNodeIndex, uint g, uint h, uint insertionOrder, TieBreaking tieBreaking)
		{
 Add_0000036E_0024BurstDirectCall.Invoke(ref binaryHeap, ref nodes, pathNodeIndex, g, h, insertionOrder, tieBreaking);
}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x44F377C", Offset = "0x44EF77C", VA = "0x44F377C")]
		private static void DecreaseKey(UnsafeSpan<HeapNode> heap, UnsafeSpan<PathNode> nodes, HeapNode node, ushort index)
		{
 uint position = index;
 while (position != 0) {
  uint parent = (position - 1) / D;
  Unity.Burst.CompilerServices.Hint.Assume(parent < heap.length);
  Unity.Burst.CompilerServices.Hint.Assume(position < heap.length);
  if (node.sortKey >= heap[parent].sortKey) break;
  heap[position] = heap[parent];
  nodes[heap[position].pathNodeIndex].heapIndex = unchecked((ushort)position);
  position = parent;
 }
 Unity.Burst.CompilerServices.Hint.Assume(position < heap.length);
 heap[position] = node;
 nodes[node.pathNodeIndex].heapIndex = unchecked((ushort)position);
}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x44F3A08", Offset = "0x44EFA08", VA = "0x44F3A08")]
		public uint Remove(UnsafeSpan<PathNode> nodes, out uint g, out uint h)
		{
 uint tieBreaker;
 uint f;
 uint result = Remove(ref nodes, ref this, out tieBreaker, out f);
 h = tieBreaking == TieBreaking.HScore ? tieBreaker : 0;
 g = unchecked(f - h);
 return result;
}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x44F3A6C", Offset = "0x44EFA6C", VA = "0x44F3A6C")]
		[BurstCompile]
		private static uint Remove(ref UnsafeSpan<PathNode> nodes, ref BinaryHeap binaryHeap, [NoAlias] out uint removedTieBreaker, [NoAlias] out uint removedF)
		{
 return Remove_00000371_0024BurstDirectCall.Invoke(ref nodes, ref binaryHeap, out removedTieBreaker, out removedF);
}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x44F3BC8", Offset = "0x44EFBC8", VA = "0x44F3BC8")]
		[Conditional("VALIDATE_BINARY_HEAP")]
		private static void Validate(ref UnsafeSpan<PathNode> nodes, ref BinaryHeap binaryHeap)
		{
 for (int i = 1; i < binaryHeap.numberOfItems; i++) {
  int parent = (i - 1) / D;
  if (binaryHeap.heap[parent].F > binaryHeap.heap[i].F || binaryHeap.heap[parent].sortKey > binaryHeap.heap[i].sortKey)
   throw new System.Exception("Invalid state at " + i + ":" + parent + " ( " + binaryHeap.heap[parent].F + " > " + binaryHeap.heap[i].F + " ) ");
  if (nodes[binaryHeap.heap[i].pathNodeIndex].heapIndex != i) throw new System.Exception("Invalid heap index");
 }
}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x44F4018", Offset = "0x44F0018", VA = "0x44F4018")]
		public void Rebuild(UnsafeSpan<PathNode> nodes)
		{
 for (int i = 2; i < numberOfItems; i++) {
  int position = i;
  HeapNode node = heap[position];
  while (true) {
   int parent = position / D;
   if (node.F >= heap[parent].F) break;
   heap[position] = heap[parent];
   nodes[heap[position].pathNodeIndex].heapIndex = unchecked((ushort)position);
   heap[parent] = node;
   nodes[heap[parent].pathNodeIndex].heapIndex = unchecked((ushort)parent);
   if ((position & ~3) == 4) break;
   position = parent;
  }
 }
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x44F42B4", Offset = "0x44F02B4", VA = "0x44F42B4")]
		[BurstCompile]
		public static void Add_0024BurstManaged(ref BinaryHeap binaryHeap, ref UnsafeSpan<PathNode> nodes, uint pathNodeIndex, uint g, uint h, uint insertionOrder, TieBreaking tieBreaking)
		{
 uint tie = tieBreaking == TieBreaking.HScore ? h : unchecked(4 * insertionOrder);
 uint f = unchecked(g + h);
 ushort index = nodes[pathNodeIndex].heapIndex;
 HeapNode node = new HeapNode(pathNodeIndex, tie, f);
 if (index == NotInHeap) {
  if (binaryHeap.numberOfItems == binaryHeap.heap.Length) Expand(ref binaryHeap.heap);
  DecreaseKey(binaryHeap.heap, nodes, node, unchecked((ushort)binaryHeap.numberOfItems));
  binaryHeap.numberOfItems = unchecked(binaryHeap.numberOfItems + 1);
 } else {
  DecreaseKey(binaryHeap.heap, nodes, node, index);
 }
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x44F4440", Offset = "0x44F0440", VA = "0x44F4440")]
		[BurstCompile]
		public static uint Remove_0024BurstManaged(ref UnsafeSpan<PathNode> nodes, ref BinaryHeap binaryHeap, [NoAlias] out uint removedTieBreaker, [NoAlias] out uint removedF)
		{
 if (binaryHeap.numberOfItems == 0) throw new System.InvalidOperationException("Removing item from empty heap");
 UnsafeSpan<HeapNode> heap = binaryHeap.heap;
 HeapNode root = heap[0];
 uint removed = root.pathNodeIndex;
 nodes[removed].heapIndex = NotInHeap;
 removedTieBreaker = root.TieBreaker;
 removedF = root.F;
 binaryHeap.numberOfItems = unchecked(binaryHeap.numberOfItems - 1);
 int count = binaryHeap.numberOfItems;
 if (count != 0) {
  HeapNode last = heap[count];
  uint position = 0;
  uint firstChild = 1;
  while (firstChild < count) {
   ulong key0 = heap[firstChild].sortKey & ~3UL;
   ulong key1 = (heap[firstChild + 1].sortKey & ~3UL) | 1UL;
   ulong key2 = (heap[firstChild + 2].sortKey & ~3UL) | 2UL;
   ulong key3 = heap[firstChild + 3].sortKey | 3UL;
   ulong best = key0;
   if (firstChild + 1 < count && key1 < best) best = key1;
   if (firstChild + 2 < count && key2 < best) best = key2;
   if (firstChild + 3 < count && key3 < best) best = key3;
   if ((best & ~3UL) >= (last.sortKey & ~3UL)) break;
   uint child = firstChild + unchecked((uint)(best & 3UL));
   heap[position] = heap[child];
   nodes[heap[child].pathNodeIndex].heapIndex = unchecked((ushort)position);
   position = child;
   firstChild = unchecked(4 * position + 1);
  }
  heap[position] = last;
  nodes[last.pathNodeIndex].heapIndex = unchecked((ushort)position);
 }
 return removed;
}
	}
}
