using Il2CppDummyDll;

namespace SuperScrollView
{
	[Token(Token = "0x2000C71")]
	public class ListViewAutoMoveToItemData
	{
		[Token(Token = "0x4005922")]
		[FieldOffset(Offset = "0x10")]
		public float mStartFloatItemIndex;

		[Token(Token = "0x4005923")]
		[FieldOffset(Offset = "0x14")]
		public int mTargetItemIndex;

		[Token(Token = "0x4005924")]
		[FieldOffset(Offset = "0x18")]
		public float mTargetItemOffset;

		[Token(Token = "0x4005925")]
		[FieldOffset(Offset = "0x1C")]
		public float mStartMoveTime;

		[Token(Token = "0x4005926")]
		[FieldOffset(Offset = "0x20")]
		public float mStartPreciseMoveTime;

		[Token(Token = "0x4005927")]
		[FieldOffset(Offset = "0x24")]
		public float mDuration;

		[Token(Token = "0x4005928")]
		[FieldOffset(Offset = "0x28")]
		public float mPreciseMoveDuration;

		[Token(Token = "0x4005929")]
		[FieldOffset(Offset = "0x2C")]
		public float mPreciseMoveSpeed;

		[Token(Token = "0x400592A")]
		[FieldOffset(Offset = "0x30")]
		public float mPreciseMoveLeftDistance;

		[Token(Token = "0x400592B")]
		[FieldOffset(Offset = "0x34")]
		public bool mIsInPreciseMove;

		[Token(Token = "0x6004D39")]
		[Address(RVA = "0x427F8D4", Offset = "0x427B8D4", VA = "0x427F8D4")]
		public ListViewAutoMoveToItemData()
		{
		}
	}
}
