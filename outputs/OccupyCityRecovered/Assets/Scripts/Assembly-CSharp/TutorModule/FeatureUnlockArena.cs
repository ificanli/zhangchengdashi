using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;

namespace TutorModule
{
	[Token(Token = "0x2000201")]
	public class FeatureUnlockArena : FeatureUnlockBase
	{
		[Token(Token = "0x4001CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly int _arena;

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x418B07C", Offset = "0x418707C", VA = "0x418B07C")]
		public FeatureUnlockArena(GlobalFeatureUnlockInfo info, bool isUnlock) : base(info, isUnlock)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FeatureUnlockArena..ctor RVA=0x418B07C Token=0x0600083B; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x418E728", Offset = "0x418A728", VA = "0x418E728", Slot = "5")]
		public override void StartCheck()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x418E880", Offset = "0x418A880", VA = "0x418E880", Slot = "6")]
		public override void EndCheck()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x418E948", Offset = "0x418A948", VA = "0x418E948", Slot = "7")]
		public override string UnlockTip()
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x418E80C", Offset = "0x418A80C", VA = "0x418E80C")]
		private void CheckUnlock([Optional] object obj)
		{
		}
	}
}
