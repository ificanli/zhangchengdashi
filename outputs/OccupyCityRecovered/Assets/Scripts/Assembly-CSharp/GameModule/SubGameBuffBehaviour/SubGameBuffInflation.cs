using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x200061F")]
	public class SubGameBuffInflation : SubGameBuffBase
	{
		[Token(Token = "0x400326D")]
		public const int PriceIncreasePerOpen = 5;

		[Token(Token = "0x400326E")]
		private const int KillCoinIncreasePerOpen = 1;

		[Token(Token = "0x6002089")]
		[Address(RVA = "0x3F1103C", Offset = "0x3F0D03C", VA = "0x3F1103C")]
		public SubGameBuffInflation() : base(1008)
		{
		}

		[Token(Token = "0x600208A")]
		[Address(RVA = "0x3F11048", Offset = "0x3F0D048", VA = "0x3F11048", Slot = "11")]
		public override void ModifyHexOpenPrice(ref int price, bool isEnemyHex)
		{
		}

		[Token(Token = "0x600208B")]
		[Address(RVA = "0x3F11098", Offset = "0x3F0D098", VA = "0x3F11098", Slot = "8")]
		public override void ModifyKillCoin(ref int coin, bool killedUnitIsEnemy)
		{
		}
	}
}
