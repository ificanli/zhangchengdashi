using DataModule;
using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000626")]
	public class SubGameBuffTopSuppress : SubGameBuffBase
	{
		[Token(Token = "0x4003277")]
		private const float LegendaryBonusRatio = 0.3f;

		[Token(Token = "0x4003278")]
		private const float NormalPenaltyRatio = 0.3f;

		[Token(Token = "0x6002098")]
		[Address(RVA = "0x3F114C8", Offset = "0x3F0D4C8", VA = "0x3F114C8")]
		public SubGameBuffTopSuppress() : base(1016)
		{
		}

		[Token(Token = "0x6002099")]
		[Address(RVA = "0x3F114D4", Offset = "0x3F0D4D4", VA = "0x3F114D4", Slot = "4")]
		public override void ModifyRoleProperty(bool isEnemy, RolePropertyTemp propertyTemp, CardFettersType fettersType, AtkWayType atkWayType, int cardLevel)
		{
		}
	}
}
