using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.StyledGUI
{
	[Token(Token = "0x2000DF4")]
	public class StyledMask : PropertyAttribute
	{
		[Token(Token = "0x40061A5")]
		[FieldOffset(Offset = "0x10")]
		public string display;

		[Token(Token = "0x40061A6")]
		[FieldOffset(Offset = "0x18")]
		public string file;

		[Token(Token = "0x40061A7")]
		[FieldOffset(Offset = "0x20")]
		public string options;

		[Token(Token = "0x40061A8")]
		[FieldOffset(Offset = "0x28")]
		public int top;

		[Token(Token = "0x40061A9")]
		[FieldOffset(Offset = "0x2C")]
		public int down;

		[Token(Token = "0x600565E")]
		[Address(RVA = "0x433C3F4", Offset = "0x43383F4", VA = "0x433C3F4")]
		public StyledMask(string file, string options, int top, int down)
		{
		}

		[Token(Token = "0x600565F")]
		[Address(RVA = "0x433C474", Offset = "0x4338474", VA = "0x433C474")]
		public StyledMask(string display, string file, string options, int top, int down)
		{
		}
	}
}
