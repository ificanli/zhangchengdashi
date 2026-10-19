using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EC2")]
	public class PlayerCardData : ServerBaseData
	{
		[Token(Token = "0x4006661")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("hcdl")]
		public List<UserHeroCardData> userHeroCardDataList;

		[Token(Token = "0x4006662")]
		[FieldOffset(Offset = "0x18")]
		[JsonIgnore]
		public Dictionary<string, UserHeroCardData> userHeroCardDataDic;

		[Token(Token = "0x4006663")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("sgcd")]
		public List<string> userStayGetCardData;

		[Token(Token = "0x4006664")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("cddl")]
		public List<UserCardDeckData> UserCardDeckDataList;

		[Token(Token = "0x4006665")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("cdi")]
		public int cardDeckIndex;

		[Token(Token = "0x4006666")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("bcid")]
		public List<int> battleCardID;

		[Token(Token = "0x4006667")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("uhctd")]
		public Dictionary<string, UserCardTalentData> UserHeroCardTalentData;

		[Token(Token = "0x4006668")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("uhctdd")]
		public Dictionary<string, int> UserHeroCardTalentDotData;

		[Token(Token = "0x4006669")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("tbtihou")]
		public bool talentIsHandle;

		[Token(Token = "0x400666A")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("uhct2d")]
		public Dictionary<string, List<Talent2Data>> UserHeroCardTalent2Data;

		[Token(Token = "0x400666B")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("hhpas")]
		public bool hadHandlePlayerAbilityStone;

		[Token(Token = "0x6005981")]
		[Address(RVA = "0x436E814", Offset = "0x436A814", VA = "0x436E814", Slot = "5")]
		public override void InitFromDefaults()
		{
		}

		[Token(Token = "0x6005982")]
		[Address(RVA = "0x436E81C", Offset = "0x436A81C", VA = "0x436E81C", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005983")]
		[Address(RVA = "0x4370190", Offset = "0x436C190", VA = "0x4370190")]
		private void HandleBToAEquipCard(List<string> excludeCardIds)
		{
		}

		[Token(Token = "0x6005984")]
		[Address(RVA = "0x43708DC", Offset = "0x436C8DC", VA = "0x43708DC")]
		public List<int> GetBattleCardIDList()
		{
			return null;
		}

		[Token(Token = "0x6005985")]
		[Address(RVA = "0x437093C", Offset = "0x436C93C", VA = "0x437093C")]
		public List<UserHeroCardData> GetBattleCardList()
		{
			return null;
		}

		[Token(Token = "0x6005986")]
		[Address(RVA = "0x4370AD8", Offset = "0x436CAD8", VA = "0x4370AD8")]
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
