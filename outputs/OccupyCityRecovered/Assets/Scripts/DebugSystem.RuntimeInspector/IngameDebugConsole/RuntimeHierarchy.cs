using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000006")]
	public class RuntimeHierarchy : SkinnedWindow, IListViewAdapter, ITooltipManager
	{
		[Token(Token = "0x2000007")]
		[Flags]
		public enum SelectOptions
		{
			[Token(Token = "0x4000065")]
			None = 0,
			[Token(Token = "0x4000066")]
			Additive = 1,
			[Token(Token = "0x4000067")]
			FocusOnSelection = 2,
			[Token(Token = "0x4000068")]
			ForceRevealSelection = 4
		}

		[Token(Token = "0x2000008")]
		public enum LongPressAction
		{
			[Token(Token = "0x400006A")]
			None = 0,
			[Token(Token = "0x400006B")]
			CreateDraggedReferenceItem = 1,
			[Token(Token = "0x400006C")]
			ShowMultiSelectionToggles = 2,
			[Token(Token = "0x400006D")]
			ShowMultiSelectionTogglesThenCreateDraggedReferenceItem = 3
		}

		[Token(Token = "0x2000009")]
		public delegate void SelectionChangedDelegate(ReadOnlyCollection<Transform> selection);

		[Token(Token = "0x200000A")]
		public delegate void DoubleClickDelegate(HierarchyData clickedItem);

		[Token(Token = "0x200000B")]
		public delegate bool GameObjectFilterDelegate(Transform transform);

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DraggedReferenceItem _draggedReferenceItemPrefab;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_refreshInterval;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_objectNamesRefreshInterval;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_searchRefreshInterval;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x44")]
		private float nextHierarchyRefreshTime;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x48")]
		private float nextObjectNamesRefreshTime;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x4C")]
		private float nextSearchRefreshTime;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x50")]
		[Space]
		[SerializeField]
		private bool m_allowMultiSelection;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x51")]
		private bool m_multiSelectionToggleSelectionMode;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x52")]
		private bool justActivatedMultiSelectionToggleSelectionMode;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x53")]
		[Space]
		[SerializeField]
		private bool m_exposeUnityScenes;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[FormerlySerializedAs("exposedScenes")]
		private string[] exposedUnityScenesSubset;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_exposeDontDestroyOnLoadScene;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string[] pseudoScenesOrder;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Space]
		private LongPressAction m_pointerLongPressAction;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[FormerlySerializedAs("m_draggedReferenceHoldTime")]
		private float m_pointerLongPressDuration;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float m_doubleClickThreshold;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x7C")]
		[Space]
		[SerializeField]
		private bool m_canReorganizeItems;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x7D")]
		[SerializeField]
		private bool m_canDropDraggedParentOnChild;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x7E")]
		[SerializeField]
		private bool m_canDropDraggedObjectsToPseudoScenes;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x7F")]
		[Space]
		[SerializeField]
		private bool m_showTooltips;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float m_tooltipDelay;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x90")]
		[Space]
		[SerializeField]
		private bool m_showHorizontalScrollbar;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x91")]
		private bool m_isInSearchMode;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RuntimeInspector m_connectedInspector;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isLocked;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Header("Internal Variables")]
		private ScrollRect scrollView;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform drawArea;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RecycledListView listView;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Image background;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Image verticalScrollbar;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Image horizontalScrollbar;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private InputField searchInputField;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Image searchIcon;

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Image searchInputFieldBackground;

		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private LayoutElement searchBarLayoutElement;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Button deselectAllButton;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private LayoutElement deselectAllLayoutElement;

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Text deselectAllLabel;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Image selectedPathBackground;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Text selectedPathText;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private HierarchyDragDropListener dragDropListener;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private HierarchyField drawerPrefab;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Sprite m_sceneDrawerBackground;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Sprite m_transformDrawerBackground;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x0")]
		private static int aliveHierarchies;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x140")]
		private bool initialized;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x148")]
		private readonly List<HierarchyField> drawers;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x150")]
		private readonly List<HierarchyDataRoot> sceneData;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x158")]
		private readonly List<HierarchyDataRoot> searchSceneData;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x160")]
		private readonly Dictionary<string, HierarchyDataRootPseudoScene> pseudoSceneDataLookup;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x168")]
		private readonly List<Transform> m_currentSelection;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x170")]
		private readonly HashSet<int> currentSelectionSet;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x178")]
		private readonly HashSet<int> newSelectionSet;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x180")]
		private Transform multiSelectionPivotTransform;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x188")]
		private HierarchyDataRoot multiSelectionPivotSceneData;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x190")]
		private readonly List<int> multiSelectionPivotSiblingIndexTraversalList;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x198")]
		private readonly Transform[] singleTransformSelection;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x1A0")]
		private int totalItemCount;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x1A4")]
		private bool selectLock;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x1A5")]
		private bool isListViewDirty;

		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x1A6")]
		private bool shouldRecalculateContentWidth;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x1A8")]
		private float lastClickTime;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x1B0")]
		private HierarchyField lastClickedDrawer;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x1B8")]
		private HierarchyField currentlyPressedDrawer;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x1C0")]
		private float pressedDrawerDraggedReferenceCreateTime;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x1C8")]
		private PointerEventData pressedDrawerActivePointer;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x1D0")]
		private Canvas m_canvas;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x1D8")]
		private float m_autoScrollSpeed;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x1E0")]
		private PointerEventData nullPointerEventData;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x1E8")]
		public SelectionChangedDelegate OnSelectionChanged;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x1F0")]
		public DoubleClickDelegate OnItemDoubleClicked;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x1F8")]
		private GameObjectFilterDelegate m_gameObjectDelegate;

		[Token(Token = "0x17000003")]
		public float RefreshInterval
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x464BCE0", Offset = "0x4647CE0", VA = "0x464BCE0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x464BCE8", Offset = "0x4647CE8", VA = "0x464BCE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public float ObjectNamesRefreshInterval
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x464BCF0", Offset = "0x4647CF0", VA = "0x464BCF0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x464BCF8", Offset = "0x4647CF8", VA = "0x464BCF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public float SearchRefreshInterval
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x464BD00", Offset = "0x4647D00", VA = "0x464BD00")]
			get
			{
				return default;
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x464BD08", Offset = "0x4647D08", VA = "0x464BD08")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public bool AllowMultiSelection
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x464BD10", Offset = "0x4647D10", VA = "0x464BD10")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x464BD18", Offset = "0x4647D18", VA = "0x464BD18")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public bool MultiSelectionToggleSelectionMode
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x464CE20", Offset = "0x4648E20", VA = "0x464CE20")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x464BE90", Offset = "0x4647E90", VA = "0x464BE90")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public bool ExposeUnityScenes
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x464CFA0", Offset = "0x4648FA0", VA = "0x464CFA0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x464CFA8", Offset = "0x4648FA8", VA = "0x464CFA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public bool ExposeDontDestroyOnLoadScene
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x464D4A4", Offset = "0x46494A4", VA = "0x464D4A4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x464D4AC", Offset = "0x46494AC", VA = "0x464D4AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public LongPressAction PointerLongPressAction
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x464D7DC", Offset = "0x46497DC", VA = "0x464D7DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x464D7E4", Offset = "0x46497E4", VA = "0x464D7E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public float PointerLongPressDuration
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x464D7EC", Offset = "0x46497EC", VA = "0x464D7EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x464D7F4", Offset = "0x46497F4", VA = "0x464D7F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public float DoubleClickThreshold
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x464D7FC", Offset = "0x46497FC", VA = "0x464D7FC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x464D804", Offset = "0x4649804", VA = "0x464D804")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public bool CanReorganizeItems
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x464D80C", Offset = "0x464980C", VA = "0x464D80C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x464D814", Offset = "0x4649814", VA = "0x464D814")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public bool CanDropDraggedParentOnChild
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x464D820", Offset = "0x4649820", VA = "0x464D820")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x464D828", Offset = "0x4649828", VA = "0x464D828")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public bool CanDropDraggedObjectsToPseudoScenes
		{
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x464D834", Offset = "0x4649834", VA = "0x464D834")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x464D83C", Offset = "0x464983C", VA = "0x464D83C")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public bool ShowTooltips
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x464D848", Offset = "0x4649848", VA = "0x464D848")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000011")]
		public float TooltipDelay
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x464D850", Offset = "0x4649850", VA = "0x464D850", Slot = "15")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x464D858", Offset = "0x4649858", VA = "0x464D858")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		internal TooltipListener TooltipListener
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x464D860", Offset = "0x4649860", VA = "0x464D860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x464D868", Offset = "0x4649868", VA = "0x464D868")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool ShowHorizontalScrollbar
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x464D870", Offset = "0x4649870", VA = "0x464D870")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x464D878", Offset = "0x4649878", VA = "0x464D878")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public string SearchTerm
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x464DABC", Offset = "0x4649ABC", VA = "0x464DABC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x464DAD8", Offset = "0x4649AD8", VA = "0x464DAD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public bool IsInSearchMode
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x464DAF4", Offset = "0x4649AF4", VA = "0x464DAF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000016")]
		public RuntimeInspector ConnectedInspector
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x464DAFC", Offset = "0x4649AFC", VA = "0x464DAFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x464DB04", Offset = "0x4649B04", VA = "0x464DB04")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public bool IsLocked
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x464DC48", Offset = "0x4649C48", VA = "0x464DC48")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x464DC50", Offset = "0x4649C50", VA = "0x464DC50")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		internal Sprite SceneDrawerBackground
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x464DC5C", Offset = "0x4649C5C", VA = "0x464DC5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		internal Sprite TransformDrawerBackground
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0x464DC64", Offset = "0x4649C64", VA = "0x464DC64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public ReadOnlyCollection<Transform> CurrentSelection
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x464DC6C", Offset = "0x4649C6C", VA = "0x464DC6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		internal int ItemCount
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x464DCBC", Offset = "0x4649CBC", VA = "0x464DCBC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001C")]
		public Canvas Canvas
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x464DCC4", Offset = "0x4649CC4", VA = "0x464DCC4", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		internal float AutoScrollSpeed
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x464DCCC", Offset = "0x4649CCC", VA = "0x464DCCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public GameObjectFilterDelegate GameObjectFilter
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x464DCD4", Offset = "0x4649CD4", VA = "0x464DCD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x464DCDC", Offset = "0x4649CDC", VA = "0x464DCDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700001F")]
int IListViewAdapter.Count
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x464E00C", Offset = "0x464A00C", VA = "0x464E00C", Slot = "8")]
			get
			{
				return IngameDebugConsole_002EIListViewAdapter_002Eget_Count();
			}
		}

		[Token(Token = "0x17000020")]
