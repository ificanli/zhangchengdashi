using DataModule;
using Il2CppDummyDll;

namespace TutorModule
{
	[Token(Token = "0x2000204")]
	public class FeatureUnlockTotalDays : FeatureUnlockBase
	{
		[Token(Token = "0x4001CF1")]
		[FieldOffset(Offset = "0x20")]
		private readonly int _dayNum;

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x418AFE4", Offset = "0x4186FE4", VA = "0x418AFE4")]
		public FeatureUnlockTotalDays(GlobalFeatureUnlockInfo info, bool isUnlock) : base(info, isUnlock)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FeatureUnlockTotalDays..ctor RVA=0x418AFE4 Token=0x0600085C; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x418FDC0", Offset = "0x418BDC0", VA = "0x418FDC0", Slot = "5")]
		public override void StartCheck()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x418FE70", Offset = "0x418BE70", VA = "0x418FE70")]
		private void CheckUnlock()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x418FF04", Offset = "0x418BF04", VA = "0x418FF04", Slot = "6")]
		public override void EndCheck()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x418FFB4", Offset = "0x418BFB4", VA = "0x418FFB4", Slot = "7")]
		public override string UnlockTip()
		{
			return null;
		}
	}
}
