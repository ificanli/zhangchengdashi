using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200028F")]
	public class HexMirrorInfo
	{
		[Token(Token = "0x4002059")]
		[FieldOffset(Offset = "0x10")]
		public string Key;

		[Token(Token = "0x400205A")]
		[FieldOffset(Offset = "0x18")]
		public Quality Quality;

		[Token(Token = "0x400205B")]
		[FieldOffset(Offset = "0x1C")]
		public RareLevel RareLevel;

		[Token(Token = "0x400205C")]
		[FieldOffset(Offset = "0x20")]
		public HexType HexType;

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x4420A88", Offset = "0x441CA88", VA = "0x4420A88")]
		public HexMirrorInfo()
		{
		}
	}
}
