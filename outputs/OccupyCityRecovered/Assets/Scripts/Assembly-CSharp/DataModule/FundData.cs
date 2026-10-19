using System;
using System.Collections.Generic;
using GameModule;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000E9F")]
	public class FundData
	{
		[Token(Token = "0x40065CE")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("ft")]
		public FundManager.FundType fundType;

		[Token(Token = "0x40065CF")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("fi")]
		public List<FundItem> fundItem;

		[Token(Token = "0x40065D0")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, FundItem> _fundItemsDic;

		[Token(Token = "0x40065D1")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("ca")]
		public int currentActivity;

		[Token(Token = "0x40065D2")]
		[FieldOffset(Offset = "0x2C")]
		[JsonProperty("cl")]
		public int currentLevel;

		[Token(Token = "0x40065D3")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, object> extraData;

		[Token(Token = "0x60058DC")]
		[Address(RVA = "0x4366760", Offset = "0x4362760", VA = "0x4366760")]
		public FundData()
		{
		}

		[Token(Token = "0x60058DD")]
		[Address(RVA = "0x4366800", Offset = "0x4362800", VA = "0x4366800")]
		public FundData(FundManager.FundType fundType)
		{
		}

		[Token(Token = "0x60058DE")]
		[Address(RVA = "0x4366E68", Offset = "0x4362E68", VA = "0x4366E68")]
		public void Init()
		{
		}

		[Token(Token = "0x60058DF")]
		[Address(RVA = "0x43671C4", Offset = "0x43631C4", VA = "0x43671C4")]
		public FundItem GetFundItem(string key = "Free")
		{
			return null;
		}

		[Token(Token = "0x60058E0")]
		[Address(RVA = "0x436734C", Offset = "0x436334C", VA = "0x436734C")]
		public void SetExtraData(string key, object value)
		{
		}

		[Token(Token = "0x60058E1")]
		public T GetExtraData<T>(string key)
		{
    throw new global::System.NotImplementedException("RECOVERY_UNIMPLEMENTED FundData.GetExtraData RVA= Token=0x60058E1");
}
	}
}
