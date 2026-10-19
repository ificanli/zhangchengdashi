using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000567")]
	public class reportCard
	{
		[Token(Token = "0x4002F95")]
		[FieldOffset(Offset = "0x10")]
		public string cardid;

		[Token(Token = "0x4002F96")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x3EC7FF8", Offset = "0x3EC3FF8", VA = "0x3EC7FF8")]
		public reportCard()
		{
		}
	}
}
