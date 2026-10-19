using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x200047C")]
	internal class ResponseGetOtherGameData : IResponseData
	{
		[Token(Token = "0x200047D")]
		public class Data
		{
			[Token(Token = "0x4001EAA")]
			[FieldOffset(Offset = "0x10")]
			public long uid;

			[Token(Token = "0x4001EAB")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, string> data;

			[Token(Token = "0x6006BD0")]
			[Address(RVA = "0x7286044", Offset = "0x7282044", VA = "0x7286044")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4001EA9")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6006BCF")]
		[Address(RVA = "0x728603C", Offset = "0x728203C", VA = "0x728603C")]
		public ResponseGetOtherGameData()
		{
		}
	}
}
