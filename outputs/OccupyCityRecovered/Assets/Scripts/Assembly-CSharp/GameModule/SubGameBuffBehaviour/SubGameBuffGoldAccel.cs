using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x200061C")]
	public class SubGameBuffGoldAccel : SubGameBuffBase
	{
		[Token(Token = "0x4003268")]
		private const float OutputMultiplier = 2f;

		[Token(Token = "0x6002082")]
		[Address(RVA = "0x3F10CE0", Offset = "0x3F0CCE0", VA = "0x3F10CE0")]
		public SubGameBuffGoldAccel() : base(1011)
		{
		}

		[Token(Token = "0x6002083")]
		[Address(RVA = "0x3F10CEC", Offset = "0x3F0CCEC", VA = "0x3F10CEC", Slot = "7")]
		public override void ModifyGoldMineOutput(ref float outputBonus, bool isEnemy)
		{
		}
	}
}
