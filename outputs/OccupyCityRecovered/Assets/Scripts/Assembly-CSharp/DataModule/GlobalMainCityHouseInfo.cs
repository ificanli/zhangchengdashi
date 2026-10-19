using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E84")]
	public class GlobalMainCityHouseInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006529")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x400652A")]
		[FieldOffset(Offset = "0x20")]
		public string rareLevel;

		[Token(Token = "0x400652B")]
		[FieldOffset(Offset = "0x28")]
		public string faction;

		[Token(Token = "0x400652C")]
		[FieldOffset(Offset = "0x30")]
		public string defaultPopulation;

		[Token(Token = "0x60058AA")]
		[Address(RVA = "0x4364874", Offset = "0x4360874", VA = "0x4364874")]
		public GlobalMainCityHouseInfo()
		{
		}
	}
}
