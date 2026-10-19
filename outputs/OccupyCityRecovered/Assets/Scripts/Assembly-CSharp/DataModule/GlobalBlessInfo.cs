using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E57")]
	public class GlobalBlessInfo : GlobalInfoBase
	{
		[Token(Token = "0x40063DA")]
		[FieldOffset(Offset = "0x18")]
		public string I2Loc_name;

		[Token(Token = "0x40063DB")]
		[FieldOffset(Offset = "0x20")]
		public string I2Loc_des;

		[Token(Token = "0x40063DC")]
		[FieldOffset(Offset = "0x28")]
		public string value;

		[Token(Token = "0x40063DD")]
		[FieldOffset(Offset = "0x30")]
		public string valueType;

		[Token(Token = "0x40063DE")]
		[FieldOffset(Offset = "0x38")]
		public string upgradePrice;

		[Token(Token = "0x40063DF")]
		[FieldOffset(Offset = "0x40")]
		public string rareLevel;

		[Token(Token = "0x40063E0")]
		[FieldOffset(Offset = "0x48")]
		public string IconPath;

		[Token(Token = "0x40063E1")]
		[FieldOffset(Offset = "0x50")]
		public string blessType;

		[Token(Token = "0x60057E4")]
		[Address(RVA = "0x4358B28", Offset = "0x4354B28", VA = "0x4358B28")]
		public GlobalBlessInfo()
		{
		}
	}
}
