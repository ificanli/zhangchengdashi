using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E3B")]
	public class GlobalBotNameInfo : GlobalInfoBase
	{
		[Token(Token = "0x400630E")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x600577E")]
		[Address(RVA = "0x4353A64", Offset = "0x434FA64", VA = "0x4353A64")]
		public GlobalBotNameInfo()
		{
		}
	}
}
