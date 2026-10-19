using System;
using Il2CppDummyDll;

namespace Pathfinding.Clipper2Lib
{
	[Token(Token = "0x2000014")]
	[Flags]
	public enum PointInPolygonResult
	{
		[Token(Token = "0x400002F")]
		IsOn = 0,
		[Token(Token = "0x4000030")]
		IsInside = 1,
		[Token(Token = "0x4000031")]
		IsOutside = 2
	}
}
