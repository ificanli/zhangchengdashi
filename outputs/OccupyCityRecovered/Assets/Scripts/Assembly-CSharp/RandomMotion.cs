using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000085")]
public class RandomMotion : MonoBehaviour
{
	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x20")]
	public float positionFrequency;

	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0x24")]
	public float positionAmplitude;

	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 positionScale;

	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x34")]
	[Range(0f, 8f)]
	public int positionFractalLevel;

	[Token(Token = "0x4000295")]
	private const float fbmNorm = 1.3333334f;

	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 initialPosition;

	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x48")]
	private float[] time;

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x3D22968", Offset = "0x3D1E968", VA = "0x3D22968")]
	public void RecalculateTime()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x3D229D4", Offset = "0x3D1E9D4", VA = "0x3D229D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x3D22A28", Offset = "0x3D1EA28", VA = "0x3D22A28")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x3D22A58", Offset = "0x3D1EA58", VA = "0x3D22A58")]
	private void Update()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x3D22B98", Offset = "0x3D1EB98", VA = "0x3D22B98")]
	public RandomMotion()
	{
	}
}
