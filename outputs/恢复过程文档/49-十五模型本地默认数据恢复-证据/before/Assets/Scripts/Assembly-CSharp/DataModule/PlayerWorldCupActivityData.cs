using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EF4")]
	public class PlayerWorldCupActivityData : ServerBaseData
	{
		[Token(Token = "0x40067D2")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("fc")]
		public int footballCount;

		[Token(Token = "0x40067D3")]
		[FieldOffset(Offset = "0x14")]
		[JsonProperty("as")]
		public int activityScore;

		[Token(Token = "0x40067D4")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("fsddk")]
		public string faceSlapDismissDateKey;

		[Token(Token = "0x40067D5")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("sbc")]
		public Dictionary<int, int> shopBuyCounts;

		[Token(Token = "0x40067D6")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("pdc")]
		public Dictionary<int, int> packDailyBuyCounts;

		[Token(Token = "0x40067D7")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("pbdk")]
		public string packBuyDateKey;

		[Token(Token = "0x40067D8")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("dtdk")]
		public string dailyTaskDateKey;

		[Token(Token = "0x40067D9")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("dtr")]
		public List<WorldCupDailyTaskRecord> dailyTaskRecords;

		[Token(Token = "0x40067DA")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("ast")]
		public DateTime activityStartTime;

		[Token(Token = "0x40067DB")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("aet")]
		public DateTime activityEndTime;

		[Token(Token = "0x17000F3A")]
		public bool HasDailyTaskData
		{
			[Token(Token = "0x6005A30")]
			[Address(RVA = "0x437A71C", Offset = "0x437671C", VA = "0x437A71C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005A2C")]
		[Address(RVA = "0x437A574", Offset = "0x4376574", VA = "0x437A574")]
		public void ResetForNewActivity(DateTime startTime, DateTime endTime, int initFootball)
		{
		}

		[Token(Token = "0x6005A2D")]
		[Address(RVA = "0x437A6B8", Offset = "0x43766B8", VA = "0x437A6B8")]
		public void ClearOnActivityEnded()
		{
		}

		[Token(Token = "0x6005A2E")]
		[Address(RVA = "0x437A5EC", Offset = "0x43765EC", VA = "0x437A5EC")]
		public void ClearDailyGiftProgress()
		{
		}

		[Token(Token = "0x6005A2F")]
		[Address(RVA = "0x437A648", Offset = "0x4376648", VA = "0x437A648")]
		public void ClearDailyTaskProgress()
		{
		}

		[Token(Token = "0x6005A31")]
		[Address(RVA = "0x437A780", Offset = "0x4376780", VA = "0x437A780")]
		public int GetPackDailyBuyCount(int packId)
		{
			return default;
		}

		[Token(Token = "0x6005A32")]
		[Address(RVA = "0x437A7F4", Offset = "0x43767F4", VA = "0x437A7F4")]
		public void AddPackDailyBuyCount(int packId)
		{
		}

		[Token(Token = "0x6005A33")]
		[Address(RVA = "0x437A8B4", Offset = "0x43768B4", VA = "0x437A8B4")]
		public int GetShopBuyCount(int shopId)
		{
			return default;
		}

		[Token(Token = "0x6005A34")]
		[Address(RVA = "0x437A928", Offset = "0x4376928", VA = "0x437A928")]
		public void AddShopBuyCount(int shopId)
		{
		}

		[Token(Token = "0x6005A35")]
		[Address(RVA = "0x437A9E8", Offset = "0x43769E8", VA = "0x437A9E8")]
		public PlayerWorldCupActivityData()
		{
		}
	}
}
