using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerMainCityData : ServerBaseData
	{
		[JsonProperty("ptl")]
		public Dictionary<string, int> playerTalentLevel;
		[JsonProperty("hds")]
		public List<UserOutsiderHexData> HexDatas;
		[JsonProperty("tds")]
		public List<UserTileData> tileDatas;
		[JsonProperty("fds")]
		public List<UserFamilyData> familyDatas;
		[JsonProperty("ultn")]
		public int unLockTileNum;
		[JsonProperty("mcti")]
		public string mainCityTitleId;
		[JsonProperty("itw")]
		public bool isReturnWood;
		[JsonProperty("iouumd")]
		public bool isOldUserUpdateMapData;
		[JsonIgnore]
		public Dictionary<string, int> playerTalentNew;
		public override void InitFromDefaults()
		{
    base.InitFromDefaults();
    if (playerTalentLevel == null)
        playerTalentLevel = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
}
		public PlayerMainCityData()
		{
    playerTalentLevel = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
    HexDatas = new global::System.Collections.Generic.List<DataModule.UserOutsiderHexData>();
    tileDatas = new global::System.Collections.Generic.List<DataModule.UserTileData>();
    familyDatas = new global::System.Collections.Generic.List<DataModule.UserFamilyData>();
    playerTalentNew = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
}
	}
}
