using System.Runtime.InteropServices;
using DataModule;
using Il2CppDummyDll;

namespace TutorModule
{
	[Token(Token = "0x2000207")]
	public class FeatureWeeklyUnlock : FeatureUnlockBase
	{
		[Token(Token = "0x4001CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly int _day;

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x418B0C8", Offset = "0x41870C8", VA = "0x418B0C8")]
		public FeatureWeeklyUnlock(GlobalFeatureUnlockInfo info, bool isUnlock) : base(info, isUnlock)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FeatureWeeklyUnlock..ctor RVA=0x418B0C8 Token=0x0600086A; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x41904BC", Offset = "0x418C4BC", VA = "0x41904BC", Slot = "5")]
		public override void StartCheck()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x4190414", Offset = "0x418C414", VA = "0x4190414")]
		private bool GetIsUnlock()
		{
			return default;
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x41905B4", Offset = "0x418C5B4", VA = "0x41905B4", Slot = "6")]
		public override void EndCheck()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x41905B8", Offset = "0x418C5B8", VA = "0x41905B8", Slot = "7")]
		public override string UnlockTip()
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x4190590", Offset = "0x418C590", VA = "0x4190590")]
		private void CheckUnlock([Optional] object obj)
		{
		}
	}
}
