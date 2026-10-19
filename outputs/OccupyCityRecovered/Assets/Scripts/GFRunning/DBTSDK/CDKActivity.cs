using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001EF")]
	public class CDKActivity
	{
		[Token(Token = "0x40006C7")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40006C8")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x60019D1")]
		[Address(RVA = "0x70AC7CC", Offset = "0x70A87CC", VA = "0x70AC7CC")]
		public CDKActivity()
		{
		}
	}
}
