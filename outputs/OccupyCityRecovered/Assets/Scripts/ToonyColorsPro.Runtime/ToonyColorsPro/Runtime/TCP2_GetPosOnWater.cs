using Il2CppDummyDll;
using UnityEngine;

namespace ToonyColorsPro.Runtime
{
	[Token(Token = "0x2000005")]
	public class TCP2_GetPosOnWater : MonoBehaviour
	{
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		public Material WaterMaterial;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Height scale, for example if the water mesh is scaled along its Y axis")]
		public float heightScale;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x2C")]
		[Space]
		[Tooltip("Will make the object stick to the water plane")]
		public bool followWaterHeight;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Y Position offset")]
		public float heightOffset;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x34")]
		[Space]
		[Tooltip("Will align the object to the wave normal based on its position")]
		public bool followWaterNormal;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Determine the object's up axis (when following wave normal)")]
		public Vector3 upAxis;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Rotation of the object once it's been affected by the water normal")]
		public Vector3 postRotation;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		private bool isValid;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x54")]
		[HideInInspector]
		[SerializeField]
		private int sineCount;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x58")]
		private float[] sinePosOffsetsX;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x60")]
		private float[] sinePosOffsetsZ;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x68")]
		private float[] sinePhsOffsetsX;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x70")]
		private float[] sinePhsOffsetsZ;

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x7D5FF20", Offset = "0x7D5BF20", VA = "0x7D5FF20")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x7D6004C", Offset = "0x7D5C04C", VA = "0x7D6004C")]
		public Vector3 GetPositionOnWater(Vector3 worldPosition)
		{
			return default;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x7D607E4", Offset = "0x7D5C7E4", VA = "0x7D607E4")]
		public Vector3 GetNormalOnWater(Vector3 worldPosition)
		{
			return default;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x7D610C8", Offset = "0x7D5D0C8", VA = "0x7D610C8")]
		public TCP2_GetPosOnWater()
		{
		}
	}
}
