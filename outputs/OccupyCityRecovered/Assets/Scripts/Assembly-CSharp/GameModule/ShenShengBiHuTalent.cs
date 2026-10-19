using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003BD")]
	public class ShenShengBiHuTalent : TalentBase
	{
		[Token(Token = "0x60010D2")]
		[Address(RVA = "0x3DA612C", Offset = "0x3DA212C", VA = "0x3DA612C")]
		public ShenShengBiHuTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010D3")]
		[Address(RVA = "0x3DA6134", Offset = "0x3DA2134", VA = "0x3DA6134", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}

		[Token(Token = "0x60010D4")]
		[Address(RVA = "0x3DA62D0", Offset = "0x3DA22D0", VA = "0x3DA62D0", Slot = "7")]
		public override void Clear()
		{
		}
	}
}
