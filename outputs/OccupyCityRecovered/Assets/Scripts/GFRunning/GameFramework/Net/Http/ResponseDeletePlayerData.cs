using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x2000480")]
	internal class ResponseDeletePlayerData : IResponseData
	{
		[Token(Token = "0x2000481")]
		public class Data
		{
			[Token(Token = "0x4001EB0")]
			[FieldOffset(Offset = "0x10")]
			public string[] Keys;

			[Token(Token = "0x6006BD4")]
			[Address(RVA = "0x7286064", Offset = "0x7282064", VA = "0x7286064")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4001EAF")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6006BD3")]
		[Address(RVA = "0x728605C", Offset = "0x728205C", VA = "0x728605C")]
		public ResponseDeletePlayerData()
		{
		}
	}
}
