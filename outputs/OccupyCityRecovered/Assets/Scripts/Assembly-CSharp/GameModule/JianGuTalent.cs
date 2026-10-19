using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200039D")]
	public class JianGuTalent : TalentBase
	{
		[Token(Token = "0x6001088")]
		[Address(RVA = "0x3DA0CC0", Offset = "0x3D9CCC0", VA = "0x3DA0CC0")]
		public JianGuTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x6001089")]
		[Address(RVA = "0x3DA0CC8", Offset = "0x3D9CCC8", VA = "0x3DA0CC8", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
