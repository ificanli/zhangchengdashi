using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000036")]
public class FeedUI : MonoBehaviour
{
	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x0")]
	public static FeedUI Instance;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PopUI;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x28")]
	public Button CloseBtn;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x30")]
	public Button ClickBtn;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI ClickText;

	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x40")]
	public GameObject TipImg;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x48")]
	public GameObject TipText1;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x50")]
	public GameObject TipText2;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x58")]
	public Button BGMask;

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x3D0613C", Offset = "0x3D0213C", VA = "0x3D0613C")]
	public void Awake()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x3D061F4", Offset = "0x3D021F4", VA = "0x3D061F4")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x3D05308", Offset = "0x3D01308", VA = "0x3D05308")]
	public void SwitchTip_Box(bool isShow)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x3D054A0", Offset = "0x3D014A0", VA = "0x3D054A0")]
	public void SwitchTip_offline(bool isShow)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x3D05784", Offset = "0x3D01784", VA = "0x3D05784")]
	public void ShowPop()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x3D06274", Offset = "0x3D02274", VA = "0x3D06274")]
	public FeedUI()
	{
	}
}
