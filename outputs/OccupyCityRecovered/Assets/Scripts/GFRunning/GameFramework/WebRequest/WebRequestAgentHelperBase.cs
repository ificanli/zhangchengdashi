using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameFramework.WebRequest
{
	[Token(Token = "0x2000440")]
	public abstract class WebRequestAgentHelperBase : MonoBehaviour, IWebRequestAgentHelper
	{
		[Token(Token = "0x14000019")]
		public abstract event EventHandler<WebRequestAgentHelperCompleteEventArgs> WebRequestAgentHelperComplete;

		[Token(Token = "0x1400001A")]
		public abstract event EventHandler<WebRequestAgentHelperErrorEventArgs> WebRequestAgentHelperError;

		[Token(Token = "0x60068AB")]
		[Address(RVA = "0x726ECF8", Offset = "0x726ACF8", VA = "0x726ECF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60068B0")]
		public abstract void Request(string _008E_00B0_008Au_007D_009C, Dictionary<string, string> _0096H_008AWAH);

		[Token(Token = "0x60068B1")]
		public abstract void Request(string _008E_00B0_008Au_007D_009C, byte[] _008E_00A2_0090_008EP_009C, Dictionary<string, string> _0096H_008AWAH);

		[Token(Token = "0x60068B2")]
		public abstract void Reset();

		[Token(Token = "0x60068B3")]
		public abstract void Shutdown();

		[Token(Token = "0x60068B4")]
		[Address(RVA = "0x726ED50", Offset = "0x726AD50", VA = "0x726ED50")]
		protected WebRequestAgentHelperBase()
		{
		}
	}
}
