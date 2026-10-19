using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20004F7")]
	public class MultistageNewcomerPackagePanelData
	{
		[Token(Token = "0x4002D1F")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4002D20")]
		[FieldOffset(Offset = "0x18")]
		public string iapId;

		[Token(Token = "0x4002D21")]
		[FieldOffset(Offset = "0x20")]
		public string price;

		[Token(Token = "0x4002D22")]
		[FieldOffset(Offset = "0x28")]
		public bool IsPurchase;

		[Token(Token = "0x4002D23")]
		[FieldOffset(Offset = "0x29")]
		public bool IsGetReward_Level1;

		[Token(Token = "0x4002D24")]
		[FieldOffset(Offset = "0x2A")]
		public bool IsGetReward_Level2;

		[Token(Token = "0x4002D25")]
		[FieldOffset(Offset = "0x2B")]
		public bool IsGetReward_Level3;

		[Token(Token = "0x4002D26")]
		[FieldOffset(Offset = "0x30")]
		public string day1Rewards;

		[Token(Token = "0x4002D27")]
		[FieldOffset(Offset = "0x38")]
		public string day2Rewards;

		[Token(Token = "0x4002D28")]
		[FieldOffset(Offset = "0x40")]
		public string day3Rewards;

		[Token(Token = "0x6001913")]
		[Address(RVA = "0x3E8D73C", Offset = "0x3E8973C", VA = "0x3E8D73C")]
		public MultistageNewcomerPackagePanelData()
		{
		}
	}
}
