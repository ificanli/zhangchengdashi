using System;
using System.Collections.Generic;
using System.Numerics;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerCoreData : ServerBaseData
	{
		[JsonProperty("nlr")]
		public bool nowLingquReward;
		[JsonProperty("fegt")]
		public DateTime firstEnterGameTime;
		[JsonProperty("mn")]
		public int moraleNum;
		[JsonProperty("mnsih")]
		public bool moraleNewSystemIsHandle;
		[JsonProperty("hdgd")]
		public bool handledDanGetData;
		[JsonProperty("pgc")]
		public int PlayerGameCount;
		[JsonProperty("wgc")]
		public int WonGameCount;
		[JsonProperty("wpgc")]
		public int PlayerWeeklyPlayGameCount;
		[JsonProperty("wwgc")]
		public int PlayerWeeklyWonGameCount;
		[JsonProperty("dpgc")]
		public int PlayerDailyPlayGameCount;
		[JsonProperty("dwgc")]
		public int PlayerDailyWonGameCount;
		public int DailyNoBetGoldEarned;
		[JsonProperty("gsd")]
		public bool getSliverDan;
		[JsonProperty("gwd")]
		public bool getWoodDan;
		[JsonProperty("gbd")]
		public bool getBronzeDan;
		[JsonProperty("ggd")]
		public bool getGoldenDan;
		[JsonProperty("gpd")]
		public bool getPlatinumDan;
		[JsonProperty("gdd")]
		public bool getDiamondDan;
		[JsonProperty("gmd")]
		public bool getMasterDan;
		[JsonProperty("ggmd")]
		public bool getGrandMasterDan;
		[JsonProperty("gcd")]
		public bool getChallengerDan;
		[JsonProperty("gdtsd")]
		public bool getDiamondTwoStarDan;
		[JsonProperty("gdtesd")]
		public bool getDiamondThereStarDan;
		[JsonProperty("gmtsd")]
		public bool getMasterTwoStarDan;
		[JsonProperty("gmtesd")]
		public bool getMasterThereStarDan;
		[JsonProperty("ggmtsd")]
		public bool getGrandMasterTwoStarDan;
		[JsonProperty("ggmtesd")]
		public bool getGrandMasterThereStarDan;
		[JsonProperty("ptic")]
		public bool playerTimeInfoConverted;
		[JsonProperty("uws")]
		public int userWinStreak;
		[JsonProperty("uls")]
		public int userLoseStreak;
		[JsonProperty("ipps")]
		public bool isPopPacks;
		[JsonProperty("neprc")]
		public List<int> nowExpProgressRewardConfig;
		[JsonProperty("hfhd")]
		public bool hadFixedHexData;
		[JsonProperty("lsuc")]
		public bool LoginSuccessfully;
		[JsonProperty("lhlrdt")]
		public DateTime lastHideLoginRedDotTime;
		[JsonProperty("ur")]
		public Dictionary<string, bool> UpgradeReward;
		[JsonProperty("tht")]
		public BigInteger TheHighestTrophy;
		[JsonProperty("sd")]
		public SeasonData seasonData;
		[JsonProperty("pdb")]
		public List<string> playerDayBless;
		[JsonProperty("uwad")]
		public UserWeeklyActivityData userWeeklyActivityData;
		[JsonProperty("wclpd")]
		public DateTime WeeklyCardLastPopupDate;
		[JsonProperty("wcdpc")]
		public int WeeklyCardDailyPopupCount;
		[JsonProperty("cbsd")]
		public Dictionary<string, CardBattleStatisticsData> cardBattleStatisticsDic;
		public override void InitFromDefaults()
		{
		}
		public override void Init()
		{
		}
		public PlayerCoreData()
		{
		}
	}
}
