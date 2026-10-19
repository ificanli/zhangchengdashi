using DataModule;
using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x200061E")]
	public class SubGameBuffGrassroots : SubGameBuffBase
	{
		[Token(Token = "0x400326A")]
		private const float SpawnSpeedIncreaseRatio = 0.5f;

		[Token(Token = "0x400326B")]
		private const float HpReduceRatio = 0.3f;

		[Token(Token = "0x400326C")]
		private const float MoveSpeedIncreaseRatio = 0.3f;

		[Token(Token = "0x6002086")]
		[Address(RVA = "0x3F10E94", Offset = "0x3F0CE94", VA = "0x3F10E94")]
		public SubGameBuffGrassroots() : base(1017)
		{
		}

		[Token(Token = "0x6002087")]
		[Address(RVA = "0x3F10EA0", Offset = "0x3F0CEA0", VA = "0x3F10EA0", Slot = "4")]
		public override void ModifyRoleProperty(bool isEnemy, RolePropertyTemp propertyTemp, CardFettersType fettersType, AtkWayType atkWayType, int cardLevel)
		{
		}

		[Token(Token = "0x6002088")]
		[Address(RVA = "0x3F10FC0", Offset = "0x3F0CFC0", VA = "0x3F10FC0", Slot = "6")]
		public override void ModifyArchitectureSpawnTime(ArchitecturePropertyTemp propertyTemp, bool isEnemy, RareLevel rareLevel, string architectureType)
		{
		}
	}
}
