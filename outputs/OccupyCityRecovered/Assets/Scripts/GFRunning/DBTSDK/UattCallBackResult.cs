using Il2CppDummyDll;

namespace DBTSDK
{
	[Token(Token = "0x20001DB")]
	public class UattCallBackResult
	{
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x10")]
		public int code;

		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x18")]
		public string value;

		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x70A2E98", Offset = "0x709EE98", VA = "0x70A2E98")]
		public UattCallBackResult()
		{
		}
	}
}
