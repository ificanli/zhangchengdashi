using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200003D")]
public class QRCodeObj : MonoBehaviour
{
	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string _borrowConfirmTicket;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string _borrowConfirmOpenId;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Texture2D qrCodeTexture;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private QRCodeState _currentState;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool _isDestroy;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button btn_Copy;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Button btn_refresh;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject loadingObj;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject loginsuc;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RawImage img_qrcode;

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x3D066BC", Offset = "0x3D026BC", VA = "0x3D066BC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x3D0680C", Offset = "0x3D0280C", VA = "0x3D0680C")]
	private void RegisterBtnEvent()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x3D068F4", Offset = "0x3D028F4", VA = "0x3D068F4")]
	public void ODestroy()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x3D06808", Offset = "0x3D02808", VA = "0x3D06808")]
	public void TryRefreshQRCode()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x3D06900", Offset = "0x3D02900", VA = "0x3D06900")]
	private void RefreshQRCode(QRCodeState state, [Optional] Texture2D texture)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x3D06704", Offset = "0x3D02704", VA = "0x3D06704")]
	private void SetQRCodeState(QRCodeState state, [Optional] Texture2D texture)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x3D0698C", Offset = "0x3D0298C", VA = "0x3D0698C")]
	private void OnCopyBtnClick()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x3D06C14", Offset = "0x3D02C14", VA = "0x3D06C14")]
	private void OnRefreshBtnClick()
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x3D06994", Offset = "0x3D02994", VA = "0x3D06994")]
	private void CopyToClipboard(string ticket, string openId)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x3D06C30", Offset = "0x3D02C30", VA = "0x3D06C30")]
	public QRCodeObj()
	{
	}
}
