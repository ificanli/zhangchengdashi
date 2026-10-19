using System;
using Il2CppDummyDll;

namespace GameModule
{
	[Token(Token = "0x200052F")]
	[Flags]
	public enum MysteryAdventurePanelRefreshScope
	{
		[Token(Token = "0x4002E8C")]
		None = 0,
		[Token(Token = "0x4002E8D")]
		DiceUi = 1,
		[Token(Token = "0x4002E8E")]
		TotalDiceTrack = 2,
		[Token(Token = "0x4002E8F")]
		LapProgress = 4,
		[Token(Token = "0x4002E90")]
		Board = 8,
		[Token(Token = "0x4002E91")]
		SideEntries = 0x10,
		[Token(Token = "0x4002E92")]
		DailyPanels = 0x20,
		[Token(Token = "0x4002E93")]
		RollControls = 0x40,
		[Token(Token = "0x4002E94")]
		Status = 0x80,
		[Token(Token = "0x4002E95")]
		RollImmediate = DiceUi | RollControls,
		[Token(Token = "0x4002E96")]
		AfterRoll = RollImmediate | TotalDiceTrack | LapProgress | Board | Status,
		[Token(Token = "0x4002E97")]
		AfterRollComplete = AfterRoll | SideEntries | DailyPanels,
		[Token(Token = "0x4002E98")]
		AutoRollStep = 0x41,
		[Token(Token = "0x4002E99")]
		Full = AfterRollComplete
	}
}
