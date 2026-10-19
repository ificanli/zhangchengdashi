using System;
using Il2CppDummyDll;

namespace Voodoo.Sauce.IAP
{
	[Token(Token = "0x2000F7D")]
	public class ConfirmationPopupConfig
	{
		[Token(Token = "0x4006A9E")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		[Token(Token = "0x4006A9F")]
		[FieldOffset(Offset = "0x18")]
		public string message;

		[Token(Token = "0x4006AA0")]
		[FieldOffset(Offset = "0x20")]
		public Action cancelCallback;

		[Token(Token = "0x4006AA1")]
		[FieldOffset(Offset = "0x28")]
		public Action confirmCallback;

		[Token(Token = "0x4006AA2")]
		[FieldOffset(Offset = "0x30")]
		public Action altCallback;

		[Token(Token = "0x6005CD0")]
		[Address(RVA = "0x43B3720", Offset = "0x43AF720", VA = "0x43B3720")]
		public ConfirmationPopupConfig()
		{
		}
	}
}
