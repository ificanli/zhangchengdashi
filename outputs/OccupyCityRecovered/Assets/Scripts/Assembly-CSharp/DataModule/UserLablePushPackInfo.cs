using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E96")]
	public class UserLablePushPackInfo : GlobalInfoBase
	{
		[Token(Token = "0x40065B0")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40065B1")]
		[FieldOffset(Offset = "0x20")]
		public string iapId;

		[Token(Token = "0x40065B2")]
		[FieldOffset(Offset = "0x28")]
		public string reward;

		[Token(Token = "0x60058C5")]
		[Address(RVA = "0x436567C", Offset = "0x436167C", VA = "0x436567C")]
		public UserLablePushPackInfo()
		{
		}
	}
}
