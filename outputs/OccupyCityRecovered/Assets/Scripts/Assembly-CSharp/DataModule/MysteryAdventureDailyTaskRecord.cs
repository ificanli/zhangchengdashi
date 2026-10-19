using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EA9")]
	public class MysteryAdventureDailyTaskRecord
	{
		[Token(Token = "0x40065EA")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("id")]
		public int ConfigId;

		[Token(Token = "0x40065EB")]
		[FieldOffset(Offset = "0x14")]
		[JsonProperty("p")]
		public int Progress;

		[Token(Token = "0x40065EC")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("c")]
		public bool Claimed;

		[Token(Token = "0x6005907")]
		[Address(RVA = "0x43681D4", Offset = "0x43641D4", VA = "0x43681D4")]
		public MysteryAdventureDailyTaskRecord()
		{
		}
	}
}
