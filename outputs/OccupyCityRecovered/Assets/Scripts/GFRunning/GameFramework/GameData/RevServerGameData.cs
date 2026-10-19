using Il2CppDummyDll;

namespace GameFramework.GameData
{
	[Token(Token = "0x20004B0")]
	public class RevServerGameData
	{
		[Token(Token = "0x4001F32")]
		[FieldOffset(Offset = "0x10")]
		public string dataKey;

		[Token(Token = "0x4001F33")]
		[FieldOffset(Offset = "0x18")]
		public string JsonData;

		[Token(Token = "0x4001F34")]
		[FieldOffset(Offset = "0x20")]
		public int versionNumber;

		[Token(Token = "0x6007033")]
		[Address(RVA = "0x72AA718", Offset = "0x72A6718", VA = "0x72AA718")]
		public RevServerGameData()
		{
		}
	}
}
