using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.StyledGUI
{
	[Token(Token = "0x2000DEE")]
	public class StyledButton : PropertyAttribute
	{
		[Token(Token = "0x4006197")]
		[FieldOffset(Offset = "0x10")]
		public string Text;

		[Token(Token = "0x4006198")]
		[FieldOffset(Offset = "0x18")]
		public float Top;

		[Token(Token = "0x4006199")]
		[FieldOffset(Offset = "0x1C")]
		public float Down;

		[Token(Token = "0x6005652")]
		[Address(RVA = "0x433C02C", Offset = "0x433802C", VA = "0x433C02C")]
		public StyledButton(string Text)
		{
		}

		[Token(Token = "0x6005653")]
		[Address(RVA = "0x433C090", Offset = "0x4338090", VA = "0x433C090")]
		public StyledButton(string Text, float Top, float Down)
		{
		}
	}
}
