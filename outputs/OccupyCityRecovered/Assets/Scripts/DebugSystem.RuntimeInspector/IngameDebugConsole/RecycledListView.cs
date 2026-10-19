using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x200006A")]
	[RequireComponent(typeof(ScrollRect))]
	public class RecycledListView : MonoBehaviour
	{
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform viewportTransform;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform contentTransform;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x30")]
		private float itemHeight;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x34")]
		private float _1OverItemHeight;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x38")]
		private float m_viewportWidth;

		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x3C")]
		private float m_viewportHeight;

		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<int, RecycledListItem> items;

		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x48")]
		private readonly Stack<RecycledListItem> pooledItems;

		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x50")]
		private IListViewAdapter adapter;

		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x58")]
		private bool isDirty;

		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x5C")]
		private int currentTopIndex;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x60")]
		private int currentBottomIndex;

		[Token(Token = "0x170000B4")]
		public float ViewportWidth
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x4673974", Offset = "0x466F974", VA = "0x4673974")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000B5")]
		public float ViewportHeight
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x467397C", Offset = "0x466F97C", VA = "0x467397C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x4673984", Offset = "0x466F984", VA = "0x4673984")]
		private void Start()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x4673A44", Offset = "0x466FA44", VA = "0x4673A44")]
		private void Update()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x4673E10", Offset = "0x466FE10", VA = "0x4673E10")]
		public void SetAdapter(IListViewAdapter adapter)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x4673EC8", Offset = "0x466FEC8", VA = "0x4673EC8")]
		public void UpdateList(bool resetContentPosition = true)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x4674018", Offset = "0x4670018", VA = "0x4674018")]
		public void ResetList()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x46742A8", Offset = "0x46702A8", VA = "0x46742A8")]
		private void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x4673A88", Offset = "0x466FA88", VA = "0x4673A88")]
		private void UpdateItemsInTheList(bool updateAllVisibleItems = false)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x46742B4", Offset = "0x46702B4", VA = "0x46742B4")]
		private void CreateItemsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x4674400", Offset = "0x4670400", VA = "0x4674400")]
		private void CreateItemAtIndex(int index)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x46741DC", Offset = "0x46701DC", VA = "0x46741DC")]
		private void DestroyItemsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x46742F4", Offset = "0x46702F4", VA = "0x46742F4")]
		private void UpdateItemContentsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x46745A8", Offset = "0x46705A8", VA = "0x46745A8")]
		public RecycledListView()
		{
		}
	}
}
