using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000076")]
	[CreateAssetMenu(fileName = "UI Skin", menuName = "yasirkula/RuntimeInspector/UI Skin", order = 111)]
	public class UISkin : ScriptableObject
	{
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x18")]
		private int m_version;

		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Font m_font;

		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_fontSize;

		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int m_lineHeight;

		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int m_indentAmount;

		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_labelWidthPercentage;

		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_expandArrowSpacing;

		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Color m_windowColor;

		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Color m_backgroundColor;

		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Color m_textColor;

		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Color m_scrollbarColor;

		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Color m_expandArrowColor;

		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Color m_inputFieldNormalBackgroundColor;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private Color m_inputFieldInvalidBackgroundColor;

		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private Color m_inputFieldTextColor;

		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private Color m_toggleCheckmarkColor;

		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private Color m_sliderBackgroundColor;

		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private Color m_sliderThumbColor;

		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private Color m_buttonBackgroundColor;

		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private Color m_buttonTextColor;

		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private Color m_selectedItemBackgroundColor;

		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private Color m_selectedItemTextColor;

		[Token(Token = "0x170000C2")]
		public int Version
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x467B2B8", Offset = "0x46772B8", VA = "0x467B2B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000C3")]
		public Font Font
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x467B2E4", Offset = "0x46772E4", VA = "0x467B2E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x467B2EC", Offset = "0x46772EC", VA = "0x467B2EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public int FontSize
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x467B370", Offset = "0x4677370", VA = "0x467B370")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x467B378", Offset = "0x4677378", VA = "0x467B378")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public int LineHeight
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x467B398", Offset = "0x4677398", VA = "0x467B398")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x467B3A0", Offset = "0x46773A0", VA = "0x467B3A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public int IndentAmount
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x467B3C0", Offset = "0x46773C0", VA = "0x467B3C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x467B3C8", Offset = "0x46773C8", VA = "0x467B3C8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public float LabelWidthPercentage
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x467B3E8", Offset = "0x46773E8", VA = "0x467B3E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x467B3F0", Offset = "0x46773F0", VA = "0x467B3F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public float ExpandArrowSpacing
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x467B414", Offset = "0x4677414", VA = "0x467B414")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x467B41C", Offset = "0x467741C", VA = "0x467B41C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public Color WindowColor
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x467B440", Offset = "0x4677440", VA = "0x467B440")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x467B44C", Offset = "0x467744C", VA = "0x467B44C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public Color BackgroundColor
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x467B4A8", Offset = "0x46774A8", VA = "0x467B4A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x467B4B4", Offset = "0x46774B4", VA = "0x467B4B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public Color TextColor
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x467B510", Offset = "0x4677510", VA = "0x467B510")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x467B51C", Offset = "0x467751C", VA = "0x467B51C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public Color ScrollbarColor
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x467B578", Offset = "0x4677578", VA = "0x467B578")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x467B584", Offset = "0x4677584", VA = "0x467B584")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public Color ExpandArrowColor
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x467B5E0", Offset = "0x46775E0", VA = "0x467B5E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x467B5EC", Offset = "0x46775EC", VA = "0x467B5EC")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public Color InputFieldNormalBackgroundColor
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x467B648", Offset = "0x4677648", VA = "0x467B648")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x467B654", Offset = "0x4677654", VA = "0x467B654")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public Color InputFieldInvalidBackgroundColor
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x467B6B0", Offset = "0x46776B0", VA = "0x467B6B0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x467B6BC", Offset = "0x46776BC", VA = "0x467B6BC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public Color InputFieldTextColor
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x467B718", Offset = "0x4677718", VA = "0x467B718")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x467B724", Offset = "0x4677724", VA = "0x467B724")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public Color ToggleCheckmarkColor
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x467B780", Offset = "0x4677780", VA = "0x467B780")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x467B78C", Offset = "0x467778C", VA = "0x467B78C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public Color SliderBackgroundColor
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x467B7E8", Offset = "0x46777E8", VA = "0x467B7E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x467B7F4", Offset = "0x46777F4", VA = "0x467B7F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public Color SliderThumbColor
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x467B850", Offset = "0x4677850", VA = "0x467B850")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x467B85C", Offset = "0x467785C", VA = "0x467B85C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public Color ButtonBackgroundColor
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x467B8B8", Offset = "0x46778B8", VA = "0x467B8B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x467B8C4", Offset = "0x46778C4", VA = "0x467B8C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public Color ButtonTextColor
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x467B920", Offset = "0x4677920", VA = "0x467B920")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x467B930", Offset = "0x4677930", VA = "0x467B930")]
			set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public Color SelectedItemBackgroundColor
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x467B994", Offset = "0x4677994", VA = "0x467B994")]
			get
			{
				return default;
			}
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x467B9A8", Offset = "0x46779A8", VA = "0x467B9A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public Color SelectedItemTextColor
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x467BA14", Offset = "0x4677A14", VA = "0x467BA14")]
			get
			{
				return default;
			}
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x467BA28", Offset = "0x4677A28", VA = "0x467BA28")]
			set
			{
			}
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x467B2C0", Offset = "0x46772C0", VA = "0x467B2C0")]
		[ContextMenu("Refresh UI")]
		private void Invalidate()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x467BA94", Offset = "0x4677A94", VA = "0x467BA94")]
		public UISkin()
		{
		}
	}
}
