using Il2CppDummyDll;

namespace SuperScrollView
{
	[Token(Token = "0x2000C7A")]
	public class GridViewLayoutParam
	{
		[Token(Token = "0x4005992")]
		[FieldOffset(Offset = "0x10")]
		public int mColumnOrRowCount;

		[Token(Token = "0x4005993")]
		[FieldOffset(Offset = "0x14")]
		public float mItemWidthOrHeight;

		[Token(Token = "0x4005994")]
		[FieldOffset(Offset = "0x18")]
		public float mPadding1;

		[Token(Token = "0x4005995")]
		[FieldOffset(Offset = "0x1C")]
		public float mPadding2;

		[Token(Token = "0x4005996")]
		[FieldOffset(Offset = "0x20")]
		public float[] mCustomColumnOrRowOffsetArray;

		[Token(Token = "0x6004DCE")]
		[Address(RVA = "0x429D464", Offset = "0x4299464", VA = "0x429D464")]
		public bool CheckParam()
		{
			return default;
		}

		[Token(Token = "0x6004DCF")]
		[Address(RVA = "0x429D530", Offset = "0x4299530", VA = "0x429D530")]
		public GridViewLayoutParam()
		{
		}
	}
}
