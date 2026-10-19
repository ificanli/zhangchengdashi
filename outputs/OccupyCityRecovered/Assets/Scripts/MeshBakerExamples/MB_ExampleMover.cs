using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000009")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x20")]
	public int axis;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x74C20CC", Offset = "0x74BE0CC", VA = "0x74C20CC")]
	private void Update()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x74C21F0", Offset = "0x74BE1F0", VA = "0x74C21F0")]
	public MB_ExampleMover()
	{
	}
}
