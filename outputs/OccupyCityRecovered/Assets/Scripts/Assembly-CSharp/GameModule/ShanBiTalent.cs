using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003A6")]
	public class ShanBiTalent : TalentBase
	{
		[Token(Token = "0x600109A")]
		[Address(RVA = "0x3DA1C34", Offset = "0x3D9DC34", VA = "0x3DA1C34")]
		public ShanBiTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x600109B")]
		[Address(RVA = "0x3DA1C3C", Offset = "0x3D9DC3C", VA = "0x3DA1C3C", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
