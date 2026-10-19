using System.Collections.Generic;
using GameFramework.Resources;
using Il2CppDummyDll;

namespace ljzs_lt
{
	[Token(Token = "0x2000F19")]
	public class ConfigMgr
	{
		[Token(Token = "0x4006878")]
		[FieldOffset(Offset = "0x10")]
		public bool IsInitialize;

		[Token(Token = "0x4006879")]
		[FieldOffset(Offset = "0x18")]
		public readonly Dictionary<object, GoalRewardConfig> dicGoalReward;

		[Token(Token = "0x400687A")]
		[FieldOffset(Offset = "0x20")]
		public readonly Dictionary<object, WorldCupdailyTaskConfig> dicWorldCupdailyTask;

		[Token(Token = "0x400687B")]
		[FieldOffset(Offset = "0x28")]
		public readonly Dictionary<object, WorldCupdailyPriceConfig> dicWorldCupdailyPrice;

		[Token(Token = "0x400687C")]
		[FieldOffset(Offset = "0x30")]
		public readonly Dictionary<object, PointShopConfig> dicPointShop;

		[Token(Token = "0x400687D")]
		[FieldOffset(Offset = "0x38")]
		public readonly Dictionary<object, WorldCuphow2PlayConfig> dicWorldCuphow2Play;

		[Token(Token = "0x400687E")]
		[FieldOffset(Offset = "0x40")]
		public readonly Dictionary<object, DiceConfigConfig> dicDiceConfig;

		[Token(Token = "0x400687F")]
		[FieldOffset(Offset = "0x48")]
		public readonly Dictionary<object, BuildConfigConfig> dicBuildConfig;

		[Token(Token = "0x4006880")]
		[FieldOffset(Offset = "0x50")]
		public readonly Dictionary<object, ChessboardConfig> dicChessboard;

		[Token(Token = "0x4006881")]
		[FieldOffset(Offset = "0x58")]
		public readonly Dictionary<object, PoolConfigConfig> dicPoolConfig;

		[Token(Token = "0x4006882")]
		[FieldOffset(Offset = "0x60")]
		public readonly Dictionary<object, RuinsConfigConfig> dicRuinsConfig;

		[Token(Token = "0x4006883")]
		[FieldOffset(Offset = "0x68")]
		public readonly Dictionary<object, DailyTaskConfig> dicDailyTask;

		[Token(Token = "0x4006884")]
		[FieldOffset(Offset = "0x70")]
		public readonly Dictionary<object, DailyPriceConfig> dicDailyPrice;

		[Token(Token = "0x4006885")]
		[FieldOffset(Offset = "0x78")]
		public readonly Dictionary<object, TotalDiceConfig> dicTotalDice;

		[Token(Token = "0x4006886")]
		[FieldOffset(Offset = "0x80")]
		public readonly Dictionary<object, LapsConfigConfig> dicLapsConfig;

		[Token(Token = "0x4006887")]
		[FieldOffset(Offset = "0x88")]
		public readonly Dictionary<object, SaleShopConfig> dicSaleShop;

		[Token(Token = "0x4006888")]
		[FieldOffset(Offset = "0x90")]
		public readonly Dictionary<object, How2PlayConfig> dicHow2Play;

		[Token(Token = "0x4006889")]
		[FieldOffset(Offset = "0x98")]
		public readonly Dictionary<object, PurchaseConfig> dicPurchase;

		[Token(Token = "0x400688A")]
		[FieldOffset(Offset = "0xA0")]
		public readonly Dictionary<object, CdkConfig> dicCdk;

		[Token(Token = "0x400688B")]
		[FieldOffset(Offset = "0xA8")]
		public readonly Dictionary<object, CompareCardInfoConfig> dicCompareCardInfo;

		[Token(Token = "0x400688C")]
		[FieldOffset(Offset = "0xB0")]
		public readonly Dictionary<object, WordEmojiConfig> dicWordEmoji;

		[Token(Token = "0x400688D")]
		[FieldOffset(Offset = "0xB8")]
		public readonly Dictionary<object, SubGameBuffConfig> dicSubGameBuff;

		[Token(Token = "0x400688E")]
		[FieldOffset(Offset = "0xC0")]
		public readonly Dictionary<object, CompareShenqiInfoConfig> dicCompareShenqiInfo;

		[Token(Token = "0x400688F")]
		[FieldOffset(Offset = "0xC8")]
		public readonly Dictionary<object, PropAttrBuffInfoConfig> dicPropAttrBuffInfo;

		[Token(Token = "0x4006890")]
		[FieldOffset(Offset = "0xD0")]
		public readonly Dictionary<object, PropUpgradeInfoConfig> dicPropUpgradeInfo;

