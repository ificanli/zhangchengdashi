using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x200002E")]
public class ChangeBattleFps : MonoBehaviour
{
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x20")]
	public TMP_Dropdown TMP_Dropdown;

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x3D04778", Offset = "0x3D00778", VA = "0x3D04778")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x3D0481C", Offset = "0x3D0081C", VA = "0x3D0481C")]
	private void OnDropdownValueChanged(int value)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x3D04904", Offset = "0x3D00904", VA = "0x3D04904")]
	public ChangeBattleFps()
	{
	}
}
