using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000060")]
	public class ObjectReferencePicker : SkinnedWindow, IListViewAdapter
	{
		[Token(Token = "0x2000061")]
		public delegate void ReferenceCallback(object reference);

		[Token(Token = "0x2000062")]
		public delegate string NameGetter(object reference);

		[Token(Token = "0x40001CA")]
		private const string SPRITE_ATLAS_PREFIX = "SpriteAtlasTexture-";

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x0")]
		private static ObjectReferencePicker prefab;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x8")]
		private static Transform parent;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x10")]
		private static ObjectReferencePicker m_instance;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x30")]
		private ReferenceCallback onReferenceChanged;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x38")]
		private ReferenceCallback onSelectionConfirmed;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x40")]
		private NameGetter referenceNameGetter;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x48")]
		private NameGetter referenceDisplayNameGetter;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image panel;

		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image scrollbar;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private InputField searchBar;

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image searchIcon;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image searchBarBackground;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text selectPromptText;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private LayoutElement searchBarLayoutElement;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private LayoutElement buttonsLayoutElement;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button cancelButton;

		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button okButton;

		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RecycledListView listView;

		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image listViewBackground;

		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ObjectReferencePickerItem referenceItemPrefab;

		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0xB8")]
		private readonly List<object> references;

		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0xC0")]
		private readonly List<object> filteredReferences;

		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0xC8")]
		private object initialValue;

		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0xD0")]
		private object currentlySelectedObject;

		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0xD8")]
		private ObjectReferencePickerItem currentlySelectedItem;

		[Token(Token = "0x170000A9")]
		public static ObjectReferencePicker Instance
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x46609D0", Offset = "0x465C9D0", VA = "0x46609D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
int IListViewAdapter.Count
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x4671A2C", Offset = "0x466DA2C", VA = "0x4671A2C", Slot = "8")]
			get
			{
				return IngameDebugConsole_002EIListViewAdapter_002Eget_Count();
			}
		}

		[Token(Token = "0x170000AB")]
float IListViewAdapter.ItemHeight
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x4671A74", Offset = "0x466DA74", VA = "0x4671A74", Slot = "9")]
			get
			{
				return IngameDebugConsole_002EIListViewAdapter_002Eget_ItemHeight();
			}
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x4671A2C", Offset = "0x466DA2C", VA = "0x4671A2C", Slot = "8")]
		private int IngameDebugConsole_002EIListViewAdapter_002Eget_Count()
		{
			return default;
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x4671A74", Offset = "0x466DA74", VA = "0x4671A74", Slot = "9")]
		private float IngameDebugConsole_002EIListViewAdapter_002Eget_ItemHeight()
		{
			return default;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x4671A94", Offset = "0x466DA94", VA = "0x4671A94", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x4660D40", Offset = "0x465CD40", VA = "0x4660D40")]
		public void Show(ReferenceCallback onReferenceChanged, ReferenceCallback onSelectionConfirmed, NameGetter referenceNameGetter, NameGetter referenceDisplayNameGetter, object[] references, object initialReference, bool includeNullReference, string title, Canvas referenceCanvas)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x467203C", Offset = "0x466E03C", VA = "0x467203C")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x4672114", Offset = "0x466E114", VA = "0x4672114")]
		public void Close()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x46721D0", Offset = "0x466E1D0", VA = "0x46721D0", Slot = "7")]
		protected override void RefreshSkin()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x4671C14", Offset = "0x466DC14", VA = "0x4671C14")]
		private void GenerateReferenceItems(object[] references, bool includeNullReference)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x4672508", Offset = "0x466E508", VA = "0x4672508", Slot = "10")]
RecycledListItem IListViewAdapter.CreateItem(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x4672350", Offset = "0x466E350", VA = "0x4672350")]
		private void OnSearchTextChanged(string value)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x4672704", Offset = "0x466E704", VA = "0x4672704", Slot = "11")]
void IListViewAdapter.SetItemContent(RecycledListItem item)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x4672A48", Offset = "0x466EA48", VA = "0x4672A48", Slot = "12")]
void IListViewAdapter.OnItemClicked(RecycledListItem item)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x4672C14", Offset = "0x466EC14", VA = "0x4672C14")]
		public static void DestroyInstance()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x4672D3C", Offset = "0x466ED3C", VA = "0x4672D3C")]
		public static void SetPrefab(ObjectReferencePicker picker, Transform createParent)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x4672DA0", Offset = "0x466EDA0", VA = "0x4672DA0")]
		public ObjectReferencePicker()
		{
		}
	}
}
