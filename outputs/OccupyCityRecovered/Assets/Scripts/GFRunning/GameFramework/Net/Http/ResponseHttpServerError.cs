using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x2000486")]
	internal class ResponseHttpServerError : IResponseData
	{
		[Token(Token = "0x2000487")]
		public class Data
		{
			[Token(Token = "0x4001EB9")]
			[FieldOffset(Offset = "0x10")]
			public string deviceId;

			[Token(Token = "0x6006BDA")]
			[Address(RVA = "0x7286094", Offset = "0x7282094", VA = "0x7286094")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4001EB8")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6006BD9")]
		[Address(RVA = "0x728608C", Offset = "0x728208C", VA = "0x728608C")]
		public ResponseHttpServerError()
		{
		}
	}
}
