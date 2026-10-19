using GPUInstancer.CrowdAnimations;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000AE")]
public class GPUInstanceSetColorBehaviour : MonoBehaviour
{
	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x20")]
	private Material baseMaterial;

	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x28")]
	private GPUICrowdPrefab _gpuiCrowdPrefab;

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x3E2F814", Offset = "0x3E2B814", VA = "0x3E2F814")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x3E2F874", Offset = "0x3E2B874", VA = "0x3E2F874")]
	public void ChangeColor(Color color)
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x3E2F9FC", Offset = "0x3E2B9FC", VA = "0x3E2F9FC")]
	public void ChangeMaterial(Material material)
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x3E2FA9C", Offset = "0x3E2BA9C", VA = "0x3E2FA9C")]
	public GPUInstanceSetColorBehaviour()
	{
	}
}
