using System.Collections.Generic;
using System.Numerics;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerResourceData : ServerBaseData
	{
		[JsonProperty("urdl")]
		public List<UserAssetData> userResourcesDataList;
		private Dictionary<string, UserAssetData> userResourcesDataDic;
		public override void InitFromDefaults()
		{
		}
		public PlayerResourceData()
		{
		}
	}
}
