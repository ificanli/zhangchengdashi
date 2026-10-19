using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E4C")]
	public class GlobalProgressInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006390")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x4006391")]
		[FieldOffset(Offset = "0x20")]
		public string type;

		[Token(Token = "0x4006392")]
		[FieldOffset(Offset = "0x28")]
		public string startLevel;

		[Token(Token = "0x4006393")]
		[FieldOffset(Offset = "0x30")]
		public string formulaId;

		[Token(Token = "0x4006394")]
		[FieldOffset(Offset = "0x38")]
		public string displayContent;

		[Token(Token = "0x60057C2")]
		[Address(RVA = "0x4357EAC", Offset = "0x4353EAC", VA = "0x4357EAC")]
		public GlobalProgressInfo()
		{
		}
	}
}
