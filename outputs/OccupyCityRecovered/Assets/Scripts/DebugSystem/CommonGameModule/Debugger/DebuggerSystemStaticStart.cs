using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x200000A")]
	[DefaultExecutionOrder(-999)]
	public static class DebuggerSystemStaticStart
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4630750", Offset = "0x462C750", VA = "0x4630750")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		private static void RegisteCustomInit()
		{
		}
	}
}
