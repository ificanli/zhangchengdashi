using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EDC")]
	public class UserBoxData : UserAssetData
	{
		[Token(Token = "0x4006717")]
		[FieldOffset(Offset = "0x70")]
		[JsonProperty("aid")]
		public string arenaID;

		[Token(Token = "0x4006718")]
		[FieldOffset(Offset = "0x78")]
		[JsonProperty("bid")]
		public int boxID;

		[Token(Token = "0x4006719")]
		[FieldOffset(Offset = "0x80")]
		[JsonProperty("uk")]
		public string UnlockKey;

		[Token(Token = "0x400671A")]
		[FieldOffset(Offset = "0x88")]
		[JsonProperty("iui")]
		public bool isUnlockIng;

		[Token(Token = "0x400671B")]
		[FieldOffset(Offset = "0x89")]
		[JsonProperty("iue")]
		public bool isUnlockEd;

		[Token(Token = "0x400671C")]
		[FieldOffset(Offset = "0x8C")]
		[JsonProperty("crc")]
		public int coinRewardCount;

		[Token(Token = "0x400671D")]
		[FieldOffset(Offset = "0x90")]
		[JsonProperty("carc")]
		public int cardRewardCount;

		[Token(Token = "0x400671E")]
		[FieldOffset(Offset = "0x98")]
		[JsonProperty("brc")]
		public string boxRewardCofig;

		[Token(Token = "0x400671F")]
		[FieldOffset(Offset = "0xA0")]
		[JsonProperty("wa")]
		public bool watchAD;

		[Token(Token = "0x4006720")]
		[FieldOffset(Offset = "0xA1")]
		[JsonProperty("ctfg")]
		public bool chestTutorialFreeGet;

		[Token(Token = "0x4006721")]
		[FieldOffset(Offset = "0xA8")]
		private GlobalBoxInfo _globalBoxInfo;

		[Token(Token = "0x60059DC")]
		[Address(RVA = "0x43770DC", Offset = "0x43730DC", VA = "0x43770DC")]
		public void SetBoxId(string _boxId)
		{
		}

		[Token(Token = "0x60059DD")]
		[Address(RVA = "0x4377178", Offset = "0x4373178", VA = "0x4377178")]
		public UserBoxData()
		{
		}

		[Token(Token = "0x60059DE")]
		[Address(RVA = "0x4377180", Offset = "0x4373180", VA = "0x4377180")]
		public UserBoxData(GlobalAssetInfo assetInfo)
		{
		}

		[Token(Token = "0x60059DF")]
		[Address(RVA = "0x43771EC", Offset = "0x43731EC", VA = "0x43771EC")]
		public new GlobalBoxInfo GetInfo()
		{
			return null;
		}
	}
}
