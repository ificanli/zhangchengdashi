using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x2000484")]
	internal class ResponseLoginOutData : IResponseData
	{
		[Token(Token = "0x2000485")]
		public class Data
		{
			[Token(Token = "0x4001EB4")]
			[FieldOffset(Offset = "0x10")]
			public long timeUnReg;

			[Token(Token = "0x4001EB5")]
			[FieldOffset(Offset = "0x18")]
			public long uid;

			[Token(Token = "0x4001EB6")]
			[FieldOffset(Offset = "0x20")]
			public int state;

			[Token(Token = "0x4001EB7")]
			[FieldOffset(Offset = "0x28")]
			public string userId;

			[Token(Token = "0x6006BD8")]
			[Address(RVA = "0x7286084", Offset = "0x7282084", VA = "0x7286084")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4001EB3")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6006BD7")]
		[Address(RVA = "0x728607C", Offset = "0x728207C", VA = "0x728607C")]
		public ResponseLoginOutData()
		{
		}
	}
}
