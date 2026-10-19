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
	[Token(Token = "0x2000AB5")]
	public class PropLotteryPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000AB6")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__288 : IAsyncStateMachine
		{
			[Token(Token = "0x4004ED8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4004ED9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4004EDA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PropLotteryPanelComponents _003C_003E4__this;

			[Token(Token = "0x4004EDB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60040B7")]
			[Address(RVA = "0x41AE3E4", Offset = "0x41AA3E4", VA = "0x41AE3E4", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60040B8")]
			[Address(RVA = "0x41AE65C", Offset = "0x41AA65C", VA = "0x41AE65C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004EC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform _rectTransformSummonProgressBg;

		[Token(Token = "0x4004EC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformSummonProgress;

		[Token(Token = "0x4004EC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonDes;

		[Token(Token = "0x4004ECA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonLevel;

		[Token(Token = "0x4004ECB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ButtonExtend _buttonExtendBtnSummonDes;

		[Token(Token = "0x4004ECC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonExp;

		[Token(Token = "0x4004ECD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonAddExp;

		[Token(Token = "0x4004ECE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform _rectTransformImgTitle;

		[Token(Token = "0x4004ECF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform _rectTransformImgTitleSpecial;

		[Token(Token = "0x4004ED0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ScrollRect _scrollRectRewardContent;

		[Token(Token = "0x4004ED1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RectTransform _rectTransformItemsGroup;

		[Token(Token = "0x4004ED2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ButtonExtend _buttonExtendBtnGemSummon;

		[Token(Token = "0x4004ED3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TextMeshProUGUI _textMeshProUGUITxtSummonTenGem;

		[Token(Token = "0x4004ED4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TextMeshProUGUI _textMeshProUGUITxtGemSummon;

		[Token(Token = "0x4004ED5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TextMeshProUGUI _textMeshProUGUINormalSummonTimesLimit;

		[Token(Token = "0x4004ED6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ButtonExtend _buttonExtendConfirmBtn;

		[Token(Token = "0x4004ED7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TextMeshProUGUI _textMeshProUGUIConfirmBtnText;

		[Token(Token = "0x17000A19")]
		public RectTransform RectTransformSummonProgressBg
		{
			[Token(Token = "0x600409C")]
			[Address(RVA = "0x41AB8A8", Offset = "0x41A78A8", VA = "0x41AB8A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A1A")]
		public RectTransform RectTransformSummonProgress
		{
			[Token(Token = "0x600409D")]
			[Address(RVA = "0x41AB7E0", Offset = "0x41A77E0", VA = "0x41AB7E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A1B")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonDes
		{
			[Token(Token = "0x600409E")]
			[Address(RVA = "0x41ADC20", Offset = "0x41A9C20", VA = "0x41ADC20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A1C")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonLevel
		{
			[Token(Token = "0x600409F")]
			[Address(RVA = "0x41ABA38", Offset = "0x41A7A38", VA = "0x41ABA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A1D")]
		public ButtonExtend ButtonExtendBtnSummonDes
		{
			[Token(Token = "0x60040A0")]
			[Address(RVA = "0x41AE014", Offset = "0x41AA014", VA = "0x41AE014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A1E")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonExp
		{
			[Token(Token = "0x60040A1")]
			[Address(RVA = "0x41AB970", Offset = "0x41A7970", VA = "0x41AB970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A1F")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonAddExp
		{
			[Token(Token = "0x60040A2")]
			[Address(RVA = "0x41AB718", Offset = "0x41A7718", VA = "0x41AB718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A20")]
		public RectTransform RectTransformImgTitle
		{
			[Token(Token = "0x60040A3")]
			[Address(RVA = "0x41ADA90", Offset = "0x41A9A90", VA = "0x41ADA90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A21")]
		public RectTransform RectTransformImgTitleSpecial
		{
			[Token(Token = "0x60040A4")]
			[Address(RVA = "0x41ADB58", Offset = "0x41A9B58", VA = "0x41ADB58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A22")]
		public ScrollRect ScrollRectRewardContent
		{
			[Token(Token = "0x60040A5")]
			[Address(RVA = "0x41AE0DC", Offset = "0x41AA0DC", VA = "0x41AE0DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A23")]
		public RectTransform RectTransformItemsGroup
		{
			[Token(Token = "0x60040A6")]
			[Address(RVA = "0x41ADF40", Offset = "0x41A9F40", VA = "0x41ADF40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A24")]
		public ButtonExtend ButtonExtendBtnGemSummon
		{
			[Token(Token = "0x60040A7")]
			[Address(RVA = "0x41AD900", Offset = "0x41A9900", VA = "0x41AD900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A25")]
		public TextMeshProUGUI TextMeshProUGUITxtSummonTenGem
		{
			[Token(Token = "0x60040A8")]
			[Address(RVA = "0x41ADCE8", Offset = "0x41A9CE8", VA = "0x41ADCE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A26")]
		public TextMeshProUGUI TextMeshProUGUITxtGemSummon
		{
			[Token(Token = "0x60040A9")]
			[Address(RVA = "0x41ADDB0", Offset = "0x41A9DB0", VA = "0x41ADDB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A27")]
		public TextMeshProUGUI TextMeshProUGUINormalSummonTimesLimit
		{
			[Token(Token = "0x60040AA")]
			[Address(RVA = "0x41ABB00", Offset = "0x41A7B00", VA = "0x41ABB00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A28")]
		public ButtonExtend ButtonExtendConfirmBtn
		{
			[Token(Token = "0x60040AB")]
			[Address(RVA = "0x41AD9C8", Offset = "0x41A99C8", VA = "0x41AD9C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A29")]
		public TextMeshProUGUI TextMeshProUGUIConfirmBtnText
		{
			[Token(Token = "0x60040AC")]
			[Address(RVA = "0x41ADE78", Offset = "0x41A9E78", VA = "0x41ADE78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60040AD")]
		[Address(RVA = "0x41AE1A4", Offset = "0x41AA1A4", VA = "0x41AE1A4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60040AE")]
		[Address(RVA = "0x41ABCA0", Offset = "0x41A7CA0", VA = "0x41ABCA0", Slot = "12")]
		protected virtual void OnButtonExtendBtnSummonDesClicked()
		{
		}

		[Token(Token = "0x60040AF")]
		[Address(RVA = "0x41AE328", Offset = "0x41AA328", VA = "0x41AE328", Slot = "13")]
		protected virtual void OnScrollRectRewardContentValueChanged(Vector2 arg)
		{
		}

		[Token(Token = "0x60040B0")]
		[Address(RVA = "0x41AA974", Offset = "0x41A6974", VA = "0x41AA974", Slot = "14")]
		protected virtual void OnButtonExtendBtnGemSummonClicked()
		{
		}

		[Token(Token = "0x60040B1")]
		[Address(RVA = "0x41ABDC4", Offset = "0x41A7DC4", VA = "0x41ABDC4", Slot = "15")]
		protected virtual void OnButtonExtendConfirmBtnClicked()
		{
		}

		[Token(Token = "0x60040B2")]
		[Address(RVA = "0x41AA618", Offset = "0x41A6618", VA = "0x41AA618", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60040B3")]
		[Address(RVA = "0x41ABD2C", Offset = "0x41A7D2C", VA = "0x41ABD2C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__288))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60040B4")]
		[Address(RVA = "0x41AAB34", Offset = "0x41A6B34", VA = "0x41AAB34", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60040B5")]
		[Address(RVA = "0x41ABD20", Offset = "0x41A7D20", VA = "0x41ABD20")]
		public PropLotteryPanelComponents()
		{
		}
	}
}
