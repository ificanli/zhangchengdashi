using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace L_Tools.Localization
{
	[Token(Token = "0x2000FC1")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Text))]
	public class DBTUGUILangText : MonoBehaviour
	{
		[Token(Token = "0x4006BB4")]
		[FieldOffset(Offset = "0x20")]
		public string sourceText;

		[NonSerialized]
		[Token(Token = "0x4006BB5")]
		[FieldOffset(Offset = "0x28")]
		public string transText;

		[Token(Token = "0x4006BB6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text textmeshPro;

		[Token(Token = "0x6005E4F")]
		[Address(RVA = "0x43FBC6C", Offset = "0x43F7C6C", VA = "0x43FBC6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005E50")]
		[Address(RVA = "0x43FBDB0", Offset = "0x43F7DB0", VA = "0x43FBDB0")]
		public DBTUGUILangText()
		{
		}
	}
}
