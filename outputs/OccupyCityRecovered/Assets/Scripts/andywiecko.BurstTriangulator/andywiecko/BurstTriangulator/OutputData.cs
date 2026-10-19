using System;
using Il2CppDummyDll;
using Unity.Collections;

namespace andywiecko.BurstTriangulator
{
	[Token(Token = "0x200000F")]
	public class OutputData<T2> where T2 : unmanaged
	{
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x0")]
		private readonly Triangulator<T2> owner;

		[Token(Token = "0x1700001D")]
		public NativeList<T2> Positions
		{
			[Token(Token = "0x6000043")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001E")]
		public NativeList<int> Triangles
		{
			[Token(Token = "0x6000044")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001F")]
		public NativeReference<Status> Status
		{
			[Token(Token = "0x6000045")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000020")]
		public NativeList<int> Halfedges
		{
			[Token(Token = "0x6000046")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000021")]
		public NativeList<HalfedgeState> ConstrainedHalfedges
		{
			[Token(Token = "0x6000047")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000048")]
		[Obsolete("This will be converted into internal ctor.")]
		public OutputData(Triangulator<T2> owner)
		{
		}
	}
}
