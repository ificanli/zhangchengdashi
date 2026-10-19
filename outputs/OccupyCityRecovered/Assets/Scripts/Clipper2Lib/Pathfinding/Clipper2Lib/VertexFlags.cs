using System;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000015")]
	[Flags]
	internal enum VertexFlags
	{
		[Token(Token = "0x4000033")]
		None = 0,
		[Token(Token = "0x4000034")]
		OpenStart = 1,
		[Token(Token = "0x4000035")]
		OpenEnd = 2,
		[Token(Token = "0x4000036")]
		LocalMax = 4,
		[Token(Token = "0x4000037")]
		LocalMin = 8
	}
}
