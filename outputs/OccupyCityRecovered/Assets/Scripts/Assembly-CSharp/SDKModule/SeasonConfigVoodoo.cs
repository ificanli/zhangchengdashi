using System;
using Il2CppDummyDll;

namespace SDKModule
{
	[Serializable]
	[Token(Token = "0x2000175")]
	public class SeasonConfigVoodoo
	{
		[Token(Token = "0x4001A4F")]
		[FieldOffset(Offset = "0x10")]
		public string Season1StartTime;

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x3F73964", Offset = "0x3F6F964", VA = "0x3F73964")]
		public DateTime GetSeason1StartTime()
		{
			return default;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x3F73AF0", Offset = "0x3F6FAF0", VA = "0x3F73AF0")]
		public SeasonConfigVoodoo()
		{
		}
	}
}
