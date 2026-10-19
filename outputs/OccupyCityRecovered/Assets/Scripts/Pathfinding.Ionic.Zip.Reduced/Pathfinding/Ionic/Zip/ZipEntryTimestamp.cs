using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x200002D")]
	[Flags]
	public enum ZipEntryTimestamp
	{
		[Token(Token = "0x40000CB")]
		None = 0,
		[Token(Token = "0x40000CC")]
		DOS = 1,
		[Token(Token = "0x40000CD")]
		Windows = 2,
		[Token(Token = "0x40000CE")]
		Unix = 4,
		[Token(Token = "0x40000CF")]
		InfoZip1 = 8
	}
}
