using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E89")]
	public class GlobalSubMetaModuleInfo : GlobalInfo
	{
		[Token(Token = "0x4006554")]
		[FieldOffset(Offset = "0x2F8")]
		public string name;

		[Token(Token = "0x4006555")]
		[FieldOffset(Offset = "0x300")]
		public string iconPath;

		[Token(Token = "0x4006556")]
		[FieldOffset(Offset = "0x308")]
		public string parent;

		[Token(Token = "0x4006557")]
		[FieldOffset(Offset = "0x310")]
		public string unlockChapter;

		[Token(Token = "0x4006558")]
		[FieldOffset(Offset = "0x318")]
		public string clickEvent;

		[Token(Token = "0x60058AF")]
		[Address(RVA = "0x436489C", Offset = "0x436089C", VA = "0x436489C")]
		public GlobalSubMetaModuleInfo()
		{
		}
	}
}
