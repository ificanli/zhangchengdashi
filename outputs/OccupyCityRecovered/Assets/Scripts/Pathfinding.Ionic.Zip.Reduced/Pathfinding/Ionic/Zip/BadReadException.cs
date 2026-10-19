using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000010")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000A")]
	public class BadReadException : ZipException
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x78396E0", Offset = "0x78356E0", VA = "0x78396E0")]
		public BadReadException()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x78396E4", Offset = "0x78356E4", VA = "0x78396E4")]
		public BadReadException(string message)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x78396E8", Offset = "0x78356E8", VA = "0x78396E8")]
		public BadReadException(string message, Exception innerException)
		{
		}
	}
}