float IListViewAdapter.ItemHeight
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x464E014", Offset = "0x464A014", VA = "0x464E014", Slot = "9")]
			get
			{
				return IngameDebugConsole_002EIListViewAdapter_002Eget_ItemHeight();
			}
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x464E00C", Offset = "0x464A00C", VA = "0x464E00C", Slot = "8")]
		private int IngameDebugConsole_002EIListViewAdapter_002Eget_Count()
		{
			return default;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x464E014", Offset = "0x464A014", VA = "0x464E014", Slot = "9")]
		private float IngameDebugConsole_002EIListViewAdapter_002Eget_ItemHeight()
		{
			return default;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x464E034", Offset = "0x464A034", VA = "0x464E034", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x464E050", Offset = "0x464A050", VA = "0x464E050")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x464E2EC", Offset = "0x464A2EC", VA = "0x464E2EC")]
		private void Start()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x464E464", Offset = "0x464A464", VA = "0x464E464")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x464E808", Offset = "0x464A808", VA = "0x464E808")]
		private void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x464E814", Offset = "0x464A814", VA = "0x464E814")]
		private void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x464E864", Offset = "0x464A864", VA = "0x464E864", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x464F0CC", Offset = "0x464B0CC", VA = "0x464F0CC")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x464F370", Offset = "0x464B370", VA = "0x464F370")]
		private void RefreshListView()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x464F9C0", Offset = "0x464B9C0", VA = "0x464F9C0")]
		internal void SetListViewDirty()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x464F220", Offset = "0x464B220", VA = "0x464F220")]
		public void RefreshSearchResults()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x464F9EC", Offset = "0x464B9EC", VA = "0x464F9EC")]
		public void RefreshNameOf(Transform target)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x464FD70", Offset = "0x464BD70", VA = "0x464FD70", Slot = "7")]
		protected override void RefreshSkin()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x464CF08", Offset = "0x4648F08", VA = "0x464CF08")]
		private void EnsureScrollViewIsWithinBounds()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x46500C8", Offset = "0x464C0C8", VA = "0x46500C8", Slot = "11")]
