using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000074")]
public class UserIDText : MonoBehaviour
{
	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x20")]
	public Button CopyBtn;

	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x28")]
	private TextMeshProUGUI textMesh;

	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x30")]
	private Text uguiText;

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x3D20320", Offset = "0x3D1C320", VA = "0x3D20320")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x3D204DC", Offset = "0x3D1C4DC", VA = "0x3D204DC")]
	public void OnCopyBtnClick()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x3D20570", Offset = "0x3D1C570", VA = "0x3D20570")]
	public UserIDText()
	{
	}
}
