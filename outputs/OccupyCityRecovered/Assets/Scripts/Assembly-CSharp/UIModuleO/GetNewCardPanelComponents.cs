using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20008DB")]
	public class GetNewCardPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008DC")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__201 : IAsyncStateMachine
		{
			[Token(Token = "0x400431C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400431D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400431E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GetNewCardPanelComponents _003C_003E4__this;

			[Token(Token = "0x400431F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60032F5")]
			[Address(RVA = "0x4091C40", Offset = "0x408DC40", VA = "0x4091C40", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60032F6")]
			[Address(RVA = "0x4091EB8", Offset = "0x408DEB8", VA = "0x4091EB8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400430C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBG;

		[Token(Token = "0x400430D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformTxtNewCard;

		[Token(Token = "0x400430E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtNewCard;

		[Token(Token = "0x400430F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgCardEff;

		[Token(Token = "0x4004310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformLightSkeletonGraphicRoot;

		[Token(Token = "0x4004311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageImgCardIcon;

		[Token(Token = "0x4004312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RectTransform _rectTransformImgBG;

		[Token(Token = "0x4004313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtName;

		[Token(Token = "0x4004314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtCardRare;

		[Token(Token = "0x4004315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgAtkWayTypeIcon;

		[Token(Token = "0x4004316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtAtkWayType;

		[Token(Token = "0x4004317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgFetterIcon;

		[Token(Token = "0x4004318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtFetter;

		[Token(Token = "0x4004319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RectTransform _rectTransformImgPropetryBG;

		[Token(Token = "0x400431A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RectTransform _rectTransformTxtTapToContinue;

		[Token(Token = "0x400431B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtTapToContinue;

		[Token(Token = "0x170006B1")]
		public Button ButtonBG
		{
			[Token(Token = "0x60032DE")]
			[Address(RVA = "0x4090D58", Offset = "0x408CD58", VA = "0x4090D58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B2")]
		public RectTransform RectTransformTxtNewCard
		{
			[Token(Token = "0x60032DF")]
			[Address(RVA = "0x4090E20", Offset = "0x408CE20", VA = "0x4090E20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B3")]
		public TextMeshProUGUI TextMeshProUGUITxtNewCard
		{
			[Token(Token = "0x60032E0")]
			[Address(RVA = "0x4090EE8", Offset = "0x408CEE8", VA = "0x4090EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B4")]
		public Image ImageImgCardEff
		{
			[Token(Token = "0x60032E1")]
			[Address(RVA = "0x4090FB0", Offset = "0x408CFB0", VA = "0x4090FB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B5")]
		public RectTransform RectTransformLightSkeletonGraphicRoot
		{
			[Token(Token = "0x60032E2")]
			[Address(RVA = "0x4091078", Offset = "0x408D078", VA = "0x4091078")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B6")]
		public Image ImageImgCardIcon
		{
			[Token(Token = "0x60032E3")]
			[Address(RVA = "0x4091140", Offset = "0x408D140", VA = "0x4091140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B7")]
		public RectTransform RectTransformImgBG
		{
			[Token(Token = "0x60032E4")]
			[Address(RVA = "0x4091208", Offset = "0x408D208", VA = "0x4091208")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B8")]
		public TextMeshProUGUI TextMeshProUGUITxtName
		{
			[Token(Token = "0x60032E5")]
			[Address(RVA = "0x40912D0", Offset = "0x408D2D0", VA = "0x40912D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B9")]
		public TextMeshProUGUI TextMeshProUGUITxtCardRare
		{
			[Token(Token = "0x60032E6")]
			[Address(RVA = "0x4091398", Offset = "0x408D398", VA = "0x4091398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006BA")]
		public Image ImageImgAtkWayTypeIcon
		{
			[Token(Token = "0x60032E7")]
			[Address(RVA = "0x4091460", Offset = "0x408D460", VA = "0x4091460")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006BB")]
		public TextMeshProUGUI TextMeshProUGUITxtAtkWayType
		{
			[Token(Token = "0x60032E8")]
			[Address(RVA = "0x4091528", Offset = "0x408D528", VA = "0x4091528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006BC")]
		public Image ImageImgFetterIcon
		{
			[Token(Token = "0x60032E9")]
			[Address(RVA = "0x40915F0", Offset = "0x408D5F0", VA = "0x40915F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006BD")]
		public TextMeshProUGUI TextMeshProUGUITxtFetter
		{
			[Token(Token = "0x60032EA")]
			[Address(RVA = "0x40916B8", Offset = "0x408D6B8", VA = "0x40916B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006BE")]
		public RectTransform RectTransformImgPropetryBG
		{
			[Token(Token = "0x60032EB")]
			[Address(RVA = "0x4091780", Offset = "0x408D780", VA = "0x4091780")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006BF")]
		public RectTransform RectTransformTxtTapToContinue
		{
			[Token(Token = "0x60032EC")]
			[Address(RVA = "0x4091848", Offset = "0x408D848", VA = "0x4091848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C0")]
		public TextMeshProUGUI TextMeshProUGUITxtTapToContinue
		{
			[Token(Token = "0x60032ED")]
			[Address(RVA = "0x4091910", Offset = "0x408D910", VA = "0x4091910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60032EE")]
		[Address(RVA = "0x40919D8", Offset = "0x408D9D8", VA = "0x40919D8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60032EF")]
		[Address(RVA = "0x4091A60", Offset = "0x408DA60", VA = "0x4091A60", Slot = "12")]
		protected virtual void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x60032F0")]
		[Address(RVA = "0x4091ACC", Offset = "0x408DACC", VA = "0x4091ACC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60032F1")]
		[Address(RVA = "0x4091AE8", Offset = "0x408DAE8", VA = "0x4091AE8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__201))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60032F2")]
		[Address(RVA = "0x4091B7C", Offset = "0x408DB7C", VA = "0x4091B7C", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60032F3")]
		[Address(RVA = "0x4091C30", Offset = "0x408DC30", VA = "0x4091C30")]
		public GetNewCardPanelComponents()
		{
		}
	}
}
