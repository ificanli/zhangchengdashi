using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x200009B")]
	public struct Connection
	{
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x0")]
		public GraphNode node;

		[Token(Token = "0x4000342")]
		[FieldOffset(Offset = "0x8")]
		public uint cost;

		[Token(Token = "0x4000343")]
		[FieldOffset(Offset = "0xC")]
		public byte shapeEdgeInfo;

		[Token(Token = "0x4000344")]
		public const byte NoSharedEdge = 15;

		[Token(Token = "0x4000345")]
		public const byte IncomingConnection = 16;

		[Token(Token = "0x4000346")]
		public const byte OutgoingConnection = 32;

		[Token(Token = "0x4000347")]
		public const byte IdenticalEdge = 64;

		[Token(Token = "0x17000108")]
		public int shapeEdge
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x450E008", Offset = "0x450A008", VA = "0x450E008")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000109")]
		public int adjacentShapeEdge
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x450E014", Offset = "0x450A014", VA = "0x450E014")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010A")]
		public bool edgesAreIdentical
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x450E020", Offset = "0x450A020", VA = "0x450E020")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010B")]
		public bool isEdgeShared
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x450E02C", Offset = "0x450A02C", VA = "0x450E02C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010C")]
		public bool isOutgoing
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0x450E040", Offset = "0x450A040", VA = "0x450E040")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010D")]
		public bool isIncoming
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0x450E04C", Offset = "0x450A04C", VA = "0x450E04C")]
			get
			{
				return default;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x450E058", Offset = "0x450A058", VA = "0x450E058")]
		public Connection(GraphNode node, uint cost, bool isOutgoing, bool isIncoming)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Connection..ctor RVA=0x450E058 Token=0x6000516");
}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x450E088", Offset = "0x450A088", VA = "0x450E088")]
		public static byte PackShapeEdgeInfo(bool isOutgoing, bool isIncoming)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x450E0AC", Offset = "0x450A0AC", VA = "0x450E0AC")]
		public static byte PackShapeEdgeInfo(byte shapeEdge, byte adjacentShapeEdge, bool areEdgesIdentical, bool isOutgoing, bool isIncoming)
		{
			return default;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x450E0E4", Offset = "0x450A0E4", VA = "0x450E0E4")]
		public Connection(GraphNode node, uint cost, byte shapeEdgeInfo)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED Connection..ctor RVA=0x450E0E4 Token=0x6000519");
}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x450E0F4", Offset = "0x450A0F4", VA = "0x450E0F4", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x450E124", Offset = "0x450A124", VA = "0x450E124", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}
	}
}
