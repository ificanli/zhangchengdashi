using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E6B")]
	public class GlobalIAPInfo : GlobalInfoBase
	{
		[Token(Token = "0x400643F")]
		[FieldOffset(Offset = "0x18")]
		public string type;

		[Token(Token = "0x4006440")]
		[FieldOffset(Offset = "0x20")]
		public string googleProductId;

		[Token(Token = "0x4006441")]
		[FieldOffset(Offset = "0x28")]
		public string appleProductId;

		[Token(Token = "0x4006442")]
		[FieldOffset(Offset = "0x30")]
		public double price;

		[Token(Token = "0x4006443")]
		[FieldOffset(Offset = "0x38")]
		public string benefit;

		[Token(Token = "0x4006444")]
		[FieldOffset(Offset = "0x40")]
		public string rewardScene;

		[Token(Token = "0x4006445")]
		[FieldOffset(Offset = "0x48")]
		public bool canRestorationPurchase;

		[Token(Token = "0x4006446")]
		[FieldOffset(Offset = "0x50")]
		public string rewardA;

		[Token(Token = "0x4006447")]
		[FieldOffset(Offset = "0x58")]
		public string rewardB;

		[Token(Token = "0x17000F15")]
		public string reward
		{
			[Token(Token = "0x600582A")]
			[Address(RVA = "0x435BB38", Offset = "0x4357B38", VA = "0x435BB38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600582B")]
		[Address(RVA = "0x435BBC8", Offset = "0x4357BC8", VA = "0x435BBC8")]
		public string GetProductId()
		{
			return null;
		}

		[Token(Token = "0x600582C")]
		[Address(RVA = "0x435BBD0", Offset = "0x4357BD0", VA = "0x435BBD0")]
		public GlobalIAPInfo()
		{
		}
	}
}
