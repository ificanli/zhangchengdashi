using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x2000474")]
	public class ResponseLoginInfo : IResponseData
	{
		[Token(Token = "0x2000475")]
		public class Data
		{
			[Token(Token = "0x4001E8E")]
			[FieldOffset(Offset = "0x10")]
			public long uid;

			[Token(Token = "0x4001E8F")]
			[FieldOffset(Offset = "0x18")]
			public string shortId;

			[Token(Token = "0x4001E90")]
			[FieldOffset(Offset = "0x20")]
			public bool isNewPlayer;

			[Token(Token = "0x4001E91")]
			[FieldOffset(Offset = "0x21")]
			public bool isDataUploaded;

			[Token(Token = "0x4001E92")]
			[FieldOffset(Offset = "0x22")]
			public bool isNewDevice;

			[Token(Token = "0x4001E93")]
			[FieldOffset(Offset = "0x28")]
			public string userId;

			[Token(Token = "0x4001E94")]
			[FieldOffset(Offset = "0x30")]
			public string attachment;

			[Token(Token = "0x4001E95")]
			[FieldOffset(Offset = "0x38")]
			public string token;

			[Token(Token = "0x4001E96")]
			[FieldOffset(Offset = "0x40")]
			public string userExt;

			[Token(Token = "0x4001E97")]
			[FieldOffset(Offset = "0x48")]
			public string openId;

			[Token(Token = "0x4001E98")]
			[FieldOffset(Offset = "0x50")]
			public int lobby;

			[Token(Token = "0x4001E99")]
			[FieldOffset(Offset = "0x58")]
			public int[] haroute;

			[Token(Token = "0x4001E9A")]
			[FieldOffset(Offset = "0x60")]
			public string lobbyHost;

			[Token(Token = "0x4001E9B")]
			[FieldOffset(Offset = "0x68")]
			public string param;

			[Token(Token = "0x4001E9C")]
			[FieldOffset(Offset = "0x70")]
			public long banEndTime;

			[Token(Token = "0x4001E9D")]
			[FieldOffset(Offset = "0x78")]
			public string serverGroupId;

			[Token(Token = "0x4001E9E")]
			[FieldOffset(Offset = "0x80")]
			public bool enterPreLobby;

			[Token(Token = "0x4001E9F")]
			[FieldOffset(Offset = "0x88")]
			public string subjectChangeBind;

			[Token(Token = "0x6006BC8")]
			[Address(RVA = "0x7286004", Offset = "0x7282004", VA = "0x7286004")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4001E8D")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6006BC7")]
		[Address(RVA = "0x7285FFC", Offset = "0x7281FFC", VA = "0x7285FFC")]
		public ResponseLoginInfo()
		{
		}
	}
}
