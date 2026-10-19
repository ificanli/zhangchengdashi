using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BadgeGraph;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;

namespace GameModule
{
	[Token(Token = "0x20005AA")]
	public class ShopManager : ManagerBase<ShopManager>
	{
		[Token(Token = "0x20005AB")]
		public enum TimingPushGiftPackType
		{
			[Token(Token = "0x40030BF")]
			CardCustom = 0,
			[Token(Token = "0x40030C0")]
			PropCustom = 1,
			[Token(Token = "0x40030C1")]
			Resources = 2
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005B5")]
		[CompilerGenerated]
		private struct _003CBuyProductCallBack_003Ed__25 : IAsyncStateMachine
		{
			[Token(Token = "0x40030D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40030D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40030D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopManager _003C_003E4__this;

			[Token(Token = "0x6001DCD")]
			[Address(RVA = "0x3EE6F90", Offset = "0x3EE2F90", VA = "0x3EE6F90", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001DCE")]
			[Address(RVA = "0x3EE73CC", Offset = "0x3EE33CC", VA = "0x3EE73CC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005B6")]
		[CompilerGenerated]
		private struct _003CGrantMonthPassImmediateDiamondRewardAsync_003Ed__28 : IAsyncStateMachine
		{
			[Token(Token = "0x40030D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40030D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40030DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool fromBuyButton;

			[Token(Token = "0x40030DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001DCF")]
			[Address(RVA = "0x3EE73D8", Offset = "0x3EE33D8", VA = "0x3EE73D8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001DD0")]
			[Address(RVA = "0x3EE8430", Offset = "0x3EE4430", VA = "0x3EE8430", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005B7")]
		[CompilerGenerated]
		private struct _003CHideMask_003Ed__29 : IAsyncStateMachine
		{
			[Token(Token = "0x40030DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40030DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40030DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001DD1")]
			[Address(RVA = "0x3EE843C", Offset = "0x3EE443C", VA = "0x3EE843C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001DD2")]
			[Address(RVA = "0x3EE8764", Offset = "0x3EE4764", VA = "0x3EE8764", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005B8")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__21 : IAsyncStateMachine
		{
			[Token(Token = "0x40030DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40030E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40030E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ShopManager _003C_003E4__this;

			[Token(Token = "0x6001DD3")]
			[Address(RVA = "0x3EE8770", Offset = "0x3EE4770", VA = "0x3EE8770", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001DD4")]
			[Address(RVA = "0x3EE949C", Offset = "0x3EE549C", VA = "0x3EE949C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005B9")]
		[CompilerGenerated]
		private struct _003CPurchaseProductCallBack_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40030E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40030E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40030E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string productId;

			[Token(Token = "0x40030E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ShopManager _003C_003E4__this;

			[Token(Token = "0x40030E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GlobalShopInfo _003CshopInfo_003E5__2;

			[Token(Token = "0x40030E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private bool _003CisBuy_003E5__3;

			[Token(Token = "0x40030E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001DD5")]
			[Address(RVA = "0x3EE94A8", Offset = "0x3EE54A8", VA = "0x3EE94A8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001DD6")]
			[Address(RVA = "0x3EECA20", Offset = "0x3EE8A20", VA = "0x3EECA20", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20005BA")]
		[CompilerGenerated]
		private struct _003CRefreshDayCommodity_003Ed__32 : IAsyncStateMachine
		{
			[Token(Token = "0x40030E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40030EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40030EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShopManager _003C_003E4__this;

			[Token(Token = "0x6001DD7")]
			[Address(RVA = "0x3EECA2C", Offset = "0x3EE8A2C", VA = "0x3EECA2C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001DD8")]
			[Address(RVA = "0x3EECBA8", Offset = "0x3EE8BA8", VA = "0x3EECBA8", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40030B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThrottleTrigger redDotThrottleTrigger;

		[Token(Token = "0x40030B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly int[] CardCustomNum;

		[Token(Token = "0x40030BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly int[] PropCustomNum;

		[Token(Token = "0x40030BB")]
		public const string CardTitle = "Card";

		[Token(Token = "0x40030BC")]
		public const string PropTitle = "Prop";

		[Token(Token = "0x1700017F")]
		public string RewardPartsCustom
		{
			[Token(Token = "0x6001D7F")]
			[Address(RVA = "0x3EDF7C0", Offset = "0x3EDB7C0", VA = "0x3EDF7C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000180")]
		public string PendingCongratulationsGiftPackReward
		{
			[Token(Token = "0x6001D80")]
			[Address(RVA = "0x3EDF84C", Offset = "0x3EDB84C", VA = "0x3EDF84C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D81")]
			[Address(RVA = "0x3EDF854", Offset = "0x3EDB854", VA = "0x3EDF854")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6001D82")]
		[Address(RVA = "0x3EDF85C", Offset = "0x3EDB85C", VA = "0x3EDF85C")]
		public static bool TryParseArtifactPackRewardTemplate(string reward, out string propId, out int propCount, out List<string> resourceSegments)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ShopManager.TryParseArtifactPackRewardTemplate RVA=0x3EDF85C Token=0x6001D82");
}

		[Token(Token = "0x6001D83")]
		[Address(RVA = "0x3EDFB1C", Offset = "0x3EDBB1C", VA = "0x3EDFB1C")]
		public void ResetArtifactPackToTemplateOnceIfNeeded()
		{
		}

		[Token(Token = "0x6001D84")]
		[Address(RVA = "0x3EDFC4C", Offset = "0x3EDBC4C", VA = "0x3EDFC4C")]
		public void RefreshArtifactPackFromGlobalTemplate()
		{
		}

		[Token(Token = "0x6001D85")]
		[Address(RVA = "0x3EDFC9C", Offset = "0x3EDBC9C", VA = "0x3EDFC9C")]
		private void SyncArtifactPackPropCountFromTemplateIfChanged()
		{
		}

		[Token(Token = "0x6001D86")]
		[Address(RVA = "0x3EDFCEC", Offset = "0x3EDBCEC", VA = "0x3EDFCEC")]
		public void RefreshArtifactPackPropRandomSameRare()
		{
		}

		[Token(Token = "0x6001D87")]
		[Address(RVA = "0x3EDFD44", Offset = "0x3EDBD44", VA = "0x3EDFD44")]
		private string GetArtifactPackRewardShopStyleSegments(GlobalShopInfo tierRow)
		{
			return null;
		}

		[Token(Token = "0x6001D88")]
		[Address(RVA = "0x3EDFD9C", Offset = "0x3EDBD9C", VA = "0x3EDFD9C")]
		private string BuildArtifactPackPurchaseRewardString(GlobalShopInfo tierRow)
		{
			return null;
		}

		[Token(Token = "0x6001D89")]
		[Address(RVA = "0x3EE008C", Offset = "0x3EDC08C", VA = "0x3EE008C")]
		private void CheckRedDot()
		{
		}

		[Token(Token = "0x6001D8A")]
		[Address(RVA = "0x3EE03C4", Offset = "0x3EDC3C4", VA = "0x3EE03C4")]
		private static string BuildRewardStringFromConfig(Dictionary<string, int> config)
		{
			return null;
		}

		[Token(Token = "0x6001D8B")]
		[Address(RVA = "0x3EDFE10", Offset = "0x3EDBE10", VA = "0x3EDFE10")]
		private static string BuildRewardStringFromPartsSegments(string parts)
		{
			return null;
		}

		[Token(Token = "0x6001D8C")]
		[Address(RVA = "0x3EE06A8", Offset = "0x3EDC6A8", VA = "0x3EE06A8", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__21))]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001D8D")]
		[Address(RVA = "0x3EE0738", Offset = "0x3EDC738", VA = "0x3EE0738")]
		private void InitUniversalCardData()
		{
		}

		[Token(Token = "0x6001D8E")]
		[Address(RVA = "0x3EE09FC", Offset = "0x3EDC9FC", VA = "0x3EE09FC")]
		public void RefreshUserUniversalCardData()
		{
		}

		[Token(Token = "0x6001D8F")]
		[Address(RVA = "0x3EE0D30", Offset = "0x3EDCD30", VA = "0x3EE0D30")]
		public void RecordCustomRewardParts(string customReward)
		{
		}

		[Token(Token = "0x6001D90")]
		[Address(RVA = "0x3EE0DD8", Offset = "0x3EDCDD8", VA = "0x3EE0DD8")]
		[AsyncStateMachine(typeof(_003CBuyProductCallBack_003Ed__25))]
		private void BuyProductCallBack()
		{
		}

		[Token(Token = "0x6001D91")]
		[Address(RVA = "0x3EE0E64", Offset = "0x3EDCE64", VA = "0x3EE0E64")]
		[AsyncStateMachine(typeof(_003CPurchaseProductCallBack_003Ed__26))]
		public void PurchaseProductCallBack(string productId)
		{
		}

		[Token(Token = "0x6001D92")]
		[Address(RVA = "0x3EE0F04", Offset = "0x3EDCF04", VA = "0x3EE0F04")]
		public int GetNum(RareLevel rare, bool isCard)
		{
			return default;
		}

		[Token(Token = "0x6001D93")]
		[Address(RVA = "0x3EE0FB8", Offset = "0x3EDCFB8", VA = "0x3EE0FB8")]
		[AsyncStateMachine(typeof(_003CGrantMonthPassImmediateDiamondRewardAsync_003Ed__28))]
		private UniTask GrantMonthPassImmediateDiamondRewardAsync(bool fromBuyButton)
		{
			return default;
		}

		[Token(Token = "0x6001D94")]
		[Address(RVA = "0x3EE1054", Offset = "0x3EDD054", VA = "0x3EE1054")]
		[AsyncStateMachine(typeof(_003CHideMask_003Ed__29))]
		private void HideMask()
		{
		}

		[Token(Token = "0x6001D95")]
		[Address(RVA = "0x3EE10DC", Offset = "0x3EDD0DC", VA = "0x3EE10DC")]
		private void ShowShopPanel(object obj)
		{
		}

		[Token(Token = "0x6001D96")]
		[Address(RVA = "0x3EE11A8", Offset = "0x3EDD1A8", VA = "0x3EE11A8")]
		private void HideShopPanel(object obj)
		{
		}

		[Token(Token = "0x6001D97")]
		[Address(RVA = "0x3EE120C", Offset = "0x3EDD20C", VA = "0x3EE120C")]
		[AsyncStateMachine(typeof(_003CRefreshDayCommodity_003Ed__32))]
		private void RefreshDayCommodity()
		{
		}

		[Token(Token = "0x6001D98")]
		[Address(RVA = "0x3EE1298", Offset = "0x3EDD298", VA = "0x3EE1298")]
		public void RefreshGiftPackCofigData(Dictionary<string, int> targetPackCofig, string shopInfoPriceValue, int cardFetters, bool isArtifact = false)
		{
		}

		[Token(Token = "0x6001D99")]
		[Address(RVA = "0x3EE1EA0", Offset = "0x3EDDEA0", VA = "0x3EE1EA0")]
		public void RefreshCommonCardPackConfigData(Dictionary<string, int> targetPackConfig, string shopInfoPriceValue, bool forceRefresh = false)
		{
		}

		[Token(Token = "0x6001D9A")]
		[Address(RVA = "0x3EE2814", Offset = "0x3EDE814", VA = "0x3EE2814")]
		public void RefreshAllFetterGiftPackConfigData(Dictionary<string, int> targetPackConfig, string shopInfoPriceValue, bool forceRefresh = false)
		{
		}

		[Token(Token = "0x6001D9B")]
		[Address(RVA = "0x3EE3024", Offset = "0x3EDF024", VA = "0x3EE3024")]
		public void RefreshUserDailyData()
		{
		}

		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0x3EE4624", Offset = "0x3EE0624", VA = "0x3EE4624")]
		public void RecordBuyDaliyReward(string cardId)
		{
		}

		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0x3EE4778", Offset = "0x3EE0778", VA = "0x3EE4778")]
		public void GetADGiftPackReward(int woodNum, int coinNum, string cardId, int cardNum)
		{
		}

		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0x3EE49FC", Offset = "0x3EE09FC", VA = "0x3EE49FC")]
		public void RecordReceiveDailyReward(string dailyRewardKey)
		{
		}

		[Token(Token = "0x6001D9F")]
		[Address(RVA = "0x3EE4B10", Offset = "0x3EE0B10", VA = "0x3EE4B10")]
		public bool CheckReceivedDailyReward(string dailyRewardKey)
		{
			return default;
		}

		[Token(Token = "0x6001DA0")]
		[Address(RVA = "0x3EE4B9C", Offset = "0x3EE0B9C", VA = "0x3EE4B9C")]
		public void RecordWatchAdCount()
		{
		}

		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0x3EE4C24", Offset = "0x3EE0C24", VA = "0x3EE4C24")]
		public void ResetWatchAdCount()
		{
		}

		[Token(Token = "0x6001DA2")]
		[Address(RVA = "0x3EE4CA4", Offset = "0x3EE0CA4", VA = "0x3EE4CA4")]
		public void ResetPopPacks()
		{
		}

		[Token(Token = "0x6001DA3")]
		[Address(RVA = "0x3EE4D28", Offset = "0x3EE0D28", VA = "0x3EE4D28")]
		public void InitShopArenaPackData()
		{
		}

		[Token(Token = "0x6001DA4")]
		[Address(RVA = "0x3ECB7D4", Offset = "0x3EC77D4", VA = "0x3ECB7D4")]
		public List<ArenaPackageData> GetShowArenaPackData()
		{
			return null;
		}

		[Token(Token = "0x6001DA5")]
		[Address(RVA = "0x3EE4F8C", Offset = "0x3EE0F8C", VA = "0x3EE4F8C")]
		public bool TryGetHighestShowArenaPackForMainPanel(out ArenaPackageData data, out ShopArenaPackInfos config, out GlobalIAPInfo iapInfo)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ShopManager.TryGetHighestShowArenaPackForMainPanel RVA=0x3EE4F8C Token=0x6001DA5");
}

		[Token(Token = "0x6001DA6")]
		[Address(RVA = "0x3EE5168", Offset = "0x3EE1168", VA = "0x3EE5168")]
		public bool IsShowShopArenaPack()
		{
			return default;
		}

		[Token(Token = "0x6001DA7")]
		[Address(RVA = "0x3EE51AC", Offset = "0x3EE11AC", VA = "0x3EE51AC")]
		public void ArenaPackagePurchaseOrPastDue(ArenaPackageData data)
		{
		}

		[Token(Token = "0x6001DA8")]
		[Address(RVA = "0x3EE52F4", Offset = "0x3EE12F4", VA = "0x3EE52F4")]
		public ShopManager()
		{
		}
	}
}
