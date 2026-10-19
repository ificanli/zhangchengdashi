using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003A4")]
	public class PoHuaiZheTalent : TalentBase
	{
		[Token(Token = "0x6001096")]
		[Address(RVA = "0x3DA19A8", Offset = "0x3D9D9A8", VA = "0x3DA19A8")]
		public PoHuaiZheTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x6001097")]
		[Address(RVA = "0x3DA19B0", Offset = "0x3D9D9B0", VA = "0x3DA19B0", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
