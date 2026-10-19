using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DataModule
{
	[Serializable]
	[Token(Token = "0x2000EC6")]
	public class ChestSlotUnlockData
	{
		[Token(Token = "0x4006676")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, int> unlockStatus;

		[Token(Token = "0x6005991")]
		[Address(RVA = "0x4371974", Offset = "0x436D974", VA = "0x4371974")]
		public ChestSlotUnlockData()
		{
		}
	}
}
