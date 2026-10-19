using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerWorldCupActivityData : ServerBaseData
	{
		[JsonProperty("fc")]
		public int footballCount;
		[JsonProperty("as")]
		public int activityScore;
		[JsonProperty("fsddk")]
		public string faceSlapDismissDateKey;
		[JsonProperty("sbc")]
		public Dictionary<int, int> shopBuyCounts;
		[JsonProperty("pdc")]
		public Dictionary<int, int> packDailyBuyCounts;
		[JsonProperty("pbdk")]
		public string packBuyDateKey;
		[JsonProperty("dtdk")]
		public string dailyTaskDateKey;
		[JsonProperty("dtr")]
		public List<WorldCupDailyTaskRecord> dailyTaskRecords;
		[JsonProperty("ast")]
		public DateTime activityStartTime;
		[JsonProperty("aet")]
		public DateTime activityEndTime;
		public PlayerWorldCupActivityData()
		{
    shopBuyCounts = new global::System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
    packDailyBuyCounts = new global::System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
    dailyTaskRecords = new global::System.Collections.Generic.List<DataModule.WorldCupDailyTaskRecord>();
}
	}
}
