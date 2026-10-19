using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.StyledGUI
{
	[Token(Token = "0x2000DF3")]
	public class StyledLayers : PropertyAttribute
	{
		[Token(Token = "0x40061A4")]
		[FieldOffset(Offset = "0x10")]
		public string display;

		[Token(Token = "0x600565C")]
		[Address(RVA = "0x433C340", Offset = "0x4338340", VA = "0x433C340")]
		public StyledLayers()
		{
		}

		[Token(Token = "0x600565D")]
		[Address(RVA = "0x433C390", Offset = "0x4338390", VA = "0x433C390")]
		public StyledLayers(string display)
		{
		}
	}
}
