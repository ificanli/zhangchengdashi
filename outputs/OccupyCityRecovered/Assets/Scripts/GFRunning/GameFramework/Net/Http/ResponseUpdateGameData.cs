using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x200047A")]
	internal class ResponseUpdateGameData : IResponseData
	{
		[Token(Token = "0x200047B")]
		public class Data
		{
			[Token(Token = "0x4001EA7")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, string> data;

			[Token(Token = "0x4001EA8")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> version;

			[Token(Token = "0x6006BCE")]
			[Address(RVA = "0x7286034", Offset = "0x7282034", VA = "0x7286034")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4001EA6")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6006BCD")]
		[Address(RVA = "0x728602C", Offset = "0x728202C", VA = "0x728602C")]
		public ResponseUpdateGameData()
		{
		}
	}
}
