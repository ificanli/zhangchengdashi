using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	[Token(Token = "0x2000011")]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00009")]
	public class BadCrcException : ZipException
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x78396EC", Offset = "0x78356EC", VA = "0x78396EC")]
		public BadCrcException()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x78396F0", Offset = "0x78356F0", VA = "0x78396F0")]
		public BadCrcException(string message)
		{
		}
	}
}
