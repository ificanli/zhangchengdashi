using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x20000DA")]
	public class LinkNode : PointNode
	{
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x38")]
		public OffMeshLinks.OffMeshLinkSource linkSource;

		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x40")]
		public OffMeshLinks.OffMeshLinkConcrete linkConcrete;

		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x48")]
		public int nodeInGraphIndex;

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x452D988", Offset = "0x4529988", VA = "0x452D988")]
		public LinkNode()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x452D3DC", Offset = "0x45293DC", VA = "0x452D3DC")]
		public LinkNode(AstarPath active)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x452D990", Offset = "0x4529990", VA = "0x452D990", Slot = "8")]
		public override void RemovePartialConnection(GraphNode node)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x452DA28", Offset = "0x4529A28", VA = "0x452DA28", Slot = "12")]
		public override void Open(ref Path.SearchContext ctx, uint pathNodeIndex, uint gScore)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x452DE88", Offset = "0x4529E88", VA = "0x452DE88", Slot = "13")]
		public override void OpenAtPoint(ref Path.SearchContext ctx, uint pathNodeIndex, Int3 pos, uint gScore)
		{
		}
	}
}
