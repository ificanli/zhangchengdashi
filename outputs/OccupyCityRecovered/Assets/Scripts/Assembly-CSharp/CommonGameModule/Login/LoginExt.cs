using Beebyte.Obfuscator;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FE0")]
	[Skip]
	public class LoginExt
	{
		[Token(Token = "0x4006C29")]
		[FieldOffset(Offset = "0x10")]
		public string os;

		[Token(Token = "0x4006C2A")]
		[FieldOffset(Offset = "0x18")]
		public string network;

		[Token(Token = "0x4006C2B")]
		[FieldOffset(Offset = "0x20")]
		public string device;

		[Token(Token = "0x4006C2C")]
		[FieldOffset(Offset = "0x28")]
		public string appver;

		[Token(Token = "0x4006C2D")]
		[FieldOffset(Offset = "0x30")]
		public string deviceModel;

		[Token(Token = "0x4006C2E")]
		[FieldOffset(Offset = "0x38")]
		public string nickName;

		[Token(Token = "0x4006C2F")]
		[FieldOffset(Offset = "0x40")]
		public string platform;

		[Token(Token = "0x4006C30")]
		[FieldOffset(Offset = "0x48")]
		public string channel;

		[Token(Token = "0x4006C31")]
		[FieldOffset(Offset = "0x50")]
		public string country;

		[Token(Token = "0x4006C32")]
		[FieldOffset(Offset = "0x58")]
		public string userChannel;

		[Token(Token = "0x4006C33")]
		[FieldOffset(Offset = "0x60")]
		public int selectLobby;

		[Token(Token = "0x6005EF6")]
		[Address(RVA = "0x43FFDF8", Offset = "0x43FBDF8", VA = "0x43FFDF8")]
		public LoginExt()
		{
		}
	}
}
