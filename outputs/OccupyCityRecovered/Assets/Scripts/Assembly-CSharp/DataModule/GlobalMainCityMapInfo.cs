using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E71")]
	public class GlobalMainCityMapInfo : GlobalInfoBase
	{
		[Token(Token = "0x40064B3")]
		[FieldOffset(Offset = "0x18")]
		public string infos;

		[Token(Token = "0x6005880")]
		[Address(RVA = "0x4361288", Offset = "0x435D288", VA = "0x4361288")]
		public GlobalMainCityMapInfo()
		{
		}
	}
}
