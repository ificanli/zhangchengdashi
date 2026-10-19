using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E5D")]
	public class GlobalBuildInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006407")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4006408")]
		[FieldOffset(Offset = "0x20")]
		public string type;

		[Token(Token = "0x4006409")]
		[FieldOffset(Offset = "0x28")]
		public string prefabPath;

		[Token(Token = "0x6005801")]
		[Address(RVA = "0x435A6B4", Offset = "0x43566B4", VA = "0x435A6B4")]
		public GlobalBuildInfo()
		{
		}
	}
}
