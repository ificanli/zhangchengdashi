using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003B8")]
	public class RuoDianDongXiTalent : TalentBase
	{
		[Token(Token = "0x60010C6")]
		[Address(RVA = "0x3DA551C", Offset = "0x3DA151C", VA = "0x3DA551C")]
		public RuoDianDongXiTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010C7")]
		[Address(RVA = "0x3DA5524", Offset = "0x3DA1524", VA = "0x3DA5524", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
