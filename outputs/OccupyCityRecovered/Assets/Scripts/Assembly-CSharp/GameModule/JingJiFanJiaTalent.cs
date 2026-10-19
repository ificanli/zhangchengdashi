using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003B4")]
	public class JingJiFanJiaTalent : TalentBase
	{
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x3DA4780", Offset = "0x3DA0780", VA = "0x3DA4780")]
		public JingJiFanJiaTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x3DA4788", Offset = "0x3DA0788", VA = "0x3DA4788", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}

		[Token(Token = "0x60010BE")]
		[Address(RVA = "0x3DA4A40", Offset = "0x3DA0A40", VA = "0x3DA4A40", Slot = "7")]
		public override void Clear()
		{
		}
	}
}
