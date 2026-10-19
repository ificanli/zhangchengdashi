using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000ECA")]
	public class PlayerGuideData : ServerBaseData
	{
		[Token(Token = "0x40066AE")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("iftg")]
		public bool isFirstThroghGame;

		[Token(Token = "0x40066AF")]
		[FieldOffset(Offset = "0x11")]
		[JsonProperty("pwed")]
		public bool PLayerWonED;

		[Token(Token = "0x40066B0")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("tdd")]
		public Dictionary<string, int> tutorialDataDic;

		[Token(Token = "0x40066B1")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("utdl")]
		public List<UserTutorialData> UserTutorialDataList;

		[Token(Token = "0x40066B2")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("uufl")]
		public Dictionary<string, UserFeatureUnlockData> UserUnlockFeatureList;

		[Token(Token = "0x40066B3")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("itc")]
		public bool isTrainingComplete;

		[Token(Token = "0x40066B4")]
		[FieldOffset(Offset = "0x34")]
		[JsonProperty("tgi")]
		public int trainingGameIndex;

		[Token(Token = "0x40066B5")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("tgv")]
		public int trainingGroupVariant;

		[Token(Token = "0x40066B6")]
		[FieldOffset(Offset = "0x3C")]
		public bool hadClaimTrainingCompleteReward;

		[Token(Token = "0x6005999")]
		[Address(RVA = "0x4372360", Offset = "0x436E360", VA = "0x4372360", Slot = "5")]
		public override void InitFromDefaults()
		{
		}

		[Token(Token = "0x600599A")]
		[Address(RVA = "0x4372380", Offset = "0x436E380", VA = "0x4372380")]
		public PlayerGuideData()
		{
		}
	}
}
