using System.Collections.Generic;
using Il2CppDummyDll;

namespace SuperScrollView
{
	[Token(Token = "0x2000C63")]
	public class ItemPosMgr
	{
		[Token(Token = "0x40058A2")]
		public const int mItemMaxCountPerGroup = 100;

		[Token(Token = "0x40058A3")]
		[FieldOffset(Offset = "0x10")]
		private List<ItemSizeGroup> mItemSizeGroupList;

		[Token(Token = "0x40058A4")]
		[FieldOffset(Offset = "0x18")]
		private int mDirtyBeginIndex;

		[Token(Token = "0x40058A5")]
		[FieldOffset(Offset = "0x1C")]
		public float mTotalSize;

		[Token(Token = "0x40058A6")]
		[FieldOffset(Offset = "0x20")]
		public float mItemDefaultSize;

		[Token(Token = "0x40058A7")]
		[FieldOffset(Offset = "0x24")]
		private int mMaxNotEmptyGroupIndex;

		[Token(Token = "0x6004C8B")]
		[Address(RVA = "0x4278888", Offset = "0x4274888", VA = "0x4278888")]
		public ItemPosMgr(float itemDefaultSize)
		{
		}

		[Token(Token = "0x6004C8C")]
		[Address(RVA = "0x4278928", Offset = "0x4274928", VA = "0x4278928")]
		public void SetItemMaxCount(int maxCount)
		{
		}

		[Token(Token = "0x6004C8D")]
		[Address(RVA = "0x4278C10", Offset = "0x4274C10", VA = "0x4278C10")]
		public void SetItemSize(int itemIndex, float size)
		{
		}

		[Token(Token = "0x6004C8E")]
		[Address(RVA = "0x4278CE0", Offset = "0x4274CE0", VA = "0x4278CE0")]
		public float GetItemPos(int itemIndex)
		{
			return default;
		}

		[Token(Token = "0x6004C8F")]
		[Address(RVA = "0x4278E90", Offset = "0x4274E90", VA = "0x4278E90")]
		public bool GetItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
		{
			return default;
		}

		[Token(Token = "0x6004C90")]
		[Address(RVA = "0x4278D6C", Offset = "0x4274D6C", VA = "0x4278D6C")]
		public void Update(bool updateAll)
		{
		}
	}
}
