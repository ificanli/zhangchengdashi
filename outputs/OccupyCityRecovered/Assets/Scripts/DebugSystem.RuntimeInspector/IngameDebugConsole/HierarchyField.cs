using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000014")]
	public class HierarchyField : RecycledListItem, ITooltipContent
	{
		[Token(Token = "0x2000015")]
		private enum ExpandedState
		{
			[Token(Token = "0x40000AB")]
			Collapsed = 0,
			[Token(Token = "0x40000AC")]
			Expanded = 1,
			[Token(Token = "0x40000AD")]
			ArrowHidden = 2
		}

		[Token(Token = "0x4000097")]
		private const float INACTIVE_ITEM_TEXT_ALPHA = 0.57f;

		[Token(Token = "0x4000098")]
		private const float TEXT_X_OFFSET = 35f;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform contentTransform;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text nameText;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PointerEventListener clickListener;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PointerEventListener expandToggle;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Graphic expandArrow;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Toggle multiSelectionToggle;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image multiSelectionToggleBackground;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform rectTransform;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x78")]
		private Image background;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x80")]
		private int m_skinVersion;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x88")]
		private UISkin m_skin;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isSelected;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x91")]
		private bool m_isActive;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x94")]
		private ExpandedState m_isExpanded;

		[Token(Token = "0x1700003E")]
		public UISkin Skin
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x4657948", Offset = "0x4653948", VA = "0x4657948")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x4650378", Offset = "0x464C378", VA = "0x4650378")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public bool IsSelected
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x4657950", Offset = "0x4653950", VA = "0x4657950")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x464F510", Offset = "0x464B510", VA = "0x464F510")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		private bool IsActive
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x4657958", Offset = "0x4653958", VA = "0x4657958")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x4657960", Offset = "0x4653960", VA = "0x4657960")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public bool MultiSelectionToggleVisible
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x46579E0", Offset = "0x46539E0", VA = "0x46579E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x464CE28", Offset = "0x4648E28", VA = "0x464CE28")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		private ExpandedState IsExpanded
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x4657A08", Offset = "0x4653A08", VA = "0x4657A08")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x4657A10", Offset = "0x4653A10", VA = "0x4657A10")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
bool ITooltipContent.IsActive
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x4657B00", Offset = "0x4653B00", VA = "0x4657B00", Slot = "4")]
			get
			{
				return IngameDebugConsole_002EITooltipContent_002Eget_IsActive();
			}
		}

		[Token(Token = "0x17000044")]
string ITooltipContent.TooltipText
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x4657B88", Offset = "0x4653B88", VA = "0x4657B88", Slot = "5")]
			get
			{
				return IngameDebugConsole_002EITooltipContent_002Eget_TooltipText();
			}
		}

		[Token(Token = "0x17000045")]
		public float PreferredWidth
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x4657BA8", Offset = "0x4653BA8", VA = "0x4657BA8")]
			[CompilerGenerated]
			get
			{
				return default;
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x4657BB0", Offset = "0x4653BB0", VA = "0x4657BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public RuntimeHierarchy Hierarchy
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x4657BB8", Offset = "0x4653BB8", VA = "0x4657BB8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x4657BC0", Offset = "0x4653BC0", VA = "0x4657BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public HierarchyData Data
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x4657BC8", Offset = "0x4653BC8", VA = "0x4657BC8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x4657BD0", Offset = "0x4653BD0", VA = "0x4657BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x4657B00", Offset = "0x4653B00", VA = "0x4657B00", Slot = "4")]
		private bool IngameDebugConsole_002EITooltipContent_002Eget_IsActive()
		{
			return default;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x4657B88", Offset = "0x4653B88", VA = "0x4657B88", Slot = "5")]
		private string IngameDebugConsole_002EITooltipContent_002Eget_TooltipText()
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x4653314", Offset = "0x464F314", VA = "0x4653314")]
		public void Initialize(RuntimeHierarchy hierarchy)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x46505B4", Offset = "0x464C5B4", VA = "0x46505B4")]
		public void SetContent(HierarchyData data)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x4657BD8", Offset = "0x4653BD8", VA = "0x4657BD8")]
		private void ToggleExpandedState()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x464F948", Offset = "0x464B948", VA = "0x464F948")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x464D9B0", Offset = "0x46499B0", VA = "0x464D9B0")]
		public void RefreshName()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x4657BFC", Offset = "0x4653BFC", VA = "0x4657BFC")]
		private void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x4657C38", Offset = "0x4653C38", VA = "0x4657C38")]
		private void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x4657C6C", Offset = "0x4653C6C", VA = "0x4657C6C")]
		public HierarchyField()
		{
		}
	}
}
