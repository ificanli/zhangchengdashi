using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace CommonGameModule.Debugger.UGUI.ConsoleWindow
{
	[Token(Token = "0x200009C")]
	public class ReportLogTextProcess : ILogTextProcess
	{
		[Token(Token = "0x40002A8")]
		private const string TargetTag = "[Report:]";

		[Token(Token = "0x40002A9")]
		private const string TargetError = "上报不合规";

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x469402C", Offset = "0x469002C", VA = "0x469402C")]
		[Preserve]
		public ReportLogTextProcess()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x4694034", Offset = "0x4690034", VA = "0x4694034", Slot = "4")]
		public void Process(ConsoleWindowUGUI.Log log)
		{
		}
	}
}
