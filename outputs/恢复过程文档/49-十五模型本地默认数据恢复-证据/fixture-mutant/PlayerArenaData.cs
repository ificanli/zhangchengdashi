using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerArenaData : ServerBaseData
	{
		[JsonProperty("uadl")]
		public List<UserArenaData> userArenaDataList;
		[JsonProperty("wtc")]
		public int WonTrophyCount;
		[JsonProperty("dn")]
		public int DanNum;
		[JsonProperty("ihada")]
		public bool isHandleArenaDanAbout;
		[JsonProperty("isnasp")]
		public bool isSliverNoArena3SpecialPlayer;
		[JsonProperty("ihopau")]
		public bool isHandleOldPlayerArtifactsUnlock;
		public List<TrophyProgressRewardData> trophyProgressRewardDataList;
		public override void InitFromDefaults()
		{
    base.InitFromDefaults();
    DanNum = 1;
    if (userArenaDataList == null)
        userArenaDataList = new global::System.Collections.Generic.List<DataModule.UserArenaData>();
}
		public PlayerArenaData()
		{
    userArenaDataList = new global::System.Collections.Generic.List<DataModule.UserArenaData>();
}
	}
}
