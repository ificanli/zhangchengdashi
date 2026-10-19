using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DataModule;
using Il2CppDummyDll;
using ToolModule;
using UIFramework;
using UIModuleO;
using ljzs_lt;

namespace GameModule
{
	[Token(Token = "0x200056C")]
	public class ResourceObtainGuideManager : ManagerBase<ResourceObtainGuideManager>
	{
		[Token(Token = "0x200056D")]
		public enum ResourceGuideCategory
		{
			[Token(Token = "0x4002FEC")]
			BasicResource = 0,
			[Token(Token = "0x4002FED")]
			Card = 1,
			[Token(Token = "0x4002FEE")]
			LockedCard = 2,
			[Token(Token = "0x4002FEF")]
			Artifact = 3
		}

		[Token(Token = "0x200056E")]
		public enum ResourceGuideJumpType
		{
			[Token(Token = "0x4002FF1")]
			ShopPrimary = 0,
			[Token(Token = "0x4002FF2")]
			ShopSales = 1,
			[Token(Token = "0x4002FF3")]
			MonthPass = 2,
			[Token(Token = "0x4002FF4")]
			NewcomerPackage = 3,
			[Token(Token = "0x4002FF5")]
			Fund = 4,
			[Token(Token = "0x4002FF6")]
			BattleHome = 5,
			[Token(Token = "0x4002FF7")]
			Territory = 6,
			[Token(Token = "0x4002FF8")]
			ArtifactSummon = 7,
			[Token(Token = "0x4002FF9")]
			ArtifactSpecialSummon = 8,
			[Token(Token = "0x4002FFA")]
			MysteriousStore = 9,
			[Token(Token = "0x4002FFB")]
			LevelUpReward = 10,
			[Token(Token = "0x4002FFC")]
			WeeklyCard = 11,
			[Token(Token = "0x4002FFD")]
			MysteryAdventure = 12,
			[Token(Token = "0x4002FFE")]
			CheckInReward = 13,
			[Token(Token = "0x4002FFF")]
			SpecialSummonGift = 14,
			[Token(Token = "0x4003000")]
			ArenaGiftPack = 15,
			[Token(Token = "0x4003001")]
			TimingPushGiftPack = 16,
			[Token(Token = "0x4003002")]
			ElitePack = 17,
			[Token(Token = "0x4003003")]
			SpecialOffer = 18,
			[Token(Token = "0x4003004")]
			WorldCupPointShop = 19,
			[Token(Token = "0x4003005")]
			WorldCupDailyGift = 20
		}

