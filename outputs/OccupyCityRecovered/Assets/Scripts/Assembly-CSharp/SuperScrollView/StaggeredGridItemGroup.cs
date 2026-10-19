using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace SuperScrollView
{
	[Token(Token = "0x2000C7D")]
	public class StaggeredGridItemGroup
	{
		[Token(Token = "0x40059CC")]
		[FieldOffset(Offset = "0x10")]
		private LoopStaggeredGridView mParentGridView;

		[Token(Token = "0x40059CD")]
		[FieldOffset(Offset = "0x18")]
		private ListItemArrangeType mArrangeType;

		[Token(Token = "0x40059CE")]
		[FieldOffset(Offset = "0x20")]
		private List<LoopStaggeredGridViewItem> mItemList;

		[Token(Token = "0x40059CF")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform mContainerTrans;

		[Token(Token = "0x40059D0")]
		[FieldOffset(Offset = "0x30")]
		private ScrollRect mScrollRect;

		[Token(Token = "0x40059D1")]
		[FieldOffset(Offset = "0x38")]
		public int mGroupIndex;

		[Token(Token = "0x40059D2")]
		[FieldOffset(Offset = "0x40")]
		private GameObject mGameObject;

		[Token(Token = "0x40059D3")]
		[FieldOffset(Offset = "0x48")]
		private List<int> mItemIndexMap;

		[Token(Token = "0x40059D4")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform mScrollRectTransform;

		[Token(Token = "0x40059D5")]
		[FieldOffset(Offset = "0x58")]
		private RectTransform mViewPortRectTransform;

		[Token(Token = "0x40059D6")]
		[FieldOffset(Offset = "0x60")]
		private float mItemDefaultWithPaddingSize;

		[Token(Token = "0x40059D7")]
		[FieldOffset(Offset = "0x64")]
		private int mItemTotalCount;

		[Token(Token = "0x40059D8")]
		[FieldOffset(Offset = "0x68")]
		private bool mIsVertList;

		[Token(Token = "0x40059D9")]
		[FieldOffset(Offset = "0x70")]
		private Func<int, int, LoopStaggeredGridViewItem> mOnGetItemByIndex;

		[Token(Token = "0x40059DA")]
		[FieldOffset(Offset = "0x78")]
		private Vector3[] mItemWorldCorners;

		[Token(Token = "0x40059DB")]
		[FieldOffset(Offset = "0x80")]
		private Vector3[] mViewPortRectLocalCorners;

		[Token(Token = "0x40059DC")]
		[FieldOffset(Offset = "0x88")]
		private int mCurReadyMinItemIndex;

		[Token(Token = "0x40059DD")]
		[FieldOffset(Offset = "0x8C")]
		private int mCurReadyMaxItemIndex;

		[Token(Token = "0x40059DE")]
		[FieldOffset(Offset = "0x90")]
		private bool mNeedCheckNextMinItem;

		[Token(Token = "0x40059DF")]
		[FieldOffset(Offset = "0x91")]
		private bool mNeedCheckNextMaxItem;

		[Token(Token = "0x40059E0")]
		[FieldOffset(Offset = "0x98")]
		private ItemPosMgr mItemPosMgr;

		[Token(Token = "0x40059E1")]
		[FieldOffset(Offset = "0xA0")]
		private bool mSupportScrollBar;

		[Token(Token = "0x40059E2")]
		[FieldOffset(Offset = "0xA4")]
		private int mLastItemIndex;

		[Token(Token = "0x40059E3")]
		[FieldOffset(Offset = "0xA8")]
		private float mLastItemPadding;

		[Token(Token = "0x40059E4")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 mLastFrameContainerPos;

		[Token(Token = "0x40059E5")]
		[FieldOffset(Offset = "0xB8")]
		private int mListUpdateCheckFrameCount;

		[Token(Token = "0x17000DFF")]
		public List<int> ItemIndexMap
		{
			[Token(Token = "0x6004E38")]
			[Address(RVA = "0x42A2B94", Offset = "0x429EB94", VA = "0x42A2B94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E00")]
		public float ViewPortSize
		{
			[Token(Token = "0x6004E3B")]
			[Address(RVA = "0x42A2CB4", Offset = "0x429ECB4", VA = "0x42A2CB4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000E01")]
		public float ViewPortWidth
		{
			[Token(Token = "0x6004E3C")]
			[Address(RVA = "0x42A2CE4", Offset = "0x429ECE4", VA = "0x42A2CE4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000E02")]
		public float ViewPortHeight
		{
			[Token(Token = "0x6004E3D")]
			[Address(RVA = "0x42A2D08", Offset = "0x429ED08", VA = "0x42A2D08")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000E03")]
		private bool IsDraging
		{
			[Token(Token = "0x6004E3E")]
			[Address(RVA = "0x42A2D2C", Offset = "0x429ED2C", VA = "0x42A2D2C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000E04")]
		public int HadCreatedItemCount
		{
			[Token(Token = "0x6004E4E")]
			[Address(RVA = "0x42A3308", Offset = "0x429F308", VA = "0x42A3308")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004E37")]
		[Address(RVA = "0x429EB4C", Offset = "0x429AB4C", VA = "0x429EB4C")]
		public void Init(LoopStaggeredGridView parent, int itemTotalCount, int groupIndex, Func<int, int, LoopStaggeredGridViewItem> onGetItemByIndex)
		{
		}

		[Token(Token = "0x6004E39")]
		[Address(RVA = "0x42A2B9C", Offset = "0x429EB9C", VA = "0x42A2B9C")]
		public void ResetListView()
		{
		}

		[Token(Token = "0x6004E3A")]
		[Address(RVA = "0x42A2BC0", Offset = "0x429EBC0", VA = "0x42A2BC0")]
		public LoopStaggeredGridViewItem GetShownItemByItemIndex(int itemIndex)
		{
			return null;
		}

		[Token(Token = "0x6004E3F")]
		[Address(RVA = "0x42A03B8", Offset = "0x429C3B8", VA = "0x42A03B8")]
		public LoopStaggeredGridViewItem GetShownItemByIndexInGroup(int indexInGroup)
		{
			return null;
		}

		[Token(Token = "0x6004E40")]
		[Address(RVA = "0x42A2D48", Offset = "0x429ED48", VA = "0x42A2D48")]
		public int GetIndexInShownItemList(LoopStaggeredGridViewItem item)
		{
			return default;
		}

		[Token(Token = "0x6004E41")]
		[Address(RVA = "0x42A0540", Offset = "0x429C540", VA = "0x42A0540")]
		public void RefreshAllShownItem()
		{
		}

		[Token(Token = "0x6004E42")]
		[Address(RVA = "0x42A060C", Offset = "0x429C60C", VA = "0x42A060C")]
		public void OnItemSizeChanged(int indexInGroup)
		{
		}

		[Token(Token = "0x6004E43")]
		[Address(RVA = "0x42A072C", Offset = "0x429C72C", VA = "0x42A072C")]
		public void RefreshItemByIndexInGroup(int indexInGroup)
		{
		}

		[Token(Token = "0x6004E44")]
		[Address(RVA = "0x42A2E50", Offset = "0x429EE50", VA = "0x42A2E50")]
		public void RefreshAllShownItemWithFirstIndexInGroup(int firstItemIndexInGroup)
		{
		}

		[Token(Token = "0x6004E45")]
		[Address(RVA = "0x42A30C4", Offset = "0x429F0C4", VA = "0x42A30C4")]
		public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndexInGroup, Vector3 pos)
		{
		}

		[Token(Token = "0x6004E46")]
		[Address(RVA = "0x42A0D7C", Offset = "0x429CD7C", VA = "0x42A0D7C")]
		public void SetItemSize(int itemIndex, float itemSize, float padding)
		{
		}

		[Token(Token = "0x6004E47")]
		[Address(RVA = "0x42A3278", Offset = "0x429F278", VA = "0x42A3278")]
		private bool GetPlusItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
		{
			return default;
		}

		[Token(Token = "0x6004E48")]
		[Address(RVA = "0x42A1E40", Offset = "0x429DE40", VA = "0x42A1E40")]
		public float GetItemPos(int itemIndex)
		{
			return default;
		}

		[Token(Token = "0x6004E49")]
		[Address(RVA = "0x42A3294", Offset = "0x429F294", VA = "0x42A3294")]
		public Vector3 GetItemCornerPosInViewPort(LoopStaggeredGridViewItem item, ItemCornerEnum corner = ItemCornerEnum.LeftBottom)
		{
			return default;
		}

		[Token(Token = "0x6004E4A")]
		[Address(RVA = "0x42A3070", Offset = "0x429F070", VA = "0x42A3070")]
		public void RecycleItemTmp(LoopStaggeredGridViewItem item)
		{
		}

		[Token(Token = "0x6004E4B")]
		[Address(RVA = "0x42A0E5C", Offset = "0x429CE5C", VA = "0x42A0E5C")]
		public void RecycleAllItem()
		{
		}

		[Token(Token = "0x6004E4C")]
		[Address(RVA = "0x42A30AC", Offset = "0x429F0AC", VA = "0x42A30AC")]
		public void ClearAllTmpRecycledItem()
		{
		}

		[Token(Token = "0x6004E4D")]
		[Address(RVA = "0x42A3088", Offset = "0x429F088", VA = "0x42A3088")]
		private LoopStaggeredGridViewItem GetNewItemByIndexInGroup(int indexInGroup)
		{
			return null;
		}

		[Token(Token = "0x6004E4F")]
		[Address(RVA = "0x429F8CC", Offset = "0x429B8CC", VA = "0x429F8CC")]
		public void SetListItemCount(int itemCount)
		{
		}

		[Token(Token = "0x6004E50")]
		[Address(RVA = "0x42A3350", Offset = "0x429F350", VA = "0x42A3350")]
		private void UpdateItemIndexMap(int oldItemTotalCount)
		{
		}

		[Token(Token = "0x6004E51")]
		[Address(RVA = "0x42A2378", Offset = "0x429E378", VA = "0x42A2378")]
		public void UpdateListViewPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
		}

		[Token(Token = "0x6004E52")]
		[Address(RVA = "0x42A2500", Offset = "0x429E500", VA = "0x42A2500")]
		public bool UpdateListViewPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return default;
		}

		[Token(Token = "0x6004E53")]
		[Address(RVA = "0x42A34E4", Offset = "0x429F4E4", VA = "0x42A34E4")]
		public bool UpdateForVertListPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return default;
		}

		[Token(Token = "0x6004E54")]
		[Address(RVA = "0x42A4FD8", Offset = "0x42A0FD8", VA = "0x42A4FD8")]
		public bool UpdateForVertListPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return default;
		}

		[Token(Token = "0x6004E55")]
		[Address(RVA = "0x42A4248", Offset = "0x42A0248", VA = "0x42A4248")]
		public bool UpdateForHorizontalListPart1(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return default;
		}

		[Token(Token = "0x6004E56")]
		[Address(RVA = "0x42A5734", Offset = "0x42A1734", VA = "0x42A5734")]
		public bool UpdateForHorizontalListPart2(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
			return default;
		}

		[Token(Token = "0x6004E57")]
		[Address(RVA = "0x42A2510", Offset = "0x429E510", VA = "0x42A2510")]
		public float GetContentPanelSize()
		{
			return default;
		}

		[Token(Token = "0x6004E58")]
		[Address(RVA = "0x42A0D58", Offset = "0x429CD58", VA = "0x42A0D58")]
		public float GetContentPanelSizeWithLastItemPadding()
		{
			return default;
		}

		[Token(Token = "0x6004E59")]
		[Address(RVA = "0x42A2248", Offset = "0x429E248", VA = "0x42A2248")]
		public float GetShownItemPosMaxValue()
		{
			return default;
		}

		[Token(Token = "0x6004E5A")]
		[Address(RVA = "0x42A1A80", Offset = "0x429DA80", VA = "0x42A1A80")]
		public void CheckIfNeedUpdateItemPos()
		{
		}

		[Token(Token = "0x6004E5B")]
		[Address(RVA = "0x42A16F8", Offset = "0x429D6F8", VA = "0x42A16F8")]
		public void UpdateAllShownItemsPos()
		{
		}

		[Token(Token = "0x6004E5C")]
		[Address(RVA = "0x429EA08", Offset = "0x429AA08", VA = "0x429EA08")]
		public StaggeredGridItemGroup()
		{
		}
	}
}
