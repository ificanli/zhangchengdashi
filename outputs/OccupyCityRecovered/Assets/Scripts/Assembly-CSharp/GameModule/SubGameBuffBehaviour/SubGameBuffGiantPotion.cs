using DataModule;
using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x200061A")]
	public class SubGameBuffGiantPotion : SubGameBuffBase
	{
		[Token(Token = "0x4003264")]
		private const float MoveSpeedReduceRatio = 0.3f;

		[Token(Token = "0x4003265")]
		private const float HpIncreaseRatio = 0.3f;

		[Token(Token = "0x600207E")]
		[Address(RVA = "0x3F109C0", Offset = "0x3F0C9C0", VA = "0x3F109C0")]
		public SubGameBuffGiantPotion() : base(1014)
		{
		}

		[Token(Token = "0x600207F")]
		[Address(RVA = "0x3F109CC", Offset = "0x3F0C9CC", VA = "0x3F109CC", Slot = "4")]
		public override void ModifyRoleProperty(bool isEnemy, RolePropertyTemp propertyTemp, CardFettersType fettersType, AtkWayType atkWayType, int cardLevel)
		{
		}
	}
}
