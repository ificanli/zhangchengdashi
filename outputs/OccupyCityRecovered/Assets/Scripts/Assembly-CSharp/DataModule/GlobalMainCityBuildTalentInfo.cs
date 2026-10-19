using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E70")]
	public class GlobalMainCityBuildTalentInfo : GlobalInfoBase
	{
		[Token(Token = "0x40064B0")]
		[FieldOffset(Offset = "0x18")]
		public string buildType;

		[Token(Token = "0x40064B1")]
		[FieldOffset(Offset = "0x20")]
		public string talentNum;

		[Token(Token = "0x40064B2")]
		[FieldOffset(Offset = "0x28")]
		public string assetInfoId;

		[Token(Token = "0x600587F")]
		[Address(RVA = "0x4361280", Offset = "0x435D280", VA = "0x4361280")]
		public GlobalMainCityBuildTalentInfo()
		{
		}
	}
}
