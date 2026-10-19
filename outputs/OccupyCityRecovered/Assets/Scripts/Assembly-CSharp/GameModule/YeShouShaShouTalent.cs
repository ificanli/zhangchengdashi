using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003AB")]
	public class YeShouShaShouTalent : TalentBase
	{
		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x3DA23E8", Offset = "0x3D9E3E8", VA = "0x3DA23E8")]
		public YeShouShaShouTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x3DA23F0", Offset = "0x3D9E3F0", VA = "0x3DA23F0", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
