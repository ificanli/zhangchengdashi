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
	[Token(Token = "0x2000817")]
	public class ArtifactViewComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000818")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__468 : IAsyncStateMachine
		{
			[Token(Token = "0x4003DF0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003DF1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003DF2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArtifactViewComponents _003C_003E4__this;

			[Token(Token = "0x4003DF3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002D3A")]
			[Address(RVA = "0x400B538", Offset = "0x4007538", VA = "0x400B538", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002D3B")]
			[Address(RVA = "0x400B7B0", Offset = "0x40077B0", VA = "0x400B7B0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Image _imageImgPropTitleBg;

		[Token(Token = "0x4003DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextMeshProUGUI _textMeshProUGUITxtPropName;

		[Token(Token = "0x4003DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Image _imageImgPropIcon;

		[Token(Token = "0x4003DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imageImgPropProgress;

		[Token(Token = "0x4003DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtPropProgress;

		[Token(Token = "0x4003DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtNowLevelPropDes;

		[Token(Token = "0x4003DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtNowLevel;

		[Token(Token = "0x4003DE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private TextMeshProUGUI _textMeshProUGUITxtNextLevelPropDes;

		[Token(Token = "0x4003DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtNextLevel;

		[Token(Token = "0x4003DE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Image _imageImgGreenHead;

		[Token(Token = "0x4003DE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUITxtUsing;

		[Token(Token = "0x4003DE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ButtonExtend _buttonExtendBtnUse;

		[Token(Token = "0x4003DE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtUse;

		[Token(Token = "0x4003DE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ButtonExtend _buttonExtendBtnUpgrade;

		[Token(Token = "0x4003DEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUITxtUpgrade;

		[Token(Token = "0x4003DEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TextMeshProUGUI _textMeshProUGUITxtUpgradeRequireNum;

		[Token(Token = "0x4003DEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUITxtCrystalNum;

		[Token(Token = "0x4003DED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ScrollRect _scrollRectImgSVBotBg;

		[Token(Token = "0x4003DEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private RectTransform _rectTransformBotContent;

		[Token(Token = "0x4003DEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ButtonExtend _buttonExtendSummonBtn;

		[Token(Token = "0x17000505")]
		public Image ImageImgPropTitleBg
		{
			[Token(Token = "0x6002D1C")]
			[Address(RVA = "0x400B094", Offset = "0x4007094", VA = "0x400B094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000506")]
		public TextMeshProUGUI TextMeshProUGUITxtPropName
		{
			[Token(Token = "0x6002D1D")]
			[Address(RVA = "0x400A98C", Offset = "0x400698C", VA = "0x400A98C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000507")]
		public Image ImageImgPropIcon
		{
			[Token(Token = "0x6002D1E")]
			[Address(RVA = "0x40060B4", Offset = "0x40020B4", VA = "0x40060B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000508")]
		public Image ImageImgPropProgress
		{
			[Token(Token = "0x6002D1F")]
			[Address(RVA = "0x400ACAC", Offset = "0x4006CAC", VA = "0x400ACAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000509")]
		public TextMeshProUGUI TextMeshProUGUITxtPropProgress
		{
			[Token(Token = "0x6002D20")]
			[Address(RVA = "0x400ABE4", Offset = "0x4006BE4", VA = "0x400ABE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050A")]
		public TextMeshProUGUI TextMeshProUGUITxtNowLevelPropDes
		{
			[Token(Token = "0x6002D21")]
			[Address(RVA = "0x400AF04", Offset = "0x4006F04", VA = "0x400AF04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050B")]
		public TextMeshProUGUI TextMeshProUGUITxtNowLevel
		{
			[Token(Token = "0x6002D22")]
			[Address(RVA = "0x400AD74", Offset = "0x4006D74", VA = "0x400AD74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050C")]
		public TextMeshProUGUI TextMeshProUGUITxtNextLevelPropDes
		{
			[Token(Token = "0x6002D23")]
			[Address(RVA = "0x400A7FC", Offset = "0x40067FC", VA = "0x400A7FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050D")]
		public TextMeshProUGUI TextMeshProUGUITxtNextLevel
		{
			[Token(Token = "0x6002D24")]
			[Address(RVA = "0x400AE3C", Offset = "0x4006E3C", VA = "0x400AE3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050E")]
		public Image ImageImgGreenHead
		{
			[Token(Token = "0x6002D25")]
			[Address(RVA = "0x400A8C4", Offset = "0x40068C4", VA = "0x400A8C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700050F")]
		public TextMeshProUGUI TextMeshProUGUITxtUsing
		{
			[Token(Token = "0x6002D26")]
			[Address(RVA = "0x400A734", Offset = "0x4006734", VA = "0x400A734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000510")]
		public ButtonExtend ButtonExtendBtnUse
		{
			[Token(Token = "0x6002D27")]
			[Address(RVA = "0x400A66C", Offset = "0x400666C", VA = "0x400A66C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000511")]
		public TextMeshProUGUI TextMeshProUGUITxtUse
		{
			[Token(Token = "0x6002D28")]
			[Address(RVA = "0x400AB1C", Offset = "0x4006B1C", VA = "0x400AB1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000512")]
		public ButtonExtend ButtonExtendBtnUpgrade
		{
			[Token(Token = "0x6002D29")]
			[Address(RVA = "0x4006A9C", Offset = "0x4002A9C", VA = "0x4006A9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000513")]
		public TextMeshProUGUI TextMeshProUGUITxtUpgrade
		{
			[Token(Token = "0x6002D2A")]
			[Address(RVA = "0x400AA54", Offset = "0x4006A54", VA = "0x400AA54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000514")]
		public TextMeshProUGUI TextMeshProUGUITxtUpgradeRequireNum
		{
			[Token(Token = "0x6002D2B")]
			[Address(RVA = "0x400AFCC", Offset = "0x4006FCC", VA = "0x400AFCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000515")]
		public TextMeshProUGUI TextMeshProUGUITxtCrystalNum
		{
			[Token(Token = "0x6002D2C")]
			[Address(RVA = "0x4006768", Offset = "0x4002768", VA = "0x4006768")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000516")]
		public ScrollRect ScrollRectImgSVBotBg
		{
			[Token(Token = "0x6002D2D")]
			[Address(RVA = "0x400B168", Offset = "0x4007168", VA = "0x400B168")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000517")]
		public RectTransform RectTransformBotContent
		{
			[Token(Token = "0x6002D2E")]
			[Address(RVA = "0x4008ED0", Offset = "0x4004ED0", VA = "0x4008ED0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000518")]
		public ButtonExtend ButtonExtendSummonBtn
		{
			[Token(Token = "0x6002D2F")]
			[Address(RVA = "0x400B230", Offset = "0x4007230", VA = "0x400B230")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002D30")]
		[Address(RVA = "0x400B2F8", Offset = "0x40072F8", VA = "0x400B2F8")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002D31")]
		[Address(RVA = "0x4006F3C", Offset = "0x4002F3C", VA = "0x4006F3C", Slot = "12")]
		protected virtual void OnButtonExtendBtnUseClicked()
		{
		}

		[Token(Token = "0x6002D32")]
		[Address(RVA = "0x400755C", Offset = "0x400355C", VA = "0x400755C", Slot = "13")]
		protected virtual void OnButtonExtendBtnUpgradeClicked()
		{
		}

		[Token(Token = "0x6002D33")]
		[Address(RVA = "0x400B47C", Offset = "0x400747C", VA = "0x400B47C", Slot = "14")]
		protected virtual void OnScrollRectImgSVBotBgValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x6002D34")]
		[Address(RVA = "0x400761C", Offset = "0x400361C", VA = "0x400761C", Slot = "15")]
		protected virtual void OnButtonExtendSummonBtnClicked()
		{
		}

		[Token(Token = "0x6002D35")]
		[Address(RVA = "0x4007728", Offset = "0x4003728", VA = "0x4007728", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002D36")]
		[Address(RVA = "0x4007748", Offset = "0x4003748", VA = "0x4007748", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__468))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002D37")]
		[Address(RVA = "0x40063F4", Offset = "0x40023F4", VA = "0x40063F4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002D38")]
		[Address(RVA = "0x4007704", Offset = "0x4003704", VA = "0x4007704")]
		public ArtifactViewComponents()
		{
		}
	}
}
