using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200003E")]
public class QRCodePreviewUI : MonoBehaviour
{
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x20")]
	public Button btn_close;

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x3D06C38", Offset = "0x3D02C38", VA = "0x3D06C38")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x3D06C3C", Offset = "0x3D02C3C", VA = "0x3D06C3C")]
	private void RegisterBtnEvent()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x3D06CCC", Offset = "0x3D02CCC", VA = "0x3D06CCC")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x3D06CF0", Offset = "0x3D02CF0", VA = "0x3D06CF0")]
	public QRCodePreviewUI()
	{
	}
}
