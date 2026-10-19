using DataModule;
using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x200061B")]
	public class SubGameBuffGlassCannon : SubGameBuffBase
	{
		[Token(Token = "0x4003266")]
		private const float AttackIncreaseRatio = 0.25f;

		[Token(Token = "0x4003267")]
		private const float HpReduceRatio = 0.3f;

		[Token(Token = "0x6002080")]
		[Address(RVA = "0x3F10AF4", Offset = "0x3F0CAF4", VA = "0x3F10AF4")]
		public SubGameBuffGlassCannon() : base(1015)
		{
		}

		[Token(Token = "0x6002081")]
		[Address(RVA = "0x3F10B00", Offset = "0x3F0CB00", VA = "0x3F10B00", Slot = "4")]
		public override void ModifyRoleProperty(bool isEnemy, RolePropertyTemp propertyTemp, CardFettersType fettersType, AtkWayType atkWayType, int cardLevel)
		{
		}
	}
}
