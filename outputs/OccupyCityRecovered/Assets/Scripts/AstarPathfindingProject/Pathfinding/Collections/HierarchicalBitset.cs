using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;

namespace Pathfinding.Collections
{
	[Token(Token = "0x2000266")]
	[BurstCompile]
	public struct HierarchicalBitset
	{
		[Token(Token = "0x2000267")]
		[BurstCompile]
		public struct Iterator : IEnumerator<UnsafeSpan<int>>, IEnumerator, IDisposable, IEnumerable<UnsafeSpan<int>>, IEnumerable
		{
			[Token(Token = "0x2000268")]
			public delegate bool MoveNextBurst_00000E25_0024PostfixBurstDelegate(ref Iterator iter);

			[Token(Token = "0x2000269")]
			internal static class MoveNextBurst_00000E25_0024BurstDirectCall
			{
				[Token(Token = "0x4000B50")]
				[FieldOffset(Offset = "0x0")]
				private static IntPtr Pointer;

				[Token(Token = "0x4000B51")]
				[FieldOffset(Offset = "0x8")]
				private static IntPtr DeferredCompilation;

				[Token(Token = "0x6000F3F")]
				[Address(RVA = "0x448CA8C", Offset = "0x4488A8C", VA = "0x448CA8C")]
				[BurstDiscard]
				private static void GetFunctionPointerDiscard(ref IntPtr P_0)
				{
				}

				[Token(Token = "0x6000F40")]
				[Address(RVA = "0x448CBA8", Offset = "0x4488BA8", VA = "0x448CBA8")]
				private static IntPtr GetFunctionPointer()
				{
					return default;
				}

				[Token(Token = "0x6000F41")]
				[Address(RVA = "0x448CC04", Offset = "0x4488C04", VA = "0x448CC04")]
				public static void Constructor()
				{
				}

				[Token(Token = "0x6000F42")]
				[Address(RVA = "0x448CCAC", Offset = "0x4488CAC", VA = "0x448CCAC")]
				public static void Initialize()
				{
				}

				[Token(Token = "0x6000F44")]
				[Address(RVA = "0x448C538", Offset = "0x4488538", VA = "0x448C538")]
				public static bool Invoke(ref Iterator iter)
				{
					return default;
				}
			}

			[Token(Token = "0x4000B4A")]
			[FieldOffset(Offset = "0x0")]
			private HierarchicalBitset bitSet;

			[Token(Token = "0x4000B4B")]
			[FieldOffset(Offset = "0x38")]
			private UnsafeSpan<int> result;

			[Token(Token = "0x4000B4C")]
			[FieldOffset(Offset = "0x48")]
			private int resultCount;

			[Token(Token = "0x4000B4D")]
			[FieldOffset(Offset = "0x4C")]
			private int l3index;

			[Token(Token = "0x4000B4E")]
			[FieldOffset(Offset = "0x50")]
			private int l3bitIndex;

			[Token(Token = "0x4000B4F")]
			[FieldOffset(Offset = "0x54")]
			private int l2bitIndex;

