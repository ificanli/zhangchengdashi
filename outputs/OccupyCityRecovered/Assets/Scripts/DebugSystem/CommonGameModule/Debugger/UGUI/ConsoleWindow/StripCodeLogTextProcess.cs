using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace CommonGameModule.Debugger.UGUI.ConsoleWindow
{
	[Token(Token = "0x200009D")]
	public class StripCodeLogTextProcess : ILogTextProcess
	{
		[Token(Token = "0x40002AA")]
		private const string JsonError = "constructor not found for type";

		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] _stripCodeLog;

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x46940D8", Offset = "0x46900D8", VA = "0x46940D8")]
		[Preserve]
		public StripCodeLogTextProcess()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x46940E0", Offset = "0x46900E0", VA = "0x46940E0", Slot = "4")]
		public void Process(ConsoleWindowUGUI.Log log)
		{
		}
	}
}
