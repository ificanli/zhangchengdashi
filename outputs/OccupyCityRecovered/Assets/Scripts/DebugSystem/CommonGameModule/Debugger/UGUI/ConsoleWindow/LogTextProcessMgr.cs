using System.Collections.Generic;
using Il2CppDummyDll;

namespace CommonGameModule.Debugger.UGUI.ConsoleWindow
{
	[Token(Token = "0x200009A")]
	public class LogTextProcessMgr : ILogTextProcess
	{
		[Token(Token = "0x40002A4")]
		[FieldOffset(Offset = "0x0")]
		private static LogTextProcessMgr _instance;

		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<ILogTextProcess> _logTextProcesses;

		[Token(Token = "0x1700009D")]
		public static LogTextProcessMgr Instance
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x46936A4", Offset = "0x468F6A4", VA = "0x46936A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x469370C", Offset = "0x468F70C", VA = "0x469370C")]
		private LogTextProcessMgr()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x4693EE4", Offset = "0x468FEE4", VA = "0x4693EE4", Slot = "4")]
		public void Process(ConsoleWindowUGUI.Log log)
		{
		}
	}
}
