using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameModule
{
	[Serializable]
	[Token(Token = "0x20005C6")]
	public class SubGameChaosTrailsSaveData
	{
		[Token(Token = "0x4003113")]
		[FieldOffset(Offset = "0x10")]
		public string lastRefreshOpenCycleKey;

		[Token(Token = "0x4003114")]
		[FieldOffset(Offset = "0x18")]
		public int usedRefreshCount;

		[Token(Token = "0x4003115")]
		[FieldOffset(Offset = "0x1C")]
		public int usedDiamondRefreshCount;

		[Token(Token = "0x4003116")]
		[FieldOffset(Offset = "0x20")]
		public int dailyBaseRewardPlayCount;

		[Token(Token = "0x4003117")]
		[FieldOffset(Offset = "0x28")]
		public List<int> currentBuffIds;

		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0x3EF0A3C", Offset = "0x3EECA3C", VA = "0x3EF0A3C")]
		public SubGameChaosTrailsSaveData()
		{
		}
	}
}
