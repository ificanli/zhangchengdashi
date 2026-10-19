using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000035")]
	public enum Zip64Option
	{
		[Token(Token = "0x4000127")]
		Default = 0,
		[Token(Token = "0x4000128")]
		Never = Default,
		[Token(Token = "0x4000129")]
		AsNecessary = 1,
		[Token(Token = "0x400012A")]
		Always = 2
	}
}
