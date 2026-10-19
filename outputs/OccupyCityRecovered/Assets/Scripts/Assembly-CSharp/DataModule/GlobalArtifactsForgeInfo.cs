using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E51")]
	public class GlobalArtifactsForgeInfo : GlobalInfoBase
	{
		[Token(Token = "0x40063BE")]
		[FieldOffset(Offset = "0x18")]
		public int Level;

		[Token(Token = "0x40063BF")]
		[FieldOffset(Offset = "0x1C")]
		public int Quality;

		[Token(Token = "0x40063C0")]
		[FieldOffset(Offset = "0x20")]
		public int CardGrouping;

		[Token(Token = "0x40063C1")]
		[FieldOffset(Offset = "0x24")]
		public int attrType;

		[Token(Token = "0x40063C2")]
		[FieldOffset(Offset = "0x28")]
		public double attrValue;

		[Token(Token = "0x40063C3")]
		[FieldOffset(Offset = "0x30")]
		public int ValueType;

		[Token(Token = "0x40063C4")]
		[FieldOffset(Offset = "0x38")]
		public string iconPath;

		[Token(Token = "0x40063C5")]
		[FieldOffset(Offset = "0x40")]
		public string I2LocKey;

		[Token(Token = "0x60057C8")]
		[Address(RVA = "0x4357F64", Offset = "0x4353F64", VA = "0x4357F64")]
		public GlobalArtifactsForgeInfo()
		{
		}
	}
}
