using Il2CppDummyDll;

namespace GameFramework.GameData
{
	[Token(Token = "0x20004B6")]
	public class GameReportDataVer
	{
		[Token(Token = "0x4001F51")]
		[FieldOffset(Offset = "0x10")]
		public string dataKey;

		[Token(Token = "0x4001F52")]
		[FieldOffset(Offset = "0x18")]
		public int localVersionNumber;

		[Token(Token = "0x4001F53")]
		[FieldOffset(Offset = "0x1C")]
		public int serverVersionNumber;

		[Token(Token = "0x60070A6")]
		[Address(RVA = "0x72B0FD8", Offset = "0x72ACFD8", VA = "0x72B0FD8")]
		public GameReportDataVer()
		{
		}
	}
}
