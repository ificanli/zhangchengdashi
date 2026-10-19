using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EF0")]
	public class GoldCardWeeklyGiftPackData
	{
		[Token(Token = "0x40067C3")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("id")]
		public string IAP_id;

		[Token(Token = "0x40067C4")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("ip")]
		public bool IsPurchase;

		[Token(Token = "0x6005A25")]
		[Address(RVA = "0x437A3A8", Offset = "0x43763A8", VA = "0x437A3A8")]
		public void Clear()
		{
		}

		[Token(Token = "0x6005A26")]
		[Address(RVA = "0x437A3B0", Offset = "0x43763B0", VA = "0x437A3B0")]
		public GoldCardWeeklyGiftPackData()
		{
		}
	}
}
