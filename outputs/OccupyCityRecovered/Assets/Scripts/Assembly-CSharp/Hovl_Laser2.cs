using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000006")]
public class Hovl_Laser2 : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x20")]
	public float laserScale;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x24")]
	public Color laserColor;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x38")]
	public GameObject HitEffect;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x40")]
	public GameObject FlashEffect;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x48")]
	public float HitOffset;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x4C")]
	public float MaxLength;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x50")]
	private bool UpdateSaver;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x58")]
	private ParticleSystem laserPS;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x60")]
	private ParticleSystem[] Flash;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x68")]
	private ParticleSystem[] Hit;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x70")]
	private Material laserMat;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x78")]
	private int particleCount;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x80")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x88")]
	private Vector3[] particlesPositions;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x90")]
	private float dissovleTimer;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x94")]
	private bool startDissovle;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x3CFD3E8", Offset = "0x3CF93E8", VA = "0x3CFD3E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x3CFD4E4", Offset = "0x3CF94E4", VA = "0x3CFD4E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x3CFDCBC", Offset = "0x3CF9CBC", VA = "0x3CFDCBC")]
	private void AddParticles()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x3CFC97C", Offset = "0x3CF897C", VA = "0x3CFC97C")]
	public void DisablePrepare()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3CFDE6C", Offset = "0x3CF9E6C", VA = "0x3CFDE6C")]
	public Hovl_Laser2()
	{
	}
}
