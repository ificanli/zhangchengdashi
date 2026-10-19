using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace L_Tools.Localization
{
	[Token(Token = "0x2000FC0")]
	[RequireComponent(typeof(TMP_Text))]
	[DisallowMultipleComponent]
	public class DBTTMPLangText : MonoBehaviour
	{
		[Token(Token = "0x4006BB1")]
		[FieldOffset(Offset = "0x20")]
		public string sourceText;

		[NonSerialized]
		[Token(Token = "0x4006BB2")]
		[FieldOffset(Offset = "0x28")]
		private string transText;

		[Token(Token = "0x4006BB3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TMP_Text textmeshPro;

		[Token(Token = "0x6005E4C")]
		[Address(RVA = "0x43FB954", Offset = "0x43F7954", VA = "0x43FB954")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005E4D")]
		[Address(RVA = "0x43FBA98", Offset = "0x43F7A98", VA = "0x43FBA98")]
		private void Start()
		{
		}

		[Token(Token = "0x6005E4E")]
		[Address(RVA = "0x43FBC64", Offset = "0x43F7C64", VA = "0x43FBC64")]
		public DBTTMPLangText()
		{
		}
	}
}
