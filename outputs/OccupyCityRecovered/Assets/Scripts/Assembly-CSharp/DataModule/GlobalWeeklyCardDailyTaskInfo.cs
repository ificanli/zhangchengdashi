using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E80")]
	public class GlobalWeeklyCardDailyTaskInfo : GlobalInfoBase
	{
		[Token(Token = "0x400651B")]
		[FieldOffset(Offset = "0x18")]
		public string i2Loc_Des;

		[Token(Token = "0x400651C")]
		[FieldOffset(Offset = "0x20")]
		public string taskType;

		[Token(Token = "0x400651D")]
		[FieldOffset(Offset = "0x28")]
		public string value;

		[Token(Token = "0x400651E")]
		[FieldOffset(Offset = "0x30")]
		public string reward;

		[Token(Token = "0x400651F")]
		[FieldOffset(Offset = "0x38")]
		public string activityNumber;

		[Token(Token = "0x60058A6")]
		[Address(RVA = "0x4364854", Offset = "0x4360854", VA = "0x4364854")]
		public GlobalWeeklyCardDailyTaskInfo()
		{
		}
	}
}
