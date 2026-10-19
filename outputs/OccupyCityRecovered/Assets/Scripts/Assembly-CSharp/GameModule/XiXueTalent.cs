using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003A9")]
	public class XiXueTalent : TalentBase
	{
		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x3DA20CC", Offset = "0x3D9E0CC", VA = "0x3DA20CC")]
		public XiXueTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x3DA20D4", Offset = "0x3D9E0D4", VA = "0x3DA20D4", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
