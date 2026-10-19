using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x2000472")]
	internal class ResponseServerTime : IResponseData
	{
		[Token(Token = "0x2000473")]
		public class Data
		{
			[Token(Token = "0x4001E8B")]
			[FieldOffset(Offset = "0x10")]
			public long nowTime;

			[Token(Token = "0x4001E8C")]
			[FieldOffset(Offset = "0x18")]
			public string version;

			[Token(Token = "0x6006BC6")]
			[Address(RVA = "0x7285FF4", Offset = "0x7281FF4", VA = "0x7285FF4")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4001E8A")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6006BC5")]
		[Address(RVA = "0x7285FEC", Offset = "0x7281FEC", VA = "0x7285FEC")]
		public ResponseServerTime()
		{
		}
	}
}
