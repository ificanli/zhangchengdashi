using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DataModule
{
	[Token(Token = "0x2000E1E")]
	public class SaveDataPanel : MonoBehaviour
	{
		[Token(Token = "0x4006280")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI resourceText;

		[Token(Token = "0x4006281")]
		[FieldOffset(Offset = "0x28")]
		public GameObject isLoadingObj;

		[Token(Token = "0x4006282")]
		[FieldOffset(Offset = "0x30")]
		public Button choiceBtn;

		[Token(Token = "0x60056FF")]
		[Address(RVA = "0x4349244", Offset = "0x4345244", VA = "0x4349244")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005700")]
		[Address(RVA = "0x43492CC", Offset = "0x43452CC", VA = "0x43492CC")]
		public void InitData(CompareResult compareResult, bool islocal, Action OnChoice)
		{
		}

		[Token(Token = "0x6005701")]
		[Address(RVA = "0x434967C", Offset = "0x434567C", VA = "0x434967C")]
		public SaveDataPanel()
		{
		}
	}
}
