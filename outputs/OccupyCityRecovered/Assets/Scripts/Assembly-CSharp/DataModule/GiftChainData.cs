using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000E9E")]
	public class GiftChainData
	{
		[Token(Token = "0x40065CD")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("gcbid")]
		public Dictionary<string, int> giftChainBuyIdDic;

		[Token(Token = "0x60058DB")]
		[Address(RVA = "0x43666E4", Offset = "0x43626E4", VA = "0x43666E4")]
		public GiftChainData()
		{
		}
	}
}
