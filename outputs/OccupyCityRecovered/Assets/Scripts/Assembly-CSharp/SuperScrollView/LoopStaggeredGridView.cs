using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SuperScrollView
{
	[Token(Token = "0x2000C7B")]
	public class LoopStaggeredGridView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x4005997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, StaggeredGridItemPool> mItemPoolDict;

		[Token(Token = "0x4005998")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<StaggeredGridItemPool> mItemPoolList;

		[Token(Token = "0x4005999")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<StaggeredGridItemPrefabConfData> mItemPrefabDataList;

		[Token(Token = "0x400599A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ListItemArrangeType mArrangeType;

		[Token(Token = "0x400599B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform mContainerTrans;

		[Token(Token = "0x400599C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ScrollRect mScrollRect;

		[Token(Token = "0x400599D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int mGroupCount;

		[Token(Token = "0x400599E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<StaggeredGridItemGroup> mItemGroupList;

		[Token(Token = "0x400599F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<ItemIndexData> mItemIndexDataList;

		[Token(Token = "0x40059A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform mScrollRectTransform;

		[Token(Token = "0x40059A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform mViewPortRectTransform;

		[Token(Token = "0x40059A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float mItemDefaultWithPaddingSize;

		[Token(Token = "0x40059A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int mItemTotalCount;

		[Token(Token = "0x40059A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool mIsVertList;

		[Token(Token = "0x40059A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Func<LoopStaggeredGridView, int, LoopStaggeredGridViewItem> mOnGetItemByItemIndex;

		[Token(Token = "0x40059A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Func<int, (float, float)> mOnGetItemSizeByItemIndex;

		[Token(Token = "0x40059A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] mItemWorldCorners;

		[Token(Token = "0x40059A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3[] mViewPortRectLocalCorners;

		[Token(Token = "0x40059A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float mDistanceForRecycle0;

		[Token(Token = "0x40059AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float mDistanceForNew0;

		[Token(Token = "0x40059AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float mDistanceForRecycle1;

		[Token(Token = "0x40059AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float mDistanceForNew1;

		[Token(Token = "0x40059AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool mIsDraging;

		[Token(Token = "0x40059AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private PointerEventData mPointerEventData;

		[Token(Token = "0x40059AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Action mOnBeginDragAction;

		[Token(Token = "0x40059B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Action mOnDragingAction;

		[Token(Token = "0x40059B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Action mOnEndDragAction;

		[Token(Token = "0x40059B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 mLastFrameContainerPos;

		[Token(Token = "0x40059B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool mListViewInited;

		[Token(Token = "0x40059B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int mListUpdateCheckFrameCount;

		[Token(Token = "0x40059B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private GridViewLayoutParam mLayoutParam;

		[Token(Token = "0x40059B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool mIsPointerDownInScrollBar;

		[Token(Token = "0x40059B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool mNeedReplaceScrollbarEventHandler;

		[Token(Token = "0x40059B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ClickEventListener mScrollBarClickEventListener;

		[Token(Token = "0x40059B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int mCurCreatingItemIndex;

		[Token(Token = "0x40059BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private SGVAutoMoveToItemData mSGVAutoMoveToItemData;

		[Token(Token = "0x17000DDA")]
		public ListItemArrangeType ArrangeType
		{
			[Token(Token = "0x6004DD0")]
			[Address(RVA = "0x429D538", Offset = "0x4299538", VA = "0x429D538")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004DD1")]
			[Address(RVA = "0x429D540", Offset = "0x4299540", VA = "0x429D540")]
			set
			{
			}
		}

		[Token(Token = "0x17000DDB")]
		public List<StaggeredGridItemPrefabConfData> ItemPrefabDataList
		{
			[Token(Token = "0x6004DD2")]
			[Address(RVA = "0x429D548", Offset = "0x4299548", VA = "0x429D548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DDC")]
		public int ListUpdateCheckFrameCount
		{
			[Token(Token = "0x6004DD3")]
			[Address(RVA = "0x429D550", Offset = "0x4299550", VA = "0x429D550")]
			get
			{
				return mListUpdateCheckFrameCount;
			}
		}

		[Token(Token = "0x17000DDD")]
		public bool IsVertList
		{
			[Token(Token = "0x6004DD4")]
			[Address(RVA = "0x429D558", Offset = "0x4299558", VA = "0x429D558")]
			get
			{
				return mIsVertList;
			}
		}

		[Token(Token = "0x17000DDE")]
		public int ItemTotalCount
		{
			[Token(Token = "0x6004DD5")]
			[Address(RVA = "0x429D560", Offset = "0x4299560", VA = "0x429D560")]
			get
			{
				return mItemTotalCount;
			}
		}

		[Token(Token = "0x17000DDF")]
		public RectTransform ContainerTrans
		{
			[Token(Token = "0x6004DD6")]
			[Address(RVA = "0x429D568", Offset = "0x4299568", VA = "0x429D568")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DE0")]
		public ScrollRect ScrollRect
		{
			[Token(Token = "0x6004DD7")]
			[Address(RVA = "0x429D570", Offset = "0x4299570", VA = "0x429D570")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DE1")]
		public bool IsDraging
		{
			[Token(Token = "0x6004DD8")]
			[Address(RVA = "0x429D578", Offset = "0x4299578", VA = "0x429D578")]
			get
			{
				return mIsDraging;
			}
		}

		[Token(Token = "0x17000DE2")]
		public GridViewLayoutParam LayoutParam
		{
			[Token(Token = "0x6004DD9")]
			[Address(RVA = "0x429D580", Offset = "0x4299580", VA = "0x429D580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000DE3")]
		public bool IsInited
		{
			[Token(Token = "0x6004DDA")]
			[Address(RVA = "0x429D588", Offset = "0x4299588", VA = "0x429D588")]
			get
			{
				return mListViewInited;
			}
		}

		[Token(Token = "0x17000DE4")]
		public float ViewPortSize
		{
			[Token(Token = "0x6004DF1")]
			[Address(RVA = "0x429FFFC", Offset = "0x429BFFC", VA = "0x429FFFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DE5")]
		public float ViewPortWidth
		{
			[Token(Token = "0x6004DF2")]
			[Address(RVA = "0x429F4B0", Offset = "0x429B4B0", VA = "0x429F4B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DE6")]
		public float ViewPortHeight
		{
			[Token(Token = "0x6004DF3")]
			[Address(RVA = "0x429F4D4", Offset = "0x429B4D4", VA = "0x429F4D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000DE7")]
		public int CurMaxCreatedItemIndexCount
		{
			[Token(Token = "0x6004E00")]
			[Address(RVA = "0x42A1618", Offset = "0x429D618", VA = "0x42A1618")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004DDB")]
		[Address(RVA = "0x429D590", Offset = "0x4299590", VA = "0x429D590")]
		public StaggeredGridItemGroup GetItemGroupByIndex(int index)
		{
			return null;
		}

		[Token(Token = "0x6004DDC")]
		[Address(RVA = "0x429D614", Offset = "0x4299614", VA = "0x429D614")]
		public StaggeredGridItemPrefabConfData GetItemPrefabConfData(string prefabName)
		{
			return null;
		}

		[Token(Token = "0x6004DDD")]
		[Address(RVA = "0x429D83C", Offset = "0x429983C", VA = "0x429D83C")]
		public void InitListView(int itemTotalCount, GridViewLayoutParam layoutParam, Func<LoopStaggeredGridView, int, LoopStaggeredGridViewItem> onGetItemByItemIndex, [Optional] StaggeredGridViewInitParam initParam, [Optional] Func<int, (float, float)> onGetItemSizeByItemIndex)
		{
		}

		[Token(Token = "0x6004DDE")]
		[Address(RVA = "0x429EE44", Offset = "0x429AE44", VA = "0x429EE44")]
		public void ResetGridViewLayoutParam(int itemTotalCount, GridViewLayoutParam layoutParam)
		{
		}

		[Token(Token = "0x6004DDF")]
		[Address(RVA = "0x429F44C", Offset = "0x429B44C", VA = "0x429F44C")]
		private void OnPointerDownInScrollBar(GameObject obj)
		{
		}

		[Token(Token = "0x6004DE0")]
		[Address(RVA = "0x429F458", Offset = "0x429B458", VA = "0x429F458")]
		private void OnPointerUpInScrollBar(GameObject obj)
		{
		}

		[Token(Token = "0x6004DE1")]
		[Address(RVA = "0x429E6B4", Offset = "0x429A6B4", VA = "0x429E6B4")]
		private void ReplaceScrollbarEventHandlerForSmoothMove()
		{
		}

		[Token(Token = "0x6004DE2")]
		[Address(RVA = "0x429F460", Offset = "0x429B460", VA = "0x429F460")]
		private void OnScrollBarValueChanged(float value)
		{
		}

		[Token(Token = "0x6004DE3")]
		[Address(RVA = "0x429DE38", Offset = "0x4299E38", VA = "0x429DE38")]
		private void UpdateItemSize()
		{
		}

		[Token(Token = "0x6004DE4")]
		[Address(RVA = "0x429E8E8", Offset = "0x429A8E8", VA = "0x429E8E8")]
		private void UpdateLayoutParamAutoValue()
		{
		}

		[Token(Token = "0x6004DE5")]
		[Address(RVA = "0x429F4F8", Offset = "0x429B4F8", VA = "0x429F4F8")]
		public LoopStaggeredGridViewItem NewListViewItem(string itemPrefabName)
		{
			return null;
		}

		[Token(Token = "0x6004DE6")]
		[Address(RVA = "0x429F154", Offset = "0x429B154", VA = "0x429F154")]
		public void SetListItemCount(int itemCount, bool resetPos = true)
		{
		}

		[Token(Token = "0x6004DE7")]
		[Address(RVA = "0x429FD50", Offset = "0x429BD50", VA = "0x429FD50")]
		public void MovePanelToItemIndexImmediately(int itemIndex, float offset)
		{
		}

		[Token(Token = "0x6004DE8")]
		[Address(RVA = "0x429FA38", Offset = "0x429BA38", VA = "0x429FA38")]
		public void MovePanelToItemIndex(int itemIndex, float offset, float duration = 0f)
		{
		}

		[Token(Token = "0x6004DE9")]
		[Address(RVA = "0x42A02EC", Offset = "0x429C2EC", VA = "0x42A02EC")]
		public LoopStaggeredGridViewItem GetShownItemByItemIndex(int itemIndex)
		{
			return null;
		}

		[Token(Token = "0x6004DEA")]
		[Address(RVA = "0x42A04A8", Offset = "0x429C4A8", VA = "0x42A04A8")]
		public void RefreshAllShownItem()
		{
		}

		[Token(Token = "0x6004DEB")]
		[Address(RVA = "0x42A05C4", Offset = "0x429C5C4", VA = "0x42A05C4")]
		public void OnItemSizeChanged(int itemIndex)
		{
		}

		[Token(Token = "0x6004DEC")]
		[Address(RVA = "0x42A06E4", Offset = "0x429C6E4", VA = "0x42A06E4")]
		public void RefreshItemByItemIndex(int itemIndex)
		{
		}

		[Token(Token = "0x6004DED")]
		[Address(RVA = "0x42A0948", Offset = "0x429C948", VA = "0x42A0948")]
		public void ResetListView(bool resetPos = true)
		{
		}

		[Token(Token = "0x6004DEE")]
		[Address(RVA = "0x42A09D4", Offset = "0x429C9D4", VA = "0x42A09D4")]
		public void UpdateContentSizeUpToItemIndex(int itemIndex)
		{
		}

		[Token(Token = "0x6004DEF")]
		[Address(RVA = "0x429F4A8", Offset = "0x429B4A8", VA = "0x429F4A8")]
		public void ClearAutoMoveToItemData()
		{
		}

		[Token(Token = "0x6004DF0")]
		[Address(RVA = "0x42A0DD0", Offset = "0x429CDD0", VA = "0x42A0DD0")]
		public void UpdateAutoMoveToItem()
		{
		}

		[Token(Token = "0x6004DF4")]
		[Address(RVA = "0x429F31C", Offset = "0x429B31C", VA = "0x429F31C")]
		public void RecycleAllItem()
		{
		}

		[Token(Token = "0x6004DF5")]
		[Address(RVA = "0x42A0FE0", Offset = "0x429CFE0", VA = "0x42A0FE0")]
		public void RecycleItemTmp(LoopStaggeredGridViewItem item)
		{
		}

		[Token(Token = "0x6004DF6")]
		[Address(RVA = "0x429F3B4", Offset = "0x429B3B4", VA = "0x429F3B4")]
		public void ClearAllTmpRecycledItem()
		{
		}

		[Token(Token = "0x6004DF7")]
		[Address(RVA = "0x429E128", Offset = "0x429A128", VA = "0x429E128")]
		private void AdjustContainerPivot(RectTransform rtf)
		{
		}

		[Token(Token = "0x6004DF8")]
		[Address(RVA = "0x429DFE8", Offset = "0x4299FE8", VA = "0x429DFE8")]
		private void AdjustPivot(RectTransform rtf)
		{
		}

		[Token(Token = "0x6004DF9")]
		[Address(RVA = "0x42A1228", Offset = "0x429D228", VA = "0x42A1228")]
		private void AdjustContainerAnchor(RectTransform rtf)
		{
		}

		[Token(Token = "0x6004DFA")]
		[Address(RVA = "0x429E05C", Offset = "0x429A05C", VA = "0x429E05C")]
		private void AdjustAnchor(RectTransform rtf)
		{
		}

		[Token(Token = "0x6004DFB")]
		[Address(RVA = "0x429E19C", Offset = "0x429A19C", VA = "0x429E19C")]
		private void InitItemPool()
		{
		}

		[Token(Token = "0x6004DFC")]
		[Address(RVA = "0x42A1430", Offset = "0x429D430", VA = "0x42A1430", Slot = "7")]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004DFD")]
		[Address(RVA = "0x42A1598", Offset = "0x429D598", VA = "0x42A1598", Slot = "8")]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004DFE")]
		[Address(RVA = "0x42A15D8", Offset = "0x429D5D8", VA = "0x42A15D8", Slot = "9")]
		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004DFF")]
		[Address(RVA = "0x42A1478", Offset = "0x429D478", VA = "0x42A1478")]
		private void CacheDragPointerEventData(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004E01")]
		[Address(RVA = "0x429F9FC", Offset = "0x429B9FC", VA = "0x429F9FC")]
		private void SetAnchoredPositionX(RectTransform rtf, float x)
		{
		}

		[Token(Token = "0x6004E02")]
		[Address(RVA = "0x429F9C0", Offset = "0x429B9C0", VA = "0x429F9C0")]
		private void SetAnchoredPositionY(RectTransform rtf, float y)
		{
		}

		[Token(Token = "0x6004E03")]
		[Address(RVA = "0x42A0334", Offset = "0x429C334", VA = "0x42A0334")]
		public ItemIndexData GetItemIndexData(int itemIndex)
		{
			return null;
		}

		[Token(Token = "0x6004E04")]
		[Address(RVA = "0x42A1660", Offset = "0x429D660", VA = "0x42A1660")]
		public void UpdateAllGroupShownItemsPos()
		{
		}

		[Token(Token = "0x6004E05")]
		[Address(RVA = "0x429FF64", Offset = "0x429BF64", VA = "0x429FF64")]
		private void CheckAllGroupIfNeedUpdateItemPos()
		{
		}

		[Token(Token = "0x6004E06")]
		[Address(RVA = "0x42A005C", Offset = "0x429C05C", VA = "0x42A005C")]
		public float GetItemAbsPosByItemIndex(int itemIndex)
		{
			return default;
		}

		[Token(Token = "0x6004E07")]
		[Address(RVA = "0x42A1E5C", Offset = "0x429DE5C", VA = "0x42A1E5C")]
		public LoopStaggeredGridViewItem GetNewItemByGroupAndIndex(int groupIndex, int indexInGroup)
		{
			return null;
		}

		[Token(Token = "0x6004E08")]
		[Address(RVA = "0x42A2184", Offset = "0x429E184", VA = "0x42A2184")]
		private int GetCurShouldAddNewItemGroupIndex()
		{
			return default;
		}

		[Token(Token = "0x6004E09")]
		[Address(RVA = "0x42A2310", Offset = "0x429E310", VA = "0x42A2310")]
		public void UpdateListViewWithDefault()
		{
		}

		[Token(Token = "0x6004E0A")]
		[Address(RVA = "0x42A2330", Offset = "0x429E330", VA = "0x42A2330")]
		private void Update()
		{
		}

		[Token(Token = "0x6004E0B")]
		[Address(RVA = "0x42A0128", Offset = "0x429C128", VA = "0x42A0128")]
		public void UpdateListView(float distanceForRecycle0, float distanceForRecycle1, float distanceForNew0, float distanceForNew1)
		{
		}

		[Token(Token = "0x6004E0C")]
		[Address(RVA = "0x42A002C", Offset = "0x429C02C", VA = "0x42A002C")]
		public float GetContentSize()
		{
			return default;
		}

		[Token(Token = "0x6004E0D")]
		[Address(RVA = "0x429ED0C", Offset = "0x429AD0C", VA = "0x429ED0C")]
		public void UpdateContentSize()
		{
		}

		[Token(Token = "0x6004E0E")]
		[Address(RVA = "0x42A2548", Offset = "0x429E548", VA = "0x42A2548")]
		public LoopStaggeredGridView()
		{
		}
	}
}
