using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200039F")]
	public class JiXieKeXingTalent : TalentBase
	{
		[Token(Token = "0x600108C")]
		[Address(RVA = "0x3DA1010", Offset = "0x3D9D010", VA = "0x3DA1010")]
		public JiXieKeXingTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x600108D")]
		[Address(RVA = "0x3DA1018", Offset = "0x3D9D018", VA = "0x3DA1018", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
