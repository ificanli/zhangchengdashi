using DataModule;
using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000624")]
	public class SubGameBuffTechInnovation : SubGameBuffBase
	{
		[Token(Token = "0x4003274")]
		private const float SpawnSpeedIncreaseRatio = 0.3f;

		[Token(Token = "0x4003275")]
		private const float HpReduceRatio = 0.15f;

		[Token(Token = "0x6002093")]
		[Address(RVA = "0x3F11310", Offset = "0x3F0D310", VA = "0x3F11310")]
		public SubGameBuffTechInnovation() : base(1019)
		{
		}

		[Token(Token = "0x6002094")]
		[Address(RVA = "0x3F1131C", Offset = "0x3F0D31C", VA = "0x3F1131C", Slot = "4")]
		public override void ModifyRoleProperty(bool isEnemy, RolePropertyTemp propertyTemp, CardFettersType fettersType, AtkWayType atkWayType, int cardLevel)
		{
		}

		[Token(Token = "0x6002095")]
		[Address(RVA = "0x3F1142C", Offset = "0x3F0D42C", VA = "0x3F1142C", Slot = "6")]
		public override void ModifyArchitectureSpawnTime(ArchitecturePropertyTemp propertyTemp, bool isEnemy, RareLevel rareLevel, string architectureType)
		{
		}
	}
}
