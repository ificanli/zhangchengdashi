using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003BC")]
	public class ShenJingChongJiTalent : TalentBase
	{
		[Token(Token = "0x60010D0")]
		[Address(RVA = "0x3DA6014", Offset = "0x3DA2014", VA = "0x3DA6014")]
		public ShenJingChongJiTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010D1")]
		[Address(RVA = "0x3DA601C", Offset = "0x3DA201C", VA = "0x3DA601C", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
