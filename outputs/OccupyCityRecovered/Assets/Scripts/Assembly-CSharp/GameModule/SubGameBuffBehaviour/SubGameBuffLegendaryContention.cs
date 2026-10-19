using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000620")]
	public class SubGameBuffLegendaryContention : SubGameBuffBase
	{
		[Token(Token = "0x400326F")]
		private const int GoldCardOddMultiplier = 5;

		[Token(Token = "0x600208C")]
		[Address(RVA = "0x3F110E4", Offset = "0x3F0D0E4", VA = "0x3F110E4")]
		public SubGameBuffLegendaryContention() : base(1003)
		{
		}

		[Token(Token = "0x600208D")]
		[Address(RVA = "0x3F110F0", Offset = "0x3F0D0F0", VA = "0x3F110F0", Slot = "5")]
		public override int GetGoldCardOddBonus(int baseSssrWeight, bool isEnemyHex)
		{
			return default;
		}
	}
}
