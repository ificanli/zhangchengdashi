using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E83")]
	public class GlobalMainCityAssetsInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006525")]
		[FieldOffset(Offset = "0x18")]
		public string path;

		[Token(Token = "0x4006526")]
		[FieldOffset(Offset = "0x20")]
		public string highPath;

		[Token(Token = "0x4006527")]
		[FieldOffset(Offset = "0x28")]
		public string nameKey;

		[Token(Token = "0x4006528")]
		[FieldOffset(Offset = "0x30")]
		public string iconPath;

		[Token(Token = "0x60058A9")]
		[Address(RVA = "0x436486C", Offset = "0x436086C", VA = "0x436486C")]
		public GlobalMainCityAssetsInfo()
		{
		}
	}
}
