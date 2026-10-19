using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E7F")]
	public class GlobalUpgradeTalentPriceInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006516")]
		[FieldOffset(Offset = "0x18")]
		public string cardIndex;

		[Token(Token = "0x4006517")]
		[FieldOffset(Offset = "0x20")]
		public string unlockLevel;

		[Token(Token = "0x4006518")]
		[FieldOffset(Offset = "0x28")]
		public string levelOnePrice;

		[Token(Token = "0x4006519")]
		[FieldOffset(Offset = "0x30")]
		public string levelTwoPrice;

		[Token(Token = "0x400651A")]
		[FieldOffset(Offset = "0x38")]
		public string levelTherePrice;

		[Token(Token = "0x60058A5")]
		[Address(RVA = "0x436484C", Offset = "0x436084C", VA = "0x436484C")]
		public GlobalUpgradeTalentPriceInfo()
		{
		}
	}
}
