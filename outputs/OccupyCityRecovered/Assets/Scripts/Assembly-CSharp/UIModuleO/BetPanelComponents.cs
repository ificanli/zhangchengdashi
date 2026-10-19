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

namespace UIModuleO
{
	[Token(Token = "0x200071C")]
	public class BetPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200071D")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__274 : IAsyncStateMachine
		{
			[Token(Token = "0x400386A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400386B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400386C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BetPanelComponents _003C_003E4__this;

			[Token(Token = "0x400386D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60026C7")]
			[Address(RVA = "0x3F98CEC", Offset = "0x3F94CEC", VA = "0x3F98CEC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60026C8")]
			[Address(RVA = "0x3F98F64", Offset = "0x3F94F64", VA = "0x3F98F64", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400385D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBG;

		[Token(Token = "0x400385E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformImgBetBg;

		[Token(Token = "0x400385F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUITxtTitle;

		[Token(Token = "0x4003860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUITxtDes;

		[Token(Token = "0x4003861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUITxtBetCoinNum;

		[Token(Token = "0x4003862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUITxtCost;

		[Token(Token = "0x4003863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ButtonExtend _buttonExtendBtnReduce;

		[Token(Token = "0x4003864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ButtonExtend _buttonExtendBtnBoost;

		[Token(Token = "0x4003865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUITxtRewardDes;

		[Token(Token = "0x4003866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI _textMeshProUGUITxtRewardCoinNum;

		[Token(Token = "0x4003867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ButtonExtend _buttonExtendBtnStart;

		[Token(Token = "0x4003868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TextMeshProUGUI _textMeshProUGUITxtStart;

		[Token(Token = "0x4003869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ButtonExtend _buttonExtendBtnClose;

		[Token(Token = "0x1700031C")]
		public ButtonExtend ButtonExtendBG
		{
			[Token(Token = "0x60026AF")]
			[Address(RVA = "0x3F98740", Offset = "0x3F94740", VA = "0x3F98740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700031D")]
		public RectTransform RectTransformImgBetBg
		{
			[Token(Token = "0x60026B0")]
			[Address(RVA = "0x3F97798", Offset = "0x3F93798", VA = "0x3F97798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700031E")]
		public TextMeshProUGUI TextMeshProUGUITxtTitle
		{
			[Token(Token = "0x60026B1")]
			[Address(RVA = "0x3F9834C", Offset = "0x3F9434C", VA = "0x3F9834C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700031F")]
		public TextMeshProUGUI TextMeshProUGUITxtDes
		{
			[Token(Token = "0x60026B2")]
			[Address(RVA = "0x3F98414", Offset = "0x3F94414", VA = "0x3F98414")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000320")]
		public TextMeshProUGUI TextMeshProUGUITxtBetCoinNum
		{
			[Token(Token = "0x60026B3")]
			[Address(RVA = "0x3F975D0", Offset = "0x3F935D0", VA = "0x3F975D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000321")]
		public TextMeshProUGUI TextMeshProUGUITxtCost
		{
			[Token(Token = "0x60026B4")]
			[Address(RVA = "0x3F9866C", Offset = "0x3F9466C", VA = "0x3F9866C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000322")]
		public ButtonExtend ButtonExtendBtnReduce
		{
			[Token(Token = "0x60026B5")]
			[Address(RVA = "0x3F98808", Offset = "0x3F94808", VA = "0x3F98808")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000323")]
		public ButtonExtend ButtonExtendBtnBoost
		{
			[Token(Token = "0x60026B6")]
			[Address(RVA = "0x3F988D0", Offset = "0x3F948D0", VA = "0x3F988D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000324")]
		public TextMeshProUGUI TextMeshProUGUITxtRewardDes
		{
			[Token(Token = "0x60026B7")]
			[Address(RVA = "0x3F985A4", Offset = "0x3F945A4", VA = "0x3F985A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000325")]
		public TextMeshProUGUI TextMeshProUGUITxtRewardCoinNum
		{
			[Token(Token = "0x60026B8")]
			[Address(RVA = "0x3F97038", Offset = "0x3F93038", VA = "0x3F97038")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000326")]
		public ButtonExtend ButtonExtendBtnStart
		{
			[Token(Token = "0x60026B9")]
			[Address(RVA = "0x3F98998", Offset = "0x3F94998", VA = "0x3F98998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000327")]
		public TextMeshProUGUI TextMeshProUGUITxtStart
		{
			[Token(Token = "0x60026BA")]
			[Address(RVA = "0x3F984DC", Offset = "0x3F944DC", VA = "0x3F984DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000328")]
		public ButtonExtend ButtonExtendBtnClose
		{
			[Token(Token = "0x60026BB")]
			[Address(RVA = "0x3F98A60", Offset = "0x3F94A60", VA = "0x3F98A60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60026BC")]
		[Address(RVA = "0x3F98B28", Offset = "0x3F94B28", VA = "0x3F98B28")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60026BD")]
		[Address(RVA = "0x3F978A4", Offset = "0x3F938A4", VA = "0x3F978A4", Slot = "12")]
		protected virtual void OnButtonExtendBGClicked()
		{
		}

		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x3F97138", Offset = "0x3F93138", VA = "0x3F97138", Slot = "13")]
		protected virtual void OnButtonExtendBtnReduceClicked()
		{
		}

		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x3F974D8", Offset = "0x3F934D8", VA = "0x3F974D8", Slot = "14")]
		protected virtual void OnButtonExtendBtnBoostClicked()
		{
		}

		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x3F96FCC", Offset = "0x3F92FCC", VA = "0x3F96FCC", Slot = "15")]
		protected virtual void OnButtonExtendBtnStartClicked()
		{
		}

		[Token(Token = "0x60026C1")]
		[Address(RVA = "0x3F97564", Offset = "0x3F93564", VA = "0x3F97564", Slot = "16")]
		protected virtual void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x60026C2")]
		[Address(RVA = "0x3F98CC8", Offset = "0x3F94CC8", VA = "0x3F98CC8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60026C3")]
		[Address(RVA = "0x3F97924", Offset = "0x3F93924", VA = "0x3F97924", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__274))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60026C4")]
		[Address(RVA = "0x3F979D0", Offset = "0x3F939D0", VA = "0x3F979D0", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60026C5")]
		[Address(RVA = "0x3F97918", Offset = "0x3F93918", VA = "0x3F97918")]
		public BetPanelComponents()
		{
		}
	}
}