void IListViewAdapter.SetItemContent(RecycledListItem item)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x4650674", Offset = "0x464C674", VA = "0x4650674", Slot = "12")]
void IListViewAdapter.OnItemClicked(RecycledListItem item)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x46510D0", Offset = "0x464D0D0", VA = "0x46510D0")]
		private bool FindMultiSelectionPivotAbsoluteIndex(out int pivotAbsoluteIndex)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RuntimeHierarchy.FindMultiSelectionPivotAbsoluteIndex RVA=0x46510D0 Token=0x600005B");
}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x4650254", Offset = "0x464C254", VA = "0x4650254")]
		internal HierarchyData GetDataAt(int index)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x46516BC", Offset = "0x464D6BC", VA = "0x46516BC")]
		public void OnDrawerPointerEvent(HierarchyField drawer, PointerEventData eventData, bool isPointerDown)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x4651718", Offset = "0x464D718", VA = "0x4651718")]
		public bool Select(Transform selection, SelectOptions selectOptions = SelectOptions.None)
		{
			return default;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x46517A8", Offset = "0x464D7A8", VA = "0x46517A8")]
		public bool Select(IList<Transform> selection, SelectOptions selectOptions = SelectOptions.None)
		{
			return default;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x464BFBC", Offset = "0x4647FBC", VA = "0x464BFBC")]
		internal bool SelectInternal(IList<Transform> selection, SelectOptions selectOptions = SelectOptions.None)
		{
			return default;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4651E54", Offset = "0x464DE54", VA = "0x4651E54")]
		public void Deselect()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x4651E78", Offset = "0x464DE78", VA = "0x4651E78")]
		public void Deselect(Transform deselection)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x4651E68", Offset = "0x464DE68", VA = "0x4651E68")]
		public void Deselect(IList<Transform> deselection)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x464CAC0", Offset = "0x4648AC0", VA = "0x464CAC0")]
		internal void DeselectInternal(IList<Transform> deselection)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x4651EF0", Offset = "0x464DEF0", VA = "0x4651EF0")]
		public bool IsSelected(Transform transform)
		{
			return default;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x46517BC", Offset = "0x464D7BC", VA = "0x46517BC")]
		private bool CanSelectTransform(Transform transform)
		{
			return default;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x464F6B0", Offset = "0x464B6B0", VA = "0x464F6B0")]
		private void OnCurrentSelectionChanged()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x4651FB0", Offset = "0x464DFB0", VA = "0x4651FB0")]
		private void OnSearchTermChanged(string search)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x464D068", Offset = "0x4649068", VA = "0x464D068")]
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x464D2F0", Offset = "0x46492F0", VA = "0x464D2F0")]
		private void OnSceneUnloaded(Scene arg0)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x464D504", Offset = "0x4649504", VA = "0x464D504")]
		private Scene GetDontDestroyOnLoadScene()
		{
			return default;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x46522A0", Offset = "0x464E2A0", VA = "0x46522A0")]
		public void AddToPseudoScene(string scene, Transform transform)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x4652428", Offset = "0x464E428", VA = "0x4652428")]
		public void AddToPseudoScene(string scene, IEnumerable<Transform> transforms)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x4652720", Offset = "0x464E720", VA = "0x4652720")]
		public void RemoveFromPseudoScene(string scene, Transform transform, bool deleteSceneIfEmpty)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x46529A4", Offset = "0x464E9A4", VA = "0x46529A4")]
		public void RemoveFromPseudoScene(string scene, IEnumerable<Transform> transforms, bool deleteSceneIfEmpty)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x46522C4", Offset = "0x464E2C4", VA = "0x46522C4")]
		private HierarchyDataRootPseudoScene GetPseudoScene(string scene, bool createIfNotExists)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x4652F7C", Offset = "0x464EF7C", VA = "0x4652F7C")]
		public void CreatePseudoScene(string scene)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x4652CF0", Offset = "0x464ECF0", VA = "0x4652CF0")]
		private HierarchyDataRootPseudoScene CreatePseudoSceneInternal(string scene)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x4653084", Offset = "0x464F084", VA = "0x4653084")]
		public void DeleteAllPseudoScenes()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x46527EC", Offset = "0x464E7EC", VA = "0x46527EC")]
		public void DeletePseudoScene(string scene)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x46531FC", Offset = "0x464F1FC", VA = "0x46531FC", Slot = "10")]
RecycledListItem IListViewAdapter.CreateItem(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4653548", Offset = "0x464F548", VA = "0x4653548")]
		public RuntimeHierarchy()
		{
		}
	}
}
