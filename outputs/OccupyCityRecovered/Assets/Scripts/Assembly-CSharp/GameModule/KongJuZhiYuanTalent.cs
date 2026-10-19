using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003A1")]
	public class KongJuZhiYuanTalent : TalentBase
	{
		[Token(Token = "0x6001090")]
		[Address(RVA = "0x3DA1374", Offset = "0x3D9D374", VA = "0x3DA1374")]
		public KongJuZhiYuanTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x6001091")]
		[Address(RVA = "0x3DA137C", Offset = "0x3D9D37C", VA = "0x3DA137C", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
