using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using TimeModuleO;

namespace UIModuleO
{
	[Token(Token = "0x2000985")]
	public class MainReadyPanel_IAPBtnRoot_Right : MainReadyPanel_IAPBtnRoot_RightComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000987")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__5 : IAsyncStateMachine
		{
			[Token(Token = "0x400475B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400475C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400475D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MainReadyPanel_IAPBtnRoot_Right _003C_003E4__this;

			[Token(Token = "0x400475E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x6003850")]
			[Address(RVA = "0x40F4A70", Offset = "0x40F0A70", VA = "0x40F4A70", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6003851")]
			[Address(RVA = "0x40F50EC", Offset = "0x40F10EC", VA = "0x40F50EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4004755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private TimeManager.Timer newBieTimer;

		[Token(Token = "0x4004756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _v1CountdownRefreshTimer;

		[Token(Token = "0x6003835")]
		[Address(RVA = "0x40F1FC0", Offset = "0x40EDFC0", VA = "0x40F1FC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6003836")]
		[Address(RVA = "0x40F2618", Offset = "0x40EE618", VA = "0x40F2618")]
		public void ResetView()
		{
		}

		[Token(Token = "0x6003837")]
		[Address(RVA = "0x40F2C44", Offset = "0x40EEC44", VA = "0x40F2C44")]
		private void CheckFundBtn()
		{
		}

		[Token(Token = "0x6003838")]
		[Address(RVA = "0x40F2DE4", Offset = "0x40EEDE4", VA = "0x40F2DE4", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__5))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6003839")]
		[Address(RVA = "0x40F2E78", Offset = "0x40EEE78", VA = "0x40F2E78")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600383A")]
		[Address(RVA = "0x40F2F98", Offset = "0x40EEF98", VA = "0x40F2F98")]
		private void UpdateDailyBlessBtnActive(object o)
		{
		}

		[Token(Token = "0x600383B")]
		[Address(RVA = "0x40F3148", Offset = "0x40EF148", VA = "0x40F3148")]
		private void UpdateSeasonPassEntranceBtnActive(object o)
		{
		}

		[Token(Token = "0x600383C")]
		[Address(RVA = "0x40F33A4", Offset = "0x40EF3A4", VA = "0x40F33A4")]
		private void UpdateCheckInRewardBtnActive(object o)
		{
		}

		[Token(Token = "0x600383D")]
		[Address(RVA = "0x40F350C", Offset = "0x40EF50C", VA = "0x40F350C", Slot = "17")]
		protected override void OnButtonExtendBtnCheckInRewardClicked()
		{
		}

		[Token(Token = "0x600383E")]
		[Address(RVA = "0x40F3650", Offset = "0x40EF650", VA = "0x40F3650", Slot = "14")]
		protected override void OnButtonExtendBtnNewPackClicked()
		{
		}

		[Token(Token = "0x600383F")]
		[Address(RVA = "0x40F3974", Offset = "0x40EF974", VA = "0x40F3974", Slot = "16")]
		protected override void OnButtonExtendBtnMonthPassClicked()
		{
		}

		[Token(Token = "0x6003840")]
		[Address(RVA = "0x40F3A4C", Offset = "0x40EFA4C", VA = "0x40F3A4C")]
		private void Update()
		{
		}

		[Token(Token = "0x6003841")]
		[Address(RVA = "0x40F3C70", Offset = "0x40EFC70", VA = "0x40F3C70")]
		private void RefreshV1Countdown()
		{
		}

		[Token(Token = "0x6003842")]
		[Address(RVA = "0x40F40D0", Offset = "0x40F00D0", VA = "0x40F40D0")]
		private MultistageNewcomerPackageData GetV1CountdownTargetTier()
		{
			return null;
		}

		[Token(Token = "0x6003843")]
		[Address(RVA = "0x40F4228", Offset = "0x40F0228", VA = "0x40F4228")]
		private void NewBieGiftPackDisappear(object o)
		{
		}

		[Token(Token = "0x6003844")]
		[Address(RVA = "0x40F4610", Offset = "0x40F0610", VA = "0x40F4610")]
		private void BuyMonthPass(object o)
		{
		}

		[Token(Token = "0x6003845")]
		[Address(RVA = "0x40F4728", Offset = "0x40F0728", VA = "0x40F4728", Slot = "18")]
		protected override void OnButtonExtendBtnDailyBlessClicked()
		{
		}

		[Token(Token = "0x6003846")]
		[Address(RVA = "0x40F47E8", Offset = "0x40F07E8", VA = "0x40F47E8", Slot = "15")]
		protected override void OnButtonExtendBtnFundClicked()
		{
		}

		[Token(Token = "0x6003847")]
		[Address(RVA = "0x40F48C4", Offset = "0x40F08C4", VA = "0x40F48C4")]
		public MainReadyPanel_IAPBtnRoot_Right()
		{
		}
	}
}
