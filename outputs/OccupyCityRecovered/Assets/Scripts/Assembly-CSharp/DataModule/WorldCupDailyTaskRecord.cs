using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EF5")]
	public class WorldCupDailyTaskRecord
	{
		[Token(Token = "0x40067DC")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("id")]
		public int SourceId;

		[Token(Token = "0x40067DD")]
		[FieldOffset(Offset = "0x14")]
		[JsonProperty("p")]
		public int Progress;

		[Token(Token = "0x40067DE")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("cl")]
		public bool Claimed;

		[Token(Token = "0x6005A36")]
		[Address(RVA = "0x438FC28", Offset = "0x438BC28", VA = "0x438FC28")]
		public WorldCupDailyTaskRecord()
		{
		}
	}
}
