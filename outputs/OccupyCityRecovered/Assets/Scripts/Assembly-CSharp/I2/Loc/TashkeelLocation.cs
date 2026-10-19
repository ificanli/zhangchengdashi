using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000DC2")]
	internal class TashkeelLocation
	{
		[Token(Token = "0x40060C5")]
		[FieldOffset(Offset = "0x10")]
		public char tashkeel;

		[Token(Token = "0x40060C6")]
		[FieldOffset(Offset = "0x14")]
		public int position;

		[Token(Token = "0x600552F")]
		[Address(RVA = "0x432ECD4", Offset = "0x432ACD4", VA = "0x432ECD4")]
		public TashkeelLocation(char tashkeel, int position)
		{
		}
	}
}
