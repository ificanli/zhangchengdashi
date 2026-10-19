using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003C6")]
	public class ZhanDouKuangReTalent : TalentBase
	{
		[Token(Token = "0x400265B")]
		[FieldOffset(Offset = "0x24")]
		private int atkNum;

		[Token(Token = "0x60010E9")]
		[Address(RVA = "0x3DA7F48", Offset = "0x3DA3F48", VA = "0x3DA7F48")]
		public ZhanDouKuangReTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010EA")]
		[Address(RVA = "0x3DA7F50", Offset = "0x3DA3F50", VA = "0x3DA7F50", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
