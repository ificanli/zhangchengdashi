using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E60")]
	public class GlobalCardTalenTreeInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006418")]
		[FieldOffset(Offset = "0x18")]
		public string cardLevelTalent;

		[Token(Token = "0x4006419")]
		[FieldOffset(Offset = "0x20")]
		public string talentNode;

		[Token(Token = "0x6005805")]
		[Address(RVA = "0x435A73C", Offset = "0x435673C", VA = "0x435A73C")]
		public GlobalCardTalenTreeInfo()
		{
		}
	}
}
