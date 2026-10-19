using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000016")]
	internal class Vertex
	{
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x10")]
		public Point64 pt;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x20")]
		public Vertex? next;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x28")]
		public Vertex? prev;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x30")]
		public VertexFlags flags;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x460C094", Offset = "0x4608094", VA = "0x460C094")]
		public Vertex(Point64 pt, VertexFlags flags, Vertex? prev)
		{
		}
	}
}
