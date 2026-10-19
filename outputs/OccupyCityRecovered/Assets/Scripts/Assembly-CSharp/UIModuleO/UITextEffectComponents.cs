using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x2000BD1")]
	public class UITextEffectComponents : UIPanel, IUIPanelComponents
	{
		[Token(Token = "0x40055CD")]
		[FieldOffset(Offset = "0x40")]
		private RectTransform _uITextEffectRect;

		[Token(Token = "0x40055CE")]
		[FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textText;

		[Token(Token = "0x17000CAA")]
		protected RectTransform UITextEffectRect
		{
			[Token(Token = "0x60048EF")]
			[Address(RVA = "0x423FC04", Offset = "0x423BC04", VA = "0x423FC04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000CAB")]
		protected TextMeshProUGUI TextText
		{
			[Token(Token = "0x60048F0")]
			[Address(RVA = "0x423FCA8", Offset = "0x423BCA8", VA = "0x423FCA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60048F1")]
		[Address(RVA = "0x423FA34", Offset = "0x423BA34", VA = "0x423FA34", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60048F2")]
		[Address(RVA = "0x42400B4", Offset = "0x423C0B4", VA = "0x42400B4")]
		public UITextEffectComponents()
		{
		}
	}
}
