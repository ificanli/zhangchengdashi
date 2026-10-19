using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E49")]
	public class GlobalDanInfo : GlobalInfoBase
	{
		[Token(Token = "0x4006373")]
		[FieldOffset(Offset = "0x18")]
		public string danName;

		[Token(Token = "0x4006374")]
		[FieldOffset(Offset = "0x20")]
		public string trophyRequire;

		[Token(Token = "0x4006375")]
		[FieldOffset(Offset = "0x28")]
		public string cardReward;

		[Token(Token = "0x4006376")]
		[FieldOffset(Offset = "0x30")]
		public string trophyReward;

		[Token(Token = "0x4006377")]
		[FieldOffset(Offset = "0x38")]
		public string coinReward;

		[Token(Token = "0x4006378")]
		[FieldOffset(Offset = "0x40")]
		public string iconPath;

		[Token(Token = "0x4006379")]
		[FieldOffset(Offset = "0x48")]
		public string talentLimitLevel;

		[Token(Token = "0x60057BE")]
		[Address(RVA = "0x4357C68", Offset = "0x4353C68", VA = "0x4357C68")]
		public GlobalDanInfo()
		{
		}
	}
}
