using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EA2")]
	public class FundItem
	{
		[Token(Token = "0x40065D6")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("hb")]
		public bool hadBuy;

		[Token(Token = "0x40065D7")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("k")]
		public string key;

		[Token(Token = "0x40065D8")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("hcl")]
		public List<int> hadClaimLevel;

		[Token(Token = "0x60058E7")]
		[Address(RVA = "0x4367530", Offset = "0x4363530", VA = "0x4367530")]
		public FundItem()
		{
		}

		[Token(Token = "0x60058E8")]
		[Address(RVA = "0x4366DAC", Offset = "0x4362DAC", VA = "0x4366DAC")]
		public FundItem(string key)
		{
		}

		[Token(Token = "0x60058E9")]
		[Address(RVA = "0x43675D0", Offset = "0x43635D0", VA = "0x43675D0")]
		public bool CanClaim(int level)
		{
			return default;
		}
	}
}
