using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EA4")]
	public class IAPRecord
	{
		[Token(Token = "0x40065DB")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("pid")]
		public string productId;

		[Token(Token = "0x40065DC")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("prs")]
		public List<SinglePurchaseRecord> purchaseRecords;

		[Token(Token = "0x17000F2B")]
		[JsonIgnore]
		public int PurchaseCount
		{
			[Token(Token = "0x60058EB")]
			[Address(RVA = "0x4367644", Offset = "0x4363644", VA = "0x4367644")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60058EC")]
		[Address(RVA = "0x4367690", Offset = "0x4363690", VA = "0x4367690")]
		public void AddPurchase(DateTime purchaseTime, string version)
		{
		}

		[Token(Token = "0x60058ED")]
		[Address(RVA = "0x43678A0", Offset = "0x43638A0", VA = "0x43678A0")]
		public SinglePurchaseRecord GetLastPurchaseTime()
		{
			return null;
		}

		[Token(Token = "0x60058EE")]
		[Address(RVA = "0x43678F8", Offset = "0x43638F8", VA = "0x43678F8")]
		public IAPRecord()
		{
		}
	}
}
