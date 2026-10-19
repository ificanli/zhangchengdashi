using DataModule;
using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000614")]
	public class SubGameBuffChaosLaw : SubGameBuffBase
	{
		[Token(Token = "0x400325D")]
		private const float MinAttackRatio = 0.5f;

		[Token(Token = "0x400325E")]
		private const float MaxAttackRatio = 1.5f;

		[Token(Token = "0x6002071")]
		[Address(RVA = "0x3F104C0", Offset = "0x3F0C4C0", VA = "0x3F104C0")]
		public SubGameBuffChaosLaw() : base(1004)
		{
		}

		[Token(Token = "0x6002072")]
		[Address(RVA = "0x3F104CC", Offset = "0x3F0C4CC", VA = "0x3F104CC", Slot = "4")]
		public override void ModifyRoleProperty(bool isEnemy, RolePropertyTemp propertyTemp, CardFettersType fettersType, AtkWayType atkWayType, int cardLevel)
		{
		}
	}
}
