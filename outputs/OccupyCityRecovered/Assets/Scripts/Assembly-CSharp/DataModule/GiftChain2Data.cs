using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000E9D")]
	public class GiftChain2Data
	{
		[Token(Token = "0x40065CB")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("gcbid")]
		public Dictionary<string, int> giftChainBuyIdDic;

		[Token(Token = "0x40065CC")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("csc")]
		public int chainStartCount;

		[Token(Token = "0x60058DA")]
		[Address(RVA = "0x4366668", Offset = "0x4362668", VA = "0x4366668")]
		public GiftChain2Data()
		{
		}
	}
}
