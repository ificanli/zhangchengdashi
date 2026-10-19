using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20000B9")]
public class FamilyNameBehaviour : MonoBehaviour
{
	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject playerNameBG;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject familyNameBG;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshPro familyText;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UnityEvent familyInfoBtn;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string familyName;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool player;

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x3E34A98", Offset = "0x3E30A98", VA = "0x3E34A98")]
	public void ReStartTMP()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x3E34AD0", Offset = "0x3E30AD0", VA = "0x3E34AD0")]
	private void UpdateLanguage(object o)
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x3E34BA0", Offset = "0x3E30BA0", VA = "0x3E34BA0")]
	public void Awake()
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x3E34CF8", Offset = "0x3E30CF8", VA = "0x3E34CF8")]
	public void Init(string _familyName, bool _player = false)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x3E34E10", Offset = "0x3E30E10", VA = "0x3E34E10")]
	private void UpdatePlayerName([Optional] object o)
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x3E34EA4", Offset = "0x3E30EA4", VA = "0x3E34EA4")]
	public void OnFamilyInfoClick()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x3E34F48", Offset = "0x3E30F48", VA = "0x3E34F48")]
	public FamilyNameBehaviour()
	{
	}
}
