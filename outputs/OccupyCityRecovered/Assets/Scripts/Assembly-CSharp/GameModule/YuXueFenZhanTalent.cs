using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003C5")]
	public class YuXueFenZhanTalent : TalentBase
	{
		[Token(Token = "0x4002659")]
		[FieldOffset(Offset = "0x21")]
		private bool addOffset;

		[Token(Token = "0x400265A")]
		[FieldOffset(Offset = "0x24")]
		private float offset;

		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x3DA7DE0", Offset = "0x3DA3DE0", VA = "0x3DA7DE0")]
		public YuXueFenZhanTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010E8")]
		[Address(RVA = "0x3DA7DE8", Offset = "0x3DA3DE8", VA = "0x3DA7DE8", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
