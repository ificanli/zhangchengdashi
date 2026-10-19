using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000013")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00007")]
	public class BadStateException : ZipException
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x78396FC", Offset = "0x78356FC", VA = "0x78396FC")]
		public BadStateException()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x7839700", Offset = "0x7835700", VA = "0x7839700")]
		public BadStateException(string message)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x7839704", Offset = "0x7835704", VA = "0x7839704")]
		public BadStateException(string message, Exception innerException)
		{
		}
	}
}
