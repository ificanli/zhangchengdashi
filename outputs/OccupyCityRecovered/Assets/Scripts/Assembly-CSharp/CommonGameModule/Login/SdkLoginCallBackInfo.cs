using Beebyte.Obfuscator;
using Il2CppDummyDll;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FDC")]
	[Skip]
	public class SdkLoginCallBackInfo
	{
		[Token(Token = "0x4006C13")]
		[FieldOffset(Offset = "0x10")]
		public int Code;

		[Token(Token = "0x4006C14")]
		[FieldOffset(Offset = "0x18")]
		public string UserData;

		[Token(Token = "0x6005EF2")]
		[Address(RVA = "0x43FFDD8", Offset = "0x43FBDD8", VA = "0x43FFDD8")]
		public SdkLoginCallBackInfo()
		{
		}
	}
}
