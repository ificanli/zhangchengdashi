using System;
using System.Collections.Generic;
using GameModule;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000ED1")]
	public class PlayerShopData : ServerBaseData
	{
		[Token(Token = "0x40066C6")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("dscdl")]
		public List<UserDailyShopCardData> daliyShopCardDataList;

		[Token(Token = "0x40066C7")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("uhpc")]
		public Dictionary<string, int> userHumanPackCofig;

		[Token(Token = "0x40066C8")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("uopc")]
		public Dictionary<string, int> userOrcPackCofig;

		[Token(Token = "0x40066C9")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, int> userMachinePackCofig;

		[Token(Token = "0x40066CA")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("uupc")]
		public Dictionary<string, int> userUndeadPackCofig;

		[Token(Token = "0x40066CB")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("uapc")]
		public Dictionary<string, int> userArtifactPackCofig;

		[Token(Token = "0x40066CC")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("uappi")]
		public string userArtifactPackPropId;

		[Token(Token = "0x40066CD")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("uappc")]
		public int userArtifactPackPropCount;

		[Token(Token = "0x40066CE")]
		[FieldOffset(Offset = "0x4C")]
		[JsonProperty("uaprrd")]
		public bool userArtifactPackResetToNewConfigDone;

		[Token(Token = "0x40066CF")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("uappd")]
		public List<string> userArtifactPackDrawnPropIds;

		[Token(Token = "0x40066D0")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("ucpc")]
		public Dictionary<string, int> userCommonCardPackCofig;

		[Token(Token = "0x40066D1")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("uafpc")]
		public Dictionary<string, int> userAllFetterPackCofig;

		[Token(Token = "0x40066D2")]
		[FieldOffset(Offset = "0x68")]
		[JsonProperty("ibmp")]
		public DateTime monthPassPurchaseTime;

		[Token(Token = "0x40066D3")]
		[FieldOffset(Offset = "0x70")]
		[JsonProperty("mped")]
		public DateTime monthPassExpiryTime;

		[Token(Token = "0x40066D4")]
		[FieldOffset(Offset = "0x78")]
		[JsonProperty("mp")]
		public List<string> monthPass;

		[Token(Token = "0x40066D5")]
		[FieldOffset(Offset = "0x80")]
		[JsonProperty("isnbgp")]
		public bool isShowNewBieGiftPack;

		[Token(Token = "0x40066D6")]
		[FieldOffset(Offset = "0x81")]
		[JsonProperty("fupspp")]
		public bool fistUnLockPropShowPropPack;

		[Token(Token = "0x40066D7")]
		[FieldOffset(Offset = "0x82")]
		[JsonProperty("ctpgp")]
		public bool canTimingPushGiftPackage;

		[Token(Token = "0x40066D8")]
		[FieldOffset(Offset = "0x83")]
		[JsonProperty("tpgpci")]
		public bool timingPushGiftPackageCdIng;

		[Token(Token = "0x40066D9")]
		[FieldOffset(Offset = "0x84")]
		[JsonProperty("tpgpbci")]
		public bool timingPushGiftPlayerBuyCdIng;

		[Token(Token = "0x40066DA")]
		[FieldOffset(Offset = "0x88")]
		[JsonProperty("tpgpt")]
		public ShopManager.TimingPushGiftPackType timingPushGiftPackType;

		[Token(Token = "0x40066DB")]
		[FieldOffset(Offset = "0x90")]
		[JsonProperty("tpgcrp")]
		public string rewardPartsCustom;

		[Token(Token = "0x40066DC")]
		[FieldOffset(Offset = "0x98")]
		[JsonProperty("hhtsob")]
		public bool hadHandleTwoSixOneBug;

		[Token(Token = "0x40066DD")]
		[FieldOffset(Offset = "0xA0")]
		[JsonProperty("aiaprs")]
		public List<IAPRecord> allIAPRecords;

		[Token(Token = "0x40066DE")]
		[FieldOffset(Offset = "0xA8")]
		[JsonProperty("auwars")]
		public Dictionary<int, int> allUserWatchAdRecords;

		[Token(Token = "0x40066DF")]
		[FieldOffset(Offset = "0xB0")]
		[JsonProperty("frd")]
		public Dictionary<FundManager.FundType, FundData> fundData;

		[Token(Token = "0x40066E0")]
		[FieldOffset(Offset = "0xB8")]
		[JsonProperty("cpbcnw")]
		public Dictionary<string, int> cardPackBuyCountNowWeek;

		[Token(Token = "0x40066E1")]
		[FieldOffset(Offset = "0xC0")]
		[JsonProperty("gcd")]
		public GiftChainData giftChainData;

		[Token(Token = "0x40066E2")]
		[FieldOffset(Offset = "0xC8")]
		[JsonProperty("gc2d")]
		public GiftChain2Data giftChain2Data;

		[Token(Token = "0x40066E3")]
		[FieldOffset(Offset = "0xD0")]
		[JsonProperty("msncpd")]
		public List<MultistageNewcomerPackageData> multistageNewcomerPackageData;

		[Token(Token = "0x40066E4")]
		[FieldOffset(Offset = "0xD8")]
		[JsonProperty("ucpr")]
		public Dictionary<string, int> universalCardPurchaseRestriction;

		[Token(Token = "0x40066E5")]
		[FieldOffset(Offset = "0xE0")]
		[JsonProperty("apds")]
		public List<ArenaPackageData> arenaPackageDatas;

		[Token(Token = "0x40066E6")]
		[FieldOffset(Offset = "0xE8")]
		[JsonProperty("dgd")]
		public Dictionary<string, bool> doubleGemsData;

		[Token(Token = "0x40066E7")]
		[FieldOffset(Offset = "0xF0")]
		[JsonProperty("msd")]
		public List<MysteriousStoreData> mysteriousStoreData;

		[Token(Token = "0x40066E8")]
		[FieldOffset(Offset = "0xF8")]
		[JsonProperty("gcwgpd")]
		public List<GoldCardWeeklyGiftPackData> goldCardWeeklyGiftPackData;

		[Token(Token = "0x40066E9")]
		[FieldOffset(Offset = "0x100")]
		[JsonProperty("hso")]
		public bool hasSpecialOffer;

		[Token(Token = "0x40066EA")]
		[FieldOffset(Offset = "0x101")]
		[JsonProperty("hep")]
		public bool hasElitePack;

		[Token(Token = "0x40066EB")]
		[FieldOffset(Offset = "0x104")]
		[JsonProperty("payCount")]
		public int payCount;

		[Token(Token = "0x40066EC")]
		[FieldOffset(Offset = "0x108")]
		[JsonProperty("cprsp")]
		public bool canPushRuneStonePack;

		[Token(Token = "0x40066ED")]
		[FieldOffset(Offset = "0x110")]
		[JsonProperty("prsbs")]
		public Dictionary<string, bool> playerRuneStoneBuyState;

		[Token(Token = "0x40066EE")]
		[FieldOffset(Offset = "0x118")]
		[JsonProperty("lpprc")]
		public Dictionary<int, int> limitedPropPackRemainCount;

		[Token(Token = "0x40066EF")]
		[FieldOffset(Offset = "0x120")]
		[JsonProperty("lppwpi")]
		public int limitedPropPackWeeklyPeriodIndex;

		[Token(Token = "0x40066F0")]
		[FieldOffset(Offset = "0x128")]
		[JsonProperty("cprc")]
		public Dictionary<int, int> crystalPackRemainCount;

		[Token(Token = "0x40066F1")]
		[FieldOffset(Offset = "0x130")]
		[JsonProperty("cldpi")]
		public int crystalPackLastDisplayPackId;

		[Token(Token = "0x60059AE")]
		[Address(RVA = "0x4374030", Offset = "0x4370030", VA = "0x4374030", Slot = "5")]
		public override void InitFromDefaults()
		{
		}

		[Token(Token = "0x60059AF")]
		[Address(RVA = "0x4374168", Offset = "0x4370168", VA = "0x4374168", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x60059B0")]
		[Address(RVA = "0x43755B0", Offset = "0x43715B0", VA = "0x43755B0")]
		private Dictionary<string, int> ReplaceBlackListKeys(CardFettersType fettersType, Dictionary<string, int> userHumanPackConfig, List<string> black)
		{
			return null;
		}

		[Token(Token = "0x60059B1")]
		[Address(RVA = "0x43751E8", Offset = "0x43711E8", VA = "0x43751E8")]
		private void NormalizeArtifactPackConfigForBGroup()
		{
		}

		[Token(Token = "0x60059B2")]
		[Address(RVA = "0x4375F14", Offset = "0x4371F14", VA = "0x4375F14")]
		public void ReCountPayCount()
		{
		}

		[Token(Token = "0x60059B3")]
		[Address(RVA = "0x43760EC", Offset = "0x43720EC", VA = "0x43760EC")]
		public void AddOrUpdateIAPRecord(string productId)
		{
		}

		[Token(Token = "0x60059B4")]
		[Address(RVA = "0x4376418", Offset = "0x4372418", VA = "0x4376418")]
		public void RecordUserWathcAdCount(int rvID)
		{
		}

		[Token(Token = "0x60059B5")]
		[Address(RVA = "0x4376520", Offset = "0x4372520", VA = "0x4376520")]
		public PlayerShopData()
		{
		}
	}
}
