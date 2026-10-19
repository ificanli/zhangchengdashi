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
    base.InitFromDefaults();
    if (ToolModule.StringTool.IsNullOrEmpty(playerName, true))
    {
        int number = 0;
        for (int i = 0; i < 6; i++)
        {
            int digit = new global::System.Random().Next(0, 9);
            number += (int)global::System.Math.Pow(10, i) * digit;
        }

        playerName = "User" + number.ToString();
    }
}
		public PlayerCustomizationData()
		{
    isAudioBgmEnable = true;
    isAudioSfxEnable = true;
    oepnAiSendEmoji = true;
    HeadShotID = "1003";
}
	}
}
