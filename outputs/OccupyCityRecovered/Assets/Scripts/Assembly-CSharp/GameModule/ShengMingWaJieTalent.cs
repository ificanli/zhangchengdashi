using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003BB")]
	public class ShengMingWaJieTalent : TalentBase
	{
		[Token(Token = "0x60010CE")]
		[Address(RVA = "0x3DA5D94", Offset = "0x3DA1D94", VA = "0x3DA5D94")]
		public ShengMingWaJieTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010CF")]
		[Address(RVA = "0x3DA5D9C", Offset = "0x3DA1D9C", VA = "0x3DA5D9C", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
