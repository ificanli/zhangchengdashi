using Il2CppDummyDll;
using Pathfinding.Drawing;

namespace Pathfinding.Util
{
	[Token(Token = "0x20002A4")]
	public struct NodeHasher
	{
		[Token(Token = "0x4000BFF")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool includePathSearchInfo;

		[Token(Token = "0x4000C00")]
		[FieldOffset(Offset = "0x1")]
		private readonly bool includeAreaInfo;

		[Token(Token = "0x4000C01")]
		[FieldOffset(Offset = "0x2")]
		private readonly bool includeHierarchicalNodeInfo;

		[Token(Token = "0x4000C02")]
		[FieldOffset(Offset = "0x8")]
		private readonly PathHandler debugData;

		[Token(Token = "0x4000C03")]
		[FieldOffset(Offset = "0x10")]
		public DrawingData.Hasher hasher;

		[Token(Token = "0x60010CA")]
		[Address(RVA = "0x44982C4", Offset = "0x44942C4", VA = "0x44982C4")]
		public NodeHasher(AstarPath active)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED NodeHasher..ctor RVA=0x44982C4 Token=0x60010CA");
}

		[Token(Token = "0x60010CB")]
		[Address(RVA = "0x449845C", Offset = "0x449445C", VA = "0x449845C")]
		public void HashNode(GraphNode node)
		{
		}

		[Token(Token = "0x60010CC")]
		public void Add<T>(T v)
		{
		}

		[Token(Token = "0x60010CD")]
		[Address(RVA = "0x449862C", Offset = "0x449462C", VA = "0x449862C")]
		public static implicit operator DrawingData.Hasher(NodeHasher hasher)
		{
			return default;
		}
	}
}
