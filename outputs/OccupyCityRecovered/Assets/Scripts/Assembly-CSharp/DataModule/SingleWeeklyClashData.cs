using System;
using System.Collections.Generic;
using GameModule;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EB0")]
	public class SingleWeeklyClashData
	{
		[Token(Token = "0x400660F")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4006610")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("rsbn")]
		public int requirementStatusBattleNumber;

		[Token(Token = "0x4006611")]
		[FieldOffset(Offset = "0x1C")]
		[JsonProperty("rbn")]
		public int remainingBattleNumber;

		[Token(Token = "0x4006612")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("bn")]
		public int battlesNumber;

		[Token(Token = "0x4006613")]
		[FieldOffset(Offset = "0x24")]
		[JsonProperty("wbn")]
		public int winBattlesNumber;

		[Token(Token = "0x4006614")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("hcr")]
		public bool hadClaimReward;

		[Token(Token = "0x4006615")]
		[FieldOffset(Offset = "0x2C")]
		[JsonProperty("s")]
		public int scores;

		[Token(Token = "0x4006616")]
		[FieldOffset(Offset = "0x30")]
		public List<WeeklyClashBattleLog> battleLogs;

		[Token(Token = "0x4006617")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("wcs")]
		public SeasonManager.WeeklyClashStatus weeklyClashStatus;

		[Token(Token = "0x4006618")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("rd")]
		public List<SeasonRankData> rankData;

		[Token(Token = "0x4006619")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("r")]
		public int rank;

		[Token(Token = "0x400661A")]
		[FieldOffset(Offset = "0x50")]
		private WeeklyClashConfig weeklyClashConfig;

		[Token(Token = "0x400661B")]
		[FieldOffset(Offset = "0x58")]
		private SingleSeasonData belongingSeason;

		[Token(Token = "0x6005921")]
		[Address(RVA = "0x4368D78", Offset = "0x4364D78", VA = "0x4368D78")]
		public void ChangeWeeklyClashStatus(SeasonManager.WeeklyClashStatus weeklyClashStatus)
		{
		}

		[Token(Token = "0x6005922")]
		[Address(RVA = "0x4368EE0", Offset = "0x4364EE0", VA = "0x4368EE0")]
		public WeeklyClashConfig GetConfig()
		{
			return null;
		}

		[Token(Token = "0x6005923")]
		[Address(RVA = "0x4368FAC", Offset = "0x4364FAC", VA = "0x4368FAC")]
		public SingleSeasonData GetSeason()
		{
			return null;
		}

		[Token(Token = "0x6005924")]
		[Address(RVA = "0x436923C", Offset = "0x436523C", VA = "0x436923C")]
		public int CalculateRealScore()
		{
			return default;
		}

		[Token(Token = "0x6005925")]
		[Address(RVA = "0x4369760", Offset = "0x4365760", VA = "0x4369760")]
		public SingleWeeklyClashData()
		{
		}
	}
}
