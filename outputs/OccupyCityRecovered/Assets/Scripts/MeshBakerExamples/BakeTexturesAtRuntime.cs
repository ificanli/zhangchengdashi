using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000002")]
public class BakeTexturesAtRuntime : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	public GameObject target;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x28")]
	private float elapsedTime;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x30")]
	private MB3_TextureCombiner.CreateAtlasesCoroutineResult result;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x74C0414", Offset = "0x74BC414", VA = "0x74C0414")]
	public string GetShaderNameForPipeline()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x74C04A0", Offset = "0x74BC4A0", VA = "0x74C04A0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x74C0A8C", Offset = "0x74BCA8C", VA = "0x74C0A8C")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x74C0C84", Offset = "0x74BCC84", VA = "0x74C0C84")]
	public BakeTexturesAtRuntime()
	{
	}
}
