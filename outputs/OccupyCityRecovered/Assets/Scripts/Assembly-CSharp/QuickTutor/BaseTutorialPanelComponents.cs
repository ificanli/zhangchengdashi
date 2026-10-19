using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine.UI;

namespace QuickTutor
{
	[Token(Token = "0x2000C99")]
	public class BaseTutorialPanelComponents : UIPanel, IUIPanelComponents
	{
		[Token(Token = "0x4005A80")]
		[FieldOffset(Offset = "0x40")]
		private Image _imageMaskImg;

		[Token(Token = "0x4005A81")]
		[FieldOffset(Offset = "0x48")]
		private Image _imageHand;

		[Token(Token = "0x4005A82")]
		[FieldOffset(Offset = "0x50")]
		private Image _imageIntroContent;

		[Token(Token = "0x4005A83")]
		[FieldOffset(Offset = "0x58")]
		private Image _imageRoleHeadBack;

		[Token(Token = "0x4005A84")]
		[FieldOffset(Offset = "0x60")]
		private Image _imageIntroBack;

		[Token(Token = "0x4005A85")]
		[FieldOffset(Offset = "0x68")]
		private Button _buttonIntroBack;

		[Token(Token = "0x4005A86")]
		[FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUIIntroText;

		[Token(Token = "0x4005A87")]
		[FieldOffset(Offset = "0x78")]
		private Image _imageNextStep;

		[Token(Token = "0x17000E16")]
		public Image ImageMaskImg
		{
			[Token(Token = "0x6004F0F")]
			[Address(RVA = "0x42B0C80", Offset = "0x42ACC80", VA = "0x42B0C80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E17")]
		public Image ImageHand
		{
			[Token(Token = "0x6004F10")]
			[Address(RVA = "0x42B0A28", Offset = "0x42ACA28", VA = "0x42B0A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E18")]
		public Image ImageIntroContent
		{
			[Token(Token = "0x6004F11")]
			[Address(RVA = "0x42B0BB8", Offset = "0x42ACBB8", VA = "0x42B0BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E19")]
		public Image ImageRoleHeadBack
		{
			[Token(Token = "0x6004F12")]
			[Address(RVA = "0x42B2EA8", Offset = "0x42AEEA8", VA = "0x42B2EA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E1A")]
		public Image ImageIntroBack
		{
			[Token(Token = "0x6004F13")]
			[Address(RVA = "0x42B0AF0", Offset = "0x42ACAF0", VA = "0x42B0AF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E1B")]
		public Button ButtonIntroBack
		{
			[Token(Token = "0x6004F14")]
			[Address(RVA = "0x42B2F70", Offset = "0x42AEF70", VA = "0x42B2F70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E1C")]
		public TextMeshProUGUI TextMeshProUGUIIntroText
		{
			[Token(Token = "0x6004F15")]
			[Address(RVA = "0x42B2A5C", Offset = "0x42AEA5C", VA = "0x42B2A5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000E1D")]
		public Image ImageNextStep
		{
			[Token(Token = "0x6004F16")]
			[Address(RVA = "0x42B2B24", Offset = "0x42AEB24", VA = "0x42B2B24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004F17")]
		[Address(RVA = "0x42B3038", Offset = "0x42AF038", VA = "0x42B3038")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6004F18")]
		[Address(RVA = "0x42B30C0", Offset = "0x42AF0C0", VA = "0x42B30C0", Slot = "12")]
		protected virtual void OnButtonIntroBackClicked()
		{
		}

		[Token(Token = "0x6004F19")]
		[Address(RVA = "0x42B312C", Offset = "0x42AF12C", VA = "0x42B312C", Slot = "13")]
		public virtual void Init()
		{
		}

		[Token(Token = "0x6004F1A")]
		[Address(RVA = "0x42B2DF4", Offset = "0x42AEDF4", VA = "0x42B2DF4")]
		public BaseTutorialPanelComponents()
		{
		}
	}
}
