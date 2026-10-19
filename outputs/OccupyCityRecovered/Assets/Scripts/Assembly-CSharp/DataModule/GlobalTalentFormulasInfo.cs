using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E7A")]
	public class GlobalTalentFormulasInfo : GlobalInfoBase
	{
		[Token(Token = "0x40064F3")]
		[FieldOffset(Offset = "0x18")]
		public string numFormulas;

		[Token(Token = "0x40064F4")]
		[FieldOffset(Offset = "0x20")]
		public string upgradeRequireAssetFormulas;

		[Token(Token = "0x40064F5")]
		[FieldOffset(Offset = "0x28")]
		public string des;

		[Token(Token = "0x60058A0")]
		[Address(RVA = "0x43647C8", Offset = "0x43607C8", VA = "0x43647C8")]
		public GlobalTalentFormulasInfo()
		{
		}
	}
}
