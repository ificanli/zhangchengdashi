using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerTimeData : ServerBaseData
	{
		[JsonProperty("tid")]
		public Dictionary<string, TimeInfo> timeInfoDic;
		[JsonProperty("legt")]
		public DateTime lastExitGameTime;
		public PlayerTimeData()
		{
    timeInfoDic = new Dictionary<string, TimeInfo>();
}
	}
}
