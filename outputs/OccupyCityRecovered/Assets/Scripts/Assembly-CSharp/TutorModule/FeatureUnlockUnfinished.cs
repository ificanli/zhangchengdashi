using DataModule;
using Il2CppDummyDll;

namespace TutorModule
{
	[Token(Token = "0x2000206")]
	public class FeatureUnlockUnfinished : FeatureUnlockBase
	{
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x418B250", Offset = "0x4187250", VA = "0x418B250")]
		public FeatureUnlockUnfinished(GlobalFeatureUnlockInfo info, bool isUnlock) : base(info, false)
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x4190404", Offset = "0x418C404", VA = "0x4190404", Slot = "5")]
		public override void StartCheck()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x4190408", Offset = "0x418C408", VA = "0x4190408", Slot = "6")]
		public override void EndCheck()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x419040C", Offset = "0x418C40C", VA = "0x419040C", Slot = "7")]
		public override string UnlockTip()
		{
			return null;
		}
	}
}
