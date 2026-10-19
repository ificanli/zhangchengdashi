using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E92")]
	public class ShopArenaPackInfos : GlobalInfoBase
	{
		[Token(Token = "0x400658D")]
		[FieldOffset(Offset = "0x18")]
		public string purchaseId;

		[Token(Token = "0x400658E")]
		[FieldOffset(Offset = "0x20")]
		public int limitCount;

		[Token(Token = "0x400658F")]
		[FieldOffset(Offset = "0x24")]
		public int limitTime;

		[Token(Token = "0x4006590")]
		[FieldOffset(Offset = "0x28")]
		public string backgroundPath;

		[Token(Token = "0x4006591")]
		[FieldOffset(Offset = "0x30")]
		public string businessCardPath;

		[Token(Token = "0x4006592")]
		[FieldOffset(Offset = "0x38")]
		public string ArenaPath;

		[Token(Token = "0x4006593")]
		[FieldOffset(Offset = "0x40")]
		public string ArenaPackId;

		[Token(Token = "0x60058C0")]
		[Address(RVA = "0x43655F4", Offset = "0x43615F4", VA = "0x43655F4")]
		public ShopArenaPackInfos()
		{
		}
	}
}
