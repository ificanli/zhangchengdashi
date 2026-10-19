using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.StyledGUI
{
	[Token(Token = "0x2000DF6")]
	public class StyledRangeOptions : PropertyAttribute
	{
		[Token(Token = "0x40061AE")]
		[FieldOffset(Offset = "0x10")]
		public string display;

		[Token(Token = "0x40061AF")]
		[FieldOffset(Offset = "0x18")]
		public float min;

		[Token(Token = "0x40061B0")]
		[FieldOffset(Offset = "0x1C")]
		public float max;

		[Token(Token = "0x40061B1")]
		[FieldOffset(Offset = "0x20")]
		public string[] options;

		[Token(Token = "0x6005662")]
		[Address(RVA = "0x433C574", Offset = "0x4338574", VA = "0x433C574")]
		public StyledRangeOptions(string display, float min, float max, string[] options)
		{
		}
	}
}
