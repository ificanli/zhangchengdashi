using Il2CppDummyDll;

namespace SuperScrollView
{
	[Token(Token = "0x2000C67")]
	public class LoopGridViewInitParam
	{
		[Token(Token = "0x40058B5")]
		[FieldOffset(Offset = "0x10")]
		public float mSmoothDumpRate;

		[Token(Token = "0x40058B6")]
		[FieldOffset(Offset = "0x14")]
		public float mSnapFinishThreshold;

		[Token(Token = "0x40058B7")]
		[FieldOffset(Offset = "0x18")]
		public float mSnapVecThreshold;

		[Token(Token = "0x6004CA8")]
		[Address(RVA = "0x4279FA4", Offset = "0x4275FA4", VA = "0x4279FA4")]
		public static LoopGridViewInitParam CopyDefaultInitParam()
		{
			return null;
		}

		[Token(Token = "0x6004CA9")]
		[Address(RVA = "0x427A00C", Offset = "0x427600C", VA = "0x427A00C")]
		public LoopGridViewInitParam()
		{
		}
	}
}
