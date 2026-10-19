using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200003A")]
public class ProxyLoginMsgCanvas : MonoBehaviour
{
	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x0")]
	private static GameObject _cachedPrefab;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x8")]
	private static ProxyLoginMsgCanvas _instance;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x10")]
	private static bool _isCreating;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x20")]
	public Button btn_confirm;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x28")]
	public Button btn_cancel;

	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI txt_msg;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI txt_title;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x11")]
	public static bool isPlayer;

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x3D06460", Offset = "0x3D02460", VA = "0x3D06460")]
	private void Awake()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x3D0665C", Offset = "0x3D0265C", VA = "0x3D0665C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x3D06478", Offset = "0x3D02478", VA = "0x3D06478")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x3D06574", Offset = "0x3D02574", VA = "0x3D06574")]
	private void RegisterBtnEvent()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x3D06660", Offset = "0x3D02660", VA = "0x3D06660")]
	private void OnBtnConfirmClick()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x3D06664", Offset = "0x3D02664", VA = "0x3D06664")]
	private void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x3D06688", Offset = "0x3D02688", VA = "0x3D06688")]
	public ProxyLoginMsgCanvas()
	{
	}
}
