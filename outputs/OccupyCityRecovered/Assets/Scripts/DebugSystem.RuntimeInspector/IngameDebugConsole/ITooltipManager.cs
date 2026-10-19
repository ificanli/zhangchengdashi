using Il2CppDummyDll;
using UnityEngine;

namespace IngameDebugConsole
{
	[Token(Token = "0x2000070")]
	public interface ITooltipManager
	{
		[Token(Token = "0x170000BE")]
		UISkin Skin
		{
			[Token(Token = "0x60003C5")]
			get;
		}

		[Token(Token = "0x170000BF")]
		Canvas Canvas
		{
			[Token(Token = "0x60003C6")]
			get;
		}

		[Token(Token = "0x170000C0")]
		float TooltipDelay
		{
			[Token(Token = "0x60003C7")]
			get;
		}
	}
}