			[Token(Token = "0x1700023C")]
			public UnsafeSpan<int> Current
			{
				[Token(Token = "0x6000F2E")]
				[Address(RVA = "0x448BE60", Offset = "0x4487E60", VA = "0x448BE60", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x1700023D")]
object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000F2F")]
				[Address(RVA = "0x448C3C4", Offset = "0x44883C4", VA = "0x448C3C4", Slot = "7")]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000F2F")]
			[Address(RVA = "0x448C3C4", Offset = "0x44883C4", VA = "0x448C3C4", Slot = "7")]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000F30")]
			[Address(RVA = "0x448C3FC", Offset = "0x44883FC", VA = "0x448C3FC", Slot = "8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000F31")]
			[Address(RVA = "0x448C434", Offset = "0x4488434", VA = "0x448C434", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000F32")]
			[Address(RVA = "0x448C438", Offset = "0x4488438", VA = "0x448C438", Slot = "9")]
			public IEnumerator<UnsafeSpan<int>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000F33")]
			[Address(RVA = "0x448C49C", Offset = "0x448849C", VA = "0x448C49C", Slot = "10")]
IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000F34")]
			[Address(RVA = "0x448C4D4", Offset = "0x44884D4", VA = "0x448C4D4")]
			private static int l2index(int l3index, int l3bitIndex)
			{
				return default;
			}

			[Token(Token = "0x6000F35")]
			[Address(RVA = "0x448C4DC", Offset = "0x44884DC", VA = "0x448C4DC")]
			private static int l1index(int l2index, int l2bitIndex)
			{
				return default;
			}

			[Token(Token = "0x6000F36")]
			[Address(RVA = "0x448C308", Offset = "0x4488308", VA = "0x448C308")]
			public Iterator(HierarchicalBitset bitSet, UnsafeSpan<int> result)
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HierarchicalBitset.Iterator..ctor RVA=0x448C308 Token=0x6000F36");
}

			[Token(Token = "0x6000F37")]
			[Address(RVA = "0x448BEB0", Offset = "0x4487EB0", VA = "0x448BEB0", Slot = "6")]
			public bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000F38")]
			[Address(RVA = "0x448C4E4", Offset = "0x44884E4", VA = "0x448C4E4")]
			[BurstCompile]
			public static bool MoveNextBurst(ref Iterator iter)
			{
				return default;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F39")]
			[Address(RVA = "0x448C5DC", Offset = "0x44885DC", VA = "0x448C5DC")]
			private bool MoveNextInternal()
			{
				return default;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000F3A")]
			[Address(RVA = "0x448C920", Offset = "0x4488920", VA = "0x448C920")]
			[BurstCompile]
			public static bool MoveNextBurst_0024BurstManaged(ref Iterator iter)
			{
				return default;
			}
		}

		[Token(Token = "0x4000B45")]
		[FieldOffset(Offset = "0x0")]
		private UnsafeSpan<ulong> l1;

		[Token(Token = "0x4000B46")]
		[FieldOffset(Offset = "0x10")]
		private UnsafeSpan<ulong> l2;

		[Token(Token = "0x4000B47")]
		[FieldOffset(Offset = "0x20")]
		private UnsafeSpan<ulong> l3;

		[Token(Token = "0x4000B48")]
		[FieldOffset(Offset = "0x30")]
		private Allocator allocator;

		[Token(Token = "0x4000B49")]
		private const int Log64 = 6;

		[Token(Token = "0x17000239")]
		public bool IsCreated
		{
			[Token(Token = "0x6000F20")]
			[Address(RVA = "0x448B7A4", Offset = "0x44877A4", VA = "0x448B7A4")]
			get
			{ return Capacity > 0; }
		}

		[Token(Token = "0x1700023A")]
		public int Capacity
		{
			[Token(Token = "0x6000F22")]
			[Address(RVA = "0x448B7EC", Offset = "0x44877EC", VA = "0x448B7EC")]
			get
			{ return unchecked(l1.Length << 6); }
			[Token(Token = "0x6000F23")]
			[Address(RVA = "0x448B8AC", Offset = "0x44878AC", VA = "0x448B8AC")]
			set
			{
 if (Capacity > value) throw new ArgumentException("Shrinking the bitset is not supported");
 if (Capacity != value) {
  var result = new HierarchicalBitset(value, allocator);
  l1.CopyTo(result.l1); l2.CopyTo(result.l2); l3.CopyTo(result.l3);
  Dispose();
  this = result;
 }
}
		}

		[Token(Token = "0x1700023B")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000F25")]
			[Address(RVA = "0x448BAF4", Offset = "0x4487AF4", VA = "0x448BAF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x448B66C", Offset = "0x448766C", VA = "0x448B66C")]
		public HierarchicalBitset(int size, Allocator allocator)
		{
 this.allocator = allocator;
 l1 = new UnsafeSpan<ulong>(allocator, unchecked(size + 63) >> 6);
 l2 = new UnsafeSpan<ulong>(allocator, unchecked(size + 4095) >> 12);
 l3 = new UnsafeSpan<ulong>(allocator, unchecked(size + 262143) >> 18);
 l1.FillZeros(); l2.FillZeros(); l3.FillZeros();
}

		[Token(Token = "0x6000F21")]
		[Address(RVA = "0x448B82C", Offset = "0x448782C", VA = "0x448B82C")]
		public void Dispose()
		{ l1.Free(allocator); l2.Free(allocator); l3.Free(allocator); this = default; }

		[Token(Token = "0x6000F24")]
		[Address(RVA = "0x448B9E4", Offset = "0x44879E4", VA = "0x448B9E4")]
		public int Count()
		{
			return default;
		}

		[Token(Token = "0x6000F26")]
		[Address(RVA = "0x448BBCC", Offset = "0x4487BCC", VA = "0x448BBCC")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x448BC60", Offset = "0x4487C60", VA = "0x448BC60")]
		public void GetIndices(NativeList<int> result)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x448BEB4", Offset = "0x4487EB4", VA = "0x448BEB4")]
		private static bool SetAtomic(ref UnsafeSpan<ulong> span, int index)
		{
 int word = index >> 6;
 ulong value = span[word];
 ulong mask = 1UL << index;
 if ((value & mask) != 0) return true;
 for (;;) {
  long previous = System.Threading.Interlocked.CompareExchange(ref Unity.Collections.LowLevel.Unsafe.UnsafeUtility.As<ulong,long>(ref span[word]), unchecked((long)(value | mask)), unchecked((long)value));
  if (unchecked((ulong)previous) == value) return false;
  value = unchecked((ulong)previous);
 }
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x448BFDC", Offset = "0x4487FDC", VA = "0x448BFDC")]
		private static bool ResetAtomic(ref UnsafeSpan<ulong> span, int index)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x448C108", Offset = "0x4488108", VA = "0x448C108")]
		public bool Get(int index)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x448C1AC", Offset = "0x44881AC", VA = "0x448C1AC")]
		public void Set(int index)
		{ if (!SetAtomic(ref l1, index)) { SetAtomic(ref l2, index >> 6); SetAtomic(ref l3, index >> 12); } }

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x448C1FC", Offset = "0x44881FC", VA = "0x448C1FC")]
		public void Reset(int index)
		{
		}

		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x448BE0C", Offset = "0x4487E0C", VA = "0x448BE0C")]
		public Iterator GetIterator(UnsafeSpan<int> scratchBuffer)
		{
			return default;
		}
	}
}
