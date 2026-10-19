using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E39")]
	public class GlobalFormulaInfo : GlobalInfoBase
	{
		[Token(Token = "0x400630A")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400630B")]
		[FieldOffset(Offset = "0x20")]
		public string des;

		[Token(Token = "0x400630C")]
		[FieldOffset(Offset = "0x28")]
		public string priceFormula;

		[Token(Token = "0x400630D")]
		[FieldOffset(Offset = "0x30")]
		public string valueFormula;

		[Token(Token = "0x600577C")]
		[Address(RVA = "0x4353A54", Offset = "0x434FA54", VA = "0x4353A54")]
		public GlobalFormulaInfo()
		{
		}
	}
}
