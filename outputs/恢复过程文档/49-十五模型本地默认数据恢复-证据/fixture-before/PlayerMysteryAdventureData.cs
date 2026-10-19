using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerMysteryAdventureData : ServerBaseData
	{
		[JsonProperty("ula")]
		public bool unlockActivity;
		[JsonProperty("ast")]
		public DateTime activityStartTime;
		[JsonProperty("aet")]
		public DateTime activityEndTime;
		[JsonProperty("cc")]
		public int currentCellId;
		[JsonProperty("dc")]
		public int diceCount;
		[JsonProperty("lrt")]
		public DateTime lastDiceRecoverTime;
		[JsonProperty("lc")]
		public int lapCount;
		[JsonProperty("tdc")]
		public int totalDiceConsumed;
		[JsonProperty("ctdr")]
		public List<int> claimedTotalDiceRewardIds;
		[JsonProperty("clrl")]
		public List<int> claimedLapRewardLevels;
		[JsonProperty("dgdk")]
		public string dailyGiftDateKey;
		[JsonProperty("fsddk")]
		public string faceSlapDismissDateKey;
		[JsonProperty("dgpc")]
		public Dictionary<int, int> dailyGiftPurchaseCounts;
		[JsonProperty("dsids")]
		public List<int> discountShopItemIds;
		[JsonProperty("dspc")]
		public List<int> discountShopPurchasedIds;
		[JsonProperty("dsvc")]
		public int discountShopVisitCount;
		[JsonProperty("prbb")]
		public bool pendingRuinsBanditBattle;
		[JsonProperty("prbbr")]
		public string pendingRuinsBanditBaseRewardRaw;
		[JsonProperty("prbcr")]
		public string pendingRuinsBanditClaimRewardRaw;
		[JsonProperty("prbrpo")]
		public bool pendingRuinsBanditRuinsPanelOpen;
		[JsonProperty("d")]
		public string dailyTaskDateKey;
		[JsonProperty("r")]
		public List<MysteryAdventureDailyTaskRecord> dailyTaskRecords;
		public PlayerMysteryAdventureData()
		{
		}
	}
}
