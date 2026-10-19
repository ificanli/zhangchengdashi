using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20003B0")]
	public class HanRenCiGuTalent : TalentBase
	{
		[Token(Token = "0x4002629")]
		[FieldOffset(Offset = "0x28")]
		private List<int> allAtkID;

		[Token(Token = "0x400262A")]
		[FieldOffset(Offset = "0x30")]
		private List<RoleBehaviour> allAtkRole;

		[Token(Token = "0x400262B")]
		[FieldOffset(Offset = "0x38")]
		private List<float> allAtkReduceSpeed;

		[Token(Token = "0x60010B1")]
		[Address(RVA = "0x3DA2FA8", Offset = "0x3D9EFA8", VA = "0x3DA2FA8")]
		public HanRenCiGuTalent(string talentId, GameEventType eventType, float value) : base(talentId, eventType, value)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED HanRenCiGuTalent..ctor RVA=0x3DA2FA8 Token=0x060010B1; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x60010B2")]
		[Address(RVA = "0x3DA30DC", Offset = "0x3D9F0DC", VA = "0x3DA30DC", Slot = "6")]
		protected override void HandleEvent(GameEventArgs args)
		{
		}

		[Token(Token = "0x60010B3")]
		[Address(RVA = "0x3DA3398", Offset = "0x3D9F398", VA = "0x3DA3398", Slot = "7")]
		public override void Clear()
		{
		}
	}
}
