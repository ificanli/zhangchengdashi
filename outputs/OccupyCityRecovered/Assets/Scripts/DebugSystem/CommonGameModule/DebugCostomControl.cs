using System;
using Il2CppDummyDll;

namespace CommonGameModule
{
	[Token(Token = "0x2000004")]
	public class DebugCostomControl
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x462F604", Offset = "0x462B604", VA = "0x462F604")]
		public static void AddFunction(string functionName, Action<string> functionCallBack)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x462F75C", Offset = "0x462B75C", VA = "0x462F75C")]
		public static void SetFunName(Action<string> func, string name)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x462F800", Offset = "0x462B800", VA = "0x462F800")]
		public DebugCostomControl()
		{
		}
	}
}
