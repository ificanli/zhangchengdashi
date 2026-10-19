using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000623")]
	public class SubGameBuffRuleMaker : SubGameBuffBase
	{
		[Token(Token = "0x4003273")]
		private const int VictoryCoinThreshold = 3000;

		[Token(Token = "0x6002091")]
		[Address(RVA = "0x3F11244", Offset = "0x3F0D244", VA = "0x3F11244")]
		public SubGameBuffRuleMaker() : base(1005)
		{
		}

		[Token(Token = "0x6002092")]
		[Address(RVA = "0x3F11250", Offset = "0x3F0D250", VA = "0x3F11250", Slot = "12")]
		public override void OnCoinChanged(bool isEnemy, int coinAmount)
		{
		}
	}
}
