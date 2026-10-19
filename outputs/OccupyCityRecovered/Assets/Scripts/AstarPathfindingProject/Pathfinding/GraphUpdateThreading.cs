using System;
using Il2CppDummyDll;

namespace Pathfinding
{
	[Token(Token = "0x200003A")]
	[Flags]
	public enum GraphUpdateThreading
	{
		[Token(Token = "0x400018E")]
		UnityThread = 0,
		[Token(Token = "0x400018F")]
		UnityInit = 2,
		[Token(Token = "0x4000190")]
		UnityPost = 4
	}
}
