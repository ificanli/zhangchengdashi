using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E4E")]
	public class GloablMainCityBuildTalentInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006396")]
		[FieldOffset(Offset = "0x18")]
		public string buildType;

		[Token(Token = "0x4006397")]
		[FieldOffset(Offset = "0x20")]
		public string talentNum;

		[Token(Token = "0x4006398")]
		[FieldOffset(Offset = "0x28")]
		public string assetInfoId;

		[Token(Token = "0x60057C4")]
		[Address(RVA = "0x4357EBC", Offset = "0x4353EBC", VA = "0x4357EBC")]
		public GloablMainCityBuildTalentInfo()
		{
		}
	}
}
