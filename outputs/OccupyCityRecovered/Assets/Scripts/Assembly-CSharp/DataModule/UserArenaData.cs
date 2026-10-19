using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EDA")]
	public class UserArenaData
	{
		[Token(Token = "0x4006708")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("aid")]
		public string arenaID;

		[Token(Token = "0x4006709")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("tn")]
		public int trophyNum;

		[Token(Token = "0x400670A")]
		[FieldOffset(Offset = "0x1C")]
		[JsonProperty("igcr")]
		public bool isGetCompleteReward;

		[Token(Token = "0x400670B")]
		[FieldOffset(Offset = "0x1D")]
		[JsonProperty("iu")]
		public bool isUnLock;

		[Token(Token = "0x400670C")]
		[FieldOffset(Offset = "0x1E")]
		[JsonProperty("hf")]
		public bool hasFight;

		[Token(Token = "0x400670D")]
		[FieldOffset(Offset = "0x1F")]
		[JsonProperty("cpr")]
		public bool chaimProgressReward;

		[Token(Token = "0x400670E")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("cpri")]
		public string chaimProgressRewardId;

		[Token(Token = "0x60059D5")]
		[Address(RVA = "0x436BFDC", Offset = "0x4367FDC", VA = "0x436BFDC")]
		public UserArenaData()
		{
		}
	}
}
