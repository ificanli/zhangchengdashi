using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using GameModule;
using Il2CppDummyDll;
using ljzs_lt;

namespace UIModuleO
{
	[Token(Token = "0x2000B34")]
	public class BuyGiftPackTwoSurePanel : BuyGiftPackTwoSurePanelComponents
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000B36")]
		[CompilerGenerated]
		private struct _003CShow_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x40051BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40051BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40051BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public BuyGiftPackTwoSurePanel _003C_003E4__this;

			[Token(Token = "0x40051BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x40051BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600444B")]
			[Address(RVA = "0x41EABB8", Offset = "0x41E6BB8", VA = "0x41EABB8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600444C")]
			[Address(RVA = "0x41EB444", Offset = "0x41E7444", VA = "0x41EB444", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40051B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private GlobalShopInfo _info;

		[Token(Token = "0x40051B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private CrystalPackConfig _crystalPack;

		[Token(Token = "0x40051B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string _placement;

		[Token(Token = "0x40051B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly List<RewardItemUI> _rewardItemPool;

		[Token(Token = "0x40051B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float lastTriggerPurchaseProductTime;

		[Token(Token = "0x6004433")]
		[Address(RVA = "0x41E83E4", Offset = "0x41E43E4", VA = "0x41E83E4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004434")]
		[Address(RVA = "0x41E85BC", Offset = "0x41E45BC", VA = "0x41E85BC")]
		private void BuyGiftPackSuccess(object o)
		{
		}

		[Token(Token = "0x6004435")]
		[Address(RVA = "0x41E85C8", Offset = "0x41E45C8", VA = "0x41E85C8", Slot = "5")]
		[AsyncStateMachine(typeof(_003CShow_003Ed__7))]
		public override UniTask Show(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x6004436")]
		[Address(RVA = "0x41E8664", Offset = "0x41E4664", VA = "0x41E8664", Slot = "17")]
		protected override void OnButtonExtendBtnBuyClicked()
		{
		}

		[Token(Token = "0x6004437")]
		[Address(RVA = "0x41E89EC", Offset = "0x41E49EC", VA = "0x41E89EC", Slot = "13")]
		protected override void OnButtonExtendBtnCloseClicked()
		{
		}

		[Token(Token = "0x6004438")]
		[Address(RVA = "0x41E8A78", Offset = "0x41E4A78", VA = "0x41E8A78", Slot = "6")]
		public override void Hide()
		{
		}

		[Token(Token = "0x6004439")]
		[Address(RVA = "0x41E8B3C", Offset = "0x41E4B3C", VA = "0x41E8B3C", Slot = "7")]
		protected override void OnHideAnimationComplete()
		{
		}

		[Token(Token = "0x600443A")]
		[Address(RVA = "0x41E8D60", Offset = "0x41E4D60", VA = "0x41E8D60", Slot = "12")]
		protected override void OnButtonBGClicked()
		{
		}

		[Token(Token = "0x600443B")]
		[Address(RVA = "0x41E8DEC", Offset = "0x41E4DEC", VA = "0x41E8DEC")]
		private void EnsureRewardPoolInitialized()
		{
		}

		[Token(Token = "0x600443C")]
		[Address(RVA = "0x41E91D0", Offset = "0x41E51D0", VA = "0x41E91D0")]
		private void ShowCrystalPackConfirm(CrystalPackConfig pack, string placement)
		{
		}

		[Token(Token = "0x600443D")]
		[Address(RVA = "0x41E960C", Offset = "0x41E560C", VA = "0x41E960C")]
		private void RefreshCrystalPackBenefitDisplay(CrystalPackConfig pack)
		{
		}

		[Token(Token = "0x600443E")]
		[Address(RVA = "0x41E9C10", Offset = "0x41E5C10", VA = "0x41E9C10")]
		private List<RewardConfigSingle> BuildGiftPackPreviewRewards(GlobalShopInfo info)
		{
			return null;
		}

		[Token(Token = "0x600443F")]
		[Address(RVA = "0x41EA370", Offset = "0x41E6370", VA = "0x41EA370")]
		private bool IsRuneStonePack(string iapId)
		{
			return default;
		}

		[Token(Token = "0x6004440")]
		[Address(RVA = "0x41EA140", Offset = "0x41E6140", VA = "0x41EA140")]
		private Dictionary<string, int> GetPackConfigData(string iapId)
		{
			return null;
		}

		[Token(Token = "0x6004441")]
		[Address(RVA = "0x41E974C", Offset = "0x41E574C", VA = "0x41E974C")]
		private void UpdateRewardList(List<RewardConfigSingle> rewards)
		{
		}

		[Token(Token = "0x6004442")]
		[Address(RVA = "0x41EA41C", Offset = "0x41E641C", VA = "0x41EA41C")]
		private void UpdateContentTopPadding(int rewardCount)
		{
		}

		[Token(Token = "0x6004443")]
		[Address(RVA = "0x41EA520", Offset = "0x41E6520", VA = "0x41EA520")]
		private void SetScrollEnabled(bool enabled)
		{
		}

		[Token(Token = "0x6004444")]
		[Address(RVA = "0x41EA6E4", Offset = "0x41E66E4", VA = "0x41EA6E4")]
		private void ResetContentToTop()
		{
		}

		[Token(Token = "0x6004445")]
		[Address(RVA = "0x41EAA24", Offset = "0x41E6A24", VA = "0x41EAA24")]
		public BuyGiftPackTwoSurePanel()
		{
		}
	}
}
