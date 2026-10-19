using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E8A")]
	public class GlobaMultistageNewcomerPackageInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006559")]
		[FieldOffset(Offset = "0x18")]
		public string level;

		[Token(Token = "0x400655A")]
		[FieldOffset(Offset = "0x20")]
		public string iapId;

		[Token(Token = "0x400655B")]
		[FieldOffset(Offset = "0x28")]
		public string day1RewardsA;

		[Token(Token = "0x400655C")]
		[FieldOffset(Offset = "0x30")]
		public string day2RewardsA;

		[Token(Token = "0x400655D")]
		[FieldOffset(Offset = "0x38")]
		public string day3RewardsA;

		[Token(Token = "0x400655E")]
		[FieldOffset(Offset = "0x40")]
		public string day1RewardsB;

		[Token(Token = "0x400655F")]
		[FieldOffset(Offset = "0x48")]
		public string day2RewardsB;

		[Token(Token = "0x4006560")]
		[FieldOffset(Offset = "0x50")]
		public string day3RewardsB;

		[Token(Token = "0x4006561")]
		[FieldOffset(Offset = "0x58")]
		public string price;

		[Token(Token = "0x17000F24")]
		public string day1Rewards
		{
			[Token(Token = "0x60058B0")]
			[Address(RVA = "0x43648A4", Offset = "0x43608A4", VA = "0x43648A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F25")]
		public string day2Rewards
		{
			[Token(Token = "0x60058B1")]
			[Address(RVA = "0x4364940", Offset = "0x4360940", VA = "0x4364940")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F26")]
		public string day3Rewards
		{
			[Token(Token = "0x60058B2")]
			[Address(RVA = "0x43649DC", Offset = "0x43609DC", VA = "0x43649DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60058B3")]
		[Address(RVA = "0x4364A78", Offset = "0x4360A78", VA = "0x4364A78")]
		public GlobaMultistageNewcomerPackageInfo()
		{
		}
	}
}
