using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BrainFailProductions.PolyFew.UnityMeshSimplifier
{
	[Token(Token = "0x200001D")]
	internal class UVChannels<TVec>
	{
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int UVChannelCount;

		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x0")]
		private ResizableArray<TVec>[] channels;

		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x0")]
		private TVec[][] channelsData;

		[Token(Token = "0x17000039")]
		public TVec[][] Data
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public ResizableArray<TVec> this[int index]
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x6000119")]
			get
			{
				return null;
			}
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[Token(Token = "0x600011A")]
			set
			{
			}
		}

		[Token(Token = "0x600011B")]
		public UVChannels()
		{
		}

		[Token(Token = "0x600011C")]
		public void Resize(int capacity, bool trimExess = false)
		{
		}
	}
}
