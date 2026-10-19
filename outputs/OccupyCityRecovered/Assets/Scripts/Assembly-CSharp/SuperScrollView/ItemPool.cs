using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace SuperScrollView
{
	[Token(Token = "0x2000C6D")]
	public class ItemPool
	{
		[Token(Token = "0x400590A")]
		[FieldOffset(Offset = "0x10")]
		private GameObject mPrefabObj;

		[Token(Token = "0x400590B")]
		[FieldOffset(Offset = "0x18")]
		private string mPrefabName;

		[Token(Token = "0x400590C")]
		[FieldOffset(Offset = "0x20")]
		private int mInitCreateCount;

		[Token(Token = "0x400590D")]
		[FieldOffset(Offset = "0x24")]
		private float mPadding;

		[Token(Token = "0x400590E")]
		[FieldOffset(Offset = "0x28")]
		private float mStartPosOffset;

		[Token(Token = "0x400590F")]
		[FieldOffset(Offset = "0x30")]
		private List<LoopListViewItem2> mTmpPooledItemList;

		[Token(Token = "0x4005910")]
		[FieldOffset(Offset = "0x38")]
		private List<LoopListViewItem2> mPooledItemList;

		[Token(Token = "0x4005911")]
		[FieldOffset(Offset = "0x0")]
		private static int mCurItemIdCount;

		[Token(Token = "0x4005912")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform mItemParent;

		[Token(Token = "0x6004D2D")]
		[Address(RVA = "0x427EE10", Offset = "0x427AE10", VA = "0x427EE10")]
		public ItemPool()
		{
		}

		[Token(Token = "0x6004D2E")]
		[Address(RVA = "0x427EEAC", Offset = "0x427AEAC", VA = "0x427EEAC")]
		public void Init(GameObject prefabObj, float padding, float startPosOffset, int createCount, RectTransform parent)
		{
		}

		[Token(Token = "0x6004D2F")]
		[Address(RVA = "0x427F268", Offset = "0x427B268", VA = "0x427F268")]
		public LoopListViewItem2 GetItem(int itemIndexForSearch)
		{
			return null;
		}

		[Token(Token = "0x6004D30")]
		[Address(RVA = "0x427F4A4", Offset = "0x427B4A4", VA = "0x427F4A4")]
		public LoopListViewItem2 GetItemFromTmpPool(int itemIndex)
		{
			return null;
		}

		[Token(Token = "0x6004D31")]
		[Address(RVA = "0x427F59C", Offset = "0x427B59C", VA = "0x427F59C")]
		public void DestroyAllItem()
		{
		}

		[Token(Token = "0x6004D32")]
		[Address(RVA = "0x427EF4C", Offset = "0x427AF4C", VA = "0x427EF4C")]
		public LoopListViewItem2 CreateItem()
		{
			return null;
		}

		[Token(Token = "0x6004D33")]
		[Address(RVA = "0x427F1A4", Offset = "0x427B1A4", VA = "0x427F1A4")]
		public void RecycleItemReal(LoopListViewItem2 item)
		{
		}

		[Token(Token = "0x6004D34")]
		[Address(RVA = "0x427F794", Offset = "0x427B794", VA = "0x427F794")]
		public void RecycleItem(LoopListViewItem2 item)
		{
		}

		[Token(Token = "0x6004D35")]
		[Address(RVA = "0x427F6BC", Offset = "0x427B6BC", VA = "0x427F6BC")]
		public void ClearTmpRecycledItem()
		{
		}
	}
}
