using Il2CppDummyDll;

namespace GameFramework.GameData
{
	[Token(Token = "0x20004AF")]
	public class GameDataVer
	{
		[Token(Token = "0x4001F30")]
		[FieldOffset(Offset = "0x10")]
		public string dataKey;

		[Token(Token = "0x4001F31")]
		[FieldOffset(Offset = "0x18")]
		public int versionNumber;

		[Token(Token = "0x6007032")]
		[Address(RVA = "0x72AA708", Offset = "0x72A6708", VA = "0x72AA708")]
		public GameDataVer()
		{
		}
	}
}
