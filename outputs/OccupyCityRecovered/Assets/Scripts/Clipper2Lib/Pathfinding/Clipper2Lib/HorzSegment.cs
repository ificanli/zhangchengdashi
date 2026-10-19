using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x200001E")]
	internal class HorzSegment
	{
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x10")]
		public OutPt? leftOp;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x18")]
		public OutPt? rightOp;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x20")]
		public bool leftToRight;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x460C288", Offset = "0x4608288", VA = "0x460C288")]
		public HorzSegment(OutPt op)
		{
		}
	}
}
