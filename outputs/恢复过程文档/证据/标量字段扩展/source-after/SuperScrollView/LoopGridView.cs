using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SuperScrollView
{
	[Token(Token = "0x2000C69")]
	public class LoopGridView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x2000C6A")]
		private class SnapData
		{
			[Token(Token = "0x40058EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SnapStatus mSnapStatus;

			[Token(Token = "0x40058F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public RowColumnPair mSnapTarget;

			[Token(Token = "0x40058F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector2 mSnapNeedMoveDir;

			[Token(Token = "0x40058F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float mTargetSnapVal;

			[Token(Token = "0x40058F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float mCurSnapVal;

			[Token(Token = "0x40058F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool mIsForceSnapTo;

			[Token(Token = "0x6004D0A")]
			[Address(RVA = "0x427AA38", Offset = "0x4276A38", VA = "0x427AA38")]
			public void Clear()
			{
			}

			[Token(Token = "0x6004D0B")]
			[Address(RVA = "0x427ECFC", Offset = "0x427ACFC", VA = "0x427ECFC")]
			public SnapData()
			{
			}
		}

		[Token(Token = "0x2000C6B")]
		private class ItemRangeData
		{
			[Token(Token = "0x40058F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int mMaxRow;

			[Token(Token = "0x40058F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int mMinRow;

			[Token(Token = "0x40058F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int mMaxColumn;

			[Token(Token = "0x40058F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int mMinColumn;

			[Token(Token = "0x40058F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector2 mCheckedPosition;

			[Token(Token = "0x6004D0C")]
			[Address(RVA = "0x427ED04", Offset = "0x427AD04", VA = "0x427ED04")]
			public ItemRangeData()
			{
			}
		}

		[Token(Token = "0x40058BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, GridItemPool> mItemPoolDict;

		[Token(Token = "0x40058BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<GridItemPool> mItemPoolList;

		[Token(Token = "0x40058BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GridViewItemPrefabConfData> mItemPrefabDataList;

		[Token(Token = "0x40058C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GridItemArrangeType mArrangeType;

		[Token(Token = "0x40058C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform mContainerTrans;

		[Token(Token = "0x40058C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ScrollRect mScrollRect;

		[Token(Token = "0x40058C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform mScrollRectTransform;

		[Token(Token = "0x40058C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform mViewPortRectTransform;

		[Token(Token = "0x40058C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int mItemTotalCount;

		[Token(Token = "0x40058C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int mFixedRowOrColumnCount;

		[Token(Token = "0x40058C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectOffset mPadding;

		[Token(Token = "0x40058C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector2 mItemPadding;

		[Token(Token = "0x40058C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2 mItemSize;

		[Token(Token = "0x40058CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector2 mItemRecycleDistance;

		[Token(Token = "0x40058CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector2 mItemSizeWithPadding;

		[Token(Token = "0x40058CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2 mStartPadding;

		[Token(Token = "0x40058CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 mEndPadding;

		[Token(Token = "0x40058CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Func<LoopGridView, int, int, int, LoopGridViewItem> mOnGetItemByRowColumn;

		[Token(Token = "0x40058CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<GridItemGroup> mItemGroupObjPool;

		[Token(Token = "0x40058D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<GridItemGroup> mItemGroupList;

		[Token(Token = "0x40058D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool mIsDraging;

		[Token(Token = "0x40058D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int mRowCount;

		[Token(Token = "0x40058D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int mColumnCount;

		[Token(Token = "0x40058D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Action<PointerEventData> mOnBeginDragAction;

		[Token(Token = "0x40058D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Action<PointerEventData> mOnDragingAction;

		[Token(Token = "0x40058D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Action<PointerEventData> mOnEndDragAction;

		[Token(Token = "0x40058D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float mSmoothDumpVel;

		[Token(Token = "0x40058D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float mSmoothDumpRate;

		[Token(Token = "0x40058D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float mSnapFinishThreshold;

		[Token(Token = "0x40058DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float mSnapVecThreshold;

		[Token(Token = "0x40058DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool mItemSnapEnable;

		[Token(Token = "0x40058DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private GridFixedType mGridFixedType;

		[Token(Token = "0x40058DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Action<LoopGridView, LoopGridViewItem> mOnSnapItemFinished;

		[Token(Token = "0x40058DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Action<LoopGridView> mOnSnapNearestChanged;

		[Token(Token = "0x40058DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int mLeftSnapUpdateExtraCount;

		[Token(Token = "0x40058E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private Vector2 mViewPortSnapPivot;

		[Token(Token = "0x40058E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		private Vector2 mItemSnapPivot;

		[Token(Token = "0x40058E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private SnapData mCurSnapData;

		[Token(Token = "0x40058E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 mLastSnapCheckPos;

		[Token(Token = "0x40058E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private bool mListViewInited;

		[Token(Token = "0x40058E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int mListUpdateCheckFrameCount;

		[Token(Token = "0x40058E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private ItemRangeData mCurFrameItemRangeData;

		[Token(Token = "0x40058E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private int mNeedCheckContentPosLeftCount;

		[Token(Token = "0x40058E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private ClickEventListener mScrollBarClickEventListener1;

		[Token(Token = "0x40058E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private ClickEventListener mScrollBarClickEventListener2;

		[Token(Token = "0x40058EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private RowColumnPair mCurSnapNearestItemRowColumn;

		[Token(Token = "0x40058EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool mIsPointerDownInVerticalScrollBar;

		[Token(Token = "0x40058EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool mIsPointerDownInHorizontalScrollBar;

		[Token(Token = "0x40058ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A")]
		private bool mNeedReplaceScrollbarEventHandler;

		[Token(Token = "0x40058EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int mCurCreatingItemIndex;

		[Token(Token = "0x17000D95")]
		public GridItemArrangeType ArrangeType
		{
			[Token(Token = "0x6004CAB")]
			[Address(RVA = "0x427A030", Offset = "0x4276030", VA = "0x427A030")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004CAC")]
			[Address(RVA = "0x427A038", Offset = "0x4276038", VA = "0x427A038")]
			set
			{
			}
		}

		[Token(Token = "0x17000D96")]
		public bool IsListViewInited
		{
			[Token(Token = "0x6004CAD")]
			[Address(RVA = "0x427A040", Offset = "0x4276040", VA = "0x427A040")]
			get
			{
				return mListViewInited;
			}
		}

		[Token(Token = "0x17000D97")]
		public List<GridViewItemPrefabConfData> ItemPrefabDataList
		{
			[Token(Token = "0x6004CAE")]
			[Address(RVA = "0x427A048", Offset = "0x4276048", VA = "0x427A048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D98")]
		public int ItemTotalCount
		{
			[Token(Token = "0x6004CAF")]
			[Address(RVA = "0x427A050", Offset = "0x4276050", VA = "0x427A050")]
			get
			{
				return mItemTotalCount;
			}
		}

		[Token(Token = "0x17000D99")]
		public RectTransform ContainerTrans
		{
			[Token(Token = "0x6004CB0")]
			[Address(RVA = "0x427A058", Offset = "0x4276058", VA = "0x427A058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D9A")]
		public float ViewPortWidth
		{
			[Token(Token = "0x6004CB1")]
			[Address(RVA = "0x427A060", Offset = "0x4276060", VA = "0x427A060")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000D9B")]
		public float ViewPortHeight
		{
			[Token(Token = "0x6004CB2")]
			[Address(RVA = "0x427A084", Offset = "0x4276084", VA = "0x427A084")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000D9C")]
		public ScrollRect ScrollRect
		{
			[Token(Token = "0x6004CB3")]
			[Address(RVA = "0x427A0A8", Offset = "0x42760A8", VA = "0x427A0A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000D9D")]
		public bool IsDraging
		{
			[Token(Token = "0x6004CB4")]
			[Address(RVA = "0x427A0B0", Offset = "0x42760B0", VA = "0x427A0B0")]
			get
			{
				return mIsDraging;
			}
		}

		[Token(Token = "0x17000D9E")]
		public bool ItemSnapEnable
		{
			[Token(Token = "0x6004CB5")]
			[Address(RVA = "0x427A0B8", Offset = "0x42760B8", VA = "0x427A0B8")]
			get
			{
				return mItemSnapEnable;
			}
			[Token(Token = "0x6004CB6")]
			[Address(RVA = "0x427A0C0", Offset = "0x42760C0", VA = "0x427A0C0")]
			set
			{
				mItemSnapEnable = value;
			}
		}

		[Token(Token = "0x17000D9F")]
		public Vector2 ItemSize
		{
			[Token(Token = "0x6004CB7")]
			[Address(RVA = "0x427A0CC", Offset = "0x42760CC", VA = "0x427A0CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004CB8")]
			[Address(RVA = "0x427A0D4", Offset = "0x42760D4", VA = "0x427A0D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000DA0")]
		public Vector2 ItemPadding
		{
			[Token(Token = "0x6004CB9")]
			[Address(RVA = "0x427A1A0", Offset = "0x42761A0", VA = "0x427A1A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004CBA")]
			[Address(RVA = "0x427A1A8", Offset = "0x42761A8", VA = "0x427A1A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000DA1")]
		public Vector2 ItemSizeWithPadding
		{
			[Token(Token = "0x6004CBB")]
			[Address(RVA = "0x427A274", Offset = "0x4276274", VA = "0x427A274")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DA2")]
		public RectOffset Padding
		{
			[Token(Token = "0x6004CBC")]
			[Address(RVA = "0x427A27C", Offset = "0x427627C", VA = "0x427A27C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CBD")]
			[Address(RVA = "0x427A284", Offset = "0x4276284", VA = "0x427A284")]
			set
			{
			}
		}

		[Token(Token = "0x17000DA3")]
		public RowColumnPair CurSnapNearestItemRowColumn
		{
			[Token(Token = "0x6004CC7")]
			[Address(RVA = "0x427C884", Offset = "0x4278884", VA = "0x427C884")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004CBE")]
		[Address(RVA = "0x427A328", Offset = "0x4276328", VA = "0x427A328")]
		public GridViewItemPrefabConfData GetItemPrefabConfData(string prefabName)
		{
			return null;
		}

		[Token(Token = "0x6004CBF")]
		[Address(RVA = "0x427A550", Offset = "0x4276550", VA = "0x427A550")]
		public void InitGridView(int itemTotalCount, Func<LoopGridView, int, int, int, LoopGridViewItem> onGetItemByRowColumn, [Optional] LoopGridViewSettingParam settingParam, [Optional] LoopGridViewInitParam initParam)
		{
		}

		[Token(Token = "0x6004CC0")]
		[Address(RVA = "0x427B4A8", Offset = "0x42774A8", VA = "0x427B4A8")]
		public void SetListItemCount(int itemCount, bool resetPos = true)
		{
		}

		[Token(Token = "0x6004CC1")]
		[Address(RVA = "0x427C0B0", Offset = "0x42780B0", VA = "0x427C0B0")]
		public LoopGridViewItem NewListViewItem(string itemPrefabName)
		{
			return null;
		}

		[Token(Token = "0x6004CC2")]
		[Address(RVA = "0x427C238", Offset = "0x4278238", VA = "0x427C238")]
		public void ClearAllShownItems()
		{
		}

		[Token(Token = "0x6004CC3")]
		[Address(RVA = "0x427C250", Offset = "0x4278250", VA = "0x427C250")]
		public void RefreshItemByItemIndex(int itemIndex)
		{
		}

		[Token(Token = "0x6004CC4")]
		[Address(RVA = "0x427C314", Offset = "0x4278314", VA = "0x427C314")]
		public void RefreshItemByRowColumn(int row, int column)
		{
		}

		[Token(Token = "0x6004CC5")]
		[Address(RVA = "0x427C82C", Offset = "0x427882C", VA = "0x427C82C")]
		public void ClearSnapData()
		{
		}

		[Token(Token = "0x6004CC6")]
		[Address(RVA = "0x427C84C", Offset = "0x427884C", VA = "0x427C84C")]
		public void SetSnapTargetItemRowColumn(int row, int column)
		{
		}

		[Token(Token = "0x6004CC8")]
		[Address(RVA = "0x427C88C", Offset = "0x427888C", VA = "0x427C88C")]
		public void ForceSnapUpdateCheck()
		{
		}

		[Token(Token = "0x6004CC9")]
		[Address(RVA = "0x427B6A4", Offset = "0x42776A4", VA = "0x427B6A4")]
		public void ForceToCheckContentPos()
		{
		}

		[Token(Token = "0x6004CCA")]
		[Address(RVA = "0x427C8A8", Offset = "0x42788A8", VA = "0x427C8A8")]
		public void MovePanelToItemByIndex(int itemIndex, float offsetX = 0f, float offsetY = 0f)
		{
		}

		[Token(Token = "0x6004CCB")]
		[Address(RVA = "0x427BED0", Offset = "0x4277ED0", VA = "0x427BED0")]
		public void MovePanelToItemByRowColumn(int row, int column, float offsetX = 0f, float offsetY = 0f)
		{
		}

		[Token(Token = "0x6004CCC")]
		[Address(RVA = "0x427C980", Offset = "0x4278980", VA = "0x427C980")]
		public void RefreshAllShownItem()
		{
		}

		[Token(Token = "0x6004CCD")]
		[Address(RVA = "0x427C9F8", Offset = "0x42789F8", VA = "0x427C9F8")]
		public void ForceUpdateGridViewAtOnce()
		{
		}

		[Token(Token = "0x6004CCE")]
		[Address(RVA = "0x427CC88", Offset = "0x4278C88", VA = "0x427CC88", Slot = "7")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004CCF")]
		[Address(RVA = "0x427CCD8", Offset = "0x4278CD8", VA = "0x427CCD8", Slot = "8")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004CD0")]
		[Address(RVA = "0x427CD28", Offset = "0x4278D28", VA = "0x427CD28", Slot = "9")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004CD1")]
		[Address(RVA = "0x427CD60", Offset = "0x4278D60", VA = "0x427CD60")]
		public int GetItemIndexByRowColumn(int row, int column)
		{
			return default;
		}

		[Token(Token = "0x6004CD2")]
		[Address(RVA = "0x427C2E4", Offset = "0x42782E4", VA = "0x427C2E4")]
		public RowColumnPair GetRowColumnByItemIndex(int itemIndex)
		{
			return default;
		}

		[Token(Token = "0x6004CD3")]
		[Address(RVA = "0x427CD7C", Offset = "0x4278D7C", VA = "0x427CD7C")]
		public Vector2 GetItemAbsPos(int row, int column)
		{
			return default;
		}

		[Token(Token = "0x6004CD4")]
		[Address(RVA = "0x427C8E8", Offset = "0x42788E8", VA = "0x427C8E8")]
		public Vector2 GetItemPos(int row, int column)
		{
			return default;
		}

		[Token(Token = "0x6004CD5")]
		[Address(RVA = "0x427CD9C", Offset = "0x4278D9C", VA = "0x427CD9C")]
		public LoopGridViewItem GetShownItemByItemIndex(int itemIndex)
		{
			return null;
		}

		[Token(Token = "0x6004CD6")]
		[Address(RVA = "0x427CE34", Offset = "0x4278E34", VA = "0x427CE34")]
		public LoopGridViewItem GetShownItemByRowColumn(int row, int column)
		{
			return null;
		}

		[Token(Token = "0x6004CD7")]
		[Address(RVA = "0x427B454", Offset = "0x4277454", VA = "0x427B454")]
		public void UpdateAllGridSetting()
		{
		}

		[Token(Token = "0x6004CD8")]
		[Address(RVA = "0x427D23C", Offset = "0x427923C", VA = "0x427D23C")]
		public void SetGridFixedGroupCount(GridFixedType fixedType, int count)
		{
		}

		[Token(Token = "0x6004CD9")]
		[Address(RVA = "0x427A0D8", Offset = "0x42760D8", VA = "0x427A0D8")]
		public void SetItemSize(Vector2 newSize)
		{
		}

		[Token(Token = "0x6004CDA")]
		[Address(RVA = "0x427A1AC", Offset = "0x42761AC", VA = "0x427A1AC")]
		public void SetItemPadding(Vector2 newPadding)
		{
		}

		[Token(Token = "0x6004CDB")]
		[Address(RVA = "0x427A288", Offset = "0x4276288", VA = "0x427A288")]
		public void SetPadding(RectOffset newPadding)
		{
		}

		[Token(Token = "0x6004CDC")]
		[Address(RVA = "0x427B5CC", Offset = "0x42775CC", VA = "0x427B5CC")]
		public void UpdateContentSize()
		{
		}

		[Token(Token = "0x6004CDD")]
		[Address(RVA = "0x427B8D0", Offset = "0x42778D0", VA = "0x427B8D0")]
		public void VaildAndSetContainerPos()
		{
		}

		[Token(Token = "0x6004CDE")]
		[Address(RVA = "0x427B838", Offset = "0x4277838", VA = "0x427B838")]
		public void ClearAllTmpRecycledItem()
		{
		}

		[Token(Token = "0x6004CDF")]
		[Address(RVA = "0x427B6C0", Offset = "0x42776C0", VA = "0x427B6C0")]
		public void RecycleAllItem()
		{
		}

		[Token(Token = "0x6004CE0")]
		[Address(RVA = "0x427B918", Offset = "0x4277918", VA = "0x427B918")]
		public void UpdateGridViewContent()
		{
		}

		[Token(Token = "0x6004CE1")]
		[Address(RVA = "0x427CEE4", Offset = "0x4278EE4", VA = "0x427CEE4")]
		public void UpdateStartEndPadding()
		{
		}

		[Token(Token = "0x6004CE2")]
		[Address(RVA = "0x427D088", Offset = "0x4279088", VA = "0x427D088")]
		public void UpdateItemSize()
		{
		}

		[Token(Token = "0x6004CE3")]
		[Address(RVA = "0x427B56C", Offset = "0x427756C", VA = "0x427B56C")]
		public void UpdateColumnRowCount()
		{
		}

		[Token(Token = "0x6004CE4")]
		[Address(RVA = "0x427DB5C", Offset = "0x4279B5C", VA = "0x427DB5C")]
		private bool IsContainerTransCanMove()
		{
			return default;
		}

		[Token(Token = "0x6004CE5")]
		[Address(RVA = "0x427D444", Offset = "0x4279444", VA = "0x427D444")]
		private void RecycleItemGroupTmp(GridItemGroup group)
		{
		}

		[Token(Token = "0x6004CE6")]
		[Address(RVA = "0x427C760", Offset = "0x4278760", VA = "0x427C760")]
		private void RecycleItemTmp(LoopGridViewItem item)
		{
		}

		[Token(Token = "0x6004CE7")]
		[Address(RVA = "0x427AE10", Offset = "0x4276E10", VA = "0x427AE10")]
		private void AdjustViewPortPivot()
		{
		}

		[Token(Token = "0x6004CE8")]
		[Address(RVA = "0x427AE90", Offset = "0x4276E90", VA = "0x427AE90")]
		private void AdjustContainerAnchorAndPivot()
		{
		}

		[Token(Token = "0x6004CE9")]
		[Address(RVA = "0x427DC98", Offset = "0x4279C98", VA = "0x427DC98")]
		private void AdjustItemAnchorAndPivot(RectTransform rtf)
		{
		}

		[Token(Token = "0x6004CEA")]
		[Address(RVA = "0x427AF50", Offset = "0x4276F50", VA = "0x427AF50")]
		private void InitItemPool()
		{
		}

		[Token(Token = "0x6004CEB")]
		[Address(RVA = "0x427C5C0", Offset = "0x42785C0", VA = "0x427C5C0")]
		private LoopGridViewItem GetNewItemByRowColumn(int row, int column)
		{
			return null;
		}

		[Token(Token = "0x6004CEC")]
		[Address(RVA = "0x427DD58", Offset = "0x4279D58", VA = "0x427DD58")]
		private RowColumnPair GetCeilItemRowColumnAtGivenAbsPos(float ax, float ay)
		{
			return default;
		}

		[Token(Token = "0x6004CED")]
		[Address(RVA = "0x427DE90", Offset = "0x4279E90", VA = "0x427DE90")]
		private void Update()
		{
		}

		[Token(Token = "0x6004CEE")]
		[Address(RVA = "0x427D5EC", Offset = "0x42795EC", VA = "0x427D5EC")]
		private GridItemGroup CreateItemGroup(int groupIndex)
		{
			return null;
		}

		[Token(Token = "0x6004CEF")]
		[Address(RVA = "0x427DFA0", Offset = "0x4279FA0", VA = "0x427DFA0")]
		private Vector2 GetContainerMovedDistance()
		{
			return default;
		}

		[Token(Token = "0x6004CF0")]
		[Address(RVA = "0x427D2F8", Offset = "0x42792F8", VA = "0x427D2F8")]
		private Vector2 GetContainerVaildPos(float curX, float curY)
		{
			return default;
		}

		[Token(Token = "0x6004CF1")]
		[Address(RVA = "0x427D4F4", Offset = "0x42794F4", VA = "0x427D4F4")]
		private void UpdateCurFrameItemRangeData()
		{
		}

		[Token(Token = "0x6004CF2")]
		[Address(RVA = "0x427D60C", Offset = "0x427960C", VA = "0x427D60C")]
		private void UpdateRowItemGroupForRecycleAndNew(GridItemGroup group)
		{
		}

		[Token(Token = "0x6004CF3")]
		[Address(RVA = "0x427D8B4", Offset = "0x42798B4", VA = "0x427D8B4")]
		private void UpdateColumnItemGroupForRecycleAndNew(GridItemGroup group)
		{
		}

		[Token(Token = "0x6004CF4")]
		[Address(RVA = "0x427AA44", Offset = "0x4276A44", VA = "0x427AA44")]
		private void SetScrollbarListener()
		{
		}

		[Token(Token = "0x6004CF5")]
		[Address(RVA = "0x427AC40", Offset = "0x4276C40", VA = "0x427AC40")]
		private void ReplaceScrollbarEventHandlerForSmoothMove()
		{
		}

		[Token(Token = "0x6004CF6")]
		[Address(RVA = "0x427DFF4", Offset = "0x4279FF4", VA = "0x427DFF4")]
		private void OnVerticalScrollBarValueChanged(float value)
		{
		}

		[Token(Token = "0x6004CF7")]
		[Address(RVA = "0x427E020", Offset = "0x427A020", VA = "0x427E020")]
		private void OnHorizontalScrollBarValueChanged(float value)
		{
		}

		[Token(Token = "0x6004CF8")]
		[Address(RVA = "0x427E04C", Offset = "0x427A04C", VA = "0x427E04C")]
		private void OnPointerDownInVerticalScrollBar(GameObject obj)
		{
		}

		[Token(Token = "0x6004CF9")]
		[Address(RVA = "0x427E074", Offset = "0x427A074", VA = "0x427E074")]
		private void OnPointerUpInVerticalScrollBar(GameObject obj)
		{
		}

		[Token(Token = "0x6004CFA")]
		[Address(RVA = "0x427E094", Offset = "0x427A094", VA = "0x427E094")]
		private void OnPointerDownInHorizontalScrollBar(GameObject obj)
		{
		}

		[Token(Token = "0x6004CFB")]
		[Address(RVA = "0x427E0BC", Offset = "0x427A0BC", VA = "0x427E0BC")]
		private void OnPointerUpInHorizontalScrollBar(GameObject obj)
		{
		}

		[Token(Token = "0x6004CFC")]
		[Address(RVA = "0x427E0DC", Offset = "0x427A0DC", VA = "0x427E0DC")]
		private RowColumnPair FindNearestItemWithLocalPos(float x, float y)
		{
			return default;
		}

		[Token(Token = "0x6004CFD")]
		[Address(RVA = "0x427E208", Offset = "0x427A208", VA = "0x427E208")]
		private Vector2 GetItemSnapPivotLocalPos(int row, int column)
		{
			return default;
		}

		[Token(Token = "0x6004CFE")]
		[Address(RVA = "0x427E334", Offset = "0x427A334", VA = "0x427E334")]
		private Vector2 GetViewPortSnapPivotLocalPos(Vector2 pos)
		{
			return default;
		}

		[Token(Token = "0x6004CFF")]
		[Address(RVA = "0x427E44C", Offset = "0x427A44C", VA = "0x427E44C")]
		private void UpdateNearestSnapItem(bool forceSendEvent)
		{
		}

		[Token(Token = "0x6004D00")]
		[Address(RVA = "0x427A8A0", Offset = "0x42768A0", VA = "0x427A8A0")]
		private void UpdateFromSettingParam(LoopGridViewSettingParam param)
		{
		}

		[Token(Token = "0x6004D01")]
		[Address(RVA = "0x427E590", Offset = "0x427A590", VA = "0x427E590")]
		public void FinishSnapImmediately()
		{
		}

		[Token(Token = "0x6004D02")]
		[Address(RVA = "0x427CA44", Offset = "0x4278A44", VA = "0x427CA44")]
		private void UpdateSnapMove(bool immediate = false, bool forceSendEvent = false)
		{
		}

		[Token(Token = "0x6004D03")]
		[Address(RVA = "0x427C4CC", Offset = "0x42784CC", VA = "0x427C4CC")]
		private GridItemGroup GetShownGroup(int groupIndex)
		{
			return null;
		}

		[Token(Token = "0x6004D04")]
		[Address(RVA = "0x427E890", Offset = "0x427A890", VA = "0x427E890")]
		private void FillCurSnapData(int row, int column)
		{
		}

		[Token(Token = "0x6004D05")]
		[Address(RVA = "0x427E6DC", Offset = "0x427A6DC", VA = "0x427E6DC")]
		private void UpdateCurSnapData()
		{
		}

		[Token(Token = "0x6004D06")]
		[Address(RVA = "0x427E59C", Offset = "0x427A59C", VA = "0x427E59C")]
		private bool CanSnap()
		{
			return default;
		}

		[Token(Token = "0x6004D07")]
		[Address(RVA = "0x427DEC8", Offset = "0x4279EC8", VA = "0x427DEC8")]
		private GridItemGroup GetOneItemGroupObj()
		{
			return null;
		}

		[Token(Token = "0x6004D08")]
		[Address(RVA = "0x427DBF4", Offset = "0x4279BF4", VA = "0x427DBF4")]
		private void RecycleOneItemGroupObj(GridItemGroup obj)
		{
		}

		[Token(Token = "0x6004D09")]
		[Address(RVA = "0x427EA14", Offset = "0x427AA14", VA = "0x427EA14")]
		public LoopGridView()
		{
		}
	}
}
