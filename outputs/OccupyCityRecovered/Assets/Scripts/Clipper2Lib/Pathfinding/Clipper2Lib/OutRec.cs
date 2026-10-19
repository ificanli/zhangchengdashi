using System.Collections.Generic;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x200001D")]
	internal class OutRec
	{
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x10")]
		public int idx;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x18")]
		public OutRec? owner;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x20")]
		public Active? frontEdge;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x28")]
		public Active? backEdge;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x30")]
		public OutPt? pts;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x38")]
		public PolyPathBase? polypath;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x40")]
		public Rect64 bounds;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x60")]
		public List<Point64> path;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x68")]
		public bool isOpen;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x70")]
		public List<int>? splits;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x78")]
		public OutRec? recursiveSplit;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x460C20C", Offset = "0x460820C", VA = "0x460C20C")]
		public OutRec()
		{
		}
	}
}
