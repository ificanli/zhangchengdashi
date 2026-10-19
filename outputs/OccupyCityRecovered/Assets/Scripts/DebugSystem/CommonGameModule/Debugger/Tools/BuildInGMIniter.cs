using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger.Tools
{
	[Token(Token = "0x2000018")]
	public static class BuildInGMIniter
	{
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x0")]
		private static List<IBuildInGM> m_BuildInGMList;

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4636DCC", Offset = "0x4632DCC", VA = "0x4636DCC")]
		public static void RegisterGM()
		{
		}
	}
}
