using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x200001A")]
	internal class OutPt
	{
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x10")]
		public Point64 pt;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x20")]
		public OutPt? next;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x28")]
		public OutPt prev;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x30")]
		public OutRec outrec;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x38")]
		public HorzSegment? horz;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x460C1CC", Offset = "0x46081CC", VA = "0x460C1CC")]
		public OutPt(Point64 pt, OutRec outrec)
		{
		}
	}
}
