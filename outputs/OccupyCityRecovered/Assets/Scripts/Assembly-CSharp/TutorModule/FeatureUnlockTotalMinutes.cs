using DataModule;
using Il2CppDummyDll;

namespace TutorModule
{
	[Token(Token = "0x2000205")]
	public class FeatureUnlockTotalMinutes : FeatureUnlockBase
	{
		[Token(Token = "0x4001CF2")]
		[FieldOffset(Offset = "0x20")]
		private readonly int _minuteNum;

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x418B030", Offset = "0x4187030", VA = "0x418B030")]
		public FeatureUnlockTotalMinutes(GlobalFeatureUnlockInfo info, bool isUnlock) : base(info, isUnlock)
		{
			throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FeatureUnlockTotalMinutes..ctor RVA=0x418B030 Token=0x06000861; original base constructor arguments recovered; remaining original constructor body pending.");
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x4190098", Offset = "0x418C098", VA = "0x4190098", Slot = "5")]
		public override void StartCheck()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x4190144", Offset = "0x418C144", VA = "0x4190144", Slot = "6")]
		public override void EndCheck()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x41901F0", Offset = "0x418C1F0", VA = "0x41901F0")]
		private void CheckUnlock(float inter)
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x4190320", Offset = "0x418C320", VA = "0x4190320", Slot = "7")]
		public override string UnlockTip()
		{
			return null;
		}
	}
}
