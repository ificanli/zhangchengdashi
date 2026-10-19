using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.StyledGUI
{
	[Token(Token = "0x2000DF8")]
	public class StyledText : PropertyAttribute
	{
		[Token(Token = "0x40061B3")]
		[FieldOffset(Offset = "0x10")]
		public string text;

		[Token(Token = "0x40061B4")]
		[FieldOffset(Offset = "0x18")]
		public TextAnchor alignment;

		[Token(Token = "0x40061B5")]
		[FieldOffset(Offset = "0x1C")]
		public float top;

		[Token(Token = "0x40061B6")]
		[FieldOffset(Offset = "0x20")]
		public float down;

		[Token(Token = "0x6005664")]
		[Address(RVA = "0x433C5E0", Offset = "0x43385E0", VA = "0x433C5E0")]
		public StyledText()
		{
		}

		[Token(Token = "0x6005665")]
		[Address(RVA = "0x433C638", Offset = "0x4338638", VA = "0x433C638")]
		public StyledText(TextAnchor alignment)
		{
		}

		[Token(Token = "0x6005666")]
		[Address(RVA = "0x433C6A4", Offset = "0x43386A4", VA = "0x433C6A4")]
		public StyledText(TextAnchor alignment, float top, float down)
		{
		}
	}
}
