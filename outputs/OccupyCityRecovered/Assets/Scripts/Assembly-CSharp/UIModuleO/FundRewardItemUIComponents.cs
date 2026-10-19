using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UIFramework;
using UnityEngine;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x20008A1")]
	public class FundRewardItemUIComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20008A2")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__197 : IAsyncStateMachine
		{
			[Token(Token = "0x4004159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400415A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400415B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FundRewardItemUIComponents _003C_003E4__this;

			[Token(Token = "0x400415C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x60030DE")]
			[Address(RVA = "0x4054320", Offset = "0x4050320", VA = "0x4054320", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60030DF")]
			[Address(RVA = "0x4054598", Offset = "0x4050598", VA = "0x4054598", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RewardItemUI _rewardItemUIFundRewardItemUI;

		[Token(Token = "0x4004154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DOTweenAnimation _dOTweenAnimationFundRewardItemUI;

		[Token(Token = "0x4004155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RectTransform _rectTransformLockRect;

		[Token(Token = "0x4004156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransformCanClaim;

		[Token(Token = "0x4004157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RectTransform _rectTransformHadClaimRect;

		[Token(Token = "0x4004158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _imageRedDot_UI;

		[Token(Token = "0x17000609")]
		public RewardItemUI RewardItemUIFundRewardItemUI
		{
			[Token(Token = "0x60030D2")]
			[Address(RVA = "0x4053B20", Offset = "0x404FB20", VA = "0x4053B20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700060A")]
		public DOTweenAnimation DOTweenAnimationFundRewardItemUI
		{
			[Token(Token = "0x60030D3")]
			[Address(RVA = "0x4054110", Offset = "0x4050110", VA = "0x4054110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700060B")]
		public RectTransform RectTransformLockRect
		{
			[Token(Token = "0x60030D4")]
			[Address(RVA = "0x4053EB8", Offset = "0x404FEB8", VA = "0x4053EB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700060C")]
		public RectTransform RectTransformCanClaim
		{
			[Token(Token = "0x60030D5")]
			[Address(RVA = "0x4053F80", Offset = "0x404FF80", VA = "0x4053F80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700060D")]
		public RectTransform RectTransformHadClaimRect
		{
			[Token(Token = "0x60030D6")]
			[Address(RVA = "0x4053DF0", Offset = "0x404FDF0", VA = "0x4053DF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700060E")]
		public Image ImageRedDot_UI
		{
			[Token(Token = "0x60030D7")]
			[Address(RVA = "0x4054048", Offset = "0x4050048", VA = "0x4054048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60030D8")]
		[Address(RVA = "0x40541C4", Offset = "0x40501C4", VA = "0x40541C4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x60030D9")]
		[Address(RVA = "0x40541C8", Offset = "0x40501C8", VA = "0x40541C8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60030DA")]
		[Address(RVA = "0x40541D0", Offset = "0x40501D0", VA = "0x40541D0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__197))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60030DB")]
		[Address(RVA = "0x4054264", Offset = "0x4050264", VA = "0x4054264", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x60030DC")]
		[Address(RVA = "0x40541BC", Offset = "0x40501BC", VA = "0x40541BC")]
		public FundRewardItemUIComponents()
		{
		}
	}
}
