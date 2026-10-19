using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200039E")]
	public class JianJiaTalent : TalentBase
	{
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x3DA0E7C", Offset = "0x3D9CE7C", VA = "0x3DA0E7C")]
		public JianJiaTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x600108B")]
		[Address(RVA = "0x3DA0E84", Offset = "0x3D9CE84", VA = "0x3DA0E84", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
