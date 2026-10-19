using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000008")]
public class MB_Example : MonoBehaviour
{
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x20")]
	public MB3_MeshBaker meshbaker;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] objsToCombine;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x74C1F3C", Offset = "0x74BDF3C", VA = "0x74C1F3C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x74C1F98", Offset = "0x74BDF98", VA = "0x74C1F98")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x74C201C", Offset = "0x74BE01C", VA = "0x74C201C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x74C20C4", Offset = "0x74BE0C4", VA = "0x74C20C4")]
	public MB_Example()
	{
	}
}
