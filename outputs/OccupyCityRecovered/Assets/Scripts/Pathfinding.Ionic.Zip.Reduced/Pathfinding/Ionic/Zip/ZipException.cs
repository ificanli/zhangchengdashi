using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000014")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00006")]
	public class ZipException : Exception
	{
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x78395A8", Offset = "0x78355A8", VA = "0x78395A8")]
		public ZipException()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x7839604", Offset = "0x7835604", VA = "0x7839604")]
		public ZipException(string message)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x7839670", Offset = "0x7835670", VA = "0x7839670")]
		public ZipException(string message, Exception innerException)
		{
		}
	}
}
