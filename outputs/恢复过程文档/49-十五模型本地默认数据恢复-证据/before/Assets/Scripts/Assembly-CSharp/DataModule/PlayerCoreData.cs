using System;
using System.Collections.Generic;
using System.Numerics;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EC7")]
	public class PlayerCoreData : ServerBaseData
	{
		[Token(Token = "0x4006677")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("nlr")]
		public bool nowLingquReward;

		[Token(Token = "0x4006678")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("fegt")]
		public DateTime firstEnterGameTime;

		[Token(Token = "0x4006679")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("mn")]
		public int moraleNum;

		[Token(Token = "0x400667A")]
		[FieldOffset(Offset = "0x24")]
		[JsonProperty("mnsih")]
		public bool moraleNewSystemIsHandle;

		[Token(Token = "0x400667B")]
		[FieldOffset(Offset = "0x25")]
		[JsonProperty("hdgd")]
		public bool handledDanGetData;

		[Token(Token = "0x400667C")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("pgc")]
		public int PlayerGameCount;

		[Token(Token = "0x400667D")]
		[FieldOffset(Offset = "0x2C")]
		[JsonProperty("wgc")]
		public int WonGameCount;

		[Token(Token = "0x400667E")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("wpgc")]
		public int PlayerWeeklyPlayGameCount;

		[Token(Token = "0x400667F")]
		[FieldOffset(Offset = "0x34")]
		[JsonProperty("wwgc")]
		public int PlayerWeeklyWonGameCount;

		[Token(Token = "0x4006680")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("dpgc")]
		public int PlayerDailyPlayGameCount;

		[Token(Token = "0x4006681")]
		[FieldOffset(Offset = "0x3C")]
		[JsonProperty("dwgc")]
		public int PlayerDailyWonGameCount;

		[Token(Token = "0x4006682")]
		[FieldOffset(Offset = "0x40")]
		public int DailyNoBetGoldEarned;

		[Token(Token = "0x4006683")]
		[FieldOffset(Offset = "0x44")]
		[JsonProperty("gsd")]
		public bool getSliverDan;

		[Token(Token = "0x4006684")]
		[FieldOffset(Offset = "0x45")]
		[JsonProperty("gwd")]
		public bool getWoodDan;

		[Token(Token = "0x4006685")]
		[FieldOffset(Offset = "0x46")]
		[JsonProperty("gbd")]
		public bool getBronzeDan;

		[Token(Token = "0x4006686")]
		[FieldOffset(Offset = "0x47")]
		[JsonProperty("ggd")]
		public bool getGoldenDan;

		[Token(Token = "0x4006687")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("gpd")]
		public bool getPlatinumDan;

		[Token(Token = "0x4006688")]
		[FieldOffset(Offset = "0x49")]
		[JsonProperty("gdd")]
		public bool getDiamondDan;

		[Token(Token = "0x4006689")]
		[FieldOffset(Offset = "0x4A")]
		[JsonProperty("gmd")]
		public bool getMasterDan;

		[Token(Token = "0x400668A")]
		[FieldOffset(Offset = "0x4B")]
		[JsonProperty("ggmd")]
		public bool getGrandMasterDan;

		[Token(Token = "0x400668B")]
		[FieldOffset(Offset = "0x4C")]
		[JsonProperty("gcd")]
		public bool getChallengerDan;

		[Token(Token = "0x400668C")]
		[FieldOffset(Offset = "0x4D")]
		[JsonProperty("gdtsd")]
		public bool getDiamondTwoStarDan;

		[Token(Token = "0x400668D")]
		[FieldOffset(Offset = "0x4E")]
		[JsonProperty("gdtesd")]
		public bool getDiamondThereStarDan;

		[Token(Token = "0x400668E")]
		[FieldOffset(Offset = "0x4F")]
		[JsonProperty("gmtsd")]
		public bool getMasterTwoStarDan;

		[Token(Token = "0x400668F")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("gmtesd")]
		public bool getMasterThereStarDan;

		[Token(Token = "0x4006690")]
		[FieldOffset(Offset = "0x51")]
		[JsonProperty("ggmtsd")]
		public bool getGrandMasterTwoStarDan;

		[Token(Token = "0x4006691")]
		[FieldOffset(Offset = "0x52")]
		[JsonProperty("ggmtesd")]
		public bool getGrandMasterThereStarDan;

		[Token(Token = "0x4006692")]
		[FieldOffset(Offset = "0x53")]
		[JsonProperty("ptic")]
		public bool playerTimeInfoConverted;

		[Token(Token = "0x4006693")]
		[FieldOffset(Offset = "0x54")]
		[JsonProperty("uws")]
		public int userWinStreak;

		[Token(Token = "0x4006694")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("uls")]
		public int userLoseStreak;

		[Token(Token = "0x4006695")]
		[FieldOffset(Offset = "0x5C")]
		[JsonProperty("ipps")]
		public bool isPopPacks;

		[Token(Token = "0x4006696")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("neprc")]
		public List<int> nowExpProgressRewardConfig;

		[Token(Token = "0x4006697")]
		[FieldOffset(Offset = "0x68")]
		[JsonProperty("hfhd")]
		public bool hadFixedHexData;

		[Token(Token = "0x4006698")]
		[FieldOffset(Offset = "0x69")]
		[JsonProperty("lsuc")]
		public bool LoginSuccessfully;

		[Token(Token = "0x4006699")]
		[FieldOffset(Offset = "0x70")]
		[JsonProperty("lhlrdt")]
		public DateTime lastHideLoginRedDotTime;

		[Token(Token = "0x400669A")]
		[FieldOffset(Offset = "0x78")]
		[JsonProperty("ur")]
		public Dictionary<string, bool> UpgradeReward;

		[Token(Token = "0x400669B")]
		[FieldOffset(Offset = "0x80")]
		[JsonProperty("tht")]
		public BigInteger TheHighestTrophy;

		[Token(Token = "0x400669C")]
		[FieldOffset(Offset = "0x90")]
		[JsonProperty("sd")]
		public SeasonData seasonData;

		[Token(Token = "0x400669D")]
		[FieldOffset(Offset = "0x98")]
		[JsonProperty("pdb")]
		public List<string> playerDayBless;

		[Token(Token = "0x400669E")]
		[FieldOffset(Offset = "0xA0")]
		[JsonProperty("uwad")]
		public UserWeeklyActivityData userWeeklyActivityData;

		[Token(Token = "0x400669F")]
		[FieldOffset(Offset = "0xA8")]
		[JsonProperty("wclpd")]
		public DateTime WeeklyCardLastPopupDate;

		[Token(Token = "0x40066A0")]
		[FieldOffset(Offset = "0xB0")]
		[JsonProperty("wcdpc")]
		public int WeeklyCardDailyPopupCount;

		[Token(Token = "0x40066A1")]
		[FieldOffset(Offset = "0xB8")]
		[JsonProperty("cbsd")]
		public Dictionary<string, CardBattleStatisticsData> cardBattleStatisticsDic;

		[Token(Token = "0x6005992")]
		[Address(RVA = "0x43719F8", Offset = "0x436D9F8", VA = "0x43719F8", Slot = "5")]
		public override void InitFromDefaults()
		{
		}

		[Token(Token = "0x6005993")]
		[Address(RVA = "0x4371ADC", Offset = "0x436DADC", VA = "0x4371ADC", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005994")]
		[Address(RVA = "0x4371B5C", Offset = "0x436DB5C", VA = "0x4371B5C")]
		public PlayerCoreData()
		{
		}
	}
}
