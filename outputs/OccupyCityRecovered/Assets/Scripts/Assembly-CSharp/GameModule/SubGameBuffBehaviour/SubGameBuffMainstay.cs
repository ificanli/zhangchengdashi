using DataModule;
using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000621")]
	public class SubGameBuffMainstay : SubGameBuffBase
	{
		[Token(Token = "0x4003270")]
		private const float AttackSpeedIncreaseRatio = 0.5f;

		[Token(Token = "0x4003271")]
		private const float HpReduceRatio = 0.2f;

		[Token(Token = "0x600208E")]
		[Address(RVA = "0x3F11100", Offset = "0x3F0D100", VA = "0x3F11100")]
		public SubGameBuffMainstay() : base(1018)
		{
		}

		[Token(Token = "0x600208F")]
		[Address(RVA = "0x3F1110C", Offset = "0x3F0D10C", VA = "0x3F1110C", Slot = "4")]
		public override void ModifyRoleProperty(bool isEnemy, RolePropertyTemp propertyTemp, CardFettersType fettersType, AtkWayType atkWayType, int cardLevel)
		{
		}
	}
}
