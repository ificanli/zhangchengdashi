using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E97")]
	public class UserLevelInfo : GlobalInfoBase
	{
		[Token(Token = "0x40065B3")]
		[FieldOffset(Offset = "0x18")]
		public string level;

		[Token(Token = "0x40065B4")]
		[FieldOffset(Offset = "0x20")]
		public string exp;

		[Token(Token = "0x60058C6")]
		[Address(RVA = "0x4365684", Offset = "0x4361684", VA = "0x4365684")]
		public UserLevelInfo()
		{
		}
	}
}
