using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x20000BB")]
	public struct PathNode
	{
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x0")]
		public ushort pathID;

		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x2")]
		public ushort heapIndex;

		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x4")]
		private uint flags;

		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PathNode Default = new PathNode { heapIndex=65535 };

		[Token(Token = "0x40003E7")]
		private const uint ParentIndexMask = 67108863u;

		[Token(Token = "0x40003E8")]
		private const int FractionAlongEdgeOffset = 26;

		[Token(Token = "0x40003E9")]
		private const uint FractionAlongEdgeMask = 1006632960u;

		[Token(Token = "0x40003EA")]
		public const int FractionAlongEdgeQuantization = 16;

		[Token(Token = "0x40003EB")]
		private const int Flag1Offset = 30;

		[Token(Token = "0x40003EC")]
		private const uint Flag1Mask = 1073741824u;

		[Token(Token = "0x40003ED")]
		private const int Flag2Offset = 31;

		[Token(Token = "0x40003EE")]
		private const uint Flag2Mask = 2147483648u;

		[Token(Token = "0x1700013C")]
		public uint fractionAlongEdge
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x4518F14", Offset = "0x4514F14", VA = "0x4518F14")]
			get
			{
				return default;
			}
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x4518340", Offset = "0x4514340", VA = "0x4518340")]
			set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public uint parentIndex
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x45173CC", Offset = "0x45133CC", VA = "0x45173CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x451832C", Offset = "0x451432C", VA = "0x451832C")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public bool flag1
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x45185FC", Offset = "0x45145FC", VA = "0x45185FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x4517C74", Offset = "0x4513C74", VA = "0x4517C74")]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public bool flag2
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x4519448", Offset = "0x4515448", VA = "0x4519448")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x4517C94", Offset = "0x4513C94", VA = "0x4517C94")]
			set
			{
			}
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x45193F8", Offset = "0x45153F8", VA = "0x45193F8")]
		public static uint ReverseFractionAlongEdge(uint v)
		{
			return default;
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x4519404", Offset = "0x4515404", VA = "0x4519404")]
		public static uint QuantizeFractionAlongEdge(float v)
		{
			return default;
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x4519434", Offset = "0x4515434", VA = "0x4519434")]
		public static float UnQuantizeFractionAlongEdge(uint v)
		{
			return default;
		}
	}
}
