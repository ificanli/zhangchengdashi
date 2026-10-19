using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace SuperScrollView
{
	[Token(Token = "0x2000C65")]
	public class GridItemPool
	{
		[Token(Token = "0x40058AC")]
		[FieldOffset(Offset = "0x10")]
		private GameObject mPrefabObj;

		[Token(Token = "0x40058AD")]
		[FieldOffset(Offset = "0x18")]
		private string mPrefabName;

		[Token(Token = "0x40058AE")]
		[FieldOffset(Offset = "0x20")]
		private int mInitCreateCount;

		[Token(Token = "0x40058AF")]
		[FieldOffset(Offset = "0x28")]
		private List<LoopGridViewItem> mTmpPooledItemList;

		[Token(Token = "0x40058B0")]
		[FieldOffset(Offset = "0x30")]
		private List<LoopGridViewItem> mPooledItemList;

		[Token(Token = "0x40058B1")]
		[FieldOffset(Offset = "0x0")]
		private static int mCurItemIdCount;

		[Token(Token = "0x40058B2")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform mItemParent;

		[Token(Token = "0x6004C9F")]
		[Address(RVA = "0x4279674", Offset = "0x4275674", VA = "0x4279674")]
		public GridItemPool()
		{
		}

		[Token(Token = "0x6004CA0")]
		[Address(RVA = "0x4279710", Offset = "0x4275710", VA = "0x4279710")]
		public void Init(GameObject prefabObj, int createCount, RectTransform parent)
		{
		}

		[Token(Token = "0x6004CA1")]
		[Address(RVA = "0x4279AB4", Offset = "0x4275AB4", VA = "0x4279AB4")]
		public LoopGridViewItem GetItem(int itemIndexForSearch)
		{
			return null;
		}

		[Token(Token = "0x6004CA2")]
		[Address(RVA = "0x4279CF8", Offset = "0x4275CF8", VA = "0x4279CF8")]
		public void DestroyAllItem()
		{
		}

		[Token(Token = "0x6004CA3")]
		[Address(RVA = "0x42797A0", Offset = "0x42757A0", VA = "0x42797A0")]
		public LoopGridViewItem CreateItem()
		{
			return null;
		}

		[Token(Token = "0x6004CA4")]
		[Address(RVA = "0x42799F0", Offset = "0x42759F0", VA = "0x42799F0")]
		private void RecycleItemReal(LoopGridViewItem item)
		{
		}

		[Token(Token = "0x6004CA5")]
		[Address(RVA = "0x4279EF0", Offset = "0x4275EF0", VA = "0x4279EF0")]
		public void RecycleItem(LoopGridViewItem item)
		{
		}

		[Token(Token = "0x6004CA6")]
		[Address(RVA = "0x4279E18", Offset = "0x4275E18", VA = "0x4279E18")]
		public void ClearTmpRecycledItem()
		{
		}
	}
}
