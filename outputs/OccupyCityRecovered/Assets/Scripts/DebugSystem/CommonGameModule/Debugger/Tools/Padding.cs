using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.Tools
{
	[Serializable]
	[Token(Token = "0x200002D")]
	public class Padding
	{
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x10")]
		public int top;

		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x14")]
		public int bottom;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x18")]
		public int left;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x1C")]
		public int right;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x463C844", Offset = "0x4638844", VA = "0x463C844")]
		public Padding(RectOffset rectOffset)
		{
		}
	}
}
