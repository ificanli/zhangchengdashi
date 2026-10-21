using System;
using Il2CppDummyDll;

namespace SDKModule
{
	[Serializable]
	[Token(Token = "0x2000156")]
	public class WeeklyCardEventClass
	{
		[Token(Token = "0x4001A2C")]
		[FieldOffset(Offset = "0x10")]
		public int WeeklyCardEvent = -1;

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x3F7377C", Offset = "0x3F6F77C", VA = "0x3F7377C")]
		public WeeklyCardEventClass()
		{
		}
	}
}
