using Beebyte.Obfuscator;
using GameFramework.Net.Http;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FDE")]
	[Skip]
	public class ResponseCutoverLoginData : IResponseData
	{
		[Token(Token = "0x2000FDF")]
		public class Data
		{
			[Token(Token = "0x4006C24")]
			[FieldOffset(Offset = "0x10")]
			public long uid;

			[Token(Token = "0x4006C25")]
			[FieldOffset(Offset = "0x18")]
			public string userId;

			[Token(Token = "0x4006C26")]
			[FieldOffset(Offset = "0x20")]
			public string token;

			[Token(Token = "0x4006C27")]
			[FieldOffset(Offset = "0x28")]
			public string param;

			[Token(Token = "0x4006C28")]
			[FieldOffset(Offset = "0x30")]
			public string lobbyHost;

			[Token(Token = "0x6005EF5")]
			[Address(RVA = "0x43FFDF0", Offset = "0x43FBDF0", VA = "0x43FFDF0")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4006C23")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6005EF4")]
		[Address(RVA = "0x43FFDE8", Offset = "0x43FBDE8", VA = "0x43FFDE8")]
		public ResponseCutoverLoginData()
		{
		}
	}
}
