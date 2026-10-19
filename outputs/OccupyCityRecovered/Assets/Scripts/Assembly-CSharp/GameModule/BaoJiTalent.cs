using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200039B")]
	public class BaoJiTalent : TalentBase
	{
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x3DA09F4", Offset = "0x3D9C9F4", VA = "0x3DA09F4")]
		public BaoJiTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x6001085")]
		[Address(RVA = "0x3DA09FC", Offset = "0x3D9C9FC", VA = "0x3DA09FC", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