		[Token(Token = "0x200056F")]
		public class ResourceGuideRequest
		{
			[Token(Token = "0x4003006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string ResourceId;

			[Token(Token = "0x4003007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ResourceGuideCategory Category;

			[Token(Token = "0x6001C30")]
			[Address(RVA = "0x3EC97E0", Offset = "0x3EC57E0", VA = "0x3EC97E0")]
			public ResourceGuideRequest()
			{
			}
		}

		[Token(Token = "0x2000570")]
		public class ResourceGuideWayData
		{
			[Token(Token = "0x4003008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x4003009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Description;

			[Token(Token = "0x400300A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResourceGuideJumpType JumpType;

			[Token(Token = "0x400300B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object[] JumpArgs;

			[Token(Token = "0x6001C31")]
			[Address(RVA = "0x3ECCD28", Offset = "0x3EC8D28", VA = "0x3ECCD28")]
			public ResourceGuideWayData(string name, string description, ResourceGuideJumpType jumpType, [Optional] object[] args)
			{
			}
		}

		[Token(Token = "0x2000571")]
		public class ResourceGuidePanelData
		{
			[Token(Token = "0x400300C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ResourceGuideRequest Request;

			[Token(Token = "0x400300D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GlobalInfoBase ResourceInfo;

			[Token(Token = "0x400300E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int CurrentCount;

			[Token(Token = "0x400300F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<ResourceGuideWayData> Ways;

			[Token(Token = "0x6001C32")]
			[Address(RVA = "0x3EC9B3C", Offset = "0x3EC5B3C", VA = "0x3EC9B3C")]
			public ResourceGuidePanelData()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000575")]
		[CompilerGenerated]
		private struct _003CHideAllSecondaryPanelsExceptMetaSwitch_003Ed__31 : IAsyncStateMachine
		{
			[Token(Token = "0x4003014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private UIPanel _003CmetaSwitchPanel_003E5__2;

			[Token(Token = "0x4003017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UIPanel _003CuserResourcesPanel_003E5__3;

			[Token(Token = "0x4003018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UIPanel _003CpropDetailsPanel_003E5__4;

			[Token(Token = "0x4003019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UIPanel _003CcollectTweenPanel_003E5__5;

			[Token(Token = "0x400301A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UIPanel _003CfloatingTextPanel_003E5__6;

			[Token(Token = "0x400301B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UniTask<UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001C3A")]
			[Address(RVA = "0x3ECD50C", Offset = "0x3EC950C", VA = "0x3ECD50C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001C3B")]
			[Address(RVA = "0x3ECE45C", Offset = "0x3ECA45C", VA = "0x3ECE45C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000576")]
		[CompilerGenerated]
		private struct _003CJumpToShopPrimary_003Ed__34 : IAsyncStateMachine
		{
			[Token(Token = "0x400301C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400301D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400301E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string target;

			[Token(Token = "0x400301F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001C3C")]
			[Address(RVA = "0x3ECE468", Offset = "0x3ECA468", VA = "0x3ECE468", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001C3D")]
			[Address(RVA = "0x3ECE8EC", Offset = "0x3ECA8EC", VA = "0x3ECE8EC", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000577")]
		[CompilerGenerated]
		private struct _003CJumpToShopSales_003Ed__35 : IAsyncStateMachine
		{
			[Token(Token = "0x4003020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4003021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4003022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SalesJumpTargetType target;

			[Token(Token = "0x4003023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UniTask<UIPanel>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x6001C3E")]
			[Address(RVA = "0x3ECE8F8", Offset = "0x3ECA8F8", VA = "0x3ECE8F8", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0x3ECED7C", Offset = "0x3ECAD7C", VA = "0x3ECED7C", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6001BF0")]
		[Address(RVA = "0x3EC8010", Offset = "0x3EC4010", VA = "0x3EC8010")]
		private bool CanShowElitePackWay()
		{
			return default;
		}

		[Token(Token = "0x6001BF1")]
		[Address(RVA = "0x3EC811C", Offset = "0x3EC411C", VA = "0x3EC811C")]
		private bool CanShowSpecialOfferWay()
		{
			return default;
		}

		[Token(Token = "0x6001BF2")]
		[Address(RVA = "0x3EC8228", Offset = "0x3EC4228", VA = "0x3EC8228")]
		private bool ArenaPackContainsResource(ArenaPackageData data, string resourceId)
		{
			return default;
		}

		[Token(Token = "0x6001BF3")]
		[Address(RVA = "0x3EC850C", Offset = "0x3EC450C", VA = "0x3EC850C")]
		private bool IsTimingPushGiftPackAvailable()
		{
			return default;
		}

		[Token(Token = "0x6001BF4")]
		[Address(RVA = "0x3EC85DC", Offset = "0x3EC45DC", VA = "0x3EC85DC")]
		private string GetTimingPushGiftPackName(ShopManager.TimingPushGiftPackType type)
		{
			return null;
		}

		[Token(Token = "0x6001BF5")]
		[Address(RVA = "0x3EC87A0", Offset = "0x3EC47A0", VA = "0x3EC87A0")]
		private bool CanShowArtifactPackWay(ResourceGuideRequest request)
		{
			return default;
		}

		[Token(Token = "0x6001BF6")]
		[Address(RVA = "0x3EC8858", Offset = "0x3EC4858", VA = "0x3EC8858")]
		private bool TryGetAvailableRacePackTarget(ResourceGuideRequest request, out SalesJumpTargetType targetType)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ResourceObtainGuideManager.TryGetAvailableRacePackTarget RVA=0x3EC8858 Token=0x6001BF6");
}

		[Token(Token = "0x6001BF7")]
		[Address(RVA = "0x3EC89CC", Offset = "0x3EC49CC", VA = "0x3EC89CC")]
		private bool TryMatchRacePack(Dictionary<string, int> packConfig, string iapId, SalesJumpTargetType salesTargetType, string resourceId, out SalesJumpTargetType targetType)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED ResourceObtainGuideManager.TryMatchRacePack RVA=0x3EC89CC Token=0x6001BF7");
}

		[Token(Token = "0x6001BF8")]
		[Address(RVA = "0x3EC8A90", Offset = "0x3EC4A90", VA = "0x3EC8A90")]
		private bool IsSalesPackAvailable(string iapId)
		{
			return default;
		}

		[Token(Token = "0x6001BF9")]
		[Address(RVA = "0x3EC8B60", Offset = "0x3EC4B60", VA = "0x3EC8B60")]
		private GlobalShopInfo GetSalesShopInfo(string iapId)
		{
			return null;
		}

		[Token(Token = "0x6001BFA")]
		[Address(RVA = "0x3EC8CE4", Offset = "0x3EC4CE4", VA = "0x3EC8CE4")]
		private bool IsGreenCard(string cardId)
		{
			return default;
		}

		[Token(Token = "0x6001BFB")]
		[Address(RVA = "0x3EC8E20", Offset = "0x3EC4E20", VA = "0x3EC8E20")]
		private bool IsGreenArtifact(string propId)
		{
			return default;
		}

		[Token(Token = "0x6001BFC")]
		[Address(RVA = "0x3EC8F5C", Offset = "0x3EC4F5C", VA = "0x3EC8F5C")]
		private bool CanShowCommonCardPackWay(ResourceGuideRequest request)
		{
			return default;
		}

		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x3EC90A8", Offset = "0x3EC50A8", VA = "0x3EC90A8")]
		private bool CanShowDailyDiscountWay(ResourceGuideRequest request)
		{
			return default;
		}

		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x3EC91B4", Offset = "0x3EC51B4", VA = "0x3EC91B4")]
		private bool CanShowWorldCupPointShopWay(ResourceGuideRequest request)
		{
			return default;
		}

		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x3EC9290", Offset = "0x3EC5290", VA = "0x3EC9290")]
		private bool HasAvailableWorldCupPointShopReward(string resourceId)
		{
			return default;
		}

		[Token(Token = "0x6001C00")]
		[Address(RVA = "0x3EC9470", Offset = "0x3EC5470", VA = "0x3EC9470")]
		private bool IsPointShopConfigMatchingResource(PointShopConfig config, string resourceId)
		{
			return default;
		}

		[Token(Token = "0x6001C01")]
		[Address(RVA = "0x3EC95FC", Offset = "0x3EC55FC", VA = "0x3EC95FC")]
		private bool CanShowWorldCupDailyGiftWay()
		{
			return default;
		}

		[Token(Token = "0x6001C02")]
		[Address(RVA = "0x3EC96A0", Offset = "0x3EC56A0", VA = "0x3EC96A0")]
		private bool CanShowSpecialSummonGiftWay()
		{
			return default;
		}

		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x3EC970C", Offset = "0x3EC570C", VA = "0x3EC970C", Slot = "4")]
		public override UniTask Init()
		{
			return default;
		}

		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x3EC9764", Offset = "0x3EC5764", VA = "0x3EC9764")]
		public void ShowGuide(string resourceId, ResourceGuideCategory category)
		{
		}

		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x3EC97E8", Offset = "0x3EC57E8", VA = "0x3EC97E8")]
		private void ShowGuide(ResourceGuideRequest request)
		{
		}

		[Token(Token = "0x6001C06")]
		[Address(RVA = "0x3EC9900", Offset = "0x3EC5900", VA = "0x3EC9900")]
		private ResourceGuidePanelData BuildPanelData(ResourceGuideRequest request)
		{
			return null;
		}

		[Token(Token = "0x6001C07")]
		[Address(RVA = "0x3EC9B44", Offset = "0x3EC5B44", VA = "0x3EC9B44")]
		private List<ResourceGuideWayData> BuildWayList(ResourceGuideRequest request)
		{
			return null;
		}

		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x3ECA3B4", Offset = "0x3EC63B4", VA = "0x3ECA3B4")]
		public void Jump(ResourceGuideWayData wayData, ResourceGuidePanelData panelData)
		{
		}

		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x3ECB554", Offset = "0x3EC7554", VA = "0x3ECB554")]
		private void ReportAfterJump(ResourceGuideWayData wayData, ResourceGuidePanelData panelData)
		{
		}

		[Token(Token = "0x6001C0A")]
		[Address(RVA = "0x3ECAEF8", Offset = "0x3EC6EF8", VA = "0x3ECAEF8")]
		[AsyncStateMachine(typeof(_003CHideAllSecondaryPanelsExceptMetaSwitch_003Ed__31))]
		private UniTask HideAllSecondaryPanelsExceptMetaSwitch()
		{
			return default;
		}

		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x3ECB0A4", Offset = "0x3EC70A4", VA = "0x3ECB0A4")]
		private void JumpToArenaGiftPack(string packId)
		{
		}

		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x3ECB3B4", Offset = "0x3EC73B4", VA = "0x3ECB3B4")]
		private void JumpToTimingPushGiftPack(ShopManager.TimingPushGiftPackType type)
		{
		}

		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x3ECAF84", Offset = "0x3EC6F84", VA = "0x3ECAF84")]
		[AsyncStateMachine(typeof(_003CJumpToShopPrimary_003Ed__34))]
		private UniTask JumpToShopPrimary(string target)
		{
			return default;
		}

		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0x3ECB014", Offset = "0x3EC7014", VA = "0x3ECB014")]
		[AsyncStateMachine(typeof(_003CJumpToShopSales_003Ed__35))]
		private UniTask JumpToShopSales(SalesJumpTargetType target)
		{
			return default;
		}

		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0x3ECA2F0", Offset = "0x3EC62F0", VA = "0x3ECA2F0")]
		private void AddArtifactWays(List<ResourceGuideWayData> ways, ResourceGuideRequest request)
		{
		}

		[Token(Token = "0x6001C10")]
		[Address(RVA = "0x3ECBD0C", Offset = "0x3EC7D0C", VA = "0x3ECBD0C")]
		private void AddArtifactTimingPushGiftPackWay(List<ResourceGuideWayData> ways, ResourceGuideRequest request)
		{
		}

		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x3EC9C34", Offset = "0x3EC5C34", VA = "0x3EC9C34")]
		private void AddBasicResourceWays(List<ResourceGuideWayData> ways, ResourceGuideRequest request)
		{
		}

		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x3ECBF68", Offset = "0x3EC7F68", VA = "0x3ECBF68")]
		private void AddShopPrimaryWay(List<ResourceGuideWayData> ways, string wayName, string description, string target)
		{
		}

		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x3ECBC1C", Offset = "0x3EC7C1C", VA = "0x3ECBC1C")]
		private void AddShopSalesWay(List<ResourceGuideWayData> ways, string wayName, string description, SalesJumpTargetType targetType)
		{
		}

		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x3ECC024", Offset = "0x3EC8024", VA = "0x3ECC024")]
		private void AddMonthPassWay(List<ResourceGuideWayData> ways)
		{
		}

		[Token(Token = "0x6001C15")]
		[Address(RVA = "0x3ECCB80", Offset = "0x3EC8B80", VA = "0x3ECCB80")]
		private void AddNewcomerPackageWay(List<ResourceGuideWayData> ways, bool requireUnpurchasedPack, NewcomerPackageFocusMode focusMode)
		{
		}

		[Token(Token = "0x6001C16")]
		[Address(RVA = "0x3ECC094", Offset = "0x3EC8094", VA = "0x3ECC094")]
		private void AddNewcomerPackageWay(List<ResourceGuideWayData> ways, bool requireUnpurchasedPack, NewcomerPackageFocusMode focusMode, string targetResourceId)
		{
		}

		[Token(Token = "0x6001C17")]
		[Address(RVA = "0x3ECCB8C", Offset = "0x3EC8B8C", VA = "0x3ECCB8C")]
		private void AddCheckInRewardWayIfUnlock(List<ResourceGuideWayData> ways)
		{
		}

		[Token(Token = "0x6001C18")]
		[Address(RVA = "0x3ECCA24", Offset = "0x3EC8A24", VA = "0x3ECCA24")]
		private void AddBattleWay(List<ResourceGuideWayData> ways, string description)
		{
		}

		[Token(Token = "0x6001C19")]
		[Address(RVA = "0x3ECC39C", Offset = "0x3EC839C", VA = "0x3ECC39C")]
		private void AddTerritoryWayIfUnlock(List<ResourceGuideWayData> ways)
		{
		}

		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x3ECC964", Offset = "0x3EC8964", VA = "0x3ECC964")]
		private void AddMainCityPassFundWayIfUnlock(List<ResourceGuideWayData> ways, string description)
		{
		}

		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x3ECBC18", Offset = "0x3EC7C18", VA = "0x3ECBC18")]
		private void AddMysteriousStoreWayIfAvailable(List<ResourceGuideWayData> ways, ResourceGuideRequest request)
		{
		}

		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x3ECBB10", Offset = "0x3EC7B10", VA = "0x3ECBB10")]
		private void AddArtifactSummonWayIfUnlock(List<ResourceGuideWayData> ways, bool isNormal)
		{
		}

		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x3ECCC30", Offset = "0x3EC8C30", VA = "0x3ECCC30")]
		private void AddMysteryAdventureWayIfAvailable(List<ResourceGuideWayData> ways)
		{
		}

		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x3ECC2B0", Offset = "0x3EC82B0", VA = "0x3ECC2B0")]
		private void AddElitePackWayIfAvailable(List<ResourceGuideWayData> ways)
		{
		}

		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x3ECC668", Offset = "0x3EC8668", VA = "0x3ECC668")]
		private void AddSpecialOfferWayIfAvailable(List<ResourceGuideWayData> ways)
		{
		}

		[Token(Token = "0x6001C20")]
		[Address(RVA = "0x3ECCA84", Offset = "0x3EC8A84", VA = "0x3ECCA84")]
		private void AddWay(List<ResourceGuideWayData> ways, string wayName, string description, ResourceGuideJumpType jumpType, [Optional] object[] args)
		{
		}

		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x3ECCD6C", Offset = "0x3EC8D6C", VA = "0x3ECCD6C")]
		private void AddLevelUpRewardWayIfAvailable(List<ResourceGuideWayData> ways)
		{
		}

		[Token(Token = "0x6001C22")]
		[Address(RVA = "0x3ECC84C", Offset = "0x3EC884C", VA = "0x3ECC84C")]
		private void AddFundWayIfAvailable(List<ResourceGuideWayData> ways, string wayName, string description, FundManager.FundType fundType)
		{
		}

		[Token(Token = "0x6001C23")]
		[Address(RVA = "0x3ECC45C", Offset = "0x3EC845C", VA = "0x3ECC45C")]
		private void AddArenaPackWaysIfAvailable(List<ResourceGuideWayData> ways, string resourceId)
		{
		}

		[Token(Token = "0x6001C24")]
		[Address(RVA = "0x3ECBDE8", Offset = "0x3EC7DE8", VA = "0x3ECBDE8")]
		private void AddTimingPushGiftPackWayIfAvailable(List<ResourceGuideWayData> ways, ShopManager.TimingPushGiftPackType requiredType)
		{
		}

		[Token(Token = "0x6001C25")]
		[Address(RVA = "0x3ECBD50", Offset = "0x3EC7D50", VA = "0x3ECBD50")]
		private void AddWorldCupPointShopWayIfAvailable(List<ResourceGuideWayData> ways, ResourceGuideRequest request)
		{
		}

		[Token(Token = "0x6001C26")]
		[Address(RVA = "0x3ECC7D0", Offset = "0x3EC87D0", VA = "0x3ECC7D0")]
		private void AddWorldCupDailyGiftWayIfAvailable(List<ResourceGuideWayData> ways)
		{
		}

		[Token(Token = "0x6001C27")]
		[Address(RVA = "0x3ECC754", Offset = "0x3EC8754", VA = "0x3ECC754")]
		private void AddSpecialSummonGiftWayIfAvailable(List<ResourceGuideWayData> ways)
		{
		}

		[Token(Token = "0x6001C28")]
		[Address(RVA = "0x3ECA258", Offset = "0x3EC6258", VA = "0x3ECA258")]
		private void AddCardWays(List<ResourceGuideWayData> ways, ResourceGuideRequest request, bool locked)
		{
		}

		[Token(Token = "0x6001C29")]
		[Address(RVA = "0x3ECCE10", Offset = "0x3EC8E10", VA = "0x3ECCE10")]
		private bool TryAddExclusiveCardWays(List<ResourceGuideWayData> ways, ResourceGuideRequest request, bool locked)
		{
			return default;
		}

		[Token(Token = "0x6001C2A")]
		[Address(RVA = "0x3ECCFC0", Offset = "0x3EC8FC0", VA = "0x3ECCFC0")]
		private bool TryAddWeeklyCardWays(List<ResourceGuideWayData> ways, ResourceGuideRequest request, bool locked)
		{
			return default;
		}

		[Token(Token = "0x6001C2B")]
		[Address(RVA = "0x3ECD1EC", Offset = "0x3EC91EC", VA = "0x3ECD1EC")]
		private void AddDefaultCardWays(List<ResourceGuideWayData> ways, ResourceGuideRequest request, bool locked)
		{
		}

		[Token(Token = "0x6001C2C")]
		[Address(RVA = "0x3ECD370", Offset = "0x3EC9370", VA = "0x3ECD370")]
		private void AddCardSpecificExtraWays(List<ResourceGuideWayData> ways, ResourceGuideRequest request, bool locked)
		{
		}

		[Token(Token = "0x6001C2D")]
		[Address(RVA = "0x3ECCEB0", Offset = "0x3EC8EB0", VA = "0x3ECCEB0")]
		private void AddSharedCardTailWays(List<ResourceGuideWayData> ways, ResourceGuideRequest request, bool locked)
		{
		}

		[Token(Token = "0x6001C2E")]
		[Address(RVA = "0x3ECCF7C", Offset = "0x3EC8F7C", VA = "0x3ECCF7C")]
		private void AddCardTimingPushGiftPackWay(List<ResourceGuideWayData> ways, ResourceGuideRequest request)
		{
		}

		[Token(Token = "0x6001C2F")]
		[Address(RVA = "0x3ECD434", Offset = "0x3EC9434", VA = "0x3ECD434")]
		public ResourceObtainGuideManager()
		{
		}
	}
}
