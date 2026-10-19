using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace SuperScrollView
{
	[Token(Token = "0x2000C7E")]
	public class StaggeredGridItemPool
	{
		[Token(Token = "0x40059E6")]
		[FieldOffset(Offset = "0x10")]
		private GameObject mPrefabObj;

		[Token(Token = "0x40059E7")]
		[FieldOffset(Offset = "0x18")]
		private string mPrefabName;

		[Token(Token = "0x40059E8")]
		[FieldOffset(Offset = "0x20")]
		private int mInitCreateCount;

		[Token(Token = "0x40059E9")]
		[FieldOffset(Offset = "0x24")]
		private float mPadding;

		[Token(Token = "0x40059EA")]
		[FieldOffset(Offset = "0x28")]
		private List<LoopStaggeredGridViewItem> mTmpPooledItemList;

		[Token(Token = "0x40059EB")]
		[FieldOffset(Offset = "0x30")]
		private List<LoopStaggeredGridViewItem> mPooledItemList;

		[Token(Token = "0x40059EC")]
		[FieldOffset(Offset = "0x0")]
		private static int mCurItemIdCount;

		[Token(Token = "0x40059ED")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform mItemParent;

		[Token(Token = "0x6004E5D")]
		[Address(RVA = "0x42A12F4", Offset = "0x429D2F4", VA = "0x42A12F4")]
		public StaggeredGridItemPool()
		{
		}

		[Token(Token = "0x6004E5E")]
		[Address(RVA = "0x42A1390", Offset = "0x429D390", VA = "0x42A1390")]
		public void Init(GameObject prefabObj, float padding, int createCount, RectTransform parent)
		{
		}

		[Token(Token = "0x6004E5F")]
		[Address(RVA = "0x429F680", Offset = "0x429B680", VA = "0x429F680")]
		public LoopStaggeredGridViewItem GetItem(int itemIndexForSearch)
		{
			return null;
		}

		[Token(Token = "0x6004E60")]
		[Address(RVA = "0x42A61B8", Offset = "0x42A21B8", VA = "0x42A61B8")]
		public void DestroyAllItem()
		{
		}

		[Token(Token = "0x6004E61")]
		[Address(RVA = "0x42A5EA0", Offset = "0x42A1EA0", VA = "0x42A5EA0")]
		public LoopStaggeredGridViewItem CreateItem()
		{
			return null;
		}

		[Token(Token = "0x6004E62")]
		[Address(RVA = "0x42A60F4", Offset = "0x42A20F4", VA = "0x42A60F4")]
		private void RecycleItemReal(LoopStaggeredGridViewItem item)
		{
		}

		[Token(Token = "0x6004E63")]
		[Address(RVA = "0x42A10AC", Offset = "0x429D0AC", VA = "0x42A10AC")]
		public void RecycleItem(LoopStaggeredGridViewItem item)
		{
		}

		[Token(Token = "0x6004E64")]
		[Address(RVA = "0x42A1150", Offset = "0x429D150", VA = "0x42A1150")]
		public void ClearTmpRecycledItem()
		{
		}
	}
}
