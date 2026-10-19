using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000625")]
	public class SubGameBuffTimeAccel : SubGameBuffBase
	{
		[Token(Token = "0x4003276")]
		private const float BattleTimeScale = 1.5f;

		[Token(Token = "0x6002096")]
		[Address(RVA = "0x3F114B0", Offset = "0x3F0D4B0", VA = "0x3F114B0")]
		public SubGameBuffTimeAccel() : base(1010)
		{
		}

		[Token(Token = "0x6002097")]
		[Address(RVA = "0x3F114BC", Offset = "0x3F0D4BC", VA = "0x3F114BC", Slot = "15")]
		public override void ModifyBattleTimeScale(ref float timeScale)
		{
		}
	}
}
