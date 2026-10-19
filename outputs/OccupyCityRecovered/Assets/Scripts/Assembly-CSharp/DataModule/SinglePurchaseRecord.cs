using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EA3")]
	public class SinglePurchaseRecord
	{
		[Token(Token = "0x40065D9")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("pt")]
		public DateTime purchaseTime;

		[Token(Token = "0x40065DA")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("pv")]
		public string purchaseVersion;

		[Token(Token = "0x60058EA")]
		[Address(RVA = "0x436763C", Offset = "0x436363C", VA = "0x436763C")]
		public SinglePurchaseRecord()
		{
		}
	}
}
