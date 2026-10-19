using Beebyte.Obfuscator;
using GameFramework.Login;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FDD")]
	[Skip]
	public class LoginUseInfo
	{
		[Token(Token = "0x4006C15")]
		[FieldOffset(Offset = "0x10")]
		public long Uid;

		[Token(Token = "0x4006C16")]
		[FieldOffset(Offset = "0x18")]
		public string shortId;

		[Token(Token = "0x4006C17")]
		[FieldOffset(Offset = "0x20")]
		public bool IsNewPlayer;

		[Token(Token = "0x4006C18")]
		[FieldOffset(Offset = "0x21")]
		public bool IsNewDevice;

		[Token(Token = "0x4006C19")]
		[FieldOffset(Offset = "0x28")]
		public string UserId;

		[Token(Token = "0x4006C1A")]
		[FieldOffset(Offset = "0x30")]
		public string Attachment;

		[Token(Token = "0x4006C1B")]
		[FieldOffset(Offset = "0x38")]
		public string Token;

		[Token(Token = "0x4006C1C")]
		[FieldOffset(Offset = "0x40")]
		public string userExt;

		[Token(Token = "0x4006C1D")]
		[FieldOffset(Offset = "0x48")]
		public string OpenId;

		[Token(Token = "0x4006C1E")]
		[FieldOffset(Offset = "0x50")]
		public int[] haroute;

		[Token(Token = "0x4006C1F")]
		[FieldOffset(Offset = "0x58")]
		public int Lobby;

		[Token(Token = "0x4006C20")]
		[FieldOffset(Offset = "0x60")]
		public string LobbyHost;

		[Token(Token = "0x4006C21")]
		[FieldOffset(Offset = "0x68")]
		public string Param;

		[Token(Token = "0x4006C22")]
		[FieldOffset(Offset = "0x70")]
		public LoginUserData sdkUserData;

		[Token(Token = "0x6005EF3")]
		[Address(RVA = "0x43FFDE0", Offset = "0x43FBDE0", VA = "0x43FFDE0")]
		public LoginUseInfo()
		{
		}
	}
}
