using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E16")]
	public class CompareAnalysis
	{
		[Token(Token = "0x4006236")]
		[FieldOffset(Offset = "0x10")]
		public int[] ExpLevelList;

		[Token(Token = "0x4006237")]
		[FieldOffset(Offset = "0x18")]
		public int[] SummonLevelList;

		[Token(Token = "0x4006238")]
		[FieldOffset(Offset = "0x20")]
		public string userID;

		[Token(Token = "0x4006239")]
		[FieldOffset(Offset = "0x28")]
		public long Level;

		[Token(Token = "0x400623A")]
		[FieldOffset(Offset = "0x30")]
		public long Exp;

		[Token(Token = "0x400623B")]
		[FieldOffset(Offset = "0x38")]
		public long gold;

		[Token(Token = "0x400623C")]
		[FieldOffset(Offset = "0x40")]
		public long diamond;

		[Token(Token = "0x400623D")]
		[FieldOffset(Offset = "0x48")]
		public long wood;

		[Token(Token = "0x400623E")]
		[FieldOffset(Offset = "0x50")]
		public long crystal;

		[Token(Token = "0x400623F")]
		[FieldOffset(Offset = "0x58")]
		public int payCount;

		[Token(Token = "0x4006240")]
		[FieldOffset(Offset = "0x60")]
		public long goldGet;

		[Token(Token = "0x4006241")]
		[FieldOffset(Offset = "0x68")]
		public long goldUse;

		[Token(Token = "0x4006242")]
		[FieldOffset(Offset = "0x70")]
		public long diamondGet;

		[Token(Token = "0x4006243")]
		[FieldOffset(Offset = "0x78")]
		public long diamondUse;

		[Token(Token = "0x4006244")]
		[FieldOffset(Offset = "0x80")]
		public long woodGet;

		[Token(Token = "0x4006245")]
		[FieldOffset(Offset = "0x88")]
		public long woodUse;

		[Token(Token = "0x4006246")]
		[FieldOffset(Offset = "0x90")]
		public long crystalGet;

		[Token(Token = "0x4006247")]
		[FieldOffset(Offset = "0x98")]
		public long crystalUse;

		[Token(Token = "0x4006248")]
		[FieldOffset(Offset = "0xA0")]
		public int highestArena;

		[Token(Token = "0x4006249")]
		[FieldOffset(Offset = "0xA4")]
		public int wonTrophyCount;

		[Token(Token = "0x400624A")]
		[FieldOffset(Offset = "0xA8")]
		public int danNum;

		[Token(Token = "0x400624B")]
		[FieldOffset(Offset = "0xB0")]
		public List<compareCardInfo> cardInfo;

		[Token(Token = "0x400624C")]
		[FieldOffset(Offset = "0xB8")]
		public string lastExitGameTime;

		[Token(Token = "0x400624D")]
		[FieldOffset(Offset = "0xC0")]
		public DateTime lastExitGameTimeDT;

		[Token(Token = "0x400624E")]
		[FieldOffset(Offset = "0xC8")]
		public DateTime lastLingdiRewardTime;

		[Token(Token = "0x400624F")]
		[FieldOffset(Offset = "0xD0")]
		public string monthCardStatus;

		[Token(Token = "0x4006250")]
		[FieldOffset(Offset = "0xD8")]
		public DateTime MonthPassPurchaseTime;

		[Token(Token = "0x4006251")]
		[FieldOffset(Offset = "0xE0")]
		public DateTime MonthCardExpireTime;

		[Token(Token = "0x4006252")]
		[FieldOffset(Offset = "0xE8")]
		public List<compareArtifactInfo> artifactInfo;

		[Token(Token = "0x4006253")]
		[FieldOffset(Offset = "0xF0")]
		public int artifactLevel;

		[Token(Token = "0x4006254")]
		[FieldOffset(Offset = "0xF4")]
		public int SummonExp;

		[Token(Token = "0x60056D8")]
		[Address(RVA = "0x4341428", Offset = "0x433D428", VA = "0x4341428")]
		public CompareAnalysis(CompareData compareData)
		{
		}

		[Token(Token = "0x60056D9")]
		[Address(RVA = "0x4342704", Offset = "0x433E704", VA = "0x4342704")]
		public string GetArenaName(int danID)
		{
			return null;
		}
	}
}
