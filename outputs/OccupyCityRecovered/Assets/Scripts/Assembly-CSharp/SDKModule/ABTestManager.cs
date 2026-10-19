using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppDummyDll;
using QuickTutor;

namespace SDKModule
{
	[Token(Token = "0x2000133")]
	public class ABTestManager : Singleton<ABTestManager>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000134")]
		[CompilerGenerated]
		private struct _003CInit_003Ed__206 : IAsyncStateMachine
		{
			[Token(Token = "0x4001A06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001A07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001A08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ABTestManager _003C_003E4__this;

			[Token(Token = "0x4001A09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object[] args;

			[Token(Token = "0x4001A0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private UniTask.Awaiter _003C_003Eu__1;

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x3F7310C", Offset = "0x3F6F10C", VA = "0x3F7310C", Slot = "4")]
void System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x3F73560", Offset = "0x3F6F560", VA = "0x3F73560", Slot = "5")]
			[DebuggerHidden]
void System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40019C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ArtifactsImproveABClass artifactsImproveAbClass;

		[Token(Token = "0x40019C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StackedStarterPackClass stackedStarterPackClass;

		[Token(Token = "0x40019C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MinesCountLimitClass minesCountLimitClass;

		[Token(Token = "0x40019C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ArenaDifficultyV2Class arenaDifficultyV2Class;

		[Token(Token = "0x40019C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private NewArenaMapClass newArenaMapClass;

		[Token(Token = "0x40019C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DynamicCoinsClass dynamicCoinsClass;

		[Token(Token = "0x40019C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ArtifactsSystemClass artifactsSystemClass;

		[Token(Token = "0x40019CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AdsLimitTo8Class adsLimitTo8Class;

		[Token(Token = "0x40019CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ArenaPackClass arenaPackClass;

		[Token(Token = "0x40019CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MaxArtifactUsageClass maxArtifactUsageClass;

		[Token(Token = "0x40019CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SelectableOfferClass selectableOfferClass;

		[Token(Token = "0x40019CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private SalesPurchaseLimitClass salesPurchaseLimitClass;

		[Token(Token = "0x40019CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private BalanceAdjustment01Class balanceAdjustment01Class;

		[Token(Token = "0x40019D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ChainRewardsIAPClass chainRewardsIAPClass;

		[Token(Token = "0x40019D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ChainRewards2Class chainRewards2Class;

		[Token(Token = "0x40019D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AbilitiesInAdvanceClass abilitiesInAdvanceClass;

		[Token(Token = "0x40019D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FundSystemClass fundSystemClass;

		[Token(Token = "0x40019D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AbilityTreeSystemClass abilityTreeSystemClass;

		[Token(Token = "0x40019D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private NewMainCitySystemClass newMainCitySystemClass;

		[Token(Token = "0x40019D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private NewArenaProcessClass newArenaProcessClass;

		[Token(Token = "0x40019D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private NewMoraleSystemClass newMoraleSystem;

		[Token(Token = "0x40019D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FundRewardsImproveClass fundRewardsImproveClass;

		[Token(Token = "0x40019D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InterstitialABClass interstitialAbClass;

		[Token(Token = "0x40019DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UniversalCardsClass universalCardsClass;

		[Token(Token = "0x40019DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private UserSegmentationClass userSegmentationClass;

		[Token(Token = "0x40019DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private NewHexaTypeClass newHexaTypeClass;

		[Token(Token = "0x40019DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private NewMainCity2Class mewMainCity2Class;

		[Token(Token = "0x40019DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private SeasonClass seasonClass;

		[Token(Token = "0x40019DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private NewMachineCardsClass newMachineCardsClass;

		[Token(Token = "0x40019E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private NewCardsV1Class newCardsV1Class;

		[Token(Token = "0x40019E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private WeeklyCardEventClass weeklyCardEventClass;

		[Token(Token = "0x40019E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private NewInterstitialABClass newInterstitialAbClass;

		[Token(Token = "0x40019E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private NewInterstitialAB_iOSClass newInterstitialAB_iOSClass;

		[Token(Token = "0x40019E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private BalanceAdjustment02Class balanceAdjustment02Class;

		[Token(Token = "0x40019E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private BalanceAdjustment03Class balanceAdjustment03Class;

		[Token(Token = "0x40019E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public SeasonConfigVoodoo seasonConfigVoodoo;

		[Token(Token = "0x40019E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private NewAbilitySystemClass newAbilitySystemClass;

		[Token(Token = "0x40019E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private DailyBlessClass dailyBlessClass;

		[Token(Token = "0x40019E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private MysticMarketClass mysticMarketClass;

		[Token(Token = "0x40019EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private CoinBalanceClass coinBalanceClass;

		[Token(Token = "0x40019EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private DoubleGemsOnFirstPurchaseClass doubleGemsOnFirstPurchaseClass;

		[Token(Token = "0x40019EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private ShopImproveV1Class shopImproveV1Class;

		[Token(Token = "0x40019ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private WeeklyClashImprove01Class weeklyClashImprove01Class;

		[Token(Token = "0x40019EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private WeeklyClashImprove02Class weeklyClashImprove02Class;

		[Token(Token = "0x40019EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private ChestImprove01Class chestImprove01Class;

		[Token(Token = "0x40019F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private GamePlayImprove01Class gamePlayImprove01Class;

		[Token(Token = "0x40019F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private GoldMinePrice01Class goldMinePrice01Class;

		[Token(Token = "0x40019F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private GoldMinePriceV2Class goldMinePriceV2Class;

		[Token(Token = "0x40019F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private GamePlayImproveV2Class gamePlayImproveV2Class;

		[Token(Token = "0x40019F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private ArenaRewardImprove01Class arenaRewardImprove01Class;

		[Token(Token = "0x40019F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private HigherViewClass higherViewClass;

		[Token(Token = "0x40019F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private HigherViewV2Class higherViewV2Class;

		[Token(Token = "0x40019F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private DynamicDifficulty01Class dynamicDifficulty01Class;

		[Token(Token = "0x40019F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private UnitCollisionEnableClass unitCollisionEnableClass;

		[Token(Token = "0x40019F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private FiefBalance01Class fiefBalance01Class;

		[Token(Token = "0x40019FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private IAPRewardAdjustment01Class iapRewardAdjustment01Class;

		[Token(Token = "0x40019FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private BottomChestUIClass bottomChestUIClass;

		[Token(Token = "0x40019FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private NoBetClass noBetClass;

		[Token(Token = "0x40019FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private GameCenterClass gameCenterClass;

		[Token(Token = "0x40019FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private NewbieTutorialClass newbieTutorialClass;

		[Token(Token = "0x40019FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private StarterPackImproveV1Class starterPackImproveV1Class;

		[Token(Token = "0x4001A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private NewArtifactsPlayClass newArtifactsPlayClass;

		[Token(Token = "0x4001A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private WeeklyHeroPackImproveV1Class weeklyHeroPackImproveV1Class;

		[Token(Token = "0x4001A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private InterstitialInfoV1 interstitialInfoV1;

		[Token(Token = "0x4001A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public bool hadGetAbTestValue;

		[Token(Token = "0x4001A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private List<string> allCohorts;

		[Token(Token = "0x4001A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private UnitsCountLimitClass countLimitClass;

		[Token(Token = "0x1700004B")]
		public bool CardIsBTest
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x3F7232C", Offset = "0x3F6E32C", VA = "0x3F7232C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004C")]
		public bool ArenaIsBTest
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x3F72334", Offset = "0x3F6E334", VA = "0x3F72334")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004D")]
		public bool MonthCardIsBTest
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x3F7233C", Offset = "0x3F6E33C", VA = "0x3F7233C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004E")]
		public bool LevelIsBTest
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x3F72344", Offset = "0x3F6E344", VA = "0x3F72344")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004F")]
		public bool MinesCountIsBTest
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x3F7234C", Offset = "0x3F6E34C", VA = "0x3F7234C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000050")]
		public bool ArenaDifficultyV2IsBTest
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x3F72354", Offset = "0x3F6E354", VA = "0x3F72354")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000051")]
		public bool NewMainCitySystemIsBTest
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x3F7235C", Offset = "0x3F6E35C", VA = "0x3F7235C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000052")]
		public bool AdsLimitTo8On
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x3F72364", Offset = "0x3F6E364", VA = "0x3F72364")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000053")]
		public bool FundSystemIsOn
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x3F7236C", Offset = "0x3F6E36C", VA = "0x3F7236C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000054")]
		public bool DynamicCoinsOn
		{
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x3F72374", Offset = "0x3F6E374", VA = "0x3F72374")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000055")]
		public bool SelectableOfferIsOn
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x3F7237C", Offset = "0x3F6E37C", VA = "0x3F7237C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000056")]
		public bool NewMapIsBTest
		{
			[Token(Token = "0x6000567")]
			[Address(RVA = "0x3F72384", Offset = "0x3F6E384", VA = "0x3F72384")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000057")]
		public bool ArtifactsSystemIsBTest
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x3F7238C", Offset = "0x3F6E38C", VA = "0x3F7238C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000058")]
		public bool StackedStarterPackIsBTest
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x3F72394", Offset = "0x3F6E394", VA = "0x3F72394")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000059")]
		public bool ArtifactsImproveAbIsOn
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x3F7239C", Offset = "0x3F6E39C", VA = "0x3F7239C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005A")]
		public bool NewArenaProcessIsBTest
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x3F723A4", Offset = "0x3F6E3A4", VA = "0x3F723A4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005B")]
		public bool UniversalCardsIsOn
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x3F723AC", Offset = "0x3F6E3AC", VA = "0x3F723AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005C")]
		public bool NewMoraleSystemIsBTest
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x3F723B4", Offset = "0x3F6E3B4", VA = "0x3F723B4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005D")]
		public bool ArenaPackIsB
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x3F723BC", Offset = "0x3F6E3BC", VA = "0x3F723BC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005E")]
		public bool UserSegmentationABIsBTest
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x3F723C4", Offset = "0x3F6E3C4", VA = "0x3F723C4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005F")]
		public bool AbilityTreeSystemIsOn
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x3F723CC", Offset = "0x3F6E3CC", VA = "0x3F723CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000060")]
		public bool MaxArtifactUsageIsOn
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x3F723D4", Offset = "0x3F6E3D4", VA = "0x3F723D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000061")]
		public bool SalesPurchaseLimitIsBTest
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x3F723DC", Offset = "0x3F6E3DC", VA = "0x3F723DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000062")]
		public bool BalanceAdjustment01IsBTest
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x3F723E4", Offset = "0x3F6E3E4", VA = "0x3F723E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000063")]
		public bool ChainRewardsIAPIsBTest
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x3F723EC", Offset = "0x3F6E3EC", VA = "0x3F723EC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000064")]
		public bool ChainRewards2IsBTest
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x3F723F4", Offset = "0x3F6E3F4", VA = "0x3F723F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000065")]
		public bool AbilitiesInAdvanceIsBTest
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x3F72418", Offset = "0x3F6E418", VA = "0x3F72418")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000066")]
		public bool FundRewardsImproveIsB
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x3F7243C", Offset = "0x3F6E43C", VA = "0x3F7243C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000067")]
		public bool InterstitialABIsB
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x3F72444", Offset = "0x3F6E444", VA = "0x3F72444")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000068")]
		public bool NewHexaTypeABIsBTest
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x3F7244C", Offset = "0x3F6E44C", VA = "0x3F7244C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000069")]
		public bool NewMainCity2
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x3F72454", Offset = "0x3F6E454", VA = "0x3F72454")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006A")]
		public bool NewMachineCardIsB
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x3F7245C", Offset = "0x3F6E45C", VA = "0x3F7245C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006B")]
		public bool NewCardsV1IsB
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x3F72464", Offset = "0x3F6E464", VA = "0x3F72464")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006C")]
		public bool WeeklyCardEventIsB
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x3F7246C", Offset = "0x3F6E46C", VA = "0x3F7246C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006D")]
		public bool SeasonIsBTest
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x3F72474", Offset = "0x3F6E474", VA = "0x3F72474")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006E")]
		public bool BalanceAdjustment02IsBTest
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x3F7247C", Offset = "0x3F6E47C", VA = "0x3F7247C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700006F")]
		public bool BalanceAdjustment03IsBTest
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x3F72484", Offset = "0x3F6E484", VA = "0x3F72484")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000070")]
		public bool NewInterstitialAbIsOn
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x3F7248C", Offset = "0x3F6E48C", VA = "0x3F7248C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000071")]
		public bool NewAbilitySystemAbIsOn
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x3F724B0", Offset = "0x3F6E4B0", VA = "0x3F724B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000072")]
		public bool NewInterstitialAB_iOSAbIsOn
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x3F724B8", Offset = "0x3F6E4B8", VA = "0x3F724B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000073")]
		public bool CoinBalanceIsBTest
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x3F724DC", Offset = "0x3F6E4DC", VA = "0x3F724DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000074")]
		public bool DoubleGemsOnFirstPurchaseIsBTest
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x3F724E4", Offset = "0x3F6E4E4", VA = "0x3F724E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000075")]
		public bool Dailybless_onIsBTest
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x3F724EC", Offset = "0x3F6E4EC", VA = "0x3F724EC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000076")]
		public bool MysticMarketIsOn
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x3F724F4", Offset = "0x3F6E4F4", VA = "0x3F724F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000077")]
		public bool ShopImproveV1IsBTest
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x3F724FC", Offset = "0x3F6E4FC", VA = "0x3F724FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000078")]
		public bool WeeklyClashImprove01IsBTest
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x3F7251C", Offset = "0x3F6E51C", VA = "0x3F7251C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000079")]
		public bool ArenaRewardImprove01
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x3F72524", Offset = "0x3F6E524", VA = "0x3F72524")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007A")]
		public bool WeeklyClashImprove02IsBTest
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x3F7252C", Offset = "0x3F6E52C", VA = "0x3F7252C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007B")]
		public bool ChestImprove01IsBTest
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x3F72534", Offset = "0x3F6E534", VA = "0x3F72534")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007C")]
		public bool NewbieTutorialIsBTest
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x3F72558", Offset = "0x3F6E558", VA = "0x3F72558")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007D")]
		public bool GamePlayImprove01IsBTest
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x3F7257C", Offset = "0x3F6E57C", VA = "0x3F7257C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007E")]
		public bool GamePlayImprove01IsCTest
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x3F72584", Offset = "0x3F6E584", VA = "0x3F72584")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700007F")]
		public bool GoldMinePrice01IsBTest
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x3F7258C", Offset = "0x3F6E58C", VA = "0x3F7258C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000080")]
		public bool GoldMinePriceV2IsBTest
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x3F72594", Offset = "0x3F6E594", VA = "0x3F72594")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000081")]
		public bool IsNewPathfindingBTest
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x3F725B8", Offset = "0x3F6E5B8", VA = "0x3F725B8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000082")]
		public bool HigherViewIsBTest
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x3F725C0", Offset = "0x3F6E5C0", VA = "0x3F725C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000083")]
		public bool HigherViewV2IsBTest
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x3F725C8", Offset = "0x3F6E5C8", VA = "0x3F725C8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000084")]
		public int FiefBalance01TestValue
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x3F725EC", Offset = "0x3F6E5EC", VA = "0x3F725EC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000085")]
		public bool IAPRewardAdjustment01
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x3F725F4", Offset = "0x3F6E5F4", VA = "0x3F725F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000086")]
		public bool DynamicDifficulty01IsBTest
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x3F725FC", Offset = "0x3F6E5FC", VA = "0x3F725FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000087")]
		public bool UnitCollisionEnableIsBTest
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x3F72604", Offset = "0x3F6E604", VA = "0x3F72604")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000088")]
		public bool BottomChestUIIsBTest
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x3F7260C", Offset = "0x3F6E60C", VA = "0x3F7260C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000089")]
		public bool NoBetIsBTest
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x3F72614", Offset = "0x3F6E614", VA = "0x3F72614")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008A")]
		public bool GameCenterIsBTest
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x3F7261C", Offset = "0x3F6E61C", VA = "0x3F7261C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008B")]
		public bool StarterPackImproveV1IsBTest
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x3F72640", Offset = "0x3F6E640", VA = "0x3F72640")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008C")]
		public bool NewArtifactsPlayIsBTest
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x3F72664", Offset = "0x3F6E664", VA = "0x3F72664")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008D")]
		public bool WeeklyHeroPackImproveV1
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x3F72688", Offset = "0x3F6E688", VA = "0x3F72688")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008E")]
		public bool UnitsCountIsBTest
		{
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x3F726AC", Offset = "0x3F6E6AC", VA = "0x3F726AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700008F")]
		public int GamePlayImproveV2Variant
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x3F726D0", Offset = "0x3F6E6D0", VA = "0x3F726D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x3F726F4", Offset = "0x3F6E6F4", VA = "0x3F726F4")]
		private int NormalizeV2Variant(int raw)
		{
			return default;
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x3F72704", Offset = "0x3F6E704", VA = "0x3F72704", Slot = "4")]
		[AsyncStateMachine(typeof(_003CInit_003Ed__206))]
		public override UniTask Init(params object[] args)
		{
			return default;
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x3F727A0", Offset = "0x3F6E7A0", VA = "0x3F727A0")]
		private void OnInitComplete()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x3F73040", Offset = "0x3F6F040", VA = "0x3F73040")]
		public ABTestManager()
		{
		}
	}
}
