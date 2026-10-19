using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using AssetsModule;
using LitJson;
using SDKModule;
using ToolModule;
using UnityEngine;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E6C")]
	public class GlobalInfo
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E6D")]
		[CompilerGenerated]
		private struct _003CInitInfo_003Ed__92 : IAsyncStateMachine
		{
			[Token(Token = "0x40064A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40064A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40064A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GlobalInfo _003C_003E4__this;

			[Token(Token = "0x40064A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600587A")]
			[Address(RVA = "0x435DF2C", Offset = "0x4359F2C", VA = "0x435DF2C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600587B")]
			[Address(RVA = "0x4361218", Offset = "0x435D218", VA = "0x4361218", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000E6E")]
		[CompilerGenerated]
		private struct _003CLoadGlobalInfo_003Ed__94<T> : IAsyncStateMachine
		{
			[Token(Token = "0x40064A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40064AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40064AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GlobalInfo _003C_003E4__this;

			[Token(Token = "0x40064AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string jsonPath;

			[Token(Token = "0x40064AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<List<T>> onComplete;

			[Token(Token = "0x40064AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private UniTask<UnityEngine.TextAsset>.Awaiter _003C_003Eu__1;

			[Token(Token = "0x600587C")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x600587D")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4006448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<string> loadingConfig;

		[Token(Token = "0x4006449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GlobalFormulaInfo> formulaInfos;

		[Token(Token = "0x400644A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GlobalStrategyInfo> strategyInfos;

		[Token(Token = "0x400644B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<GlobalTalentFormulasInfo> talentFormulasInfos;

		[Token(Token = "0x400644C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, GlobalTalentFormulasInfo> talentFormulasInfoDic;

		[Token(Token = "0x400644D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GlobalProgressInfo> progressInfos;

		[Token(Token = "0x400644E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GlobalMetaModuleInfo> metaModuleInfos;

		[Token(Token = "0x400644F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<GlobalSubMetaModuleInfo> subMetaModuleInfos;

		[Token(Token = "0x4006450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<GlobalAssetInfo> baseAssetInfos;

		[Token(Token = "0x4006451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<GlobalHeroCardInfo> heroCardInfos;

		[Token(Token = "0x4006452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<GlobalRandomHeroCardInfo> randomHeroCardInfos;

		[Token(Token = "0x4006453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Dictionary<string, GlobalHeroCardInfo> heroCardDic;

		[Token(Token = "0x4006454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<GlobalArchitectureInfo> architectureInfos;

		[Token(Token = "0x4006455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<string, GlobalArchitectureInfo> architectureInfoDic;

		[Token(Token = "0x4006456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<GlobalRoleInfo> roleInfos;

		[Token(Token = "0x4006457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Dictionary<string, GlobalRoleInfo> roleInfoDic;

		[Token(Token = "0x4006458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GlobalDanInfo> danInfos;

		[Token(Token = "0x4006459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<GlobalBotNameInfo> botNameInfos;

		[Token(Token = "0x400645A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GlobalArenaInfo> arenaInfos;

		[Token(Token = "0x400645B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public List<GlobalTrophyProgressInfo> trophyProgressInfos;

		[Token(Token = "0x400645C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public List<GlobalPolygonArenaInfo> polygonArenaInfos;

		[Token(Token = "0x400645D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Dictionary<string, GlobalArenaInfo> arenaInfoDic;

		[Token(Token = "0x400645E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Dictionary<string, GlobalPolygonArenaInfo> polygonArenaInfoDic;

		[Token(Token = "0x400645F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<GlobalTrainingMapInfo> trainingMapInfos;

		[Token(Token = "0x4006460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Dictionary<string, GlobalTrainingMapInfo> trainingMapInfoDic;

		[Token(Token = "0x4006461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public List<GlobalBoxInfo> boxInfos;

		[Token(Token = "0x4006462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Dictionary<string, ArenaEnemyBalanceInfo> arenaEnemyBalanceInfoDic;

		[Token(Token = "0x4006463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<GlobalHexInfo> hexInfos;

		[Token(Token = "0x4006464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public List<GlobalBuildInfo> buildInfos;

		[Token(Token = "0x4006465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public List<UserLevelInfo> UserLevelInfos;

		[Token(Token = "0x4006466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Dictionary<int, UserLevelInfo> UserLevelDic;

		[Token(Token = "0x4006467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public List<ArenaEnemyBalanceInfo> arenaEnemyBalanceInfos;

		[Token(Token = "0x4006468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public List<ArenaEnemyCardsInfo> arenaEnemyCardsInfoList;

		[Token(Token = "0x4006469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public List<EnemyDifficultLevelInfos> enemyDifficultLevelInfoList;

		[Token(Token = "0x400646A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Dictionary<int, EnemyDifficultLevelInfos> enemyDifficultLevelInfoDic;

		[Token(Token = "0x400646B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public List<GlobalShopInfo> shopInfoList;

		[Token(Token = "0x400646C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public List<GlobalIAPInfo> iapInfoList;

		[Token(Token = "0x400646D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public List<GlobaMultistageNewcomerPackageInfo> multistageNewcomerPackage;

		[Token(Token = "0x400646E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public List<GlobalTipInfo> tipInfoList;

		[Token(Token = "0x400646F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public List<GlobalSummonInfo> summonInfoList;

		[Token(Token = "0x4006470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public List<GlobalArtifactsForgeInfo> artifactsForgeInfoList;

		[Token(Token = "0x4006471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public Dictionary<string, GlobalArtifactsForgeInfo> artifactsForgeInfoDic;

		[Token(Token = "0x4006472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public List<GlobalArtifactAIReleaseInfo> artifactAIReleaseInfoList;

		[Token(Token = "0x4006473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public Dictionary<string, GlobalArtifactAIReleaseInfo> artifactAIReleaseInfoDic;

		[Token(Token = "0x4006474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public List<GlobalPropInfo> propInfoList;

		[Token(Token = "0x4006475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public Dictionary<string, GlobalSummonInfo> summonInfoDic;

		[Token(Token = "0x4006476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public Dictionary<string, GlobalPropInfo> propInfoDic;

		[Token(Token = "0x4006477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public List<GlobalMainCityMapInfo> mapInfos;

		[Token(Token = "0x4006478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public List<GlobalMapInfo> tileInfos;

		[Token(Token = "0x4006479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public Dictionary<string, GlobalMapInfo> tileInfoDic;

		[Token(Token = "0x400647A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public List<GlobalMainCityAssetsInfo> metaModelAssets;

		[Token(Token = "0x400647B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public List<GlobalMainCityTitleInfo> mainCityTitleInfos;

		[Token(Token = "0x400647C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<GlobalMainCityHouseInfo> mainCityHouseInfos;

		[Token(Token = "0x400647D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public List<GlobalMainCityBuildTalentInfo> mainCityTalentInfos;

		[Token(Token = "0x400647E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public List<GlobalCardTalentInfo> cardTalentInfoList;

		[Token(Token = "0x400647F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public Dictionary<string, GlobalCardTalentInfo> cardTalentInfoDic;

		[Token(Token = "0x4006480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public List<GlobalCardTalenTreeInfo> cardTalentTreeInfoList;

		[Token(Token = "0x4006481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public Dictionary<string, GlobalCardTalenTreeInfo> cardTalentTreeInfoDic;

		[Token(Token = "0x4006482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public List<GlobalFundInfo> globalFundInfos_AbilityFund;

		[Token(Token = "0x4006483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public List<GlobalFundInfo> globalFundInfos_SummonFund;

		[Token(Token = "0x4006484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public List<GlobalFundInfo> globalFundInfos_CardFund;

		[Token(Token = "0x4006485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public List<GlobalFundInfo> globalFundInfos_MainCityPass;

		[Token(Token = "0x4006486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public List<GlobalFundInfo> globalFundInfos_SeasonPass;

		[Token(Token = "0x4006487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public List<FundIAPInfo> fundIAPInfos;

		[Token(Token = "0x4006488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public List<GlobalGiftChainInfo> globalGiftChainInfos_chain1;

		[Token(Token = "0x4006489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public List<GlobalTutorialInfo> globalTutorialInfos;

		[Token(Token = "0x400648A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public List<GlobalFeatureUnlockInfo> globalFeatureUnlockInfos;

		[Token(Token = "0x400648B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public List<GlobaUpgradeReward> globaUpgradeRewards;

		[Token(Token = "0x400648C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		public List<UserLablePushPackInfo> userLablePushPackInfoS;

		[Token(Token = "0x400648D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public List<SeasonRankingRewardConfig> seasonRewardConfigs;

		[Token(Token = "0x400648E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public List<ShopArenaPackInfos> shopArenaPackInfos;

		[Token(Token = "0x400648F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public List<GlobalBannerInfo> GlobalBannerInfos;

		[Token(Token = "0x4006490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		public List<GlobalExpression> GlobalExpressionInfos;

		[Token(Token = "0x4006491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		public List<GameSettingConfig> gameSettingConfigs;

		[Token(Token = "0x4006492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		public List<WeeklyClashDifficultyConfig> weeklyClashDifficultyConfigs;

		[Token(Token = "0x4006493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		public List<GlobalGiftChainInfo2> globalGiftChainInfos_chain2;

		[Token(Token = "0x4006494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		public List<GlobalCardTalent2Info> globalCardTalent2BaseInfos;

		[Token(Token = "0x4006495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		public Dictionary<string, GlobalCardTalent2Info> globalCardTalent2BaseInfoDic;

		[Token(Token = "0x4006496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		public List<GlobalCardTalentInfo> cardTalent2InfoList;

		[Token(Token = "0x4006497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		public Dictionary<string, GlobalCardTalentInfo> cardTalent2InfoDic;

		[Token(Token = "0x4006498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		public List<GlobalUpgradeTalentPriceInfo> upgradeTalentPriceInfos;

		[Token(Token = "0x4006499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public Dictionary<string, GlobalUpgradeTalentPriceInfo> upgradeTalentPriceDic;

		[Token(Token = "0x400649A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		public List<PanelConfig> panelConfigs;

		[Token(Token = "0x400649B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		public List<GlobalMysteriousStore> globalMysteriousStoreInfos;

		[Token(Token = "0x400649C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		public List<GlobalBlessInfo> globalBlessInfos;

		[Token(Token = "0x400649D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		public List<SeasonInfo> globalSeasonInfos;

		[Token(Token = "0x400649E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		public Dictionary<string, GlobalBlessInfo> globalBlessInfoDic;

		[Token(Token = "0x400649F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		public List<GlobalWeeklyCardDailyTaskInfo> globalWeeklyCardDailyTaskInfo;

		[Token(Token = "0x40064A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		public Dictionary<string, GlobalWeeklyCardDailyTaskInfo> globalWeeklyCardDailyTaskInfoDic;

		[Token(Token = "0x40064A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		public List<GlobalWeeklyCardStageInfo> globalWeeklyCardStageInfo;

		[Token(Token = "0x40064A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		public Dictionary<string, GlobalWeeklyCardStageInfo> globalWeeklyCardStageInfoDic;

		[Token(Token = "0x40064A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		public List<string> HeadShotIDS;

		[Token(Token = "0x40064A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private List<string> hadLoadInfo;

		[Token(Token = "0x600582D")]
		[Address(RVA = "0x4350578", Offset = "0x434C578", VA = "0x4350578")]
		public async Task InitInfo()
		{
			if (ABTestManager.Instance.NewMachineCardIsB)
			{
			    HeadShotIDS.Add("1027");
			    HeadShotIDS.Add("1028");
			}
			if (ABTestManager.Instance.NewCardsV1IsB)
			{
			    HeadShotIDS.Add("1029");
			    HeadShotIDS.Add("1030");
			    HeadShotIDS.Add("1031");
			    HeadShotIDS.Add("1032");
			    HeadShotIDS.Add("1033");
			}
			if (ABTestManager.Instance.WeeklyCardEventIsB)
			{
			    HeadShotIDS.Add("1034");
			    HeadShotIDS.Add("1035");
			    HeadShotIDS.Add("1036");
			    HeadShotIDS.Add("1037");
			}
			HeadShotIDS.Add("1038");
			HeadShotIDS.Add("1039");
			HeadShotIDS.Add("1040");
			LoadGlobalInfo<GlobalAssetInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalBaseAssetsInfo.json", _003CInitInfo_003Eb__92_0);
			LoadGlobalInfo<GlobalFormulaInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalFormulasInfo.json", _003CInitInfo_003Eb__92_1);
			LoadGlobalInfo<GlobalStrategyInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalStrategyInfo.json", _003CInitInfo_003Eb__92_2);
			LoadGlobalInfo<GlobalMetaModuleInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalMetaModuleInfo.json", _003CInitInfo_003Eb__92_3);
			LoadGlobalInfo<GlobalSubMetaModuleInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalSubMetaModuleInfo.json", _003CInitInfo_003Eb__92_4);
			LoadGlobalInfo<GlobalShopInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalShopInfo.json", _003CInitInfo_003Eb__92_5);
			LoadGlobalInfo<GlobalIAPInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalIAPInfo.json", _003CInitInfo_003Eb__92_6);
			LoadGlobalInfo<GlobaMultistageNewcomerPackageInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobaMultistageNewcomerPackageInfo.json", _003CInitInfo_003Eb__92_7);
			LoadGlobalInfo<UserLablePushPackInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/UserLablePushPackInfo.json", _003CInitInfo_003Eb__92_8);
			LoadGlobalInfo<GlobalMysteriousStore>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalMysteriousStore.json", _003CInitInfo_003Eb__92_9);
			LoadGlobalInfo<GlobalSummonInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalSummonInfo.json", _003CInitInfo_003Eb__92_10);
			LoadGlobalInfo<GlobalArtifactsForgeInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalArtifactsForgeInfo.json", _003CInitInfo_003Eb__92_11);
			LoadGlobalInfo<GlobalArtifactAIReleaseInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalArtifactAIReleaseInfo.json", _003CInitInfo_003Eb__92_12);
			string propPath = ABTestManager.Instance.NewArtifactsPlayIsBTest ? "Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalPropInfoBTest.json" : "Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalPropInfoATest.json";
			LoadGlobalInfo<GlobalPropInfo>(propPath, _003CInitInfo_003Eb__92_13);
			LoadGlobalInfo<GlobalBannerInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalBannerInfo.json", _003CInitInfo_003Eb__92_14);
			LoadGlobalInfo<GlobalExpression>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalExpression.json", _003CInitInfo_003Eb__92_15);
			LoadGlobalInfo<GlobaUpgradeReward>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobaUpgradeReward.json", _003CInitInfo_003Eb__92_16);
			string architecturePath;
			string rolePath;
			string heroCardPath;
			if (ABTestManager.Instance.ShopImproveV1IsBTest)
			{
			    architecturePath = "Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalArchitectureInfoshop_improve_v1.json";
			    rolePath = "Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalRoleInfoshop_improve_v1.json";
			    heroCardPath = "Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalHeroCardInfoshop_improve_v1.json";
			    UnityEngine.Debug.Log("建筑角色卡牌表使用shop_improve_v1数值");
			}
			else
			{
			    architecturePath = "Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalArchitectureInfogameplay_improve_01.json";
			    rolePath = "Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalRoleInfogameplay_improve_01.json";
			    heroCardPath = "Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalHeroCardInfoSheet5.json";
			    UnityEngine.Debug.Log("建筑角色卡牌表使用gameplay_improve_01数值");
			}
			LoadGlobalInfo<GlobalCardTalent2Info>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalCardTalent2Info.json", _003CInitInfo_003Eb__92_17);
			if (ABTestManager.Instance.AbilitiesInAdvanceIsBTest)
			{
			    LoadGlobalInfo<GlobalUpgradeTalentPriceInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalUpgradeTalentPriceInfoabilities_in_advance.json", _003CInitInfo_003Eb__92_19);
			}
			else
			{
			    LoadGlobalInfo<GlobalUpgradeTalentPriceInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalUpgradeTalentPriceInfocontrol.json", _003CInitInfo_003Eb__92_18);
			}
			LoadGlobalInfo<GlobalCardTalentInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalCardTalentInfoSheet3.json", _003CInitInfo_003Eb__92_20);
			LoadGlobalInfo<GlobalHeroCardInfo>(heroCardPath, _003CInitInfo_003Eb__92_21);
			LoadGlobalInfo<GlobalArchitectureInfo>(architecturePath, _003CInitInfo_003Eb__92_22);
			LoadGlobalInfo<GlobalRoleInfo>(rolePath, _003CInitInfo_003Eb__92_23);
			LoadGlobalInfo<GlobalCardTalenTreeInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalCardTalenTreeInfoSheet2.json", _003CInitInfo_003Eb__92_24);
			LoadGlobalInfo<GlobalCardTalentInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalCardTalentInfoSheet2.json", _003CInitInfo_003Eb__92_25);
			LoadGlobalInfo<GlobalRandomHeroCardInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalRandomHeroCardInfo.json", _003CInitInfo_003Eb__92_26);
			if (ABTestManager.Instance.NewArenaProcessIsBTest)
			{
			    LoadGlobalInfo<GlobalDanInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalDanInfoSheet2.json", _003CInitInfo_003Eb__92_27);
			}
			else
			{
			    LoadGlobalInfo<GlobalDanInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalDanInfoSheet1.json", _003CInitInfo_003Eb__92_28);
			}
			LoadGlobalInfo<GlobalBotNameInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalBotNameInfo.json", _003CInitInfo_003Eb__92_29);
			LoadGlobalInfo<GlobalMainCityBuildTalentInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalMainCityBuildTalentInfoSheet2.json", _003CInitInfo_003Eb__92_30);
			LoadGlobalInfo<GlobalTalentFormulasInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalTalentFormulasInfoSheet2.json", _003CInitInfo_003Eb__92_31);
			if (ABTestManager.Instance.NewArenaProcessIsBTest)
			{
			    LoadGlobalInfo<GlobalArenaInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalArenaInfoSheet2.json", _003CInitInfo_003Eb__92_32);
			}
			else
			{
			    LoadGlobalInfo<GlobalArenaInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalArenaInfoSheet1.json", _003CInitInfo_003Eb__92_33);
			}
			if (ABTestManager.Instance.NewbieTutorialIsBTest)
			{
			    LoadGlobalInfo<GlobalTrainingMapInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalTrainingMapInfoSheet1.json", _003CInitInfo_003Eb__92_34);
			}
			else
			{
			    LoadGlobalInfo<GlobalTrainingMapInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalTrainingMapInfoSheet2.json", _003CInitInfo_003Eb__92_35);
			}
			LoadGlobalInfo<GlobalTrophyProgressInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalTrophyProgressInfo.json", _003CInitInfo_003Eb__92_36);
			LoadGlobalInfo<GlobalPolygonArenaInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalPolygonArenaInfoSheet2.json", _003CInitInfo_003Eb__92_37);
			LoadGlobalInfo<GlobalBoxInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalBoxInfo.json", _003CInitInfo_003Eb__92_38);
			if (ABTestManager.Instance.ShopImproveV1IsBTest)
			{
			    LoadGlobalInfo<ArenaEnemyCardsInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/ArenaEnemyCardsInfoSheet3.json", _003CInitInfo_003Eb__92_39);
			}
			else
			{
			    LoadGlobalInfo<ArenaEnemyCardsInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/ArenaEnemyCardsInfoSheet2.json", _003CInitInfo_003Eb__92_40);
			}
			string enemyDifficultyPath;
			string arenaBalancePath;
			int gameplayVariant = ABTestManager.Instance.GamePlayImproveV2Variant;
			if (gameplayVariant == 1)
			{
			    enemyDifficultyPath = "Assets/_Res/Addressable/01FirstBundle/JsonData/EnemyDifficultLevelInfosgameplay_improve_v2_01.json";
			    arenaBalancePath = "Assets/_Res/Addressable/01FirstBundle/JsonData/ArenaEnemyBalanceInfogameplay_improve_v2_01.json";
			}
			else if (gameplayVariant == 2)
			{
			    enemyDifficultyPath = "Assets/_Res/Addressable/01FirstBundle/JsonData/EnemyDifficultLevelInfosgameplay_improve_v2_02.json";
			    arenaBalancePath = "Assets/_Res/Addressable/01FirstBundle/JsonData/ArenaEnemyBalanceInfogameplay_improve_v2_02.json";
			}
			else
			{
			    enemyDifficultyPath = "Assets/_Res/Addressable/01FirstBundle/JsonData/EnemyDifficultLevelInfosgameplay_improve_01.json";
			    if (ABTestManager.Instance.BalanceAdjustment03IsBTest)
			    {
			        arenaBalancePath = "Assets/_Res/Addressable/01FirstBundle/JsonData/ArenaEnemyBalanceInfobalance_adjustment_03_on.json";
			        UnityEngine.Debug.Log("竞技场敌人平衡表使用 BalanceAdjustment03 的 B 组数值");
			    }
			    else
			    {
			        arenaBalancePath = "Assets/_Res/Addressable/01FirstBundle/JsonData/ArenaEnemyBalanceInfogameplay_improve_01.json";
			        UnityEngine.Debug.Log("竞技场敌人平衡表使用 BalanceAdjustment03 的 A 组数值");
			    }
			}
			LoadGlobalInfo<EnemyDifficultLevelInfos>(enemyDifficultyPath, _003CInitInfo_003Eb__92_41);
			LoadGlobalInfo<ArenaEnemyBalanceInfo>(arenaBalancePath, _003CInitInfo_003Eb__92_42);
			LoadGlobalInfo<GlobalHexInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalHexInfo.json", _003CInitInfo_003Eb__92_43);
			LoadGlobalInfo<GlobalBuildInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalBuildInfo.json", _003CInitInfo_003Eb__92_44);
			LoadGlobalInfo<UserLevelInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/UserLevelInfo.json", _003CInitInfo_003Eb__92_45);
			LoadGlobalInfo<GlobalTipInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalTipInfo.json", _003CInitInfo_003Eb__92_46);
			LoadGlobalInfo<GlobalMainCityMapInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalMainCityMapInfo.json", _003CInitInfo_003Eb__92_47);
			LoadGlobalInfo<GlobalBlessInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalBlessInfo.json", _003CInitInfo_003Eb__92_48);
			LoadGlobalInfo<SeasonInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/SeasonInfo.json", _003CInitInfo_003Eb__92_49);
			LoadGlobalInfo<GlobalMainCityAssetsInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalMainCityAssetsInfo.json", _003CInitInfo_003Eb__92_50);
			LoadGlobalInfo<GlobalMainCityTitleInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalMainCityTitleInfo.json", _003CInitInfo_003Eb__92_51);
			LoadGlobalInfo<GlobalMainCityHouseInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalMainCityHouseInfo.json", _003CInitInfo_003Eb__92_52);
			LoadGlobalInfo<GlobalFundInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalFundInfoAbilityFund.json", _003CInitInfo_003Eb__92_53);
			LoadGlobalInfo<GlobalFundInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalFundInfoSummonFund.json", _003CInitInfo_003Eb__92_54);
			LoadGlobalInfo<GlobalFundInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalFundInfoCardFund.json", _003CInitInfo_003Eb__92_55);
			LoadGlobalInfo<GlobalFundInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalFundInfoMainCityPass.json", _003CInitInfo_003Eb__92_56);
			LoadGlobalInfo<GlobalFundInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalFundInfoSeasonPass.json", _003CInitInfo_003Eb__92_57);
			LoadGlobalInfo<ShopArenaPackInfos>("Assets/_Res/Addressable/01FirstBundle/JsonData/ShopArenaPackInfos.json", _003CInitInfo_003Eb__92_58);
			LoadGlobalInfo<GlobalWeeklyCardDailyTaskInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalWeeklyCardDailyTaskInfo.json", _003CInitInfo_003Eb__92_59);
			LoadGlobalInfo<GlobalWeeklyCardStageInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalWeeklyCardStageInfo.json", _003CInitInfo_003Eb__92_60);
			LoadGlobalInfo<FundIAPInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/FundIAPInfo.json", _003CInitInfo_003Eb__92_61);
			LoadGlobalInfo<GlobalGiftChainInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalGiftChainInfo.json", _003CInitInfo_003Eb__92_62);
			LoadGlobalInfo<GlobalGiftChainInfo2>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalGiftChainInfo2.json", _003CInitInfo_003Eb__92_63);
			LoadGlobalInfo<GlobalTutorialInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalTutorialInfo.json", _003CInitInfo_003Eb__92_64);
			LoadGlobalInfo<GlobalFeatureUnlockInfo>("Assets/_Res/Addressable/01FirstBundle/JsonData/GlobalFeatureUnlockInfo.json", _003CInitInfo_003Eb__92_65);
			if (ABTestManager.Instance.WeeklyClashImprove01IsBTest)
			{
			    LoadGlobalInfo<SeasonRankingRewardConfig>("Assets/_Res/Addressable/01FirstBundle/JsonData/SeasonRankingRewardConfigSheet2.json", _003CInitInfo_003Eb__92_66);
			}
			else
			{
			    LoadGlobalInfo<SeasonRankingRewardConfig>("Assets/_Res/Addressable/01FirstBundle/JsonData/SeasonRankingRewardConfigSheet1.json", _003CInitInfo_003Eb__92_67);
			}
			LoadGlobalInfo<GameSettingConfig>("Assets/_Res/Addressable/01FirstBundle/JsonData/GameSettingConfig.json", _003CInitInfo_003Eb__92_68);
			if (ABTestManager.Instance.WeeklyClashImprove01IsBTest)
			{
			    LoadGlobalInfo<WeeklyClashDifficultyConfig>("Assets/_Res/Addressable/01FirstBundle/JsonData/WeeklyClashDifficultyConfigSheet2.json", _003CInitInfo_003Eb__92_69);
			}
			else
			{
			    LoadGlobalInfo<WeeklyClashDifficultyConfig>("Assets/_Res/Addressable/01FirstBundle/JsonData/WeeklyClashDifficultyConfigSheet1.json", _003CInitInfo_003Eb__92_70);
			}
			LoadGlobalInfo<PanelConfig>("Assets/_Res/Addressable/01FirstBundle/JsonData/PanelConfig.json", _003CInitInfo_003Eb__92_71);
			await UniTask.WaitUntil(_003CInitInfo_003Eb__92_72);
		}

		[Token(Token = "0x600582E")]
		private async void LoadGlobalInfo<T>(string jsonPath, Action<List<T>> onComplete)
		{
			if (hadLoadInfo.Contains(jsonPath))
			{
			    UnityEngine.Debug.LogError("配置文件文件多次加载：" + jsonPath);
			}
			else
			{
			    hadLoadInfo.Add(jsonPath);
			}
			loadingConfig.Add(jsonPath);
			int slashIndex = jsonPath.LastIndexOf('/');
			int dotIndex = jsonPath.LastIndexOf('.');
			string resourceName = jsonPath.Substring(slashIndex + 1, dotIndex - slashIndex - 1);
			TextAsset asset = UnityEngine.Resources.Load<TextAsset>("JsonData/" + resourceName);
			if (asset == null)
			{
			    UnityEngine.Debug.LogWarning("配置文件文件不在Resources目录下，尝试从StreamingAssets目录加载：" + jsonPath);
			    asset = await AssetsManager.Instance.LoadAssetAsync<TextAsset>(jsonPath);
			}
			onComplete?.Invoke(GlobalStringToConfig<T>(jsonPath, asset.text));
			loadingConfig.Remove(jsonPath);
		}

		[Token(Token = "0x600582F")]
		private List<T> GlobalStringToConfig<T>(string jsonPath, string jsonStr)
		{
			try
			{
			    jsonStr = GZipTool.DecompressFromBase64(jsonStr);
			    return JsonMapper.ToObject<List<T>>(jsonStr);
			}
			catch (Exception exception)
			{
			    Console.WriteLine(exception);
			    UnityEngine.Debug.LogError(string.Format("GlobalStringToConfig Fail => T = {0} jsonStr = {1}", typeof(T), jsonStr));
			    throw;
			}
		}

		[Token(Token = "0x6005830")]
		[Address(RVA = "0x434FB94", Offset = "0x434BB94", VA = "0x434FB94")]
		public GlobalInfo()
		{
			loadingConfig = new List<string>();
			HeadShotIDS = new List<string> { "1003", "1002", "1004", "1005", "1006", "1007", "1008", "1009", "1010", "1011", "1012", "1013", "1016", "1017", "1018", "1019", "1020", "1021", "1022", "1023", "1024", "1025", "1026" };
			hadLoadInfo = new List<string>();
		}

		[CompilerGenerated]
		[Address(RVA = "0x435BBD8", VA = "0x435BBD8")]
		private void _003CInitInfo_003Eb__92_0(List<GlobalAssetInfo> list)
		{
		    baseAssetInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BBE0", VA = "0x435BBE0")]
		private void _003CInitInfo_003Eb__92_1(List<GlobalFormulaInfo> list)
		{
		    formulaInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BBE8", VA = "0x435BBE8")]
		private void _003CInitInfo_003Eb__92_2(List<GlobalStrategyInfo> list)
		{
		    strategyInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BBF0", VA = "0x435BBF0")]
		private void _003CInitInfo_003Eb__92_3(List<GlobalMetaModuleInfo> list)
		{
		    metaModuleInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BBF8", VA = "0x435BBF8")]
		private void _003CInitInfo_003Eb__92_4(List<GlobalSubMetaModuleInfo> list)
		{
		    subMetaModuleInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BC00", VA = "0x435BC00")]
		private void _003CInitInfo_003Eb__92_5(List<GlobalShopInfo> list)
		{
		    shopInfoList = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BC08", VA = "0x435BC08")]
		private void _003CInitInfo_003Eb__92_6(List<GlobalIAPInfo> list)
		{
		    iapInfoList = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BC10", VA = "0x435BC10")]
		private void _003CInitInfo_003Eb__92_7(List<GlobaMultistageNewcomerPackageInfo> list)
		{
		    multistageNewcomerPackage = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BC18", VA = "0x435BC18")]
		private void _003CInitInfo_003Eb__92_8(List<UserLablePushPackInfo> list)
		{
		    userLablePushPackInfoS = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BC20", VA = "0x435BC20")]
		private void _003CInitInfo_003Eb__92_9(List<GlobalMysteriousStore> list)
		{
		    globalMysteriousStoreInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BC28", VA = "0x435BC28")]
		private void _003CInitInfo_003Eb__92_10(List<GlobalSummonInfo> list)
		{
		    summonInfoList = list;
		    summonInfoDic = new Dictionary<string, GlobalSummonInfo>();
		    for (int index = 0; index < summonInfoList.Count; ++index)
		    {
		        summonInfoDic.Add(summonInfoList[index].level, summonInfoList[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BD50", VA = "0x435BD50")]
		private void _003CInitInfo_003Eb__92_11(List<GlobalArtifactsForgeInfo> list)
		{
		    artifactsForgeInfoList = list;
		    artifactsForgeInfoDic = new Dictionary<string, GlobalArtifactsForgeInfo>();
		    for (int index = 0; index < artifactsForgeInfoList.Count; ++index)
		    {
		        artifactsForgeInfoDic.Add(artifactsForgeInfoList[index].id, artifactsForgeInfoList[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BE78", VA = "0x435BE78")]
		private void _003CInitInfo_003Eb__92_12(List<GlobalArtifactAIReleaseInfo> list)
		{
		    artifactAIReleaseInfoList = list;
		    artifactAIReleaseInfoDic = new Dictionary<string, GlobalArtifactAIReleaseInfo>();
		    for (int index = 0; index < artifactAIReleaseInfoList.Count; ++index)
		    {
		        artifactAIReleaseInfoDic.Add(artifactAIReleaseInfoList[index].id, artifactAIReleaseInfoList[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435BFA0", VA = "0x435BFA0")]
		private void _003CInitInfo_003Eb__92_13(List<GlobalPropInfo> list)
		{
		    propInfoList = list;
		    propInfoDic = new Dictionary<string, GlobalPropInfo>();
		    for (int index = 0; index < propInfoList.Count; ++index)
		    {
		        propInfoDic.Add(propInfoList[index].id, propInfoList[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435C0C8", VA = "0x435C0C8")]
		private void _003CInitInfo_003Eb__92_14(List<GlobalBannerInfo> list)
		{
		    GlobalBannerInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435C0D0", VA = "0x435C0D0")]
		private void _003CInitInfo_003Eb__92_15(List<GlobalExpression> list)
		{
		    GlobalExpressionInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435C0D8", VA = "0x435C0D8")]
		private void _003CInitInfo_003Eb__92_16(List<GlobaUpgradeReward> list)
		{
		    globaUpgradeRewards = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435C0E0", VA = "0x435C0E0")]
		private void _003CInitInfo_003Eb__92_17(List<GlobalCardTalent2Info> list)
		{
		    globalCardTalent2BaseInfos = list;
		    globalCardTalent2BaseInfoDic = new Dictionary<string, GlobalCardTalent2Info>();
		    for (int index = 0; index < globalCardTalent2BaseInfos.Count; ++index)
		    {
		        globalCardTalent2BaseInfoDic.Add(globalCardTalent2BaseInfos[index].id, globalCardTalent2BaseInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435C208", VA = "0x435C208")]
		private void _003CInitInfo_003Eb__92_18(List<GlobalUpgradeTalentPriceInfo> list)
		{
		    upgradeTalentPriceInfos = list;
		    upgradeTalentPriceDic = new Dictionary<string, GlobalUpgradeTalentPriceInfo>();
		    for (int index = 0; index < upgradeTalentPriceInfos.Count; ++index)
		    {
		        upgradeTalentPriceDic.Add(upgradeTalentPriceInfos[index].cardIndex, upgradeTalentPriceInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435C330", VA = "0x435C330")]
		private void _003CInitInfo_003Eb__92_19(List<GlobalUpgradeTalentPriceInfo> list)
		{
		    upgradeTalentPriceInfos = list;
		    upgradeTalentPriceDic = new Dictionary<string, GlobalUpgradeTalentPriceInfo>();
		    for (int index = 0; index < upgradeTalentPriceInfos.Count; ++index)
		    {
		        upgradeTalentPriceDic.Add(upgradeTalentPriceInfos[index].cardIndex, upgradeTalentPriceInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435C458", VA = "0x435C458")]
		private void _003CInitInfo_003Eb__92_20(List<GlobalCardTalentInfo> list)
		{
		    cardTalent2InfoList = list;
		    cardTalent2InfoDic = new Dictionary<string, GlobalCardTalentInfo>();
		    for (int index = 0; index < cardTalent2InfoList.Count; ++index)
		    {
		        cardTalent2InfoDic.Add(cardTalent2InfoList[index].id, cardTalent2InfoList[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435C580", VA = "0x435C580")]
		private void _003CInitInfo_003Eb__92_21(List<GlobalHeroCardInfo> list)
		{
		    heroCardInfos = list;
		    heroCardDic = new Dictionary<string, GlobalHeroCardInfo>();
		    for (int index = 0; index < heroCardInfos.Count; ++index)
		    {
		        heroCardDic.Add(heroCardInfos[index].id, heroCardInfos[index]);
		    }
		    UnityEngine.Debug.Log("OOO卡牌B测试，加载完配置，一共条数据" + heroCardInfos.Count.ToString());
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435C720", VA = "0x435C720")]
		private void _003CInitInfo_003Eb__92_22(List<GlobalArchitectureInfo> list)
		{
		    architectureInfos = list;
		    architectureInfoDic = new Dictionary<string, GlobalArchitectureInfo>();
		    for (int index = 0; index < architectureInfos.Count; ++index)
		    {
		        architectureInfoDic.Add(architectureInfos[index].id, architectureInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435C848", VA = "0x435C848")]
		private void _003CInitInfo_003Eb__92_23(List<GlobalRoleInfo> list)
		{
		    roleInfos = list;
		    roleInfoDic = new Dictionary<string, GlobalRoleInfo>();
		    for (int index = 0; index < roleInfos.Count; ++index)
		    {
		        roleInfoDic.Add(roleInfos[index].id, roleInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435C970", VA = "0x435C970")]
		private void _003CInitInfo_003Eb__92_24(List<GlobalCardTalenTreeInfo> list)
		{
		    cardTalentTreeInfoList = list;
		    cardTalentTreeInfoDic = new Dictionary<string, GlobalCardTalenTreeInfo>();
		    for (int index = 0; index < cardTalentTreeInfoList.Count; ++index)
		    {
		        cardTalentTreeInfoDic.Add(cardTalentTreeInfoList[index].id, cardTalentTreeInfoList[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435CA98", VA = "0x435CA98")]
		private void _003CInitInfo_003Eb__92_25(List<GlobalCardTalentInfo> list)
		{
		    cardTalentInfoList = list;
		    cardTalentInfoDic = new Dictionary<string, GlobalCardTalentInfo>();
		    for (int index = 0; index < cardTalentInfoList.Count; ++index)
		    {
		        cardTalentInfoDic.Add(cardTalentInfoList[index].id, cardTalentInfoList[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435CBC0", VA = "0x435CBC0")]
		private void _003CInitInfo_003Eb__92_26(List<GlobalRandomHeroCardInfo> list)
		{
		    randomHeroCardInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435CBC8", VA = "0x435CBC8")]
		private void _003CInitInfo_003Eb__92_27(List<GlobalDanInfo> list)
		{
		    danInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435CBD0", VA = "0x435CBD0")]
		private void _003CInitInfo_003Eb__92_28(List<GlobalDanInfo> list)
		{
		    danInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435CBD8", VA = "0x435CBD8")]
		private void _003CInitInfo_003Eb__92_29(List<GlobalBotNameInfo> list)
		{
		    botNameInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435CBE0", VA = "0x435CBE0")]
		private void _003CInitInfo_003Eb__92_30(List<GlobalMainCityBuildTalentInfo> list)
		{
		    mainCityTalentInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435CBE8", VA = "0x435CBE8")]
		private void _003CInitInfo_003Eb__92_31(List<GlobalTalentFormulasInfo> list)
		{
		    talentFormulasInfos = list;
		    talentFormulasInfoDic = new Dictionary<string, GlobalTalentFormulasInfo>();
		    for (int index = 0; index < talentFormulasInfos.Count; ++index)
		    {
		        talentFormulasInfoDic.Add(talentFormulasInfos[index].id, talentFormulasInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435CD10", VA = "0x435CD10")]
		private void _003CInitInfo_003Eb__92_32(List<GlobalArenaInfo> list)
		{
		    arenaInfos = list;
		    arenaInfoDic = new Dictionary<string, GlobalArenaInfo>();
		    for (int index = 0; index < arenaInfos.Count; ++index)
		    {
		        arenaInfoDic.Add(arenaInfos[index].id, arenaInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435CE38", VA = "0x435CE38")]
		private void _003CInitInfo_003Eb__92_33(List<GlobalArenaInfo> list)
		{
		    arenaInfos = list;
		    arenaInfoDic = new Dictionary<string, GlobalArenaInfo>();
		    for (int index = 0; index < arenaInfos.Count; ++index)
		    {
		        arenaInfoDic.Add(arenaInfos[index].id, arenaInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435CF60", VA = "0x435CF60")]
		private void _003CInitInfo_003Eb__92_34(List<GlobalTrainingMapInfo> list)
		{
		    trainingMapInfos = list;
		    trainingMapInfoDic = new Dictionary<string, GlobalTrainingMapInfo>();
		    for (int index = 0; index < trainingMapInfos.Count; ++index)
		    {
		        trainingMapInfoDic.Add(trainingMapInfos[index].id, trainingMapInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D088", VA = "0x435D088")]
		private void _003CInitInfo_003Eb__92_35(List<GlobalTrainingMapInfo> list)
		{
		    trainingMapInfos = list;
		    trainingMapInfoDic = new Dictionary<string, GlobalTrainingMapInfo>();
		    for (int index = 0; index < trainingMapInfos.Count; ++index)
		    {
		        trainingMapInfoDic.Add(trainingMapInfos[index].id, trainingMapInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D1B0", VA = "0x435D1B0")]
		private void _003CInitInfo_003Eb__92_36(List<GlobalTrophyProgressInfo> list)
		{
		    trophyProgressInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D1B8", VA = "0x435D1B8")]
		private void _003CInitInfo_003Eb__92_37(List<GlobalPolygonArenaInfo> list)
		{
		    polygonArenaInfos = list;
		    polygonArenaInfoDic = new Dictionary<string, GlobalPolygonArenaInfo>();
		    for (int index = 0; index < polygonArenaInfos.Count; ++index)
		    {
		        polygonArenaInfoDic.Add(polygonArenaInfos[index].id, polygonArenaInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D2E0", VA = "0x435D2E0")]
		private void _003CInitInfo_003Eb__92_38(List<GlobalBoxInfo> list)
		{
		    boxInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D2E8", VA = "0x435D2E8")]
		private void _003CInitInfo_003Eb__92_39(List<ArenaEnemyCardsInfo> list)
		{
		    arenaEnemyCardsInfoList = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D2F0", VA = "0x435D2F0")]
		private void _003CInitInfo_003Eb__92_40(List<ArenaEnemyCardsInfo> list)
		{
		    arenaEnemyCardsInfoList = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D2F8", VA = "0x435D2F8")]
		private void _003CInitInfo_003Eb__92_41(List<EnemyDifficultLevelInfos> list)
		{
		    enemyDifficultLevelInfoList = list;
		    enemyDifficultLevelInfoDic = new Dictionary<int, EnemyDifficultLevelInfos>();
		    for (int index = 0; index < enemyDifficultLevelInfoList.Count; ++index)
		    {
		        enemyDifficultLevelInfoDic.Add(StringTool.ToInt(enemyDifficultLevelInfoList[index].id), enemyDifficultLevelInfoList[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D42C", VA = "0x435D42C")]
		private void _003CInitInfo_003Eb__92_42(List<ArenaEnemyBalanceInfo> list)
		{
		    arenaEnemyBalanceInfos = list;
		    arenaEnemyBalanceInfoDic = new Dictionary<string, ArenaEnemyBalanceInfo>();
		    for (int index = 0; index < arenaEnemyBalanceInfos.Count; ++index)
		    {
		        arenaEnemyBalanceInfoDic.Add(arenaEnemyBalanceInfos[index].arnenaID, arenaEnemyBalanceInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D554", VA = "0x435D554")]
		private void _003CInitInfo_003Eb__92_43(List<GlobalHexInfo> list)
		{
		    hexInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D55C", VA = "0x435D55C")]
		private void _003CInitInfo_003Eb__92_44(List<GlobalBuildInfo> list)
		{
		    buildInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D564", VA = "0x435D564")]
		private void _003CInitInfo_003Eb__92_45(List<UserLevelInfo> list)
		{
		    UserLevelInfos = list;
		    UserLevelDic = new Dictionary<int, UserLevelInfo>();
		    for (int index = 0; index < UserLevelInfos.Count; ++index)
		    {
		        UserLevelDic.Add(StringTool.ToInt(UserLevelInfos[index].level), UserLevelInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D698", VA = "0x435D698")]
		private void _003CInitInfo_003Eb__92_46(List<GlobalTipInfo> list)
		{
		    tipInfoList = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435D6A0", VA = "0x435D6A0")]
		private void _003CInitInfo_003Eb__92_47(List<GlobalMainCityMapInfo> list)
		{
		    mapInfos = list;
		    tileInfos = new List<GlobalMapInfo>();
		    tileInfoDic = new Dictionary<string, GlobalMapInfo>();
		    foreach (GlobalMainCityMapInfo map in mapInfos)
		    {
		        foreach (GlobalMapInfo tile in JsonMapper.ToObject<List<GlobalMapInfo>>(map.infos))
		        {
		            tileInfos.Add(tile);
		            tileInfoDic.TryAdd(tile.tileKey, tile);
		        }
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DABC", VA = "0x435DABC")]
		private void _003CInitInfo_003Eb__92_48(List<GlobalBlessInfo> list)
		{
		    globalBlessInfos = list;
		    globalBlessInfoDic = new Dictionary<string, GlobalBlessInfo>();
		    for (int index = 0; index < globalBlessInfos.Count; ++index)
		    {
		        globalBlessInfoDic.Add(globalBlessInfos[index].id, globalBlessInfos[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DBE4", VA = "0x435DBE4")]
		private void _003CInitInfo_003Eb__92_49(List<SeasonInfo> list)
		{
		    globalSeasonInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DBEC", VA = "0x435DBEC")]
		private void _003CInitInfo_003Eb__92_50(List<GlobalMainCityAssetsInfo> list)
		{
		    metaModelAssets = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DBF4", VA = "0x435DBF4")]
		private void _003CInitInfo_003Eb__92_51(List<GlobalMainCityTitleInfo> list)
		{
		    mainCityTitleInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DBFC", VA = "0x435DBFC")]
		private void _003CInitInfo_003Eb__92_52(List<GlobalMainCityHouseInfo> list)
		{
		    mainCityHouseInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DC04", VA = "0x435DC04")]
		private void _003CInitInfo_003Eb__92_53(List<GlobalFundInfo> list)
		{
		    globalFundInfos_AbilityFund = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DC0C", VA = "0x435DC0C")]
		private void _003CInitInfo_003Eb__92_54(List<GlobalFundInfo> list)
		{
		    globalFundInfos_SummonFund = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DC14", VA = "0x435DC14")]
		private void _003CInitInfo_003Eb__92_55(List<GlobalFundInfo> list)
		{
		    globalFundInfos_CardFund = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DC1C", VA = "0x435DC1C")]
		private void _003CInitInfo_003Eb__92_56(List<GlobalFundInfo> list)
		{
		    globalFundInfos_MainCityPass = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DC24", VA = "0x435DC24")]
		private void _003CInitInfo_003Eb__92_57(List<GlobalFundInfo> list)
		{
		    globalFundInfos_SeasonPass = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DC2C", VA = "0x435DC2C")]
		private void _003CInitInfo_003Eb__92_58(List<ShopArenaPackInfos> list)
		{
		    shopArenaPackInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DC34", VA = "0x435DC34")]
		private void _003CInitInfo_003Eb__92_59(List<GlobalWeeklyCardDailyTaskInfo> list)
		{
		    globalWeeklyCardDailyTaskInfo = list;
		    globalWeeklyCardDailyTaskInfoDic = new Dictionary<string, GlobalWeeklyCardDailyTaskInfo>();
		    for (int index = 0; index < globalWeeklyCardDailyTaskInfo.Count; ++index)
		    {
		        globalWeeklyCardDailyTaskInfoDic.Add(globalWeeklyCardDailyTaskInfo[index].id, globalWeeklyCardDailyTaskInfo[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DD5C", VA = "0x435DD5C")]
		private void _003CInitInfo_003Eb__92_60(List<GlobalWeeklyCardStageInfo> list)
		{
		    globalWeeklyCardStageInfo = list;
		    globalWeeklyCardStageInfoDic = new Dictionary<string, GlobalWeeklyCardStageInfo>();
		    for (int index = 0; index < globalWeeklyCardStageInfo.Count; ++index)
		    {
		        globalWeeklyCardStageInfoDic.Add(globalWeeklyCardStageInfo[index].id, globalWeeklyCardStageInfo[index]);
		    }
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DE84", VA = "0x435DE84")]
		private void _003CInitInfo_003Eb__92_61(List<FundIAPInfo> list)
		{
		    fundIAPInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DE8C", VA = "0x435DE8C")]
		private void _003CInitInfo_003Eb__92_62(List<GlobalGiftChainInfo> list)
		{
		    globalGiftChainInfos_chain1 = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DE94", VA = "0x435DE94")]
		private void _003CInitInfo_003Eb__92_63(List<GlobalGiftChainInfo2> list)
		{
		    globalGiftChainInfos_chain2 = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DE9C", VA = "0x435DE9C")]
		private void _003CInitInfo_003Eb__92_64(List<GlobalTutorialInfo> list)
		{
		    globalTutorialInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DEA4", VA = "0x435DEA4")]
		private void _003CInitInfo_003Eb__92_65(List<GlobalFeatureUnlockInfo> list)
		{
		    globalFeatureUnlockInfos = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DEAC", VA = "0x435DEAC")]
		private void _003CInitInfo_003Eb__92_66(List<SeasonRankingRewardConfig> list)
		{
		    seasonRewardConfigs = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DEB4", VA = "0x435DEB4")]
		private void _003CInitInfo_003Eb__92_67(List<SeasonRankingRewardConfig> list)
		{
		    seasonRewardConfigs = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DEBC", VA = "0x435DEBC")]
		private void _003CInitInfo_003Eb__92_68(List<GameSettingConfig> list)
		{
		    gameSettingConfigs = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DEC4", VA = "0x435DEC4")]
		private void _003CInitInfo_003Eb__92_69(List<WeeklyClashDifficultyConfig> list)
		{
		    weeklyClashDifficultyConfigs = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DECC", VA = "0x435DECC")]
		private void _003CInitInfo_003Eb__92_70(List<WeeklyClashDifficultyConfig> list)
		{
		    weeklyClashDifficultyConfigs = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DED4", VA = "0x435DED4")]
		private void _003CInitInfo_003Eb__92_71(List<PanelConfig> list)
		{
		    panelConfigs = list;
		}
		
		[CompilerGenerated]
		[Address(RVA = "0x435DEDC", VA = "0x435DEDC")]
		private bool _003CInitInfo_003Eb__92_72()
		{
		    return loadingConfig.Count < 1;
		}

	}
}
