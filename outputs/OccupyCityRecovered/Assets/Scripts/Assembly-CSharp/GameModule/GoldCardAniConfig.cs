using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000449")]
	public class GoldCardAniConfig
	{
		[Token(Token = "0x4002A27")]
		[FieldOffset(Offset = "0x10")]
		public bool isEnemy;

		[Token(Token = "0x4002A28")]
		[FieldOffset(Offset = "0x14")]
		public int odds;

		[Token(Token = "0x4002A29")]
		[FieldOffset(Offset = "0x18")]
		public string id;

		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x3E06530", Offset = "0x3E02530", VA = "0x3E06530")]
		public GoldCardAniConfig(bool isEnemy, int odds, string id)
		{
		}
	}
}
