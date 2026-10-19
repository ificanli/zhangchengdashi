using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200022B")]
	public struct FootballShootResult
	{
		[Token(Token = "0x4001DC5")]
		[FieldOffset(Offset = "0x0")]
		public bool IsGoal;

		[Token(Token = "0x4001DC6")]
		[FieldOffset(Offset = "0x1")]
		public bool WasSavedByKeeper;

		[Token(Token = "0x4001DC7")]
		[FieldOffset(Offset = "0x4")]
		public FootballGoalZone ShotZone;
	}
}
