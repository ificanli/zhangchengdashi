using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x200000F")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000B")]
	public class BadPasswordException : ZipException
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x78395A4", Offset = "0x78355A4", VA = "0x78395A4")]
		public BadPasswordException()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x7839600", Offset = "0x7835600", VA = "0x7839600")]
		public BadPasswordException(string message)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x783966C", Offset = "0x783566C", VA = "0x783966C")]
		public BadPasswordException(string message, Exception innerException)
		{
		}
	}
}
