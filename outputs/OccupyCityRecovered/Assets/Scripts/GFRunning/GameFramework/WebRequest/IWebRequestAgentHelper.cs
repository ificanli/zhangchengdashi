using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GameFramework.WebRequest
{
	[Token(Token = "0x200043E")]
	public interface IWebRequestAgentHelper
	{
		[Token(Token = "0x14000015")]
		event EventHandler<WebRequestAgentHelperCompleteEventArgs> WebRequestAgentHelperComplete;

		[Token(Token = "0x14000016")]
		event EventHandler<WebRequestAgentHelperErrorEventArgs> WebRequestAgentHelperError;

		[Token(Token = "0x600687C")]
		void Request(string _008E_00B0_008Au_007D_009C, Dictionary<string, string> _0096H_008AWAH);

		[Token(Token = "0x600687D")]
		void Request(string _008E_00B0_008Au_007D_009C, byte[] _008E_00A2_0090_008EP_009C, Dictionary<string, string> _0096H_008AWAH);

		[Token(Token = "0x600687E")]
		void Reset();

		[Token(Token = "0x600687F")]
		void Shutdown();
	}
}
