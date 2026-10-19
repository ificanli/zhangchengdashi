using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.Tools
{
	[Serializable]
	[Token(Token = "0x200002C")]
	public class MyLayout
	{
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x10")]
		public bool isVertical;

		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x18")]
		public Padding padding;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x20")]
		public float spacing;

		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 prefabSize;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x2C")]
		public bool setRootSize;

		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform root;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x463C404", Offset = "0x4638404", VA = "0x463C404")]
		public void Refresh(RectTransform root)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x463C40C", Offset = "0x463840C", VA = "0x463C40C")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x463C830", Offset = "0x4638830", VA = "0x463C830")]
		public MyLayout()
		{
		}
	}
}
