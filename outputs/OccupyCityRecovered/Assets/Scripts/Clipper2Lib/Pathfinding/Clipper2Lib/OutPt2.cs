using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000034")]
	public class OutPt2
	{
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x10")]
		public OutPt2? next;

		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x18")]
		public OutPt2? prev;

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x20")]
		public Point64 pt;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x30")]
		public int ownerIdx;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x38")]
		public List<OutPt2?>? edge;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x4620EDC", Offset = "0x461CEDC", VA = "0x4620EDC")]
		public OutPt2(Point64 pt)
		{
		}
	}
}
