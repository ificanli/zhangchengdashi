using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerRankData : ServerBaseData
	{
		[JsonProperty("ri")]
		public List<RankItemData> rankInfo;
		public PlayerRankData()
		{
		}
	}
}
