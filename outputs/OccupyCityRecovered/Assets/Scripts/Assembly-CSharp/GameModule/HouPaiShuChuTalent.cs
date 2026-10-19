using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003B1")]
	public class HouPaiShuChuTalent : TalentBase
	{
		[Token(Token = "0x60010B4")]
		[Address(RVA = "0x3DA35E0", Offset = "0x3D9F5E0", VA = "0x3DA35E0")]
		public HouPaiShuChuTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010B5")]
		[Address(RVA = "0x3DA35E8", Offset = "0x3D9F5E8", VA = "0x3DA35E8", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