		[Token(Token = "0x4006891")]
		[FieldOffset(Offset = "0xD8")]
		public readonly Dictionary<object, PropRankUpInfoConfig> dicPropRankUpInfo;

		[Token(Token = "0x4006892")]
		[FieldOffset(Offset = "0xE0")]
		public readonly Dictionary<object, PropAttrEnumInfoConfig> dicPropAttrEnumInfo;

		[Token(Token = "0x4006893")]
		[FieldOffset(Offset = "0xE8")]
		public readonly Dictionary<object, PropAttrTypeConfig> dicPropAttrType;

		[Token(Token = "0x4006894")]
		[FieldOffset(Offset = "0xF0")]
		public readonly Dictionary<object, PropForgePowerConfig> dicPropForgePower;

		[Token(Token = "0x4006895")]
		[FieldOffset(Offset = "0xF8")]
		public readonly Dictionary<object, AIPropInfoConfig> dicAIPropInfo;

		[Token(Token = "0x4006896")]
		[FieldOffset(Offset = "0x100")]
		public readonly Dictionary<object, AIPropInfoBConfig> dicAIPropInfoB;

		[Token(Token = "0x4006897")]
		[FieldOffset(Offset = "0x108")]
		public readonly Dictionary<object, AIPropInfoCConfig> dicAIPropInfoC;

		[Token(Token = "0x4006898")]
		[FieldOffset(Offset = "0x110")]
		public readonly Dictionary<object, LimitedPropInfoConfig> dicLimitedPropInfo;

		[Token(Token = "0x4006899")]
		[FieldOffset(Offset = "0x118")]
		public readonly Dictionary<object, LimitedPropPackConfig> dicLimitedPropPack;

		[Token(Token = "0x400689A")]
		[FieldOffset(Offset = "0x120")]
		public readonly Dictionary<object, CrystalPackConfig> dicCrystalPack;

		[Token(Token = "0x400689B")]
		[FieldOffset(Offset = "0x128")]
		public readonly Dictionary<object, LimitedPropOrderConfig> dicLimitedPropOrder;

		[Token(Token = "0x400689C")]
		[FieldOffset(Offset = "0x130")]
		public readonly Dictionary<object, CheckInRewardsIndexConfig> dicCheckInRewardsIndex;

		[Token(Token = "0x400689D")]
		[FieldOffset(Offset = "0x138")]
		public readonly Dictionary<object, CheckInRewardsConfig> dicCheckInRewards;

		[Token(Token = "0x400689E")]
		[FieldOffset(Offset = "0x140")]
		public readonly Dictionary<object, CumulativeRewardConfig> dicCumulativeReward;

		[Token(Token = "0x400689F")]
		[FieldOffset(Offset = "0x148")]
		public SettingConfig settingConfig;

		[Token(Token = "0x40068A0")]
		[FieldOffset(Offset = "0x150")]
		public WorldCupbaseConfigConfig worldCupbaseConfigConfig;

		[Token(Token = "0x40068A1")]
		[FieldOffset(Offset = "0x158")]
		public BaseConfigConfig baseConfigConfig;

		[Token(Token = "0x40068A2")]
		[FieldOffset(Offset = "0x0")]
		private static ConfigMgr _instance;

		[Token(Token = "0x40068A3")]
		[FieldOffset(Offset = "0x160")]
		public readonly Dictionary<int, List<PoolConfigConfig>> dicPoolConfigByPoolId;

		[Token(Token = "0x17000F44")]
		public static ConfigMgr Instance
		{
			[Token(Token = "0x6005AEA")]
			[Address(RVA = "0x4399F1C", Offset = "0x4395F1C", VA = "0x4399F1C")]
			get
			{
			if (_instance == null)
			    _instance = new ConfigMgr();
			return _instance;
		}
		}

		[Token(Token = "0x6005AE7")]
		[Address(RVA = "0x4399578", Offset = "0x4395578", VA = "0x4399578")]
		public void Initialize()
		{
			GameFramework.ConfigRead.IsUserJsonUtility = true;
			GameFramework.AppSetting.IsUseMemoryPack = false;
			if (!IsInitialize)
			{
			    ReadConfig();
			    customRead();
			    IsInitialize = true;
			}
		}

