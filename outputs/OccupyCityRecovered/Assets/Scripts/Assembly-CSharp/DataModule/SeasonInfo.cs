using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E90")]
	public class SeasonInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006587")]
		[FieldOffset(Offset = "0x18")]
		public string roleId;

		[Token(Token = "0x4006588")]
		[FieldOffset(Offset = "0x20")]
		public int index;

		[Token(Token = "0x60058BE")]
		[Address(RVA = "0x43655E4", Offset = "0x43615E4", VA = "0x43655E4")]
		public SeasonInfo()
		{
		}
	}
}
