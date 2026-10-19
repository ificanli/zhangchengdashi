using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E88")]
	public class GlobalMetaModuleInfo : GlobalInfoBase
	{
		[Token(Token = "0x400654C")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400654D")]
		[FieldOffset(Offset = "0x20")]
		public string spineIconPath;

		[Token(Token = "0x400654E")]
		[FieldOffset(Offset = "0x28")]
		public string showMetaPanelEvent;

		[Token(Token = "0x400654F")]
		[FieldOffset(Offset = "0x30")]
		public string hideMetaPanelEvent;

		[Token(Token = "0x4006550")]
		[FieldOffset(Offset = "0x38")]
		public string redDotKey;

		[Token(Token = "0x4006551")]
		[FieldOffset(Offset = "0x40")]
		public string spineKey_dianji;

		[Token(Token = "0x4006552")]
		[FieldOffset(Offset = "0x48")]
		public string spineKey_xunhuan;

		[Token(Token = "0x4006553")]
		[FieldOffset(Offset = "0x50")]
		public string spineKey_jingzhi;

		[Token(Token = "0x60058AE")]
		[Address(RVA = "0x4364894", Offset = "0x4360894", VA = "0x4364894")]
		public GlobalMetaModuleInfo()
		{
		}
	}
}