		[Token(Token = "0x6005AE8")]
		[Address(RVA = "0x4399658", Offset = "0x4395658", VA = "0x4399658")]
		private void ReadConfig()
		{
			GameFramework.ConfigRead.readConfigByUnityJson<GoalRewardConfig>(dicGoalReward);
			GameFramework.ConfigRead.readConfigByUnityJson<WorldCupdailyTaskConfig>(dicWorldCupdailyTask);
			GameFramework.ConfigRead.readConfigByUnityJson<WorldCupdailyPriceConfig>(dicWorldCupdailyPrice);
			GameFramework.ConfigRead.readConfigByUnityJson<PointShopConfig>(dicPointShop);
			GameFramework.ConfigRead.readConfigByUnityJson<WorldCuphow2PlayConfig>(dicWorldCuphow2Play);
			GameFramework.ConfigRead.readConfigByUnityJson<DiceConfigConfig>(dicDiceConfig);
			GameFramework.ConfigRead.readConfigByUnityJson<BuildConfigConfig>(dicBuildConfig);
			GameFramework.ConfigRead.readConfigByUnityJson<ChessboardConfig>(dicChessboard);
			GameFramework.ConfigRead.readConfigByUnityJson<PoolConfigConfig>(dicPoolConfig);
			GameFramework.ConfigRead.readConfigByUnityJson<RuinsConfigConfig>(dicRuinsConfig);
			GameFramework.ConfigRead.readConfigByUnityJson<DailyTaskConfig>(dicDailyTask);
			GameFramework.ConfigRead.readConfigByUnityJson<DailyPriceConfig>(dicDailyPrice);
			GameFramework.ConfigRead.readConfigByUnityJson<TotalDiceConfig>(dicTotalDice);
			GameFramework.ConfigRead.readConfigByUnityJson<LapsConfigConfig>(dicLapsConfig);
			GameFramework.ConfigRead.readConfigByUnityJson<SaleShopConfig>(dicSaleShop);
			GameFramework.ConfigRead.readConfigByUnityJson<How2PlayConfig>(dicHow2Play);
			GameFramework.ConfigRead.readConfigByUnityJson<PurchaseConfig>(dicPurchase);
			GameFramework.ConfigRead.readConfigByUnityJson<CdkConfig>(dicCdk);
			GameFramework.ConfigRead.readConfigByUnityJson<CompareCardInfoConfig>(dicCompareCardInfo);
			GameFramework.ConfigRead.readConfigByUnityJson<WordEmojiConfig>(dicWordEmoji);
			GameFramework.ConfigRead.readConfigByUnityJson<SubGameBuffConfig>(dicSubGameBuff);
			GameFramework.ConfigRead.readConfigByUnityJson<CompareShenqiInfoConfig>(dicCompareShenqiInfo);
			GameFramework.ConfigRead.readConfigByUnityJson<PropAttrBuffInfoConfig>(dicPropAttrBuffInfo);
			GameFramework.ConfigRead.readConfigByUnityJson<PropUpgradeInfoConfig>(dicPropUpgradeInfo);
			GameFramework.ConfigRead.readConfigByUnityJson<PropRankUpInfoConfig>(dicPropRankUpInfo);
			GameFramework.ConfigRead.readConfigByUnityJson<PropAttrEnumInfoConfig>(dicPropAttrEnumInfo);
			GameFramework.ConfigRead.readConfigByUnityJson<PropAttrTypeConfig>(dicPropAttrType);
			GameFramework.ConfigRead.readConfigByUnityJson<PropForgePowerConfig>(dicPropForgePower);
			GameFramework.ConfigRead.readConfigByUnityJson<AIPropInfoConfig>(dicAIPropInfo);
			GameFramework.ConfigRead.readConfigByUnityJson<AIPropInfoBConfig>(dicAIPropInfoB);
			GameFramework.ConfigRead.readConfigByUnityJson<AIPropInfoCConfig>(dicAIPropInfoC);
			GameFramework.ConfigRead.readConfigByUnityJson<LimitedPropInfoConfig>(dicLimitedPropInfo);
			GameFramework.ConfigRead.readConfigByUnityJson<LimitedPropPackConfig>(dicLimitedPropPack);
			GameFramework.ConfigRead.readConfigByUnityJson<CrystalPackConfig>(dicCrystalPack);
			GameFramework.ConfigRead.readConfigByUnityJson<LimitedPropOrderConfig>(dicLimitedPropOrder);
			GameFramework.ConfigRead.readConfigByUnityJson<CheckInRewardsIndexConfig>(dicCheckInRewardsIndex);
			GameFramework.ConfigRead.readConfigByUnityJson<CheckInRewardsConfig>(dicCheckInRewards);
			GameFramework.ConfigRead.readConfigByUnityJson<CumulativeRewardConfig>(dicCumulativeReward);
			settingConfig = GameFramework.ConfigRead.readConfigVByUnityJson<SettingConfig>();
			worldCupbaseConfigConfig = GameFramework.ConfigRead.readConfigVByUnityJson<WorldCupbaseConfigConfig>();
			baseConfigConfig = GameFramework.ConfigRead.readConfigVByUnityJson<BaseConfigConfig>();
		}

