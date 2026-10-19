using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UIFramework;
using UnityEngine.UI;

namespace UIModuleO
{
	[Token(Token = "0x2000860")]
	public class dayAwardItemComponents : UIPanel, IUIPanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000861")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__245 : IAsyncStateMachine
		{
			[Token(Token = "0x4003F88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003F89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003F8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public dayAwardItemComponents _003C_003E4__this;

			[Token(Token = "0x4003F8B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6002F21")]
			[Address(RVA = "0x402B130", Offset = "0x4027130", VA = "0x402B130", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6002F22")]
			[Address(RVA = "0x402B3A8", Offset = "0x40273A8", VA = "0x402B3A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4003F84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMeshProUGUI _textMeshProUGUIDayText;

		[Token(Token = "0x4003F85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RewardItemUI _rewardItemUIRewardItemUI1;

		[Token(Token = "0x4003F86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RewardItemUI _rewardItemUIRewardItemUI2;

		[Token(Token = "0x4003F87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image _imagePurchaseMask;

		[Token(Token = "0x17000588")]
		public TextMeshProUGUI TextMeshProUGUIDayText
		{
			[Token(Token = "0x6002F17")]
			[Address(RVA = "0x402ACA4", Offset = "0x4026CA4", VA = "0x402ACA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000589")]
		public RewardItemUI RewardItemUIRewardItemUI1
		{
			[Token(Token = "0x6002F18")]
			[Address(RVA = "0x402AE34", Offset = "0x4026E34", VA = "0x402AE34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700058A")]
		public RewardItemUI RewardItemUIRewardItemUI2
		{
			[Token(Token = "0x6002F19")]
			[Address(RVA = "0x402AEFC", Offset = "0x4026EFC", VA = "0x402AEFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700058B")]
		public Image ImagePurchaseMask
		{
			[Token(Token = "0x6002F1A")]
			[Address(RVA = "0x402AD6C", Offset = "0x4026D6C", VA = "0x402AD6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F1B")]
		[Address(RVA = "0x402AFD4", Offset = "0x4026FD4", VA = "0x402AFD4")]
		private void AddEvent()
		{
		}

		[Token(Token = "0x6002F1C")]
		[Address(RVA = "0x402AFD8", Offset = "0x4026FD8", VA = "0x402AFD8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6002F1D")]
		[Address(RVA = "0x402AFE0", Offset = "0x4026FE0", VA = "0x402AFE0", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__245))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6002F1E")]
		[Address(RVA = "0x402B074", Offset = "0x4027074", VA = "0x402B074", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6002F1F")]
		[Address(RVA = "0x402AFCC", Offset = "0x4026FCC", VA = "0x402AFCC")]
		public dayAwardItemComponents()
		{
		}
	}
}
