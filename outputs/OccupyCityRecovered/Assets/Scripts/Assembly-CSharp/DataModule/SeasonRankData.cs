using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EAE")]
	public class SeasonRankData
	{
		[Token(Token = "0x4006609")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("pn")]
		public string playerName;

		[Token(Token = "0x400660A")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("s")]
		public int score;

		[Token(Token = "0x400660B")]
		[FieldOffset(Offset = "0x1C")]
		[JsonProperty("r")]
		public int rank;

		[Token(Token = "0x600591F")]
		[Address(RVA = "0x4368D68", Offset = "0x4364D68", VA = "0x4368D68")]
		public SeasonRankData()
		{
		}
	}
}