		[Token(Token = "0x6005AE9")]
		[Address(RVA = "0x4399EBC", Offset = "0x4395EBC", VA = "0x4399EBC")]
		public void SetConfigABRes(ResourcesInfo resourcesInfo)
		{
			GameFramework.ConfigRead.configRes = resourcesInfo;
		}

		[Token(Token = "0x6005AEB")]
		[Address(RVA = "0x4399BEC", Offset = "0x4395BEC", VA = "0x4399BEC")]
		private void customRead()
		{
			dicPoolConfigByPoolId.Clear();
			foreach (KeyValuePair<object, PoolConfigConfig> pair in dicPoolConfig)
			{
			    PoolConfigConfig value = pair.Value;
			    if (value == null || value.pool_id < 1)
			        continue;
			    List<PoolConfigConfig> list;
			    if (!dicPoolConfigByPoolId.TryGetValue(value.pool_id, out list))
			    {
			        list = new List<PoolConfigConfig>();
			        dicPoolConfigByPoolId.Add(value.pool_id, list);
			    }
			    list.Add(value);
			}
		}

		[Token(Token = "0x6005AEC")]
		[Address(RVA = "0x4399F18", Offset = "0x4395F18", VA = "0x4399F18")]
		private void SetReloadConfigAction()
		{
		}

		[Token(Token = "0x6005AED")]
		[Address(RVA = "0x4399F90", Offset = "0x4395F90", VA = "0x4399F90")]
		public ConfigMgr()
		{
			dicGoalReward = new Dictionary<object, GoalRewardConfig>();
			dicWorldCupdailyTask = new Dictionary<object, WorldCupdailyTaskConfig>();
			dicWorldCupdailyPrice = new Dictionary<object, WorldCupdailyPriceConfig>();
			dicPointShop = new Dictionary<object, PointShopConfig>();
			dicWorldCuphow2Play = new Dictionary<object, WorldCuphow2PlayConfig>();
			dicDiceConfig = new Dictionary<object, DiceConfigConfig>();
			dicBuildConfig = new Dictionary<object, BuildConfigConfig>();
			dicChessboard = new Dictionary<object, ChessboardConfig>();
			dicPoolConfig = new Dictionary<object, PoolConfigConfig>();
			dicRuinsConfig = new Dictionary<object, RuinsConfigConfig>();
			dicDailyTask = new Dictionary<object, DailyTaskConfig>();
			dicDailyPrice = new Dictionary<object, DailyPriceConfig>();
			dicTotalDice = new Dictionary<object, TotalDiceConfig>();
			dicLapsConfig = new Dictionary<object, LapsConfigConfig>();
			dicSaleShop = new Dictionary<object, SaleShopConfig>();
			dicHow2Play = new Dictionary<object, How2PlayConfig>();
			dicPurchase = new Dictionary<object, PurchaseConfig>();
			dicCdk = new Dictionary<object, CdkConfig>();
			dicCompareCardInfo = new Dictionary<object, CompareCardInfoConfig>();
			dicWordEmoji = new Dictionary<object, WordEmojiConfig>();
			dicSubGameBuff = new Dictionary<object, SubGameBuffConfig>();
			dicCompareShenqiInfo = new Dictionary<object, CompareShenqiInfoConfig>();
			dicPropAttrBuffInfo = new Dictionary<object, PropAttrBuffInfoConfig>();
			dicPropUpgradeInfo = new Dictionary<object, PropUpgradeInfoConfig>();
			dicPropRankUpInfo = new Dictionary<object, PropRankUpInfoConfig>();
			dicPropAttrEnumInfo = new Dictionary<object, PropAttrEnumInfoConfig>();
			dicPropAttrType = new Dictionary<object, PropAttrTypeConfig>();
			dicPropForgePower = new Dictionary<object, PropForgePowerConfig>();
			dicAIPropInfo = new Dictionary<object, AIPropInfoConfig>();
			dicAIPropInfoB = new Dictionary<object, AIPropInfoBConfig>();
			dicAIPropInfoC = new Dictionary<object, AIPropInfoCConfig>();
			dicLimitedPropInfo = new Dictionary<object, LimitedPropInfoConfig>();
			dicLimitedPropPack = new Dictionary<object, LimitedPropPackConfig>();
			dicCrystalPack = new Dictionary<object, CrystalPackConfig>();
			dicLimitedPropOrder = new Dictionary<object, LimitedPropOrderConfig>();
			dicCheckInRewardsIndex = new Dictionary<object, CheckInRewardsIndexConfig>();
			dicCheckInRewards = new Dictionary<object, CheckInRewardsConfig>();
			dicCumulativeReward = new Dictionary<object, CumulativeRewardConfig>();
			dicPoolConfigByPoolId = new Dictionary<int, List<PoolConfigConfig>>();
		}
	}
}
