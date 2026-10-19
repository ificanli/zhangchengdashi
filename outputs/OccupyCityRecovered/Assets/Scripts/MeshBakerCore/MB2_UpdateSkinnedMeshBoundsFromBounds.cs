using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000015")]
public class MB2_UpdateSkinnedMeshBoundsFromBounds : MonoBehaviour
{
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> objects;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x28")]
	private SkinnedMeshRenderer smr;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x743E33C", Offset = "0x743A33C", VA = "0x743E33C")]
	private void Start()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x743E5FC", Offset = "0x743A5FC", VA = "0x743E5FC")]
	private void Update()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x743E89C", Offset = "0x743A89C", VA = "0x743E89C")]
	public MB2_UpdateSkinnedMeshBoundsFromBounds()
	{
	}
}
