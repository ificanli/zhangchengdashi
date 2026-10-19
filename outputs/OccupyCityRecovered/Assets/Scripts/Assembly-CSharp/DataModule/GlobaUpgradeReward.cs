using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E82")]
	public class GlobaUpgradeReward : GlobalInfoBase
	{
		[Token(Token = "0x4006522")]
		[FieldOffset(Offset = "0x18")]
		public string type;

		[Token(Token = "0x4006523")]
		[FieldOffset(Offset = "0x20")]
		public string rewardId;

		[Token(Token = "0x4006524")]
		[FieldOffset(Offset = "0x28")]
		public string rewardConfig;

		[Token(Token = "0x60058A8")]
		[Address(RVA = "0x4364864", Offset = "0x4360864", VA = "0x4364864")]
		public GlobaUpgradeReward()
		{
		}
	}
}
