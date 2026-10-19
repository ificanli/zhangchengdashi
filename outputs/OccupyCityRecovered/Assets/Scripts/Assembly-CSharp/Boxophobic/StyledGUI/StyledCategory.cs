using Il2CppDummyDll;
using UnityEngine;

namespace Boxophobic.StyledGUI
{
	[Token(Token = "0x2000DEF")]
	public class StyledCategory : PropertyAttribute
	{
		[Token(Token = "0x400619A")]
		[FieldOffset(Offset = "0x10")]
		public string category;

		[Token(Token = "0x400619B")]
		[FieldOffset(Offset = "0x18")]
		public float top;

		[Token(Token = "0x400619C")]
		[FieldOffset(Offset = "0x1C")]
		public float down;

		[Token(Token = "0x400619D")]
		[FieldOffset(Offset = "0x20")]
		public bool colapsable;

		[Token(Token = "0x6005654")]
		[Address(RVA = "0x433C108", Offset = "0x4338108", VA = "0x433C108")]
		public StyledCategory(string category)
		{
		}

		[Token(Token = "0x6005655")]
		[Address(RVA = "0x433C13C", Offset = "0x433813C", VA = "0x433C13C")]
		public StyledCategory(string category, bool colapsable)
		{
		}

		[Token(Token = "0x6005656")]
		[Address(RVA = "0x433C174", Offset = "0x4338174", VA = "0x433C174")]
		public StyledCategory(string category, float top, float down)
		{
		}

		[Token(Token = "0x6005657")]
		[Address(RVA = "0x433C1B4", Offset = "0x43381B4", VA = "0x433C1B4")]
		public StyledCategory(string category, int top, int down, bool colapsable)
		{
		}
	}
}
