using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003A0")]
	public class JiXingTalent : TalentBase
	{
		[Token(Token = "0x600108E")]
		[Address(RVA = "0x3DA124C", Offset = "0x3D9D24C", VA = "0x3DA124C")]
		public JiXingTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x600108F")]
		[Address(RVA = "0x3DA1254", Offset = "0x3D9D254", VA = "0x3DA1254", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
