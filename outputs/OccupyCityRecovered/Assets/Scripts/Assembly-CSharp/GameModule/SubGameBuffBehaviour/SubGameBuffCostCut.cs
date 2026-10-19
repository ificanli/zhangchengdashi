using DataModule;
using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000615")]
	public class SubGameBuffCostCut : SubGameBuffBase
	{
		[Token(Token = "0x400325F")]
		private const float SpawnSpeedIncreaseRatio = 0.5f;

		[Token(Token = "0x4003260")]
		private const float HpReduceRatio = 0.25f;

		[Token(Token = "0x6002073")]
		[Address(RVA = "0x3F105DC", Offset = "0x3F0C5DC", VA = "0x3F105DC")]
		public SubGameBuffCostCut() : base(1009)
		{
		}

		[Token(Token = "0x6002074")]
		[Address(RVA = "0x3F105E8", Offset = "0x3F0C5E8", VA = "0x3F105E8", Slot = "4")]
		public override void ModifyRoleProperty(bool isEnemy, RolePropertyTemp propertyTemp, CardFettersType fettersType, AtkWayType atkWayType, int cardLevel)
		{
		}

		[Token(Token = "0x6002075")]
		[Address(RVA = "0x3F106E8", Offset = "0x3F0C6E8", VA = "0x3F106E8", Slot = "6")]
		public override void ModifyArchitectureSpawnTime(ArchitecturePropertyTemp propertyTemp, bool isEnemy, RareLevel rareLevel, string architectureType)
		{
		}
	}
}
