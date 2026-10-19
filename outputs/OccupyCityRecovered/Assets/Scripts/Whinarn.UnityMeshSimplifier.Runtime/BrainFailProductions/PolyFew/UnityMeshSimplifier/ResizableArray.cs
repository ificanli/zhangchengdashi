using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x2000021")]
	internal sealed class ResizableArray<T>
	{
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x0")]
		private T[] items;

		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x0")]
		private int length;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x0")]
		private static T[] emptyArr;

		[Token(Token = "0x1700003B")]
		public int Length
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000133")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003C")]
		public T[] Data
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public T this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000135")]
			get
			{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ResizableArray.indexer.get RVA= Token=0x6000135");
}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000136")]
			set
			{
			}
		}

		[Token(Token = "0x6000137")]
		public ResizableArray(int capacity)
		{
		}

		[Token(Token = "0x6000138")]
		public ResizableArray(int capacity, int length)
		{
		}

		[Token(Token = "0x6000139")]
		public ResizableArray(T[] initialArray)
		{
		}

		[Token(Token = "0x600013A")]
		private void IncreaseCapacity(int capacity)
		{
		}

		[Token(Token = "0x600013B")]
		public void Clear()
		{
		}

		[Token(Token = "0x600013C")]
		public void Resize(int length, bool trimExess = false, bool clearMemory = false)
		{
		}

		[Token(Token = "0x600013D")]
		public void TrimExcess()
		{
		}

		[Token(Token = "0x600013E")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x600013F")]
		public T[] ToArray()
		{
			return null;
		}
	}
}
