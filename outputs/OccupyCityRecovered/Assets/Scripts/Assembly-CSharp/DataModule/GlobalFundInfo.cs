using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E67")]
	public class GlobalFundInfo : GlobalInfoBase
	{
		[Token(Token = "0x400642A")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		[Token(Token = "0x400642B")]
		[FieldOffset(Offset = "0x1C")]
		public int need;

		[Token(Token = "0x400642C")]
		[FieldOffset(Offset = "0x20")]
		public string reward1A;

		[Token(Token = "0x400642D")]
		[FieldOffset(Offset = "0x28")]
		public string reward2A;

		[Token(Token = "0x400642E")]
		[FieldOffset(Offset = "0x30")]
		public string reward3A;

		[Token(Token = "0x400642F")]
		[FieldOffset(Offset = "0x38")]
		public string reward1B;

		[Token(Token = "0x4006430")]
		[FieldOffset(Offset = "0x40")]
		public string reward2B;

		[Token(Token = "0x4006431")]
		[FieldOffset(Offset = "0x48")]
		public string reward3B;

		[Token(Token = "0x17000F11")]
		public string reward1
		{
			[Token(Token = "0x6005822")]
			[Address(RVA = "0x435B8D8", Offset = "0x43578D8", VA = "0x435B8D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F12")]
		public string reward2
		{
			[Token(Token = "0x6005823")]
			[Address(RVA = "0x435B968", Offset = "0x4357968", VA = "0x435B968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F13")]
		public string reward3
		{
			[Token(Token = "0x6005824")]
			[Address(RVA = "0x435B9F8", Offset = "0x43579F8", VA = "0x435B9F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005825")]
		[Address(RVA = "0x435BA88", Offset = "0x4357A88", VA = "0x435BA88")]
		public GlobalFundInfo()
		{
		}
	}
}
