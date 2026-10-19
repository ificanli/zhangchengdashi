using Il2CppDummyDll;

namespace DataModule
{
	[Token(Token = "0x2000E6F")]
	public abstract class GlobalInfoBase
	{
		[Token(Token = "0x40064AF")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x600587E")]
		[Address(RVA = "0x4350D00", Offset = "0x434CD00", VA = "0x4350D00")]
		protected GlobalInfoBase()
		{
		}
	}
}
