using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000075")]
public class VersionText : MonoBehaviour
{
	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x20")]
	private TextMeshProUGUI textMesh;

	[Token(Token = "0x4000223")]
	[FieldOffset(Offset = "0x28")]
	private Text uguiText;

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x3D20578", Offset = "0x3D1C578", VA = "0x3D20578")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x3D20764", Offset = "0x3D1C764", VA = "0x3D20764")]
	public VersionText()
	{
	}
}
