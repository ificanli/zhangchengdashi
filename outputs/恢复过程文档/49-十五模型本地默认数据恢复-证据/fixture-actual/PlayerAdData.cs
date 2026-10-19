using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerAdData : ServerBaseData
	{
		[JsonProperty("wdgpac")]
		public int WatchDailyGiftPackAdCount;
		[JsonIgnore]
		public int MaxWatchDailyGiftPackAdCount;
		[JsonProperty("wcac")]
		public int WatchCoinAdCount;
		[JsonProperty("wwac")]
		public int WatchWoodAdCount;
		[JsonProperty("wsac")]
		public int WatchStoneAdCount;
		[JsonProperty("wcrac")]
		public int WatchCrystalAdCount;
		[JsonProperty("srappc")]
		public int showRemoveAdPassPanelCount;
		[JsonProperty("sie")]
		public bool ShowInterstitialEd;
		[JsonProperty("rvmppd")]
		public string LastDayFirstRvMonthPassPop;
		public override void InitFromDefaults()
		{
    base.InitFromDefaults();
    WatchCoinAdCount = 5;
    WatchWoodAdCount = 5;
    WatchStoneAdCount = 5;
    WatchCrystalAdCount = 5;
    showRemoveAdPassPanelCount = 1;
}
		public PlayerAdData()
		{
    WatchStoneAdCount = 5;
    WatchCrystalAdCount = 5;
}
	}
}
