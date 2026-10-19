using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003C4")]
	public class YuanJuSheJiTalent : TalentBase
	{
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x3DA7C24", Offset = "0x3DA3C24", VA = "0x3DA7C24")]
		public YuanJuSheJiTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010E6")]
		[Address(RVA = "0x3DA7C2C", Offset = "0x3DA3C2C", VA = "0x3DA7C2C", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
