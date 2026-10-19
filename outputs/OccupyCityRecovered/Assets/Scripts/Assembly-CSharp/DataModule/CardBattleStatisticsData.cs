using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EC8")]
	public class CardBattleStatisticsData
	{
		[Token(Token = "0x40066A2")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("ngu")]
		public int nbrGameUsed;

		[Token(Token = "0x40066A3")]
		[FieldOffset(Offset = "0x14")]
		[JsonProperty("ngp")]
		public int nbrGamePossible;

		[Token(Token = "0x40066A4")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("nw")]
		public int nbrWin;

		[Token(Token = "0x6005995")]
		[Address(RVA = "0x4371C90", Offset = "0x436DC90", VA = "0x4371C90")]
		public CardBattleStatisticsData()
		{
		}
	}
}
