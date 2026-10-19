using System;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000020")]
	internal class Active : IDisposable
	{
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x10")]
		public Point64 bot;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x20")]
		public Point64 top;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x30")]
		public long curX;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x38")]
		public double dx;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x40")]
		public int windDx;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x44")]
		public int windCount;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x48")]
		public int windCount2;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x50")]
		public OutRec? outrec;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x58")]
		public Active? prevInAEL;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x60")]
		public Active? nextInAEL;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x68")]
		public Active? prevInSEL;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x70")]
		public Active? nextInSEL;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x78")]
		public Active? jump;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x80")]
		public Vertex? vertexTop;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x88")]
		public LocalMinima localMin;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x98")]
		internal bool isLeftBound;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x9C")]
		internal JoinWith joinWith;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x460C2E4", Offset = "0x46082E4", VA = "0x460C2E4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x460C308", Offset = "0x4608308", VA = "0x460C308")]
		public Active()
		{
		}
	}
}
