using Il2CppDummyDll;
using StylizedWater;
using UnityEngine;

[Token(Token = "0x200002C")]
[RequireComponent(typeof(Rigidbody))]
public class BuoyantObject : MonoBehaviour
{
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x20")]
	private Color red;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x30")]
	private Color green;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x40")]
	private Color blue;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x50")]
	private Color orange;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x60")]
	private float steepness;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x64")]
	private float wavelength;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x68")]
	private float speed;

	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x70")]
	private float[] directions;

	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x78")]
	[Header("Water Object")]
	public StylizedWaterURP water;

	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x80")]
	[Header("Buoyancy")]
	[Range(1f, 5f)]
	public float strength;

	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x84")]
	[Range(0.2f, 5f)]
	public float objectDepth;

	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x88")]
	public float velocityDrag;

	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x8C")]
	public float angularDrag;

	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x90")]
	[Header("Effectors")]
	public Transform[] effectors;

	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x98")]
	private Rigidbody rb;

	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3[] effectorProjections;

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x3D03A5C", Offset = "0x3CFFA5C", VA = "0x3D03A5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x3D03B8C", Offset = "0x3CFFB8C", VA = "0x3D03B8C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x3D03BAC", Offset = "0x3CFFBAC", VA = "0x3D03BAC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x3D03EDC", Offset = "0x3CFFEDC", VA = "0x3D03EDC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x3D041D8", Offset = "0x3D001D8", VA = "0x3D041D8")]
	public BuoyantObject()
	{
	}
}
