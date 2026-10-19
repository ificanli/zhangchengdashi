using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003A2")]
	public class KongZhongYouShiTalent : TalentBase
	{
		[Token(Token = "0x6001092")]
		[Address(RVA = "0x3DA15B0", Offset = "0x3D9D5B0", VA = "0x3DA15B0")]
		public KongZhongYouShiTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x6001093")]
		[Address(RVA = "0x3DA15B8", Offset = "0x3D9D5B8", VA = "0x3DA15B8", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
