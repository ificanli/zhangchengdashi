using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x2000476")]
	internal class ResponseBind : IResponseData
	{
		[Token(Token = "0x2000477")]
		public class Data
		{
			[Token(Token = "0x4001EA1")]
			[FieldOffset(Offset = "0x10")]
			public long uid;

			[Token(Token = "0x4001EA2")]
			[FieldOffset(Offset = "0x18")]
			public string userId;

			[Token(Token = "0x4001EA3")]
			[FieldOffset(Offset = "0x20")]
			public string token;

			[Token(Token = "0x6006BCA")]
			[Address(RVA = "0x7286014", Offset = "0x7282014", VA = "0x7286014")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4001EA0")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6006BC9")]
		[Address(RVA = "0x728600C", Offset = "0x728200C", VA = "0x728600C")]
		public ResponseBind()
		{
		}
	}
}
