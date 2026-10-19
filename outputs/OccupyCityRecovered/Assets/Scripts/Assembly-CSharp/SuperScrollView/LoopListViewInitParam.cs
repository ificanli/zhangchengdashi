using Il2CppDummyDll;

namespace SuperScrollView
{
	[Token(Token = "0x2000C6F")]
	public class LoopListViewInitParam
	{
		[Token(Token = "0x4005917")]
		[FieldOffset(Offset = "0x10")]
		public float mDistanceForRecycle0;

		[Token(Token = "0x4005918")]
		[FieldOffset(Offset = "0x14")]
		public float mDistanceForNew0;

		[Token(Token = "0x4005919")]
		[FieldOffset(Offset = "0x18")]
		public float mDistanceForRecycle1;

		[Token(Token = "0x400591A")]
		[FieldOffset(Offset = "0x1C")]
		public float mDistanceForNew1;

		[Token(Token = "0x400591B")]
		[FieldOffset(Offset = "0x20")]
		public float mSmoothDumpRate;

		[Token(Token = "0x400591C")]
		[FieldOffset(Offset = "0x24")]
		public float mSnapFinishThreshold;

		[Token(Token = "0x400591D")]
		[FieldOffset(Offset = "0x28")]
		public float mSnapVecThreshold;

		[Token(Token = "0x400591E")]
		[FieldOffset(Offset = "0x2C")]
		public float mItemDefaultWithPaddingSize;

		[Token(Token = "0x400591F")]
		[FieldOffset(Offset = "0x30")]
		public bool mNeedReplaceScrollbarEventHandler;

		[Token(Token = "0x6004D37")]
		[Address(RVA = "0x427F840", Offset = "0x427B840", VA = "0x427F840")]
		public static LoopListViewInitParam CopyDefaultInitParam()
		{
			return null;
		}

		[Token(Token = "0x6004D38")]
		[Address(RVA = "0x427F8B0", Offset = "0x427B8B0", VA = "0x427F8B0")]
		public LoopListViewInitParam()
		{
		}
	}
}
