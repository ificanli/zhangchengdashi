using Il2CppDummyDll;
using UnityEngine;

namespace GPUInstancer
{
	[Token(Token = "0x2000051")]
	public class GPUInstancerTerrainSettings : ScriptableObject
	{
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x18")]
		public string terrainDataGUID;

		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x20")]
		public float maxDetailDistance;

		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x24")]
		public float maxTreeDistance;

		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 windVector;

		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D healthyDryNoiseTexture;

		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D windWaveNormalTexture;

		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x40")]
		public bool autoSPCellSize;

		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x44")]
		[Range(25f, 500f)]
		public int preferedSPCellSize;

		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float detailDensity;

		[Token(Token = "0x4000361")]
		[FieldOffset(Offset = "0x50")]
		public string warningText;

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x73E1D20", Offset = "0x73DDD20", VA = "0x73E1D20")]
		public Texture2D GetHealthyDryNoiseTexture(GPUInstancerDetailPrototype detailPrototype)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x73E1DA8", Offset = "0x73DDDA8", VA = "0x73E1DA8")]
		public GPUInstancerTerrainSettings()
		{
		}
	}
}
