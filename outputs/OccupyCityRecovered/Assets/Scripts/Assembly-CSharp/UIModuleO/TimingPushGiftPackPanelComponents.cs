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
	[Token(Token = "0x2000BA5")]
	public class TimingPushGiftPackPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000BA6")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__458 : IAsyncStateMachine
		{
			[Token(Token = "0x40054A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40054A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40054A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public TimingPushGiftPackPanelComponents _003C_003E4__this;

			[Token(Token = "0x40054AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6004789")]
			[Address(RVA = "0x4226044", Offset = "0x4222044", VA = "0x4226044", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600478A")]
			[Address(RVA = "0x42262BC", Offset = "0x42222BC", VA = "0x42262BC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformTimingPushGiftPackPanel;

		[Token(Token = "0x4005488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x4005489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformRoot;

		[Token(Token = "0x400548A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtGiftName;

		[Token(Token = "0x400548B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x400548C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageChooseCustomBtnRoot;

		[Token(Token = "0x400548D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendBtnChoose1;

		[Token(Token = "0x400548E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image _imageImgChoose1Icon;

		[Token(Token = "0x400548F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtLegendaryCount;

		[Token(Token = "0x4005490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtLegendaryRareLevel;

		[Token(Token = "0x4005491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ButtonExtend _buttonExtendBtnChoose2;

		[Token(Token = "0x4005492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image _imageImgChoose2Icon;

		[Token(Token = "0x4005493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtEpicCount;

		[Token(Token = "0x4005494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtEpicRareLevel;

		[Token(Token = "0x4005495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ButtonExtend _buttonExtendBtnChoose3;

		[Token(Token = "0x4005496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Image _imageImgChoose3Icon;

		[Token(Token = "0x4005497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUITxtRareCount;

		[Token(Token = "0x4005498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private TextMeshProUGUI _textMeshProUGUITxtEpicRareLevel1;

		[Token(Token = "0x4005499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RectTransform _rectTransformRewardRoot;

		[Token(Token = "0x400549A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Image _imageImgResRoot;

		[Token(Token = "0x400549B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RectTransform _rectTransformImgResGem;

		[Token(Token = "0x400549C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private TextMeshProUGUI _textMeshProUGUITxtResGemNum;

		[Token(Token = "0x400549D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private TextMeshProUGUI _textMeshProUGUITxtResGemName;

		[Token(Token = "0x400549E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RectTransform _rectTransformImgResCoin;

		[Token(Token = "0x400549F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private TextMeshProUGUI _textMeshProUGUITxtResCoinNum;

		[Token(Token = "0x40054A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private TextMeshProUGUI _textMeshProUGUITxtResCoinName;

		[Token(Token = "0x40054A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private RectTransform _rectTransformImgResWood;

		[Token(Token = "0x40054A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private TextMeshProUGUI _textMeshProUGUITxtResWoodNum;

		[Token(Token = "0x40054A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private TextMeshProUGUI _textMeshProUGUITxtResWoodName;

		[Token(Token = "0x40054A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private TextMeshProUGUI _textMeshProUGUITxtCutDown;

		[Token(Token = "0x40054A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private ButtonExtend _buttonExtendBtnBuy;

		[Token(Token = "0x40054A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private TextMeshProUGUI _textMeshProUGUITxtPriceNum;

		[Token(Token = "0x17000C08")]
		public RectTransform RectTransformTimingPushGiftPackPanel
		{
			[Token(Token = "0x600475D")]
			[Address(RVA = "0x4222EC8", Offset = "0x421EEC8", VA = "0x4222EC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C09")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x600475E")]
			[Address(RVA = "0x4225C00", Offset = "0x4221C00", VA = "0x4225C00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C0A")]
		public RectTransform RectTransformRoot
		{
			[Token(Token = "0x600475F")]
			[Address(RVA = "0x42218B4", Offset = "0x421D8B4", VA = "0x42218B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C0B")]
		public TextMeshProUGUI TextMeshProUGUITxtGiftName
		{
			[Token(Token = "0x6004760")]
			[Address(RVA = "0x4225104", Offset = "0x4221104", VA = "0x4225104")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C0C")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x6004761")]
			[Address(RVA = "0x4225CC8", Offset = "0x4221CC8", VA = "0x4225CC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C0D")]
		public Image ImageChooseCustomBtnRoot
		{
			[Token(Token = "0x6004762")]
			[Address(RVA = "0x4224F74", Offset = "0x4220F74", VA = "0x4224F74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C0E")]
		public ButtonExtend ButtonExtendBtnChoose1
		{
			[Token(Token = "0x6004763")]
			[Address(RVA = "0x4220DFC", Offset = "0x421CDFC", VA = "0x4220DFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C0F")]
		public Image ImageImgChoose1Icon
		{
			[Token(Token = "0x6004764")]
			[Address(RVA = "0x42251CC", Offset = "0x42211CC", VA = "0x42251CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C10")]
		public TextMeshProUGUI TextMeshProUGUITxtLegendaryCount
		{
			[Token(Token = "0x6004765")]
			[Address(RVA = "0x4225424", Offset = "0x4221424", VA = "0x4225424")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C11")]
		public TextMeshProUGUI TextMeshProUGUITxtLegendaryRareLevel
		{
			[Token(Token = "0x6004766")]
			[Address(RVA = "0x422567C", Offset = "0x422167C", VA = "0x422567C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C12")]
		public ButtonExtend ButtonExtendBtnChoose2
		{
			[Token(Token = "0x6004767")]
			[Address(RVA = "0x4221288", Offset = "0x421D288", VA = "0x4221288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C13")]
		public Image ImageImgChoose2Icon
		{
			[Token(Token = "0x6004768")]
			[Address(RVA = "0x4225294", Offset = "0x4221294", VA = "0x4225294")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C14")]
		public TextMeshProUGUI TextMeshProUGUITxtEpicCount
		{
			[Token(Token = "0x6004769")]
			[Address(RVA = "0x42254EC", Offset = "0x42214EC", VA = "0x42254EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C15")]
		public TextMeshProUGUI TextMeshProUGUITxtEpicRareLevel
		{
			[Token(Token = "0x600476A")]
			[Address(RVA = "0x4225744", Offset = "0x4221744", VA = "0x4225744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C16")]
		public ButtonExtend ButtonExtendBtnChoose3
		{
			[Token(Token = "0x600476B")]
			[Address(RVA = "0x42213F0", Offset = "0x421D3F0", VA = "0x42213F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C17")]
		public Image ImageImgChoose3Icon
		{
			[Token(Token = "0x600476C")]
			[Address(RVA = "0x422535C", Offset = "0x422135C", VA = "0x422535C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C18")]
		public TextMeshProUGUI TextMeshProUGUITxtRareCount
		{
			[Token(Token = "0x600476D")]
			[Address(RVA = "0x42255B4", Offset = "0x42215B4", VA = "0x42255B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C19")]
		public TextMeshProUGUI TextMeshProUGUITxtEpicRareLevel1
		{
			[Token(Token = "0x600476E")]
			[Address(RVA = "0x422580C", Offset = "0x422180C", VA = "0x422580C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C1A")]
		public RectTransform RectTransformRewardRoot
		{
			[Token(Token = "0x600476F")]
			[Address(RVA = "0x42214B8", Offset = "0x421D4B8", VA = "0x42214B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C1B")]
		public Image ImageImgResRoot
		{
			[Token(Token = "0x6004770")]
			[Address(RVA = "0x422503C", Offset = "0x422103C", VA = "0x422503C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C1C")]
		public RectTransform RectTransformImgResGem
		{
			[Token(Token = "0x6004771")]
			[Address(RVA = "0x4223034", Offset = "0x421F034", VA = "0x4223034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C1D")]
		public TextMeshProUGUI TextMeshProUGUITxtResGemNum
		{
			[Token(Token = "0x6004772")]
			[Address(RVA = "0x422328C", Offset = "0x421F28C", VA = "0x422328C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C1E")]
		public TextMeshProUGUI TextMeshProUGUITxtResGemName
		{
			[Token(Token = "0x6004773")]
			[Address(RVA = "0x4225A64", Offset = "0x4221A64", VA = "0x4225A64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C1F")]
		public RectTransform RectTransformImgResCoin
		{
			[Token(Token = "0x6004774")]
			[Address(RVA = "0x4222F6C", Offset = "0x421EF6C", VA = "0x4222F6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C20")]
		public TextMeshProUGUI TextMeshProUGUITxtResCoinNum
		{
			[Token(Token = "0x6004775")]
			[Address(RVA = "0x42230FC", Offset = "0x421F0FC", VA = "0x42230FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C21")]
		public TextMeshProUGUI TextMeshProUGUITxtResCoinName
		{
			[Token(Token = "0x6004776")]
			[Address(RVA = "0x422599C", Offset = "0x422199C", VA = "0x422599C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C22")]
		public RectTransform RectTransformImgResWood
		{
			[Token(Token = "0x6004777")]
			[Address(RVA = "0x4222E00", Offset = "0x421EE00", VA = "0x4222E00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C23")]
		public TextMeshProUGUI TextMeshProUGUITxtResWoodNum
		{
			[Token(Token = "0x6004778")]
			[Address(RVA = "0x42231C4", Offset = "0x421F1C4", VA = "0x42231C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C24")]
		public TextMeshProUGUI TextMeshProUGUITxtResWoodName
		{
			[Token(Token = "0x6004779")]
			[Address(RVA = "0x4225B2C", Offset = "0x4221B2C", VA = "0x4225B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C25")]
		public TextMeshProUGUI TextMeshProUGUITxtCutDown
		{
			[Token(Token = "0x600477A")]
			[Address(RVA = "0x42202B4", Offset = "0x421C2B4", VA = "0x42202B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C26")]
		public ButtonExtend ButtonExtendBtnBuy
		{
			[Token(Token = "0x600477B")]
			[Address(RVA = "0x4225D90", Offset = "0x4221D90", VA = "0x4225D90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000C27")]
		public TextMeshProUGUI TextMeshProUGUITxtPriceNum
		{
			[Token(Token = "0x600477C")]
			[Address(RVA = "0x42258D4", Offset = "0x42218D4", VA = "0x42258D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600477D")]
		[Address(RVA = "0x4225E58", Offset = "0x4221E58", VA = "0x4225E58")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x600477E")]
		[Address(RVA = "0x422162C", Offset = "0x421D62C", VA = "0x422162C", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x600477F")]
		[Address(RVA = "0x42216B8", Offset = "0x421D6B8", VA = "0x42216B8", Slot = "13")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6004780")]
		[Address(RVA = "0x42204F4", Offset = "0x421C4F4", VA = "0x42204F4", Slot = "14")]
		protected virtual void OnButtonExtendBtnChoose1Clicked()
		{
		}

		[Token(Token = "0x6004781")]
		[Address(RVA = "0x42206D8", Offset = "0x421C6D8", VA = "0x42206D8", Slot = "15")]
		protected virtual void OnButtonExtendBtnChoose2Clicked()
		{
		}

		[Token(Token = "0x6004782")]
		[Address(RVA = "0x42208BC", Offset = "0x421C8BC", VA = "0x42208BC", Slot = "16")]
		protected virtual void OnButtonExtendBtnChoose3Clicked()
		{
		}

		[Token(Token = "0x6004783")]
		[Address(RVA = "0x4220B0C", Offset = "0x421CB0C", VA = "0x4220B0C", Slot = "17")]
		protected virtual void OnButtonExtendBtnBuyClicked()
		{
		}

		[Token(Token = "0x6004784")]
		[Address(RVA = "0x4221A98", Offset = "0x421DA98", VA = "0x4221A98", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004785")]
		[Address(RVA = "0x4221AB8", Offset = "0x421DAB8", VA = "0x4221AB8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__458))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004786")]
		[Address(RVA = "0x4221BA8", Offset = "0x421DBA8", VA = "0x4221BA8", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004787")]
		[Address(RVA = "0x4221A74", Offset = "0x421DA74", VA = "0x4221A74")]
		public TimingPushGiftPackPanelComponents()
		{
		}
	}
}
