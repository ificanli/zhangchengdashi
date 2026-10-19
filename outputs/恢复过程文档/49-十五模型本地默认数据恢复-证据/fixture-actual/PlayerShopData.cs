using System;
using System.Collections.Generic;
using GameModule;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerShopData : ServerBaseData
	{
		[JsonProperty("dscdl")]
		public List<UserDailyShopCardData> daliyShopCardDataList;
		[JsonProperty("uhpc")]
		public Dictionary<string, int> userHumanPackCofig;
		[JsonProperty("uopc")]
		public Dictionary<string, int> userOrcPackCofig;
		public Dictionary<string, int> userMachinePackCofig;
		[JsonProperty("uupc")]
		public Dictionary<string, int> userUndeadPackCofig;
		[JsonProperty("uapc")]
		public Dictionary<string, int> userArtifactPackCofig;
		[JsonProperty("uappi")]
		public string userArtifactPackPropId;
		[JsonProperty("uappc")]
		public int userArtifactPackPropCount;
		[JsonProperty("uaprrd")]
		public bool userArtifactPackResetToNewConfigDone;
		[JsonProperty("uappd")]
		public List<string> userArtifactPackDrawnPropIds;
		[JsonProperty("ucpc")]
		public Dictionary<string, int> userCommonCardPackCofig;
		[JsonProperty("uafpc")]
		public Dictionary<string, int> userAllFetterPackCofig;
		[JsonProperty("ibmp")]
		public DateTime monthPassPurchaseTime;
		[JsonProperty("mped")]
		public DateTime monthPassExpiryTime;
		[JsonProperty("mp")]
		public List<string> monthPass;
		[JsonProperty("isnbgp")]
		public bool isShowNewBieGiftPack;
		[JsonProperty("fupspp")]
		public bool fistUnLockPropShowPropPack;
		[JsonProperty("ctpgp")]
		public bool canTimingPushGiftPackage;
		[JsonProperty("tpgpci")]
		public bool timingPushGiftPackageCdIng;
		[JsonProperty("tpgpbci")]
		public bool timingPushGiftPlayerBuyCdIng;
		[JsonProperty("tpgpt")]
		public ShopManager.TimingPushGiftPackType timingPushGiftPackType;
		[JsonProperty("tpgcrp")]
		public string rewardPartsCustom;
		[JsonProperty("hhtsob")]
		public bool hadHandleTwoSixOneBug;
		[JsonProperty("aiaprs")]
		public List<IAPRecord> allIAPRecords;
		[JsonProperty("auwars")]
		public Dictionary<int, int> allUserWatchAdRecords;
		[JsonProperty("frd")]
		public Dictionary<FundManager.FundType, FundData> fundData;
		[JsonProperty("cpbcnw")]
		public Dictionary<string, int> cardPackBuyCountNowWeek;
		[JsonProperty("gcd")]
		public GiftChainData giftChainData;
		[JsonProperty("gc2d")]
		public GiftChain2Data giftChain2Data;
		[JsonProperty("msncpd")]
		public List<MultistageNewcomerPackageData> multistageNewcomerPackageData;
		[JsonProperty("ucpr")]
		public Dictionary<string, int> universalCardPurchaseRestriction;
		[JsonProperty("apds")]
		public List<ArenaPackageData> arenaPackageDatas;
		[JsonProperty("dgd")]
		public Dictionary<string, bool> doubleGemsData;
		[JsonProperty("msd")]
		public List<MysteriousStoreData> mysteriousStoreData;
		[JsonProperty("gcwgpd")]
		public List<GoldCardWeeklyGiftPackData> goldCardWeeklyGiftPackData;
		[JsonProperty("hso")]
		public bool hasSpecialOffer;
		[JsonProperty("hep")]
		public bool hasElitePack;
		[JsonProperty("payCount")]
		public int payCount;
		[JsonProperty("cprsp")]
		public bool canPushRuneStonePack;
		[JsonProperty("prsbs")]
		public Dictionary<string, bool> playerRuneStoneBuyState;
		[JsonProperty("lpprc")]
		public Dictionary<int, int> limitedPropPackRemainCount;
		[JsonProperty("lppwpi")]
		public int limitedPropPackWeeklyPeriodIndex;
		[JsonProperty("cprc")]
		public Dictionary<int, int> crystalPackRemainCount;
		[JsonProperty("cldpi")]
		public int crystalPackLastDisplayPackId;
		public override void InitFromDefaults()
		{
    base.InitFromDefaults();
    isShowNewBieGiftPack = true;
    allIAPRecords = new global::System.Collections.Generic.List<DataModule.IAPRecord>();
    universalCardPurchaseRestriction = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
    allUserWatchAdRecords = new global::System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
    userAllFetterPackCofig = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
    hasSpecialOffer = true;
    hasElitePack = true;
}
		public PlayerShopData()
		{
    daliyShopCardDataList = new global::System.Collections.Generic.List<DataModule.UserDailyShopCardData>();
    userHumanPackCofig = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
    userOrcPackCofig = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
    userMachinePackCofig = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
    userUndeadPackCofig = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
    userArtifactPackCofig = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
    userArtifactPackPropId = string.Empty;
    userArtifactPackDrawnPropIds = new global::System.Collections.Generic.List<System.String>();
    userCommonCardPackCofig = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
    userAllFetterPackCofig = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
    monthPass = new global::System.Collections.Generic.List<System.String>();
    rewardPartsCustom = string.Empty;
    allIAPRecords = new global::System.Collections.Generic.List<DataModule.IAPRecord>();
    allUserWatchAdRecords = new global::System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
    hasSpecialOffer = true;
    hasElitePack = true;
    limitedPropPackRemainCount = new global::System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
    limitedPropPackWeeklyPeriodIndex = -1;
    crystalPackRemainCount = new global::System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
}
	}
}
