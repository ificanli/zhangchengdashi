using System;
using System.Collections.Generic;
using GameModule;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DataModule
{
	[Token(Token = "0x2000EE6")]
	public class UserLableData
	{
		[Token(Token = "0x400675F")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("rwr")]
		public float RecentWinRate;

		[Token(Token = "0x4006760")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("n2gs")]
		public List<int> near20GameSituation;

		[Token(Token = "0x4006761")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("cws")]
		public int CurrentWinStreak;

		[Token(Token = "0x4006762")]
		[FieldOffset(Offset = "0x24")]
		[JsonProperty("cls")]
		public int CurrentLoseStreak;

		[Token(Token = "0x4006763")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("hp")]
		public bool HasPaid;

		[Token(Token = "0x4006764")]
		[FieldOffset(Offset = "0x29")]
		[JsonProperty("hwa")]
		public bool HasWatchedAd;

		[Token(Token = "0x4006765")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("llt")]
		public DateTime LastLoginTime;

		[Token(Token = "0x4006766")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("iugb")]
		public int InactiveUserGameBuff;

		[Token(Token = "0x4006767")]
		[FieldOffset(Offset = "0x3C")]
		[JsonProperty("jnp")]
		public bool JustNowPaid;

		[Token(Token = "0x4006768")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("jnpgb")]
		public int JustNowPaidGameBuff;

		[Token(Token = "0x4006769")]
		[FieldOffset(Offset = "0x44")]
		[JsonProperty("ifmt")]
		public bool IsFirstMatchToday;

		[Token(Token = "0x400676A")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("ual")]
		public List<UserLableManager.UserLable> UserAllLables;

		[Token(Token = "0x400676B")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<UserLableManager.UserLable, int> UserCategoryLevelDict;

		[Token(Token = "0x60059FB")]
		[Address(RVA = "0x4378390", Offset = "0x4374390", VA = "0x4378390")]
		public UserLableData()
		{
		}
	}
}
