using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000018")]
public class MB3_BoneWeightCopier : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject inputGameObject;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject outputPrefab;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x30")]
	public float radius;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x38")]
	public SkinnedMeshRenderer seamMesh;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x40")]
	public string outputFolder;

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x743E994", Offset = "0x743A994", VA = "0x743E994")]
	public MB3_BoneWeightCopier()
	{
	}
}
