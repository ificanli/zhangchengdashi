using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EDF")]
	public class UserDailyShopCardData
	{
		[Token(Token = "0x4006725")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("cid")]
		public string cardId;

		[Token(Token = "0x4006726")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("rl")]
		public int rareLevel;

		[Token(Token = "0x4006727")]
		[FieldOffset(Offset = "0x1C")]
		[JsonProperty("p")]
		public int price;

		[Token(Token = "0x4006728")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("c")]
		public int count;

		[Token(Token = "0x4006729")]
		[FieldOffset(Offset = "0x24")]
		[JsonProperty("ib")]
		public bool isBuy;

		[Token(Token = "0x60059E5")]
		[Address(RVA = "0x4377384", Offset = "0x4373384", VA = "0x4377384")]
		public UserDailyShopCardData()
		{
		}
	}
}
