using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EB6")]
	public class SeasonData
	{
		[Token(Token = "0x400662D")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("pdgspc")]
		public int PlayerDailyGetSeasonPassCount;

		[Token(Token = "0x400662E")]
		[FieldOffset(Offset = "0x14")]
		[JsonProperty("pdgsps")]
		public int PlayerDailyGetSeasonPassScore;

		[Token(Token = "0x400662F")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("bn")]
		public int battlesNumber;

		[Token(Token = "0x4006630")]
		[FieldOffset(Offset = "0x1C")]
		[JsonProperty("wbn")]
		public int winBattleNumber;

		[Token(Token = "0x4006631")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("id")]
		public string currentSeasonId;

		[Token(Token = "0x4006632")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("asd")]
		public Dictionary<string, SingleSeasonData> allSeasonData;

		[Token(Token = "0x4006633")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("cwci")]
		public string currentWeeklyClashId;

		[Token(Token = "0x4006634")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("awcd")]
		public Dictionary<string, SingleWeeklyClashData> allWeeklyClashData;

		[Token(Token = "0x6005937")]
		[Address(RVA = "0x4369114", Offset = "0x4365114", VA = "0x4369114")]
		public SingleSeasonData AddNewSingleSeasonData(string newSeasonId)
		{
			return null;
		}

		[Token(Token = "0x6005938")]
		[Address(RVA = "0x436A0EC", Offset = "0x43660EC", VA = "0x436A0EC")]
		public SingleWeeklyClashData AddNewSingleWeeklyClashData(string newWeeklyClashId, int WeeklyClashMaxBattleNumber)
		{
			return null;
		}

		[Token(Token = "0x6005939")]
		[Address(RVA = "0x4369080", Offset = "0x4365080", VA = "0x4369080")]
		public SingleSeasonData GetSeasonDataById(string seasonId)
		{
			return null;
		}

		[Token(Token = "0x600593A")]
		[Address(RVA = "0x436A214", Offset = "0x4366214", VA = "0x436A214")]
		public SingleSeasonData GetCurrentSeasonData()
		{
			return null;
		}

		[Token(Token = "0x600593B")]
		[Address(RVA = "0x4369DD0", Offset = "0x4365DD0", VA = "0x4369DD0")]
		public SingleWeeklyClashData GetWeeklyClashDataById(string id)
		{
			return null;
		}

		[Token(Token = "0x600593C")]
		[Address(RVA = "0x436A21C", Offset = "0x436621C", VA = "0x436A21C")]
		public SingleWeeklyClashData GetCurrentWeeklyClashData()
		{
			return null;
		}

		[Token(Token = "0x600593D")]
		[Address(RVA = "0x436A224", Offset = "0x4366224", VA = "0x436A224")]
		public SeasonData()
		{
    allSeasonData = new global::System.Collections.Generic.Dictionary<string, global::DataModule.SingleSeasonData>();
    allWeeklyClashData = new global::System.Collections.Generic.Dictionary<string, global::DataModule.SingleWeeklyClashData>();
}
	}
}
