using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003C7")]
	public class ZhenDangBoRenTalent : TalentBase
	{
		[Token(Token = "0x60010EB")]
		[Address(RVA = "0x3DA8038", Offset = "0x3DA4038", VA = "0x3DA8038")]
		public ZhenDangBoRenTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010EC")]
		[Address(RVA = "0x3DA8040", Offset = "0x3DA4040", VA = "0x3DA8040", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
