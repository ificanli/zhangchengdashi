using System;
using Il2CppDummyDll;

namespace GameModule
{
	[Serializable]
	[Token(Token = "0x20002FD")]
	internal class NormalSummonDailyLimitData
	{
		[Token(Token = "0x40022F4")]
		[FieldOffset(Offset = "0x10")]
		public string dateKey;

		[Token(Token = "0x40022F5")]
		[FieldOffset(Offset = "0x18")]
		public int usedTimes;

		[Token(Token = "0x6000D60")]
		[Address(RVA = "0x3D5C20C", Offset = "0x3D5820C", VA = "0x3D5C20C")]
		public NormalSummonDailyLimitData()
		{
		}
	}
}
