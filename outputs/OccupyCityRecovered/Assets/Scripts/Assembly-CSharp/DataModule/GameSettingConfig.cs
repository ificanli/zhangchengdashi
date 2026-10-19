using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E4D")]
	public class GameSettingConfig : GlobalInfoBase
	{
		[Token(Token = "0x4006395")]
		[FieldOffset(Offset = "0x18")]
		public string value;

		[Token(Token = "0x60057C3")]
		[Address(RVA = "0x4357EB4", Offset = "0x4353EB4", VA = "0x4357EB4")]
		public GameSettingConfig()
		{
		}
	}
}
