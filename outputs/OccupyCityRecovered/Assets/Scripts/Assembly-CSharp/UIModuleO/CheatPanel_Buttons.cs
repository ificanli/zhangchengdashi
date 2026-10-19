using System;
using Il2CppDummyDll;

namespace UIModuleO
{
	[Token(Token = "0x20007CF")]
	public class CheatPanel_Buttons : CheatPanel_ButtonsComponents
	{
		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0x3FEAC2C", Offset = "0x3FE6C2C", VA = "0x3FEAC2C")]
		public void Init(string title)
		{
		}

		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x3FEAD20", Offset = "0x3FE6D20", VA = "0x3FEAD20")]
		public void AddToggle(string toggleTextOn, string toggleTextOff, Action<bool> onClick, int parent, bool initState)
		{
		}

		[Token(Token = "0x6002B4D")]
		[Address(RVA = "0x3FEAFFC", Offset = "0x3FE6FFC", VA = "0x3FEAFFC")]
		public void AddButton(string buttonText, Action onClick, int parent)
		{
		}

		[Token(Token = "0x6002B4E")]
		[Address(RVA = "0x3FEB29C", Offset = "0x3FE729C", VA = "0x3FEB29C")]
		public CheatPanel_Buttons()
		{
		}
	}
}
