using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x2000482")]
	internal class ResponseDataVersion : IResponseData
	{
		[Token(Token = "0x2000483")]
		public class Data
		{
			[Token(Token = "0x4001EB2")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> version;

			[Token(Token = "0x6006BD6")]
			[Address(RVA = "0x7286074", Offset = "0x7282074", VA = "0x7286074")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4001EB1")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6006BD5")]
		[Address(RVA = "0x728606C", Offset = "0x728206C", VA = "0x728606C")]
		public ResponseDataVersion()
		{
		}
	}
}
