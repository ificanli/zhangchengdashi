using System;
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
	[Token(Token = "0x2000589")]
	public class RewardManager : ManagerBase<RewardManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200058C")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4003033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RewardManager _003C_003E4__this;

			[Token(Token = "0x6001CC2")]
			[Address(RVA = "0x3ED4720", Offset = "0x3ED0720", VA = "0x3ED4720", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001CC3")]
			[Address(RVA = "0x3ED49A8", Offset = "0x3ED09A8", VA = "0x3ED49A8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400302D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static RewardBoostCtrl RewardBoost;

		[Token(Token = "0x400302E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RewardConfig _rewardConfig;

		[Token(Token = "0x400302F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<RewardConfig> OnShowPanel;

		[Token(Token = "0x6001CAE")]
		[Address(RVA = "0x3ED35E8", Offset = "0x3ECF5E8", VA = "0x3ED35E8", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__2))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001CAF")]
		[Address(RVA = "0x3EC84A4", Offset = "0x3EC44A4", VA = "0x3EC84A4")]
		public RewardConfig GetRewardConfig(string rewardStr, CurrencyTransactionSceneType currencyTransactionSceneType = CurrencyTransactionSceneType.shop_related)
		{
			return null;
		}

		[Token(Token = "0x6001CB0")]
		[Address(RVA = "0x3ED3860", Offset = "0x3ECF860", VA = "0x3ED3860")]
		public void RewardUserAndShowPanel(string rewardStr, CurrencyTransactionSceneType type)
		{
		}

		[Token(Token = "0x6001CB1")]
		[Address(RVA = "0x3ED3ABC", Offset = "0x3ECFABC", VA = "0x3ED3ABC")]
		public void RewardUser(string rewardStr, CurrencyTransactionSceneType type)
		{
		}

		[Token(Token = "0x6001CB2")]
		[Address(RVA = "0x3ED387C", Offset = "0x3ECF87C", VA = "0x3ED387C")]
		public void RewardUserAndShowPanel(RewardConfig rewardConfig)
		{
		}

		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x3ED3AD8", Offset = "0x3ECFAD8", VA = "0x3ED3AD8")]
		public void RewardUser(RewardConfig rewardConfig)
		{
		}

		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x3ED3B74", Offset = "0x3ECFB74", VA = "0x3ED3B74")]
		private static bool IsValidRewardConfig(RewardConfig rewardConfig)
		{
			return default;
		}

		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0x3ED3D90", Offset = "0x3ECFD90", VA = "0x3ED3D90")]
		public void CloseRewardPanel(object obj)
		{
		}

		[Token(Token = "0x6001CB6")]
		[Address(RVA = "0x3ED3DF8", Offset = "0x3ECFDF8", VA = "0x3ED3DF8")]
		public static bool TryFindAssetsInfo(string infoId, out IGlobalAssetsInfo info)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RewardManager.TryFindAssetsInfo RVA=0x3ED3DF8 Token=0x6001CB6");
}

		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x3ED41BC", Offset = "0x3ED01BC", VA = "0x3ED41BC")]
		private static bool TryFindRandomCardInfo(string infoId, out IGlobalAssetsInfo info)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED RewardManager.TryFindRandomCardInfo RVA=0x3ED41BC Token=0x6001CB7");
}

		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0x3ED43B8", Offset = "0x3ED03B8", VA = "0x3ED43B8")]
		private static bool HasUnownedCardsForRandom(GlobalRandomHeroCardInfo randomCardInfo)
		{
			return default;
		}

		[Token(Token = "0x6001CB9")]
		[Address(RVA = "0x3ED45C4", Offset = "0x3ED05C4", VA = "0x3ED45C4")]
		public RewardManager()
		{
		}
	}
}
