using Il2CppDummyDll;

namespace GameFramework.Net.Http
{
	[Token(Token = "0x200047E")]
	internal class ResponsePlayerIsExists : IResponseData
	{
		[Token(Token = "0x200047F")]
		public class Data
		{
			[Token(Token = "0x4001EAD")]
			[FieldOffset(Offset = "0x10")]
			public long uid;

			[Token(Token = "0x4001EAE")]
			[FieldOffset(Offset = "0x18")]
			public bool exists;

			[Token(Token = "0x6006BD2")]
			[Address(RVA = "0x7286054", Offset = "0x7282054", VA = "0x7286054")]
			public Data()
			{
			}
		}

		[Token(Token = "0x4001EAC")]
		[FieldOffset(Offset = "0x20")]
		public Data data;

		[Token(Token = "0x6006BD1")]
		[Address(RVA = "0x728604C", Offset = "0x728204C", VA = "0x728604C")]
		public ResponsePlayerIsExists()
		{
		}
	}
}
