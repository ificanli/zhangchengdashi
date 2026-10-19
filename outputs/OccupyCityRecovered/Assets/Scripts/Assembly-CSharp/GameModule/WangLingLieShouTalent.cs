using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003A8")]
	public class WangLingLieShouTalent : TalentBase
	{
		[Token(Token = "0x600109E")]
		[Address(RVA = "0x3DA1EE4", Offset = "0x3D9DEE4", VA = "0x3DA1EE4")]
		public WangLingLieShouTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x600109F")]
		[Address(RVA = "0x3DA1EEC", Offset = "0x3D9DEEC", VA = "0x3DA1EEC", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
