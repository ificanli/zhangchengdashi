using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EEF")]
	public class RankItemData
	{
		[Token(Token = "0x40067BF")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("ip")]
		public string iconPath;

		[Token(Token = "0x40067C0")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("n")]
		public string name;

		[Token(Token = "0x40067C1")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("tn")]
		public int trophyNum;

		[Token(Token = "0x40067C2")]
		[FieldOffset(Offset = "0x24")]
		[JsonProperty("ipr")]
		public bool isPlayer;

		[Token(Token = "0x6005A23")]
		[Address(RVA = "0x437A1A8", Offset = "0x43761A8", VA = "0x437A1A8")]
		public RankItemData()
		{
		}

		[Token(Token = "0x6005A24")]
		[Address(RVA = "0x437A1B0", Offset = "0x43761B0", VA = "0x437A1B0")]
		public RankItemData(int DanNum, bool isPlayer, string playerName)
		{
		}
	}
}
