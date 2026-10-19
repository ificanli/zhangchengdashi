using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EAA")]
	public class PlayerMysteryAdventureData : ServerBaseData
	{
		[Token(Token = "0x40065ED")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("ula")]
		public bool unlockActivity;

		[Token(Token = "0x40065EE")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("ast")]
		public DateTime activityStartTime;

		[Token(Token = "0x40065EF")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("aet")]
		public DateTime activityEndTime;

		[Token(Token = "0x40065F0")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("cc")]
		public int currentCellId;

		[Token(Token = "0x40065F1")]
		[FieldOffset(Offset = "0x2C")]
		[JsonProperty("dc")]
		public int diceCount;

		[Token(Token = "0x40065F2")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("lrt")]
		public DateTime lastDiceRecoverTime;

		[Token(Token = "0x40065F3")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("lc")]
		public int lapCount;

		[Token(Token = "0x40065F4")]
		[FieldOffset(Offset = "0x3C")]
		[JsonProperty("tdc")]
		public int totalDiceConsumed;

		[Token(Token = "0x40065F5")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("ctdr")]
		public List<int> claimedTotalDiceRewardIds;

		[Token(Token = "0x40065F6")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("clrl")]
		public List<int> claimedLapRewardLevels;

		[Token(Token = "0x40065F7")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("dgdk")]
		public string dailyGiftDateKey;

		[Token(Token = "0x40065F8")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("fsddk")]
		public string faceSlapDismissDateKey;

		[Token(Token = "0x40065F9")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("dgpc")]
		public Dictionary<int, int> dailyGiftPurchaseCounts;

		[Token(Token = "0x40065FA")]
		[FieldOffset(Offset = "0x68")]
		[JsonProperty("dsids")]
		public List<int> discountShopItemIds;

		[Token(Token = "0x40065FB")]
		[FieldOffset(Offset = "0x70")]
		[JsonProperty("dspc")]
		public List<int> discountShopPurchasedIds;

		[Token(Token = "0x40065FC")]
		[FieldOffset(Offset = "0x78")]
		[JsonProperty("dsvc")]
		public int discountShopVisitCount;

		[Token(Token = "0x40065FD")]
		[FieldOffset(Offset = "0x7C")]
		[JsonProperty("prbb")]
		public bool pendingRuinsBanditBattle;

		[Token(Token = "0x40065FE")]
		[FieldOffset(Offset = "0x80")]
		[JsonProperty("prbbr")]
		public string pendingRuinsBanditBaseRewardRaw;

		[Token(Token = "0x40065FF")]
		[FieldOffset(Offset = "0x88")]
		[JsonProperty("prbcr")]
		public string pendingRuinsBanditClaimRewardRaw;

		[Token(Token = "0x4006600")]
		[FieldOffset(Offset = "0x90")]
		[JsonProperty("prbrpo")]
		public bool pendingRuinsBanditRuinsPanelOpen;

		[Token(Token = "0x4006601")]
		[FieldOffset(Offset = "0x98")]
		[JsonProperty("d")]
		public string dailyTaskDateKey;

		[Token(Token = "0x4006602")]
		[FieldOffset(Offset = "0xA0")]
		[JsonProperty("r")]
		public List<MysteryAdventureDailyTaskRecord> dailyTaskRecords;

		[Token(Token = "0x17000F2E")]
		public bool HasPendingRuinsBanditClaimReward
		{
			[Token(Token = "0x6005908")]
			[Address(RVA = "0x43681DC", Offset = "0x43641DC", VA = "0x43681DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000F2F")]
		public bool HasDailyTaskData
		{
			[Token(Token = "0x6005909")]
			[Address(RVA = "0x43681FC", Offset = "0x43641FC", VA = "0x43681FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600590A")]
		[Address(RVA = "0x4368230", Offset = "0x4364230", VA = "0x4368230")]
		public bool IsTotalDiceRewardClaimed(int configId)
		{
			return default;
		}

		[Token(Token = "0x600590B")]
		[Address(RVA = "0x4368290", Offset = "0x4364290", VA = "0x4368290")]
		public void MarkTotalDiceRewardClaimed(int configId)
		{
		}

		[Token(Token = "0x600590C")]
		[Address(RVA = "0x43683A8", Offset = "0x43643A8", VA = "0x43683A8")]
		public bool IsLapRewardLevelClaimed(int lapLevel)
		{
			return default;
		}

		[Token(Token = "0x600590D")]
		[Address(RVA = "0x4368408", Offset = "0x4364408", VA = "0x4368408")]
		public void MarkLapRewardLevelClaimed(int lapLevel)
		{
		}

		[Token(Token = "0x600590E")]
		[Address(RVA = "0x4368528", Offset = "0x4364528", VA = "0x4368528")]
		public void ClearLapRewardProgress()
		{
		}

		[Token(Token = "0x600590F")]
		[Address(RVA = "0x4368578", Offset = "0x4364578", VA = "0x4368578")]
		public void ClearAll()
		{
		}

		[Token(Token = "0x6005910")]
		[Address(RVA = "0x4368758", Offset = "0x4364758", VA = "0x4368758")]
		public void ResetForNewActivity(DateTime startTime, DateTime endTime, int initialDiceCount)
		{
		}

		[Token(Token = "0x6005911")]
		[Address(RVA = "0x4368618", Offset = "0x4364618", VA = "0x4368618")]
		public void ClearDailyGiftProgress()
		{
		}

		[Token(Token = "0x6005912")]
		[Address(RVA = "0x43686E8", Offset = "0x43646E8", VA = "0x43686E8")]
		public void ClearDailyTaskProgress()
		{
		}

		[Token(Token = "0x6005913")]
		[Address(RVA = "0x4368674", Offset = "0x4364674", VA = "0x4368674")]
		public void ClearDiscountShopSession()
		{
		}

		[Token(Token = "0x6005914")]
		[Address(RVA = "0x43686D8", Offset = "0x43646D8", VA = "0x43686D8")]
		public void ClearRuinsBanditBattleProgress()
		{
		}

		[Token(Token = "0x6005915")]
		[Address(RVA = "0x43687FC", Offset = "0x43647FC", VA = "0x43687FC")]
		public void ClearRuinsBanditInterruptedProgress()
		{
		}

		[Token(Token = "0x6005916")]
		[Address(RVA = "0x436880C", Offset = "0x436480C", VA = "0x436880C")]
		public bool IsDiscountShopItemPurchased(int configId)
		{
			return default;
		}

		[Token(Token = "0x6005917")]
		[Address(RVA = "0x436886C", Offset = "0x436486C", VA = "0x436886C")]
		public void MarkDiscountShopItemPurchased(int configId)
		{
		}

		[Token(Token = "0x6005918")]
		[Address(RVA = "0x4368984", Offset = "0x4364984", VA = "0x4368984")]
		public int GetDailyGiftPurchaseCount(int configId)
		{
			return default;
		}

		[Token(Token = "0x6005919")]
		[Address(RVA = "0x43689F8", Offset = "0x43649F8", VA = "0x43689F8")]
		public void SetDailyGiftPurchaseCount(int configId, int count)
		{
		}

		[Token(Token = "0x600591A")]
		[Address(RVA = "0x4368AA8", Offset = "0x4364AA8", VA = "0x4368AA8")]
		public void AddDailyGiftPurchaseCount(int configId)
		{
		}

		[Token(Token = "0x600591B")]
		[Address(RVA = "0x4368AD4", Offset = "0x4364AD4", VA = "0x4368AD4")]
		public PlayerMysteryAdventureData()
		{
		}
	}
}
