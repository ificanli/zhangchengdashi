using DataModule;
using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x200061D")]
	public class SubGameBuffGoldenPie : SubGameBuffBase
	{
		[Token(Token = "0x4003269")]
		private const float AttackPercentPerCoin = 0.001f;

		[Token(Token = "0x6002084")]
		[Address(RVA = "0x3F10D00", Offset = "0x3F0CD00", VA = "0x3F10D00")]
		public SubGameBuffGoldenPie() : base(1013)
		{
		}

		[Token(Token = "0x6002085")]
		[Address(RVA = "0x3F10D0C", Offset = "0x3F0CD0C", VA = "0x3F10D0C", Slot = "4")]
		public override void ModifyRoleProperty(bool isEnemy, RolePropertyTemp propertyTemp, CardFettersType fettersType, AtkWayType atkWayType, int cardLevel)
		{
		}
	}
}
