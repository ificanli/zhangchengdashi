using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerCustomizationData : ServerBaseData
	{
		[JsonProperty("bgm")]
		public bool isAudioBgmEnable;
		[JsonProperty("sfx")]
		public bool isAudioSfxEnable;
		[JsonProperty("emoji")]
		public bool oepnAiSendEmoji;
		[JsonProperty("pn")]
		public string playerName;
		[JsonProperty("hsid")]
		public string HeadShotID;
		[JsonProperty("uld")]
		public UserLableData userLableData;
		[JsonProperty("psd")]
		public PlayerSkinData playerSkinData;
		public PlayerExpressionData playerExpressionData;
		public PlayerBubbleData playerBubbleData;
		public override void InitFromDefaults()
		{
		}
		public PlayerCustomizationData()
		{
		}
	}
}
