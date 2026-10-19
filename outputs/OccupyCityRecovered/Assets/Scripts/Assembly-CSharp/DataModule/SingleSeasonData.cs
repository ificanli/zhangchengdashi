using System;
using System.Collections.Generic;
using GameModule;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EB4")]
	public class SingleSeasonData
	{
		[Token(Token = "0x4006621")]
		[FieldOffset(Offset = "0x10")]
		public bool hadPlayedIntroAnimation;

		[Token(Token = "0x4006622")]
		[FieldOffset(Offset = "0x11")]
		[JsonProperty("hbp")]
		public bool hadBuyPass;

		[Token(Token = "0x4006623")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("id")]
		public string seasonId;

		[Token(Token = "0x4006624")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("hcsr")]
		public bool hadClaimSeasonReward;

		[Token(Token = "0x4006625")]
		[FieldOffset(Offset = "0x24")]
		[JsonProperty("s")]
		public int score;

		[Token(Token = "0x4006626")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("bn")]
		public int battlesNumber;

		[Token(Token = "0x4006627")]
		[FieldOffset(Offset = "0x2C")]
		[JsonProperty("wbn")]
		public int winBattlesNumber;

		[Token(Token = "0x4006628")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("rd")]
		public List<SeasonRankData> rankData;

		[Token(Token = "0x4006629")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("r")]
		public int rank;

		[Token(Token = "0x400662A")]
		[FieldOffset(Offset = "0x40")]
		private SeasonConfig seasonConfig;

		[Token(Token = "0x600592E")]
		[Address(RVA = "0x43699BC", Offset = "0x43659BC", VA = "0x43699BC")]
		public int CalculateRealScore()
		{
			return default;
		}

		[Token(Token = "0x600592F")]
		[Address(RVA = "0x4369D04", Offset = "0x4365D04", VA = "0x4369D04")]
		public SeasonConfig GetConfig()
		{
			return null;
		}

		[Token(Token = "0x6005930")]
		[Address(RVA = "0x4369E64", Offset = "0x4365E64", VA = "0x4369E64")]
		public SeasonManager.SeasonStatus GetStatus()
		{
			return default;
		}

		[Token(Token = "0x6005931")]
		[Address(RVA = "0x4369FAC", Offset = "0x4365FAC", VA = "0x4369FAC")]
		public SingleSeasonData()
		{
		}
	}
}
