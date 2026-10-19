using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Debugger.UGUI
{
	[Token(Token = "0x2000063")]
	public class ToggleBtn
	{
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x10")]
		public readonly Button btn;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x18")]
		private Text _text;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x20")]
		private bool _isOn;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x28")]
		private Action<bool> _onValue;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x30")]
		private string _format;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x0")]
		private static Color _onColor;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x10")]
		private static Color _offColor;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x20")]
		private static List<ToggleBtn> _toggleBtnList;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x4681974", Offset = "0x467D974", VA = "0x4681974")]
		public ToggleBtn(Button btn, bool defaultValue, string textFormat, Action<bool> onValueChange)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x4681D58", Offset = "0x467DD58", VA = "0x4681D58")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x4681BAC", Offset = "0x467DBAC", VA = "0x4681BAC")]
		public void SetIsOn(bool isOn)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x4681C94", Offset = "0x467DC94", VA = "0x4681C94")]
		public void SetText(string text)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x468029C", Offset = "0x467C29C", VA = "0x468029C")]
		public static void SetColor(Color onColor, Color offColor)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x4680594", Offset = "0x467C594", VA = "0x4680594")]
		public static void Clear()
		{
		}
	}
}
