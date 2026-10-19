using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E6A")]
	public class GlobalHexInfo : GlobalInfoBase
	{
		[Token(Token = "0x400643B")]
		[FieldOffset(Offset = "0x18")]
		public string des;

		[Token(Token = "0x400643C")]
		[FieldOffset(Offset = "0x20")]
		public string price;

		[Token(Token = "0x400643D")]
		[FieldOffset(Offset = "0x28")]
		public string uiResPath;

		[Token(Token = "0x400643E")]
		[FieldOffset(Offset = "0x30")]
		public string probabilityProfile;

		[Token(Token = "0x6005829")]
		[Address(RVA = "0x435BB30", Offset = "0x4357B30", VA = "0x435BB30")]
		public GlobalHexInfo()
		{
		}
	}
}
