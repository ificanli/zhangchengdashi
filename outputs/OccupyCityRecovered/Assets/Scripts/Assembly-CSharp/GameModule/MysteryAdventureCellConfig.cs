using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x2000504")]
	public class MysteryAdventureCellConfig
	{
		[Token(Token = "0x4002D4C")]
		[FieldOffset(Offset = "0x10")]
		public int CellId;

		[Token(Token = "0x4002D4D")]
		[FieldOffset(Offset = "0x14")]
		public int BuildId;

		[Token(Token = "0x4002D4E")]
		[FieldOffset(Offset = "0x18")]
		public int PoolId;

		[Token(Token = "0x4002D4F")]
		[FieldOffset(Offset = "0x20")]
		public string BuildName;

		[Token(Token = "0x4002D50")]
		[FieldOffset(Offset = "0x28")]
		public MysteryAdventureCellType CellType;

		[Token(Token = "0x4002D51")]
		[FieldOffset(Offset = "0x2C")]
		public MysteryAdventureTriggerType TriggerType;

		[Token(Token = "0x4002D52")]
		[FieldOffset(Offset = "0x30")]
		public int RewardMin;

		[Token(Token = "0x4002D53")]
		[FieldOffset(Offset = "0x34")]
		public int RewardMax;

		[Token(Token = "0x4002D54")]
		[FieldOffset(Offset = "0x38")]
		public string ResourceId;

		[Token(Token = "0x6001958")]
		[Address(RVA = "0x3E92594", Offset = "0x3E8E594", VA = "0x3E92594")]
		public MysteryAdventureCellConfig()
		{
		}
	}
}
