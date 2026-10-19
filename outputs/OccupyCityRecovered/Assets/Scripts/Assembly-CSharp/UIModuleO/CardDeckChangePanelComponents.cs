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
	[Token(Token = "0x2000797")]
	public class CardDeckChangePanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000798")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__561 : IAsyncStateMachine
		{
			[Token(Token = "0x4003B08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003B09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003B0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CardDeckChangePanelComponents _003C_003E4__this;

			[Token(Token = "0x4003B0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60029FF")]
			[Address(RVA = "0x3FCD1A4", Offset = "0x3FC91A4", VA = "0x3FCD1A4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002A00")]
			[Address(RVA = "0x3FCD41C", Offset = "0x3FC941C", VA = "0x3FCD41C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Button _buttonBg;

		[Token(Token = "0x4003AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformTop;

		[Token(Token = "0x4003AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ScrollRect _scrollRectEquipScrollView;

		[Token(Token = "0x4003AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformEquipContent;

		[Token(Token = "0x4003AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformBtnCardDeckRoot;

		[Token(Token = "0x4003ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageBtnCardDeck1;

		[Token(Token = "0x4003ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendBtnCardDeck1;

		[Token(Token = "0x4003ADC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageImgBtnDeckBanner1;

		[Token(Token = "0x4003ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image _imageBtnCardDeck2;

		[Token(Token = "0x4003ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendBtnCardDeck2;

		[Token(Token = "0x4003ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image _imageImgBtnDeckBanner2;

		[Token(Token = "0x4003AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageBtnCardDeck3;

		[Token(Token = "0x4003AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ButtonExtend _buttonExtendBtnCardDeck3;

		[Token(Token = "0x4003AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Image _imageImgBtnDeckBanner3;

		[Token(Token = "0x4003AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Image _imageBtnCardDeck4;

		[Token(Token = "0x4003AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ButtonExtend _buttonExtendBtnCardDeck4;

		[Token(Token = "0x4003AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Image _imageImgBtnDeckBanner4;

		[Token(Token = "0x4003AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Image _imageBtnCardDeck5;

		[Token(Token = "0x4003AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ButtonExtend _buttonExtendBtnCardDeck5;

		[Token(Token = "0x4003AE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Image _imageImgBtnDeckBanner5;

		[Token(Token = "0x4003AE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private TextMeshProUGUI _textMeshProUGUITxtDeck;

		[Token(Token = "0x4003AEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private TextMeshProUGUI _textMeshProUGUITxtAllBattleNum;

		[Token(Token = "0x4003AEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RectTransform _rectTransformBtnTerran;

		[Token(Token = "0x4003AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Image _imageBtnTerran;

		[Token(Token = "0x4003AED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ButtonExtend _buttonExtendBtnTerran;

		[Token(Token = "0x4003AEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TextMeshProUGUI _textMeshProUGUITxtTerranCount;

		[Token(Token = "0x4003AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private RectTransform _rectTransformBtnOrcs;

		[Token(Token = "0x4003AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Image _imageBtnOrcs;

		[Token(Token = "0x4003AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private ButtonExtend _buttonExtendBtnOrcs;

		[Token(Token = "0x4003AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private TextMeshProUGUI _textMeshProUGUITxtOrcsCount;

		[Token(Token = "0x4003AF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private RectTransform _rectTransformBtnUndead;

		[Token(Token = "0x4003AF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Image _imageBtnUndead;

		[Token(Token = "0x4003AF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private ButtonExtend _buttonExtendBtnUndead;

		[Token(Token = "0x4003AF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private TextMeshProUGUI _textMeshProUGUITxtUndeadCount;

		[Token(Token = "0x4003AF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private RectTransform _rectTransformBtnMachine;

		[Token(Token = "0x4003AF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Image _imageBtnMachine;

		[Token(Token = "0x4003AF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private ButtonExtend _buttonExtendBtnMachine;

		[Token(Token = "0x4003AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private TextMeshProUGUI _textMeshProUGUITxtMachineCount;

		[Token(Token = "0x4003AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private RectTransform _rectTransformBtnMelee;

		[Token(Token = "0x4003AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Image _imageBtnMelee;

		[Token(Token = "0x4003AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private ButtonExtend _buttonExtendBtnMelee;

		[Token(Token = "0x4003AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private TextMeshProUGUI _textMeshProUGUITxtMeleeCount;

		[Token(Token = "0x4003AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private RectTransform _rectTransformBtnRemote;

		[Token(Token = "0x4003B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private Image _imageBtnRemote;

		[Token(Token = "0x4003B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private ButtonExtend _buttonExtendBtnRemote;

		[Token(Token = "0x4003B02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private TextMeshProUGUI _textMeshProUGUITxtRemoteCount;

		[Token(Token = "0x4003B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private RectTransform _rectTransformIntroBack;

		[Token(Token = "0x4003B04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private TextMeshProUGUI _textMeshProUGUITxtFetterTitle;

		[Token(Token = "0x4003B05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private RectTransform _rectTransformIntroText;

		[Token(Token = "0x4003B06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private TextMeshProUGUI _textMeshProUGUIIntroText;

		[Token(Token = "0x4003B07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private RectTransform _rectTransformFetterCardShowImgRoot;

		[Token(Token = "0x170003F5")]
		public Button ButtonBg
		{
			[Token(Token = "0x60029B9")]
			[Address(RVA = "0x3FCC680", Offset = "0x3FC8680", VA = "0x3FCC680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F6")]
		public RectTransform RectTransformTop
		{
			[Token(Token = "0x60029BA")]
			[Address(RVA = "0x3FC8F0C", Offset = "0x3FC4F0C", VA = "0x3FC8F0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F7")]
		public ScrollRect ScrollRectEquipScrollView
		{
			[Token(Token = "0x60029BB")]
			[Address(RVA = "0x3FCC748", Offset = "0x3FC8748", VA = "0x3FCC748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F8")]
		public RectTransform RectTransformEquipContent
		{
			[Token(Token = "0x60029BC")]
			[Address(RVA = "0x3FCADC4", Offset = "0x3FC6DC4", VA = "0x3FCADC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003F9")]
		public RectTransform RectTransformBtnCardDeckRoot
		{
			[Token(Token = "0x60029BD")]
			[Address(RVA = "0x3FC665C", Offset = "0x3FC265C", VA = "0x3FC665C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003FA")]
		public Image ImageBtnCardDeck1
		{
			[Token(Token = "0x60029BE")]
			[Address(RVA = "0x3FC513C", Offset = "0x3FC113C", VA = "0x3FC513C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003FB")]
		public ButtonExtend ButtonExtendBtnCardDeck1
		{
			[Token(Token = "0x60029BF")]
			[Address(RVA = "0x3FCC810", Offset = "0x3FC8810", VA = "0x3FCC810")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003FC")]
		public Image ImageImgBtnDeckBanner1
		{
			[Token(Token = "0x60029C0")]
			[Address(RVA = "0x3FC5204", Offset = "0x3FC1204", VA = "0x3FC5204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003FD")]
		public Image ImageBtnCardDeck2
		{
			[Token(Token = "0x60029C1")]
			[Address(RVA = "0x3FC52CC", Offset = "0x3FC12CC", VA = "0x3FC52CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003FE")]
		public ButtonExtend ButtonExtendBtnCardDeck2
		{
			[Token(Token = "0x60029C2")]
			[Address(RVA = "0x3FCC8D8", Offset = "0x3FC88D8", VA = "0x3FCC8D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003FF")]
		public Image ImageImgBtnDeckBanner2
		{
			[Token(Token = "0x60029C3")]
			[Address(RVA = "0x3FC5394", Offset = "0x3FC1394", VA = "0x3FC5394")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000400")]
		public Image ImageBtnCardDeck3
		{
			[Token(Token = "0x60029C4")]
			[Address(RVA = "0x3FC545C", Offset = "0x3FC145C", VA = "0x3FC545C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000401")]
		public ButtonExtend ButtonExtendBtnCardDeck3
		{
			[Token(Token = "0x60029C5")]
			[Address(RVA = "0x3FCC9A0", Offset = "0x3FC89A0", VA = "0x3FCC9A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000402")]
		public Image ImageImgBtnDeckBanner3
		{
			[Token(Token = "0x60029C6")]
			[Address(RVA = "0x3FC5524", Offset = "0x3FC1524", VA = "0x3FC5524")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000403")]
		public Image ImageBtnCardDeck4
		{
			[Token(Token = "0x60029C7")]
			[Address(RVA = "0x3FC55EC", Offset = "0x3FC15EC", VA = "0x3FC55EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000404")]
		public ButtonExtend ButtonExtendBtnCardDeck4
		{
			[Token(Token = "0x60029C8")]
			[Address(RVA = "0x3FCCA68", Offset = "0x3FC8A68", VA = "0x3FCCA68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000405")]
		public Image ImageImgBtnDeckBanner4
		{
			[Token(Token = "0x60029C9")]
			[Address(RVA = "0x3FC56B4", Offset = "0x3FC16B4", VA = "0x3FC56B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000406")]
		public Image ImageBtnCardDeck5
		{
			[Token(Token = "0x60029CA")]
			[Address(RVA = "0x3FC577C", Offset = "0x3FC177C", VA = "0x3FC577C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000407")]
		public ButtonExtend ButtonExtendBtnCardDeck5
		{
			[Token(Token = "0x60029CB")]
			[Address(RVA = "0x3FCCB30", Offset = "0x3FC8B30", VA = "0x3FCCB30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000408")]
		public Image ImageImgBtnDeckBanner5
		{
			[Token(Token = "0x60029CC")]
			[Address(RVA = "0x3FC5844", Offset = "0x3FC1844", VA = "0x3FC5844")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000409")]
		public TextMeshProUGUI TextMeshProUGUITxtDeck
		{
			[Token(Token = "0x60029CD")]
			[Address(RVA = "0x3FC9B80", Offset = "0x3FC5B80", VA = "0x3FC9B80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700040A")]
		public TextMeshProUGUI TextMeshProUGUITxtAllBattleNum
		{
			[Token(Token = "0x60029CE")]
			[Address(RVA = "0x3FC6BC4", Offset = "0x3FC2BC4", VA = "0x3FC6BC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700040B")]
		public RectTransform RectTransformBtnTerran
		{
			[Token(Token = "0x60029CF")]
			[Address(RVA = "0x3FC78A0", Offset = "0x3FC38A0", VA = "0x3FC78A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700040C")]
		public Image ImageBtnTerran
		{
			[Token(Token = "0x60029D0")]
			[Address(RVA = "0x3FCC354", Offset = "0x3FC8354", VA = "0x3FCC354")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700040D")]
		public ButtonExtend ButtonExtendBtnTerran
		{
			[Token(Token = "0x60029D1")]
			[Address(RVA = "0x3FC633C", Offset = "0x3FC233C", VA = "0x3FC633C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700040E")]
		public TextMeshProUGUI TextMeshProUGUITxtTerranCount
		{
			[Token(Token = "0x60029D2")]
			[Address(RVA = "0x3FC77D8", Offset = "0x3FC37D8", VA = "0x3FC77D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700040F")]
		public RectTransform RectTransformBtnOrcs
		{
			[Token(Token = "0x60029D3")]
			[Address(RVA = "0x3FC6F1C", Offset = "0x3FC2F1C", VA = "0x3FC6F1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000410")]
		public Image ImageBtnOrcs
		{
			[Token(Token = "0x60029D4")]
			[Address(RVA = "0x3FCC1C4", Offset = "0x3FC81C4", VA = "0x3FCC1C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000411")]
		public ButtonExtend ButtonExtendBtnOrcs
		{
			[Token(Token = "0x60029D5")]
			[Address(RVA = "0x3FC6274", Offset = "0x3FC2274", VA = "0x3FC6274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000412")]
		public TextMeshProUGUI TextMeshProUGUITxtOrcsCount
		{
			[Token(Token = "0x60029D6")]
			[Address(RVA = "0x3FC6E54", Offset = "0x3FC2E54", VA = "0x3FC6E54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000413")]
		public RectTransform RectTransformBtnUndead
		{
			[Token(Token = "0x60029D7")]
			[Address(RVA = "0x3FC7548", Offset = "0x3FC3548", VA = "0x3FC7548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000414")]
		public Image ImageBtnUndead
		{
			[Token(Token = "0x60029D8")]
			[Address(RVA = "0x3FCC28C", Offset = "0x3FC828C", VA = "0x3FCC28C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000415")]
		public ButtonExtend ButtonExtendBtnUndead
		{
			[Token(Token = "0x60029D9")]
			[Address(RVA = "0x3FC61AC", Offset = "0x3FC21AC", VA = "0x3FC61AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000416")]
		public TextMeshProUGUI TextMeshProUGUITxtUndeadCount
		{
			[Token(Token = "0x60029DA")]
			[Address(RVA = "0x3FC7480", Offset = "0x3FC3480", VA = "0x3FC7480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000417")]
		public RectTransform RectTransformBtnMachine
		{
			[Token(Token = "0x60029DB")]
			[Address(RVA = "0x3FC7C34", Offset = "0x3FC3C34", VA = "0x3FC7C34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000418")]
		public Image ImageBtnMachine
		{
			[Token(Token = "0x60029DC")]
			[Address(RVA = "0x3FCC41C", Offset = "0x3FC841C", VA = "0x3FCC41C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000419")]
		public ButtonExtend ButtonExtendBtnMachine
		{
			[Token(Token = "0x60029DD")]
			[Address(RVA = "0x3FC6404", Offset = "0x3FC2404", VA = "0x3FC6404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700041A")]
		public TextMeshProUGUI TextMeshProUGUITxtMachineCount
		{
			[Token(Token = "0x60029DE")]
			[Address(RVA = "0x3FC7B6C", Offset = "0x3FC3B6C", VA = "0x3FC7B6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700041B")]
		public RectTransform RectTransformBtnMelee
		{
			[Token(Token = "0x60029DF")]
			[Address(RVA = "0x3FC7F8C", Offset = "0x3FC3F8C", VA = "0x3FC7F8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700041C")]
		public Image ImageBtnMelee
		{
			[Token(Token = "0x60029E0")]
			[Address(RVA = "0x3FCC4E4", Offset = "0x3FC84E4", VA = "0x3FCC4E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700041D")]
		public ButtonExtend ButtonExtendBtnMelee
		{
			[Token(Token = "0x60029E1")]
			[Address(RVA = "0x3FC64CC", Offset = "0x3FC24CC", VA = "0x3FC64CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700041E")]
		public TextMeshProUGUI TextMeshProUGUITxtMeleeCount
		{
			[Token(Token = "0x60029E2")]
			[Address(RVA = "0x3FC7EC4", Offset = "0x3FC3EC4", VA = "0x3FC7EC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700041F")]
		public RectTransform RectTransformBtnRemote
		{
			[Token(Token = "0x60029E3")]
			[Address(RVA = "0x3FC82E4", Offset = "0x3FC42E4", VA = "0x3FC82E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000420")]
		public Image ImageBtnRemote
		{
			[Token(Token = "0x60029E4")]
			[Address(RVA = "0x3FCC5AC", Offset = "0x3FC85AC", VA = "0x3FCC5AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000421")]
		public ButtonExtend ButtonExtendBtnRemote
		{
			[Token(Token = "0x60029E5")]
			[Address(RVA = "0x3FC6594", Offset = "0x3FC2594", VA = "0x3FC6594")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000422")]
		public TextMeshProUGUI TextMeshProUGUITxtRemoteCount
		{
			[Token(Token = "0x60029E6")]
			[Address(RVA = "0x3FC821C", Offset = "0x3FC421C", VA = "0x3FC821C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000423")]
		public RectTransform RectTransformIntroBack
		{
			[Token(Token = "0x60029E7")]
			[Address(RVA = "0x3FC4988", Offset = "0x3FC0988", VA = "0x3FC4988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000424")]
		public TextMeshProUGUI TextMeshProUGUITxtFetterTitle
		{
			[Token(Token = "0x60029E8")]
			[Address(RVA = "0x3FC8508", Offset = "0x3FC4508", VA = "0x3FC8508")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000425")]
		public RectTransform RectTransformIntroText
		{
			[Token(Token = "0x60029E9")]
			[Address(RVA = "0x3FC85D0", Offset = "0x3FC45D0", VA = "0x3FC85D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000426")]
		public TextMeshProUGUI TextMeshProUGUIIntroText
		{
			[Token(Token = "0x60029EA")]
			[Address(RVA = "0x3FCA4F4", Offset = "0x3FC64F4", VA = "0x3FCA4F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000427")]
		public RectTransform RectTransformFetterCardShowImgRoot
		{
			[Token(Token = "0x60029EB")]
			[Address(RVA = "0x3FC8698", Offset = "0x3FC4698", VA = "0x3FC8698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60029EC")]
		[Address(RVA = "0x3FCCBF8", Offset = "0x3FC8BF8", VA = "0x3FCCBF8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60029ED")]
		[Address(RVA = "0x3FC4C68", Offset = "0x3FC0C68", VA = "0x3FC4C68", Slot = "12")]
		protected virtual void OnButtonBgClicked()
		{
		}

		[Token(Token = "0x60029EE")]
		[Address(RVA = "0x3FCCFE0", Offset = "0x3FC8FE0", VA = "0x3FCCFE0", Slot = "13")]
		protected virtual void OnScrollRectEquipScrollViewValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60029EF")]
		[Address(RVA = "0x3FC59DC", Offset = "0x3FC19DC", VA = "0x3FC59DC", Slot = "14")]
		protected virtual void OnButtonExtendBtnCardDeck1Clicked()
		{
		}

		[Token(Token = "0x60029F0")]
		[Address(RVA = "0x3FC5D58", Offset = "0x3FC1D58", VA = "0x3FC5D58", Slot = "15")]
		protected virtual void OnButtonExtendBtnCardDeck2Clicked()
		{
		}

		[Token(Token = "0x60029F1")]
		[Address(RVA = "0x3FC5DE0", Offset = "0x3FC1DE0", VA = "0x3FC5DE0", Slot = "16")]
		protected virtual void OnButtonExtendBtnCardDeck3Clicked()
		{
		}

		[Token(Token = "0x60029F2")]
		[Address(RVA = "0x3FC5E68", Offset = "0x3FC1E68", VA = "0x3FC5E68", Slot = "17")]
		protected virtual void OnButtonExtendBtnCardDeck4Clicked()
		{
		}

		[Token(Token = "0x60029F3")]
		[Address(RVA = "0x3FC5EF0", Offset = "0x3FC1EF0", VA = "0x3FC5EF0", Slot = "18")]
		protected virtual void OnButtonExtendBtnCardDeck5Clicked()
		{
		}

		[Token(Token = "0x60029F4")]
		[Address(RVA = "0x3FC776C", Offset = "0x3FC376C", VA = "0x3FC776C", Slot = "19")]
		protected virtual void OnButtonExtendBtnTerranClicked()
		{
		}

		[Token(Token = "0x60029F5")]
		[Address(RVA = "0x3FC6DE8", Offset = "0x3FC2DE8", VA = "0x3FC6DE8", Slot = "20")]
		protected virtual void OnButtonExtendBtnOrcsClicked()
		{
		}

		[Token(Token = "0x60029F6")]
		[Address(RVA = "0x3FC7414", Offset = "0x3FC3414", VA = "0x3FC7414", Slot = "21")]
		protected virtual void OnButtonExtendBtnUndeadClicked()
		{
		}

		[Token(Token = "0x60029F7")]
		[Address(RVA = "0x3FC7B00", Offset = "0x3FC3B00", VA = "0x3FC7B00", Slot = "22")]
		protected virtual void OnButtonExtendBtnMachineClicked()
		{
		}

		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x3FC7E58", Offset = "0x3FC3E58", VA = "0x3FC7E58", Slot = "23")]
		protected virtual void OnButtonExtendBtnMeleeClicked()
		{
		}

		[Token(Token = "0x60029F9")]
		[Address(RVA = "0x3FC81B0", Offset = "0x3FC41B0", VA = "0x3FC81B0", Slot = "24")]
		protected virtual void OnButtonExtendBtnRemoteClicked()
		{
		}

		[Token(Token = "0x60029FA")]
		[Address(RVA = "0x3FC8820", Offset = "0x3FC4820", VA = "0x3FC8820", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60029FB")]
		[Address(RVA = "0x3FC8840", Offset = "0x3FC4840", VA = "0x3FC8840", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__561))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60029FC")]
		[Address(RVA = "0x3FC4CE4", Offset = "0x3FC0CE4", VA = "0x3FC4CE4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60029FD")]
		[Address(RVA = "0x3FC87FC", Offset = "0x3FC47FC", VA = "0x3FC87FC")]
		public CardDeckChangePanelComponents()
		{
		}
	}
}
