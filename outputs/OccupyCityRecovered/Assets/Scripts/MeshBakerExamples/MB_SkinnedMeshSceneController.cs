using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200000C")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x20")]
	public GameObject swordPrefab;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x28")]
	public GameObject hatPrefab;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x30")]
	public GameObject glassesPrefab;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x38")]
	public GameObject workerPrefab;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x40")]
	public GameObject targetCharacter;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x48")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x50")]
	private GameObject swordInstance;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x58")]
	private GameObject glassesInstance;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x60")]
	private GameObject hatInstance;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x74C22B0", Offset = "0x74BE2B0", VA = "0x74C22B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x74C24DC", Offset = "0x74BE4DC", VA = "0x74C24DC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x74C3278", Offset = "0x74BF278", VA = "0x74C3278")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x74C3384", Offset = "0x74BF384", VA = "0x74C3384")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
