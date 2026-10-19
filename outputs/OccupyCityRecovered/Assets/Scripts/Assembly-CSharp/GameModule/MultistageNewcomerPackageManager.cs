using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x20004F9")]
	public class MultistageNewcomerPackageManager : ManagerBase<MultistageNewcomerPackageManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000500")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__3 : IAsyncStateMachine
		{
			[Token(Token = "0x4002D3B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4002D3C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4002D3D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MultistageNewcomerPackageManager _003C_003E4__this;

			[Token(Token = "0x600193E")]
			[Address(RVA = "0x3E8FFAC", Offset = "0x3E8BFAC", VA = "0x3E8FFAC", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600193F")]
			[Address(RVA = "0x3E902E4", Offset = "0x3E8C2E4", VA = "0x3E902E4", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4002D2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<MultistageNewcomerPackagePanelData> dataList;

		[Token(Token = "0x4002D2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isShowMultistageNewBieGiftPack;

		[Token(Token = "0x4002D2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isShowMultistageNewBieGiftPackPanel;

		[Token(Token = "0x6001914")]
		[Address(RVA = "0x3E8D744", Offset = "0x3E89744", VA = "0x3E8D744", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__3))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001915")]
		[Address(RVA = "0x3E8D7C8", Offset = "0x3E897C8", VA = "0x3E8D7C8")]
		private void TryInitMissingV1AppearTimeForUnpurchased(List<MultistageNewcomerPackageData> packageDataList)
		{
		}

		[Token(Token = "0x6001916")]
		[Address(RVA = "0x3E8D9B4", Offset = "0x3E899B4", VA = "0x3E8D9B4")]
		public void RefreshIsShowMultistageNewBieGiftPack()
		{
		}

		[Token(Token = "0x6001917")]
		[Address(RVA = "0x3E8DE0C", Offset = "0x3E89E0C", VA = "0x3E8DE0C")]
		public void UpdateRedDot()
		{
		}

		[Token(Token = "0x6001918")]
		[Address(RVA = "0x3E8E0F0", Offset = "0x3E8A0F0", VA = "0x3E8E0F0")]
		public void GetDayAward(int index)
		{
		}

		[Token(Token = "0x6001919")]
		[Address(RVA = "0x3E8EA60", Offset = "0x3E8AA60", VA = "0x3E8EA60")]
		private void OnStarterpackPurchaseSucceed(object obj)
		{
		}

		[Token(Token = "0x600191A")]
		[Address(RVA = "0x3E8E374", Offset = "0x3E8A374", VA = "0x3E8E374")]
		public void UpdateData()
		{
		}

		[Token(Token = "0x600191B")]
		[Address(RVA = "0x3E8EE48", Offset = "0x3E8AE48", VA = "0x3E8EE48")]
		public bool HasUnpurchasedTier()
		{
			return default;
		}

		[Token(Token = "0x600191C")]
		[Address(RVA = "0x3E8EF20", Offset = "0x3E8AF20", VA = "0x3E8EF20")]
		public bool ShouldShowNewcomerWayForResource(string resourceId)
		{
			return default;
		}

		[Token(Token = "0x600191D")]
		[Address(RVA = "0x3E8F0D4", Offset = "0x3E8B0D4", VA = "0x3E8F0D4")]
		public bool RewardContainsResource(string rewardStr, string resourceId)
		{
			return default;
		}

		[Token(Token = "0x600191E")]
		[Address(RVA = "0x3E8F254", Offset = "0x3E8B254", VA = "0x3E8F254")]
		public bool CanClaimNow(MultistageNewcomerPackageData userData)
		{
			return default;
		}

		[Token(Token = "0x600191F")]
		[Address(RVA = "0x3E8F2BC", Offset = "0x3E8B2BC", VA = "0x3E8F2BC")]
		public bool CanPurchaseNow(MultistageNewcomerPackageData userData)
		{
			return default;
		}

		[Token(Token = "0x6001920")]
		[Address(RVA = "0x3E8F36C", Offset = "0x3E8B36C", VA = "0x3E8F36C")]
		public void ShowPanel([Optional] string placement)
		{
		}

		[Token(Token = "0x6001921")]
		[Address(RVA = "0x3E8F378", Offset = "0x3E8B378", VA = "0x3E8F378")]
		public void ShowPanel(string placement, NewcomerPackageFocusMode focusMode, string targetResourceId)
		{
		}

		[Token(Token = "0x6001922")]
		[Address(RVA = "0x3E8EF74", Offset = "0x3E8AF74", VA = "0x3E8EF74")]
		private bool HasPurchasedTierWithPendingResource(string resourceId)
		{
			return default;
		}

		[Token(Token = "0x6001923")]
		[Address(RVA = "0x3E8F680", Offset = "0x3E8B680", VA = "0x3E8F680")]
		private bool AllRewardsContainResource(MultistageNewcomerPackagePanelData panelData, string resourceId)
		{
			return default;
		}

		[Token(Token = "0x6001924")]
		[Address(RVA = "0x3E8F618", Offset = "0x3E8B618", VA = "0x3E8F618")]
		private bool RemainingRewardsContainResource(MultistageNewcomerPackagePanelData panelData, MultistageNewcomerPackageData userData, string resourceId)
		{
			return default;
		}

		[Token(Token = "0x6001925")]
		[Address(RVA = "0x3E8F728", Offset = "0x3E8B728", VA = "0x3E8F728")]
		private bool RewardsUnionContainResource(string resourceId, params string[] rewardStrList)
		{
			return default;
		}

		[Token(Token = "0x6001926")]
		[Address(RVA = "0x3E8F5E8", Offset = "0x3E8B5E8", VA = "0x3E8F5E8")]
		private bool HasRemainingUnclaimedRewards(MultistageNewcomerPackageData userData)
		{
			return default;
		}

		[Token(Token = "0x6001927")]
		[Address(RVA = "0x3E8F7A0", Offset = "0x3E8B7A0", VA = "0x3E8F7A0")]
		private string GetClaimableRewardStr(MultistageNewcomerPackagePanelData panelData, MultistageNewcomerPackageData userData)
		{
			return null;
		}

		[Token(Token = "0x6001928")]
		[Address(RVA = "0x3E8F5C8", Offset = "0x3E8B5C8", VA = "0x3E8F5C8")]
		private int GetFocusPackageIndex(NewcomerPackageFocusMode focusMode, string targetResourceId)
		{
			return default;
		}

		[Token(Token = "0x6001929")]
		[Address(RVA = "0x3E8F824", Offset = "0x3E8B824", VA = "0x3E8F824")]
		private int GetFirstUnpurchasedPackageIndex()
		{
			return default;
		}

		[Token(Token = "0x600192A")]
		[Address(RVA = "0x3E8F8F4", Offset = "0x3E8B8F4", VA = "0x3E8F8F4")]
		private int GetFirstPendingRewardIndexForResource(string resourceId)
		{
			return default;
		}

		[Token(Token = "0x600192B")]
		[Address(RVA = "0x3E8FB6C", Offset = "0x3E8BB6C", VA = "0x3E8FB6C")]
		private int GetDefaultFocusPackageIndex()
		{
			return default;
		}

		[Token(Token = "0x600192C")]
		[Address(RVA = "0x3E8FD34", Offset = "0x3E8BD34", VA = "0x3E8FD34")]
		public MultistageNewcomerPackageManager()
		{
		}
	}
}
