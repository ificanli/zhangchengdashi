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
    base.InitFromDefaults();
    if (userResourcesDataList == null)
        userResourcesDataList = new global::System.Collections.Generic.List<DataModule.UserAssetData>();
}
		public PlayerResourceData()
		{
    userResourcesDataList = new global::System.Collections.Generic.List<DataModule.UserAssetData>();
    userResourcesDataDic = new global::System.Collections.Generic.Dictionary<System.String, DataModule.UserAssetData>();
}
	}
}
