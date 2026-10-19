using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.StyledGUI
{
	[Token(Token = "0x2000DF5")]
	public class StyledMessage : PropertyAttribute
	{
		[Token(Token = "0x40061AA")]
		[FieldOffset(Offset = "0x10")]
		public string Type;

		[Token(Token = "0x40061AB")]
		[FieldOffset(Offset = "0x18")]
		public string Message;

		[Token(Token = "0x40061AC")]
		[FieldOffset(Offset = "0x20")]
		public float Top;

		[Token(Token = "0x40061AD")]
		[FieldOffset(Offset = "0x24")]
		public float Down;

		[Token(Token = "0x6005660")]
		[Address(RVA = "0x433C504", Offset = "0x4338504", VA = "0x433C504")]
		public StyledMessage(string Type, string Message)
		{
		}

		[Token(Token = "0x6005661")]
		[Address(RVA = "0x433C534", Offset = "0x4338534", VA = "0x433C534")]
		public StyledMessage(string Type, string Message, float Top, float Down)
		{
		}
	}
}
