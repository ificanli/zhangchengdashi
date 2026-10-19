using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003C3")]
	public class YingYanSuoDingTalent : TalentBase
	{
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x3DA7B80", Offset = "0x3DA3B80", VA = "0x3DA7B80")]
		public YingYanSuoDingTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x3DA7B88", Offset = "0x3DA3B88", VA = "0x3DA7B88", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
