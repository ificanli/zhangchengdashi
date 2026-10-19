using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E7E")]
	public class GlobalTrophyProgressInfo : GlobalInfoBase
	{
		[Token(Token = "0x400650B")]
		[FieldOffset(Offset = "0x18")]
		public int TrophyRequire;

		[Token(Token = "0x400650C")]
		[FieldOffset(Offset = "0x20")]
		public string NodeAwardType;

		[Token(Token = "0x400650D")]
		[FieldOffset(Offset = "0x28")]
		public string Arena;

		[Token(Token = "0x400650E")]
		[FieldOffset(Offset = "0x30")]
		public string Card;

		[Token(Token = "0x400650F")]
		[FieldOffset(Offset = "0x38")]
		public string Expression;

		[Token(Token = "0x4006510")]
		[FieldOffset(Offset = "0x40")]
		public int Gold;

		[Token(Token = "0x4006511")]
		[FieldOffset(Offset = "0x44")]
		public int Diamond;

		[Token(Token = "0x4006512")]
		[FieldOffset(Offset = "0x48")]
		public int TreasureBox;

		[Token(Token = "0x4006513")]
		[FieldOffset(Offset = "0x50")]
		public string UniversalCard;

		[Token(Token = "0x4006514")]
		[FieldOffset(Offset = "0x58")]
		public string UnlockFunction;

		[Token(Token = "0x4006515")]
		[FieldOffset(Offset = "0x60")]
		public string UnlockFunctionName;

		[Token(Token = "0x60058A4")]
		[Address(RVA = "0x4364844", Offset = "0x4360844", VA = "0x4364844")]
		public GlobalTrophyProgressInfo()
		{
		}
	}
}
