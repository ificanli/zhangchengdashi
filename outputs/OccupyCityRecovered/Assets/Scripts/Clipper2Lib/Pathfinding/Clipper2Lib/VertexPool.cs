using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x200003A")]
	internal struct VertexPool
	{
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x0")]
		private Stack<Vertex> stack;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x46255BC", Offset = "0x46215BC", VA = "0x46255BC")]
		public VertexPool(int capacity)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED VertexPool..ctor RVA=0x46255BC Token=0x60001E5");
}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x4625638", Offset = "0x4621638", VA = "0x4625638")]
		public Vertex GetNew(Point64 pt, VertexFlags flags, Vertex? prev)
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x4625714", Offset = "0x4621714", VA = "0x4625714")]
		public void Pool(Vertex v)
		{
		}
	}
}
