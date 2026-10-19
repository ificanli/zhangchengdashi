using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x200003E")]
	[Flags]
	public enum GraphUpdateDebugMode
	{
		[Token(Token = "0x40001A7")]
		Nothing = 0,
		[Token(Token = "0x40001A8")]
		VisualizeOriginalBounds = 1,
		[Token(Token = "0x40001A9")]
		VisualizeAffectedBounds = 2,
		[Token(Token = "0x40001AA")]
		VisualizeOverTime = 4
	}
}
