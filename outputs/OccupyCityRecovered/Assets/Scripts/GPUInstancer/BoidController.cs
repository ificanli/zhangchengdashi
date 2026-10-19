using GPUInstancer;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000002")]
public class BoidController : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	public static class BoidProperties
	{
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int BP_boidsData;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int BP_bufferSize;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int BP_controllerTransform;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int BP_controllerVelocity;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int BP_controllerVelocityVariation;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int BP_controllerRotationCoeff;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int BP_controllerNeighborDist;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int BP_time;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int BP_deltaTime;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x24")]
		public static readonly int BP_noiseTexture;
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	public int spawnCount;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x24")]
	public float spawnRadius;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	[Range(0.1f, 20f)]
	public float velocity;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x2C")]
	[Range(0f, 0.9f)]
	public float velocityVariation;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	[Range(0.1f, 20f)]
	public float rotationCoeff;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x34")]
	[Range(0.1f, 10f)]
	public float neighborDist;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x38")]
	public Transform centerTransform;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x40")]
	public Texture2D noiseTexture;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x48")]
	public string variationBufferName;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x50")]
	private Matrix4x4[] _spawnArray;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x58")]
	private Vector4[] _variationArray;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x60")]
	private GPUInstancerPrefabManager _prefabManager;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x68")]
	private ComputeShader _gpuiBoidsCS;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x70")]
	private float[] _centerTransformArray;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x78")]
	private ComputeBuffer _transformDataBuffer;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x73AAD00", Offset = "0x73A6D00", VA = "0x73AAD00")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x73AAEEC", Offset = "0x73A6EEC", VA = "0x73AAEEC")]
	public void Spawn(int index)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x73AB0A0", Offset = "0x73A70A0", VA = "0x73AB0A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x73AB400", Offset = "0x73A7400", VA = "0x73AB400")]
	public BoidController()
	{
	}
}
