using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003A7")]
	public class TiaoWangTalent : TalentBase
	{
		[Token(Token = "0x600109C")]
		[Address(RVA = "0x3DA1DC8", Offset = "0x3D9DDC8", VA = "0x3DA1DC8")]
		public TiaoWangTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x600109D")]
		[Address(RVA = "0x3DA1DD0", Offset = "0x3D9DDD0", VA = "0x3DA1DD0", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
