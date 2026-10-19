using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000005")]
public class Hovl_Laser : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x20")]
	public int damageOverTime;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HitEffect;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x30")]
	public float HitOffset;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x34")]
	public bool useLaserRotation;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x38")]
	public float MaxLength;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x40")]
	private LineRenderer Laser;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x48")]
	public float MainTextureLength;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x4C")]
	public float NoiseTextureLength;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x50")]
	private Vector4 Length;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x60")]
	private bool LaserSaver;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x61")]
	private bool UpdateSaver;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x68")]
	private ParticleSystem[] Effects;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x70")]
	private ParticleSystem[] Hit;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x3CFCC34", Offset = "0x3CF8C34", VA = "0x3CFCC34")]
	private void Start()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x3CFCCE0", Offset = "0x3CF8CE0", VA = "0x3CFCCE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x3CFC890", Offset = "0x3CF8890", VA = "0x3CFC890")]
	public void DisablePrepare()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x3CFD3C8", Offset = "0x3CF93C8", VA = "0x3CFD3C8")]
	public Hovl_Laser()
	{
	}
}
