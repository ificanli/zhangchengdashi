using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003BE")]
	public class SiWangJuJiaoTalent : TalentBase
	{
		[Token(Token = "0x4002645")]
		[FieldOffset(Offset = "0x28")]
		private EntityBase TargetEntityBase;

		[Token(Token = "0x4002646")]
		[FieldOffset(Offset = "0x30")]
		private float frontDamage;

		[Token(Token = "0x60010D5")]
		[Address(RVA = "0x3DA62D8", Offset = "0x3DA22D8", VA = "0x3DA62D8")]
		public SiWangJuJiaoTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
		}

		[Token(Token = "0x60010D6")]
		[Address(RVA = "0x3DA62E0", Offset = "0x3DA22E0", VA = "0x3DA62E0", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}
	}
}
