using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EBA")]
	public class PlayerAdData : ServerBaseData
	{
		[Token(Token = "0x4006638")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("wdgpac")]
		public int WatchDailyGiftPackAdCount;

		[Token(Token = "0x4006639")]
		[FieldOffset(Offset = "0x14")]
		[JsonIgnore]
		public int MaxWatchDailyGiftPackAdCount;

		[Token(Token = "0x400663A")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("wcac")]
		public int WatchCoinAdCount;

		[Token(Token = "0x400663B")]
		[FieldOffset(Offset = "0x1C")]
		[JsonProperty("wwac")]
		public int WatchWoodAdCount;

		[Token(Token = "0x400663C")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("wsac")]
		public int WatchStoneAdCount;

		[Token(Token = "0x400663D")]
		[FieldOffset(Offset = "0x24")]
		[JsonProperty("wcrac")]
		public int WatchCrystalAdCount;

		[Token(Token = "0x400663E")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("srappc")]
		public int showRemoveAdPassPanelCount;

		[Token(Token = "0x400663F")]
		[FieldOffset(Offset = "0x2C")]
		[JsonProperty("sie")]
		public bool ShowInterstitialEd;

		[Token(Token = "0x4006640")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("rvmppd")]
		public string LastDayFirstRvMonthPassPop;

		[Token(Token = "0x6005951")]
		[Address(RVA = "0x436BB0C", Offset = "0x4367B0C", VA = "0x436BB0C", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005952")]
		[Address(RVA = "0x436BBAC", Offset = "0x4367BAC", VA = "0x436BBAC", Slot = "5")]
		public override void InitFromDefaults()
		{
		}

		[Token(Token = "0x6005953")]
		[Address(RVA = "0x436BBD4", Offset = "0x4367BD4", VA = "0x436BBD4")]
		public void InitializeVideosNumber()
		{
		}

		[Token(Token = "0x6005954")]
		[Address(RVA = "0x436BBE8", Offset = "0x4367BE8", VA = "0x436BBE8")]
		public PlayerAdData()
		{
		}
	}
}
