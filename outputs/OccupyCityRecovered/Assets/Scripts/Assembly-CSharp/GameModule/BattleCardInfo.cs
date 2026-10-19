using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200056B")]
	public class BattleCardInfo
	{
		[Token(Token = "0x4002FE8")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4002FE9")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		[Token(Token = "0x4002FEA")]
		[FieldOffset(Offset = "0x20")]
		public string type;

		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0x3EC8008", Offset = "0x3EC4008", VA = "0x3EC8008")]
		public BattleCardInfo()
		{
		}
	}
}
