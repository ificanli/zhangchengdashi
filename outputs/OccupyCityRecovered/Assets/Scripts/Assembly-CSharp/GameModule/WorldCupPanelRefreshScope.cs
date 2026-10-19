using System;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x20005F6")]
	[Flags]
	public enum WorldCupPanelRefreshScope
	{
		[Token(Token = "0x4003206")]
		None = 0,
		[Token(Token = "0x4003207")]
		Resources = 1,
		[Token(Token = "0x4003208")]
		Countdown = 2,
		[Token(Token = "0x4003209")]
		SideEntries = 4,
		[Token(Token = "0x400320A")]
		DailyPanels = 8,
		[Token(Token = "0x400320B")]
		ShootUi = 0x10,
		[Token(Token = "0x400320C")]
		Full = -1
	}
}
