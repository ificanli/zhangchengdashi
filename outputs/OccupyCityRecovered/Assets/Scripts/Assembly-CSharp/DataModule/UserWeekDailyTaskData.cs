using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EF1")]
	public class UserWeekDailyTaskData
	{
		[Token(Token = "0x40067C5")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("id")]
		public string taskID;

		[Token(Token = "0x40067C6")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("cp")]
		public int currentProgress;

		[Token(Token = "0x40067C7")]
		[FieldOffset(Offset = "0x1C")]
		[JsonProperty("ic")]
		public bool isCompleted;

		[Token(Token = "0x40067C8")]
		[FieldOffset(Offset = "0x1D")]
		[JsonProperty("icl")]
		public bool isClaimed;

		[Token(Token = "0x6005A27")]
		[Address(RVA = "0x437A3B8", Offset = "0x43763B8", VA = "0x437A3B8")]
		public UserWeekDailyTaskData(string taskId)
		{
		}

		[Token(Token = "0x6005A28")]
		[Address(RVA = "0x437A3E8", Offset = "0x43763E8", VA = "0x437A3E8")]
		public void Clear()
		{
		}
	}
}
