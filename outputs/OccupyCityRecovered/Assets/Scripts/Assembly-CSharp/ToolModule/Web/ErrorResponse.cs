using System;
using Il2CppDummyDll;

namespace ToolModule.Web
{
	[Serializable]
	[Token(Token = "0x20001B6")]
	public class ErrorResponse
	{
		[Token(Token = "0x4001B07")]
		[FieldOffset(Offset = "0x10")]
		public string error;

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x407BFE8", Offset = "0x4077FE8", VA = "0x407BFE8")]
		public ErrorResponse()
		{
		}
	}
}
