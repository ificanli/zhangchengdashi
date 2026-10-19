using System;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	public class TimeInfo
	{
		[JsonProperty("k")]
		public string Key;
		[JsonProperty("st")]
		public DateTime StartTime;
		[JsonProperty("tet")]
		public DateTime TargetEndTime;
		[JsonProperty("usnt")]
		public bool useStandardNetTime;
		public TimeInfo()
		{
		}
	}
}
