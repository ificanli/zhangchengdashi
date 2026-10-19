using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000004")]
public class MB_SwapShirts : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x20")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x28")]
	public Renderer[] clothingAndBodyPartsBareTorso;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x30")]
	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x38")]
	public Renderer[] clothingAndBodyPartsHoodie;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x74C0D94", Offset = "0x74BCD94", VA = "0x74C0D94")]
	private void Start()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x74C0EB8", Offset = "0x74BCEB8", VA = "0x74C0EB8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x74C1080", Offset = "0x74BD080", VA = "0x74C1080")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x74C16BC", Offset = "0x74BD6BC", VA = "0x74C16BC")]
	public MB_SwapShirts()
	{
	}
}
