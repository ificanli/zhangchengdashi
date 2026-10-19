using Il2CppDummyDll;

namespace BadgeGraph.Demo
{
	[Token(Token = "0x2000E0F")]
	internal enum BadgeType
	{
		[Token(Token = "0x4006207")]
		Event = 0,
		[Token(Token = "0x4006208")]
		CardEvent = 1,
		[Token(Token = "0x4006209")]
		AnimalCardEvent = 2,
		[Token(Token = "0x400620A")]
		SportCardEvent = 3,
		[Token(Token = "0x400620B")]
		Mail = 4,
		[Token(Token = "0x400620C")]
		NotifyMail = 5,
		[Token(Token = "0x400620D")]
		RewardMail = 6,
		[Token(Token = "0x400620E")]
		Task = 7,
		[Token(Token = "0x400620F")]
		BeginnerTask = 8,
		[Token(Token = "0x4006210")]
		DailyTask = 9,
		[Token(Token = "0x4006211")]
		SpecialTask = 10
	}
}
