using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000843")]
	public class HeroCardViewComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000844")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__787 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HeroCardViewComponents _003C_003E4__this;

			[Token(Token = "0x4003F0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002E8E")]
			[Address(RVA = "0x4021CB8", Offset = "0x401DCB8", VA = "0x4021CB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002E8F")]
			[Address(RVA = "0x4021F30", Offset = "0x401DF30", VA = "0x4021F30", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003ED2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformBottom;

		[Token(Token = "0x4003ED3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtAllCard;

		[Token(Token = "0x4003ED4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ScrollRect _scrollRectAllCardScrollView;

		[Token(Token = "0x4003ED5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformAllCardContent;

		[Token(Token = "0x4003ED6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendBtnCardDeck1;

		[Token(Token = "0x4003ED7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageImgBtnDeckBanner1;

		[Token(Token = "0x4003ED8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendBtnCardDeck2;

		[Token(Token = "0x4003ED9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageImgBtnDeckBanner2;

		[Token(Token = "0x4003EDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ButtonExtend _buttonExtendBtnCardDeck3;

		[Token(Token = "0x4003EDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgBtnDeckBanner3;

		[Token(Token = "0x4003EDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ButtonExtend _buttonExtendBtnCardDeck4;

		[Token(Token = "0x4003EDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgBtnDeckBanner4;

		[Token(Token = "0x4003EDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ButtonExtend _buttonExtendBtnCardDeck5;

		[Token(Token = "0x4003EDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _imageImgBtnDeckBanner5;

		[Token(Token = "0x4003EE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtDeck;

		[Token(Token = "0x4003EE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ScrollRect _scrollRectEquipScrollView;

		[Token(Token = "0x4003EE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private RectTransform _rectTransformEquipContent;

		[Token(Token = "0x4003EE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUITxtAllBattleNum;

		[Token(Token = "0x4003EE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RectTransform _rectTransformBtnTerran;

		[Token(Token = "0x4003EE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Image _imageBtnTerran;

		[Token(Token = "0x4003EE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ButtonExtend _buttonExtendBtnTerran;

		[Token(Token = "0x4003EE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private TextMeshProUGUI _textMeshProUGUITxtTerranCount;

		[Token(Token = "0x4003EE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RectTransform _rectTransformBtnOrcs;

		[Token(Token = "0x4003EE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Image _imageBtnOrcs;

		[Token(Token = "0x4003EEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ButtonExtend _buttonExtendBtnOrcs;

		[Token(Token = "0x4003EEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TextMeshProUGUI _textMeshProUGUITxtOrcsCount;

		[Token(Token = "0x4003EEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private RectTransform _rectTransformBtnUndead;

		[Token(Token = "0x4003EED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Image _imageBtnUndead;

		[Token(Token = "0x4003EEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ButtonExtend _buttonExtendBtnUndead;

		[Token(Token = "0x4003EEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private TextMeshProUGUI _textMeshProUGUITxtUndeadCount;

		[Token(Token = "0x4003EF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private RectTransform _rectTransformBtnMachine;

		[Token(Token = "0x4003EF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Image _imageBtnMachine;

		[Token(Token = "0x4003EF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private ButtonExtend _buttonExtendBtnMachine;

		[Token(Token = "0x4003EF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private TextMeshProUGUI _textMeshProUGUITxtMachineCount;

		[Token(Token = "0x4003EF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private RectTransform _rectTransformBtnMelee;

		[Token(Token = "0x4003EF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Image _imageBtnMelee;

		[Token(Token = "0x4003EF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private ButtonExtend _buttonExtendBtnMelee;

		[Token(Token = "0x4003EF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private TextMeshProUGUI _textMeshProUGUITxtMeleeCount;

		[Token(Token = "0x4003EF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private RectTransform _rectTransformBtnRemote;

		[Token(Token = "0x4003EF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Image _imageBtnRemote;

		[Token(Token = "0x4003EFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private ButtonExtend _buttonExtendBtnRemote;

		[Token(Token = "0x4003EFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private TextMeshProUGUI _textMeshProUGUITxtRemoteCount;

		[Token(Token = "0x4003EFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private RectTransform _rectTransformIntroBack;

		[Token(Token = "0x4003EFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private TextMeshProUGUI _textMeshProUGUITxtFetterTitle;

		[Token(Token = "0x4003EFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private RectTransform _rectTransformIntroText;

		[Token(Token = "0x4003EFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private TextMeshProUGUI _textMeshProUGUIIntroText;

		[Token(Token = "0x4003F00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private RectTransform _rectTransformFetterCardShowImgRoot;

		[Token(Token = "0x4003F01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private RectTransform _rectTransformHideInterface;

		[Token(Token = "0x4003F02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private TextMeshProUGUI _textMeshProUGUITxtReplaceDes;

		[Token(Token = "0x4003F03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Image _imageImgCardBG;

		[Token(Token = "0x4003F04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Image _imageImgType;

		[Token(Token = "0x4003F05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Image _imageImgCardIcon;

		[Token(Token = "0x4003F06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private TextMeshProUGUI _textMeshProUGUITxtCardLevel;

		[Token(Token = "0x4003F07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Image _imageImgProcess;

		[Token(Token = "0x4003F08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private TextMeshProUGUI _textMeshProUGUITxtCardCount;

		[Token(Token = "0x4003F09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private ButtonExtend _buttonExtendBtnCancel;

		[Token(Token = "0x17000533")]
		public RectTransform RectTransformBottom
		{
			[Token(Token = "0x6002E42")]
			[Address(RVA = "0x401B098", Offset = "0x4017098", VA = "0x401B098")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000534")]
		public TextMeshProUGUI TextMeshProUGUITxtAllCard
		{
			[Token(Token = "0x6002E43")]
			[Address(RVA = "0x401BF04", Offset = "0x4017F04", VA = "0x401BF04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000535")]
		public ScrollRect ScrollRectAllCardScrollView
		{
			[Token(Token = "0x6002E44")]
			[Address(RVA = "0x401FB80", Offset = "0x401BB80", VA = "0x401FB80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000536")]
		public RectTransform RectTransformAllCardContent
		{
			[Token(Token = "0x6002E45")]
			[Address(RVA = "0x401D720", Offset = "0x4019720", VA = "0x401D720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000537")]
		public ButtonExtend ButtonExtendBtnCardDeck1
		{
			[Token(Token = "0x6002E46")]
			[Address(RVA = "0x401FC48", Offset = "0x401BC48", VA = "0x401FC48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000538")]
		public Image ImageImgBtnDeckBanner1
		{
			[Token(Token = "0x6002E47")]
			[Address(RVA = "0x401FD10", Offset = "0x401BD10", VA = "0x401FD10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000539")]
		public ButtonExtend ButtonExtendBtnCardDeck2
		{
			[Token(Token = "0x6002E48")]
			[Address(RVA = "0x401FDD8", Offset = "0x401BDD8", VA = "0x401FDD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053A")]
		public Image ImageImgBtnDeckBanner2
		{
			[Token(Token = "0x6002E49")]
			[Address(RVA = "0x401FEA0", Offset = "0x401BEA0", VA = "0x401FEA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053B")]
		public ButtonExtend ButtonExtendBtnCardDeck3
		{
			[Token(Token = "0x6002E4A")]
			[Address(RVA = "0x401FF68", Offset = "0x401BF68", VA = "0x401FF68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053C")]
		public Image ImageImgBtnDeckBanner3
		{
			[Token(Token = "0x6002E4B")]
			[Address(RVA = "0x4020030", Offset = "0x401C030", VA = "0x4020030")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053D")]
		public ButtonExtend ButtonExtendBtnCardDeck4
		{
			[Token(Token = "0x6002E4C")]
			[Address(RVA = "0x40200F8", Offset = "0x401C0F8", VA = "0x40200F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053E")]
		public Image ImageImgBtnDeckBanner4
		{
			[Token(Token = "0x6002E4D")]
			[Address(RVA = "0x40201C0", Offset = "0x401C1C0", VA = "0x40201C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700053F")]
		public ButtonExtend ButtonExtendBtnCardDeck5
		{
			[Token(Token = "0x6002E4E")]
			[Address(RVA = "0x4020288", Offset = "0x401C288", VA = "0x4020288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000540")]
		public Image ImageImgBtnDeckBanner5
		{
			[Token(Token = "0x6002E4F")]
			[Address(RVA = "0x4020350", Offset = "0x401C350", VA = "0x4020350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000541")]
		public TextMeshProUGUI TextMeshProUGUITxtDeck
		{
			[Token(Token = "0x6002E50")]
			[Address(RVA = "0x401BE3C", Offset = "0x4017E3C", VA = "0x401BE3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000542")]
		public ScrollRect ScrollRectEquipScrollView
		{
			[Token(Token = "0x6002E51")]
			[Address(RVA = "0x4020418", Offset = "0x401C418", VA = "0x4020418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000543")]
		public RectTransform RectTransformEquipContent
		{
			[Token(Token = "0x6002E52")]
			[Address(RVA = "0x401D658", Offset = "0x4019658", VA = "0x401D658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000544")]
		public TextMeshProUGUI TextMeshProUGUITxtAllBattleNum
		{
			[Token(Token = "0x6002E53")]
			[Address(RVA = "0x40204E0", Offset = "0x401C4E0", VA = "0x40204E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000545")]
		public RectTransform RectTransformBtnTerran
		{
			[Token(Token = "0x6002E54")]
			[Address(RVA = "0x40205A8", Offset = "0x401C5A8", VA = "0x40205A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000546")]
		public Image ImageBtnTerran
		{
			[Token(Token = "0x6002E55")]
			[Address(RVA = "0x401EF98", Offset = "0x401AF98", VA = "0x401EF98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000547")]
		public ButtonExtend ButtonExtendBtnTerran
		{
			[Token(Token = "0x6002E56")]
			[Address(RVA = "0x4020670", Offset = "0x401C670", VA = "0x4020670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000548")]
		public TextMeshProUGUI TextMeshProUGUITxtTerranCount
		{
			[Token(Token = "0x6002E57")]
			[Address(RVA = "0x401EAE8", Offset = "0x401AAE8", VA = "0x401EAE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000549")]
		public RectTransform RectTransformBtnOrcs
		{
			[Token(Token = "0x6002E58")]
			[Address(RVA = "0x4020738", Offset = "0x401C738", VA = "0x4020738")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054A")]
		public Image ImageBtnOrcs
		{
			[Token(Token = "0x6002E59")]
			[Address(RVA = "0x401EE08", Offset = "0x401AE08", VA = "0x401EE08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054B")]
		public ButtonExtend ButtonExtendBtnOrcs
		{
			[Token(Token = "0x6002E5A")]
			[Address(RVA = "0x4020800", Offset = "0x401C800", VA = "0x4020800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054C")]
		public TextMeshProUGUI TextMeshProUGUITxtOrcsCount
		{
			[Token(Token = "0x6002E5B")]
			[Address(RVA = "0x401E958", Offset = "0x401A958", VA = "0x401E958")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054D")]
		public RectTransform RectTransformBtnUndead
		{
			[Token(Token = "0x6002E5C")]
			[Address(RVA = "0x40208C8", Offset = "0x401C8C8", VA = "0x40208C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054E")]
		public Image ImageBtnUndead
		{
			[Token(Token = "0x6002E5D")]
			[Address(RVA = "0x401EED0", Offset = "0x401AED0", VA = "0x401EED0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054F")]
		public ButtonExtend ButtonExtendBtnUndead
		{
			[Token(Token = "0x6002E5E")]
			[Address(RVA = "0x4020990", Offset = "0x401C990", VA = "0x4020990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000550")]
		public TextMeshProUGUI TextMeshProUGUITxtUndeadCount
		{
			[Token(Token = "0x6002E5F")]
			[Address(RVA = "0x401EA20", Offset = "0x401AA20", VA = "0x401EA20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000551")]
		public RectTransform RectTransformBtnMachine
		{
			[Token(Token = "0x6002E60")]
			[Address(RVA = "0x4020A58", Offset = "0x401CA58", VA = "0x4020A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000552")]
		public Image ImageBtnMachine
		{
			[Token(Token = "0x6002E61")]
			[Address(RVA = "0x401F060", Offset = "0x401B060", VA = "0x401F060")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000553")]
		public ButtonExtend ButtonExtendBtnMachine
		{
			[Token(Token = "0x6002E62")]
			[Address(RVA = "0x4020B20", Offset = "0x401CB20", VA = "0x4020B20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000554")]
		public TextMeshProUGUI TextMeshProUGUITxtMachineCount
		{
			[Token(Token = "0x6002E63")]
			[Address(RVA = "0x401ED40", Offset = "0x401AD40", VA = "0x401ED40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000555")]
		public RectTransform RectTransformBtnMelee
		{
			[Token(Token = "0x6002E64")]
			[Address(RVA = "0x4020BE8", Offset = "0x401CBE8", VA = "0x4020BE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000556")]
		public Image ImageBtnMelee
		{
			[Token(Token = "0x6002E65")]
			[Address(RVA = "0x401F128", Offset = "0x401B128", VA = "0x401F128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000557")]
		public ButtonExtend ButtonExtendBtnMelee
		{
			[Token(Token = "0x6002E66")]
			[Address(RVA = "0x4020CB0", Offset = "0x401CCB0", VA = "0x4020CB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000558")]
		public TextMeshProUGUI TextMeshProUGUITxtMeleeCount
		{
			[Token(Token = "0x6002E67")]
			[Address(RVA = "0x401EBB0", Offset = "0x401ABB0", VA = "0x401EBB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000559")]
		public RectTransform RectTransformBtnRemote
		{
			[Token(Token = "0x6002E68")]
			[Address(RVA = "0x4020D78", Offset = "0x401CD78", VA = "0x4020D78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055A")]
		public Image ImageBtnRemote
		{
			[Token(Token = "0x6002E69")]
			[Address(RVA = "0x401F1F0", Offset = "0x401B1F0", VA = "0x401F1F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055B")]
		public ButtonExtend ButtonExtendBtnRemote
		{
			[Token(Token = "0x6002E6A")]
			[Address(RVA = "0x4020E40", Offset = "0x401CE40", VA = "0x4020E40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055C")]
		public TextMeshProUGUI TextMeshProUGUITxtRemoteCount
		{
			[Token(Token = "0x6002E6B")]
			[Address(RVA = "0x401EC78", Offset = "0x401AC78", VA = "0x401EC78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055D")]
		public RectTransform RectTransformIntroBack
		{
			[Token(Token = "0x6002E6C")]
			[Address(RVA = "0x4019BE8", Offset = "0x4015BE8", VA = "0x4019BE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055E")]
		public TextMeshProUGUI TextMeshProUGUITxtFetterTitle
		{
			[Token(Token = "0x6002E6D")]
			[Address(RVA = "0x401FAAC", Offset = "0x401BAAC", VA = "0x401FAAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055F")]
		public RectTransform RectTransformIntroText
		{
			[Token(Token = "0x6002E6E")]
			[Address(RVA = "0x4019CB0", Offset = "0x4015CB0", VA = "0x4019CB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000560")]
		public TextMeshProUGUI TextMeshProUGUIIntroText
		{
			[Token(Token = "0x6002E6F")]
			[Address(RVA = "0x4020F08", Offset = "0x401CF08", VA = "0x4020F08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000561")]
		public RectTransform RectTransformFetterCardShowImgRoot
		{
			[Token(Token = "0x6002E70")]
			[Address(RVA = "0x401A4D0", Offset = "0x40164D0", VA = "0x401A4D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000562")]
		public RectTransform RectTransformHideInterface
		{
			[Token(Token = "0x6002E71")]
			[Address(RVA = "0x401B160", Offset = "0x4017160", VA = "0x401B160")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000563")]
		public TextMeshProUGUI TextMeshProUGUITxtReplaceDes
		{
			[Token(Token = "0x6002E72")]
			[Address(RVA = "0x401BFCC", Offset = "0x4017FCC", VA = "0x401BFCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000564")]
		public Image ImageImgCardBG
		{
			[Token(Token = "0x6002E73")]
			[Address(RVA = "0x401B3B8", Offset = "0x40173B8", VA = "0x401B3B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000565")]
		public Image ImageImgType
		{
			[Token(Token = "0x6002E74")]
			[Address(RVA = "0x401B2F0", Offset = "0x40172F0", VA = "0x401B2F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000566")]
		public Image ImageImgCardIcon
		{
			[Token(Token = "0x6002E75")]
			[Address(RVA = "0x401B228", Offset = "0x4017228", VA = "0x401B228")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000567")]
		public TextMeshProUGUI TextMeshProUGUITxtCardLevel
		{
			[Token(Token = "0x6002E76")]
			[Address(RVA = "0x401B480", Offset = "0x4017480", VA = "0x401B480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000568")]
		public Image ImageImgProcess
		{
			[Token(Token = "0x6002E77")]
			[Address(RVA = "0x401B610", Offset = "0x4017610", VA = "0x401B610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000569")]
		public TextMeshProUGUI TextMeshProUGUITxtCardCount
		{
			[Token(Token = "0x6002E78")]
			[Address(RVA = "0x401B548", Offset = "0x4017548", VA = "0x401B548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700056A")]
		public ButtonExtend ButtonExtendBtnCancel
		{
			[Token(Token = "0x6002E79")]
			[Address(RVA = "0x4020FD0", Offset = "0x401CFD0", VA = "0x4020FD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002E7A")]
		[Address(RVA = "0x4021098", Offset = "0x401D098", VA = "0x4021098")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002E7B")]
		[Address(RVA = "0x40214CC", Offset = "0x401D4CC", VA = "0x40214CC", Slot = "12")]
		protected virtual void OnScrollRectAllCardScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6002E7C")]
		[Address(RVA = "0x4021580", Offset = "0x401D580", VA = "0x4021580", Slot = "13")]
		protected virtual void OnButtonExtendBtnCardDeck1Clicked()
		{
		}

		[Token(Token = "0x6002E7D")]
		[Address(RVA = "0x40215EC", Offset = "0x401D5EC", VA = "0x40215EC", Slot = "14")]
		protected virtual void OnButtonExtendBtnCardDeck2Clicked()
		{
		}

		[Token(Token = "0x6002E7E")]
		[Address(RVA = "0x4021658", Offset = "0x401D658", VA = "0x4021658", Slot = "15")]
		protected virtual void OnButtonExtendBtnCardDeck3Clicked()
		{
		}

		[Token(Token = "0x6002E7F")]
		[Address(RVA = "0x40216C4", Offset = "0x401D6C4", VA = "0x40216C4", Slot = "16")]
		protected virtual void OnButtonExtendBtnCardDeck4Clicked()
		{
		}

		[Token(Token = "0x6002E80")]
		[Address(RVA = "0x4021730", Offset = "0x401D730", VA = "0x4021730", Slot = "17")]
		protected virtual void OnButtonExtendBtnCardDeck5Clicked()
		{
		}

		[Token(Token = "0x6002E81")]
		[Address(RVA = "0x402179C", Offset = "0x401D79C", VA = "0x402179C", Slot = "18")]
		protected virtual void OnScrollRectEquipScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6002E82")]
		[Address(RVA = "0x4021850", Offset = "0x401D850", VA = "0x4021850", Slot = "19")]
		protected virtual void OnButtonExtendBtnTerranClicked()
		{
		}

		[Token(Token = "0x6002E83")]
		[Address(RVA = "0x40218BC", Offset = "0x401D8BC", VA = "0x40218BC", Slot = "20")]
		protected virtual void OnButtonExtendBtnOrcsClicked()
		{
		}

		[Token(Token = "0x6002E84")]
		[Address(RVA = "0x4021928", Offset = "0x401D928", VA = "0x4021928", Slot = "21")]
		protected virtual void OnButtonExtendBtnUndeadClicked()
		{
		}

		[Token(Token = "0x6002E85")]
		[Address(RVA = "0x4021994", Offset = "0x401D994", VA = "0x4021994", Slot = "22")]
		protected virtual void OnButtonExtendBtnMachineClicked()
		{
		}

		[Token(Token = "0x6002E86")]
		[Address(RVA = "0x4021A00", Offset = "0x401DA00", VA = "0x4021A00", Slot = "23")]
		protected virtual void OnButtonExtendBtnMeleeClicked()
		{
		}

		[Token(Token = "0x6002E87")]
		[Address(RVA = "0x4021A6C", Offset = "0x401DA6C", VA = "0x4021A6C", Slot = "24")]
		protected virtual void OnButtonExtendBtnRemoteClicked()
		{
		}

		[Token(Token = "0x6002E88")]
		[Address(RVA = "0x4021AD8", Offset = "0x401DAD8", VA = "0x4021AD8", Slot = "25")]
		protected virtual void OnButtonExtendBtnCancelClicked()
		{
		}

		[Token(Token = "0x6002E89")]
		[Address(RVA = "0x4021B44", Offset = "0x401DB44", VA = "0x4021B44", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002E8A")]
		[Address(RVA = "0x4021B60", Offset = "0x401DB60", VA = "0x4021B60", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__787))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002E8B")]
		[Address(RVA = "0x4021BF4", Offset = "0x401DBF4", VA = "0x4021BF4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002E8C")]
		[Address(RVA = "0x4021CA8", Offset = "0x401DCA8", VA = "0x4021CA8")]
		public HeroCardViewComponents()
		{
		}
	}
}
