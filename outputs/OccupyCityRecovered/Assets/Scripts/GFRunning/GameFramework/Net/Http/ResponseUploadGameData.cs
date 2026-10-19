using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x2000478")]
	internal class ResponseUploadGameData : IResponseData
	{
		[Token(Token = "0x2000479")]
		public class Data
		{
			[Token(Token = "0x4001EA5")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> version;

			[Token(Token = "0x6006BCC")]
			[Address(RVA = "0x7286024", Offset = "0x7282024", VA = "0x7286024")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4001EA4")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6006BCB")]
		[Address(RVA = "0x728601C", Offset = "0x728201C", VA = "0x728601C")]
		public ResponseUploadGameData()
		{
		}
	}
}
