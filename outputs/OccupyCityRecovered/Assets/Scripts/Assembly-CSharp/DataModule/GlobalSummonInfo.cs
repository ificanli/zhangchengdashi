using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E79")]
	public class GlobalSummonInfo : GlobalInfoBase
	{
		[Token(Token = "0x40064EB")]
		[FieldOffset(Offset = "0x18")]
		public string level;

		[Token(Token = "0x40064EC")]
		[FieldOffset(Offset = "0x20")]
		public string summonExp;

		[Token(Token = "0x40064ED")]
		[FieldOffset(Offset = "0x28")]
		public string crystalWeight;

		[Token(Token = "0x40064EE")]
		[FieldOffset(Offset = "0x30")]
		public string commonPropWeight;

		[Token(Token = "0x40064EF")]
		[FieldOffset(Offset = "0x38")]
		public string rarePropWeight;

		[Token(Token = "0x40064F0")]
		[FieldOffset(Offset = "0x40")]
		public string epicPropWeight;

		[Token(Token = "0x40064F1")]
		[FieldOffset(Offset = "0x48")]
		public string legendPropWeight;

		[Token(Token = "0x40064F2")]
		[FieldOffset(Offset = "0x50")]
		public string totalWeight;

		[Token(Token = "0x600589F")]
		[Address(RVA = "0x43647C0", Offset = "0x43607C0", VA = "0x43647C0")]
		public GlobalSummonInfo()
		{
		}
	}
}
