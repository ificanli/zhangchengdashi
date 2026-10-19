using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	public class SeasonData
	{
		[JsonProperty("pdgspc")]
		public int PlayerDailyGetSeasonPassCount;
		[JsonProperty("pdgsps")]
		public int PlayerDailyGetSeasonPassScore;
		[JsonProperty("bn")]
		public int battlesNumber;
		[JsonProperty("wbn")]
		public int winBattleNumber;
		[JsonProperty("id")]
		public string currentSeasonId;
		[JsonProperty("asd")]
		public Dictionary<string, SingleSeasonData> allSeasonData;
		[JsonProperty("cwci")]
		public string currentWeeklyClashId;
		[JsonProperty("awcd")]
		public Dictionary<string, SingleWeeklyClashData> allWeeklyClashData;
		public SeasonData()
		{
		}
	}
}
