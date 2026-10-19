using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200039C")]
	public class ChengFangTalent : TalentBase
	{
		[Token(Token = "0x6001086")]
		[Address(RVA = "0x3DA0B88", Offset = "0x3D9CB88", VA = "0x3DA0B88")]
		public ChengFangTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x6001087")]
		[Address(RVA = "0x3DA0B90", Offset = "0x3D9CB90", VA = "0x3DA0B90", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
