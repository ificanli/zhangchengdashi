using Il2CppDummyDll;

namespace SuperScrollView
{
	[Token(Token = "0x2000C62")]
	public class ItemSizeGroup
	{
		[Token(Token = "0x4005898")]
		[FieldOffset(Offset = "0x10")]
		public float[] mItemSizeArray;

		[Token(Token = "0x4005899")]
		[FieldOffset(Offset = "0x18")]
		public float[] mItemStartPosArray;

		[Token(Token = "0x400589A")]
		[FieldOffset(Offset = "0x20")]
		public int mItemCount;

		[Token(Token = "0x400589B")]
		[FieldOffset(Offset = "0x24")]
		private int mDirtyBeginIndex;

		[Token(Token = "0x400589C")]
		[FieldOffset(Offset = "0x28")]
		public float mGroupSize;

		[Token(Token = "0x400589D")]
		[FieldOffset(Offset = "0x2C")]
		public float mGroupStartPos;

		[Token(Token = "0x400589E")]
		[FieldOffset(Offset = "0x30")]
		public float mGroupEndPos;

		[Token(Token = "0x400589F")]
		[FieldOffset(Offset = "0x34")]
		public int mGroupIndex;

		[Token(Token = "0x40058A0")]
		[FieldOffset(Offset = "0x38")]
		private float mItemDefaultSize;

		[Token(Token = "0x40058A1")]
		[FieldOffset(Offset = "0x3C")]
		private int mMaxNoZeroIndex;

		[Token(Token = "0x17000D90")]
		public bool IsDirty
		{
			[Token(Token = "0x6004C84")]
			[Address(RVA = "0x42785B4", Offset = "0x42745B4", VA = "0x42785B4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004C81")]
		[Address(RVA = "0x4278448", Offset = "0x4274448", VA = "0x4278448")]
		public ItemSizeGroup(int index, float itemDefaultSize)
		{
		}

		[Token(Token = "0x6004C82")]
		[Address(RVA = "0x427848C", Offset = "0x427448C", VA = "0x427848C")]
		public void Init()
		{
		}

		[Token(Token = "0x6004C83")]
		[Address(RVA = "0x427857C", Offset = "0x427457C", VA = "0x427857C")]
		public float GetItemStartPos(int index)
		{
			return default;
		}

		[Token(Token = "0x6004C85")]
		[Address(RVA = "0x42785C4", Offset = "0x42745C4", VA = "0x42785C4")]
		public float SetItemSize(int index, float size)
		{
			return default;
		}

		[Token(Token = "0x6004C86")]
		[Address(RVA = "0x4278640", Offset = "0x4274640", VA = "0x4278640")]
		public void SetItemCount(int count)
		{
		}

		[Token(Token = "0x6004C87")]
		[Address(RVA = "0x4278668", Offset = "0x4274668", VA = "0x4278668")]
		public void RecalcGroupSize()
		{
		}

		[Token(Token = "0x6004C88")]
		[Address(RVA = "0x42786C4", Offset = "0x42746C4", VA = "0x42786C4")]
		public int GetItemIndexByPos(float pos)
		{
			return default;
		}

		[Token(Token = "0x6004C89")]
		[Address(RVA = "0x42787A0", Offset = "0x42747A0", VA = "0x42787A0")]
		public void UpdateAllItemStartPos()
		{
		}

		[Token(Token = "0x6004C8A")]
		[Address(RVA = "0x4278838", Offset = "0x4274838", VA = "0x4278838")]
		public void ClearOldData()
		{
		}
	}
}
