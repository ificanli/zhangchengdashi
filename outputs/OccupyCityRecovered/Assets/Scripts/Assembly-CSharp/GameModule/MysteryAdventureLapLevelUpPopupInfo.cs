using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200050F")]
	public class MysteryAdventureLapLevelUpPopupInfo
	{
		[Token(Token = "0x4002DB0")]
		[FieldOffset(Offset = "0x10")]
		public int NewLevel;

		[Token(Token = "0x4002DB1")]
		[FieldOffset(Offset = "0x18")]
		public string BonusPercentText;

		[Token(Token = "0x4002DB2")]
		[FieldOffset(Offset = "0x20")]
		public int RewardCount;

		[Token(Token = "0x4002DB3")]
		[FieldOffset(Offset = "0x28")]
		public string RewardRaw;

		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x3E96800", Offset = "0x3E92800", VA = "0x3E96800")]
		public MysteryAdventureLapLevelUpPopupInfo()
		{
		}
	}
}
