using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E2E")]
	public class ArenaEnemyCardsInfo
	{
		[Token(Token = "0x40062CB")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x40062CC")]
		[FieldOffset(Offset = "0x18")]
		public string minArnenaLevel;

		[Token(Token = "0x40062CD")]
		[FieldOffset(Offset = "0x20")]
		public string mineCount;

		[Token(Token = "0x40062CE")]
		[FieldOffset(Offset = "0x28")]
		public string orcMeleeCount;

		[Token(Token = "0x40062CF")]
		[FieldOffset(Offset = "0x30")]
		public string orcRangeCount;

		[Token(Token = "0x40062D0")]
		[FieldOffset(Offset = "0x38")]
		public string humanMeleeCount;

		[Token(Token = "0x40062D1")]
		[FieldOffset(Offset = "0x40")]
		public string humanRangeCount;

		[Token(Token = "0x40062D2")]
		[FieldOffset(Offset = "0x48")]
		public string undeadMeleeCount;

		[Token(Token = "0x40062D3")]
		[FieldOffset(Offset = "0x50")]
		public string undeadRangeCount;

		[Token(Token = "0x40062D4")]
		[FieldOffset(Offset = "0x58")]
		public string machineMeleeCount;

		[Token(Token = "0x40062D5")]
		[FieldOffset(Offset = "0x60")]
		public string machineRangeCount;

		[Token(Token = "0x40062D6")]
		[FieldOffset(Offset = "0x68")]
		public string machineDefenseCount;

		[Token(Token = "0x40062D7")]
		[FieldOffset(Offset = "0x70")]
		public string fetterFull;

		[Token(Token = "0x6005746")]
		[Address(RVA = "0x4350D08", Offset = "0x434CD08", VA = "0x4350D08")]
		public ArenaEnemyCardsInfo()
		{
		}
	}
}
