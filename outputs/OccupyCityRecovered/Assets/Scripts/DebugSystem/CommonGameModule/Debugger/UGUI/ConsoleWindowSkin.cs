using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CommonGameModule.Debugger.UGUI
{
	[Serializable]
	[Token(Token = "0x2000090")]
	public class ConsoleWindowSkin
	{
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x10")]
		[Header("文本显示区域的背景颜色")]
		public Color bgColor;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x20")]
		[Header("文本颜色")]
		public Color textColor;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x30")]
		[Header("文本的底板颜色")]
		public Color textBgColor1;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x40")]
		public Color textBgColor2;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x50")]
		public Color textBgColorSelected;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x60")]
		[Header("Log，warning，error的文本左侧圆点颜色")]
		public Color logIconColor;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x70")]
		public Color warningIconColor;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x80")]
		public Color errorIconColor;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x4692380", Offset = "0x468E380", VA = "0x4692380")]
		public ConsoleWindowSkin()
		{
		}
	}
}
