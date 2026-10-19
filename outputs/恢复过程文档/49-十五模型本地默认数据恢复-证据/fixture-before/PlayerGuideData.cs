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
		}
		public PlayerGuideData()
		{
		}
	}
}
