using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200000E")]
public class LoginFailUI : MonoBehaviour
{
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x0")]
	public static LoginFailUI I;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x20")]
	public GameObject loginFailUI;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x28")]
	public Button continueBtn;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x30")]
	public Button restartBtn;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x38")]
	private Action continueAction;

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x3CFF918", Offset = "0x3CFB918", VA = "0x3CFF918")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x3CFFA20", Offset = "0x3CFBA20", VA = "0x3CFFA20")]
	public void Show(Action continueAction)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x3CFFA48", Offset = "0x3CFBA48", VA = "0x3CFFA48")]
	public void ReStart()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x3CFFA9C", Offset = "0x3CFBA9C", VA = "0x3CFFA9C")]
	public void Continue()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x3CFFAB8", Offset = "0x3CFBAB8", VA = "0x3CFFAB8")]
	public LoginFailUI()
	{
	}
}
