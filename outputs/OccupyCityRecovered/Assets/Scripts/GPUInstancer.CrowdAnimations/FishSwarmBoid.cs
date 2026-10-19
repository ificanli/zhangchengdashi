using GPUInstancer.CrowdAnimations;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000002")]
public class FishSwarmBoid : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	public static class BoidProperties
	{
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int BP_boidsData;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int BP_bufferSize;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int BP_controllerTransform;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0xC")]
		public static readonly int BP_controllerVelocity;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int BP_controllerVelocityVariation;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x14")]
		public static readonly int BP_controllerRotationCoeff;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int BP_controllerNeighborDist;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly int BP_time;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int BP_deltaTime;

		[Token(Token = "0x400001E")]
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
	private Matrix4x4[] _spawnArray;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x40")]
	private Vector4[] _variationArray;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x48")]
	public Transform centerTransform;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x50")]
	public Texture2D noiseTexture;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x58")]
	private GPUICrowdManager _crowdManager;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x60")]
	private GPUICrowdPrototype _prototype;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x68")]
	private GPUICrowdRuntimeData _runtimeData;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x70")]
	private GPUICrowdAnimator[] _animators;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x78")]
	private ComputeShader _gpuiBoidsCS;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x80")]
	private string _variationBufferName;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x88")]
	private float[] _centerTransformArray;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x90")]
	private ComputeBuffer _transformDataBuffer;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x98")]
	private float _nextTargetMoveTime;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x9C")]
	public float targetMovePeriod;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x73BD384", Offset = "0x73B9384", VA = "0x73BD384")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x73BD748", Offset = "0x73B9748", VA = "0x73BD748")]
	public void Spawn(int index)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x73BE164", Offset = "0x73BA164", VA = "0x73BE164")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x73BE580", Offset = "0x73BA580", VA = "0x73BE580")]
	public FishSwarmBoid()
	{
	}
}
