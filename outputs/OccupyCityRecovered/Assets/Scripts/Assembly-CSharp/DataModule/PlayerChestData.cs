using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EC5")]
	public class PlayerChestData : ServerBaseData
	{
		[Token(Token = "0x400666E")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("ubd")]
		public List<UserBoxData> userBoxData;

		[Token(Token = "0x400666F")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("usobd")]
		public List<UserBoxData> userStayOpenBoxData;

		[Token(Token = "0x4006670")]
		[FieldOffset(Offset = "0x20")]
		public ChestSlotUnlockData chestSlotUnlockData;

		[Token(Token = "0x4006671")]
		[FieldOffset(Offset = "0x28")]
		public List<UserBoxData> userHasAllBoxdata;

		[Token(Token = "0x4006672")]
		[FieldOffset(Offset = "0x30")]
		public bool handleAToBBoxSlot;

		[Token(Token = "0x4006673")]
		[FieldOffset(Offset = "0x31")]
		public bool handleBToABoxSlot;

		[Token(Token = "0x4006674")]
		[FieldOffset(Offset = "0x34")]
		public int userGetBoxCount;

		[Token(Token = "0x4006675")]
		[FieldOffset(Offset = "0x38")]
		public bool handleBoxRewardCrystal;

		[Token(Token = "0x600598C")]
		[Address(RVA = "0x43710A4", Offset = "0x436D0A4", VA = "0x43710A4")]
		public int GetChestOpenTime()
		{
			return default;
		}

		[Token(Token = "0x600598D")]
		[Address(RVA = "0x437110C", Offset = "0x436D10C", VA = "0x437110C")]
		public void OpenChestTime()
		{
		}

		[Token(Token = "0x600598E")]
		[Address(RVA = "0x4371188", Offset = "0x436D188", VA = "0x4371188", Slot = "5")]
		public override void InitFromDefaults()
		{
		}

		[Token(Token = "0x600598F")]
		[Address(RVA = "0x4371190", Offset = "0x436D190", VA = "0x4371190", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005990")]
		[Address(RVA = "0x43719F0", Offset = "0x436D9F0", VA = "0x43719F0")]
		public PlayerChestData()
		{
		}
	}
}
