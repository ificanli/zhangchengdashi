using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003A5")]
	public class QiangGongTalent : TalentBase
	{
		[Token(Token = "0x6001098")]
		[Address(RVA = "0x3DA1A7C", Offset = "0x3D9DA7C", VA = "0x3DA1A7C")]
		public QiangGongTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x6001099")]
		[Address(RVA = "0x3DA1A84", Offset = "0x3D9DA84", VA = "0x3DA1A84", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
