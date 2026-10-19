using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E8B")]
	public class PanelConfig : GlobalInfoBase
	{
		[Token(Token = "0x4006562")]
		[FieldOffset(Offset = "0x18")]
		public string panelName;

		[Token(Token = "0x4006563")]
		[FieldOffset(Offset = "0x20")]
		public int group;

		[Token(Token = "0x4006564")]
		[FieldOffset(Offset = "0x24")]
		public int layer;

		[Token(Token = "0x4006565")]
		[FieldOffset(Offset = "0x28")]
		public int openEffect;

		[Token(Token = "0x4006566")]
		[FieldOffset(Offset = "0x30")]
		public string effectRoot;

		[Token(Token = "0x4006567")]
		[FieldOffset(Offset = "0x38")]
		public bool blockTutorialTrigger;

		[Token(Token = "0x60058B4")]
		[Address(RVA = "0x4364A80", Offset = "0x4360A80", VA = "0x4364A80")]
		public PanelConfig()
		{
		}
	}
}
