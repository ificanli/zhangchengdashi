using System;
using Il2CppDummyDll;

namespace ToolModule.Web
{
	[Token(Token = "0x20001B5")]
	public class HeadResponse
	{
		[Token(Token = "0x4001B02")]
		[FieldOffset(Offset = "0x10")]
		public bool success;

		[Token(Token = "0x4001B03")]
		[FieldOffset(Offset = "0x18")]
		public long status;

		[Token(Token = "0x4001B04")]
		[FieldOffset(Offset = "0x20")]
		public DateTime last_edit;

		[Token(Token = "0x4001B05")]
		[FieldOffset(Offset = "0x28")]
		public int size;

		[Token(Token = "0x4001B06")]
		[FieldOffset(Offset = "0x30")]
		public string content_type;

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x407BFE0", Offset = "0x4077FE0", VA = "0x407BFE0")]
		public HeadResponse()
		{
		}
	}
}
