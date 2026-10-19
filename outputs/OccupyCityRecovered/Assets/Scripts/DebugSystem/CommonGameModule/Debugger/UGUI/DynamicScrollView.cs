using System.Collections.Generic;
using CommonGameModule.Debugger.Tools;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x200004E")]
	public class DynamicScrollView<ItemType, DataType, ViewSetting> where ItemType : DynamicScrollItemBase<DataType, ViewSetting>, new() where ViewSetting : class
	{
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<DataType> m_Datas;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<ItemType> m_ActiveItems;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<ItemType> m_PoolItems;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<ItemType> m_TmpItems;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x0")]
		private readonly ScrollRect m_Scroll;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x0")]
		private readonly Scrollbar m_ScrollBarVertical;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x0")]
		private readonly Scrollbar m_ScrollBarHorizontal;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x0")]
		private readonly RectTransform m_Viewport;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x0")]
		private readonly RectTransform m_Content;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x0")]
		private readonly GameObject m_Prefab;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x0")]
		private HorizontalOrVerticalLayoutGroup m_LayoutGroup;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x0")]
		private MyLayout m_myLayout;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x0")]
		public readonly ViewSetting m_ViewSetting;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x0")]
		private Vector2 m_PrefabSize;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x0")]
		private float m_Spacing;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x0")]
		private bool m_IsVertical;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x0")]
		private bool m_KeepEnd;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x0")]
		private Vector2Int m_ViewIndexRange;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x0")]
		private Vector2 m_MaxContextSize;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x0")]
		private Vector3 m_LastContentLocalPos;

		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x0")]
		private bool m_Dirty;

		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x0")]
		private bool m_ViewIndexRangeDirty;

		[Token(Token = "0x17000034")]
		public Vector2 PrefabSize
		{
			[Token(Token = "0x6000145")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000146")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public int Count
		{
			[Token(Token = "0x6000147")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000148")]
		public DynamicScrollView(ScrollRect scroll, RectTransform Viewport, RectTransform content, GameObject prefab, ViewSetting viewSetting)
		{
		}

		[Token(Token = "0x6000149")]
		public void OnUpdate()
		{
		}

		[Token(Token = "0x600014A")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600014B")]
		private void RefreshContextSize()
		{
		}

		[Token(Token = "0x600014C")]
		public void MoveToIndex(int index)
		{
		}

		[Token(Token = "0x600014D")]
		public void SetDirty(bool setViewIndexRange = false)
		{
		}

		[Token(Token = "0x600014E")]
		public void SetDatas(IList<DataType> datas)
		{
		}

		[Token(Token = "0x600014F")]
		public void AddData(DataType data)
		{
		}

		[Token(Token = "0x6000150")]
		public void RemoveData(DataType data)
		{
		}

		[Token(Token = "0x6000151")]
		public bool ChangeData(int index, DataType data)
		{
			return default;
		}

		[Token(Token = "0x6000152")]
		public void ClearData()
		{
		}

		[Token(Token = "0x6000153")]
		private void OnScrollBarValueChange(float value)
		{
		}

		[Token(Token = "0x6000154")]
		private ItemType GetItem()
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		private void RecycleItem(ItemType item)
		{
		}

		[Token(Token = "0x6000156")]
		private void RecycleAllItem()
		{
		}
	}
}
