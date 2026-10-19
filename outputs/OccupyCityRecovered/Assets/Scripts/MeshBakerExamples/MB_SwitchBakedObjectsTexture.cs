using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200000D")]
public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x20")]
	public MeshRenderer targetRenderer;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x28")]
	public Material[] materials;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x30")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x74C338C", Offset = "0x74BF38C", VA = "0x74C338C")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x74C3434", Offset = "0x74BF434", VA = "0x74C3434")]
	public void Start()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x74C34F8", Offset = "0x74BF4F8", VA = "0x74C34F8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x74C3758", Offset = "0x74BF758", VA = "0x74C3758")]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
