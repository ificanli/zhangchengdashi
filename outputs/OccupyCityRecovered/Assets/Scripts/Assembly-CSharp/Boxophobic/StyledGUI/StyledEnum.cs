using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.StyledGUI
{
	[Token(Token = "0x2000DF0")]
	public class StyledEnum : PropertyAttribute
	{
		[Token(Token = "0x400619E")]
		[FieldOffset(Offset = "0x10")]
		public string display;

		[Token(Token = "0x400619F")]
		[FieldOffset(Offset = "0x18")]
		public string file;

		[Token(Token = "0x40061A0")]
		[FieldOffset(Offset = "0x20")]
		public string options;

		[Token(Token = "0x40061A1")]
		[FieldOffset(Offset = "0x28")]
		public int top;

		[Token(Token = "0x40061A2")]
		[FieldOffset(Offset = "0x2C")]
		public int down;

		[Token(Token = "0x6005658")]
		[Address(RVA = "0x433C200", Offset = "0x4338200", VA = "0x433C200")]
		public StyledEnum(string file, string options, int top, int down)
		{
		}

		[Token(Token = "0x6005659")]
		[Address(RVA = "0x433C280", Offset = "0x4338280", VA = "0x433C280")]
		public StyledEnum(string display, string file, string options, int top, int down)
		{
		}
	}
}
