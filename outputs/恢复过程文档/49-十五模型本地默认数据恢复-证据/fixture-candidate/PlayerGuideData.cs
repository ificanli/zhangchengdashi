using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerGuideData : ServerBaseData
	{
		[JsonProperty("iftg")]
		public bool isFirstThroghGame;
		[JsonProperty("pwed")]
		public bool PLayerWonED;
		[JsonProperty("tdd")]
		public Dictionary<string, int> tutorialDataDic;
		[JsonProperty("utdl")]
		public List<UserTutorialData> UserTutorialDataList;
		[JsonProperty("uufl")]
		public Dictionary<string, UserFeatureUnlockData> UserUnlockFeatureList;
		[JsonProperty("itc")]
		public bool isTrainingComplete;
		[JsonProperty("tgi")]
		public int trainingGameIndex;
		[JsonProperty("tgv")]
		public int trainingGroupVariant;
		public bool hadClaimTrainingCompleteReward;
		public override void InitFromDefaults()
		{
    base.InitFromDefaults();
    isFirstThroghGame = true;
}
		public PlayerGuideData()
		{
    tutorialDataDic = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
    UserTutorialDataList = new global::System.Collections.Generic.List<DataModule.UserTutorialData>();
    UserUnlockFeatureList = new global::System.Collections.Generic.Dictionary<System.String, DataModule.UserFeatureUnlockData>();
}
	}
}
