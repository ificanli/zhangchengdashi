using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using SDKModule;
using TMPro;
using UIFramework;
using UIModuleO.UIAnim;
using UnityEngine;

namespace UIModuleO
{
	[Token(Token = "0x200093D")]
	public class MainCityIdleRewardPanelComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200093E")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__285 : IAsyncStateMachine
		{
			[Token(Token = "0x400453C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400453D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400453E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainCityIdleRewardPanelComponents _003C_003E4__this;

			[Token(Token = "0x400453F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60035B0")]
			[Address(RVA = "0x40BCA48", Offset = "0x40B8A48", VA = "0x40BCA48", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60035B1")]
			[Address(RVA = "0x40BCCC0", Offset = "0x40B8CC0", VA = "0x40BCCC0", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ButtonExtend _buttonExtendBtnExit;

		[Token(Token = "0x4004531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _rectTransformTop;

		[Token(Token = "0x4004532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TextMeshProUGUI _textMeshProUGUIIdleTxt;

		[Token(Token = "0x4004533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TextMeshProUGUI _textMeshProUGUIReward1Num;

		[Token(Token = "0x4004534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TextMeshProUGUI _textMeshProUGUIReward2Num;

		[Token(Token = "0x4004535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TextMeshProUGUI _textMeshProUGUIReward3Num;

		[Token(Token = "0x4004536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TextMeshProUGUI _textMeshProUGUIIdleTime;

		[Token(Token = "0x4004537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private AdButtonExtend _adButtonExtendAd;

		[Token(Token = "0x4004538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private TextMeshProUGUI _textMeshProUGUIBoostTxt;

		[Token(Token = "0x4004539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ButtonExtend _buttonExtendClaim;

		[Token(Token = "0x400453A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TextMeshProUGUI _textMeshProUGUIText;

		[Token(Token = "0x400453B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ButtonExtend _buttonExtendBtnCancel;

		[Token(Token = "0x17000791")]
		public ButtonExtend ButtonExtendBtnExit
		{
			[Token(Token = "0x600359A")]
			[Address(RVA = "0x40BC6E8", Offset = "0x40B86E8", VA = "0x40BC6E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000792")]
		public RectTransform RectTransformTop
		{
			[Token(Token = "0x600359B")]
			[Address(RVA = "0x40BB3C4", Offset = "0x40B73C4", VA = "0x40BB3C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000793")]
		public TextMeshProUGUI TextMeshProUGUIIdleTxt
		{
			[Token(Token = "0x600359C")]
			[Address(RVA = "0x40BC614", Offset = "0x40B8614", VA = "0x40BC614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000794")]
		public TextMeshProUGUI TextMeshProUGUIReward1Num
		{
			[Token(Token = "0x600359D")]
			[Address(RVA = "0x40BAE00", Offset = "0x40B6E00", VA = "0x40BAE00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000795")]
		public TextMeshProUGUI TextMeshProUGUIReward2Num
		{
			[Token(Token = "0x600359E")]
			[Address(RVA = "0x40BAEC8", Offset = "0x40B6EC8", VA = "0x40BAEC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000796")]
		public TextMeshProUGUI TextMeshProUGUIReward3Num
		{
			[Token(Token = "0x600359F")]
			[Address(RVA = "0x40BAF90", Offset = "0x40B6F90", VA = "0x40BAF90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000797")]
		public TextMeshProUGUI TextMeshProUGUIIdleTime
		{
			[Token(Token = "0x60035A0")]
			[Address(RVA = "0x40BB058", Offset = "0x40B7058", VA = "0x40BB058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000798")]
		public AdButtonExtend AdButtonExtendAd
		{
			[Token(Token = "0x60035A1")]
			[Address(RVA = "0x40BA434", Offset = "0x40B6434", VA = "0x40BA434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000799")]
		public TextMeshProUGUI TextMeshProUGUIBoostTxt
		{
			[Token(Token = "0x60035A2")]
			[Address(RVA = "0x40BC54C", Offset = "0x40B854C", VA = "0x40BC54C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700079A")]
		public ButtonExtend ButtonExtendClaim
		{
			[Token(Token = "0x60035A3")]
			[Address(RVA = "0x40BAD38", Offset = "0x40B6D38", VA = "0x40BAD38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700079B")]
		public TextMeshProUGUI TextMeshProUGUIText
		{
			[Token(Token = "0x60035A4")]
			[Address(RVA = "0x40BC484", Offset = "0x40B8484", VA = "0x40BC484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700079C")]
		public ButtonExtend ButtonExtendBtnCancel
		{
			[Token(Token = "0x60035A5")]
			[Address(RVA = "0x40BC7B0", Offset = "0x40B87B0", VA = "0x40BC7B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60035A6")]
		[Address(RVA = "0x40BC878", Offset = "0x40B8878", VA = "0x40BC878")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60035A7")]
		[Address(RVA = "0x40BB538", Offset = "0x40B7538", VA = "0x40BB538", Slot = "12")]
		protected virtual void OnButtonExtendBtnExitClicked()
		{
		}

		[Token(Token = "0x60035A8")]
		[Address(RVA = "0x40BC9D4", Offset = "0x40B89D4", VA = "0x40BC9D4", Slot = "13")]
		protected virtual void OnAdButtonExtendAdClicked()
		{
		}

		[Token(Token = "0x60035A9")]
		[Address(RVA = "0x40BB70C", Offset = "0x40B770C", VA = "0x40BB70C", Slot = "14")]
		protected virtual void OnButtonExtendClaimClicked()
		{
		}

		[Token(Token = "0x60035AA")]
		[Address(RVA = "0x40BB4AC", Offset = "0x40B74AC", VA = "0x40BB4AC", Slot = "15")]
		protected virtual void OnButtonExtendBtnCancelClicked()
		{
		}

		[Token(Token = "0x60035AB")]
		[Address(RVA = "0x40BA418", Offset = "0x40B6418", VA = "0x40BA418", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60035AC")]
		[Address(RVA = "0x40BB82C", Offset = "0x40B782C", VA = "0x40BB82C", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__285))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60035AD")]
		[Address(RVA = "0x40BB8C4", Offset = "0x40B78C4", VA = "0x40BB8C4", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60035AE")]
		[Address(RVA = "0x40BB820", Offset = "0x40B7820", VA = "0x40BB820")]
		public MainCityIdleRewardPanelComponents()
		{
		}
	}
}
