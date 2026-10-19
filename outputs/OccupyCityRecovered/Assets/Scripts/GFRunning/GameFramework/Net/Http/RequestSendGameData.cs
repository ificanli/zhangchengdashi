using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x200046C")]
	public class RequestSendGameData : IRequesData
	{
		[Token(Token = "0x4001E7B")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, string> Datas;

		[Token(Token = "0x4001E7C")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		[Token(Token = "0x6006BBF")]
		[Address(RVA = "0x7285F48", Offset = "0x7281F48", VA = "0x7285F48")]
		public RequestSendGameData()
		{
		}
	}
}
