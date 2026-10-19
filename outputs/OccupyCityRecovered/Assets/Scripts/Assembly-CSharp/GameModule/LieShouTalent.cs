using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003A3")]
	public class LieShouTalent : TalentBase
	{
		[Token(Token = "0x6001094")]
		[Address(RVA = "0x3DA1790", Offset = "0x3D9D790", VA = "0x3DA1790")]
		public LieShouTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x6001095")]
		[Address(RVA = "0x3DA1798", Offset = "0x3D9D798", VA = "0x3DA1798", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
