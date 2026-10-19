using System;
using Il2CppDummyDll;

namespace GameModule
{
	[Serializable]
	[Token(Token = "0x20002FE")]
	internal class SpecialSummonDailyLimitData
	{
		[Token(Token = "0x40022F6")]
		[FieldOffset(Offset = "0x10")]
		public string dateKey;

		[Token(Token = "0x40022F7")]
		[FieldOffset(Offset = "0x18")]
		public int usedTimes;

		[Token(Token = "0x6000D61")]
		[Address(RVA = "0x3D5C264", Offset = "0x3D58264", VA = "0x3D5C264")]
		public SpecialSummonDailyLimitData()
		{
		}
	}
}
