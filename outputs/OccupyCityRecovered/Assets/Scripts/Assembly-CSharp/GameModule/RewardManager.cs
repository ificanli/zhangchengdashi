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
		public override async UniTask Init()
		{
            EventModule.EventManager.Instance.StartListening("OnRewardPanelClose", CloseRewardPanel);
        }

		[Token(Token = "0x6001CAF")]
		[Address(RVA = "0x3EC84A4", Offset = "0x3EC44A4", VA = "0x3EC84A4")]
		public RewardConfig GetRewardConfig(string rewardStr, CurrencyTransactionSceneType currencyTransactionSceneType = CurrencyTransactionSceneType.shop_related)
		{ return new RewardConfig(rewardStr, currencyTransactionSceneType); }

		[Token(Token = "0x6001CB0")]
		[Address(RVA = "0x3ED3860", Offset = "0x3ECF860", VA = "0x3ED3860")]
		public void RewardUserAndShowPanel(string rewardStr, CurrencyTransactionSceneType type)
		{
            RewardUserAndShowPanel(GetRewardConfig(rewardStr, type));
        }

		[Token(Token = "0x6001CB1")]
		[Address(RVA = "0x3ED3ABC", Offset = "0x3ECFABC", VA = "0x3ED3ABC")]
		public void RewardUser(string rewardStr, CurrencyTransactionSceneType type)
		{
            RewardUser(GetRewardConfig(rewardStr, type));
        }

		[Token(Token = "0x6001CB2")]
		[Address(RVA = "0x3ED387C", Offset = "0x3ECF87C", VA = "0x3ED387C")]
		public void RewardUserAndShowPanel(RewardConfig rewardConfig)
		{
            if (IsValidRewardConfig(rewardConfig))
            {
                RewardUser(rewardConfig);
                OnShowPanel?.Invoke(rewardConfig);
                OnShowPanel = null;
                RewardConfigSingle firstReward = rewardConfig.RewardAssetList[0];
                if (rewardConfig.RewardAssetList.Count == 1 && firstReward.Info != null
                    && firstReward.Info.Id.StartsWith('4'))
                    return;
                UIFramework.UIManager.Instance.ShowPanel("Assets/_Res/Addressable/Prefabs/UI/Panels/RewardPanel.prefab", rewardConfig);
            }
            else UnityEngine.Debug.LogWarning("[RewardManager] RewardUserAndShowPanel: invalid reward config");
        }

		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x3ED3AD8", Offset = "0x3ECFAD8", VA = "0x3ED3AD8")]
		public void RewardUser(RewardConfig rewardConfig)
		{
            if (IsValidRewardConfig(rewardConfig))
            {
                _rewardConfig = rewardConfig;
                OnShowPanel = null;
                rewardConfig.ApplyReward();
            }
            else UnityEngine.Debug.LogWarning("[RewardManager] RewardUser: invalid reward config");
        }

		[Token(Token = "0x6001CB4")]
		[Address(RVA = "0x3ED3B74", Offset = "0x3ECFB74", VA = "0x3ED3B74")]
		private static bool IsValidRewardConfig(RewardConfig rewardConfig)
		{
            if (rewardConfig == null || rewardConfig.RewardAssetList == null || rewardConfig.RewardAssetList.Count == 0) return false;
            for (int i = 0; i < rewardConfig.RewardAssetList.Count; i++)
            {
                RewardConfigSingle item = rewardConfig.RewardAssetList[i];
                if (item == null || item.Info == null) return false;
            }
            return true;
        }

		[Token(Token = "0x6001CB5")]
		[Address(RVA = "0x3ED3D90", Offset = "0x3ECFD90", VA = "0x3ED3D90")]
		public void CloseRewardPanel(object obj)
		{
            UIFramework.UIManager.Instance.HidePanel("Assets/_Res/Addressable/Prefabs/UI/Panels/RewardPanel.prefab");
        }

		[Token(Token = "0x6001CB6")]
		[Address(RVA = "0x3ED3DF8", Offset = "0x3ECFDF8", VA = "0x3ED3DF8")]
		public static bool TryFindAssetsInfo(string infoId, out IGlobalAssetsInfo info)
		{
            info = null;
            if (string.IsNullOrEmpty(infoId)) return false;
            switch (infoId[0])
            {
                case '1':
                    GlobalHeroCardInfo card;
                    if (!DataManager.Instance.GlobalInfo.heroCardDic.TryGetValue(infoId, out card)) return false;
                    info = card;
                    return true;
                case '2':
                    info = DataManager.Instance.GlobalInfo.baseAssetInfos.Find(item => item.id == infoId);
                    return info != null;
                case '3':
                    GlobalPropInfo prop;
                    if (!DataManager.Instance.GlobalInfo.propInfoDic.TryGetValue(infoId, out prop)) return false;
                    info = prop;
                    return true;
                case '4':
                    info = DataManager.Instance.GlobalInfo.boxInfos.Find(item => item.id == infoId);
                    return info != null;
                case '5':
                    return TryFindRandomCardInfo(infoId, out info);
                case '6':
                    info = DataManager.Instance.GlobalInfo.GlobalBannerInfos.Find(item => item.id == infoId);
                    return info != null;
                case '7':
                    info = DataManager.Instance.GlobalInfo.GlobalExpressionInfos.Find(item => item.id == infoId);
                    return info != null;
                default:
                    return false;
            }
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
