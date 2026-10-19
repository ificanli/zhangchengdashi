using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace CommonGameModule.Login
{
	[Token(Token = "0x2000FE6")]
	public class LoginOutUI : MonoBehaviour
	{
		[Token(Token = "0x4006C58")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, GameObject> objectList;

		[Token(Token = "0x4006C59")]
		[FieldOffset(Offset = "0x28")]
		private GameObject m_LogoutProtocolPanel;

		[Token(Token = "0x4006C5A")]
		[FieldOffset(Offset = "0x30")]
		private GameObject m_ConfirmPanel1;

		[Token(Token = "0x4006C5B")]
		[FieldOffset(Offset = "0x38")]
		private GameObject m_ConfirmPanel2;

		[Token(Token = "0x4006C5C")]
		[FieldOffset(Offset = "0x40")]
		private GameObject loadingUI;

		[Token(Token = "0x4006C5D")]
		[FieldOffset(Offset = "0x48")]
		private GameObject m_LogoutSuc;

		[Token(Token = "0x4006C5E")]
		[FieldOffset(Offset = "0x50")]
		private GameObject m_LogoutFail;

		[Token(Token = "0x4006C5F")]
		[FieldOffset(Offset = "0x58")]
		private GameObject m_TipsgGroup;

		[Token(Token = "0x4006C60")]
		[FieldOffset(Offset = "0x60")]
		private Toggle m_ToggleChoise;

		[Token(Token = "0x4006C61")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_LogoutTimer;

		[Token(Token = "0x4006C62")]
		[FieldOffset(Offset = "0x70")]
		private Text m_LogoutTimerText;

		[Token(Token = "0x4006C63")]
		[FieldOffset(Offset = "0x78")]
		private GameObject m_BtnLogout;

		[Token(Token = "0x4006C64")]
		[FieldOffset(Offset = "0x80")]
		private bool m_IsStarTimer;

		[Token(Token = "0x4006C65")]
		[FieldOffset(Offset = "0x84")]
		private float m_Timer;

		[Token(Token = "0x4006C66")]
		[FieldOffset(Offset = "0x88")]
		private bool m_TimerOver;

		[Token(Token = "0x4006C67")]
		[FieldOffset(Offset = "0x90")]
		private Action RequestLoginOut;

		[Token(Token = "0x6005F09")]
		[Address(RVA = "0x44005D4", Offset = "0x43FC5D4", VA = "0x44005D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005F0A")]
		[Address(RVA = "0x4401410", Offset = "0x43FD410", VA = "0x4401410")]
		private void Start()
		{
		}

		[Token(Token = "0x6005F0B")]
		[Address(RVA = "0x4401530", Offset = "0x43FD530", VA = "0x4401530")]
		private void QuitGame()
		{
		}

		[Token(Token = "0x6005F0C")]
		[Address(RVA = "0x44015A8", Offset = "0x43FD5A8", VA = "0x44015A8")]
		private void LoginOut()
		{
		}

		[Token(Token = "0x6005F0D")]
		[Address(RVA = "0x4401620", Offset = "0x43FD620", VA = "0x4401620")]
		private void ShowConfirmPanel1()
		{
		}

		[Token(Token = "0x6005F0E")]
		[Address(RVA = "0x4401718", Offset = "0x43FD718", VA = "0x4401718")]
		private void ShowConfirmPanel2()
		{
		}

		[Token(Token = "0x6005F0F")]
		[Address(RVA = "0x4401720", Offset = "0x43FD720", VA = "0x4401720")]
		private void ToggleChoiseChange(bool i)
		{
		}

		[Token(Token = "0x6005F10")]
		[Address(RVA = "0x4401798", Offset = "0x43FD798", VA = "0x4401798")]
		private void Close()
		{
		}

		[Token(Token = "0x6005F11")]
		[Address(RVA = "0x44017BC", Offset = "0x43FD7BC", VA = "0x44017BC")]
		public void Show(Action action)
		{
		}

		[Token(Token = "0x6005F12")]
		[Address(RVA = "0x440183C", Offset = "0x43FD83C", VA = "0x440183C")]
		public void LoginOutComplete(bool IsSuccess)
		{
		}

		[Token(Token = "0x6005F13")]
		[Address(RVA = "0x4401724", Offset = "0x43FD724", VA = "0x4401724")]
		private void CheckLoginOut()
		{
		}

		[Token(Token = "0x6005F14")]
		[Address(RVA = "0x4401628", Offset = "0x43FD628", VA = "0x4401628")]
		private void ShowPanel(int index)
		{
		}

		[Token(Token = "0x6005F15")]
		[Address(RVA = "0x4401880", Offset = "0x43FD880", VA = "0x4401880")]
		private void Update()
		{
		}

		[Token(Token = "0x6005F16")]
		[Address(RVA = "0x44012DC", Offset = "0x43FD2DC", VA = "0x44012DC")]
		private GameObject GetGameObject(Dictionary<string, GameObject> objectList, string name)
		{
			return null;
		}

		[Token(Token = "0x6005F17")]
		private T GetComponen<T>(Dictionary<string, GameObject> objectList, string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6005F18")]
		[Address(RVA = "0x44019F0", Offset = "0x43FD9F0", VA = "0x44019F0")]
		public LoginOutUI()
		{
		}
	}
}
