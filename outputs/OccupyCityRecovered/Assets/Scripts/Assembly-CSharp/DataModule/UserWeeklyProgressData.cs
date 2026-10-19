using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EF3")]
	public class UserWeeklyProgressData
	{
		[Token(Token = "0x40067D0")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("cal")]
		public int currentActivityLevel;

		[Token(Token = "0x40067D1")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("cmrs")]
		public List<int> claimedMilestoneRewards;

		[Token(Token = "0x6005A2A")]
		[Address(RVA = "0x437A49C", Offset = "0x437649C", VA = "0x437A49C")]
		public UserWeeklyProgressData()
		{
		}

		[Token(Token = "0x6005A2B")]
		[Address(RVA = "0x437A520", Offset = "0x4376520", VA = "0x437A520")]
		public void Clear()
		{
		}
	}
}
