using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001DA")]
	internal class GameCenterScoreList : SDKCallBackResult
	{
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x18")]
		public string value;

		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x70A2E90", Offset = "0x709EE90", VA = "0x70A2E90")]
		public GameCenterScoreList()
		{
		}
	}
}
