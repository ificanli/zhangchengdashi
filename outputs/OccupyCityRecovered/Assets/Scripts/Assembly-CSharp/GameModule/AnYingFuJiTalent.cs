using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003AC")]
	public class AnYingFuJiTalent : TalentBase
	{
		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x3DA2690", Offset = "0x3D9E690", VA = "0x3DA2690")]
		public AnYingFuJiTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010A7")]
		[Address(RVA = "0x3DA2698", Offset = "0x3D9E698", VA = "0x3DA2698", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
