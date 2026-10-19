using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SuperScrollView
{
	[Token(Token = "0x2000C72")]
	public class LoopListView2 : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x2000C73")]
		private class SnapData
		{
			[Token(Token = "0x400596A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SnapStatus mSnapStatus;

			[Token(Token = "0x400596B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int mSnapTargetIndex;

			[Token(Token = "0x400596C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mTargetSnapVal;

			[Token(Token = "0x400596D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float mCurSnapVal;

			[Token(Token = "0x400596E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool mIsForceSnapTo;

			[Token(Token = "0x400596F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool mIsTempTarget;

			[Token(Token = "0x4005970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int mTempTargetIndex;

			[Token(Token = "0x4005971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float mMoveMaxAbsVec;

			[Token(Token = "0x6004DA0")]
			[Address(RVA = "0x429CE7C", Offset = "0x4298E7C", VA = "0x429CE7C")]
			public void Clear()
			{
			}

			[Token(Token = "0x6004DA1")]
			[Address(RVA = "0x429CE94", Offset = "0x4298E94", VA = "0x429CE94")]
			public SnapData()
			{
			}
		}

		[Token(Token = "0x400592C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, ItemPool> mItemPoolDict;

		[Token(Token = "0x400592D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ItemPool> mItemPoolList;

		[Token(Token = "0x400592E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<ItemPrefabConfData> mItemPrefabDataList;

		[Token(Token = "0x400592F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ListItemArrangeType mArrangeType;

		[Token(Token = "0x4005930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<LoopListViewItem2> mItemList;

		[Token(Token = "0x4005931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform mContainerTrans;

		[Token(Token = "0x4005932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ScrollRect mScrollRect;

		[Token(Token = "0x4005933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform mScrollRectTransform;

		[Token(Token = "0x4005934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform mViewPortRectTransform;

		[Token(Token = "0x4005935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float mItemDefaultWithPaddingSize;

		[Token(Token = "0x4005936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int mItemTotalCount;

		[Token(Token = "0x4005937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool mIsVertList;

		[Token(Token = "0x4005938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Func<LoopListView2, int, LoopListViewItem2> mOnGetItemByIndex;

		[Token(Token = "0x4005939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Func<int, (float, float)> mOnGetItemSizeByIndex;

		[Token(Token = "0x400593A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3[] mItemWorldCorners;

		[Token(Token = "0x400593B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] mViewPortRectLocalCorners;

		[Token(Token = "0x400593C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int mCurReadyMinItemIndex;

		[Token(Token = "0x400593D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int mCurReadyMaxItemIndex;

		[Token(Token = "0x400593E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool mNeedCheckNextMinItem;

		[Token(Token = "0x400593F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool mNeedCheckNextMaxItem;

		[Token(Token = "0x4005940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ItemPosMgr mItemPosMgr;

		[Token(Token = "0x4005941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float mDistanceForRecycle0;

		[Token(Token = "0x4005942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float mDistanceForNew0;

		[Token(Token = "0x4005943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float mDistanceForRecycle1;

		[Token(Token = "0x4005944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float mDistanceForNew1;

		[Token(Token = "0x4005945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool mSupportScrollBar;

		[Token(Token = "0x4005946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool mIsDraging;

		[Token(Token = "0x4005947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private PointerEventData mPointerEventData;

		[Token(Token = "0x4005948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Action mOnBeginDragAction;

		[Token(Token = "0x4005949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Action mOnDragingAction;

		[Token(Token = "0x400594A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Action mOnEndDragAction;

		[Token(Token = "0x400594B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int mLastItemIndex;

		[Token(Token = "0x400594C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float mLastItemPadding;

		[Token(Token = "0x400594D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float mSmoothDumpVel;

		[Token(Token = "0x400594E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float mSmoothDumpRate;

		[Token(Token = "0x400594F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float mSnapFinishThreshold;

		[Token(Token = "0x4005950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private float mSnapVecThreshold;

		[Token(Token = "0x4005951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float mSnapMoveDefaultMaxAbsVec;

		[Token(Token = "0x4005952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[SerializeField]
		private bool mItemSnapEnable;

		[Token(Token = "0x4005953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 mLastFrameContainerPos;

		[Token(Token = "0x4005954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Action<LoopListView2, LoopListViewItem2> mOnSnapItemFinished;

		[Token(Token = "0x4005955")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Action<LoopListView2, LoopListViewItem2> mOnSnapNearestChanged;

		[Token(Token = "0x4005956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private int mCurSnapNearestItemIndex;

		[Token(Token = "0x4005957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Vector2 mAdjustedVec;

		[Token(Token = "0x4005958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private bool mNeedAdjustVec;

		[Token(Token = "0x4005959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int mLeftSnapUpdateExtraCount;

		[Token(Token = "0x400595A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private Vector2 mViewPortSnapPivot;

		[Token(Token = "0x400595B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[SerializeField]
		private Vector2 mItemSnapPivot;

		[Token(Token = "0x400595C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private ClickEventListener mScrollBarClickEventListener;

		[Token(Token = "0x400595D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private SnapData mCurSnapData;

		[Token(Token = "0x400595E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 mLastSnapCheckPos;

		[Token(Token = "0x400595F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private bool mListViewInited;

		[Token(Token = "0x4005960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private int mListUpdateCheckFrameCount;

		[Token(Token = "0x4005961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public Action<LoopListView2> OnListViewStart;

		[Token(Token = "0x4005962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool mIsPointerDownInScrollBar;

		[Token(Token = "0x4005963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		private bool mNeedReplaceScrollbarEventHandler;

		[Token(Token = "0x4005964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private int mCurCreatingItemIndex;

		[Token(Token = "0x4005965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private ListViewAutoMoveToItemData mListViewAutoMoveToItemData;

		[Token(Token = "0x4005966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public Action<LoopListView2, int, float> mOnSmoothMovePanelToItemFinished;

		[Token(Token = "0x4005967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private bool isOpenItemListSortHierarchyByIndex;

		[Token(Token = "0x4005968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private ListItemArrangeType itemListSortHierarchyByIndexType;

		[Token(Token = "0x4005969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private List<LoopListViewItem2> sortedChildren;

		[Token(Token = "0x17000DB4")]
		public ListItemArrangeType ArrangeType
		{
			[Token(Token = "0x6004D3A")]
			[Address(RVA = "0x427F8DC", Offset = "0x427B8DC", VA = "0x427F8DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004D3B")]
			[Address(RVA = "0x427F8E4", Offset = "0x427B8E4", VA = "0x427F8E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000DB5")]
		public List<ItemPrefabConfData> ItemPrefabDataList
		{
			[Token(Token = "0x6004D3C")]
			[Address(RVA = "0x427F8EC", Offset = "0x427B8EC", VA = "0x427F8EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DB6")]
		public List<LoopListViewItem2> ItemList
		{
			[Token(Token = "0x6004D3D")]
			[Address(RVA = "0x427F8F4", Offset = "0x427B8F4", VA = "0x427F8F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DB7")]
		public bool IsVertList
		{
			[Token(Token = "0x6004D3E")]
			[Address(RVA = "0x427F8FC", Offset = "0x427B8FC", VA = "0x427F8FC")]
			get
			{
				return mIsVertList;
			}
		}

		[Token(Token = "0x17000DB8")]
		public int ItemTotalCount
		{
			[Token(Token = "0x6004D3F")]
			[Address(RVA = "0x427F904", Offset = "0x427B904", VA = "0x427F904")]
			get
			{
				return mItemTotalCount;
			}
		}

		[Token(Token = "0x17000DB9")]
		public RectTransform ContainerTrans
		{
			[Token(Token = "0x6004D40")]
			[Address(RVA = "0x427F90C", Offset = "0x427B90C", VA = "0x427F90C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DBA")]
		public RectTransform ViewPortTrans
		{
			[Token(Token = "0x6004D41")]
			[Address(RVA = "0x427F914", Offset = "0x427B914", VA = "0x427F914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DBB")]
		public ScrollRect ScrollRect
		{
			[Token(Token = "0x6004D42")]
			[Address(RVA = "0x427F91C", Offset = "0x427B91C", VA = "0x427F91C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DBC")]
		public bool IsDraging
		{
			[Token(Token = "0x6004D43")]
			[Address(RVA = "0x427F924", Offset = "0x427B924", VA = "0x427F924")]
			get
			{
				return mIsDraging;
			}
		}

		[Token(Token = "0x17000DBD")]
		public bool ItemSnapEnable
		{
			[Token(Token = "0x6004D44")]
			[Address(RVA = "0x427F92C", Offset = "0x427B92C", VA = "0x427F92C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004D45")]
			[Address(RVA = "0x427F934", Offset = "0x427B934", VA = "0x427F934")]
			set
			{
			}
		}

		[Token(Token = "0x17000DBE")]
		public bool SupportScrollBar
		{
			[Token(Token = "0x6004D46")]
			[Address(RVA = "0x427F940", Offset = "0x427B940", VA = "0x427F940")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004D47")]
			[Address(RVA = "0x427F948", Offset = "0x427B948", VA = "0x427F948")]
			set
			{
			}
		}

		[Token(Token = "0x17000DBF")]
		public float SnapMoveDefaultMaxAbsVec
		{
			[Token(Token = "0x6004D48")]
			[Address(RVA = "0x427F954", Offset = "0x427B954", VA = "0x427F954")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004D49")]
			[Address(RVA = "0x427F95C", Offset = "0x427B95C", VA = "0x427F95C")]
			set
			{
				mSnapMoveDefaultMaxAbsVec = value;
			}
		}

		[Token(Token = "0x17000DC0")]
		public int ShownItemCount
		{
			[Token(Token = "0x6004D58")]
			[Address(RVA = "0x4281EE4", Offset = "0x427DEE4", VA = "0x4281EE4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DC1")]
		public float ViewPortSize
		{
			[Token(Token = "0x6004D59")]
			[Address(RVA = "0x4281F2C", Offset = "0x427DF2C", VA = "0x4281F2C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DC2")]
		public float ViewPortWidth
		{
			[Token(Token = "0x6004D5A")]
			[Address(RVA = "0x4281F5C", Offset = "0x427DF5C", VA = "0x4281F5C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DC3")]
		public float ViewPortHeight
		{
			[Token(Token = "0x6004D5B")]
			[Address(RVA = "0x4281F80", Offset = "0x427DF80", VA = "0x4281F80")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DC4")]
		public int CurSnapNearestItemIndex
		{
			[Token(Token = "0x6004D8C")]
			[Address(RVA = "0x4286C10", Offset = "0x4282C10", VA = "0x4286C10")]
			get
			{
				return mCurSnapNearestItemIndex;
			}
		}

		[Token(Token = "0x6004D4A")]
		[Address(RVA = "0x427F964", Offset = "0x427B964", VA = "0x427F964")]
		public ItemPrefabConfData GetItemPrefabConfData(string prefabName)
		{
			return null;
		}

		[Token(Token = "0x6004D4B")]
		[Address(RVA = "0x427FB8C", Offset = "0x427BB8C", VA = "0x427FB8C")]
		public void OnItemPrefabChanged(string prefabName)
		{
		}

		[Token(Token = "0x6004D4C")]
		[Address(RVA = "0x4280120", Offset = "0x427C120", VA = "0x4280120")]
		public void InitListView(int itemTotalCount, Func<LoopListView2, int, LoopListViewItem2> onGetItemByIndex, [Optional] LoopListViewInitParam initParam, [Optional] Func<int, (float, float)> onGetItemSizeByIndex)
		{
		}

		[Token(Token = "0x6004D4D")]
		[Address(RVA = "0x4281118", Offset = "0x427D118", VA = "0x4281118")]
		private void Start()
		{
		}

		[Token(Token = "0x6004D4E")]
		[Address(RVA = "0x42805C0", Offset = "0x427C5C0", VA = "0x42805C0")]
		private void SetScrollbarListener()
		{
		}

		[Token(Token = "0x6004D4F")]
		[Address(RVA = "0x4281138", Offset = "0x427D138", VA = "0x4281138")]
		private void OnPointerDownInScrollBar(GameObject obj)
		{
		}

		[Token(Token = "0x6004D50")]
		[Address(RVA = "0x4281160", Offset = "0x427D160", VA = "0x4281160")]
		private void OnPointerUpInScrollBar(GameObject obj)
		{
		}

		[Token(Token = "0x6004D51")]
		[Address(RVA = "0x4280ECC", Offset = "0x427CECC", VA = "0x4280ECC")]
		private void ReplaceScrollbarEventHandlerForSmoothMove()
		{
		}

		[Token(Token = "0x6004D52")]
		[Address(RVA = "0x428119C", Offset = "0x427D19C", VA = "0x428119C")]
		private void OnScrollBarValueChanged(float value)
		{
		}

		[Token(Token = "0x6004D53")]
		[Address(RVA = "0x4280E34", Offset = "0x427CE34", VA = "0x4280E34")]
		public void ResetListView(bool resetPos = true)
		{
		}

		[Token(Token = "0x6004D54")]
		[Address(RVA = "0x42811EC", Offset = "0x427D1EC", VA = "0x42811EC")]
		public void SetListItemCount(int itemCount, bool resetPos = true)
		{
		}

		[Token(Token = "0x6004D55")]
		[Address(RVA = "0x4281B64", Offset = "0x427DB64", VA = "0x4281B64")]
		public LoopListViewItem2 GetShownItemByItemIndex(int itemIndex)
		{
			return null;
		}

		[Token(Token = "0x6004D56")]
		[Address(RVA = "0x4281C54", Offset = "0x427DC54", VA = "0x4281C54")]
		public LoopListViewItem2 GetShownItemByItemId(int itemId)
		{
			return null;
		}

		[Token(Token = "0x6004D57")]
		[Address(RVA = "0x4281DD4", Offset = "0x427DDD4", VA = "0x4281DD4")]
		public LoopListViewItem2 GetShownItemNearestItemIndex(int itemIndex)
		{
			return null;
		}

		[Token(Token = "0x6004D5C")]
		[Address(RVA = "0x4281FA4", Offset = "0x427DFA4", VA = "0x4281FA4")]
		public LoopListViewItem2 GetShownItemByIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x6004D5D")]
		[Address(RVA = "0x4282028", Offset = "0x427E028", VA = "0x4282028")]
		public void SetShownItemByIndex(int index, LoopListViewItem2 item)
		{
		}

		[Token(Token = "0x6004D5E")]
		[Address(RVA = "0x4282198", Offset = "0x427E198", VA = "0x4282198")]
		public LoopListViewItem2 GetShownItemByIndexWithoutCheck(int index)
		{
			return null;
		}

		[Token(Token = "0x6004D5F")]
		[Address(RVA = "0x42821F0", Offset = "0x427E1F0", VA = "0x42821F0")]
		public int GetIndexInShownItemList(LoopListViewItem2 item)
		{
			return default;
		}

		[Token(Token = "0x6004D60")]
		[Address(RVA = "0x42822F8", Offset = "0x427E2F8", VA = "0x42822F8")]
		public void DoActionForEachShownItem(Action<LoopListViewItem2, object> action, object param)
		{
		}

		[Token(Token = "0x6004D61")]
		[Address(RVA = "0x42823B8", Offset = "0x427E3B8", VA = "0x42823B8")]
		public LoopListViewItem2 NewListViewItem(string itemPrefabName)
		{
			return null;
		}

		[Token(Token = "0x6004D62")]
		[Address(RVA = "0x4282540", Offset = "0x427E540", VA = "0x4282540")]
		public LoopListViewItem2 GetItemFromTmpPool(int itemIndex)
		{
			return null;
		}

		[Token(Token = "0x6004D63")]
		[Address(RVA = "0x4282630", Offset = "0x427E630", VA = "0x4282630")]
		public void OnItemSizeChanged(int itemIndex)
		{
		}

		[Token(Token = "0x6004D64")]
		[Address(RVA = "0x4282764", Offset = "0x427E764", VA = "0x4282764")]
		public void RefreshItemByItemIndex(int itemIndex)
		{
		}

		[Token(Token = "0x6004D65")]
		[Address(RVA = "0x4282DA8", Offset = "0x427EDA8", VA = "0x4282DA8")]
		public void FinishSnapImmediately()
		{
		}

		[Token(Token = "0x6004D66")]
		[Address(RVA = "0x4282DE8", Offset = "0x427EDE8", VA = "0x4282DE8")]
		public void MovePanelToItemIndexImmediately(int itemIndex, float offset)
		{
		}

		[Token(Token = "0x6004D67")]
		[Address(RVA = "0x4281428", Offset = "0x427D428", VA = "0x4281428")]
		public void MovePanelToItemIndex(int itemIndex, float offset, float duration = 0f)
		{
		}

		[Token(Token = "0x6004D68")]
		[Address(RVA = "0x42811E4", Offset = "0x427D1E4", VA = "0x42811E4")]
		public void ClearAutoMoveToItemData()
		{
		}

		[Token(Token = "0x6004D69")]
		[Address(RVA = "0x4283E58", Offset = "0x427FE58", VA = "0x4283E58")]
		public void RefreshAllShownItem()
		{
		}

		[Token(Token = "0x6004D6A")]
		[Address(RVA = "0x42840A8", Offset = "0x42800A8", VA = "0x42840A8")]
		public void MovePanelByOffset(float offset)
		{
		}

		[Token(Token = "0x6004D6B")]
		[Address(RVA = "0x42843A8", Offset = "0x42803A8", VA = "0x42843A8")]
		public ItemPosStruct GetFirstShownItemIndexAndOffset()
		{
			return default;
		}

		[Token(Token = "0x6004D6C")]
		[Address(RVA = "0x4283B10", Offset = "0x427FB10", VA = "0x4283B10")]
		public float GetFirstShownFloatItemIndexInViewPort()
		{
			return default;
		}

		[Token(Token = "0x6004D6D")]
		[Address(RVA = "0x4282B74", Offset = "0x427EB74", VA = "0x4282B74")]
		public void RefreshAllShownItemWithFirstIndex(int firstItemIndex)
		{
		}

		[Token(Token = "0x6004D6E")]
		[Address(RVA = "0x427FF54", Offset = "0x427BF54", VA = "0x427FF54")]
		public void RefreshAllShownItemWithFirstIndexAndPos(int firstItemIndex, Vector3 pos)
		{
		}

		[Token(Token = "0x6004D6F")]
		[Address(RVA = "0x42845FC", Offset = "0x42805FC", VA = "0x42845FC")]
		public void RecycleItemImmediately(LoopListViewItem2 item)
		{
		}

		[Token(Token = "0x6004D70")]
		[Address(RVA = "0x42846C8", Offset = "0x42806C8", VA = "0x42846C8")]
		public void UpdateItemSizeAtOnce(int startItemIndex, int endItemIndex)
		{
		}

		[Token(Token = "0x6004D71")]
		[Address(RVA = "0x4282984", Offset = "0x427E984", VA = "0x4282984")]
		private void RecycleItemTmp(LoopListViewItem2 item)
		{
		}

		[Token(Token = "0x6004D72")]
		[Address(RVA = "0x427FEBC", Offset = "0x427BEBC", VA = "0x427FEBC")]
		private void ClearAllTmpRecycledItem()
		{
		}

		[Token(Token = "0x6004D73")]
		[Address(RVA = "0x427FD44", Offset = "0x427BD44", VA = "0x427FD44")]
		private void RecycleAllItem()
		{
		}

		[Token(Token = "0x6004D74")]
		[Address(RVA = "0x42808A4", Offset = "0x427C8A4", VA = "0x42808A4")]
		private void AdjustContainerPivot(RectTransform rtf)
		{
		}

		[Token(Token = "0x6004D75")]
		[Address(RVA = "0x4280764", Offset = "0x427C764", VA = "0x4280764")]
		private void AdjustPivot(RectTransform rtf)
		{
		}

		[Token(Token = "0x6004D76")]
		[Address(RVA = "0x4284840", Offset = "0x4280840", VA = "0x4284840")]
		private void AdjustContainerAnchor(RectTransform rtf)
		{
		}

		[Token(Token = "0x6004D77")]
		[Address(RVA = "0x42807D8", Offset = "0x427C7D8", VA = "0x42807D8")]
		private void AdjustAnchor(RectTransform rtf)
		{
		}

		[Token(Token = "0x6004D78")]
		[Address(RVA = "0x4280918", Offset = "0x427C918", VA = "0x4280918")]
		private void InitItemPool()
		{
		}

		[Token(Token = "0x6004D79")]
		[Address(RVA = "0x428490C", Offset = "0x428090C", VA = "0x428490C", Slot = "7")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004D7A")]
		[Address(RVA = "0x4284A84", Offset = "0x4280A84", VA = "0x4284A84", Slot = "8")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004D7B")]
		[Address(RVA = "0x4284AD8", Offset = "0x4280AD8", VA = "0x4284AD8", Slot = "9")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004D7C")]
		[Address(RVA = "0x4284964", Offset = "0x4280964", VA = "0x4284964")]
		private void CacheDragPointerEventData(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004D7D")]
		[Address(RVA = "0x4282A50", Offset = "0x427EA50", VA = "0x4282A50")]
		private LoopListViewItem2 GetNewItemByIndex(int index, bool canReuseItemFromTmpPool = false)
		{
			return null;
		}

		[Token(Token = "0x6004D7E")]
		[Address(RVA = "0x4282714", Offset = "0x427E714", VA = "0x4282714")]
		private void SetItemSize(int itemIndex, float itemSize, float padding)
		{
		}

		[Token(Token = "0x6004D7F")]
		[Address(RVA = "0x4284B18", Offset = "0x4280B18", VA = "0x4284B18")]
		private bool GetPlusItemIndexAndPosAtGivenPos(float pos, ref int index, ref float itemPos)
		{
			return default;
		}

		[Token(Token = "0x6004D80")]
		[Address(RVA = "0x4284B30", Offset = "0x4280B30", VA = "0x4284B30")]
		private float GetItemPos(int itemIndex)
		{
			return default;
		}

		[Token(Token = "0x6004D81")]
		[Address(RVA = "0x4284B48", Offset = "0x4280B48", VA = "0x4284B48")]
		public Vector3 GetItemCornerPosInViewPort(LoopListViewItem2 item, ItemCornerEnum corner = ItemCornerEnum.LeftBottom)
		{
			return default;
		}

		[Token(Token = "0x6004D82")]
		[Address(RVA = "0x42832D8", Offset = "0x427F2D8", VA = "0x42832D8")]
		private void AdjustPanelPos()
		{
		}

		[Token(Token = "0x6004D83")]
		[Address(RVA = "0x4284BC0", Offset = "0x4280BC0", VA = "0x4284BC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6004D84")]
		[Address(RVA = "0x4282DB4", Offset = "0x427EDB4", VA = "0x4282DB4")]
		private void UpdateSnapMove(bool immediate = false, bool forceSendEvent = false)
		{
		}

		[Token(Token = "0x6004D85")]
		[Address(RVA = "0x42852B0", Offset = "0x42812B0", VA = "0x42852B0")]
		public void UpdateListViewContent()
		{
		}

		[Token(Token = "0x6004D86")]
		[Address(RVA = "0x4284CA0", Offset = "0x4280CA0", VA = "0x4284CA0")]
		public void UpdateAutoMoveToItem()
		{
		}

		[Token(Token = "0x6004D87")]
		[Address(RVA = "0x4286100", Offset = "0x4282100", VA = "0x4286100")]
		public void UpdateAllShownItemSnapData()
		{
		}

		[Token(Token = "0x6004D88")]
		[Address(RVA = "0x42852D4", Offset = "0x42812D4", VA = "0x42852D4")]
		private void UpdateSnapVertical(bool immediate = false, bool forceSendEvent = false)
		{
		}

		[Token(Token = "0x6004D89")]
		[Address(RVA = "0x42868EC", Offset = "0x42828EC", VA = "0x42868EC")]
		private void UpdateCurSnapData()
		{
		}

		[Token(Token = "0x6004D8A")]
		[Address(RVA = "0x42860E4", Offset = "0x42820E4", VA = "0x42860E4")]
		public void ClearSnapData()
		{
		}

		[Token(Token = "0x6004D8B")]
		[Address(RVA = "0x4286B84", Offset = "0x4282B84", VA = "0x4286B84")]
		public void SetSnapTargetItemIndex(int itemIndex, float moveMaxAbsVec = -1f)
		{
		}

		[Token(Token = "0x6004D8D")]
		[Address(RVA = "0x4281180", Offset = "0x427D180", VA = "0x4281180")]
		public void ForceSnapUpdateCheck()
		{
		}

		[Token(Token = "0x6004D8E")]
		[Address(RVA = "0x42859D4", Offset = "0x42819D4", VA = "0x42859D4")]
		private void UpdateSnapHorizontal(bool immediate = false, bool forceSendEvent = false)
		{
		}

		[Token(Token = "0x6004D8F")]
		[Address(RVA = "0x428666C", Offset = "0x428266C", VA = "0x428666C")]
		private bool CanSnap()
		{
			return default;
		}

		[Token(Token = "0x6004D90")]
		[Address(RVA = "0x42813EC", Offset = "0x427D3EC", VA = "0x42813EC")]
		private void SetAnchoredPositionX(RectTransform rtf, float x)
		{
		}

		[Token(Token = "0x6004D91")]
		[Address(RVA = "0x42813B0", Offset = "0x427D3B0", VA = "0x42813B0")]
		private void SetAnchoredPositionY(RectTransform rtf, float y)
		{
		}

		[Token(Token = "0x6004D92")]
		[Address(RVA = "0x4283158", Offset = "0x427F158", VA = "0x4283158")]
		public void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1, bool canReuseItemFromTmpPool = false)
		{
		}

		[Token(Token = "0x6004D93")]
		[Address(RVA = "0x4286C18", Offset = "0x4282C18", VA = "0x4286C18")]
		private bool UpdateForVertList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1, bool canReuseItemFromTmpPool = false)
		{
			return default;
		}

		[Token(Token = "0x6004D94")]
		[Address(RVA = "0x42879D4", Offset = "0x42839D4", VA = "0x42879D4")]
		private bool UpdateForHorizontalList(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1, bool canReuseItemFromTmpPool = false)
		{
			return default;
		}

		[Token(Token = "0x6004D95")]
		[Address(RVA = "0x428422C", Offset = "0x428022C", VA = "0x428422C")]
		private float GetContentPanelSize()
		{
			return default;
		}

		[Token(Token = "0x6004D96")]
		[Address(RVA = "0x42887B4", Offset = "0x42847B4", VA = "0x42887B4")]
		private void CheckIfNeedUpdataItemPos()
		{
		}

		[Token(Token = "0x6004D97")]
		[Address(RVA = "0x428159C", Offset = "0x427D59C", VA = "0x428159C")]
		private void UpdateAllShownItemsPos()
		{
		}

		[Token(Token = "0x6004D98")]
		[Address(RVA = "0x4288B44", Offset = "0x4284B44", VA = "0x4288B44")]
		public void SetDistanceForNewAndRecycle(float mDistanceForRecycle0 = 300f, float mDistanceForNew0 = 200f, float mDistanceForRecycle1 = 300f, float mDistanceForNew1 = 200f)
		{
		}

		[Token(Token = "0x6004D99")]
		[Address(RVA = "0x4288B50", Offset = "0x4284B50", VA = "0x4288B50")]
		public void OpenItemListSortHierarchyByIndex(ListItemArrangeType arrangeType)
		{
		}

		[Token(Token = "0x6004D9A")]
		[Address(RVA = "0x4283EE4", Offset = "0x427FEE4", VA = "0x4283EE4")]
		private void SetItemSortByIndex()
		{
		}

		[Token(Token = "0x6004D9B")]
		[Address(RVA = "0x4281090", Offset = "0x427D090", VA = "0x4281090")]
		private void UpdateContentSize()
		{
		}

		[Token(Token = "0x6004D9C")]
		[Address(RVA = "0x4288B60", Offset = "0x4284B60", VA = "0x4288B60")]
		public Vector2 CalculateTargetPosition(int itemIndex, float offset)
		{
			return default;
		}

		[Token(Token = "0x6004D9D")]
		[Address(RVA = "0x4288E14", Offset = "0x4284E14", VA = "0x4288E14")]
		public void SetScrollToPosition(Vector2 targetPos)
		{
		}

		[Token(Token = "0x6004D9E")]
		[Address(RVA = "0x4288D5C", Offset = "0x4284D5C", VA = "0x4288D5C")]
		private float GetItemSize(int itemIndex)
		{
			return default;
		}

		[Token(Token = "0x6004D9F")]
		[Address(RVA = "0x4288E30", Offset = "0x4284E30", VA = "0x4288E30")]
		public LoopListView2()
		{
		}
	}
}
