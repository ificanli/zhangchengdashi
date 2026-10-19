using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003AA")]
	public class XuePoTalent : TalentBase
	{
		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x3DA2260", Offset = "0x3D9E260", VA = "0x3DA2260")]
		public XuePoTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x3DA2268", Offset = "0x3D9E268", VA = "0x3DA2268", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
