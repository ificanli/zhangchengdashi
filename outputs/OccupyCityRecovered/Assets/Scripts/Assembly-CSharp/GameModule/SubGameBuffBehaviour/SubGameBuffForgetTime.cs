using Il2CppDummyDll;

namespace GameModule.SubGameBuffBehaviour
{
	[Token(Token = "0x2000619")]
	public class SubGameBuffForgetTime : SubGameBuffBase
	{
		[Token(Token = "0x4003263")]
		private const int CountDownMultiplier = 3;

		[Token(Token = "0x600207C")]
		[Address(RVA = "0x3F109A4", Offset = "0x3F0C9A4", VA = "0x3F109A4")]
		public SubGameBuffForgetTime() : base(1006)
		{
		}

		[Token(Token = "0x600207D")]
		[Address(RVA = "0x3F109B0", Offset = "0x3F0C9B0", VA = "0x3F109B0", Slot = "14")]
		public override void ModifyCountDownTime(ref int countDownTime)
		{
		}
	}
}
