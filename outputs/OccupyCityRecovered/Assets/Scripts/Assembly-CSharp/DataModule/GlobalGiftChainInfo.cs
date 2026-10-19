using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E68")]
	public class GlobalGiftChainInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006432")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		[Token(Token = "0x4006433")]
		[FieldOffset(Offset = "0x20")]
		public string iapId;

		[Token(Token = "0x4006434")]
		[FieldOffset(Offset = "0x28")]
		public string rewards;

		[Token(Token = "0x4006435")]
		[FieldOffset(Offset = "0x30")]
		public string iconPath;

		[Token(Token = "0x4006436")]
		[FieldOffset(Offset = "0x38")]
		public string rewardNameKey;

		[Token(Token = "0x6005826")]
		[Address(RVA = "0x435BA90", Offset = "0x4357A90", VA = "0x435BA90")]
		public GlobalGiftChainInfo()
		{
		}
	}
}
