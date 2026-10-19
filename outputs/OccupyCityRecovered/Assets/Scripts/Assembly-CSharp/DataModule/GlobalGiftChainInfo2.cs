using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E69")]
	public class GlobalGiftChainInfo2 : GlobalInfoBase
	{
		[Token(Token = "0x4006437")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		[Token(Token = "0x4006438")]
		[FieldOffset(Offset = "0x20")]
		public string iapId;

		[Token(Token = "0x4006439")]
		[FieldOffset(Offset = "0x28")]
		public string rewardsA;

		[Token(Token = "0x400643A")]
		[FieldOffset(Offset = "0x30")]
		public string rewardsB;

		[Token(Token = "0x17000F14")]
		public string rewards
		{
			[Token(Token = "0x6005827")]
			[Address(RVA = "0x435BA98", Offset = "0x4357A98", VA = "0x435BA98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005828")]
		[Address(RVA = "0x435BB28", Offset = "0x4357B28", VA = "0x435BB28")]
		public GlobalGiftChainInfo2()
		{
		}
	}
}
