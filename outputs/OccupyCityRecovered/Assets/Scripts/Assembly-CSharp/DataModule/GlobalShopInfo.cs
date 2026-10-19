using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E78")]
	public class GlobalShopInfo : GlobalInfoBase
	{
		[Token(Token = "0x40064E3")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x40064E4")]
		[FieldOffset(Offset = "0x20")]
		public string type;

		[Token(Token = "0x40064E5")]
		[FieldOffset(Offset = "0x28")]
		public string group;

		[Token(Token = "0x40064E6")]
		[FieldOffset(Offset = "0x30")]
		public string priceResourceId;

		[Token(Token = "0x40064E7")]
		[FieldOffset(Offset = "0x38")]
		public string priceValue;

		[Token(Token = "0x40064E8")]
		[FieldOffset(Offset = "0x40")]
		public string rewardA;

		[Token(Token = "0x40064E9")]
		[FieldOffset(Offset = "0x48")]
		public string rewardB;

		[Token(Token = "0x40064EA")]
		[FieldOffset(Offset = "0x50")]
		public int limitCount;

		[Token(Token = "0x17000F23")]
		public string reward
		{
			[Token(Token = "0x600589C")]
			[Address(RVA = "0x436468C", Offset = "0x436068C", VA = "0x436468C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600589D")]
			[Address(RVA = "0x436471C", Offset = "0x436071C", VA = "0x436471C")]
			set
			{
			}
		}

		[Token(Token = "0x600589E")]
		[Address(RVA = "0x43647B8", Offset = "0x43607B8", VA = "0x43647B8")]
		public GlobalShopInfo()
		{
		}
	}
}
