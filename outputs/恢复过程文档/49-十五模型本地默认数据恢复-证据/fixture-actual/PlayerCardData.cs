using System.Collections.Generic;
using Newtonsoft.Json;

namespace DataModule
{
	public class PlayerCardData : ServerBaseData
	{
		[JsonProperty("hcdl")]
		public List<UserHeroCardData> userHeroCardDataList;
		[JsonIgnore]
		public Dictionary<string, UserHeroCardData> userHeroCardDataDic;
		[JsonProperty("sgcd")]
		public List<string> userStayGetCardData;
		[JsonProperty("cddl")]
		public List<UserCardDeckData> UserCardDeckDataList;
		[JsonProperty("cdi")]
		public int cardDeckIndex;
		[JsonProperty("bcid")]
		public List<int> battleCardID;
		[JsonProperty("uhctd")]
		public Dictionary<string, UserCardTalentData> UserHeroCardTalentData;
		[JsonProperty("uhctdd")]
		public Dictionary<string, int> UserHeroCardTalentDotData;
		[JsonProperty("tbtihou")]
		public bool talentIsHandle;
		[JsonProperty("uhct2d")]
		public Dictionary<string, List<Talent2Data>> UserHeroCardTalent2Data;
		[JsonProperty("hhpas")]
		public bool hadHandlePlayerAbilityStone;
		public PlayerCardData()
		{
    userHeroCardDataList = new global::System.Collections.Generic.List<DataModule.UserHeroCardData>();
    userHeroCardDataDic = new global::System.Collections.Generic.Dictionary<System.String, DataModule.UserHeroCardData>();
    userStayGetCardData = new global::System.Collections.Generic.List<System.String>();
    UserCardDeckDataList = new global::System.Collections.Generic.List<DataModule.UserCardDeckData>();
    battleCardID = new global::System.Collections.Generic.List<System.Int32>
    {
        1001,
        1002,
        1003,
        1004,
        1005,
        1011,
        1013,
        1014
    };
    UserHeroCardTalentData = new global::System.Collections.Generic.Dictionary<System.String, DataModule.UserCardTalentData>();
    UserHeroCardTalentDotData = new global::System.Collections.Generic.Dictionary<System.String, System.Int32>();
}
	}
}
