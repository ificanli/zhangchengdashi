using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003B7")]
	public class LieShaChongCiTalent : TalentBase
	{
		[Token(Token = "0x400263C")]
		[FieldOffset(Offset = "0x24")]
		private int addCount;

		[Token(Token = "0x60010C4")]
		[Address(RVA = "0x3DA5448", Offset = "0x3DA1448", VA = "0x3DA5448")]
		public LieShaChongCiTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x3DA5450", Offset = "0x3DA1450", VA = "0x3DA5450", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
