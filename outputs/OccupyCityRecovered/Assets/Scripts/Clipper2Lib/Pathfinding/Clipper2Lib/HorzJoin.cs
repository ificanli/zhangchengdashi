using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x200001F")]
	internal class HorzJoin
	{
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x10")]
		public OutPt? op1;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x18")]
		public OutPt? op2;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x460C2B8", Offset = "0x46082B8", VA = "0x460C2B8")]
		public HorzJoin(OutPt ltor, OutPt rtol)
		{
		}
	}
}
