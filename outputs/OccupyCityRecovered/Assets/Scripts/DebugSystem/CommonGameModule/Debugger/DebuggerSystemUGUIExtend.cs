using System;
using System.Runtime.InteropServices;
using CommonGameModule.Debugger.UGUI.GMWindow;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger
{
	[Token(Token = "0x200000D")]
	public static class DebuggerSystemUGUIExtend
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x462F6EC", Offset = "0x462B6EC", VA = "0x462F6EC")]
		public static void AddFunction(this DebuggerSystemUGUI debuggerSystemUGUI, string functionName, Action<string> functionCallBack, [Optional] string[] tags)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4633ED8", Offset = "0x462FED8", VA = "0x4633ED8")]
		public static void AddFunction(this DebuggerSystemUGUI debuggerSystemUGUI, string functionName, bool defaulutIsOn, Action<bool> functionCallBack, [Optional] string[] tags)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4633F58", Offset = "0x462FF58", VA = "0x4633F58")]
		public static void AddFunction(this DebuggerSystemUGUI debuggerSystemUGUI, IGMWindowItem item)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4633FB0", Offset = "0x462FFB0", VA = "0x4633FB0")]
		public static void RemoveFunctionByName(this DebuggerSystemUGUI debuggerSystemUGUI, string functionName)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4634008", Offset = "0x4630008", VA = "0x4634008")]
		public static void RemoveFunctionByCallback(this DebuggerSystemUGUI debuggerSystemUGUI, Action<string> functionCallBack)
		{
		}

		[Token(Token = "0x600004A")]
		public static void RemoveFunctionByCallback<T>(this DebuggerSystemUGUI debuggerSystemUGUI, Action<T> functionCallBack)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x462F784", Offset = "0x462B784", VA = "0x462F784")]
		public static void RenameFunction(this DebuggerSystemUGUI debuggerSystemUGUI, string functionName, Action<string> functionCallBack)
		{
		}

		[Token(Token = "0x600004C")]
		public static void RenameFunction<T>(this DebuggerSystemUGUI debuggerSystemUGUI, string functionName, Action<T> functionCallBack)
		{
		}
	}
}
