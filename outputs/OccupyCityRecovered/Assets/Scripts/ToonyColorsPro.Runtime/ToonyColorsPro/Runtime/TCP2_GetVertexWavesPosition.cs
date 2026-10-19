using Il2CppDummyDll;
using UnityEngine;

namespace ToonyColorsPro.Runtime
{
	[Token(Token = "0x2000006")]
	public class TCP2_GetVertexWavesPosition : MonoBehaviour
	{
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x20")]
		public Transform WaterPlane;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Will make the object stick to the water plane")]
		[Space]
		public bool followWaterHeight;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x2C")]
		public float heightOffset;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x30")]
		[Space]
		[Tooltip("Will align the object to the wave normal based on its position")]
		public bool followWaterNormal;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Determine the object's up axis (when following wave normal)")]
		public Vector3 upAxis;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Rotation of the object once it's been affected by the water normal")]
		public Vector3 postRotation;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x4C")]
		[Header("Water Shader Configuration")]
		[Space]
		public int sineCount;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x50")]
		[Space]
		public float WavesSpeed;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x54")]
		public float WavesHeight;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x58")]
		public float WavesFrequency;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x5C")]
		[Space]
		public bool useCustomTime;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x5D")]
		public bool customSineValues;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Vector4 sinOffsets1;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public Vector4 phaseOffsets1;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x80")]
		[HideInInspector]
		public Vector4 sinOffsets2;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public Vector4 phaseOffsets2;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector4 sinOffsets3;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public Vector4 phaseOffsets3;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		public Vector4 sinOffsets4;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		public Vector4 phaseOffsets4;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _Time;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x4")]
		private static int LastFrameTimeSampling;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x8")]
		private static float ShaderTime;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x7D61210", Offset = "0x7D5D210", VA = "0x7D61210")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x7D61B30", Offset = "0x7D5DB30", VA = "0x7D61B30")]
		private Vector4 CalculateSinePosition(float v1, float v2, Vector4 sinOffsets, Vector4 phaseOffsets, ref float phase)
		{
			return default;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x7D61BDC", Offset = "0x7D5DBDC", VA = "0x7D61BDC")]
		private Vector4 CalculateSineNormal(float v1, float v2, Vector4 sinOffsets, Vector4 phaseOffsets, ref float phase)
		{
			return default;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x7D61440", Offset = "0x7D5D440", VA = "0x7D61440")]
		public Vector3 GetPositionOnWater_SG2(float time, Vector3 worldPosition)
		{
			return default;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x7D61778", Offset = "0x7D5D778", VA = "0x7D61778")]
		public Vector3 GetNormalOnWater_SG2(float time, Vector3 worldPosition)
		{
			return default;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x7D61C9C", Offset = "0x7D5DC9C", VA = "0x7D61C9C")]
		public TCP2_GetVertexWavesPosition()
		{
		}
	}
}
