using System;
using Il2CppDummyDll;

namespace SDKModule
{
	[Serializable]
	[Token(Token = "0x200016F")]
	public class GameCenterClass
	{
		[Token(Token = "0x4001A45")]
		[FieldOffset(Offset = "0x10")]
		public int GameCenter = -1;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x3F7390C", Offset = "0x3F6F90C", VA = "0x3F7390C")]
		public GameCenterClass()
		{
		}
	}
}
