using Il2CppDummyDll;

namespace GameFramework.Debugger
{
	[Token(Token = "0x20004AE")]
	public interface IDebuggerWindowGroup : IDebuggerWindow
	{
		[Token(Token = "0x1700121E")]
		int DebuggerWindowCount
		{
			[Token(Token = "0x600702B")]
			get;
		}

		[Token(Token = "0x1700121F")]
		int SelectedIndex
		{
			[Token(Token = "0x600702C")]
			get;
			[Token(Token = "0x600702D")]
			set;
		}

		[Token(Token = "0x17001220")]
		IDebuggerWindow SelectedWindow
		{
			[Token(Token = "0x600702E")]
			get;
		}

		[Token(Token = "0x600702F")]
		string[] GetDebuggerWindowNames();

		[Token(Token = "0x6007030")]
		IDebuggerWindow GetDebuggerWindow(string P_0084c_007DÀ_00A3);

		[Token(Token = "0x6007031")]
		void RegisterDebuggerWindow(string P_0084c_007DÀ_00A3, IDebuggerWindow _008AB_0097xQ_00BB);
	}
}
