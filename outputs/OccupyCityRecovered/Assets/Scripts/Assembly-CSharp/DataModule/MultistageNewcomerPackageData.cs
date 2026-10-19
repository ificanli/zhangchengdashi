using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EA6")]
	public class MultistageNewcomerPackageData
	{
		[Token(Token = "0x40065DF")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("id")]
		public string IAP_id;

		[Token(Token = "0x40065E0")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("ip")]
		public bool IsPurchase;

		[Token(Token = "0x40065E1")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("pt")]
		public DateTime PurchaseTime;

		[Token(Token = "0x40065E2")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("igr1")]
		public bool IsGetReward_Level1;

		[Token(Token = "0x40065E3")]
		[FieldOffset(Offset = "0x29")]
		[JsonProperty("igr2")]
		public bool IsGetReward_Level2;

		[Token(Token = "0x40065E4")]
		[FieldOffset(Offset = "0x2A")]
		[JsonProperty("igr3")]
		public bool IsGetReward_Level3;

		[Token(Token = "0x40065E5")]
		[FieldOffset(Offset = "0x30")]
		public DateTime AppearTime;

		[Token(Token = "0x60058F2")]
		[Address(RVA = "0x436797C", Offset = "0x436397C", VA = "0x436797C")]
		public bool IsExpiredInV1()
		{
			return default;
		}

		[Token(Token = "0x60058F3")]
		[Address(RVA = "0x4367AA0", Offset = "0x4363AA0", VA = "0x4367AA0")]
		public TimeSpan GetRemainingTimeSpanInV1()
		{
			return default;
		}

		[Token(Token = "0x60058F4")]
		[Address(RVA = "0x4367C00", Offset = "0x4363C00", VA = "0x4367C00")]
		public string GetFormattedRemainingTimeInV1(int timeSpanFormatUnit = 4)
		{
			return null;
		}

		[Token(Token = "0x60058F5")]
		[Address(RVA = "0x4367C1C", Offset = "0x4363C1C", VA = "0x4367C1C")]
		public int GetAfterSeveralDays()
		{
			return default;
		}

		[Token(Token = "0x60058F6")]
		[Address(RVA = "0x4367D80", Offset = "0x4363D80", VA = "0x4367D80")]
		public MultistageNewcomerPackageData()
		{
		}
	}
}
