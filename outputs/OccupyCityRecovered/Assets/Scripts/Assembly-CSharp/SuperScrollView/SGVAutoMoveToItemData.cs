using Il2CppDummyDll;

namespace SuperScrollView
{
	[Token(Token = "0x2000C79")]
	public class SGVAutoMoveToItemData
	{
		[Token(Token = "0x400598D")]
		[FieldOffset(Offset = "0x10")]
		public int mTargetItemIndex;

		[Token(Token = "0x400598E")]
		[FieldOffset(Offset = "0x14")]
		public float mBeginPos;

		[Token(Token = "0x400598F")]
		[FieldOffset(Offset = "0x18")]
		public float mTargetPos;

		[Token(Token = "0x4005990")]
		[FieldOffset(Offset = "0x1C")]
		public float mStartMoveTime;

		[Token(Token = "0x4005991")]
		[FieldOffset(Offset = "0x20")]
		public float mDuration;

		[Token(Token = "0x6004DCD")]
		[Address(RVA = "0x429D45C", Offset = "0x429945C", VA = "0x429D45C")]
		public SGVAutoMoveToItemData()
		{
		}
	}
}
