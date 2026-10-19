using System;
using System.Collections.Generic;
using GameModule;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EF2")]
	public class UserWeeklyActivityData
	{
		[Token(Token = "0x40067C9")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("dts")]
		public List<UserWeekDailyTaskData> dailyTasks;

		[Token(Token = "0x40067CA")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("wp")]
		public UserWeeklyProgressData weeklyProgress;

		[Token(Token = "0x40067CB")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("ula")]
		public bool unLockActivity;

		[Token(Token = "0x40067CC")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("aut")]
		public DateTime activityUnlockTime;

		[Token(Token = "0x40067CD")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("lct")]
		public DateTime lastCycleTime;

		[Token(Token = "0x40067CE")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("cct")]
		public WeeklyCardActivityManager.CycleCardType cycleCardType;

		[Token(Token = "0x40067CF")]
		[FieldOffset(Offset = "0x3C")]
		public int weeklyCompleteTaskCount;

		[Token(Token = "0x6005A29")]
		[Address(RVA = "0x437A3F4", Offset = "0x43763F4", VA = "0x437A3F4")]
		public UserWeeklyActivityData()
		{
		}
	}
}
