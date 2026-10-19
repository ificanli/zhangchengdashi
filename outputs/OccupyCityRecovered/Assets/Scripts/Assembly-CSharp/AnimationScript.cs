using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200007D")]
public class AnimationScript : MonoBehaviour
{
	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x20")]
	public bool isAnimated;

	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x21")]
	public bool isRotating;

	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x22")]
	public bool isFloating;

	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x23")]
	public bool isScaling;

	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 rotationAngle;

	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x30")]
	public float rotationSpeed;

	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x34")]
	public float floatSpeed;

	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x38")]
	private bool goingUp;

	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x3C")]
	public float floatRate;

	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x40")]
	private float floatTimer;

	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 startScale;

	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 endScale;

	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x5C")]
	private bool scalingUp;

	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x60")]
	public float scaleSpeed;

	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x64")]
	public float scaleRate;

	[Token(Token = "0x400025B")]
	[FieldOffset(Offset = "0x68")]
	private float scaleTimer;

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x3D22308", Offset = "0x3D1E308", VA = "0x3D22308")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x3D2230C", Offset = "0x3D1E30C", VA = "0x3D2230C")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x3D22504", Offset = "0x3D1E504", VA = "0x3D22504")]
	public AnimationScript()
	{
	}
}
